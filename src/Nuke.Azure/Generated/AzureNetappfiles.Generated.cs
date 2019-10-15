// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureNetappfiles.json
// Generated with Nuke.CodeGeneration version 0.20.1 (OSX,.NETStandard,Version=v2.0)

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
    public static partial class AzureNetappfilesTasks
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public static string AzureNetappfilesPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURENETAPPFILES_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureNetappfilesLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure NetApp Files (ANF) Resources.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfiles(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureNetappfilesPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureNetappfilesLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesListMountTargets(AzureNetappfilesListMountTargetsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesListMountTargetsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesListMountTargetsSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesListMountTargetsSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesListMountTargetsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Verbose"/></li>
        ///     <li><c>--volume-name</c> via <see cref="AzureNetappfilesListMountTargetsSettings.VolumeName"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesListMountTargets(Configure<AzureNetappfilesListMountTargetsSettings> configurator)
        {
            return AzureNetappfilesListMountTargets(configurator(new AzureNetappfilesListMountTargetsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesListMountTargetsSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesListMountTargetsSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesListMountTargetsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesListMountTargetsSettings.Verbose"/></li>
        ///     <li><c>--volume-name</c> via <see cref="AzureNetappfilesListMountTargetsSettings.VolumeName"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesListMountTargetsSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesListMountTargets(CombinatorialConfigure<AzureNetappfilesListMountTargetsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesListMountTargets, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesSnapshotCreate(AzureNetappfilesSnapshotCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesSnapshotCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Debug"/></li>
        ///     <li><c>--file-system-id</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.FileSystemId"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Verbose"/></li>
        ///     <li><c>--volume-name</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.VolumeName"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesSnapshotCreate(Configure<AzureNetappfilesSnapshotCreateSettings> configurator)
        {
            return AzureNetappfilesSnapshotCreate(configurator(new AzureNetappfilesSnapshotCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Debug"/></li>
        ///     <li><c>--file-system-id</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.FileSystemId"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.Verbose"/></li>
        ///     <li><c>--volume-name</c> via <see cref="AzureNetappfilesSnapshotCreateSettings.VolumeName"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesSnapshotCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesSnapshotCreate(CombinatorialConfigure<AzureNetappfilesSnapshotCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesSnapshotCreate, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesSnapshotDelete(AzureNetappfilesSnapshotDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesSnapshotDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Verbose"/></li>
        ///     <li><c>--volume-name</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.VolumeName"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesSnapshotDelete(Configure<AzureNetappfilesSnapshotDeleteSettings> configurator)
        {
            return AzureNetappfilesSnapshotDelete(configurator(new AzureNetappfilesSnapshotDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.Verbose"/></li>
        ///     <li><c>--volume-name</c> via <see cref="AzureNetappfilesSnapshotDeleteSettings.VolumeName"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesSnapshotDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesSnapshotDelete(CombinatorialConfigure<AzureNetappfilesSnapshotDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesSnapshotDelete, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesSnapshotList(AzureNetappfilesSnapshotListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesSnapshotListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesSnapshotListSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesSnapshotListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesSnapshotListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesSnapshotListSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesSnapshotListSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesSnapshotListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesSnapshotListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesSnapshotListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesSnapshotListSettings.Verbose"/></li>
        ///     <li><c>--volume-name</c> via <see cref="AzureNetappfilesSnapshotListSettings.VolumeName"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesSnapshotList(Configure<AzureNetappfilesSnapshotListSettings> configurator)
        {
            return AzureNetappfilesSnapshotList(configurator(new AzureNetappfilesSnapshotListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesSnapshotListSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesSnapshotListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesSnapshotListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesSnapshotListSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesSnapshotListSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesSnapshotListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesSnapshotListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesSnapshotListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesSnapshotListSettings.Verbose"/></li>
        ///     <li><c>--volume-name</c> via <see cref="AzureNetappfilesSnapshotListSettings.VolumeName"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesSnapshotListSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesSnapshotList(CombinatorialConfigure<AzureNetappfilesSnapshotListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesSnapshotList, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesSnapshotShow(AzureNetappfilesSnapshotShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesSnapshotShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesSnapshotShowSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesSnapshotShowSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesSnapshotShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Verbose"/></li>
        ///     <li><c>--volume-name</c> via <see cref="AzureNetappfilesSnapshotShowSettings.VolumeName"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesSnapshotShow(Configure<AzureNetappfilesSnapshotShowSettings> configurator)
        {
            return AzureNetappfilesSnapshotShow(configurator(new AzureNetappfilesSnapshotShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesSnapshotShowSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesSnapshotShowSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesSnapshotShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesSnapshotShowSettings.Verbose"/></li>
        ///     <li><c>--volume-name</c> via <see cref="AzureNetappfilesSnapshotShowSettings.VolumeName"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesSnapshotShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesSnapshotShow(CombinatorialConfigure<AzureNetappfilesSnapshotShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesSnapshotShow, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountCreate(AzureNetappfilesAccountCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesAccountCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountCreateSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureNetappfilesAccountCreateSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureNetappfilesAccountCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountCreate(Configure<AzureNetappfilesAccountCreateSettings> configurator)
        {
            return AzureNetappfilesAccountCreate(configurator(new AzureNetappfilesAccountCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountCreateSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureNetappfilesAccountCreateSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureNetappfilesAccountCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesAccountCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesAccountCreate(CombinatorialConfigure<AzureNetappfilesAccountCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesAccountCreate, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountDelete(AzureNetappfilesAccountDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesAccountDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountDeleteSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountDelete(Configure<AzureNetappfilesAccountDeleteSettings> configurator)
        {
            return AzureNetappfilesAccountDelete(configurator(new AzureNetappfilesAccountDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountDeleteSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesAccountDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesAccountDelete(CombinatorialConfigure<AzureNetappfilesAccountDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesAccountDelete, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountList(AzureNetappfilesAccountListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesAccountListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountList(Configure<AzureNetappfilesAccountListSettings> configurator)
        {
            return AzureNetappfilesAccountList(configurator(new AzureNetappfilesAccountListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesAccountListSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesAccountList(CombinatorialConfigure<AzureNetappfilesAccountListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesAccountList, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountShow(AzureNetappfilesAccountShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesAccountShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountShowSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesAccountShowSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountShow(Configure<AzureNetappfilesAccountShowSettings> configurator)
        {
            return AzureNetappfilesAccountShow(configurator(new AzureNetappfilesAccountShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountShowSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesAccountShowSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesAccountShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesAccountShow(CombinatorialConfigure<AzureNetappfilesAccountShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesAccountShow, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountUpdate(AzureNetappfilesAccountUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesAccountUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountUpdateSettings.AccountName"/></li>
        ///     <li><c>--add</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureNetappfilesAccountUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountUpdate(Configure<AzureNetappfilesAccountUpdateSettings> configurator)
        {
            return AzureNetappfilesAccountUpdate(configurator(new AzureNetappfilesAccountUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountUpdateSettings.AccountName"/></li>
        ///     <li><c>--add</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureNetappfilesAccountUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesAccountUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesAccountUpdate(CombinatorialConfigure<AzureNetappfilesAccountUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesAccountUpdate, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesPoolCreate(AzureNetappfilesPoolCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesPoolCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesPoolCreateSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesPoolCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesPoolCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureNetappfilesPoolCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesPoolCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesPoolCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesPoolCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesPoolCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-level</c> via <see cref="AzureNetappfilesPoolCreateSettings.ServiceLevel"/></li>
        ///     <li><c>--size</c> via <see cref="AzureNetappfilesPoolCreateSettings.Size"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesPoolCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureNetappfilesPoolCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesPoolCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesPoolCreate(Configure<AzureNetappfilesPoolCreateSettings> configurator)
        {
            return AzureNetappfilesPoolCreate(configurator(new AzureNetappfilesPoolCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesPoolCreateSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesPoolCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesPoolCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureNetappfilesPoolCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesPoolCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesPoolCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesPoolCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesPoolCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-level</c> via <see cref="AzureNetappfilesPoolCreateSettings.ServiceLevel"/></li>
        ///     <li><c>--size</c> via <see cref="AzureNetappfilesPoolCreateSettings.Size"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesPoolCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureNetappfilesPoolCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesPoolCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesPoolCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesPoolCreate(CombinatorialConfigure<AzureNetappfilesPoolCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesPoolCreate, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesPoolDelete(AzureNetappfilesPoolDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesPoolDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesPoolDeleteSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesPoolDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesPoolDelete(Configure<AzureNetappfilesPoolDeleteSettings> configurator)
        {
            return AzureNetappfilesPoolDelete(configurator(new AzureNetappfilesPoolDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesPoolDeleteSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesPoolDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesPoolDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesPoolDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesPoolDelete(CombinatorialConfigure<AzureNetappfilesPoolDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesPoolDelete, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesPoolList(AzureNetappfilesPoolListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesPoolListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesPoolListSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesPoolListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesPoolListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesPoolListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesPoolListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesPoolListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesPoolListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesPoolListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesPoolList(Configure<AzureNetappfilesPoolListSettings> configurator)
        {
            return AzureNetappfilesPoolList(configurator(new AzureNetappfilesPoolListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesPoolListSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesPoolListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesPoolListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesPoolListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesPoolListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesPoolListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesPoolListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesPoolListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesPoolListSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesPoolList(CombinatorialConfigure<AzureNetappfilesPoolListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesPoolList, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesPoolShow(AzureNetappfilesPoolShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesPoolShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesPoolShowSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesPoolShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesPoolShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesPoolShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesPoolShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesPoolShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesPoolShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesPoolShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesPoolShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesPoolShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesPoolShow(Configure<AzureNetappfilesPoolShowSettings> configurator)
        {
            return AzureNetappfilesPoolShow(configurator(new AzureNetappfilesPoolShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesPoolShowSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesPoolShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesPoolShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesPoolShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesPoolShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesPoolShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesPoolShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesPoolShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesPoolShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesPoolShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesPoolShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesPoolShow(CombinatorialConfigure<AzureNetappfilesPoolShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesPoolShow, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesPoolUpdate(AzureNetappfilesPoolUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesPoolUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesPoolUpdateSettings.AccountName"/></li>
        ///     <li><c>--add</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureNetappfilesPoolUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesPoolUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-level</c> via <see cref="AzureNetappfilesPoolUpdateSettings.ServiceLevel"/></li>
        ///     <li><c>--set</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Set"/></li>
        ///     <li><c>--size</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Size"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesPoolUpdate(Configure<AzureNetappfilesPoolUpdateSettings> configurator)
        {
            return AzureNetappfilesPoolUpdate(configurator(new AzureNetappfilesPoolUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesPoolUpdateSettings.AccountName"/></li>
        ///     <li><c>--add</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureNetappfilesPoolUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesPoolUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-level</c> via <see cref="AzureNetappfilesPoolUpdateSettings.ServiceLevel"/></li>
        ///     <li><c>--set</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Set"/></li>
        ///     <li><c>--size</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Size"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesPoolUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesPoolUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesPoolUpdate(CombinatorialConfigure<AzureNetappfilesPoolUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesPoolUpdate, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeCreate(AzureNetappfilesVolumeCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesVolumeCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeCreateSettings.AccountName"/></li>
        ///     <li><c>--creation-token</c> via <see cref="AzureNetappfilesVolumeCreateSettings.CreationToken"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeCreateSettings.PoolName"/></li>
        ///     <li><c>--protocol-types</c> via <see cref="AzureNetappfilesVolumeCreateSettings.ProtocolTypes"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-level</c> via <see cref="AzureNetappfilesVolumeCreateSettings.ServiceLevel"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Tags"/></li>
        ///     <li><c>--usage-threshold</c> via <see cref="AzureNetappfilesVolumeCreateSettings.UsageThreshold"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Vnet"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeCreate(Configure<AzureNetappfilesVolumeCreateSettings> configurator)
        {
            return AzureNetappfilesVolumeCreate(configurator(new AzureNetappfilesVolumeCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeCreateSettings.AccountName"/></li>
        ///     <li><c>--creation-token</c> via <see cref="AzureNetappfilesVolumeCreateSettings.CreationToken"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeCreateSettings.PoolName"/></li>
        ///     <li><c>--protocol-types</c> via <see cref="AzureNetappfilesVolumeCreateSettings.ProtocolTypes"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-level</c> via <see cref="AzureNetappfilesVolumeCreateSettings.ServiceLevel"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Tags"/></li>
        ///     <li><c>--usage-threshold</c> via <see cref="AzureNetappfilesVolumeCreateSettings.UsageThreshold"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet</c> via <see cref="AzureNetappfilesVolumeCreateSettings.Vnet"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesVolumeCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesVolumeCreate(CombinatorialConfigure<AzureNetappfilesVolumeCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesVolumeCreate, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeDelete(AzureNetappfilesVolumeDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesVolumeDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeDelete(Configure<AzureNetappfilesVolumeDeleteSettings> configurator)
        {
            return AzureNetappfilesVolumeDelete(configurator(new AzureNetappfilesVolumeDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesVolumeDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesVolumeDelete(CombinatorialConfigure<AzureNetappfilesVolumeDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesVolumeDelete, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeList(AzureNetappfilesVolumeListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesVolumeListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeListSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeListSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeListSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeList(Configure<AzureNetappfilesVolumeListSettings> configurator)
        {
            return AzureNetappfilesVolumeList(configurator(new AzureNetappfilesVolumeListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeListSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeListSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeListSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesVolumeListSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesVolumeList(CombinatorialConfigure<AzureNetappfilesVolumeListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesVolumeList, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeShow(AzureNetappfilesVolumeShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesVolumeShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeShowSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesVolumeShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeShowSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeShowSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeShow(Configure<AzureNetappfilesVolumeShowSettings> configurator)
        {
            return AzureNetappfilesVolumeShow(configurator(new AzureNetappfilesVolumeShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeShowSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesVolumeShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeShowSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeShowSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesVolumeShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesVolumeShow(CombinatorialConfigure<AzureNetappfilesVolumeShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesVolumeShow, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeUpdate(AzureNetappfilesVolumeUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesVolumeUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.AccountName"/></li>
        ///     <li><c>--add</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.PoolName"/></li>
        ///     <li><c>--protocol-types</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.ProtocolTypes"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-level</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.ServiceLevel"/></li>
        ///     <li><c>--set</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Tags"/></li>
        ///     <li><c>--usage-threshold</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.UsageThreshold"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeUpdate(Configure<AzureNetappfilesVolumeUpdateSettings> configurator)
        {
            return AzureNetappfilesVolumeUpdate(configurator(new AzureNetappfilesVolumeUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.AccountName"/></li>
        ///     <li><c>--add</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.PoolName"/></li>
        ///     <li><c>--protocol-types</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.ProtocolTypes"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-level</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.ServiceLevel"/></li>
        ///     <li><c>--set</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Tags"/></li>
        ///     <li><c>--usage-threshold</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.UsageThreshold"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesVolumeUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesVolumeUpdate(CombinatorialConfigure<AzureNetappfilesVolumeUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesVolumeUpdate, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountAdAdd(AzureNetappfilesAccountAdAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesAccountAdAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountAdAddSettings.AccountName"/></li>
        ///     <li><c>--add</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Debug"/></li>
        ///     <li><c>--dns</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Dns"/></li>
        ///     <li><c>--domain</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Domain"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureNetappfilesAccountAdAddSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Ids"/></li>
        ///     <li><c>--organizational-unit</c> via <see cref="AzureNetappfilesAccountAdAddSettings.OrganizationalUnit"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountAdAddSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Set"/></li>
        ///     <li><c>--smb-server-name</c> via <see cref="AzureNetappfilesAccountAdAddSettings.SmbServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Subscription"/></li>
        ///     <li><c>--username</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Username"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountAdAdd(Configure<AzureNetappfilesAccountAdAddSettings> configurator)
        {
            return AzureNetappfilesAccountAdAdd(configurator(new AzureNetappfilesAccountAdAddSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountAdAddSettings.AccountName"/></li>
        ///     <li><c>--add</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Debug"/></li>
        ///     <li><c>--dns</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Dns"/></li>
        ///     <li><c>--domain</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Domain"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureNetappfilesAccountAdAddSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Ids"/></li>
        ///     <li><c>--organizational-unit</c> via <see cref="AzureNetappfilesAccountAdAddSettings.OrganizationalUnit"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountAdAddSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Set"/></li>
        ///     <li><c>--smb-server-name</c> via <see cref="AzureNetappfilesAccountAdAddSettings.SmbServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Subscription"/></li>
        ///     <li><c>--username</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Username"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountAdAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesAccountAdAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesAccountAdAdd(CombinatorialConfigure<AzureNetappfilesAccountAdAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesAccountAdAdd, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountAdList(AzureNetappfilesAccountAdListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesAccountAdListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountAdListSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountAdListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountAdListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountAdListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountAdListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountAdListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountAdListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountAdListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountAdList(Configure<AzureNetappfilesAccountAdListSettings> configurator)
        {
            return AzureNetappfilesAccountAdList(configurator(new AzureNetappfilesAccountAdListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountAdListSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountAdListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountAdListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountAdListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountAdListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountAdListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountAdListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountAdListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesAccountAdListSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesAccountAdList(CombinatorialConfigure<AzureNetappfilesAccountAdListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesAccountAdList, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountAdRemove(AzureNetappfilesAccountAdRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesAccountAdRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.AccountName"/></li>
        ///     <li><c>--active-directory</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.ActiveDirectory"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesAccountAdRemove(Configure<AzureNetappfilesAccountAdRemoveSettings> configurator)
        {
            return AzureNetappfilesAccountAdRemove(configurator(new AzureNetappfilesAccountAdRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.AccountName"/></li>
        ///     <li><c>--active-directory</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.ActiveDirectory"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesAccountAdRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesAccountAdRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesAccountAdRemove(CombinatorialConfigure<AzureNetappfilesAccountAdRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesAccountAdRemove, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeExportPolicyAdd(AzureNetappfilesVolumeExportPolicyAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesVolumeExportPolicyAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.AccountName"/></li>
        ///     <li><c>--add</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Add"/></li>
        ///     <li><c>--allowed-clients</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.AllowedClients"/></li>
        ///     <li><c>--cifs</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Cifs"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Name"/></li>
        ///     <li><c>--nfsv3</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv3"/></li>
        ///     <li><c>--nfsv4</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv4"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.ResourceGroup"/></li>
        ///     <li><c>--rule-index</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.RuleIndex"/></li>
        ///     <li><c>--set</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Subscription"/></li>
        ///     <li><c>--unix-read-only</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadOnly"/></li>
        ///     <li><c>--unix-read-write</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadWrite"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeExportPolicyAdd(Configure<AzureNetappfilesVolumeExportPolicyAddSettings> configurator)
        {
            return AzureNetappfilesVolumeExportPolicyAdd(configurator(new AzureNetappfilesVolumeExportPolicyAddSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.AccountName"/></li>
        ///     <li><c>--add</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Add"/></li>
        ///     <li><c>--allowed-clients</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.AllowedClients"/></li>
        ///     <li><c>--cifs</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Cifs"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Name"/></li>
        ///     <li><c>--nfsv3</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv3"/></li>
        ///     <li><c>--nfsv4</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv4"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.ResourceGroup"/></li>
        ///     <li><c>--rule-index</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.RuleIndex"/></li>
        ///     <li><c>--set</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Subscription"/></li>
        ///     <li><c>--unix-read-only</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadOnly"/></li>
        ///     <li><c>--unix-read-write</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadWrite"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesVolumeExportPolicyAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesVolumeExportPolicyAdd(CombinatorialConfigure<AzureNetappfilesVolumeExportPolicyAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesVolumeExportPolicyAdd, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeExportPolicyList(AzureNetappfilesVolumeExportPolicyListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesVolumeExportPolicyListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeExportPolicyList(Configure<AzureNetappfilesVolumeExportPolicyListSettings> configurator)
        {
            return AzureNetappfilesVolumeExportPolicyList(configurator(new AzureNetappfilesVolumeExportPolicyListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.AccountName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesVolumeExportPolicyListSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesVolumeExportPolicyList(CombinatorialConfigure<AzureNetappfilesVolumeExportPolicyListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesVolumeExportPolicyList, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeExportPolicyRemove(AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureNetappfilesVolumeExportPolicyRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.AccountName"/></li>
        ///     <li><c>--add</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--rule-index</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.RuleIndex"/></li>
        ///     <li><c>--set</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureNetappfilesVolumeExportPolicyRemove(Configure<AzureNetappfilesVolumeExportPolicyRemoveSettings> configurator)
        {
            return AzureNetappfilesVolumeExportPolicyRemove(configurator(new AzureNetappfilesVolumeExportPolicyRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure NetApp Files (ANF) Resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/netappfiles?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--account-name</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.AccountName"/></li>
        ///     <li><c>--add</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Output"/></li>
        ///     <li><c>--pool-name</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.PoolName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--rule-index</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.RuleIndex"/></li>
        ///     <li><c>--set</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureNetappfilesVolumeExportPolicyRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureNetappfilesVolumeExportPolicyRemove(CombinatorialConfigure<AzureNetappfilesVolumeExportPolicyRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureNetappfilesVolumeExportPolicyRemove, AzureNetappfilesLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureNetappfilesListMountTargetsSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesListMountTargetsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string PoolName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string VolumeName { get; internal set; }
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
              .Add("netappfiles list-mount-targets")
              .Add("--account-name {value}", AccountName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--pool-name {value}", PoolName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--volume-name {value}", VolumeName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureNetappfilesSnapshotCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesSnapshotCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The name of the ANF snapshot.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string PoolName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the ANF volume.
        /// </summary>
        public virtual string VolumeName { get; internal set; }
        /// <summary>
        ///   The uuid of the volume.
        /// </summary>
        public virtual string FileSystemId { get; internal set; }
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
              .Add("netappfiles snapshot create")
              .Add("--account-name {value}", AccountName)
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--pool-name {value}", PoolName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--volume-name {value}", VolumeName)
              .Add("--file-system-id {value}", FileSystemId)
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
    #region AzureNetappfilesSnapshotDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesSnapshotDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the ANF snapshot.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string PoolName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   The name of the ANF volume.
        /// </summary>
        public virtual string VolumeName { get; internal set; }
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
              .Add("netappfiles snapshot delete")
              .Add("--account-name {value}", AccountName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--pool-name {value}", PoolName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--volume-name {value}", VolumeName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureNetappfilesSnapshotListSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesSnapshotListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string PoolName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the ANF volume.
        /// </summary>
        public virtual string VolumeName { get; internal set; }
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
              .Add("netappfiles snapshot list")
              .Add("--account-name {value}", AccountName)
              .Add("--pool-name {value}", PoolName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--volume-name {value}", VolumeName)
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
    #region AzureNetappfilesSnapshotShowSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesSnapshotShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the ANF snapshot.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string PoolName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   The name of the ANF volume.
        /// </summary>
        public virtual string VolumeName { get; internal set; }
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
              .Add("netappfiles snapshot show")
              .Add("--account-name {value}", AccountName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--pool-name {value}", PoolName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--volume-name {value}", VolumeName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureNetappfilesAccountCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesAccountCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Space-separated tags in `key[=value]` format.
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
              .Add("netappfiles account create")
              .Add("--account-name {value}", AccountName)
              .Add("--location {value}", Location)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureNetappfilesAccountDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesAccountDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
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
              .Add("netappfiles account delete")
              .Add("--account-name {value}", AccountName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureNetappfilesAccountListSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesAccountListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
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
              .Add("netappfiles account list")
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
    #region AzureNetappfilesAccountShowSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesAccountShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
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
              .Add("netappfiles account show")
              .Add("--account-name {value}", AccountName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureNetappfilesAccountUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesAccountUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   Space-separated tags in `key[=value]` format.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
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
              .Add("netappfiles account update")
              .Add("--tags {value}", Tags)
              .Add("--account-name {value}", AccountName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureNetappfilesPoolCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesPoolCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The service level for the ANF pool.
        /// </summary>
        public virtual NetappfilesPoolServiceLevel ServiceLevel { get; internal set; }
        /// <summary>
        ///   The size for the ANF pool. Must be an integer number of tebibytes in multiples of 4.
        /// </summary>
        public virtual string Size { get; internal set; }
        /// <summary>
        ///   Space-separated tags in `key[=value]` format.
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
              .Add("netappfiles pool create")
              .Add("--account-name {value}", AccountName)
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-level {value}", ServiceLevel)
              .Add("--size {value}", Size)
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
    #region AzureNetappfilesPoolDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesPoolDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the ANF pool.
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
              .Add("netappfiles pool delete")
              .Add("--account-name {value}", AccountName)
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
    #region AzureNetappfilesPoolListSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesPoolListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
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
              .Add("netappfiles pool list")
              .Add("--account-name {value}", AccountName)
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
    #region AzureNetappfilesPoolShowSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesPoolShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the ANF pool.
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
              .Add("netappfiles pool show")
              .Add("--account-name {value}", AccountName)
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
    #region AzureNetappfilesPoolUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesPoolUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The service level for the ANF pool.
        /// </summary>
        public virtual NetappfilesPoolServiceLevel ServiceLevel { get; internal set; }
        /// <summary>
        ///   The size for the ANF pool. Must be an integer number of tebibytes in multiples of 4.
        /// </summary>
        public virtual string Size { get; internal set; }
        /// <summary>
        ///   Space-separated tags in `key[=value]` format.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the ANF pool.
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
              .Add("netappfiles pool update")
              .Add("--service-level {value}", ServiceLevel)
              .Add("--size {value}", Size)
              .Add("--tags {value}", Tags)
              .Add("--account-name {value}", AccountName)
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
    #region AzureNetappfilesVolumeCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesVolumeCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   A 1-80 character long alphanumeric string value that identifies a unique file share or mount point in the target subnet.
        /// </summary>
        public virtual string CreationToken { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The name of the ANF volume.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string PoolName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The maximum storage quota allowed for a file system as integer number of GiB. Min 100 GiB, max 100TiB".
        /// </summary>
        public virtual string UsageThreshold { get; internal set; }
        /// <summary>
        ///   The ARM Id or name of the vnet for the volume.
        /// </summary>
        public virtual string Vnet { get; internal set; }
        /// <summary>
        ///   Space seperated list of protocols that the volume can use.
        /// </summary>
        public virtual string ProtocolTypes { get; internal set; }
        /// <summary>
        ///   The service level.
        /// </summary>
        public virtual NetappfilesPoolServiceLevel ServiceLevel { get; internal set; }
        /// <summary>
        ///   The ARM Id or name of the subnet for the vnet. If omitted 'default' will be used.
        /// </summary>
        public virtual string Subnet { get; internal set; }
        /// <summary>
        ///   Space-separated tags in `key[=value]` format.
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
              .Add("netappfiles volume create")
              .Add("--account-name {value}", AccountName)
              .Add("--creation-token {value}", CreationToken)
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--pool-name {value}", PoolName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--usage-threshold {value}", UsageThreshold)
              .Add("--vnet {value}", Vnet)
              .Add("--protocol-types {value}", ProtocolTypes)
              .Add("--service-level {value}", ServiceLevel)
              .Add("--subnet {value}", Subnet)
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
    #region AzureNetappfilesVolumeDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesVolumeDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the ANF volume.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string PoolName { get; internal set; }
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
              .Add("netappfiles volume delete")
              .Add("--account-name {value}", AccountName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--pool-name {value}", PoolName)
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
    #region AzureNetappfilesVolumeListSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesVolumeListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string PoolName { get; internal set; }
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
              .Add("netappfiles volume list")
              .Add("--account-name {value}", AccountName)
              .Add("--pool-name {value}", PoolName)
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
    #region AzureNetappfilesVolumeShowSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesVolumeShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string PoolName { get; internal set; }
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
              .Add("netappfiles volume show")
              .Add("--account-name {value}", AccountName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--pool-name {value}", PoolName)
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
    #region AzureNetappfilesVolumeUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesVolumeUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string ProtocolTypes { get; internal set; }
        /// <summary>
        ///   The service level.
        /// </summary>
        public virtual NetappfilesPoolServiceLevel ServiceLevel { get; internal set; }
        /// <summary>
        ///   Space-separated tags in `key[=value]` format.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   The maximum storage quota allowed for a file system as integer number of GiB. Min 100 GiB, max 100TiB".
        /// </summary>
        public virtual string UsageThreshold { get; internal set; }
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the ANF volume.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string PoolName { get; internal set; }
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
              .Add("netappfiles volume update")
              .Add("--protocol-types {value}", ProtocolTypes)
              .Add("--service-level {value}", ServiceLevel)
              .Add("--tags {value}", Tags)
              .Add("--usage-threshold {value}", UsageThreshold)
              .Add("--account-name {value}", AccountName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--pool-name {value}", PoolName)
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
    #region AzureNetappfilesAccountAdAddSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesAccountAdAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   Comma separated list of DNS server IP addresses for the Active Directory domain.
        /// </summary>
        public virtual string Dns { get; internal set; }
        /// <summary>
        ///   Name of the Active Directory domain.
        /// </summary>
        public virtual string Domain { get; internal set; }
        /// <summary>
        ///   Plain text password of Active Directory domain administrator.
        /// </summary>
        public virtual string Password { get; internal set; }
        /// <summary>
        ///   NetBIOS name of the SMB server. This name will be registered as a computer account in the AD and used to mount volumes. Must be 10 characters or less.
        /// </summary>
        public virtual string SmbServerName { get; internal set; }
        /// <summary>
        ///   Username of Active Directory domain administrator.
        /// </summary>
        public virtual string Username { get; internal set; }
        /// <summary>
        ///   The Organizational Unit (OU) within the Windows Active Directory.
        /// </summary>
        public virtual string OrganizationalUnit { get; internal set; }
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
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
              .Add("netappfiles account ad add")
              .Add("--dns {value}", Dns)
              .Add("--domain {value}", Domain)
              .Add("--password {value}", Password, secret: true)
              .Add("--smb-server-name {value}", SmbServerName)
              .Add("--username {value}", Username)
              .Add("--organizational-unit {value}", OrganizationalUnit)
              .Add("--account-name {value}", AccountName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureNetappfilesAccountAdListSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesAccountAdListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
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
              .Add("netappfiles account ad list")
              .Add("--account-name {value}", AccountName)
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
    #region AzureNetappfilesAccountAdRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesAccountAdRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The id of the active directory.
        /// </summary>
        public virtual string ActiveDirectory { get; internal set; }
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
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
              .Add("netappfiles account ad remove")
              .Add("--active-directory {value}", ActiveDirectory)
              .Add("--account-name {value}", AccountName)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureNetappfilesVolumeExportPolicyAddSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesVolumeExportPolicyAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   Client ingress specification as comma separated string with IPv4 CIDRs, IPv4 host addresses and host names).
        /// </summary>
        public virtual string AllowedClients { get; internal set; }
        /// <summary>
        ///   Indication that CIFS protocol is allowed.
        /// </summary>
        public virtual bool? Cifs { get; internal set; }
        /// <summary>
        ///   Indication that NFSv3 protocol is allowed.
        /// </summary>
        public virtual bool? Nfsv3 { get; internal set; }
        /// <summary>
        ///   Indication that NFSv4 protocol is allowed.
        /// </summary>
        public virtual bool? Nfsv4 { get; internal set; }
        /// <summary>
        ///   Order index. No number can be repeated. Max 6 rules.
        /// </summary>
        public virtual string RuleIndex { get; internal set; }
        /// <summary>
        ///   Indication of read only access.
        /// </summary>
        public virtual bool? UnixReadOnly { get; internal set; }
        /// <summary>
        ///   Indication of read and write access.
        /// </summary>
        public virtual bool? UnixReadWrite { get; internal set; }
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the ANF volume.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string PoolName { get; internal set; }
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
              .Add("netappfiles volume export-policy add")
              .Add("--allowed-clients {value}", AllowedClients)
              .Add("--cifs", Cifs)
              .Add("--nfsv3", Nfsv3)
              .Add("--nfsv4", Nfsv4)
              .Add("--rule-index {value}", RuleIndex)
              .Add("--unix-read-only", UnixReadOnly)
              .Add("--unix-read-write", UnixReadWrite)
              .Add("--account-name {value}", AccountName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--pool-name {value}", PoolName)
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
    #region AzureNetappfilesVolumeExportPolicyListSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesVolumeExportPolicyListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   The name of the ANF volume.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string PoolName { get; internal set; }
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
              .Add("netappfiles volume export-policy list")
              .Add("--account-name {value}", AccountName)
              .Add("--name {value}", Name)
              .Add("--pool-name {value}", PoolName)
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
    #region AzureNetappfilesVolumeExportPolicyRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureNetappfilesVolumeExportPolicyRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureNetappfiles executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureNetappfilesTasks.AzureNetappfilesPath;
        public override Action<OutputType, string> CustomLogger => AzureNetappfilesTasks.AzureNetappfilesLogger;
        /// <summary>
        ///   Order index. Range 1 to 6.
        /// </summary>
        public virtual string RuleIndex { get; internal set; }
        /// <summary>
        ///   The name of the ANF account.
        /// </summary>
        public virtual string AccountName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the ANF volume.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the ANF pool.
        /// </summary>
        public virtual string PoolName { get; internal set; }
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
              .Add("netappfiles volume export-policy remove")
              .Add("--rule-index {value}", RuleIndex)
              .Add("--account-name {value}", AccountName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--pool-name {value}", PoolName)
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
    #region AzureNetappfilesListMountTargetsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesListMountTargetsSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesListMountTargetsSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings SetAccountName(this AzureNetappfilesListMountTargetsSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesListMountTargetsSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings ResetAccountName(this AzureNetappfilesListMountTargetsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesListMountTargetsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings SetIds(this AzureNetappfilesListMountTargetsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesListMountTargetsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings SetIds(this AzureNetappfilesListMountTargetsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesListMountTargetsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings AddIds(this AzureNetappfilesListMountTargetsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesListMountTargetsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings AddIds(this AzureNetappfilesListMountTargetsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesListMountTargetsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings ClearIds(this AzureNetappfilesListMountTargetsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesListMountTargetsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings RemoveIds(this AzureNetappfilesListMountTargetsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesListMountTargetsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings RemoveIds(this AzureNetappfilesListMountTargetsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region PoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesListMountTargetsSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings SetPoolName(this AzureNetappfilesListMountTargetsSettings toolSettings, string poolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = poolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesListMountTargetsSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings ResetPoolName(this AzureNetappfilesListMountTargetsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesListMountTargetsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings SetResourceGroup(this AzureNetappfilesListMountTargetsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesListMountTargetsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings ResetResourceGroup(this AzureNetappfilesListMountTargetsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesListMountTargetsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings SetSubscription(this AzureNetappfilesListMountTargetsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesListMountTargetsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings ResetSubscription(this AzureNetappfilesListMountTargetsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VolumeName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesListMountTargetsSettings.VolumeName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings SetVolumeName(this AzureNetappfilesListMountTargetsSettings toolSettings, string volumeName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeName = volumeName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesListMountTargetsSettings.VolumeName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings ResetVolumeName(this AzureNetappfilesListMountTargetsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesListMountTargetsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings SetDebug(this AzureNetappfilesListMountTargetsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesListMountTargetsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings ResetDebug(this AzureNetappfilesListMountTargetsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesListMountTargetsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings SetHelp(this AzureNetappfilesListMountTargetsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesListMountTargetsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings ResetHelp(this AzureNetappfilesListMountTargetsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesListMountTargetsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings SetOutput(this AzureNetappfilesListMountTargetsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesListMountTargetsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings ResetOutput(this AzureNetappfilesListMountTargetsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesListMountTargetsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings SetQuery(this AzureNetappfilesListMountTargetsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesListMountTargetsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings ResetQuery(this AzureNetappfilesListMountTargetsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesListMountTargetsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings SetVerbose(this AzureNetappfilesListMountTargetsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesListMountTargetsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesListMountTargetsSettings ResetVerbose(this AzureNetappfilesListMountTargetsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesSnapshotCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesSnapshotCreateSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotCreateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings SetAccountName(this AzureNetappfilesSnapshotCreateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotCreateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings ResetAccountName(this AzureNetappfilesSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings SetLocation(this AzureNetappfilesSnapshotCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings ResetLocation(this AzureNetappfilesSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotCreateSettings.Name"/></em></p>
        ///   <p>The name of the ANF snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings SetName(this AzureNetappfilesSnapshotCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotCreateSettings.Name"/></em></p>
        ///   <p>The name of the ANF snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings ResetName(this AzureNetappfilesSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotCreateSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings SetPoolName(this AzureNetappfilesSnapshotCreateSettings toolSettings, string poolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = poolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotCreateSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings ResetPoolName(this AzureNetappfilesSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings SetResourceGroup(this AzureNetappfilesSnapshotCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings ResetResourceGroup(this AzureNetappfilesSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VolumeName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotCreateSettings.VolumeName"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings SetVolumeName(this AzureNetappfilesSnapshotCreateSettings toolSettings, string volumeName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeName = volumeName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotCreateSettings.VolumeName"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings ResetVolumeName(this AzureNetappfilesSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeName = null;
            return toolSettings;
        }
        #endregion
        #region FileSystemId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotCreateSettings.FileSystemId"/></em></p>
        ///   <p>The uuid of the volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings SetFileSystemId(this AzureNetappfilesSnapshotCreateSettings toolSettings, string fileSystemId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileSystemId = fileSystemId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotCreateSettings.FileSystemId"/></em></p>
        ///   <p>The uuid of the volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings ResetFileSystemId(this AzureNetappfilesSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileSystemId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings SetSubscription(this AzureNetappfilesSnapshotCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings ResetSubscription(this AzureNetappfilesSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings SetDebug(this AzureNetappfilesSnapshotCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings ResetDebug(this AzureNetappfilesSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings SetHelp(this AzureNetappfilesSnapshotCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings ResetHelp(this AzureNetappfilesSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings SetOutput(this AzureNetappfilesSnapshotCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings ResetOutput(this AzureNetappfilesSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings SetQuery(this AzureNetappfilesSnapshotCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings ResetQuery(this AzureNetappfilesSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings SetVerbose(this AzureNetappfilesSnapshotCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotCreateSettings ResetVerbose(this AzureNetappfilesSnapshotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesSnapshotDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesSnapshotDeleteSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotDeleteSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings SetAccountName(this AzureNetappfilesSnapshotDeleteSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotDeleteSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings ResetAccountName(this AzureNetappfilesSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings SetIds(this AzureNetappfilesSnapshotDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings SetIds(this AzureNetappfilesSnapshotDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesSnapshotDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings AddIds(this AzureNetappfilesSnapshotDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesSnapshotDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings AddIds(this AzureNetappfilesSnapshotDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesSnapshotDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings ClearIds(this AzureNetappfilesSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesSnapshotDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings RemoveIds(this AzureNetappfilesSnapshotDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesSnapshotDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings RemoveIds(this AzureNetappfilesSnapshotDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotDeleteSettings.Name"/></em></p>
        ///   <p>The name of the ANF snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings SetName(this AzureNetappfilesSnapshotDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotDeleteSettings.Name"/></em></p>
        ///   <p>The name of the ANF snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings ResetName(this AzureNetappfilesSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotDeleteSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings SetPoolName(this AzureNetappfilesSnapshotDeleteSettings toolSettings, string poolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = poolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotDeleteSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings ResetPoolName(this AzureNetappfilesSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings SetResourceGroup(this AzureNetappfilesSnapshotDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings ResetResourceGroup(this AzureNetappfilesSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings SetSubscription(this AzureNetappfilesSnapshotDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings ResetSubscription(this AzureNetappfilesSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VolumeName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotDeleteSettings.VolumeName"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings SetVolumeName(this AzureNetappfilesSnapshotDeleteSettings toolSettings, string volumeName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeName = volumeName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotDeleteSettings.VolumeName"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings ResetVolumeName(this AzureNetappfilesSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings SetDebug(this AzureNetappfilesSnapshotDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings ResetDebug(this AzureNetappfilesSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings SetHelp(this AzureNetappfilesSnapshotDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings ResetHelp(this AzureNetappfilesSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings SetOutput(this AzureNetappfilesSnapshotDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings ResetOutput(this AzureNetappfilesSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings SetQuery(this AzureNetappfilesSnapshotDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings ResetQuery(this AzureNetappfilesSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings SetVerbose(this AzureNetappfilesSnapshotDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotDeleteSettings ResetVerbose(this AzureNetappfilesSnapshotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesSnapshotListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesSnapshotListSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotListSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings SetAccountName(this AzureNetappfilesSnapshotListSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotListSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings ResetAccountName(this AzureNetappfilesSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region PoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotListSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings SetPoolName(this AzureNetappfilesSnapshotListSettings toolSettings, string poolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = poolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotListSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings ResetPoolName(this AzureNetappfilesSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings SetResourceGroup(this AzureNetappfilesSnapshotListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings ResetResourceGroup(this AzureNetappfilesSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VolumeName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotListSettings.VolumeName"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings SetVolumeName(this AzureNetappfilesSnapshotListSettings toolSettings, string volumeName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeName = volumeName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotListSettings.VolumeName"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings ResetVolumeName(this AzureNetappfilesSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings SetSubscription(this AzureNetappfilesSnapshotListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings ResetSubscription(this AzureNetappfilesSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings SetDebug(this AzureNetappfilesSnapshotListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings ResetDebug(this AzureNetappfilesSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings SetHelp(this AzureNetappfilesSnapshotListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings ResetHelp(this AzureNetappfilesSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings SetOutput(this AzureNetappfilesSnapshotListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings ResetOutput(this AzureNetappfilesSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings SetQuery(this AzureNetappfilesSnapshotListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings ResetQuery(this AzureNetappfilesSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings SetVerbose(this AzureNetappfilesSnapshotListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotListSettings ResetVerbose(this AzureNetappfilesSnapshotListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesSnapshotShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesSnapshotShowSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotShowSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings SetAccountName(this AzureNetappfilesSnapshotShowSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotShowSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings ResetAccountName(this AzureNetappfilesSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings SetIds(this AzureNetappfilesSnapshotShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings SetIds(this AzureNetappfilesSnapshotShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesSnapshotShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings AddIds(this AzureNetappfilesSnapshotShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesSnapshotShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings AddIds(this AzureNetappfilesSnapshotShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesSnapshotShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings ClearIds(this AzureNetappfilesSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesSnapshotShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings RemoveIds(this AzureNetappfilesSnapshotShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesSnapshotShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings RemoveIds(this AzureNetappfilesSnapshotShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotShowSettings.Name"/></em></p>
        ///   <p>The name of the ANF snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings SetName(this AzureNetappfilesSnapshotShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotShowSettings.Name"/></em></p>
        ///   <p>The name of the ANF snapshot.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings ResetName(this AzureNetappfilesSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotShowSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings SetPoolName(this AzureNetappfilesSnapshotShowSettings toolSettings, string poolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = poolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotShowSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings ResetPoolName(this AzureNetappfilesSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings SetResourceGroup(this AzureNetappfilesSnapshotShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings ResetResourceGroup(this AzureNetappfilesSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings SetSubscription(this AzureNetappfilesSnapshotShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings ResetSubscription(this AzureNetappfilesSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region VolumeName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotShowSettings.VolumeName"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings SetVolumeName(this AzureNetappfilesSnapshotShowSettings toolSettings, string volumeName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeName = volumeName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotShowSettings.VolumeName"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings ResetVolumeName(this AzureNetappfilesSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VolumeName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings SetDebug(this AzureNetappfilesSnapshotShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings ResetDebug(this AzureNetappfilesSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings SetHelp(this AzureNetappfilesSnapshotShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings ResetHelp(this AzureNetappfilesSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings SetOutput(this AzureNetappfilesSnapshotShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings ResetOutput(this AzureNetappfilesSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings SetQuery(this AzureNetappfilesSnapshotShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings ResetQuery(this AzureNetappfilesSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesSnapshotShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings SetVerbose(this AzureNetappfilesSnapshotShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesSnapshotShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesSnapshotShowSettings ResetVerbose(this AzureNetappfilesSnapshotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesAccountCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesAccountCreateSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountCreateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings SetAccountName(this AzureNetappfilesAccountCreateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountCreateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings ResetAccountName(this AzureNetappfilesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings SetLocation(this AzureNetappfilesAccountCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings ResetLocation(this AzureNetappfilesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings SetResourceGroup(this AzureNetappfilesAccountCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings ResetResourceGroup(this AzureNetappfilesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in `key[=value]` format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings SetTags(this AzureNetappfilesAccountCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in `key[=value]` format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings ResetTags(this AzureNetappfilesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings SetSubscription(this AzureNetappfilesAccountCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings ResetSubscription(this AzureNetappfilesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings SetDebug(this AzureNetappfilesAccountCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings ResetDebug(this AzureNetappfilesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings SetHelp(this AzureNetappfilesAccountCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings ResetHelp(this AzureNetappfilesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings SetOutput(this AzureNetappfilesAccountCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings ResetOutput(this AzureNetappfilesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings SetQuery(this AzureNetappfilesAccountCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings ResetQuery(this AzureNetappfilesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings SetVerbose(this AzureNetappfilesAccountCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountCreateSettings ResetVerbose(this AzureNetappfilesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesAccountDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesAccountDeleteSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountDeleteSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings SetAccountName(this AzureNetappfilesAccountDeleteSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountDeleteSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings ResetAccountName(this AzureNetappfilesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings SetIds(this AzureNetappfilesAccountDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings SetIds(this AzureNetappfilesAccountDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesAccountDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings AddIds(this AzureNetappfilesAccountDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesAccountDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings AddIds(this AzureNetappfilesAccountDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesAccountDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings ClearIds(this AzureNetappfilesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesAccountDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings RemoveIds(this AzureNetappfilesAccountDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesAccountDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings RemoveIds(this AzureNetappfilesAccountDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings SetResourceGroup(this AzureNetappfilesAccountDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings ResetResourceGroup(this AzureNetappfilesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings SetSubscription(this AzureNetappfilesAccountDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings ResetSubscription(this AzureNetappfilesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings SetDebug(this AzureNetappfilesAccountDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings ResetDebug(this AzureNetappfilesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings SetHelp(this AzureNetappfilesAccountDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings ResetHelp(this AzureNetappfilesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings SetOutput(this AzureNetappfilesAccountDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings ResetOutput(this AzureNetappfilesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings SetQuery(this AzureNetappfilesAccountDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings ResetQuery(this AzureNetappfilesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings SetVerbose(this AzureNetappfilesAccountDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountDeleteSettings ResetVerbose(this AzureNetappfilesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesAccountListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesAccountListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings SetResourceGroup(this AzureNetappfilesAccountListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings ResetResourceGroup(this AzureNetappfilesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings SetSubscription(this AzureNetappfilesAccountListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings ResetSubscription(this AzureNetappfilesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings SetDebug(this AzureNetappfilesAccountListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings ResetDebug(this AzureNetappfilesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings SetHelp(this AzureNetappfilesAccountListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings ResetHelp(this AzureNetappfilesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings SetOutput(this AzureNetappfilesAccountListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings ResetOutput(this AzureNetappfilesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings SetQuery(this AzureNetappfilesAccountListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings ResetQuery(this AzureNetappfilesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings SetVerbose(this AzureNetappfilesAccountListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountListSettings ResetVerbose(this AzureNetappfilesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesAccountShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesAccountShowSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountShowSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings SetAccountName(this AzureNetappfilesAccountShowSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountShowSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings ResetAccountName(this AzureNetappfilesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings SetIds(this AzureNetappfilesAccountShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings SetIds(this AzureNetappfilesAccountShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesAccountShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings AddIds(this AzureNetappfilesAccountShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesAccountShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings AddIds(this AzureNetappfilesAccountShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesAccountShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings ClearIds(this AzureNetappfilesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesAccountShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings RemoveIds(this AzureNetappfilesAccountShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesAccountShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings RemoveIds(this AzureNetappfilesAccountShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings SetResourceGroup(this AzureNetappfilesAccountShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings ResetResourceGroup(this AzureNetappfilesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings SetSubscription(this AzureNetappfilesAccountShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings ResetSubscription(this AzureNetappfilesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings SetDebug(this AzureNetappfilesAccountShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings ResetDebug(this AzureNetappfilesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings SetHelp(this AzureNetappfilesAccountShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings ResetHelp(this AzureNetappfilesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings SetOutput(this AzureNetappfilesAccountShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings ResetOutput(this AzureNetappfilesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings SetQuery(this AzureNetappfilesAccountShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings ResetQuery(this AzureNetappfilesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings SetVerbose(this AzureNetappfilesAccountShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountShowSettings ResetVerbose(this AzureNetappfilesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesAccountUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesAccountUpdateSettingsExtensions
    {
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in `key[=value]` format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetTags(this AzureNetappfilesAccountUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in `key[=value]` format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ResetTags(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetAccountName(this AzureNetappfilesAccountUpdateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountUpdateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ResetAccountName(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetIds(this AzureNetappfilesAccountUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetIds(this AzureNetappfilesAccountUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesAccountUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings AddIds(this AzureNetappfilesAccountUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesAccountUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings AddIds(this AzureNetappfilesAccountUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesAccountUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ClearIds(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesAccountUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings RemoveIds(this AzureNetappfilesAccountUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesAccountUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings RemoveIds(this AzureNetappfilesAccountUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetResourceGroup(this AzureNetappfilesAccountUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ResetResourceGroup(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetSubscription(this AzureNetappfilesAccountUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ResetSubscription(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetAdd(this AzureNetappfilesAccountUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ResetAdd(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetForceString(this AzureNetappfilesAccountUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ResetForceString(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetRemove(this AzureNetappfilesAccountUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ResetRemove(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetSet(this AzureNetappfilesAccountUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ResetSet(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetDebug(this AzureNetappfilesAccountUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ResetDebug(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetHelp(this AzureNetappfilesAccountUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ResetHelp(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetOutput(this AzureNetappfilesAccountUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ResetOutput(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetQuery(this AzureNetappfilesAccountUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ResetQuery(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings SetVerbose(this AzureNetappfilesAccountUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountUpdateSettings ResetVerbose(this AzureNetappfilesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesPoolCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesPoolCreateSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolCreateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings SetAccountName(this AzureNetappfilesPoolCreateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolCreateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings ResetAccountName(this AzureNetappfilesPoolCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings SetLocation(this AzureNetappfilesPoolCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings ResetLocation(this AzureNetappfilesPoolCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolCreateSettings.Name"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings SetName(this AzureNetappfilesPoolCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolCreateSettings.Name"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings ResetName(this AzureNetappfilesPoolCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings SetResourceGroup(this AzureNetappfilesPoolCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings ResetResourceGroup(this AzureNetappfilesPoolCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceLevel
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolCreateSettings.ServiceLevel"/></em></p>
        ///   <p>The service level for the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings SetServiceLevel(this AzureNetappfilesPoolCreateSettings toolSettings, NetappfilesPoolServiceLevel serviceLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceLevel = serviceLevel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolCreateSettings.ServiceLevel"/></em></p>
        ///   <p>The service level for the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings ResetServiceLevel(this AzureNetappfilesPoolCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceLevel = null;
            return toolSettings;
        }
        #endregion
        #region Size
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolCreateSettings.Size"/></em></p>
        ///   <p>The size for the ANF pool. Must be an integer number of tebibytes in multiples of 4.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings SetSize(this AzureNetappfilesPoolCreateSettings toolSettings, string size)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = size;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolCreateSettings.Size"/></em></p>
        ///   <p>The size for the ANF pool. Must be an integer number of tebibytes in multiples of 4.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings ResetSize(this AzureNetappfilesPoolCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in `key[=value]` format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings SetTags(this AzureNetappfilesPoolCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in `key[=value]` format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings ResetTags(this AzureNetappfilesPoolCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings SetSubscription(this AzureNetappfilesPoolCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings ResetSubscription(this AzureNetappfilesPoolCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings SetDebug(this AzureNetappfilesPoolCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings ResetDebug(this AzureNetappfilesPoolCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings SetHelp(this AzureNetappfilesPoolCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings ResetHelp(this AzureNetappfilesPoolCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings SetOutput(this AzureNetappfilesPoolCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings ResetOutput(this AzureNetappfilesPoolCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings SetQuery(this AzureNetappfilesPoolCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings ResetQuery(this AzureNetappfilesPoolCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings SetVerbose(this AzureNetappfilesPoolCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolCreateSettings ResetVerbose(this AzureNetappfilesPoolCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesPoolDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesPoolDeleteSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolDeleteSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings SetAccountName(this AzureNetappfilesPoolDeleteSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolDeleteSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings ResetAccountName(this AzureNetappfilesPoolDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings SetIds(this AzureNetappfilesPoolDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings SetIds(this AzureNetappfilesPoolDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesPoolDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings AddIds(this AzureNetappfilesPoolDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesPoolDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings AddIds(this AzureNetappfilesPoolDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesPoolDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings ClearIds(this AzureNetappfilesPoolDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesPoolDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings RemoveIds(this AzureNetappfilesPoolDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesPoolDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings RemoveIds(this AzureNetappfilesPoolDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolDeleteSettings.Name"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings SetName(this AzureNetappfilesPoolDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolDeleteSettings.Name"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings ResetName(this AzureNetappfilesPoolDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings SetResourceGroup(this AzureNetappfilesPoolDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings ResetResourceGroup(this AzureNetappfilesPoolDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings SetSubscription(this AzureNetappfilesPoolDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings ResetSubscription(this AzureNetappfilesPoolDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings SetDebug(this AzureNetappfilesPoolDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings ResetDebug(this AzureNetappfilesPoolDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings SetHelp(this AzureNetappfilesPoolDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings ResetHelp(this AzureNetappfilesPoolDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings SetOutput(this AzureNetappfilesPoolDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings ResetOutput(this AzureNetappfilesPoolDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings SetQuery(this AzureNetappfilesPoolDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings ResetQuery(this AzureNetappfilesPoolDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings SetVerbose(this AzureNetappfilesPoolDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolDeleteSettings ResetVerbose(this AzureNetappfilesPoolDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesPoolListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesPoolListSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolListSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings SetAccountName(this AzureNetappfilesPoolListSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolListSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings ResetAccountName(this AzureNetappfilesPoolListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings SetResourceGroup(this AzureNetappfilesPoolListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings ResetResourceGroup(this AzureNetappfilesPoolListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings SetSubscription(this AzureNetappfilesPoolListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings ResetSubscription(this AzureNetappfilesPoolListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings SetDebug(this AzureNetappfilesPoolListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings ResetDebug(this AzureNetappfilesPoolListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings SetHelp(this AzureNetappfilesPoolListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings ResetHelp(this AzureNetappfilesPoolListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings SetOutput(this AzureNetappfilesPoolListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings ResetOutput(this AzureNetappfilesPoolListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings SetQuery(this AzureNetappfilesPoolListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings ResetQuery(this AzureNetappfilesPoolListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings SetVerbose(this AzureNetappfilesPoolListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolListSettings ResetVerbose(this AzureNetappfilesPoolListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesPoolShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesPoolShowSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolShowSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings SetAccountName(this AzureNetappfilesPoolShowSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolShowSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings ResetAccountName(this AzureNetappfilesPoolShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings SetIds(this AzureNetappfilesPoolShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings SetIds(this AzureNetappfilesPoolShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesPoolShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings AddIds(this AzureNetappfilesPoolShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesPoolShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings AddIds(this AzureNetappfilesPoolShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesPoolShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings ClearIds(this AzureNetappfilesPoolShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesPoolShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings RemoveIds(this AzureNetappfilesPoolShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesPoolShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings RemoveIds(this AzureNetappfilesPoolShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolShowSettings.Name"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings SetName(this AzureNetappfilesPoolShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolShowSettings.Name"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings ResetName(this AzureNetappfilesPoolShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings SetResourceGroup(this AzureNetappfilesPoolShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings ResetResourceGroup(this AzureNetappfilesPoolShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings SetSubscription(this AzureNetappfilesPoolShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings ResetSubscription(this AzureNetappfilesPoolShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings SetDebug(this AzureNetappfilesPoolShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings ResetDebug(this AzureNetappfilesPoolShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings SetHelp(this AzureNetappfilesPoolShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings ResetHelp(this AzureNetappfilesPoolShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings SetOutput(this AzureNetappfilesPoolShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings ResetOutput(this AzureNetappfilesPoolShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings SetQuery(this AzureNetappfilesPoolShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings ResetQuery(this AzureNetappfilesPoolShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings SetVerbose(this AzureNetappfilesPoolShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolShowSettings ResetVerbose(this AzureNetappfilesPoolShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesPoolUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesPoolUpdateSettingsExtensions
    {
        #region ServiceLevel
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.ServiceLevel"/></em></p>
        ///   <p>The service level for the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetServiceLevel(this AzureNetappfilesPoolUpdateSettings toolSettings, NetappfilesPoolServiceLevel serviceLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceLevel = serviceLevel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.ServiceLevel"/></em></p>
        ///   <p>The service level for the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetServiceLevel(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceLevel = null;
            return toolSettings;
        }
        #endregion
        #region Size
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Size"/></em></p>
        ///   <p>The size for the ANF pool. Must be an integer number of tebibytes in multiples of 4.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetSize(this AzureNetappfilesPoolUpdateSettings toolSettings, string size)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = size;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.Size"/></em></p>
        ///   <p>The size for the ANF pool. Must be an integer number of tebibytes in multiples of 4.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetSize(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in `key[=value]` format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetTags(this AzureNetappfilesPoolUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in `key[=value]` format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetTags(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetAccountName(this AzureNetappfilesPoolUpdateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetAccountName(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetIds(this AzureNetappfilesPoolUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetIds(this AzureNetappfilesPoolUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesPoolUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings AddIds(this AzureNetappfilesPoolUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesPoolUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings AddIds(this AzureNetappfilesPoolUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesPoolUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ClearIds(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesPoolUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings RemoveIds(this AzureNetappfilesPoolUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesPoolUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings RemoveIds(this AzureNetappfilesPoolUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Name"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetName(this AzureNetappfilesPoolUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.Name"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetName(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetResourceGroup(this AzureNetappfilesPoolUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetResourceGroup(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetSubscription(this AzureNetappfilesPoolUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetSubscription(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetAdd(this AzureNetappfilesPoolUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetAdd(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetForceString(this AzureNetappfilesPoolUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetForceString(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetRemove(this AzureNetappfilesPoolUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetRemove(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetSet(this AzureNetappfilesPoolUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetSet(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetDebug(this AzureNetappfilesPoolUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetDebug(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetHelp(this AzureNetappfilesPoolUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetHelp(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetOutput(this AzureNetappfilesPoolUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetOutput(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetQuery(this AzureNetappfilesPoolUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetQuery(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesPoolUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings SetVerbose(this AzureNetappfilesPoolUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesPoolUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesPoolUpdateSettings ResetVerbose(this AzureNetappfilesPoolUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesVolumeCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesVolumeCreateSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetAccountName(this AzureNetappfilesVolumeCreateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetAccountName(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region CreationToken
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.CreationToken"/></em></p>
        ///   <p>A 1-80 character long alphanumeric string value that identifies a unique file share or mount point in the target subnet.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetCreationToken(this AzureNetappfilesVolumeCreateSettings toolSettings, string creationToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreationToken = creationToken;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.CreationToken"/></em></p>
        ///   <p>A 1-80 character long alphanumeric string value that identifies a unique file share or mount point in the target subnet.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetCreationToken(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreationToken = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetLocation(this AzureNetappfilesVolumeCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetLocation(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.Name"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetName(this AzureNetappfilesVolumeCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.Name"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetName(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetPoolName(this AzureNetappfilesVolumeCreateSettings toolSettings, string poolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = poolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetPoolName(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetResourceGroup(this AzureNetappfilesVolumeCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetResourceGroup(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region UsageThreshold
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.UsageThreshold"/></em></p>
        ///   <p>The maximum storage quota allowed for a file system as integer number of GiB. Min 100 GiB, max 100TiB".</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetUsageThreshold(this AzureNetappfilesVolumeCreateSettings toolSettings, string usageThreshold)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UsageThreshold = usageThreshold;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.UsageThreshold"/></em></p>
        ///   <p>The maximum storage quota allowed for a file system as integer number of GiB. Min 100 GiB, max 100TiB".</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetUsageThreshold(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UsageThreshold = null;
            return toolSettings;
        }
        #endregion
        #region Vnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.Vnet"/></em></p>
        ///   <p>The ARM Id or name of the vnet for the volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetVnet(this AzureNetappfilesVolumeCreateSettings toolSettings, string vnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Vnet = vnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.Vnet"/></em></p>
        ///   <p>The ARM Id or name of the vnet for the volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetVnet(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Vnet = null;
            return toolSettings;
        }
        #endregion
        #region ProtocolTypes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.ProtocolTypes"/></em></p>
        ///   <p>Space seperated list of protocols that the volume can use.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetProtocolTypes(this AzureNetappfilesVolumeCreateSettings toolSettings, string protocolTypes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProtocolTypes = protocolTypes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.ProtocolTypes"/></em></p>
        ///   <p>Space seperated list of protocols that the volume can use.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetProtocolTypes(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProtocolTypes = null;
            return toolSettings;
        }
        #endregion
        #region ServiceLevel
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.ServiceLevel"/></em></p>
        ///   <p>The service level.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetServiceLevel(this AzureNetappfilesVolumeCreateSettings toolSettings, NetappfilesPoolServiceLevel serviceLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceLevel = serviceLevel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.ServiceLevel"/></em></p>
        ///   <p>The service level.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetServiceLevel(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceLevel = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.Subnet"/></em></p>
        ///   <p>The ARM Id or name of the subnet for the vnet. If omitted 'default' will be used.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetSubnet(this AzureNetappfilesVolumeCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.Subnet"/></em></p>
        ///   <p>The ARM Id or name of the subnet for the vnet. If omitted 'default' will be used.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetSubnet(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in `key[=value]` format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetTags(this AzureNetappfilesVolumeCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in `key[=value]` format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetTags(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetSubscription(this AzureNetappfilesVolumeCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetSubscription(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetDebug(this AzureNetappfilesVolumeCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetDebug(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetHelp(this AzureNetappfilesVolumeCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetHelp(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetOutput(this AzureNetappfilesVolumeCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetOutput(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetQuery(this AzureNetappfilesVolumeCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetQuery(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings SetVerbose(this AzureNetappfilesVolumeCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeCreateSettings ResetVerbose(this AzureNetappfilesVolumeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesVolumeDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesVolumeDeleteSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeDeleteSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings SetAccountName(this AzureNetappfilesVolumeDeleteSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeDeleteSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings ResetAccountName(this AzureNetappfilesVolumeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings SetIds(this AzureNetappfilesVolumeDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings SetIds(this AzureNetappfilesVolumeDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesVolumeDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings AddIds(this AzureNetappfilesVolumeDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesVolumeDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings AddIds(this AzureNetappfilesVolumeDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesVolumeDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings ClearIds(this AzureNetappfilesVolumeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesVolumeDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings RemoveIds(this AzureNetappfilesVolumeDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesVolumeDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings RemoveIds(this AzureNetappfilesVolumeDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeDeleteSettings.Name"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings SetName(this AzureNetappfilesVolumeDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeDeleteSettings.Name"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings ResetName(this AzureNetappfilesVolumeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeDeleteSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings SetPoolName(this AzureNetappfilesVolumeDeleteSettings toolSettings, string poolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = poolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeDeleteSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings ResetPoolName(this AzureNetappfilesVolumeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings SetResourceGroup(this AzureNetappfilesVolumeDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings ResetResourceGroup(this AzureNetappfilesVolumeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings SetSubscription(this AzureNetappfilesVolumeDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings ResetSubscription(this AzureNetappfilesVolumeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings SetDebug(this AzureNetappfilesVolumeDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings ResetDebug(this AzureNetappfilesVolumeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings SetHelp(this AzureNetappfilesVolumeDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings ResetHelp(this AzureNetappfilesVolumeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings SetOutput(this AzureNetappfilesVolumeDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings ResetOutput(this AzureNetappfilesVolumeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings SetQuery(this AzureNetappfilesVolumeDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings ResetQuery(this AzureNetappfilesVolumeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings SetVerbose(this AzureNetappfilesVolumeDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeDeleteSettings ResetVerbose(this AzureNetappfilesVolumeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesVolumeListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesVolumeListSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeListSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings SetAccountName(this AzureNetappfilesVolumeListSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeListSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings ResetAccountName(this AzureNetappfilesVolumeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region PoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeListSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings SetPoolName(this AzureNetappfilesVolumeListSettings toolSettings, string poolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = poolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeListSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings ResetPoolName(this AzureNetappfilesVolumeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings SetResourceGroup(this AzureNetappfilesVolumeListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings ResetResourceGroup(this AzureNetappfilesVolumeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings SetSubscription(this AzureNetappfilesVolumeListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings ResetSubscription(this AzureNetappfilesVolumeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings SetDebug(this AzureNetappfilesVolumeListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings ResetDebug(this AzureNetappfilesVolumeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings SetHelp(this AzureNetappfilesVolumeListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings ResetHelp(this AzureNetappfilesVolumeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings SetOutput(this AzureNetappfilesVolumeListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings ResetOutput(this AzureNetappfilesVolumeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings SetQuery(this AzureNetappfilesVolumeListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings ResetQuery(this AzureNetappfilesVolumeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings SetVerbose(this AzureNetappfilesVolumeListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeListSettings ResetVerbose(this AzureNetappfilesVolumeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesVolumeShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesVolumeShowSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeShowSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings SetAccountName(this AzureNetappfilesVolumeShowSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeShowSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings ResetAccountName(this AzureNetappfilesVolumeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings SetIds(this AzureNetappfilesVolumeShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings SetIds(this AzureNetappfilesVolumeShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesVolumeShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings AddIds(this AzureNetappfilesVolumeShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesVolumeShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings AddIds(this AzureNetappfilesVolumeShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesVolumeShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings ClearIds(this AzureNetappfilesVolumeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesVolumeShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings RemoveIds(this AzureNetappfilesVolumeShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesVolumeShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings RemoveIds(this AzureNetappfilesVolumeShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeShowSettings.Name"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings SetName(this AzureNetappfilesVolumeShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeShowSettings.Name"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings ResetName(this AzureNetappfilesVolumeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeShowSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings SetPoolName(this AzureNetappfilesVolumeShowSettings toolSettings, string poolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = poolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeShowSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings ResetPoolName(this AzureNetappfilesVolumeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings SetResourceGroup(this AzureNetappfilesVolumeShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings ResetResourceGroup(this AzureNetappfilesVolumeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings SetSubscription(this AzureNetappfilesVolumeShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings ResetSubscription(this AzureNetappfilesVolumeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings SetDebug(this AzureNetappfilesVolumeShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings ResetDebug(this AzureNetappfilesVolumeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings SetHelp(this AzureNetappfilesVolumeShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings ResetHelp(this AzureNetappfilesVolumeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings SetOutput(this AzureNetappfilesVolumeShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings ResetOutput(this AzureNetappfilesVolumeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings SetQuery(this AzureNetappfilesVolumeShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings ResetQuery(this AzureNetappfilesVolumeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings SetVerbose(this AzureNetappfilesVolumeShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeShowSettings ResetVerbose(this AzureNetappfilesVolumeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesVolumeUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesVolumeUpdateSettingsExtensions
    {
        #region ProtocolTypes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.ProtocolTypes"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetProtocolTypes(this AzureNetappfilesVolumeUpdateSettings toolSettings, string protocolTypes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProtocolTypes = protocolTypes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.ProtocolTypes"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetProtocolTypes(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProtocolTypes = null;
            return toolSettings;
        }
        #endregion
        #region ServiceLevel
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.ServiceLevel"/></em></p>
        ///   <p>The service level.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetServiceLevel(this AzureNetappfilesVolumeUpdateSettings toolSettings, NetappfilesPoolServiceLevel serviceLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceLevel = serviceLevel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.ServiceLevel"/></em></p>
        ///   <p>The service level.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetServiceLevel(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceLevel = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in `key[=value]` format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetTags(this AzureNetappfilesVolumeUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in `key[=value]` format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetTags(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region UsageThreshold
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.UsageThreshold"/></em></p>
        ///   <p>The maximum storage quota allowed for a file system as integer number of GiB. Min 100 GiB, max 100TiB".</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetUsageThreshold(this AzureNetappfilesVolumeUpdateSettings toolSettings, string usageThreshold)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UsageThreshold = usageThreshold;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.UsageThreshold"/></em></p>
        ///   <p>The maximum storage quota allowed for a file system as integer number of GiB. Min 100 GiB, max 100TiB".</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetUsageThreshold(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UsageThreshold = null;
            return toolSettings;
        }
        #endregion
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetAccountName(this AzureNetappfilesVolumeUpdateSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetAccountName(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetIds(this AzureNetappfilesVolumeUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetIds(this AzureNetappfilesVolumeUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesVolumeUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings AddIds(this AzureNetappfilesVolumeUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesVolumeUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings AddIds(this AzureNetappfilesVolumeUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesVolumeUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ClearIds(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesVolumeUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings RemoveIds(this AzureNetappfilesVolumeUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesVolumeUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings RemoveIds(this AzureNetappfilesVolumeUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.Name"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetName(this AzureNetappfilesVolumeUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.Name"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetName(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetPoolName(this AzureNetappfilesVolumeUpdateSettings toolSettings, string poolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = poolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetPoolName(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetResourceGroup(this AzureNetappfilesVolumeUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetResourceGroup(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetSubscription(this AzureNetappfilesVolumeUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetSubscription(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetAdd(this AzureNetappfilesVolumeUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetAdd(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetForceString(this AzureNetappfilesVolumeUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetForceString(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetRemove(this AzureNetappfilesVolumeUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetRemove(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetSet(this AzureNetappfilesVolumeUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetSet(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetDebug(this AzureNetappfilesVolumeUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetDebug(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetHelp(this AzureNetappfilesVolumeUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetHelp(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetOutput(this AzureNetappfilesVolumeUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetOutput(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetQuery(this AzureNetappfilesVolumeUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetQuery(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings SetVerbose(this AzureNetappfilesVolumeUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeUpdateSettings ResetVerbose(this AzureNetappfilesVolumeUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesAccountAdAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesAccountAdAddSettingsExtensions
    {
        #region Dns
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Dns"/></em></p>
        ///   <p>Comma separated list of DNS server IP addresses for the Active Directory domain.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetDns(this AzureNetappfilesAccountAdAddSettings toolSettings, string dns)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dns = dns;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.Dns"/></em></p>
        ///   <p>Comma separated list of DNS server IP addresses for the Active Directory domain.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetDns(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Dns = null;
            return toolSettings;
        }
        #endregion
        #region Domain
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Domain"/></em></p>
        ///   <p>Name of the Active Directory domain.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetDomain(this AzureNetappfilesAccountAdAddSettings toolSettings, string domain)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Domain = domain;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.Domain"/></em></p>
        ///   <p>Name of the Active Directory domain.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetDomain(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Domain = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Password"/></em></p>
        ///   <p>Plain text password of Active Directory domain administrator.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetPassword(this AzureNetappfilesAccountAdAddSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.Password"/></em></p>
        ///   <p>Plain text password of Active Directory domain administrator.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetPassword(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region SmbServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.SmbServerName"/></em></p>
        ///   <p>NetBIOS name of the SMB server. This name will be registered as a computer account in the AD and used to mount volumes. Must be 10 characters or less.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetSmbServerName(this AzureNetappfilesAccountAdAddSettings toolSettings, string smbServerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SmbServerName = smbServerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.SmbServerName"/></em></p>
        ///   <p>NetBIOS name of the SMB server. This name will be registered as a computer account in the AD and used to mount volumes. Must be 10 characters or less.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetSmbServerName(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SmbServerName = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Username"/></em></p>
        ///   <p>Username of Active Directory domain administrator.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetUsername(this AzureNetappfilesAccountAdAddSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.Username"/></em></p>
        ///   <p>Username of Active Directory domain administrator.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetUsername(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region OrganizationalUnit
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.OrganizationalUnit"/></em></p>
        ///   <p>The Organizational Unit (OU) within the Windows Active Directory.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetOrganizationalUnit(this AzureNetappfilesAccountAdAddSettings toolSettings, string organizationalUnit)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrganizationalUnit = organizationalUnit;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.OrganizationalUnit"/></em></p>
        ///   <p>The Organizational Unit (OU) within the Windows Active Directory.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetOrganizationalUnit(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrganizationalUnit = null;
            return toolSettings;
        }
        #endregion
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetAccountName(this AzureNetappfilesAccountAdAddSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetAccountName(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetIds(this AzureNetappfilesAccountAdAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetIds(this AzureNetappfilesAccountAdAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesAccountAdAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings AddIds(this AzureNetappfilesAccountAdAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesAccountAdAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings AddIds(this AzureNetappfilesAccountAdAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesAccountAdAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ClearIds(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesAccountAdAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings RemoveIds(this AzureNetappfilesAccountAdAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesAccountAdAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings RemoveIds(this AzureNetappfilesAccountAdAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetResourceGroup(this AzureNetappfilesAccountAdAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetResourceGroup(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetSubscription(this AzureNetappfilesAccountAdAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetSubscription(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetAdd(this AzureNetappfilesAccountAdAddSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetAdd(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetForceString(this AzureNetappfilesAccountAdAddSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetForceString(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetRemove(this AzureNetappfilesAccountAdAddSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetRemove(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetSet(this AzureNetappfilesAccountAdAddSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetSet(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetDebug(this AzureNetappfilesAccountAdAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetDebug(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetHelp(this AzureNetappfilesAccountAdAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetHelp(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetOutput(this AzureNetappfilesAccountAdAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetOutput(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetQuery(this AzureNetappfilesAccountAdAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetQuery(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings SetVerbose(this AzureNetappfilesAccountAdAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdAddSettings ResetVerbose(this AzureNetappfilesAccountAdAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesAccountAdListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesAccountAdListSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdListSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings SetAccountName(this AzureNetappfilesAccountAdListSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdListSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings ResetAccountName(this AzureNetappfilesAccountAdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings SetResourceGroup(this AzureNetappfilesAccountAdListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings ResetResourceGroup(this AzureNetappfilesAccountAdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings SetSubscription(this AzureNetappfilesAccountAdListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings ResetSubscription(this AzureNetappfilesAccountAdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings SetDebug(this AzureNetappfilesAccountAdListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings ResetDebug(this AzureNetappfilesAccountAdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings SetHelp(this AzureNetappfilesAccountAdListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings ResetHelp(this AzureNetappfilesAccountAdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings SetOutput(this AzureNetappfilesAccountAdListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings ResetOutput(this AzureNetappfilesAccountAdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings SetQuery(this AzureNetappfilesAccountAdListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings ResetQuery(this AzureNetappfilesAccountAdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings SetVerbose(this AzureNetappfilesAccountAdListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdListSettings ResetVerbose(this AzureNetappfilesAccountAdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesAccountAdRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesAccountAdRemoveSettingsExtensions
    {
        #region ActiveDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdRemoveSettings.ActiveDirectory"/></em></p>
        ///   <p>The id of the active directory.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings SetActiveDirectory(this AzureNetappfilesAccountAdRemoveSettings toolSettings, string activeDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActiveDirectory = activeDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdRemoveSettings.ActiveDirectory"/></em></p>
        ///   <p>The id of the active directory.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings ResetActiveDirectory(this AzureNetappfilesAccountAdRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ActiveDirectory = null;
            return toolSettings;
        }
        #endregion
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdRemoveSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings SetAccountName(this AzureNetappfilesAccountAdRemoveSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdRemoveSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings ResetAccountName(this AzureNetappfilesAccountAdRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdRemoveSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings SetIds(this AzureNetappfilesAccountAdRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdRemoveSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings SetIds(this AzureNetappfilesAccountAdRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesAccountAdRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings AddIds(this AzureNetappfilesAccountAdRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesAccountAdRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings AddIds(this AzureNetappfilesAccountAdRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesAccountAdRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings ClearIds(this AzureNetappfilesAccountAdRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesAccountAdRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings RemoveIds(this AzureNetappfilesAccountAdRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesAccountAdRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings RemoveIds(this AzureNetappfilesAccountAdRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings SetResourceGroup(this AzureNetappfilesAccountAdRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings ResetResourceGroup(this AzureNetappfilesAccountAdRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings SetSubscription(this AzureNetappfilesAccountAdRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings ResetSubscription(this AzureNetappfilesAccountAdRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings SetDebug(this AzureNetappfilesAccountAdRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings ResetDebug(this AzureNetappfilesAccountAdRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings SetHelp(this AzureNetappfilesAccountAdRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings ResetHelp(this AzureNetappfilesAccountAdRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings SetOutput(this AzureNetappfilesAccountAdRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings ResetOutput(this AzureNetappfilesAccountAdRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings SetQuery(this AzureNetappfilesAccountAdRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings ResetQuery(this AzureNetappfilesAccountAdRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesAccountAdRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings SetVerbose(this AzureNetappfilesAccountAdRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesAccountAdRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesAccountAdRemoveSettings ResetVerbose(this AzureNetappfilesAccountAdRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesVolumeExportPolicyAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesVolumeExportPolicyAddSettingsExtensions
    {
        #region AllowedClients
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.AllowedClients"/></em></p>
        ///   <p>Client ingress specification as comma separated string with IPv4 CIDRs, IPv4 host addresses and host names).</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetAllowedClients(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string allowedClients)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedClients = allowedClients;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.AllowedClients"/></em></p>
        ///   <p>Client ingress specification as comma separated string with IPv4 CIDRs, IPv4 host addresses and host names).</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetAllowedClients(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedClients = null;
            return toolSettings;
        }
        #endregion
        #region Cifs
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Cifs"/></em></p>
        ///   <p>Indication that CIFS protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetCifs(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, bool? cifs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cifs = cifs;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Cifs"/></em></p>
        ///   <p>Indication that CIFS protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetCifs(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cifs = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Cifs"/></em></p>
        ///   <p>Indication that CIFS protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings EnableCifs(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cifs = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Cifs"/></em></p>
        ///   <p>Indication that CIFS protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings DisableCifs(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cifs = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Cifs"/></em></p>
        ///   <p>Indication that CIFS protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ToggleCifs(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cifs = !toolSettings.Cifs;
            return toolSettings;
        }
        #endregion
        #region Nfsv3
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv3"/></em></p>
        ///   <p>Indication that NFSv3 protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetNfsv3(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, bool? nfsv3)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfsv3 = nfsv3;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv3"/></em></p>
        ///   <p>Indication that NFSv3 protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetNfsv3(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfsv3 = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv3"/></em></p>
        ///   <p>Indication that NFSv3 protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings EnableNfsv3(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfsv3 = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv3"/></em></p>
        ///   <p>Indication that NFSv3 protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings DisableNfsv3(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfsv3 = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv3"/></em></p>
        ///   <p>Indication that NFSv3 protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ToggleNfsv3(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfsv3 = !toolSettings.Nfsv3;
            return toolSettings;
        }
        #endregion
        #region Nfsv4
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv4"/></em></p>
        ///   <p>Indication that NFSv4 protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetNfsv4(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, bool? nfsv4)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfsv4 = nfsv4;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv4"/></em></p>
        ///   <p>Indication that NFSv4 protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetNfsv4(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfsv4 = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv4"/></em></p>
        ///   <p>Indication that NFSv4 protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings EnableNfsv4(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfsv4 = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv4"/></em></p>
        ///   <p>Indication that NFSv4 protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings DisableNfsv4(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfsv4 = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Nfsv4"/></em></p>
        ///   <p>Indication that NFSv4 protocol is allowed.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ToggleNfsv4(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfsv4 = !toolSettings.Nfsv4;
            return toolSettings;
        }
        #endregion
        #region RuleIndex
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.RuleIndex"/></em></p>
        ///   <p>Order index. No number can be repeated. Max 6 rules.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetRuleIndex(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string ruleIndex)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleIndex = ruleIndex;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.RuleIndex"/></em></p>
        ///   <p>Order index. No number can be repeated. Max 6 rules.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetRuleIndex(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleIndex = null;
            return toolSettings;
        }
        #endregion
        #region UnixReadOnly
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadOnly"/></em></p>
        ///   <p>Indication of read only access.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetUnixReadOnly(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, bool? unixReadOnly)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnixReadOnly = unixReadOnly;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadOnly"/></em></p>
        ///   <p>Indication of read only access.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetUnixReadOnly(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnixReadOnly = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadOnly"/></em></p>
        ///   <p>Indication of read only access.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings EnableUnixReadOnly(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnixReadOnly = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadOnly"/></em></p>
        ///   <p>Indication of read only access.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings DisableUnixReadOnly(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnixReadOnly = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadOnly"/></em></p>
        ///   <p>Indication of read only access.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ToggleUnixReadOnly(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnixReadOnly = !toolSettings.UnixReadOnly;
            return toolSettings;
        }
        #endregion
        #region UnixReadWrite
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadWrite"/></em></p>
        ///   <p>Indication of read and write access.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetUnixReadWrite(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, bool? unixReadWrite)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnixReadWrite = unixReadWrite;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadWrite"/></em></p>
        ///   <p>Indication of read and write access.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetUnixReadWrite(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnixReadWrite = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadWrite"/></em></p>
        ///   <p>Indication of read and write access.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings EnableUnixReadWrite(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnixReadWrite = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadWrite"/></em></p>
        ///   <p>Indication of read and write access.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings DisableUnixReadWrite(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnixReadWrite = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.UnixReadWrite"/></em></p>
        ///   <p>Indication of read and write access.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ToggleUnixReadWrite(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnixReadWrite = !toolSettings.UnixReadWrite;
            return toolSettings;
        }
        #endregion
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetAccountName(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetAccountName(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetIds(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetIds(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings AddIds(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings AddIds(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ClearIds(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings RemoveIds(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings RemoveIds(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Name"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetName(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Name"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetName(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetPoolName(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string poolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = poolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetPoolName(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetResourceGroup(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetResourceGroup(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetSubscription(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetSubscription(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetAdd(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetAdd(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetForceString(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetForceString(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetRemove(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetRemove(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetSet(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetSet(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetDebug(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetDebug(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetHelp(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetHelp(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetOutput(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetOutput(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetQuery(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetQuery(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings SetVerbose(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyAddSettings ResetVerbose(this AzureNetappfilesVolumeExportPolicyAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesVolumeExportPolicyListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesVolumeExportPolicyListSettingsExtensions
    {
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings SetAccountName(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings ResetAccountName(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Name"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings SetName(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Name"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings ResetName(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings SetPoolName(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings, string poolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = poolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings ResetPoolName(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings SetResourceGroup(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings ResetResourceGroup(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings SetSubscription(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings ResetSubscription(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings SetDebug(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings ResetDebug(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings SetHelp(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings ResetHelp(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings SetOutput(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings ResetOutput(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings SetQuery(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings ResetQuery(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings SetVerbose(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyListSettings ResetVerbose(this AzureNetappfilesVolumeExportPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureNetappfilesVolumeExportPolicyRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureNetappfilesVolumeExportPolicyRemoveSettingsExtensions
    {
        #region RuleIndex
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.RuleIndex"/></em></p>
        ///   <p>Order index. Range 1 to 6.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetRuleIndex(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string ruleIndex)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleIndex = ruleIndex;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.RuleIndex"/></em></p>
        ///   <p>Order index. Range 1 to 6.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetRuleIndex(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleIndex = null;
            return toolSettings;
        }
        #endregion
        #region AccountName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetAccountName(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string accountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = accountName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.AccountName"/></em></p>
        ///   <p>The name of the ANF account.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetAccountName(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetIds(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetIds(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings AddIds(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings AddIds(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ClearIds(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings RemoveIds(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings RemoveIds(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Name"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetName(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Name"/></em></p>
        ///   <p>The name of the ANF volume.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetName(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetPoolName(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string poolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = poolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.PoolName"/></em></p>
        ///   <p>The name of the ANF pool.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetPoolName(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PoolName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetResourceGroup(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetResourceGroup(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetSubscription(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetSubscription(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetAdd(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetAdd(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetForceString(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetForceString(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetRemove(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetRemove(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetSet(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetSet(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetDebug(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetDebug(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetHelp(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetHelp(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetOutput(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetOutput(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetQuery(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetQuery(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings SetVerbose(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureNetappfilesVolumeExportPolicyRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureNetappfilesVolumeExportPolicyRemoveSettings ResetVerbose(this AzureNetappfilesVolumeExportPolicyRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region NetappfilesPoolServiceLevel
    /// <summary>
    ///   Used within <see cref="AzureNetappfilesTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<NetappfilesPoolServiceLevel>))]
    public partial class NetappfilesPoolServiceLevel : Enumeration
    {
        public static NetappfilesPoolServiceLevel premium = new NetappfilesPoolServiceLevel { Value = "premium" };
        public static NetappfilesPoolServiceLevel standard = new NetappfilesPoolServiceLevel { Value = "standard" };
        public static NetappfilesPoolServiceLevel ultra = new NetappfilesPoolServiceLevel { Value = "ultra" };
    }
    #endregion
}
