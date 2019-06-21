// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzureBatchai.json
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
    public static partial class AzureBatchaiTasks
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public static string AzureBatchaiPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREBATCHAI_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureBatchaiLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Batch AI resources.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchai(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureBatchaiPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureBatchaiLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiListUsages(AzureBatchaiListUsagesSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiListUsagesSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiListUsagesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiListUsagesSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureBatchaiListUsagesSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiListUsagesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiListUsagesSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiListUsagesSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiListUsagesSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiListUsages(Configure<AzureBatchaiListUsagesSettings> configurator)
        {
            return AzureBatchaiListUsages(configurator(new AzureBatchaiListUsagesSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiListUsagesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiListUsagesSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureBatchaiListUsagesSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiListUsagesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiListUsagesSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiListUsagesSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiListUsagesSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiListUsagesSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiListUsages(CombinatorialConfigure<AzureBatchaiListUsagesSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiListUsages, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterAutoScale(AzureBatchaiClusterAutoScaleSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiClusterAutoScaleSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Ids"/></li>
        ///     <li><c>--max</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Max"/></li>
        ///     <li><c>--min</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Min"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterAutoScale(Configure<AzureBatchaiClusterAutoScaleSettings> configurator)
        {
            return AzureBatchaiClusterAutoScale(configurator(new AzureBatchaiClusterAutoScaleSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Ids"/></li>
        ///     <li><c>--max</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Max"/></li>
        ///     <li><c>--min</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Min"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterAutoScaleSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiClusterAutoScaleSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiClusterAutoScale(CombinatorialConfigure<AzureBatchaiClusterAutoScaleSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiClusterAutoScale, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterCreate(AzureBatchaiClusterCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiClusterCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--afs-mount-path</c> via <see cref="AzureBatchaiClusterCreateSettings.AfsMountPath"/></li>
        ///     <li><c>--afs-name</c> via <see cref="AzureBatchaiClusterCreateSettings.AfsName"/></li>
        ///     <li><c>--bfs-mount-path</c> via <see cref="AzureBatchaiClusterCreateSettings.BfsMountPath"/></li>
        ///     <li><c>--bfs-name</c> via <see cref="AzureBatchaiClusterCreateSettings.BfsName"/></li>
        ///     <li><c>--config-file</c> via <see cref="AzureBatchaiClusterCreateSettings.ConfigFile"/></li>
        ///     <li><c>--custom-image</c> via <see cref="AzureBatchaiClusterCreateSettings.CustomImage"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterCreateSettings.Debug"/></li>
        ///     <li><c>--generate-ssh-keys</c> via <see cref="AzureBatchaiClusterCreateSettings.GenerateSshKeys"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterCreateSettings.Help"/></li>
        ///     <li><c>--image</c> via <see cref="AzureBatchaiClusterCreateSettings.Image"/></li>
        ///     <li><c>--max</c> via <see cref="AzureBatchaiClusterCreateSettings.Max"/></li>
        ///     <li><c>--min</c> via <see cref="AzureBatchaiClusterCreateSettings.Min"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiClusterCreateSettings.Name"/></li>
        ///     <li><c>--nfs</c> via <see cref="AzureBatchaiClusterCreateSettings.Nfs"/></li>
        ///     <li><c>--nfs-mount-path</c> via <see cref="AzureBatchaiClusterCreateSettings.NfsMountPath"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterCreateSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureBatchaiClusterCreateSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--setup-task</c> via <see cref="AzureBatchaiClusterCreateSettings.SetupTask"/></li>
        ///     <li><c>--setup-task-output</c> via <see cref="AzureBatchaiClusterCreateSettings.SetupTaskOutput"/></li>
        ///     <li><c>--ssh-key</c> via <see cref="AzureBatchaiClusterCreateSettings.SshKey"/></li>
        ///     <li><c>--storage-account-key</c> via <see cref="AzureBatchaiClusterCreateSettings.StorageAccountKey"/></li>
        ///     <li><c>--storage-account-name</c> via <see cref="AzureBatchaiClusterCreateSettings.StorageAccountName"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureBatchaiClusterCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterCreateSettings.Subscription"/></li>
        ///     <li><c>--target</c> via <see cref="AzureBatchaiClusterCreateSettings.Target"/></li>
        ///     <li><c>--use-auto-storage</c> via <see cref="AzureBatchaiClusterCreateSettings.UseAutoStorage"/></li>
        ///     <li><c>--user-name</c> via <see cref="AzureBatchaiClusterCreateSettings.UserName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterCreateSettings.Verbose"/></li>
        ///     <li><c>--vm-priority</c> via <see cref="AzureBatchaiClusterCreateSettings.VmPriority"/></li>
        ///     <li><c>--vm-size</c> via <see cref="AzureBatchaiClusterCreateSettings.VmSize"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterCreateSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterCreate(Configure<AzureBatchaiClusterCreateSettings> configurator)
        {
            return AzureBatchaiClusterCreate(configurator(new AzureBatchaiClusterCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--afs-mount-path</c> via <see cref="AzureBatchaiClusterCreateSettings.AfsMountPath"/></li>
        ///     <li><c>--afs-name</c> via <see cref="AzureBatchaiClusterCreateSettings.AfsName"/></li>
        ///     <li><c>--bfs-mount-path</c> via <see cref="AzureBatchaiClusterCreateSettings.BfsMountPath"/></li>
        ///     <li><c>--bfs-name</c> via <see cref="AzureBatchaiClusterCreateSettings.BfsName"/></li>
        ///     <li><c>--config-file</c> via <see cref="AzureBatchaiClusterCreateSettings.ConfigFile"/></li>
        ///     <li><c>--custom-image</c> via <see cref="AzureBatchaiClusterCreateSettings.CustomImage"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterCreateSettings.Debug"/></li>
        ///     <li><c>--generate-ssh-keys</c> via <see cref="AzureBatchaiClusterCreateSettings.GenerateSshKeys"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterCreateSettings.Help"/></li>
        ///     <li><c>--image</c> via <see cref="AzureBatchaiClusterCreateSettings.Image"/></li>
        ///     <li><c>--max</c> via <see cref="AzureBatchaiClusterCreateSettings.Max"/></li>
        ///     <li><c>--min</c> via <see cref="AzureBatchaiClusterCreateSettings.Min"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiClusterCreateSettings.Name"/></li>
        ///     <li><c>--nfs</c> via <see cref="AzureBatchaiClusterCreateSettings.Nfs"/></li>
        ///     <li><c>--nfs-mount-path</c> via <see cref="AzureBatchaiClusterCreateSettings.NfsMountPath"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterCreateSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureBatchaiClusterCreateSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--setup-task</c> via <see cref="AzureBatchaiClusterCreateSettings.SetupTask"/></li>
        ///     <li><c>--setup-task-output</c> via <see cref="AzureBatchaiClusterCreateSettings.SetupTaskOutput"/></li>
        ///     <li><c>--ssh-key</c> via <see cref="AzureBatchaiClusterCreateSettings.SshKey"/></li>
        ///     <li><c>--storage-account-key</c> via <see cref="AzureBatchaiClusterCreateSettings.StorageAccountKey"/></li>
        ///     <li><c>--storage-account-name</c> via <see cref="AzureBatchaiClusterCreateSettings.StorageAccountName"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureBatchaiClusterCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterCreateSettings.Subscription"/></li>
        ///     <li><c>--target</c> via <see cref="AzureBatchaiClusterCreateSettings.Target"/></li>
        ///     <li><c>--use-auto-storage</c> via <see cref="AzureBatchaiClusterCreateSettings.UseAutoStorage"/></li>
        ///     <li><c>--user-name</c> via <see cref="AzureBatchaiClusterCreateSettings.UserName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterCreateSettings.Verbose"/></li>
        ///     <li><c>--vm-priority</c> via <see cref="AzureBatchaiClusterCreateSettings.VmPriority"/></li>
        ///     <li><c>--vm-size</c> via <see cref="AzureBatchaiClusterCreateSettings.VmSize"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterCreateSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiClusterCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiClusterCreate(CombinatorialConfigure<AzureBatchaiClusterCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiClusterCreate, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterDelete(AzureBatchaiClusterDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiClusterDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiClusterDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiClusterDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiClusterDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterDeleteSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterDeleteSettings.Workspace"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBatchaiClusterDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterDelete(Configure<AzureBatchaiClusterDeleteSettings> configurator)
        {
            return AzureBatchaiClusterDelete(configurator(new AzureBatchaiClusterDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiClusterDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiClusterDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiClusterDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterDeleteSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterDeleteSettings.Workspace"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBatchaiClusterDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiClusterDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiClusterDelete(CombinatorialConfigure<AzureBatchaiClusterDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiClusterDelete, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterList(AzureBatchaiClusterListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiClusterListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterList(Configure<AzureBatchaiClusterListSettings> configurator)
        {
            return AzureBatchaiClusterList(configurator(new AzureBatchaiClusterListSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiClusterListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiClusterList(CombinatorialConfigure<AzureBatchaiClusterListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiClusterList, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterResize(AzureBatchaiClusterResizeSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiClusterResizeSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterResizeSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterResizeSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiClusterResizeSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiClusterResizeSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterResizeSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterResizeSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterResizeSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterResizeSettings.Subscription"/></li>
        ///     <li><c>--target</c> via <see cref="AzureBatchaiClusterResizeSettings.Target"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterResizeSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterResizeSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterResize(Configure<AzureBatchaiClusterResizeSettings> configurator)
        {
            return AzureBatchaiClusterResize(configurator(new AzureBatchaiClusterResizeSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterResizeSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterResizeSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiClusterResizeSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiClusterResizeSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterResizeSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterResizeSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterResizeSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterResizeSettings.Subscription"/></li>
        ///     <li><c>--target</c> via <see cref="AzureBatchaiClusterResizeSettings.Target"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterResizeSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterResizeSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiClusterResizeSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiClusterResize(CombinatorialConfigure<AzureBatchaiClusterResizeSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiClusterResize, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterShow(AzureBatchaiClusterShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiClusterShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiClusterShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiClusterShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterShowSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterShowSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterShow(Configure<AzureBatchaiClusterShowSettings> configurator)
        {
            return AzureBatchaiClusterShow(configurator(new AzureBatchaiClusterShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiClusterShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiClusterShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterShowSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterShowSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiClusterShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiClusterShow(CombinatorialConfigure<AzureBatchaiClusterShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiClusterShow, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiExperimentCreate(AzureBatchaiExperimentCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiExperimentCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiExperimentCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiExperimentCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiExperimentCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiExperimentCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiExperimentCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiExperimentCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiExperimentCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiExperimentCreateSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiExperimentCreateSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiExperimentCreate(Configure<AzureBatchaiExperimentCreateSettings> configurator)
        {
            return AzureBatchaiExperimentCreate(configurator(new AzureBatchaiExperimentCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiExperimentCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiExperimentCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiExperimentCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiExperimentCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiExperimentCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiExperimentCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiExperimentCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiExperimentCreateSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiExperimentCreateSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiExperimentCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiExperimentCreate(CombinatorialConfigure<AzureBatchaiExperimentCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiExperimentCreate, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiExperimentDelete(AzureBatchaiExperimentDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiExperimentDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiExperimentDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiExperimentDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Workspace"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiExperimentDelete(Configure<AzureBatchaiExperimentDeleteSettings> configurator)
        {
            return AzureBatchaiExperimentDelete(configurator(new AzureBatchaiExperimentDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiExperimentDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiExperimentDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Workspace"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBatchaiExperimentDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiExperimentDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiExperimentDelete(CombinatorialConfigure<AzureBatchaiExperimentDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiExperimentDelete, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiExperimentList(AzureBatchaiExperimentListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiExperimentListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiExperimentListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiExperimentListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiExperimentListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiExperimentListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiExperimentListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiExperimentListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiExperimentListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiExperimentListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiExperimentList(Configure<AzureBatchaiExperimentListSettings> configurator)
        {
            return AzureBatchaiExperimentList(configurator(new AzureBatchaiExperimentListSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiExperimentListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiExperimentListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiExperimentListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiExperimentListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiExperimentListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiExperimentListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiExperimentListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiExperimentListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiExperimentListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiExperimentList(CombinatorialConfigure<AzureBatchaiExperimentListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiExperimentList, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiExperimentShow(AzureBatchaiExperimentShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiExperimentShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiExperimentShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiExperimentShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiExperimentShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiExperimentShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiExperimentShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiExperimentShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiExperimentShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiExperimentShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiExperimentShowSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiExperimentShowSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiExperimentShow(Configure<AzureBatchaiExperimentShowSettings> configurator)
        {
            return AzureBatchaiExperimentShow(configurator(new AzureBatchaiExperimentShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiExperimentShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiExperimentShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiExperimentShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiExperimentShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiExperimentShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiExperimentShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiExperimentShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiExperimentShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiExperimentShowSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiExperimentShowSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiExperimentShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiExperimentShow(CombinatorialConfigure<AzureBatchaiExperimentShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiExperimentShow, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiFileServerCreate(AzureBatchaiFileServerCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiFileServerCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--caching-type</c> via <see cref="AzureBatchaiFileServerCreateSettings.CachingType"/></li>
        ///     <li><c>--config-file</c> via <see cref="AzureBatchaiFileServerCreateSettings.ConfigFile"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiFileServerCreateSettings.Debug"/></li>
        ///     <li><c>--disk-count</c> via <see cref="AzureBatchaiFileServerCreateSettings.DiskCount"/></li>
        ///     <li><c>--disk-size</c> via <see cref="AzureBatchaiFileServerCreateSettings.DiskSize"/></li>
        ///     <li><c>--generate-ssh-keys</c> via <see cref="AzureBatchaiFileServerCreateSettings.GenerateSshKeys"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiFileServerCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiFileServerCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiFileServerCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiFileServerCreateSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureBatchaiFileServerCreateSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiFileServerCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiFileServerCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-key</c> via <see cref="AzureBatchaiFileServerCreateSettings.SshKey"/></li>
        ///     <li><c>--storage-sku</c> via <see cref="AzureBatchaiFileServerCreateSettings.StorageSku"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureBatchaiFileServerCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiFileServerCreateSettings.Subscription"/></li>
        ///     <li><c>--user-name</c> via <see cref="AzureBatchaiFileServerCreateSettings.UserName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiFileServerCreateSettings.Verbose"/></li>
        ///     <li><c>--vm-size</c> via <see cref="AzureBatchaiFileServerCreateSettings.VmSize"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiFileServerCreateSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiFileServerCreate(Configure<AzureBatchaiFileServerCreateSettings> configurator)
        {
            return AzureBatchaiFileServerCreate(configurator(new AzureBatchaiFileServerCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--caching-type</c> via <see cref="AzureBatchaiFileServerCreateSettings.CachingType"/></li>
        ///     <li><c>--config-file</c> via <see cref="AzureBatchaiFileServerCreateSettings.ConfigFile"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiFileServerCreateSettings.Debug"/></li>
        ///     <li><c>--disk-count</c> via <see cref="AzureBatchaiFileServerCreateSettings.DiskCount"/></li>
        ///     <li><c>--disk-size</c> via <see cref="AzureBatchaiFileServerCreateSettings.DiskSize"/></li>
        ///     <li><c>--generate-ssh-keys</c> via <see cref="AzureBatchaiFileServerCreateSettings.GenerateSshKeys"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiFileServerCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiFileServerCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiFileServerCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiFileServerCreateSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureBatchaiFileServerCreateSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiFileServerCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiFileServerCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-key</c> via <see cref="AzureBatchaiFileServerCreateSettings.SshKey"/></li>
        ///     <li><c>--storage-sku</c> via <see cref="AzureBatchaiFileServerCreateSettings.StorageSku"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureBatchaiFileServerCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiFileServerCreateSettings.Subscription"/></li>
        ///     <li><c>--user-name</c> via <see cref="AzureBatchaiFileServerCreateSettings.UserName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiFileServerCreateSettings.Verbose"/></li>
        ///     <li><c>--vm-size</c> via <see cref="AzureBatchaiFileServerCreateSettings.VmSize"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiFileServerCreateSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiFileServerCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiFileServerCreate(CombinatorialConfigure<AzureBatchaiFileServerCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiFileServerCreate, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiFileServerDelete(AzureBatchaiFileServerDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiFileServerDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiFileServerDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiFileServerDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Workspace"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiFileServerDelete(Configure<AzureBatchaiFileServerDeleteSettings> configurator)
        {
            return AzureBatchaiFileServerDelete(configurator(new AzureBatchaiFileServerDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiFileServerDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiFileServerDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Workspace"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBatchaiFileServerDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiFileServerDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiFileServerDelete(CombinatorialConfigure<AzureBatchaiFileServerDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiFileServerDelete, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiFileServerList(AzureBatchaiFileServerListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiFileServerListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiFileServerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiFileServerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiFileServerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiFileServerListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiFileServerListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiFileServerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiFileServerListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiFileServerListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiFileServerList(Configure<AzureBatchaiFileServerListSettings> configurator)
        {
            return AzureBatchaiFileServerList(configurator(new AzureBatchaiFileServerListSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiFileServerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiFileServerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiFileServerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiFileServerListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiFileServerListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiFileServerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiFileServerListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiFileServerListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiFileServerListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiFileServerList(CombinatorialConfigure<AzureBatchaiFileServerListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiFileServerList, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiFileServerShow(AzureBatchaiFileServerShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiFileServerShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiFileServerShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiFileServerShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiFileServerShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiFileServerShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiFileServerShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiFileServerShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiFileServerShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiFileServerShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiFileServerShowSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiFileServerShowSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiFileServerShow(Configure<AzureBatchaiFileServerShowSettings> configurator)
        {
            return AzureBatchaiFileServerShow(configurator(new AzureBatchaiFileServerShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiFileServerShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiFileServerShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiFileServerShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiFileServerShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiFileServerShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiFileServerShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiFileServerShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiFileServerShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiFileServerShowSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiFileServerShowSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiFileServerShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiFileServerShow(CombinatorialConfigure<AzureBatchaiFileServerShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiFileServerShow, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobCreate(AzureBatchaiJobCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiJobCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--afs-mount-path</c> via <see cref="AzureBatchaiJobCreateSettings.AfsMountPath"/></li>
        ///     <li><c>--afs-name</c> via <see cref="AzureBatchaiJobCreateSettings.AfsName"/></li>
        ///     <li><c>--bfs-mount-path</c> via <see cref="AzureBatchaiJobCreateSettings.BfsMountPath"/></li>
        ///     <li><c>--bfs-name</c> via <see cref="AzureBatchaiJobCreateSettings.BfsName"/></li>
        ///     <li><c>--cluster</c> via <see cref="AzureBatchaiJobCreateSettings.Cluster"/></li>
        ///     <li><c>--config-file</c> via <see cref="AzureBatchaiJobCreateSettings.ConfigFile"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobCreateSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobCreateSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiJobCreateSettings.Name"/></li>
        ///     <li><c>--nfs</c> via <see cref="AzureBatchaiJobCreateSettings.Nfs"/></li>
        ///     <li><c>--nfs-mount-path</c> via <see cref="AzureBatchaiJobCreateSettings.NfsMountPath"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--storage-account-key</c> via <see cref="AzureBatchaiJobCreateSettings.StorageAccountKey"/></li>
        ///     <li><c>--storage-account-name</c> via <see cref="AzureBatchaiJobCreateSettings.StorageAccountName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobCreateSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobCreateSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiJobCreate(Configure<AzureBatchaiJobCreateSettings> configurator)
        {
            return AzureBatchaiJobCreate(configurator(new AzureBatchaiJobCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--afs-mount-path</c> via <see cref="AzureBatchaiJobCreateSettings.AfsMountPath"/></li>
        ///     <li><c>--afs-name</c> via <see cref="AzureBatchaiJobCreateSettings.AfsName"/></li>
        ///     <li><c>--bfs-mount-path</c> via <see cref="AzureBatchaiJobCreateSettings.BfsMountPath"/></li>
        ///     <li><c>--bfs-name</c> via <see cref="AzureBatchaiJobCreateSettings.BfsName"/></li>
        ///     <li><c>--cluster</c> via <see cref="AzureBatchaiJobCreateSettings.Cluster"/></li>
        ///     <li><c>--config-file</c> via <see cref="AzureBatchaiJobCreateSettings.ConfigFile"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobCreateSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobCreateSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiJobCreateSettings.Name"/></li>
        ///     <li><c>--nfs</c> via <see cref="AzureBatchaiJobCreateSettings.Nfs"/></li>
        ///     <li><c>--nfs-mount-path</c> via <see cref="AzureBatchaiJobCreateSettings.NfsMountPath"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--storage-account-key</c> via <see cref="AzureBatchaiJobCreateSettings.StorageAccountKey"/></li>
        ///     <li><c>--storage-account-name</c> via <see cref="AzureBatchaiJobCreateSettings.StorageAccountName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobCreateSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobCreateSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiJobCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiJobCreate(CombinatorialConfigure<AzureBatchaiJobCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiJobCreate, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobDelete(AzureBatchaiJobDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiJobDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobDeleteSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobDeleteSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiJobDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiJobDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiJobDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobDeleteSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobDeleteSettings.Workspace"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBatchaiJobDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiJobDelete(Configure<AzureBatchaiJobDeleteSettings> configurator)
        {
            return AzureBatchaiJobDelete(configurator(new AzureBatchaiJobDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobDeleteSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobDeleteSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiJobDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiJobDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiJobDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobDeleteSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobDeleteSettings.Workspace"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBatchaiJobDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiJobDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiJobDelete(CombinatorialConfigure<AzureBatchaiJobDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiJobDelete, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobList(AzureBatchaiJobListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiJobListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobListSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobListSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiJobList(Configure<AzureBatchaiJobListSettings> configurator)
        {
            return AzureBatchaiJobList(configurator(new AzureBatchaiJobListSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobListSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobListSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiJobListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiJobList(CombinatorialConfigure<AzureBatchaiJobListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiJobList, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobShow(AzureBatchaiJobShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiJobShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobShowSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobShowSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiJobShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiJobShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobShowSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobShowSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiJobShow(Configure<AzureBatchaiJobShowSettings> configurator)
        {
            return AzureBatchaiJobShow(configurator(new AzureBatchaiJobShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobShowSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobShowSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiJobShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiJobShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobShowSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobShowSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiJobShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiJobShow(CombinatorialConfigure<AzureBatchaiJobShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiJobShow, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobTerminate(AzureBatchaiJobTerminateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiJobTerminateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobTerminateSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobTerminateSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobTerminateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiJobTerminateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiJobTerminateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiJobTerminateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobTerminateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobTerminateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobTerminateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobTerminateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobTerminateSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobTerminateSettings.Workspace"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBatchaiJobTerminateSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiJobTerminate(Configure<AzureBatchaiJobTerminateSettings> configurator)
        {
            return AzureBatchaiJobTerminate(configurator(new AzureBatchaiJobTerminateSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobTerminateSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobTerminateSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobTerminateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiJobTerminateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiJobTerminateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiJobTerminateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobTerminateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobTerminateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobTerminateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobTerminateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobTerminateSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobTerminateSettings.Workspace"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBatchaiJobTerminateSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiJobTerminateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiJobTerminate(CombinatorialConfigure<AzureBatchaiJobTerminateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiJobTerminate, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobWait(AzureBatchaiJobWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiJobWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobWaitSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobWaitSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiJobWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureBatchaiJobWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiJobWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobWaitSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobWaitSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobWaitSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiJobWait(Configure<AzureBatchaiJobWaitSettings> configurator)
        {
            return AzureBatchaiJobWait(configurator(new AzureBatchaiJobWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobWaitSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobWaitSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiJobWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureBatchaiJobWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBatchaiJobWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobWaitSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobWaitSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobWaitSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiJobWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiJobWait(CombinatorialConfigure<AzureBatchaiJobWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiJobWait, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiWorkspaceCreate(AzureBatchaiWorkspaceCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiWorkspaceCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiWorkspaceCreate(Configure<AzureBatchaiWorkspaceCreateSettings> configurator)
        {
            return AzureBatchaiWorkspaceCreate(configurator(new AzureBatchaiWorkspaceCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiWorkspaceCreateSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiWorkspaceCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiWorkspaceCreate(CombinatorialConfigure<AzureBatchaiWorkspaceCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiWorkspaceCreate, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiWorkspaceDelete(AzureBatchaiWorkspaceDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiWorkspaceDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Ids"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Workspace"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiWorkspaceDelete(Configure<AzureBatchaiWorkspaceDeleteSettings> configurator)
        {
            return AzureBatchaiWorkspaceDelete(configurator(new AzureBatchaiWorkspaceDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Ids"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Workspace"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBatchaiWorkspaceDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiWorkspaceDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiWorkspaceDelete(CombinatorialConfigure<AzureBatchaiWorkspaceDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiWorkspaceDelete, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiWorkspaceList(AzureBatchaiWorkspaceListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiWorkspaceListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiWorkspaceListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiWorkspaceListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiWorkspaceListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiWorkspaceListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiWorkspaceListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiWorkspaceListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiWorkspaceListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiWorkspaceList(Configure<AzureBatchaiWorkspaceListSettings> configurator)
        {
            return AzureBatchaiWorkspaceList(configurator(new AzureBatchaiWorkspaceListSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiWorkspaceListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiWorkspaceListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiWorkspaceListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiWorkspaceListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiWorkspaceListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiWorkspaceListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiWorkspaceListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiWorkspaceListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiWorkspaceList(CombinatorialConfigure<AzureBatchaiWorkspaceListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiWorkspaceList, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiWorkspaceShow(AzureBatchaiWorkspaceShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiWorkspaceShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiWorkspaceShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiWorkspaceShow(Configure<AzureBatchaiWorkspaceShowSettings> configurator)
        {
            return AzureBatchaiWorkspaceShow(configurator(new AzureBatchaiWorkspaceShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiWorkspaceShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiWorkspaceShowSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiWorkspaceShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiWorkspaceShow(CombinatorialConfigure<AzureBatchaiWorkspaceShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiWorkspaceShow, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterFileList(AzureBatchaiClusterFileListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiClusterFileListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster</c> via <see cref="AzureBatchaiClusterFileListSettings.Cluster"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterFileListSettings.Debug"/></li>
        ///     <li><c>--expiry</c> via <see cref="AzureBatchaiClusterFileListSettings.Expiry"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterFileListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterFileListSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBatchaiClusterFileListSettings.Path"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterFileListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterFileListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterFileListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterFileListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterFileListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterFileList(Configure<AzureBatchaiClusterFileListSettings> configurator)
        {
            return AzureBatchaiClusterFileList(configurator(new AzureBatchaiClusterFileListSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster</c> via <see cref="AzureBatchaiClusterFileListSettings.Cluster"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterFileListSettings.Debug"/></li>
        ///     <li><c>--expiry</c> via <see cref="AzureBatchaiClusterFileListSettings.Expiry"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterFileListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterFileListSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBatchaiClusterFileListSettings.Path"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterFileListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterFileListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterFileListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterFileListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterFileListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiClusterFileListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiClusterFileList(CombinatorialConfigure<AzureBatchaiClusterFileListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiClusterFileList, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterNodeExec(AzureBatchaiClusterNodeExecSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiClusterNodeExecSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--address</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Address"/></li>
        ///     <li><c>--cluster</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Cluster"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Debug"/></li>
        ///     <li><c>--exec</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Exec"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Help"/></li>
        ///     <li><c>--node-id</c> via <see cref="AzureBatchaiClusterNodeExecSettings.NodeId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterNodeExecSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-private-key</c> via <see cref="AzureBatchaiClusterNodeExecSettings.SshPrivateKey"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterNodeExec(Configure<AzureBatchaiClusterNodeExecSettings> configurator)
        {
            return AzureBatchaiClusterNodeExec(configurator(new AzureBatchaiClusterNodeExecSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--address</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Address"/></li>
        ///     <li><c>--cluster</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Cluster"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Debug"/></li>
        ///     <li><c>--exec</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Exec"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Help"/></li>
        ///     <li><c>--node-id</c> via <see cref="AzureBatchaiClusterNodeExecSettings.NodeId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterNodeExecSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-private-key</c> via <see cref="AzureBatchaiClusterNodeExecSettings.SshPrivateKey"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterNodeExecSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiClusterNodeExecSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiClusterNodeExec(CombinatorialConfigure<AzureBatchaiClusterNodeExecSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiClusterNodeExec, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterNodeList(AzureBatchaiClusterNodeListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiClusterNodeListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster</c> via <see cref="AzureBatchaiClusterNodeListSettings.Cluster"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterNodeListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterNodeListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterNodeListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterNodeListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterNodeListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterNodeListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterNodeListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterNodeListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterNodeList(Configure<AzureBatchaiClusterNodeListSettings> configurator)
        {
            return AzureBatchaiClusterNodeList(configurator(new AzureBatchaiClusterNodeListSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster</c> via <see cref="AzureBatchaiClusterNodeListSettings.Cluster"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiClusterNodeListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiClusterNodeListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiClusterNodeListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiClusterNodeListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiClusterNodeListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiClusterNodeListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiClusterNodeListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiClusterNodeListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiClusterNodeListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiClusterNodeList(CombinatorialConfigure<AzureBatchaiClusterNodeListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiClusterNodeList, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobFileList(AzureBatchaiJobFileListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiJobFileListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobFileListSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobFileListSettings.Experiment"/></li>
        ///     <li><c>--expiry</c> via <see cref="AzureBatchaiJobFileListSettings.Expiry"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobFileListSettings.Help"/></li>
        ///     <li><c>--job</c> via <see cref="AzureBatchaiJobFileListSettings.Job"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobFileListSettings.Output"/></li>
        ///     <li><c>--output-directory-id</c> via <see cref="AzureBatchaiJobFileListSettings.OutputDirectoryId"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBatchaiJobFileListSettings.Path"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobFileListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobFileListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobFileListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobFileListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobFileListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiJobFileList(Configure<AzureBatchaiJobFileListSettings> configurator)
        {
            return AzureBatchaiJobFileList(configurator(new AzureBatchaiJobFileListSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobFileListSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobFileListSettings.Experiment"/></li>
        ///     <li><c>--expiry</c> via <see cref="AzureBatchaiJobFileListSettings.Expiry"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobFileListSettings.Help"/></li>
        ///     <li><c>--job</c> via <see cref="AzureBatchaiJobFileListSettings.Job"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobFileListSettings.Output"/></li>
        ///     <li><c>--output-directory-id</c> via <see cref="AzureBatchaiJobFileListSettings.OutputDirectoryId"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBatchaiJobFileListSettings.Path"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobFileListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobFileListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobFileListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobFileListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobFileListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiJobFileListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiJobFileList(CombinatorialConfigure<AzureBatchaiJobFileListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiJobFileList, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobFileStream(AzureBatchaiJobFileStreamSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiJobFileStreamSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobFileStreamSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobFileStreamSettings.Experiment"/></li>
        ///     <li><c>--file-name</c> via <see cref="AzureBatchaiJobFileStreamSettings.FileName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobFileStreamSettings.Help"/></li>
        ///     <li><c>--job</c> via <see cref="AzureBatchaiJobFileStreamSettings.Job"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobFileStreamSettings.Output"/></li>
        ///     <li><c>--output-directory-id</c> via <see cref="AzureBatchaiJobFileStreamSettings.OutputDirectoryId"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBatchaiJobFileStreamSettings.Path"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobFileStreamSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobFileStreamSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobFileStreamSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobFileStreamSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobFileStreamSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiJobFileStream(Configure<AzureBatchaiJobFileStreamSettings> configurator)
        {
            return AzureBatchaiJobFileStream(configurator(new AzureBatchaiJobFileStreamSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobFileStreamSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobFileStreamSettings.Experiment"/></li>
        ///     <li><c>--file-name</c> via <see cref="AzureBatchaiJobFileStreamSettings.FileName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobFileStreamSettings.Help"/></li>
        ///     <li><c>--job</c> via <see cref="AzureBatchaiJobFileStreamSettings.Job"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobFileStreamSettings.Output"/></li>
        ///     <li><c>--output-directory-id</c> via <see cref="AzureBatchaiJobFileStreamSettings.OutputDirectoryId"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBatchaiJobFileStreamSettings.Path"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobFileStreamSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobFileStreamSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobFileStreamSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobFileStreamSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobFileStreamSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiJobFileStreamSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiJobFileStream(CombinatorialConfigure<AzureBatchaiJobFileStreamSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiJobFileStream, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobNodeExec(AzureBatchaiJobNodeExecSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiJobNodeExecSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--address</c> via <see cref="AzureBatchaiJobNodeExecSettings.Address"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobNodeExecSettings.Debug"/></li>
        ///     <li><c>--exec</c> via <see cref="AzureBatchaiJobNodeExecSettings.Exec"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobNodeExecSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobNodeExecSettings.Help"/></li>
        ///     <li><c>--job</c> via <see cref="AzureBatchaiJobNodeExecSettings.Job"/></li>
        ///     <li><c>--node-id</c> via <see cref="AzureBatchaiJobNodeExecSettings.NodeId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobNodeExecSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureBatchaiJobNodeExecSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobNodeExecSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobNodeExecSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-private-key</c> via <see cref="AzureBatchaiJobNodeExecSettings.SshPrivateKey"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobNodeExecSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobNodeExecSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobNodeExecSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiJobNodeExec(Configure<AzureBatchaiJobNodeExecSettings> configurator)
        {
            return AzureBatchaiJobNodeExec(configurator(new AzureBatchaiJobNodeExecSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--address</c> via <see cref="AzureBatchaiJobNodeExecSettings.Address"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobNodeExecSettings.Debug"/></li>
        ///     <li><c>--exec</c> via <see cref="AzureBatchaiJobNodeExecSettings.Exec"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobNodeExecSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobNodeExecSettings.Help"/></li>
        ///     <li><c>--job</c> via <see cref="AzureBatchaiJobNodeExecSettings.Job"/></li>
        ///     <li><c>--node-id</c> via <see cref="AzureBatchaiJobNodeExecSettings.NodeId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobNodeExecSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureBatchaiJobNodeExecSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobNodeExecSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobNodeExecSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-private-key</c> via <see cref="AzureBatchaiJobNodeExecSettings.SshPrivateKey"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobNodeExecSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobNodeExecSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobNodeExecSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiJobNodeExecSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiJobNodeExec(CombinatorialConfigure<AzureBatchaiJobNodeExecSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiJobNodeExec, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobNodeList(AzureBatchaiJobNodeListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBatchaiJobNodeListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobNodeListSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobNodeListSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobNodeListSettings.Help"/></li>
        ///     <li><c>--job</c> via <see cref="AzureBatchaiJobNodeListSettings.Job"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobNodeListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobNodeListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobNodeListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobNodeListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobNodeListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobNodeListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBatchaiJobNodeList(Configure<AzureBatchaiJobNodeListSettings> configurator)
        {
            return AzureBatchaiJobNodeList(configurator(new AzureBatchaiJobNodeListSettings()));
        }
        /// <summary>
        ///   <p>Manage Batch AI resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBatchaiJobNodeListSettings.Debug"/></li>
        ///     <li><c>--experiment</c> via <see cref="AzureBatchaiJobNodeListSettings.Experiment"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBatchaiJobNodeListSettings.Help"/></li>
        ///     <li><c>--job</c> via <see cref="AzureBatchaiJobNodeListSettings.Job"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBatchaiJobNodeListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBatchaiJobNodeListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureBatchaiJobNodeListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBatchaiJobNodeListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBatchaiJobNodeListSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureBatchaiJobNodeListSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBatchaiJobNodeListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBatchaiJobNodeList(CombinatorialConfigure<AzureBatchaiJobNodeListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBatchaiJobNodeList, AzureBatchaiLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureBatchaiListUsagesSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiListUsagesSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
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
              .Add("batchai list-usages")
              .Add("--location {value}", Location)
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
    #region AzureBatchaiClusterAutoScaleSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterAutoScaleSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Maximum number of nodes.
        /// </summary>
        public virtual int? Max { get; internal set; }
        /// <summary>
        ///   Minimum number of nodes.
        /// </summary>
        public virtual int? Min { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of cluster.
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai cluster auto-scale")
              .Add("--max {value}", Max)
              .Add("--min {value}", Min)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiClusterCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
        /// <summary>
        ///   Generate SSH public and private key files in ~/.ssh directory (if missing).
        /// </summary>
        public virtual string GenerateSshKeys { get; internal set; }
        /// <summary>
        ///   Optional password for the admin user account to be created on each compute node.
        /// </summary>
        public virtual string Password { get; internal set; }
        /// <summary>
        ///   Optional SSH public key value or path. If ommited and no password specified, default SSH key (~/.ssh/id_rsa.pub) will be used.
        /// </summary>
        public virtual string SshKey { get; internal set; }
        /// <summary>
        ///   Name of admin user account to be created on each compute node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.
        /// </summary>
        public virtual string UserName { get; internal set; }
        /// <summary>
        ///   A path to a json file containing cluster create parameters (json representation of azure.mgmt.batchai.models.ClusterCreateParameters).
        /// </summary>
        public virtual string ConfigFile { get; internal set; }
        /// <summary>
        ///   If provided, the command will create a storage account in a new or existing resource group named "batchaiautostorage". It will also create Azure File Share with name "batchaishare", Azure Blob Container with name "batchaicontainer". The File Share and Blob Container will be mounted on each cluster node at $AZ_BATCHAI_MOUNT_ROOT/autoafs and $AZ_BATCHAI_MOUNT_ROOT/autobfs. If the resource group already exists and contains an approapriate storage account belonging to the same region as cluster, this command will reuse existing storage account.
        /// </summary>
        public virtual string UseAutoStorage { get; internal set; }
        /// <summary>
        ///   Relative mount path for Azure File share. The file share will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.
        /// </summary>
        public virtual string AfsMountPath { get; internal set; }
        /// <summary>
        ///   Name of Azure File Share to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple shares can be mounted using configuration file (see --config-file option).
        /// </summary>
        public virtual string AfsName { get; internal set; }
        /// <summary>
        ///   Relative mount path for Azure Storage container. The container will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.
        /// </summary>
        public virtual string BfsMountPath { get; internal set; }
        /// <summary>
        ///   Name of Azure Storage container to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).
        /// </summary>
        public virtual string BfsName { get; internal set; }
        /// <summary>
        ///   Storage account key. Required if the storage account belongs to a different subscription. Can be specified using AZURE_BATCHAI_STORAGE_KEY environment variable.
        /// </summary>
        public virtual string StorageAccountKey { get; internal set; }
        /// <summary>
        ///   Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Can be specified using AZURE_BATCHAI_STORAGE_ACCOUNT environment variable.
        /// </summary>
        public virtual string StorageAccountName { get; internal set; }
        /// <summary>
        ///   Name or ARM ID of a file server to be mounted on each cluster node. You need to provide full ARM ID if the file server belongs to a different workspace. Multiple NFS can be mounted using configuration file (see --config-file option).
        /// </summary>
        public virtual string Nfs { get; internal set; }
        /// <summary>
        ///   Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.
        /// </summary>
        public virtual string NfsMountPath { get; internal set; }
        /// <summary>
        ///   ARM ID of a virtual machine image to be used for nodes creation. Note, you need to provide --image containing information about the base image used for this image creation.
        /// </summary>
        public virtual string CustomImage { get; internal set; }
        /// <summary>
        ///   Operation system image for cluster nodes. The value may contain an alias (UbuntuLTS, UbuntuDSVM) or specify image details in the form "publisher:offer:sku:version". If image configuration is not provided via command line or configuration file, Batch AI will choose default OS image.
        /// </summary>
        public virtual string Image { get; internal set; }
        /// <summary>
        ///   Max nodes count for the auto-scale cluster.
        /// </summary>
        public virtual string Max { get; internal set; }
        /// <summary>
        ///   Min nodes count for the auto-scale cluster.
        /// </summary>
        public virtual string Min { get; internal set; }
        /// <summary>
        ///   Number of nodes which should be allocated immediately after cluster creation. If the cluster is in auto-scale mode, BatchAI can change the number of nodes later based on number of running and queued jobs.
        /// </summary>
        public virtual int? Target { get; internal set; }
        /// <summary>
        ///   VM priority.
        /// </summary>
        public virtual BatchaiClusterCreateVmPriority VmPriority { get; internal set; }
        /// <summary>
        ///   VM size for cluster nodes (e.g. Standard_NC6 for 1 GPU node).
        /// </summary>
        public virtual string VmSize { get; internal set; }
        /// <summary>
        ///   A command line which should be executed on each compute node when it's got allocated or rebooted. The task is executed in a bash subshell under root account.
        /// </summary>
        public virtual string SetupTask { get; internal set; }
        /// <summary>
        ///   Directory path to store where setup-task's logs. Note, Batch AI will create several helper directories under this path. The created directories are reported as stdOutErrPathSuffix by 'az cluster show' command.
        /// </summary>
        public virtual string SetupTaskOutput { get; internal set; }
        /// <summary>
        ///   ARM ID of a virtual network subnet to put the cluster in.
        /// </summary>
        public virtual string Subnet { get; internal set; }
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
              .Add("batchai cluster create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--generate-ssh-keys {value}", GenerateSshKeys)
              .Add("--password {value}", Password, secret: true)
              .Add("--ssh-key {value}", SshKey)
              .Add("--user-name {value}", UserName)
              .Add("--config-file {value}", ConfigFile)
              .Add("--use-auto-storage {value}", UseAutoStorage)
              .Add("--afs-mount-path {value}", AfsMountPath)
              .Add("--afs-name {value}", AfsName)
              .Add("--bfs-mount-path {value}", BfsMountPath)
              .Add("--bfs-name {value}", BfsName)
              .Add("--storage-account-key {value}", StorageAccountKey)
              .Add("--storage-account-name {value}", StorageAccountName)
              .Add("--nfs {value}", Nfs)
              .Add("--nfs-mount-path {value}", NfsMountPath)
              .Add("--custom-image {value}", CustomImage)
              .Add("--image {value}", Image)
              .Add("--max {value}", Max)
              .Add("--min {value}", Min)
              .Add("--target {value}", Target)
              .Add("--vm-priority {value}", VmPriority)
              .Add("--vm-size {value}", VmSize)
              .Add("--setup-task {value}", SetupTask)
              .Add("--setup-task-output {value}", SetupTaskOutput)
              .Add("--subnet {value}", Subnet)
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
    #region AzureBatchaiClusterDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
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
        ///   Name of cluster.
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai cluster delete")
              .Add("--no-wait", NoWait)
              .Add("--yes {value}", Yes)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiClusterListSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai cluster list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiClusterResizeSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterResizeSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Target number of compute nodes.
        /// </summary>
        public virtual string Target { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of cluster.
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai cluster resize")
              .Add("--target {value}", Target)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiClusterShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of cluster.
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai cluster show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiExperimentCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiExperimentCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of experiment.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai experiment create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiExperimentDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiExperimentDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
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
        ///   Name of experiment.
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai experiment delete")
              .Add("--no-wait", NoWait)
              .Add("--yes {value}", Yes)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiExperimentListSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiExperimentListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai experiment list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiExperimentShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiExperimentShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of experiment.
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai experiment show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiFileServerCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiFileServerCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of file server.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure a default value by setting up default workspace using `az batchai workspace set-default`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ARM ID of the workspace. You can configure default workspace using `az batchai workspace set-default`.
        /// </summary>
        public virtual string Workspace { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   VM size.
        /// </summary>
        public virtual string VmSize { get; internal set; }
        /// <summary>
        ///   Generate SSH public and private key files in ~/.ssh directory (if missing).
        /// </summary>
        public virtual string GenerateSshKeys { get; internal set; }
        /// <summary>
        ///   Optional password for the admin user created on the NFS node.
        /// </summary>
        public virtual string Password { get; internal set; }
        /// <summary>
        ///   Optional SSH public key value or path. If ommited and no password specified, default SSH key (~/.ssh/id_rsa.pub) will be used.
        /// </summary>
        public virtual string SshKey { get; internal set; }
        /// <summary>
        ///   Name of admin user account to be created on NFS node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.
        /// </summary>
        public virtual string UserName { get; internal set; }
        /// <summary>
        ///   A path to a json file containing file server create parameters (json representation of azure.mgmt.batchai.models.FileServerCreateParameters). Note, parameters given via command line will overwrite parameters specified in the configuration file.
        /// </summary>
        public virtual string ConfigFile { get; internal set; }
        /// <summary>
        ///   Caching type for premium disks. If not provided via command line or in configuration file, no caching will be used.
        /// </summary>
        public virtual BatchaiFileServerCreateCachingType CachingType { get; internal set; }
        /// <summary>
        ///   Number of disks.
        /// </summary>
        public virtual int? DiskCount { get; internal set; }
        /// <summary>
        ///   Disk size in Gb.
        /// </summary>
        public virtual string DiskSize { get; internal set; }
        /// <summary>
        ///   The sku of storage account to persist VM.
        /// </summary>
        public virtual BatchaiFileServerCreateStorageSku StorageSku { get; internal set; }
        /// <summary>
        ///   ARM ID of a virtual network subnet to put the file server in. If not provided via command line or in the configuration file, Batch AI will create a new virtual network and subnet under your subscription.
        /// </summary>
        public virtual string Subnet { get; internal set; }
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
              .Add("batchai file-server create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--no-wait", NoWait)
              .Add("--vm-size {value}", VmSize)
              .Add("--generate-ssh-keys {value}", GenerateSshKeys)
              .Add("--password {value}", Password, secret: true)
              .Add("--ssh-key {value}", SshKey)
              .Add("--user-name {value}", UserName)
              .Add("--config-file {value}", ConfigFile)
              .Add("--caching-type {value}", CachingType)
              .Add("--disk-count {value}", DiskCount)
              .Add("--disk-size {value}", DiskSize)
              .Add("--storage-sku {value}", StorageSku)
              .Add("--subnet {value}", Subnet)
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
    #region AzureBatchaiFileServerDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiFileServerDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
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
        ///   Name of file server.
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai file-server delete")
              .Add("--no-wait", NoWait)
              .Add("--yes {value}", Yes)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiFileServerListSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiFileServerListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai file-server list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiFileServerShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiFileServerShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of file server.
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai file-server show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiJobCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name or ARM ID of the cluster to run the job. You need to provide ARM ID if the cluster belongs to a different workspace.
        /// </summary>
        public virtual string Cluster { get; internal set; }
        /// <summary>
        ///   A path to a json file containing job create parameters (json representation of azure.mgmt.batchai.models.JobCreateParameters).
        /// </summary>
        public virtual string ConfigFile { get; internal set; }
        /// <summary>
        ///   Name of experiment.
        /// </summary>
        public virtual string Experiment { get; internal set; }
        /// <summary>
        ///   Name of job.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
        /// <summary>
        ///   Relative mount path for Azure File Share. The File Share will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.
        /// </summary>
        public virtual string AfsMountPath { get; internal set; }
        /// <summary>
        ///   Name of Azure File Share to mount during the job execution. The File Share will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name.  Multiple shares can be mounted using configuration file (see --config-file option).
        /// </summary>
        public virtual string AfsName { get; internal set; }
        /// <summary>
        ///   Relative mount path for Azure Storage Blob Container. The container will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.
        /// </summary>
        public virtual string BfsMountPath { get; internal set; }
        /// <summary>
        ///   Name of Azure Storage Blob Container to mount during the job execution. The container will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).
        /// </summary>
        public virtual string BfsName { get; internal set; }
        /// <summary>
        ///   Storage account key. Required if the storage account belongs to a different subscription. Can be specified using AZURE_BATCHAI_STORAGE_KEY environment variable.
        /// </summary>
        public virtual string StorageAccountKey { get; internal set; }
        /// <summary>
        ///   Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Can be specified using AZURE_BATCHAI_STORAGE_ACCOUNT environment variable.
        /// </summary>
        public virtual string StorageAccountName { get; internal set; }
        /// <summary>
        ///   Name or ARM ID of the file server to be mounted during the job execution. You need to provide ARM ID if the file server belongs to a different workspace. You can configure multiple file servers using job's  configuration file.
        /// </summary>
        public virtual string Nfs { get; internal set; }
        /// <summary>
        ///   Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.
        /// </summary>
        public virtual string NfsMountPath { get; internal set; }
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
              .Add("batchai job create")
              .Add("--cluster {value}", Cluster)
              .Add("--config-file {value}", ConfigFile)
              .Add("--experiment {value}", Experiment)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--afs-mount-path {value}", AfsMountPath)
              .Add("--afs-name {value}", AfsName)
              .Add("--bfs-mount-path {value}", BfsMountPath)
              .Add("--bfs-name {value}", BfsName)
              .Add("--storage-account-key {value}", StorageAccountKey)
              .Add("--storage-account-name {value}", StorageAccountName)
              .Add("--nfs {value}", Nfs)
              .Add("--nfs-mount-path {value}", NfsMountPath)
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
    #region AzureBatchaiJobDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
        /// <summary>
        ///   Name of experiment.
        /// </summary>
        public virtual string Experiment { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of job.
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai job delete")
              .Add("--no-wait", NoWait)
              .Add("--yes {value}", Yes)
              .Add("--experiment {value}", Experiment)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiJobListSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of experiment.
        /// </summary>
        public virtual string Experiment { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai job list")
              .Add("--experiment {value}", Experiment)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiJobShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of experiment.
        /// </summary>
        public virtual string Experiment { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of job.
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai job show")
              .Add("--experiment {value}", Experiment)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiJobTerminateSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobTerminateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
        /// <summary>
        ///   Name of experiment.
        /// </summary>
        public virtual string Experiment { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of job.
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai job terminate")
              .Add("--no-wait", NoWait)
              .Add("--yes {value}", Yes)
              .Add("--experiment {value}", Experiment)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiJobWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Polling interval in sec.
        /// </summary>
        public virtual string Interval { get; internal set; }
        /// <summary>
        ///   Name of experiment.
        /// </summary>
        public virtual string Experiment { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of job.
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai job wait")
              .Add("--interval {value}", Interval)
              .Add("--experiment {value}", Experiment)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiWorkspaceCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiWorkspaceCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
        /// <summary>
        ///   Location of the workspace. If omitted, the location of the resource group will be used.
        /// </summary>
        public virtual string Location { get; internal set; }
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
              .Add("batchai workspace create")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--location {value}", Location)
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
    #region AzureBatchaiWorkspaceDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiWorkspaceDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai workspace delete")
              .Add("--no-wait", NoWait)
              .Add("--yes {value}", Yes)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiWorkspaceListSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiWorkspaceListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
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
              .Add("batchai workspace list")
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
    #region AzureBatchaiWorkspaceShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiWorkspaceShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
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
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai workspace show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiClusterFileListSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterFileListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of cluster.
        /// </summary>
        public virtual string Cluster { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
        /// <summary>
        ///   Time in minutes for how long generated download URLs should remain valid.
        /// </summary>
        public virtual string Expiry { get; internal set; }
        /// <summary>
        ///   Relative path of a subfolder inside of the node setup task output directory.
        /// </summary>
        public virtual string Path { get; internal set; }
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
              .Add("batchai cluster file list")
              .Add("--cluster {value}", Cluster)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--expiry {value}", Expiry)
              .Add("--path {value}", Path)
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
    #region AzureBatchaiClusterNodeExecSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterNodeExecSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of cluster.
        /// </summary>
        public virtual string Cluster { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
        /// <summary>
        ///   Specifies that connections to the given TCP port or Unix socket on the local (client) host are to be forwarded to the given host and port, or Unix socket, on the remote side. e.g. -L 8080:localhost:8080.
        /// </summary>
        public virtual string Address { get; internal set; }
        /// <summary>
        ///   Optional command line to be executed on the node. If not provided, the command will perform ports forwarding only.
        /// </summary>
        public virtual string Exec { get; internal set; }
        /// <summary>
        ///   ID of the node to forward the ports to. If not provided, the command will be executed on the first available node.
        /// </summary>
        public virtual string NodeId { get; internal set; }
        /// <summary>
        ///   Optional password to establish SSH connection.
        /// </summary>
        public virtual string Password { get; internal set; }
        /// <summary>
        ///   Optional SSH private key path to establish SSH connection. If omitted, the default SSH private key will be used.
        /// </summary>
        public virtual string SshPrivateKey { get; internal set; }
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
              .Add("batchai cluster node exec")
              .Add("--cluster {value}", Cluster)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--address {value}", Address)
              .Add("--exec {value}", Exec)
              .Add("--node-id {value}", NodeId)
              .Add("--password {value}", Password, secret: true)
              .Add("--ssh-private-key {value}", SshPrivateKey)
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
    #region AzureBatchaiClusterNodeListSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterNodeListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of cluster.
        /// </summary>
        public virtual string Cluster { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai cluster node list")
              .Add("--cluster {value}", Cluster)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiJobFileListSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobFileListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of experiment.
        /// </summary>
        public virtual string Experiment { get; internal set; }
        /// <summary>
        ///   Name of job.
        /// </summary>
        public virtual string Job { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
        /// <summary>
        ///   Time in minutes for how long generated download URL should remain valid.
        /// </summary>
        public virtual string Expiry { get; internal set; }
        /// <summary>
        ///   The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).
        /// </summary>
        public virtual string OutputDirectoryId { get; internal set; }
        /// <summary>
        ///   Relative path in the given output directory.
        /// </summary>
        public virtual string Path { get; internal set; }
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
              .Add("batchai job file list")
              .Add("--experiment {value}", Experiment)
              .Add("--job {value}", Job)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--expiry {value}", Expiry)
              .Add("--output-directory-id {value}", OutputDirectoryId)
              .Add("--path {value}", Path)
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
    #region AzureBatchaiJobFileStreamSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobFileStreamSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of experiment.
        /// </summary>
        public virtual string Experiment { get; internal set; }
        /// <summary>
        ///   The name of the file to stream.
        /// </summary>
        public virtual string FileName { get; internal set; }
        /// <summary>
        ///   Name of job.
        /// </summary>
        public virtual string Job { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
        /// <summary>
        ///   The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).
        /// </summary>
        public virtual string OutputDirectoryId { get; internal set; }
        /// <summary>
        ///   Relative path in the given output directory.
        /// </summary>
        public virtual string Path { get; internal set; }
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
              .Add("batchai job file stream")
              .Add("--experiment {value}", Experiment)
              .Add("--file-name {value}", FileName)
              .Add("--job {value}", Job)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--output-directory-id {value}", OutputDirectoryId)
              .Add("--path {value}", Path)
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
    #region AzureBatchaiJobNodeExecSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobNodeExecSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of experiment.
        /// </summary>
        public virtual string Experiment { get; internal set; }
        /// <summary>
        ///   Name of job.
        /// </summary>
        public virtual string Job { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
        /// <summary>
        ///   Specifies that connections to the given TCP port or Unix socket on the local (client) host are to be forwarded to the given host and port, or Unix socket, on the remote side. e.g. -L 8080:localhost:8080.
        /// </summary>
        public virtual string Address { get; internal set; }
        /// <summary>
        ///   Optional command line to be executed on the node. If not provided, the command will perform ports forwarding only.
        /// </summary>
        public virtual string Exec { get; internal set; }
        /// <summary>
        ///   ID of the node to forward the ports to. If not provided, the command will be executed on the first available node.
        /// </summary>
        public virtual string NodeId { get; internal set; }
        /// <summary>
        ///   Optional password to establish SSH connection.
        /// </summary>
        public virtual string Password { get; internal set; }
        /// <summary>
        ///   Optional SSH private key path to establish SSH connection. If omitted, the default SSH private key will be used.
        /// </summary>
        public virtual string SshPrivateKey { get; internal set; }
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
              .Add("batchai job node exec")
              .Add("--experiment {value}", Experiment)
              .Add("--job {value}", Job)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--address {value}", Address)
              .Add("--exec {value}", Exec)
              .Add("--node-id {value}", NodeId)
              .Add("--password {value}", Password, secret: true)
              .Add("--ssh-private-key {value}", SshPrivateKey)
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
    #region AzureBatchaiJobNodeListSettings
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobNodeListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBatchai executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        public override Action<OutputType, string> CustomLogger => AzureBatchaiTasks.AzureBatchaiLogger;
        /// <summary>
        ///   Name of experiment.
        /// </summary>
        public virtual string Experiment { get; internal set; }
        /// <summary>
        ///   Name of job.
        /// </summary>
        public virtual string Job { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai job node list")
              .Add("--experiment {value}", Experiment)
              .Add("--job {value}", Job)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiListUsagesSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiListUsagesSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetLocation(this AzureBatchaiListUsagesSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings ResetLocation(this AzureBatchaiListUsagesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetSubscription(this AzureBatchaiListUsagesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings ResetSubscription(this AzureBatchaiListUsagesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetDebug(this AzureBatchaiListUsagesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings ResetDebug(this AzureBatchaiListUsagesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetHelp(this AzureBatchaiListUsagesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings ResetHelp(this AzureBatchaiListUsagesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetOutput(this AzureBatchaiListUsagesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings ResetOutput(this AzureBatchaiListUsagesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetQuery(this AzureBatchaiListUsagesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings ResetQuery(this AzureBatchaiListUsagesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetVerbose(this AzureBatchaiListUsagesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings ResetVerbose(this AzureBatchaiListUsagesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterAutoScaleSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterAutoScaleSettingsExtensions
    {
        #region Max
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Max"/></em></p>
        ///   <p>Maximum number of nodes.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetMax(this AzureBatchaiClusterAutoScaleSettings toolSettings, int? max)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Max = max;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Max"/></em></p>
        ///   <p>Maximum number of nodes.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetMax(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Max = null;
            return toolSettings;
        }
        #endregion
        #region Min
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Min"/></em></p>
        ///   <p>Minimum number of nodes.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetMin(this AzureBatchaiClusterAutoScaleSettings toolSettings, int? min)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Min = min;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Min"/></em></p>
        ///   <p>Minimum number of nodes.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetMin(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Min = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetIds(this AzureBatchaiClusterAutoScaleSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetIds(this AzureBatchaiClusterAutoScaleSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiClusterAutoScaleSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings AddIds(this AzureBatchaiClusterAutoScaleSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiClusterAutoScaleSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings AddIds(this AzureBatchaiClusterAutoScaleSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiClusterAutoScaleSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ClearIds(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiClusterAutoScaleSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings RemoveIds(this AzureBatchaiClusterAutoScaleSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiClusterAutoScaleSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings RemoveIds(this AzureBatchaiClusterAutoScaleSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Name"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetName(this AzureBatchaiClusterAutoScaleSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Name"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetName(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetResourceGroup(this AzureBatchaiClusterAutoScaleSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetResourceGroup(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetSubscription(this AzureBatchaiClusterAutoScaleSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetSubscription(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetWorkspace(this AzureBatchaiClusterAutoScaleSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetWorkspace(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetDebug(this AzureBatchaiClusterAutoScaleSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetDebug(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetHelp(this AzureBatchaiClusterAutoScaleSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetHelp(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetOutput(this AzureBatchaiClusterAutoScaleSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetOutput(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetQuery(this AzureBatchaiClusterAutoScaleSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetQuery(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetVerbose(this AzureBatchaiClusterAutoScaleSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetVerbose(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Name"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetName(this AzureBatchaiClusterCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Name"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetName(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetResourceGroup(this AzureBatchaiClusterCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetResourceGroup(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetWorkspace(this AzureBatchaiClusterCreateSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetWorkspace(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region GenerateSshKeys
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.GenerateSshKeys"/></em></p>
        ///   <p>Generate SSH public and private key files in ~/.ssh directory (if missing).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetGenerateSshKeys(this AzureBatchaiClusterCreateSettings toolSettings, string generateSshKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = generateSshKeys;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.GenerateSshKeys"/></em></p>
        ///   <p>Generate SSH public and private key files in ~/.ssh directory (if missing).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetGenerateSshKeys(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Password"/></em></p>
        ///   <p>Optional password for the admin user account to be created on each compute node.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetPassword(this AzureBatchaiClusterCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Password"/></em></p>
        ///   <p>Optional password for the admin user account to be created on each compute node.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetPassword(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region SshKey
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.SshKey"/></em></p>
        ///   <p>Optional SSH public key value or path. If ommited and no password specified, default SSH key (~/.ssh/id_rsa.pub) will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetSshKey(this AzureBatchaiClusterCreateSettings toolSettings, string sshKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = sshKey;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.SshKey"/></em></p>
        ///   <p>Optional SSH public key value or path. If ommited and no password specified, default SSH key (~/.ssh/id_rsa.pub) will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetSshKey(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = null;
            return toolSettings;
        }
        #endregion
        #region UserName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.UserName"/></em></p>
        ///   <p>Name of admin user account to be created on each compute node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetUserName(this AzureBatchaiClusterCreateSettings toolSettings, string userName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = userName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.UserName"/></em></p>
        ///   <p>Name of admin user account to be created on each compute node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetUserName(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.ConfigFile"/></em></p>
        ///   <p>A path to a json file containing cluster create parameters (json representation of azure.mgmt.batchai.models.ClusterCreateParameters).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetConfigFile(this AzureBatchaiClusterCreateSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.ConfigFile"/></em></p>
        ///   <p>A path to a json file containing cluster create parameters (json representation of azure.mgmt.batchai.models.ClusterCreateParameters).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetConfigFile(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region UseAutoStorage
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.UseAutoStorage"/></em></p>
        ///   <p>If provided, the command will create a storage account in a new or existing resource group named "batchaiautostorage". It will also create Azure File Share with name "batchaishare", Azure Blob Container with name "batchaicontainer". The File Share and Blob Container will be mounted on each cluster node at $AZ_BATCHAI_MOUNT_ROOT/autoafs and $AZ_BATCHAI_MOUNT_ROOT/autobfs. If the resource group already exists and contains an approapriate storage account belonging to the same region as cluster, this command will reuse existing storage account.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetUseAutoStorage(this AzureBatchaiClusterCreateSettings toolSettings, string useAutoStorage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseAutoStorage = useAutoStorage;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.UseAutoStorage"/></em></p>
        ///   <p>If provided, the command will create a storage account in a new or existing resource group named "batchaiautostorage". It will also create Azure File Share with name "batchaishare", Azure Blob Container with name "batchaicontainer". The File Share and Blob Container will be mounted on each cluster node at $AZ_BATCHAI_MOUNT_ROOT/autoafs and $AZ_BATCHAI_MOUNT_ROOT/autobfs. If the resource group already exists and contains an approapriate storage account belonging to the same region as cluster, this command will reuse existing storage account.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetUseAutoStorage(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseAutoStorage = null;
            return toolSettings;
        }
        #endregion
        #region AfsMountPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.AfsMountPath"/></em></p>
        ///   <p>Relative mount path for Azure File share. The file share will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetAfsMountPath(this AzureBatchaiClusterCreateSettings toolSettings, string afsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsMountPath = afsMountPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.AfsMountPath"/></em></p>
        ///   <p>Relative mount path for Azure File share. The file share will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetAfsMountPath(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region AfsName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.AfsName"/></em></p>
        ///   <p>Name of Azure File Share to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple shares can be mounted using configuration file (see --config-file option).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetAfsName(this AzureBatchaiClusterCreateSettings toolSettings, string afsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsName = afsName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.AfsName"/></em></p>
        ///   <p>Name of Azure File Share to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple shares can be mounted using configuration file (see --config-file option).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetAfsName(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsName = null;
            return toolSettings;
        }
        #endregion
        #region BfsMountPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.BfsMountPath"/></em></p>
        ///   <p>Relative mount path for Azure Storage container. The container will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetBfsMountPath(this AzureBatchaiClusterCreateSettings toolSettings, string bfsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsMountPath = bfsMountPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.BfsMountPath"/></em></p>
        ///   <p>Relative mount path for Azure Storage container. The container will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetBfsMountPath(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region BfsName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.BfsName"/></em></p>
        ///   <p>Name of Azure Storage container to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetBfsName(this AzureBatchaiClusterCreateSettings toolSettings, string bfsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsName = bfsName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.BfsName"/></em></p>
        ///   <p>Name of Azure Storage container to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetBfsName(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsName = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountKey
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.StorageAccountKey"/></em></p>
        ///   <p>Storage account key. Required if the storage account belongs to a different subscription. Can be specified using AZURE_BATCHAI_STORAGE_KEY environment variable.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetStorageAccountKey(this AzureBatchaiClusterCreateSettings toolSettings, string storageAccountKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = storageAccountKey;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.StorageAccountKey"/></em></p>
        ///   <p>Storage account key. Required if the storage account belongs to a different subscription. Can be specified using AZURE_BATCHAI_STORAGE_KEY environment variable.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetStorageAccountKey(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.StorageAccountName"/></em></p>
        ///   <p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Can be specified using AZURE_BATCHAI_STORAGE_ACCOUNT environment variable.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetStorageAccountName(this AzureBatchaiClusterCreateSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.StorageAccountName"/></em></p>
        ///   <p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Can be specified using AZURE_BATCHAI_STORAGE_ACCOUNT environment variable.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetStorageAccountName(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region Nfs
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Nfs"/></em></p>
        ///   <p>Name or ARM ID of a file server to be mounted on each cluster node. You need to provide full ARM ID if the file server belongs to a different workspace. Multiple NFS can be mounted using configuration file (see --config-file option).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetNfs(this AzureBatchaiClusterCreateSettings toolSettings, string nfs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfs = nfs;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Nfs"/></em></p>
        ///   <p>Name or ARM ID of a file server to be mounted on each cluster node. You need to provide full ARM ID if the file server belongs to a different workspace. Multiple NFS can be mounted using configuration file (see --config-file option).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetNfs(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfs = null;
            return toolSettings;
        }
        #endregion
        #region NfsMountPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.NfsMountPath"/></em></p>
        ///   <p>Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetNfsMountPath(this AzureBatchaiClusterCreateSettings toolSettings, string nfsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsMountPath = nfsMountPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.NfsMountPath"/></em></p>
        ///   <p>Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetNfsMountPath(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region CustomImage
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.CustomImage"/></em></p>
        ///   <p>ARM ID of a virtual machine image to be used for nodes creation. Note, you need to provide --image containing information about the base image used for this image creation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetCustomImage(this AzureBatchaiClusterCreateSettings toolSettings, string customImage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomImage = customImage;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.CustomImage"/></em></p>
        ///   <p>ARM ID of a virtual machine image to be used for nodes creation. Note, you need to provide --image containing information about the base image used for this image creation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetCustomImage(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomImage = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Image"/></em></p>
        ///   <p>Operation system image for cluster nodes. The value may contain an alias (UbuntuLTS, UbuntuDSVM) or specify image details in the form "publisher:offer:sku:version". If image configuration is not provided via command line or configuration file, Batch AI will choose default OS image.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetImage(this AzureBatchaiClusterCreateSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Image"/></em></p>
        ///   <p>Operation system image for cluster nodes. The value may contain an alias (UbuntuLTS, UbuntuDSVM) or specify image details in the form "publisher:offer:sku:version". If image configuration is not provided via command line or configuration file, Batch AI will choose default OS image.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetImage(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region Max
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Max"/></em></p>
        ///   <p>Max nodes count for the auto-scale cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetMax(this AzureBatchaiClusterCreateSettings toolSettings, string max)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Max = max;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Max"/></em></p>
        ///   <p>Max nodes count for the auto-scale cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetMax(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Max = null;
            return toolSettings;
        }
        #endregion
        #region Min
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Min"/></em></p>
        ///   <p>Min nodes count for the auto-scale cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetMin(this AzureBatchaiClusterCreateSettings toolSettings, string min)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Min = min;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Min"/></em></p>
        ///   <p>Min nodes count for the auto-scale cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetMin(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Min = null;
            return toolSettings;
        }
        #endregion
        #region Target
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Target"/></em></p>
        ///   <p>Number of nodes which should be allocated immediately after cluster creation. If the cluster is in auto-scale mode, BatchAI can change the number of nodes later based on number of running and queued jobs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetTarget(this AzureBatchaiClusterCreateSettings toolSettings, int? target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = target;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Target"/></em></p>
        ///   <p>Number of nodes which should be allocated immediately after cluster creation. If the cluster is in auto-scale mode, BatchAI can change the number of nodes later based on number of running and queued jobs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetTarget(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = null;
            return toolSettings;
        }
        #endregion
        #region VmPriority
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.VmPriority"/></em></p>
        ///   <p>VM priority.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetVmPriority(this AzureBatchaiClusterCreateSettings toolSettings, BatchaiClusterCreateVmPriority vmPriority)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmPriority = vmPriority;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.VmPriority"/></em></p>
        ///   <p>VM priority.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetVmPriority(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmPriority = null;
            return toolSettings;
        }
        #endregion
        #region VmSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.VmSize"/></em></p>
        ///   <p>VM size for cluster nodes (e.g. Standard_NC6 for 1 GPU node).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetVmSize(this AzureBatchaiClusterCreateSettings toolSettings, string vmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = vmSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.VmSize"/></em></p>
        ///   <p>VM size for cluster nodes (e.g. Standard_NC6 for 1 GPU node).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetVmSize(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = null;
            return toolSettings;
        }
        #endregion
        #region SetupTask
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.SetupTask"/></em></p>
        ///   <p>A command line which should be executed on each compute node when it's got allocated or rebooted. The task is executed in a bash subshell under root account.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetSetupTask(this AzureBatchaiClusterCreateSettings toolSettings, string setupTask)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetupTask = setupTask;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.SetupTask"/></em></p>
        ///   <p>A command line which should be executed on each compute node when it's got allocated or rebooted. The task is executed in a bash subshell under root account.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetSetupTask(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetupTask = null;
            return toolSettings;
        }
        #endregion
        #region SetupTaskOutput
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.SetupTaskOutput"/></em></p>
        ///   <p>Directory path to store where setup-task's logs. Note, Batch AI will create several helper directories under this path. The created directories are reported as stdOutErrPathSuffix by 'az cluster show' command.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetSetupTaskOutput(this AzureBatchaiClusterCreateSettings toolSettings, string setupTaskOutput)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetupTaskOutput = setupTaskOutput;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.SetupTaskOutput"/></em></p>
        ///   <p>Directory path to store where setup-task's logs. Note, Batch AI will create several helper directories under this path. The created directories are reported as stdOutErrPathSuffix by 'az cluster show' command.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetSetupTaskOutput(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetupTaskOutput = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Subnet"/></em></p>
        ///   <p>ARM ID of a virtual network subnet to put the cluster in.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetSubnet(this AzureBatchaiClusterCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Subnet"/></em></p>
        ///   <p>ARM ID of a virtual network subnet to put the cluster in.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetSubnet(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetSubscription(this AzureBatchaiClusterCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetSubscription(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetDebug(this AzureBatchaiClusterCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetDebug(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetHelp(this AzureBatchaiClusterCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetHelp(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetOutput(this AzureBatchaiClusterCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetOutput(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetQuery(this AzureBatchaiClusterCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetQuery(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetVerbose(this AzureBatchaiClusterCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetVerbose(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterDeleteSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetNoWait(this AzureBatchaiClusterDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetNoWait(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBatchaiClusterDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings EnableNoWait(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBatchaiClusterDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings DisableNoWait(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBatchaiClusterDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ToggleNoWait(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetYes(this AzureBatchaiClusterDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetYes(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetIds(this AzureBatchaiClusterDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetIds(this AzureBatchaiClusterDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiClusterDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings AddIds(this AzureBatchaiClusterDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiClusterDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings AddIds(this AzureBatchaiClusterDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiClusterDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ClearIds(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiClusterDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings RemoveIds(this AzureBatchaiClusterDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiClusterDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings RemoveIds(this AzureBatchaiClusterDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Name"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetName(this AzureBatchaiClusterDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Name"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetName(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetResourceGroup(this AzureBatchaiClusterDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetResourceGroup(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetSubscription(this AzureBatchaiClusterDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetSubscription(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetWorkspace(this AzureBatchaiClusterDeleteSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetWorkspace(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetDebug(this AzureBatchaiClusterDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetDebug(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetHelp(this AzureBatchaiClusterDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetHelp(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetOutput(this AzureBatchaiClusterDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetOutput(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetQuery(this AzureBatchaiClusterDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetQuery(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetVerbose(this AzureBatchaiClusterDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetVerbose(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetResourceGroup(this AzureBatchaiClusterListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetResourceGroup(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetWorkspace(this AzureBatchaiClusterListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetWorkspace(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetSubscription(this AzureBatchaiClusterListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetSubscription(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetDebug(this AzureBatchaiClusterListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetDebug(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetHelp(this AzureBatchaiClusterListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetHelp(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetOutput(this AzureBatchaiClusterListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetOutput(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetQuery(this AzureBatchaiClusterListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetQuery(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetVerbose(this AzureBatchaiClusterListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetVerbose(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterResizeSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterResizeSettingsExtensions
    {
        #region Target
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Target"/></em></p>
        ///   <p>Target number of compute nodes.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetTarget(this AzureBatchaiClusterResizeSettings toolSettings, string target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = target;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Target"/></em></p>
        ///   <p>Target number of compute nodes.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetTarget(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetIds(this AzureBatchaiClusterResizeSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetIds(this AzureBatchaiClusterResizeSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiClusterResizeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings AddIds(this AzureBatchaiClusterResizeSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiClusterResizeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings AddIds(this AzureBatchaiClusterResizeSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiClusterResizeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ClearIds(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiClusterResizeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings RemoveIds(this AzureBatchaiClusterResizeSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiClusterResizeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings RemoveIds(this AzureBatchaiClusterResizeSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Name"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetName(this AzureBatchaiClusterResizeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Name"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetName(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetResourceGroup(this AzureBatchaiClusterResizeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetResourceGroup(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetSubscription(this AzureBatchaiClusterResizeSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetSubscription(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetWorkspace(this AzureBatchaiClusterResizeSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetWorkspace(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetDebug(this AzureBatchaiClusterResizeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetDebug(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetHelp(this AzureBatchaiClusterResizeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetHelp(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetOutput(this AzureBatchaiClusterResizeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetOutput(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetQuery(this AzureBatchaiClusterResizeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetQuery(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetVerbose(this AzureBatchaiClusterResizeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetVerbose(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetIds(this AzureBatchaiClusterShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetIds(this AzureBatchaiClusterShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiClusterShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings AddIds(this AzureBatchaiClusterShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiClusterShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings AddIds(this AzureBatchaiClusterShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiClusterShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ClearIds(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiClusterShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings RemoveIds(this AzureBatchaiClusterShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiClusterShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings RemoveIds(this AzureBatchaiClusterShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Name"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetName(this AzureBatchaiClusterShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Name"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetName(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetResourceGroup(this AzureBatchaiClusterShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetResourceGroup(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetSubscription(this AzureBatchaiClusterShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetSubscription(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetWorkspace(this AzureBatchaiClusterShowSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetWorkspace(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetDebug(this AzureBatchaiClusterShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetDebug(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetHelp(this AzureBatchaiClusterShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetHelp(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetOutput(this AzureBatchaiClusterShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetOutput(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetQuery(this AzureBatchaiClusterShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetQuery(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetVerbose(this AzureBatchaiClusterShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetVerbose(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiExperimentCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiExperimentCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Name"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetName(this AzureBatchaiExperimentCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Name"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetName(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetResourceGroup(this AzureBatchaiExperimentCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetResourceGroup(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetWorkspace(this AzureBatchaiExperimentCreateSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetWorkspace(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetSubscription(this AzureBatchaiExperimentCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetSubscription(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetDebug(this AzureBatchaiExperimentCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetDebug(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetHelp(this AzureBatchaiExperimentCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetHelp(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetOutput(this AzureBatchaiExperimentCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetOutput(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetQuery(this AzureBatchaiExperimentCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetQuery(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetVerbose(this AzureBatchaiExperimentCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetVerbose(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiExperimentDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiExperimentDeleteSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetNoWait(this AzureBatchaiExperimentDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetNoWait(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBatchaiExperimentDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings EnableNoWait(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBatchaiExperimentDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings DisableNoWait(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBatchaiExperimentDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ToggleNoWait(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetYes(this AzureBatchaiExperimentDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetYes(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetIds(this AzureBatchaiExperimentDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetIds(this AzureBatchaiExperimentDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiExperimentDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings AddIds(this AzureBatchaiExperimentDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiExperimentDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings AddIds(this AzureBatchaiExperimentDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiExperimentDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ClearIds(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiExperimentDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings RemoveIds(this AzureBatchaiExperimentDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiExperimentDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings RemoveIds(this AzureBatchaiExperimentDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Name"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetName(this AzureBatchaiExperimentDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Name"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetName(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetResourceGroup(this AzureBatchaiExperimentDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetResourceGroup(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetSubscription(this AzureBatchaiExperimentDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetSubscription(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetWorkspace(this AzureBatchaiExperimentDeleteSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetWorkspace(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetDebug(this AzureBatchaiExperimentDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetDebug(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetHelp(this AzureBatchaiExperimentDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetHelp(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetOutput(this AzureBatchaiExperimentDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetOutput(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetQuery(this AzureBatchaiExperimentDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetQuery(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetVerbose(this AzureBatchaiExperimentDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetVerbose(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiExperimentListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiExperimentListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetResourceGroup(this AzureBatchaiExperimentListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetResourceGroup(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetWorkspace(this AzureBatchaiExperimentListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetWorkspace(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetSubscription(this AzureBatchaiExperimentListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetSubscription(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetDebug(this AzureBatchaiExperimentListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetDebug(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetHelp(this AzureBatchaiExperimentListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetHelp(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetOutput(this AzureBatchaiExperimentListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetOutput(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetQuery(this AzureBatchaiExperimentListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetQuery(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetVerbose(this AzureBatchaiExperimentListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetVerbose(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiExperimentShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiExperimentShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetIds(this AzureBatchaiExperimentShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetIds(this AzureBatchaiExperimentShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiExperimentShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings AddIds(this AzureBatchaiExperimentShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiExperimentShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings AddIds(this AzureBatchaiExperimentShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiExperimentShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ClearIds(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiExperimentShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings RemoveIds(this AzureBatchaiExperimentShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiExperimentShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings RemoveIds(this AzureBatchaiExperimentShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Name"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetName(this AzureBatchaiExperimentShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Name"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetName(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetResourceGroup(this AzureBatchaiExperimentShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetResourceGroup(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetSubscription(this AzureBatchaiExperimentShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetSubscription(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetWorkspace(this AzureBatchaiExperimentShowSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetWorkspace(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetDebug(this AzureBatchaiExperimentShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetDebug(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetHelp(this AzureBatchaiExperimentShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetHelp(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetOutput(this AzureBatchaiExperimentShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetOutput(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetQuery(this AzureBatchaiExperimentShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetQuery(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetVerbose(this AzureBatchaiExperimentShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetVerbose(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiFileServerCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiFileServerCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Name"/></em></p>
        ///   <p>Name of file server.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetName(this AzureBatchaiFileServerCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Name"/></em></p>
        ///   <p>Name of file server.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetName(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure a default value by setting up default workspace using `az batchai workspace set-default`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetResourceGroup(this AzureBatchaiFileServerCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure a default value by setting up default workspace using `az batchai workspace set-default`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetResourceGroup(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Workspace"/></em></p>
        ///   <p>Name or ARM ID of the workspace. You can configure default workspace using `az batchai workspace set-default`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetWorkspace(this AzureBatchaiFileServerCreateSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Workspace"/></em></p>
        ///   <p>Name or ARM ID of the workspace. You can configure default workspace using `az batchai workspace set-default`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetWorkspace(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetNoWait(this AzureBatchaiFileServerCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetNoWait(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBatchaiFileServerCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings EnableNoWait(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBatchaiFileServerCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings DisableNoWait(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBatchaiFileServerCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ToggleNoWait(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region VmSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.VmSize"/></em></p>
        ///   <p>VM size.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetVmSize(this AzureBatchaiFileServerCreateSettings toolSettings, string vmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = vmSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.VmSize"/></em></p>
        ///   <p>VM size.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetVmSize(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = null;
            return toolSettings;
        }
        #endregion
        #region GenerateSshKeys
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.GenerateSshKeys"/></em></p>
        ///   <p>Generate SSH public and private key files in ~/.ssh directory (if missing).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetGenerateSshKeys(this AzureBatchaiFileServerCreateSettings toolSettings, string generateSshKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = generateSshKeys;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.GenerateSshKeys"/></em></p>
        ///   <p>Generate SSH public and private key files in ~/.ssh directory (if missing).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetGenerateSshKeys(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Password"/></em></p>
        ///   <p>Optional password for the admin user created on the NFS node.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetPassword(this AzureBatchaiFileServerCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Password"/></em></p>
        ///   <p>Optional password for the admin user created on the NFS node.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetPassword(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region SshKey
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.SshKey"/></em></p>
        ///   <p>Optional SSH public key value or path. If ommited and no password specified, default SSH key (~/.ssh/id_rsa.pub) will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetSshKey(this AzureBatchaiFileServerCreateSettings toolSettings, string sshKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = sshKey;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.SshKey"/></em></p>
        ///   <p>Optional SSH public key value or path. If ommited and no password specified, default SSH key (~/.ssh/id_rsa.pub) will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetSshKey(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = null;
            return toolSettings;
        }
        #endregion
        #region UserName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.UserName"/></em></p>
        ///   <p>Name of admin user account to be created on NFS node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetUserName(this AzureBatchaiFileServerCreateSettings toolSettings, string userName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = userName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.UserName"/></em></p>
        ///   <p>Name of admin user account to be created on NFS node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetUserName(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.ConfigFile"/></em></p>
        ///   <p>A path to a json file containing file server create parameters (json representation of azure.mgmt.batchai.models.FileServerCreateParameters). Note, parameters given via command line will overwrite parameters specified in the configuration file.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetConfigFile(this AzureBatchaiFileServerCreateSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.ConfigFile"/></em></p>
        ///   <p>A path to a json file containing file server create parameters (json representation of azure.mgmt.batchai.models.FileServerCreateParameters). Note, parameters given via command line will overwrite parameters specified in the configuration file.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetConfigFile(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region CachingType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.CachingType"/></em></p>
        ///   <p>Caching type for premium disks. If not provided via command line or in configuration file, no caching will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetCachingType(this AzureBatchaiFileServerCreateSettings toolSettings, BatchaiFileServerCreateCachingType cachingType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CachingType = cachingType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.CachingType"/></em></p>
        ///   <p>Caching type for premium disks. If not provided via command line or in configuration file, no caching will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetCachingType(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CachingType = null;
            return toolSettings;
        }
        #endregion
        #region DiskCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.DiskCount"/></em></p>
        ///   <p>Number of disks.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetDiskCount(this AzureBatchaiFileServerCreateSettings toolSettings, int? diskCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskCount = diskCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.DiskCount"/></em></p>
        ///   <p>Number of disks.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetDiskCount(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskCount = null;
            return toolSettings;
        }
        #endregion
        #region DiskSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.DiskSize"/></em></p>
        ///   <p>Disk size in Gb.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetDiskSize(this AzureBatchaiFileServerCreateSettings toolSettings, string diskSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskSize = diskSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.DiskSize"/></em></p>
        ///   <p>Disk size in Gb.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetDiskSize(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskSize = null;
            return toolSettings;
        }
        #endregion
        #region StorageSku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.StorageSku"/></em></p>
        ///   <p>The sku of storage account to persist VM.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetStorageSku(this AzureBatchaiFileServerCreateSettings toolSettings, BatchaiFileServerCreateStorageSku storageSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSku = storageSku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.StorageSku"/></em></p>
        ///   <p>The sku of storage account to persist VM.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetStorageSku(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSku = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Subnet"/></em></p>
        ///   <p>ARM ID of a virtual network subnet to put the file server in. If not provided via command line or in the configuration file, Batch AI will create a new virtual network and subnet under your subscription.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetSubnet(this AzureBatchaiFileServerCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Subnet"/></em></p>
        ///   <p>ARM ID of a virtual network subnet to put the file server in. If not provided via command line or in the configuration file, Batch AI will create a new virtual network and subnet under your subscription.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetSubnet(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetSubscription(this AzureBatchaiFileServerCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetSubscription(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetDebug(this AzureBatchaiFileServerCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetDebug(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetHelp(this AzureBatchaiFileServerCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetHelp(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetOutput(this AzureBatchaiFileServerCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetOutput(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetQuery(this AzureBatchaiFileServerCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetQuery(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetVerbose(this AzureBatchaiFileServerCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetVerbose(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiFileServerDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiFileServerDeleteSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetNoWait(this AzureBatchaiFileServerDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetNoWait(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBatchaiFileServerDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings EnableNoWait(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBatchaiFileServerDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings DisableNoWait(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBatchaiFileServerDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ToggleNoWait(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetYes(this AzureBatchaiFileServerDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetYes(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetIds(this AzureBatchaiFileServerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetIds(this AzureBatchaiFileServerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiFileServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings AddIds(this AzureBatchaiFileServerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiFileServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings AddIds(this AzureBatchaiFileServerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiFileServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ClearIds(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiFileServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings RemoveIds(this AzureBatchaiFileServerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiFileServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings RemoveIds(this AzureBatchaiFileServerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Name"/></em></p>
        ///   <p>Name of file server.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetName(this AzureBatchaiFileServerDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Name"/></em></p>
        ///   <p>Name of file server.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetName(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetResourceGroup(this AzureBatchaiFileServerDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetResourceGroup(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetSubscription(this AzureBatchaiFileServerDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetSubscription(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetWorkspace(this AzureBatchaiFileServerDeleteSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetWorkspace(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetDebug(this AzureBatchaiFileServerDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetDebug(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetHelp(this AzureBatchaiFileServerDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetHelp(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetOutput(this AzureBatchaiFileServerDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetOutput(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetQuery(this AzureBatchaiFileServerDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetQuery(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetVerbose(this AzureBatchaiFileServerDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetVerbose(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiFileServerListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiFileServerListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetResourceGroup(this AzureBatchaiFileServerListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetResourceGroup(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetWorkspace(this AzureBatchaiFileServerListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetWorkspace(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetSubscription(this AzureBatchaiFileServerListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetSubscription(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetDebug(this AzureBatchaiFileServerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetDebug(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetHelp(this AzureBatchaiFileServerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetHelp(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetOutput(this AzureBatchaiFileServerListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetOutput(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetQuery(this AzureBatchaiFileServerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetQuery(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetVerbose(this AzureBatchaiFileServerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetVerbose(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiFileServerShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiFileServerShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetIds(this AzureBatchaiFileServerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetIds(this AzureBatchaiFileServerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiFileServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings AddIds(this AzureBatchaiFileServerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiFileServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings AddIds(this AzureBatchaiFileServerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiFileServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ClearIds(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiFileServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings RemoveIds(this AzureBatchaiFileServerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiFileServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings RemoveIds(this AzureBatchaiFileServerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Name"/></em></p>
        ///   <p>Name of file server.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetName(this AzureBatchaiFileServerShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Name"/></em></p>
        ///   <p>Name of file server.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetName(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetResourceGroup(this AzureBatchaiFileServerShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetResourceGroup(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetSubscription(this AzureBatchaiFileServerShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetSubscription(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetWorkspace(this AzureBatchaiFileServerShowSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetWorkspace(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetDebug(this AzureBatchaiFileServerShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetDebug(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetHelp(this AzureBatchaiFileServerShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetHelp(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetOutput(this AzureBatchaiFileServerShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetOutput(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetQuery(this AzureBatchaiFileServerShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetQuery(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetVerbose(this AzureBatchaiFileServerShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetVerbose(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobCreateSettingsExtensions
    {
        #region Cluster
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Cluster"/></em></p>
        ///   <p>Name or ARM ID of the cluster to run the job. You need to provide ARM ID if the cluster belongs to a different workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetCluster(this AzureBatchaiJobCreateSettings toolSettings, string cluster)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = cluster;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Cluster"/></em></p>
        ///   <p>Name or ARM ID of the cluster to run the job. You need to provide ARM ID if the cluster belongs to a different workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetCluster(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.ConfigFile"/></em></p>
        ///   <p>A path to a json file containing job create parameters (json representation of azure.mgmt.batchai.models.JobCreateParameters).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetConfigFile(this AzureBatchaiJobCreateSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.ConfigFile"/></em></p>
        ///   <p>A path to a json file containing job create parameters (json representation of azure.mgmt.batchai.models.JobCreateParameters).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetConfigFile(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region Experiment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetExperiment(this AzureBatchaiJobCreateSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetExperiment(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Name"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetName(this AzureBatchaiJobCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Name"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetName(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetResourceGroup(this AzureBatchaiJobCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetResourceGroup(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetWorkspace(this AzureBatchaiJobCreateSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetWorkspace(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region AfsMountPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.AfsMountPath"/></em></p>
        ///   <p>Relative mount path for Azure File Share. The File Share will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetAfsMountPath(this AzureBatchaiJobCreateSettings toolSettings, string afsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsMountPath = afsMountPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.AfsMountPath"/></em></p>
        ///   <p>Relative mount path for Azure File Share. The File Share will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetAfsMountPath(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region AfsName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.AfsName"/></em></p>
        ///   <p>Name of Azure File Share to mount during the job execution. The File Share will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name.  Multiple shares can be mounted using configuration file (see --config-file option).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetAfsName(this AzureBatchaiJobCreateSettings toolSettings, string afsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsName = afsName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.AfsName"/></em></p>
        ///   <p>Name of Azure File Share to mount during the job execution. The File Share will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name.  Multiple shares can be mounted using configuration file (see --config-file option).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetAfsName(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsName = null;
            return toolSettings;
        }
        #endregion
        #region BfsMountPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.BfsMountPath"/></em></p>
        ///   <p>Relative mount path for Azure Storage Blob Container. The container will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetBfsMountPath(this AzureBatchaiJobCreateSettings toolSettings, string bfsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsMountPath = bfsMountPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.BfsMountPath"/></em></p>
        ///   <p>Relative mount path for Azure Storage Blob Container. The container will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetBfsMountPath(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region BfsName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.BfsName"/></em></p>
        ///   <p>Name of Azure Storage Blob Container to mount during the job execution. The container will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetBfsName(this AzureBatchaiJobCreateSettings toolSettings, string bfsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsName = bfsName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.BfsName"/></em></p>
        ///   <p>Name of Azure Storage Blob Container to mount during the job execution. The container will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetBfsName(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsName = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountKey
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.StorageAccountKey"/></em></p>
        ///   <p>Storage account key. Required if the storage account belongs to a different subscription. Can be specified using AZURE_BATCHAI_STORAGE_KEY environment variable.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetStorageAccountKey(this AzureBatchaiJobCreateSettings toolSettings, string storageAccountKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = storageAccountKey;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.StorageAccountKey"/></em></p>
        ///   <p>Storage account key. Required if the storage account belongs to a different subscription. Can be specified using AZURE_BATCHAI_STORAGE_KEY environment variable.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetStorageAccountKey(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.StorageAccountName"/></em></p>
        ///   <p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Can be specified using AZURE_BATCHAI_STORAGE_ACCOUNT environment variable.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetStorageAccountName(this AzureBatchaiJobCreateSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.StorageAccountName"/></em></p>
        ///   <p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Can be specified using AZURE_BATCHAI_STORAGE_ACCOUNT environment variable.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetStorageAccountName(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region Nfs
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Nfs"/></em></p>
        ///   <p>Name or ARM ID of the file server to be mounted during the job execution. You need to provide ARM ID if the file server belongs to a different workspace. You can configure multiple file servers using job's  configuration file.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetNfs(this AzureBatchaiJobCreateSettings toolSettings, string nfs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfs = nfs;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Nfs"/></em></p>
        ///   <p>Name or ARM ID of the file server to be mounted during the job execution. You need to provide ARM ID if the file server belongs to a different workspace. You can configure multiple file servers using job's  configuration file.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetNfs(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfs = null;
            return toolSettings;
        }
        #endregion
        #region NfsMountPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.NfsMountPath"/></em></p>
        ///   <p>Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetNfsMountPath(this AzureBatchaiJobCreateSettings toolSettings, string nfsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsMountPath = nfsMountPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.NfsMountPath"/></em></p>
        ///   <p>Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetNfsMountPath(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetSubscription(this AzureBatchaiJobCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetSubscription(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetDebug(this AzureBatchaiJobCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetDebug(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetHelp(this AzureBatchaiJobCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetHelp(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetOutput(this AzureBatchaiJobCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetOutput(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetQuery(this AzureBatchaiJobCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetQuery(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetVerbose(this AzureBatchaiJobCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetVerbose(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobDeleteSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetNoWait(this AzureBatchaiJobDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetNoWait(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBatchaiJobDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings EnableNoWait(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBatchaiJobDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings DisableNoWait(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBatchaiJobDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ToggleNoWait(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetYes(this AzureBatchaiJobDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetYes(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Experiment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetExperiment(this AzureBatchaiJobDeleteSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetExperiment(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetIds(this AzureBatchaiJobDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetIds(this AzureBatchaiJobDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiJobDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings AddIds(this AzureBatchaiJobDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiJobDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings AddIds(this AzureBatchaiJobDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiJobDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ClearIds(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiJobDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings RemoveIds(this AzureBatchaiJobDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiJobDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings RemoveIds(this AzureBatchaiJobDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Name"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetName(this AzureBatchaiJobDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Name"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetName(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetResourceGroup(this AzureBatchaiJobDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetResourceGroup(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetSubscription(this AzureBatchaiJobDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetSubscription(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetWorkspace(this AzureBatchaiJobDeleteSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetWorkspace(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetDebug(this AzureBatchaiJobDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetDebug(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetHelp(this AzureBatchaiJobDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetHelp(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetOutput(this AzureBatchaiJobDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetOutput(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetQuery(this AzureBatchaiJobDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetQuery(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetVerbose(this AzureBatchaiJobDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetVerbose(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobListSettingsExtensions
    {
        #region Experiment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobListSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetExperiment(this AzureBatchaiJobListSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobListSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetExperiment(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetResourceGroup(this AzureBatchaiJobListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetResourceGroup(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetWorkspace(this AzureBatchaiJobListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetWorkspace(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetSubscription(this AzureBatchaiJobListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetSubscription(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetDebug(this AzureBatchaiJobListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetDebug(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetHelp(this AzureBatchaiJobListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetHelp(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetOutput(this AzureBatchaiJobListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetOutput(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetQuery(this AzureBatchaiJobListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetQuery(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetVerbose(this AzureBatchaiJobListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetVerbose(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobShowSettingsExtensions
    {
        #region Experiment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobShowSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetExperiment(this AzureBatchaiJobShowSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobShowSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetExperiment(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetIds(this AzureBatchaiJobShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetIds(this AzureBatchaiJobShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiJobShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings AddIds(this AzureBatchaiJobShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiJobShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings AddIds(this AzureBatchaiJobShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiJobShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ClearIds(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiJobShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings RemoveIds(this AzureBatchaiJobShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiJobShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings RemoveIds(this AzureBatchaiJobShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobShowSettings.Name"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetName(this AzureBatchaiJobShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobShowSettings.Name"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetName(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetResourceGroup(this AzureBatchaiJobShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetResourceGroup(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetSubscription(this AzureBatchaiJobShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetSubscription(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobShowSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetWorkspace(this AzureBatchaiJobShowSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobShowSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetWorkspace(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetDebug(this AzureBatchaiJobShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetDebug(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetHelp(this AzureBatchaiJobShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetHelp(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetOutput(this AzureBatchaiJobShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetOutput(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetQuery(this AzureBatchaiJobShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetQuery(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetVerbose(this AzureBatchaiJobShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetVerbose(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobTerminateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobTerminateSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetNoWait(this AzureBatchaiJobTerminateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetNoWait(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBatchaiJobTerminateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings EnableNoWait(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBatchaiJobTerminateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings DisableNoWait(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBatchaiJobTerminateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ToggleNoWait(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetYes(this AzureBatchaiJobTerminateSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetYes(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Experiment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetExperiment(this AzureBatchaiJobTerminateSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetExperiment(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetIds(this AzureBatchaiJobTerminateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetIds(this AzureBatchaiJobTerminateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiJobTerminateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings AddIds(this AzureBatchaiJobTerminateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiJobTerminateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings AddIds(this AzureBatchaiJobTerminateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiJobTerminateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ClearIds(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiJobTerminateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings RemoveIds(this AzureBatchaiJobTerminateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiJobTerminateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings RemoveIds(this AzureBatchaiJobTerminateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Name"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetName(this AzureBatchaiJobTerminateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Name"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetName(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetResourceGroup(this AzureBatchaiJobTerminateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetResourceGroup(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetSubscription(this AzureBatchaiJobTerminateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetSubscription(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetWorkspace(this AzureBatchaiJobTerminateSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetWorkspace(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetDebug(this AzureBatchaiJobTerminateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetDebug(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetHelp(this AzureBatchaiJobTerminateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetHelp(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetOutput(this AzureBatchaiJobTerminateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetOutput(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetQuery(this AzureBatchaiJobTerminateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetQuery(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetVerbose(this AzureBatchaiJobTerminateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetVerbose(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobWaitSettingsExtensions
    {
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in sec.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetInterval(this AzureBatchaiJobWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in sec.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetInterval(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Experiment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetExperiment(this AzureBatchaiJobWaitSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetExperiment(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetIds(this AzureBatchaiJobWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetIds(this AzureBatchaiJobWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiJobWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings AddIds(this AzureBatchaiJobWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiJobWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings AddIds(this AzureBatchaiJobWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiJobWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ClearIds(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiJobWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings RemoveIds(this AzureBatchaiJobWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiJobWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings RemoveIds(this AzureBatchaiJobWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Name"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetName(this AzureBatchaiJobWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Name"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetName(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetResourceGroup(this AzureBatchaiJobWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetResourceGroup(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetSubscription(this AzureBatchaiJobWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetSubscription(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetWorkspace(this AzureBatchaiJobWaitSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetWorkspace(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetDebug(this AzureBatchaiJobWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetDebug(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetHelp(this AzureBatchaiJobWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetHelp(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetOutput(this AzureBatchaiJobWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetOutput(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetQuery(this AzureBatchaiJobWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetQuery(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetVerbose(this AzureBatchaiJobWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetVerbose(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiWorkspaceCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiWorkspaceCreateSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetResourceGroup(this AzureBatchaiWorkspaceCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetResourceGroup(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetWorkspace(this AzureBatchaiWorkspaceCreateSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetWorkspace(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Location"/></em></p>
        ///   <p>Location of the workspace. If omitted, the location of the resource group will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetLocation(this AzureBatchaiWorkspaceCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Location"/></em></p>
        ///   <p>Location of the workspace. If omitted, the location of the resource group will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetLocation(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetSubscription(this AzureBatchaiWorkspaceCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetSubscription(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetDebug(this AzureBatchaiWorkspaceCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetDebug(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetHelp(this AzureBatchaiWorkspaceCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetHelp(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetOutput(this AzureBatchaiWorkspaceCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetOutput(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetQuery(this AzureBatchaiWorkspaceCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetQuery(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetVerbose(this AzureBatchaiWorkspaceCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetVerbose(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiWorkspaceDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiWorkspaceDeleteSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetNoWait(this AzureBatchaiWorkspaceDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetNoWait(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBatchaiWorkspaceDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings EnableNoWait(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBatchaiWorkspaceDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings DisableNoWait(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBatchaiWorkspaceDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ToggleNoWait(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetYes(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetYes(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetIds(this AzureBatchaiWorkspaceDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetIds(this AzureBatchaiWorkspaceDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiWorkspaceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings AddIds(this AzureBatchaiWorkspaceDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiWorkspaceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings AddIds(this AzureBatchaiWorkspaceDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiWorkspaceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ClearIds(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiWorkspaceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings RemoveIds(this AzureBatchaiWorkspaceDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiWorkspaceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings RemoveIds(this AzureBatchaiWorkspaceDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetResourceGroup(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetResourceGroup(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetSubscription(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetSubscription(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetWorkspace(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetWorkspace(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetDebug(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetDebug(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetHelp(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetHelp(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetOutput(this AzureBatchaiWorkspaceDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetOutput(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetQuery(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetQuery(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetVerbose(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetVerbose(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiWorkspaceListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiWorkspaceListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings SetResourceGroup(this AzureBatchaiWorkspaceListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings ResetResourceGroup(this AzureBatchaiWorkspaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings SetSubscription(this AzureBatchaiWorkspaceListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings ResetSubscription(this AzureBatchaiWorkspaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings SetDebug(this AzureBatchaiWorkspaceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings ResetDebug(this AzureBatchaiWorkspaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings SetHelp(this AzureBatchaiWorkspaceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings ResetHelp(this AzureBatchaiWorkspaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings SetOutput(this AzureBatchaiWorkspaceListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings ResetOutput(this AzureBatchaiWorkspaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings SetQuery(this AzureBatchaiWorkspaceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings ResetQuery(this AzureBatchaiWorkspaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings SetVerbose(this AzureBatchaiWorkspaceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings ResetVerbose(this AzureBatchaiWorkspaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiWorkspaceShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiWorkspaceShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetIds(this AzureBatchaiWorkspaceShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetIds(this AzureBatchaiWorkspaceShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiWorkspaceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings AddIds(this AzureBatchaiWorkspaceShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBatchaiWorkspaceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings AddIds(this AzureBatchaiWorkspaceShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBatchaiWorkspaceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ClearIds(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiWorkspaceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings RemoveIds(this AzureBatchaiWorkspaceShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBatchaiWorkspaceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings RemoveIds(this AzureBatchaiWorkspaceShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetResourceGroup(this AzureBatchaiWorkspaceShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetResourceGroup(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetSubscription(this AzureBatchaiWorkspaceShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetSubscription(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetWorkspace(this AzureBatchaiWorkspaceShowSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetWorkspace(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetDebug(this AzureBatchaiWorkspaceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetDebug(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetHelp(this AzureBatchaiWorkspaceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetHelp(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetOutput(this AzureBatchaiWorkspaceShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetOutput(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetQuery(this AzureBatchaiWorkspaceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetQuery(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetVerbose(this AzureBatchaiWorkspaceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetVerbose(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterFileListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterFileListSettingsExtensions
    {
        #region Cluster
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Cluster"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetCluster(this AzureBatchaiClusterFileListSettings toolSettings, string cluster)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = cluster;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Cluster"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetCluster(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetResourceGroup(this AzureBatchaiClusterFileListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetResourceGroup(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetWorkspace(this AzureBatchaiClusterFileListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetWorkspace(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Expiry
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Expiry"/></em></p>
        ///   <p>Time in minutes for how long generated download URLs should remain valid.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetExpiry(this AzureBatchaiClusterFileListSettings toolSettings, string expiry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expiry = expiry;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Expiry"/></em></p>
        ///   <p>Time in minutes for how long generated download URLs should remain valid.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetExpiry(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expiry = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Path"/></em></p>
        ///   <p>Relative path of a subfolder inside of the node setup task output directory.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetPath(this AzureBatchaiClusterFileListSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Path"/></em></p>
        ///   <p>Relative path of a subfolder inside of the node setup task output directory.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetPath(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetSubscription(this AzureBatchaiClusterFileListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetSubscription(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetDebug(this AzureBatchaiClusterFileListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetDebug(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetHelp(this AzureBatchaiClusterFileListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetHelp(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetOutput(this AzureBatchaiClusterFileListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetOutput(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetQuery(this AzureBatchaiClusterFileListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetQuery(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetVerbose(this AzureBatchaiClusterFileListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetVerbose(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterNodeExecSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterNodeExecSettingsExtensions
    {
        #region Cluster
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Cluster"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetCluster(this AzureBatchaiClusterNodeExecSettings toolSettings, string cluster)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = cluster;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Cluster"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetCluster(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetResourceGroup(this AzureBatchaiClusterNodeExecSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetResourceGroup(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetWorkspace(this AzureBatchaiClusterNodeExecSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetWorkspace(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Address
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Address"/></em></p>
        ///   <p>Specifies that connections to the given TCP port or Unix socket on the local (client) host are to be forwarded to the given host and port, or Unix socket, on the remote side. e.g. -L 8080:localhost:8080.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetAddress(this AzureBatchaiClusterNodeExecSettings toolSettings, string address)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Address = address;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Address"/></em></p>
        ///   <p>Specifies that connections to the given TCP port or Unix socket on the local (client) host are to be forwarded to the given host and port, or Unix socket, on the remote side. e.g. -L 8080:localhost:8080.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetAddress(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Address = null;
            return toolSettings;
        }
        #endregion
        #region Exec
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Exec"/></em></p>
        ///   <p>Optional command line to be executed on the node. If not provided, the command will perform ports forwarding only.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetExec(this AzureBatchaiClusterNodeExecSettings toolSettings, string exec)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exec = exec;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Exec"/></em></p>
        ///   <p>Optional command line to be executed on the node. If not provided, the command will perform ports forwarding only.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetExec(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exec = null;
            return toolSettings;
        }
        #endregion
        #region NodeId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.NodeId"/></em></p>
        ///   <p>ID of the node to forward the ports to. If not provided, the command will be executed on the first available node.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetNodeId(this AzureBatchaiClusterNodeExecSettings toolSettings, string nodeId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeId = nodeId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.NodeId"/></em></p>
        ///   <p>ID of the node to forward the ports to. If not provided, the command will be executed on the first available node.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetNodeId(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeId = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Password"/></em></p>
        ///   <p>Optional password to establish SSH connection.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetPassword(this AzureBatchaiClusterNodeExecSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Password"/></em></p>
        ///   <p>Optional password to establish SSH connection.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetPassword(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region SshPrivateKey
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.SshPrivateKey"/></em></p>
        ///   <p>Optional SSH private key path to establish SSH connection. If omitted, the default SSH private key will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetSshPrivateKey(this AzureBatchaiClusterNodeExecSettings toolSettings, string sshPrivateKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPrivateKey = sshPrivateKey;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.SshPrivateKey"/></em></p>
        ///   <p>Optional SSH private key path to establish SSH connection. If omitted, the default SSH private key will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetSshPrivateKey(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPrivateKey = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetSubscription(this AzureBatchaiClusterNodeExecSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetSubscription(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetDebug(this AzureBatchaiClusterNodeExecSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetDebug(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetHelp(this AzureBatchaiClusterNodeExecSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetHelp(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetOutput(this AzureBatchaiClusterNodeExecSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetOutput(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetQuery(this AzureBatchaiClusterNodeExecSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetQuery(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetVerbose(this AzureBatchaiClusterNodeExecSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetVerbose(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterNodeListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterNodeListSettingsExtensions
    {
        #region Cluster
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Cluster"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetCluster(this AzureBatchaiClusterNodeListSettings toolSettings, string cluster)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = cluster;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Cluster"/></em></p>
        ///   <p>Name of cluster.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetCluster(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetResourceGroup(this AzureBatchaiClusterNodeListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetResourceGroup(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetWorkspace(this AzureBatchaiClusterNodeListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetWorkspace(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetSubscription(this AzureBatchaiClusterNodeListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetSubscription(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetDebug(this AzureBatchaiClusterNodeListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetDebug(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetHelp(this AzureBatchaiClusterNodeListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetHelp(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetOutput(this AzureBatchaiClusterNodeListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetOutput(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetQuery(this AzureBatchaiClusterNodeListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetQuery(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetVerbose(this AzureBatchaiClusterNodeListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetVerbose(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobFileListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobFileListSettingsExtensions
    {
        #region Experiment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetExperiment(this AzureBatchaiJobFileListSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetExperiment(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Job
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Job"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetJob(this AzureBatchaiJobFileListSettings toolSettings, string job)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = job;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Job"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetJob(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetResourceGroup(this AzureBatchaiJobFileListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetResourceGroup(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetWorkspace(this AzureBatchaiJobFileListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetWorkspace(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Expiry
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Expiry"/></em></p>
        ///   <p>Time in minutes for how long generated download URL should remain valid.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetExpiry(this AzureBatchaiJobFileListSettings toolSettings, string expiry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expiry = expiry;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Expiry"/></em></p>
        ///   <p>Time in minutes for how long generated download URL should remain valid.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetExpiry(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expiry = null;
            return toolSettings;
        }
        #endregion
        #region OutputDirectoryId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileListSettings.OutputDirectoryId"/></em></p>
        ///   <p>The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetOutputDirectoryId(this AzureBatchaiJobFileListSettings toolSettings, string outputDirectoryId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDirectoryId = outputDirectoryId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileListSettings.OutputDirectoryId"/></em></p>
        ///   <p>The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetOutputDirectoryId(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDirectoryId = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Path"/></em></p>
        ///   <p>Relative path in the given output directory.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetPath(this AzureBatchaiJobFileListSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Path"/></em></p>
        ///   <p>Relative path in the given output directory.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetPath(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetSubscription(this AzureBatchaiJobFileListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetSubscription(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetDebug(this AzureBatchaiJobFileListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetDebug(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetHelp(this AzureBatchaiJobFileListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetHelp(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetOutput(this AzureBatchaiJobFileListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetOutput(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetQuery(this AzureBatchaiJobFileListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetQuery(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetVerbose(this AzureBatchaiJobFileListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetVerbose(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobFileStreamSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobFileStreamSettingsExtensions
    {
        #region Experiment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetExperiment(this AzureBatchaiJobFileStreamSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetExperiment(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region FileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.FileName"/></em></p>
        ///   <p>The name of the file to stream.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetFileName(this AzureBatchaiJobFileStreamSettings toolSettings, string fileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileName = fileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.FileName"/></em></p>
        ///   <p>The name of the file to stream.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetFileName(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileName = null;
            return toolSettings;
        }
        #endregion
        #region Job
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Job"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetJob(this AzureBatchaiJobFileStreamSettings toolSettings, string job)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = job;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Job"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetJob(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetResourceGroup(this AzureBatchaiJobFileStreamSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetResourceGroup(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetWorkspace(this AzureBatchaiJobFileStreamSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetWorkspace(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region OutputDirectoryId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.OutputDirectoryId"/></em></p>
        ///   <p>The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetOutputDirectoryId(this AzureBatchaiJobFileStreamSettings toolSettings, string outputDirectoryId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDirectoryId = outputDirectoryId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.OutputDirectoryId"/></em></p>
        ///   <p>The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetOutputDirectoryId(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDirectoryId = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Path"/></em></p>
        ///   <p>Relative path in the given output directory.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetPath(this AzureBatchaiJobFileStreamSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Path"/></em></p>
        ///   <p>Relative path in the given output directory.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetPath(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetSubscription(this AzureBatchaiJobFileStreamSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetSubscription(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetDebug(this AzureBatchaiJobFileStreamSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetDebug(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetHelp(this AzureBatchaiJobFileStreamSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetHelp(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetOutput(this AzureBatchaiJobFileStreamSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetOutput(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetQuery(this AzureBatchaiJobFileStreamSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetQuery(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetVerbose(this AzureBatchaiJobFileStreamSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetVerbose(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobNodeExecSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobNodeExecSettingsExtensions
    {
        #region Experiment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetExperiment(this AzureBatchaiJobNodeExecSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetExperiment(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Job
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Job"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetJob(this AzureBatchaiJobNodeExecSettings toolSettings, string job)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = job;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Job"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetJob(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetResourceGroup(this AzureBatchaiJobNodeExecSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetResourceGroup(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetWorkspace(this AzureBatchaiJobNodeExecSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetWorkspace(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Address
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Address"/></em></p>
        ///   <p>Specifies that connections to the given TCP port or Unix socket on the local (client) host are to be forwarded to the given host and port, or Unix socket, on the remote side. e.g. -L 8080:localhost:8080.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetAddress(this AzureBatchaiJobNodeExecSettings toolSettings, string address)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Address = address;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Address"/></em></p>
        ///   <p>Specifies that connections to the given TCP port or Unix socket on the local (client) host are to be forwarded to the given host and port, or Unix socket, on the remote side. e.g. -L 8080:localhost:8080.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetAddress(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Address = null;
            return toolSettings;
        }
        #endregion
        #region Exec
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Exec"/></em></p>
        ///   <p>Optional command line to be executed on the node. If not provided, the command will perform ports forwarding only.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetExec(this AzureBatchaiJobNodeExecSettings toolSettings, string exec)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exec = exec;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Exec"/></em></p>
        ///   <p>Optional command line to be executed on the node. If not provided, the command will perform ports forwarding only.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetExec(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exec = null;
            return toolSettings;
        }
        #endregion
        #region NodeId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.NodeId"/></em></p>
        ///   <p>ID of the node to forward the ports to. If not provided, the command will be executed on the first available node.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetNodeId(this AzureBatchaiJobNodeExecSettings toolSettings, string nodeId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeId = nodeId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.NodeId"/></em></p>
        ///   <p>ID of the node to forward the ports to. If not provided, the command will be executed on the first available node.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetNodeId(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeId = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Password"/></em></p>
        ///   <p>Optional password to establish SSH connection.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetPassword(this AzureBatchaiJobNodeExecSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Password"/></em></p>
        ///   <p>Optional password to establish SSH connection.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetPassword(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region SshPrivateKey
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.SshPrivateKey"/></em></p>
        ///   <p>Optional SSH private key path to establish SSH connection. If omitted, the default SSH private key will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetSshPrivateKey(this AzureBatchaiJobNodeExecSettings toolSettings, string sshPrivateKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPrivateKey = sshPrivateKey;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.SshPrivateKey"/></em></p>
        ///   <p>Optional SSH private key path to establish SSH connection. If omitted, the default SSH private key will be used.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetSshPrivateKey(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPrivateKey = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetSubscription(this AzureBatchaiJobNodeExecSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetSubscription(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetDebug(this AzureBatchaiJobNodeExecSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetDebug(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetHelp(this AzureBatchaiJobNodeExecSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetHelp(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetOutput(this AzureBatchaiJobNodeExecSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetOutput(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetQuery(this AzureBatchaiJobNodeExecSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetQuery(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetVerbose(this AzureBatchaiJobNodeExecSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetVerbose(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobNodeListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobNodeListSettingsExtensions
    {
        #region Experiment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetExperiment(this AzureBatchaiJobNodeListSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Experiment"/></em></p>
        ///   <p>Name of experiment.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetExperiment(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Job
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Job"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetJob(this AzureBatchaiJobNodeListSettings toolSettings, string job)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = job;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Job"/></em></p>
        ///   <p>Name of job.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetJob(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetResourceGroup(this AzureBatchaiJobNodeListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetResourceGroup(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetWorkspace(this AzureBatchaiJobNodeListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Workspace"/></em></p>
        ///   <p>Name of workspace.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetWorkspace(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetSubscription(this AzureBatchaiJobNodeListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetSubscription(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetDebug(this AzureBatchaiJobNodeListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetDebug(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetHelp(this AzureBatchaiJobNodeListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetHelp(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetOutput(this AzureBatchaiJobNodeListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetOutput(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetQuery(this AzureBatchaiJobNodeListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetQuery(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetVerbose(this AzureBatchaiJobNodeListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetVerbose(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region BatchaiClusterCreateVmPriority
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<BatchaiClusterCreateVmPriority>))]
    public partial class BatchaiClusterCreateVmPriority : Enumeration
    {
        public static BatchaiClusterCreateVmPriority dedicated = new BatchaiClusterCreateVmPriority { Value = "dedicated" };
        public static BatchaiClusterCreateVmPriority lowpriority = new BatchaiClusterCreateVmPriority { Value = "lowpriority" };
    }
    #endregion
    #region BatchaiFileServerCreateCachingType
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<BatchaiFileServerCreateCachingType>))]
    public partial class BatchaiFileServerCreateCachingType : Enumeration
    {
        public static BatchaiFileServerCreateCachingType none = new BatchaiFileServerCreateCachingType { Value = "none" };
        public static BatchaiFileServerCreateCachingType readonly_ = new BatchaiFileServerCreateCachingType { Value = "readonly" };
        public static BatchaiFileServerCreateCachingType readwrite = new BatchaiFileServerCreateCachingType { Value = "readwrite" };
    }
    #endregion
    #region BatchaiFileServerCreateStorageSku
    /// <summary>
    ///   Used within <see cref="AzureBatchaiTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<BatchaiFileServerCreateStorageSku>))]
    public partial class BatchaiFileServerCreateStorageSku : Enumeration
    {
        public static BatchaiFileServerCreateStorageSku premium_lrs = new BatchaiFileServerCreateStorageSku { Value = "premium_lrs" };
        public static BatchaiFileServerCreateStorageSku standard_lrs = new BatchaiFileServerCreateStorageSku { Value = "standard_lrs" };
    }
    #endregion
}
