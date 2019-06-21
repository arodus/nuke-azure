// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzureSnapshot.json
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
    public static partial class AzureSnapshotTasks
    {
        /// <summary>
        ///   Path to the AzureSnapshot executable.
        /// </summary>
        public static string AzureSnapshotPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURESNAPSHOT_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureSnapshotLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage point-in-time copies of managed disks, native blobs, or other snapshots.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSnapshot(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureSnapshotPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureSnapshotLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSnapshotCreate(AzureSnapshotCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSnapshotCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotCreateSettings.Debug"/></li>
        ///     <li><c>--for-upload</c> via <see cref="AzureSnapshotCreateSettings.ForUpload"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotCreateSettings.Help"/></li>
        ///     <li><c>--hyper-v-generation</c> via <see cref="AzureSnapshotCreateSettings.HyperVGeneration"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSnapshotCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureSnapshotCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--size-gb</c> via <see cref="AzureSnapshotCreateSettings.SizeGb"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureSnapshotCreateSettings.Sku"/></li>
        ///     <li><c>--source</c> via <see cref="AzureSnapshotCreateSettings.Source"/></li>
        ///     <li><c>--source-storage-account-id</c> via <see cref="AzureSnapshotCreateSettings.SourceStorageAccountId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureSnapshotCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSnapshotCreate(Configure<AzureSnapshotCreateSettings> configurator)
        {
            return AzureSnapshotCreate(configurator(new AzureSnapshotCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotCreateSettings.Debug"/></li>
        ///     <li><c>--for-upload</c> via <see cref="AzureSnapshotCreateSettings.ForUpload"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotCreateSettings.Help"/></li>
        ///     <li><c>--hyper-v-generation</c> via <see cref="AzureSnapshotCreateSettings.HyperVGeneration"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSnapshotCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureSnapshotCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--size-gb</c> via <see cref="AzureSnapshotCreateSettings.SizeGb"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureSnapshotCreateSettings.Sku"/></li>
        ///     <li><c>--source</c> via <see cref="AzureSnapshotCreateSettings.Source"/></li>
        ///     <li><c>--source-storage-account-id</c> via <see cref="AzureSnapshotCreateSettings.SourceStorageAccountId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureSnapshotCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSnapshotCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSnapshotCreate(CombinatorialConfigure<AzureSnapshotCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSnapshotCreate, AzureSnapshotLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSnapshotDelete(AzureSnapshotDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSnapshotDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSnapshotDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSnapshotDelete(Configure<AzureSnapshotDeleteSettings> configurator)
        {
            return AzureSnapshotDelete(configurator(new AzureSnapshotDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSnapshotDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSnapshotDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureSnapshotDelete(CombinatorialConfigure<AzureSnapshotDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSnapshotDelete, AzureSnapshotLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSnapshotGrantAccess(AzureSnapshotGrantAccessSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSnapshotGrantAccessSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--access-level</c> via <see cref="AzureSnapshotGrantAccessSettings.AccessLevel"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotGrantAccessSettings.Debug"/></li>
        ///     <li><c>--duration-in-seconds</c> via <see cref="AzureSnapshotGrantAccessSettings.DurationInSeconds"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotGrantAccessSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSnapshotGrantAccessSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotGrantAccessSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotGrantAccessSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotGrantAccessSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotGrantAccessSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotGrantAccessSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotGrantAccessSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSnapshotGrantAccess(Configure<AzureSnapshotGrantAccessSettings> configurator)
        {
            return AzureSnapshotGrantAccess(configurator(new AzureSnapshotGrantAccessSettings()));
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--access-level</c> via <see cref="AzureSnapshotGrantAccessSettings.AccessLevel"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotGrantAccessSettings.Debug"/></li>
        ///     <li><c>--duration-in-seconds</c> via <see cref="AzureSnapshotGrantAccessSettings.DurationInSeconds"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotGrantAccessSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSnapshotGrantAccessSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotGrantAccessSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotGrantAccessSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotGrantAccessSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotGrantAccessSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotGrantAccessSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotGrantAccessSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSnapshotGrantAccessSettings Settings, IReadOnlyCollection<Output> Output)> AzureSnapshotGrantAccess(CombinatorialConfigure<AzureSnapshotGrantAccessSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSnapshotGrantAccess, AzureSnapshotLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSnapshotList(AzureSnapshotListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSnapshotListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSnapshotList(Configure<AzureSnapshotListSettings> configurator)
        {
            return AzureSnapshotList(configurator(new AzureSnapshotListSettings()));
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSnapshotListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSnapshotList(CombinatorialConfigure<AzureSnapshotListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSnapshotList, AzureSnapshotLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSnapshotRevokeAccess(AzureSnapshotRevokeAccessSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSnapshotRevokeAccessSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotRevokeAccessSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotRevokeAccessSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSnapshotRevokeAccessSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotRevokeAccessSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotRevokeAccessSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotRevokeAccessSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotRevokeAccessSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotRevokeAccessSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotRevokeAccessSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSnapshotRevokeAccess(Configure<AzureSnapshotRevokeAccessSettings> configurator)
        {
            return AzureSnapshotRevokeAccess(configurator(new AzureSnapshotRevokeAccessSettings()));
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotRevokeAccessSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotRevokeAccessSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSnapshotRevokeAccessSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotRevokeAccessSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotRevokeAccessSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotRevokeAccessSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotRevokeAccessSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotRevokeAccessSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotRevokeAccessSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSnapshotRevokeAccessSettings Settings, IReadOnlyCollection<Output> Output)> AzureSnapshotRevokeAccess(CombinatorialConfigure<AzureSnapshotRevokeAccessSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSnapshotRevokeAccess, AzureSnapshotLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSnapshotShow(AzureSnapshotShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSnapshotShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSnapshotShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSnapshotShow(Configure<AzureSnapshotShowSettings> configurator)
        {
            return AzureSnapshotShow(configurator(new AzureSnapshotShowSettings()));
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSnapshotShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSnapshotShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSnapshotShow(CombinatorialConfigure<AzureSnapshotShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSnapshotShow, AzureSnapshotLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSnapshotUpdate(AzureSnapshotUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSnapshotUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureSnapshotUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureSnapshotUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSnapshotUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotUpdateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureSnapshotUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureSnapshotUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureSnapshotUpdateSettings.Set"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureSnapshotUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSnapshotUpdate(Configure<AzureSnapshotUpdateSettings> configurator)
        {
            return AzureSnapshotUpdate(configurator(new AzureSnapshotUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureSnapshotUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureSnapshotUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSnapshotUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotUpdateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureSnapshotUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureSnapshotUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureSnapshotUpdateSettings.Set"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureSnapshotUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSnapshotUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSnapshotUpdate(CombinatorialConfigure<AzureSnapshotUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSnapshotUpdate, AzureSnapshotLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSnapshotWait(AzureSnapshotWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSnapshotWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureSnapshotWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureSnapshotWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureSnapshotWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureSnapshotWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSnapshotWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureSnapshotWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureSnapshotWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureSnapshotWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSnapshotWait(Configure<AzureSnapshotWaitSettings> configurator)
        {
            return AzureSnapshotWait(configurator(new AzureSnapshotWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage point-in-time copies of managed disks, native blobs, or other snapshots.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/snapshot?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureSnapshotWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureSnapshotWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSnapshotWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureSnapshotWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureSnapshotWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSnapshotWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSnapshotWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureSnapshotWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSnapshotWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSnapshotWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSnapshotWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSnapshotWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSnapshotWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureSnapshotWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureSnapshotWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSnapshotWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSnapshotWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureSnapshotWait(CombinatorialConfigure<AzureSnapshotWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSnapshotWait, AzureSnapshotLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureSnapshotCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSnapshotCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSnapshot executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSnapshotTasks.AzureSnapshotPath;
        public override Action<OutputType, string> CustomLogger => AzureSnapshotTasks.AzureSnapshotLogger;
        /// <summary>
        ///   The name of the snapshot.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Create the snapshot for uploading blobs later on through storage commands. Run "az snapshot grant-access --access-level Write" to retrieve the snapshot's SAS token.
        /// </summary>
        public virtual bool? ForUpload { get; internal set; }
        /// <summary>
        ///   The hypervisor generation of the Virtual Machine. Applicable to OS disks only.
        /// </summary>
        public virtual SnapshotCreateHyperVGeneration HyperVGeneration { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Size in GB. Max size: 4095 GB (certain preview disks can be larger).
        /// </summary>
        public virtual string SizeGb { get; internal set; }
        public virtual SnapshotSku Sku { get; internal set; }
        /// <summary>
        ///   Source to create the disk/snapshot from, including unmanaged blob uri, managed disk id or name, or snapshot id or name.
        /// </summary>
        public virtual string Source { get; internal set; }
        /// <summary>
        ///   Used when source blob is in a different subscription.
        /// </summary>
        public virtual string SourceStorageAccountId { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
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
              .Add("snapshot create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--for-upload", ForUpload)
              .Add("--hyper-v-generation {value}", HyperVGeneration)
              .Add("--location {value}", Location)
              .Add("--no-wait", NoWait)
              .Add("--size-gb {value}", SizeGb)
              .Add("--sku {value}", Sku)
              .Add("--source {value}", Source)
              .Add("--source-storage-account-id {value}", SourceStorageAccountId)
              .Add("--tags {value}", Tags)
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
    #region AzureSnapshotDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSnapshotDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSnapshot executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSnapshotTasks.AzureSnapshotPath;
        public override Action<OutputType, string> CustomLogger => AzureSnapshotTasks.AzureSnapshotLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the snapshot.
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
              .Add("snapshot delete")
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
    #region AzureSnapshotGrantAccessSettings
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSnapshotGrantAccessSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSnapshot executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSnapshotTasks.AzureSnapshotPath;
        public override Action<OutputType, string> CustomLogger => AzureSnapshotTasks.AzureSnapshotLogger;
        /// <summary>
        ///   Time duration in seconds until the SAS access expires.
        /// </summary>
        public virtual string DurationInSeconds { get; internal set; }
        /// <summary>
        ///   Access level.
        /// </summary>
        public virtual SnapshotGrantAccessAccessLevel AccessLevel { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the snapshot.
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
              .Add("snapshot grant-access")
              .Add("--duration-in-seconds {value}", DurationInSeconds)
              .Add("--access-level {value}", AccessLevel)
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
    #region AzureSnapshotListSettings
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSnapshotListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSnapshot executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSnapshotTasks.AzureSnapshotPath;
        public override Action<OutputType, string> CustomLogger => AzureSnapshotTasks.AzureSnapshotLogger;
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
              .Add("snapshot list")
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
    #region AzureSnapshotRevokeAccessSettings
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSnapshotRevokeAccessSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSnapshot executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSnapshotTasks.AzureSnapshotPath;
        public override Action<OutputType, string> CustomLogger => AzureSnapshotTasks.AzureSnapshotLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the snapshot.
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
              .Add("snapshot revoke-access")
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
    #region AzureSnapshotShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSnapshotShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSnapshot executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSnapshotTasks.AzureSnapshotPath;
        public override Action<OutputType, string> CustomLogger => AzureSnapshotTasks.AzureSnapshotLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the snapshot.
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
              .Add("snapshot show")
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
    #region AzureSnapshotUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSnapshotUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSnapshot executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSnapshotTasks.AzureSnapshotPath;
        public override Action<OutputType, string> CustomLogger => AzureSnapshotTasks.AzureSnapshotLogger;
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        public virtual SnapshotSku Sku { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the snapshot.
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
        ///   Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.
        /// </summary>
        public virtual string Add { get; internal set; }
        /// <summary>
        ///   When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public virtual string ForceString { get; internal set; }
        /// <summary>
        ///   Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.
        /// </summary>
        public virtual string Remove { get; internal set; }
        /// <summary>
        ///   Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.
        /// </summary>
        public virtual string Set { get; internal set; }
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
              .Add("snapshot update")
              .Add("--no-wait", NoWait)
              .Add("--sku {value}", Sku)
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
    #region AzureSnapshotWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSnapshotWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSnapshot executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSnapshotTasks.AzureSnapshotPath;
        public override Action<OutputType, string> CustomLogger => AzureSnapshotTasks.AzureSnapshotLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the snapshot.
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
        ///   Wait until created with 'provisioningState' at 'Succeeded'.
        /// </summary>
        public virtual string Created { get; internal set; }
        /// <summary>
        ///   Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].
        /// </summary>
        public virtual string Custom { get; internal set; }
        /// <summary>
        ///   Wait until deleted.
        /// </summary>
        public virtual string Deleted { get; internal set; }
        /// <summary>
        ///   Wait until the resource exists.
        /// </summary>
        public virtual string Exists { get; internal set; }
        /// <summary>
        ///   Polling interval in seconds.
        /// </summary>
        public virtual string Interval { get; internal set; }
        /// <summary>
        ///   Maximum wait in seconds.
        /// </summary>
        public virtual string Timeout { get; internal set; }
        /// <summary>
        ///   Wait until updated with provisioningState at 'Succeeded'.
        /// </summary>
        public virtual string Updated { get; internal set; }
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
              .Add("snapshot wait")
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
    #region AzureSnapshotCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSnapshotCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetName(this AzureSnapshotCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetName(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetResourceGroup(this AzureSnapshotCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetResourceGroup(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ForUpload
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.ForUpload"/></em></p>
        ///   <p>Create the snapshot for uploading blobs later on through storage commands. Run "az snapshot grant-access --access-level Write" to retrieve the snapshot's SAS token.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetForUpload(this AzureSnapshotCreateSettings toolSettings, bool? forUpload)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForUpload = forUpload;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.ForUpload"/></em></p>
        ///   <p>Create the snapshot for uploading blobs later on through storage commands. Run "az snapshot grant-access --access-level Write" to retrieve the snapshot's SAS token.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetForUpload(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForUpload = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureSnapshotCreateSettings.ForUpload"/></em></p>
        ///   <p>Create the snapshot for uploading blobs later on through storage commands. Run "az snapshot grant-access --access-level Write" to retrieve the snapshot's SAS token.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings EnableForUpload(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForUpload = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureSnapshotCreateSettings.ForUpload"/></em></p>
        ///   <p>Create the snapshot for uploading blobs later on through storage commands. Run "az snapshot grant-access --access-level Write" to retrieve the snapshot's SAS token.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings DisableForUpload(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForUpload = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureSnapshotCreateSettings.ForUpload"/></em></p>
        ///   <p>Create the snapshot for uploading blobs later on through storage commands. Run "az snapshot grant-access --access-level Write" to retrieve the snapshot's SAS token.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ToggleForUpload(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForUpload = !toolSettings.ForUpload;
            return toolSettings;
        }
        #endregion
        #region HyperVGeneration
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.HyperVGeneration"/></em></p>
        ///   <p>The hypervisor generation of the Virtual Machine. Applicable to OS disks only.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetHyperVGeneration(this AzureSnapshotCreateSettings toolSettings, SnapshotCreateHyperVGeneration hyperVGeneration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HyperVGeneration = hyperVGeneration;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.HyperVGeneration"/></em></p>
        ///   <p>The hypervisor generation of the Virtual Machine. Applicable to OS disks only.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetHyperVGeneration(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HyperVGeneration = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetLocation(this AzureSnapshotCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetLocation(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetNoWait(this AzureSnapshotCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetNoWait(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureSnapshotCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings EnableNoWait(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureSnapshotCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings DisableNoWait(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureSnapshotCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ToggleNoWait(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region SizeGb
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.SizeGb"/></em></p>
        ///   <p>Size in GB. Max size: 4095 GB (certain preview disks can be larger).</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetSizeGb(this AzureSnapshotCreateSettings toolSettings, string sizeGb)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SizeGb = sizeGb;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.SizeGb"/></em></p>
        ///   <p>Size in GB. Max size: 4095 GB (certain preview disks can be larger).</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetSizeGb(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SizeGb = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.Sku"/></em></p>
        ///   <p></p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetSku(this AzureSnapshotCreateSettings toolSettings, SnapshotSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.Sku"/></em></p>
        ///   <p></p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetSku(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Source
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.Source"/></em></p>
        ///   <p>Source to create the disk/snapshot from, including unmanaged blob uri, managed disk id or name, or snapshot id or name.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetSource(this AzureSnapshotCreateSettings toolSettings, string source)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = source;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.Source"/></em></p>
        ///   <p>Source to create the disk/snapshot from, including unmanaged blob uri, managed disk id or name, or snapshot id or name.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetSource(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = null;
            return toolSettings;
        }
        #endregion
        #region SourceStorageAccountId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.SourceStorageAccountId"/></em></p>
        ///   <p>Used when source blob is in a different subscription.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetSourceStorageAccountId(this AzureSnapshotCreateSettings toolSettings, string sourceStorageAccountId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceStorageAccountId = sourceStorageAccountId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.SourceStorageAccountId"/></em></p>
        ///   <p>Used when source blob is in a different subscription.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetSourceStorageAccountId(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceStorageAccountId = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetTags(this AzureSnapshotCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetTags(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetSubscription(this AzureSnapshotCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetSubscription(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetDebug(this AzureSnapshotCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetDebug(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetHelp(this AzureSnapshotCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetHelp(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetOutput(this AzureSnapshotCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetOutput(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetQuery(this AzureSnapshotCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetQuery(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings SetVerbose(this AzureSnapshotCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotCreateSettings ResetVerbose(this AzureSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSnapshotDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSnapshotDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings SetIds(this AzureSnapshotDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings SetIds(this AzureSnapshotDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSnapshotDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings AddIds(this AzureSnapshotDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSnapshotDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings AddIds(this AzureSnapshotDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSnapshotDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings ClearIds(this AzureSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSnapshotDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings RemoveIds(this AzureSnapshotDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSnapshotDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings RemoveIds(this AzureSnapshotDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotDeleteSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings SetName(this AzureSnapshotDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotDeleteSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings ResetName(this AzureSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings SetResourceGroup(this AzureSnapshotDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings ResetResourceGroup(this AzureSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings SetSubscription(this AzureSnapshotDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings ResetSubscription(this AzureSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings SetDebug(this AzureSnapshotDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings ResetDebug(this AzureSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings SetHelp(this AzureSnapshotDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings ResetHelp(this AzureSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings SetOutput(this AzureSnapshotDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings ResetOutput(this AzureSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings SetQuery(this AzureSnapshotDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings ResetQuery(this AzureSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings SetVerbose(this AzureSnapshotDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotDeleteSettings ResetVerbose(this AzureSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSnapshotGrantAccessSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSnapshotGrantAccessSettingsExtensions
    {
        #region DurationInSeconds
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotGrantAccessSettings.DurationInSeconds"/></em></p>
        ///   <p>Time duration in seconds until the SAS access expires.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings SetDurationInSeconds(this AzureSnapshotGrantAccessSettings toolSettings, string durationInSeconds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DurationInSeconds = durationInSeconds;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotGrantAccessSettings.DurationInSeconds"/></em></p>
        ///   <p>Time duration in seconds until the SAS access expires.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings ResetDurationInSeconds(this AzureSnapshotGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DurationInSeconds = null;
            return toolSettings;
        }
        #endregion
        #region AccessLevel
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotGrantAccessSettings.AccessLevel"/></em></p>
        ///   <p>Access level.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings SetAccessLevel(this AzureSnapshotGrantAccessSettings toolSettings, SnapshotGrantAccessAccessLevel accessLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessLevel = accessLevel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotGrantAccessSettings.AccessLevel"/></em></p>
        ///   <p>Access level.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings ResetAccessLevel(this AzureSnapshotGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessLevel = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotGrantAccessSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings SetIds(this AzureSnapshotGrantAccessSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotGrantAccessSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings SetIds(this AzureSnapshotGrantAccessSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSnapshotGrantAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings AddIds(this AzureSnapshotGrantAccessSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSnapshotGrantAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings AddIds(this AzureSnapshotGrantAccessSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSnapshotGrantAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings ClearIds(this AzureSnapshotGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSnapshotGrantAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings RemoveIds(this AzureSnapshotGrantAccessSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSnapshotGrantAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings RemoveIds(this AzureSnapshotGrantAccessSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotGrantAccessSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings SetName(this AzureSnapshotGrantAccessSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotGrantAccessSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings ResetName(this AzureSnapshotGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotGrantAccessSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings SetResourceGroup(this AzureSnapshotGrantAccessSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotGrantAccessSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings ResetResourceGroup(this AzureSnapshotGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotGrantAccessSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings SetSubscription(this AzureSnapshotGrantAccessSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotGrantAccessSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings ResetSubscription(this AzureSnapshotGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotGrantAccessSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings SetDebug(this AzureSnapshotGrantAccessSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotGrantAccessSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings ResetDebug(this AzureSnapshotGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotGrantAccessSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings SetHelp(this AzureSnapshotGrantAccessSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotGrantAccessSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings ResetHelp(this AzureSnapshotGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotGrantAccessSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings SetOutput(this AzureSnapshotGrantAccessSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotGrantAccessSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings ResetOutput(this AzureSnapshotGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotGrantAccessSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings SetQuery(this AzureSnapshotGrantAccessSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotGrantAccessSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings ResetQuery(this AzureSnapshotGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotGrantAccessSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings SetVerbose(this AzureSnapshotGrantAccessSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotGrantAccessSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotGrantAccessSettings ResetVerbose(this AzureSnapshotGrantAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSnapshotListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSnapshotListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings SetResourceGroup(this AzureSnapshotListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings ResetResourceGroup(this AzureSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings SetSubscription(this AzureSnapshotListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings ResetSubscription(this AzureSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings SetDebug(this AzureSnapshotListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings ResetDebug(this AzureSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings SetHelp(this AzureSnapshotListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings ResetHelp(this AzureSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings SetOutput(this AzureSnapshotListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings ResetOutput(this AzureSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings SetQuery(this AzureSnapshotListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings ResetQuery(this AzureSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings SetVerbose(this AzureSnapshotListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotListSettings ResetVerbose(this AzureSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSnapshotRevokeAccessSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSnapshotRevokeAccessSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotRevokeAccessSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings SetIds(this AzureSnapshotRevokeAccessSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotRevokeAccessSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings SetIds(this AzureSnapshotRevokeAccessSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSnapshotRevokeAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings AddIds(this AzureSnapshotRevokeAccessSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSnapshotRevokeAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings AddIds(this AzureSnapshotRevokeAccessSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSnapshotRevokeAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings ClearIds(this AzureSnapshotRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSnapshotRevokeAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings RemoveIds(this AzureSnapshotRevokeAccessSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSnapshotRevokeAccessSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings RemoveIds(this AzureSnapshotRevokeAccessSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotRevokeAccessSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings SetName(this AzureSnapshotRevokeAccessSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotRevokeAccessSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings ResetName(this AzureSnapshotRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotRevokeAccessSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings SetResourceGroup(this AzureSnapshotRevokeAccessSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotRevokeAccessSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings ResetResourceGroup(this AzureSnapshotRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotRevokeAccessSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings SetSubscription(this AzureSnapshotRevokeAccessSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotRevokeAccessSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings ResetSubscription(this AzureSnapshotRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotRevokeAccessSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings SetDebug(this AzureSnapshotRevokeAccessSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotRevokeAccessSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings ResetDebug(this AzureSnapshotRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotRevokeAccessSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings SetHelp(this AzureSnapshotRevokeAccessSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotRevokeAccessSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings ResetHelp(this AzureSnapshotRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotRevokeAccessSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings SetOutput(this AzureSnapshotRevokeAccessSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotRevokeAccessSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings ResetOutput(this AzureSnapshotRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotRevokeAccessSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings SetQuery(this AzureSnapshotRevokeAccessSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotRevokeAccessSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings ResetQuery(this AzureSnapshotRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotRevokeAccessSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings SetVerbose(this AzureSnapshotRevokeAccessSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotRevokeAccessSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotRevokeAccessSettings ResetVerbose(this AzureSnapshotRevokeAccessSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSnapshotShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSnapshotShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings SetIds(this AzureSnapshotShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings SetIds(this AzureSnapshotShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSnapshotShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings AddIds(this AzureSnapshotShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSnapshotShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings AddIds(this AzureSnapshotShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSnapshotShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings ClearIds(this AzureSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSnapshotShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings RemoveIds(this AzureSnapshotShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSnapshotShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings RemoveIds(this AzureSnapshotShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotShowSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings SetName(this AzureSnapshotShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotShowSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings ResetName(this AzureSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings SetResourceGroup(this AzureSnapshotShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings ResetResourceGroup(this AzureSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings SetSubscription(this AzureSnapshotShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings ResetSubscription(this AzureSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings SetDebug(this AzureSnapshotShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings ResetDebug(this AzureSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings SetHelp(this AzureSnapshotShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings ResetHelp(this AzureSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings SetOutput(this AzureSnapshotShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings ResetOutput(this AzureSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings SetQuery(this AzureSnapshotShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings ResetQuery(this AzureSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings SetVerbose(this AzureSnapshotShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotShowSettings ResetVerbose(this AzureSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSnapshotUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSnapshotUpdateSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetNoWait(this AzureSnapshotUpdateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetNoWait(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureSnapshotUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings EnableNoWait(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureSnapshotUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings DisableNoWait(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureSnapshotUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ToggleNoWait(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.Sku"/></em></p>
        ///   <p></p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetSku(this AzureSnapshotUpdateSettings toolSettings, SnapshotSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.Sku"/></em></p>
        ///   <p></p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetSku(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetIds(this AzureSnapshotUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetIds(this AzureSnapshotUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSnapshotUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings AddIds(this AzureSnapshotUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSnapshotUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings AddIds(this AzureSnapshotUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSnapshotUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ClearIds(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSnapshotUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings RemoveIds(this AzureSnapshotUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSnapshotUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings RemoveIds(this AzureSnapshotUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetName(this AzureSnapshotUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetName(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetResourceGroup(this AzureSnapshotUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetResourceGroup(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetSubscription(this AzureSnapshotUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetSubscription(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetAdd(this AzureSnapshotUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetAdd(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetForceString(this AzureSnapshotUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetForceString(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetRemove(this AzureSnapshotUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetRemove(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetSet(this AzureSnapshotUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetSet(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetDebug(this AzureSnapshotUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetDebug(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetHelp(this AzureSnapshotUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetHelp(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetOutput(this AzureSnapshotUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetOutput(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetQuery(this AzureSnapshotUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetQuery(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings SetVerbose(this AzureSnapshotUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotUpdateSettings ResetVerbose(this AzureSnapshotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSnapshotWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSnapshotWaitSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetIds(this AzureSnapshotWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetIds(this AzureSnapshotWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSnapshotWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings AddIds(this AzureSnapshotWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSnapshotWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings AddIds(this AzureSnapshotWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSnapshotWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ClearIds(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSnapshotWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings RemoveIds(this AzureSnapshotWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSnapshotWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings RemoveIds(this AzureSnapshotWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetName(this AzureSnapshotWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Name"/></em></p>
        ///   <p>The name of the snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetName(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetResourceGroup(this AzureSnapshotWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetResourceGroup(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetSubscription(this AzureSnapshotWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetSubscription(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetCreated(this AzureSnapshotWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetCreated(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetCustom(this AzureSnapshotWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetCustom(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetDeleted(this AzureSnapshotWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetDeleted(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetExists(this AzureSnapshotWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetExists(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetInterval(this AzureSnapshotWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetInterval(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetTimeout(this AzureSnapshotWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetTimeout(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetUpdated(this AzureSnapshotWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetUpdated(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetDebug(this AzureSnapshotWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetDebug(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetHelp(this AzureSnapshotWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetHelp(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetOutput(this AzureSnapshotWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetOutput(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetQuery(this AzureSnapshotWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetQuery(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSnapshotWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings SetVerbose(this AzureSnapshotWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSnapshotWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSnapshotWaitSettings ResetVerbose(this AzureSnapshotWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region SnapshotCreateHyperVGeneration
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<SnapshotCreateHyperVGeneration>))]
    public partial class SnapshotCreateHyperVGeneration : Enumeration
    {
        public static SnapshotCreateHyperVGeneration v1 = new SnapshotCreateHyperVGeneration { Value = "v1" };
        public static SnapshotCreateHyperVGeneration v2 = new SnapshotCreateHyperVGeneration { Value = "v2" };
    }
    #endregion
    #region SnapshotSku
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<SnapshotSku>))]
    public partial class SnapshotSku : Enumeration
    {
        public static SnapshotSku premium_lrs = new SnapshotSku { Value = "premium_lrs" };
        public static SnapshotSku standard_lrs = new SnapshotSku { Value = "standard_lrs" };
    }
    #endregion
    #region SnapshotGrantAccessAccessLevel
    /// <summary>
    ///   Used within <see cref="AzureSnapshotTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<SnapshotGrantAccessAccessLevel>))]
    public partial class SnapshotGrantAccessAccessLevel : Enumeration
    {
        public static SnapshotGrantAccessAccessLevel read = new SnapshotGrantAccessAccessLevel { Value = "read" };
        public static SnapshotGrantAccessAccessLevel write = new SnapshotGrantAccessAccessLevel { Value = "write" };
    }
    #endregion
}
