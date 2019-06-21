// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureGroup.json
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
    public static partial class AzureGroupTasks
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public static string AzureGroupPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREGROUP_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureGroupLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage resource groups and template deployments.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroup(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureGroupPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureGroupLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupCreate(AzureGroupCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureGroupCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureGroupCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupCreate(Configure<AzureGroupCreateSettings> configurator)
        {
            return AzureGroupCreate(configurator(new AzureGroupCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureGroupCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureGroupCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupCreate(CombinatorialConfigure<AzureGroupCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupCreate, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupDelete(AzureGroupDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureGroupDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureGroupDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupDelete(Configure<AzureGroupDeleteSettings> configurator)
        {
            return AzureGroupDelete(configurator(new AzureGroupDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureGroupDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureGroupDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupDelete(CombinatorialConfigure<AzureGroupDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupDelete, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupExists(AzureGroupExistsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupExistsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupExistsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupExistsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupExistsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupExistsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupExistsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupExistsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupExistsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupExists(Configure<AzureGroupExistsSettings> configurator)
        {
            return AzureGroupExists(configurator(new AzureGroupExistsSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupExistsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupExistsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupExistsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupExistsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupExistsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupExistsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupExistsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupExistsSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupExists(CombinatorialConfigure<AzureGroupExistsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupExists, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupExport(AzureGroupExportSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupExportSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupExportSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupExportSettings.Help"/></li>
        ///     <li><c>--include-comments</c> via <see cref="AzureGroupExportSettings.IncludeComments"/></li>
        ///     <li><c>--include-parameter-default-value</c> via <see cref="AzureGroupExportSettings.IncludeParameterDefaultValue"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupExportSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupExportSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupExportSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupExportSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupExportSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupExport(Configure<AzureGroupExportSettings> configurator)
        {
            return AzureGroupExport(configurator(new AzureGroupExportSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupExportSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupExportSettings.Help"/></li>
        ///     <li><c>--include-comments</c> via <see cref="AzureGroupExportSettings.IncludeComments"/></li>
        ///     <li><c>--include-parameter-default-value</c> via <see cref="AzureGroupExportSettings.IncludeParameterDefaultValue"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupExportSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupExportSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupExportSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupExportSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupExportSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupExportSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupExport(CombinatorialConfigure<AzureGroupExportSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupExport, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupList(AzureGroupListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupListSettings.Subscription"/></li>
        ///     <li><c>--tag</c> via <see cref="AzureGroupListSettings.Tag"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupList(Configure<AzureGroupListSettings> configurator)
        {
            return AzureGroupList(configurator(new AzureGroupListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupListSettings.Subscription"/></li>
        ///     <li><c>--tag</c> via <see cref="AzureGroupListSettings.Tag"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupListSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupList(CombinatorialConfigure<AzureGroupListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupList, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupShow(AzureGroupShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupShow(Configure<AzureGroupShowSettings> configurator)
        {
            return AzureGroupShow(configurator(new AzureGroupShowSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupShow(CombinatorialConfigure<AzureGroupShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupShow, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupUpdate(AzureGroupUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureGroupUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureGroupUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureGroupUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureGroupUpdateSettings.Remove"/></li>
        ///     <li><c>--set</c> via <see cref="AzureGroupUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureGroupUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupUpdate(Configure<AzureGroupUpdateSettings> configurator)
        {
            return AzureGroupUpdate(configurator(new AzureGroupUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureGroupUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureGroupUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureGroupUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureGroupUpdateSettings.Remove"/></li>
        ///     <li><c>--set</c> via <see cref="AzureGroupUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureGroupUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupUpdate(CombinatorialConfigure<AzureGroupUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupUpdate, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupWait(AzureGroupWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureGroupWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureGroupWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureGroupWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureGroupWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureGroupWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureGroupWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupWaitSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureGroupWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureGroupWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupWait(Configure<AzureGroupWaitSettings> configurator)
        {
            return AzureGroupWait(configurator(new AzureGroupWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureGroupWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureGroupWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureGroupWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureGroupWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureGroupWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureGroupWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupWaitSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureGroupWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureGroupWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupWait(CombinatorialConfigure<AzureGroupWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupWait, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentCreate(AzureGroupDeploymentCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupDeploymentCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentCreateSettings.Help"/></li>
        ///     <li><c>--mode</c> via <see cref="AzureGroupDeploymentCreateSettings.Mode"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureGroupDeploymentCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentCreateSettings.Output"/></li>
        ///     <li><c>--parameters</c> via <see cref="AzureGroupDeploymentCreateSettings.Parameters"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--rollback-on-error</c> via <see cref="AzureGroupDeploymentCreateSettings.RollbackOnError"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentCreateSettings.Subscription"/></li>
        ///     <li><c>--template-file</c> via <see cref="AzureGroupDeploymentCreateSettings.TemplateFile"/></li>
        ///     <li><c>--template-uri</c> via <see cref="AzureGroupDeploymentCreateSettings.TemplateUri"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentCreate(Configure<AzureGroupDeploymentCreateSettings> configurator)
        {
            return AzureGroupDeploymentCreate(configurator(new AzureGroupDeploymentCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentCreateSettings.Help"/></li>
        ///     <li><c>--mode</c> via <see cref="AzureGroupDeploymentCreateSettings.Mode"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureGroupDeploymentCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentCreateSettings.Output"/></li>
        ///     <li><c>--parameters</c> via <see cref="AzureGroupDeploymentCreateSettings.Parameters"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--rollback-on-error</c> via <see cref="AzureGroupDeploymentCreateSettings.RollbackOnError"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentCreateSettings.Subscription"/></li>
        ///     <li><c>--template-file</c> via <see cref="AzureGroupDeploymentCreateSettings.TemplateFile"/></li>
        ///     <li><c>--template-uri</c> via <see cref="AzureGroupDeploymentCreateSettings.TemplateUri"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupDeploymentCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupDeploymentCreate(CombinatorialConfigure<AzureGroupDeploymentCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupDeploymentCreate, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentDelete(AzureGroupDeploymentDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupDeploymentDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureGroupDeploymentDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentDelete(Configure<AzureGroupDeploymentDeleteSettings> configurator)
        {
            return AzureGroupDeploymentDelete(configurator(new AzureGroupDeploymentDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureGroupDeploymentDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupDeploymentDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupDeploymentDelete(CombinatorialConfigure<AzureGroupDeploymentDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupDeploymentDelete, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentExport(AzureGroupDeploymentExportSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupDeploymentExportSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentExportSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentExportSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentExportSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentExportSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentExportSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentExportSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentExportSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentExportSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentExport(Configure<AzureGroupDeploymentExportSettings> configurator)
        {
            return AzureGroupDeploymentExport(configurator(new AzureGroupDeploymentExportSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentExportSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentExportSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentExportSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentExportSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentExportSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentExportSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentExportSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentExportSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupDeploymentExportSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupDeploymentExport(CombinatorialConfigure<AzureGroupDeploymentExportSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupDeploymentExport, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentList(AzureGroupDeploymentListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupDeploymentListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentListSettings.Debug"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureGroupDeploymentListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureGroupDeploymentListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentList(Configure<AzureGroupDeploymentListSettings> configurator)
        {
            return AzureGroupDeploymentList(configurator(new AzureGroupDeploymentListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentListSettings.Debug"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureGroupDeploymentListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureGroupDeploymentListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupDeploymentListSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupDeploymentList(CombinatorialConfigure<AzureGroupDeploymentListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupDeploymentList, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentShow(AzureGroupDeploymentShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupDeploymentShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentShow(Configure<AzureGroupDeploymentShowSettings> configurator)
        {
            return AzureGroupDeploymentShow(configurator(new AzureGroupDeploymentShowSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupDeploymentShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupDeploymentShow(CombinatorialConfigure<AzureGroupDeploymentShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupDeploymentShow, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentValidate(AzureGroupDeploymentValidateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupDeploymentValidateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentValidateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentValidateSettings.Help"/></li>
        ///     <li><c>--mode</c> via <see cref="AzureGroupDeploymentValidateSettings.Mode"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentValidateSettings.Output"/></li>
        ///     <li><c>--parameters</c> via <see cref="AzureGroupDeploymentValidateSettings.Parameters"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentValidateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentValidateSettings.ResourceGroup"/></li>
        ///     <li><c>--rollback-on-error</c> via <see cref="AzureGroupDeploymentValidateSettings.RollbackOnError"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentValidateSettings.Subscription"/></li>
        ///     <li><c>--template-file</c> via <see cref="AzureGroupDeploymentValidateSettings.TemplateFile"/></li>
        ///     <li><c>--template-uri</c> via <see cref="AzureGroupDeploymentValidateSettings.TemplateUri"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentValidateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentValidate(Configure<AzureGroupDeploymentValidateSettings> configurator)
        {
            return AzureGroupDeploymentValidate(configurator(new AzureGroupDeploymentValidateSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentValidateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentValidateSettings.Help"/></li>
        ///     <li><c>--mode</c> via <see cref="AzureGroupDeploymentValidateSettings.Mode"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentValidateSettings.Output"/></li>
        ///     <li><c>--parameters</c> via <see cref="AzureGroupDeploymentValidateSettings.Parameters"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentValidateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentValidateSettings.ResourceGroup"/></li>
        ///     <li><c>--rollback-on-error</c> via <see cref="AzureGroupDeploymentValidateSettings.RollbackOnError"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentValidateSettings.Subscription"/></li>
        ///     <li><c>--template-file</c> via <see cref="AzureGroupDeploymentValidateSettings.TemplateFile"/></li>
        ///     <li><c>--template-uri</c> via <see cref="AzureGroupDeploymentValidateSettings.TemplateUri"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentValidateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupDeploymentValidateSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupDeploymentValidate(CombinatorialConfigure<AzureGroupDeploymentValidateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupDeploymentValidate, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentWait(AzureGroupDeploymentWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupDeploymentWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureGroupDeploymentWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureGroupDeploymentWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureGroupDeploymentWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureGroupDeploymentWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureGroupDeploymentWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureGroupDeploymentWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureGroupDeploymentWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentWait(Configure<AzureGroupDeploymentWaitSettings> configurator)
        {
            return AzureGroupDeploymentWait(configurator(new AzureGroupDeploymentWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureGroupDeploymentWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureGroupDeploymentWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureGroupDeploymentWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureGroupDeploymentWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureGroupDeploymentWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureGroupDeploymentWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureGroupDeploymentWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupDeploymentWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupDeploymentWait(CombinatorialConfigure<AzureGroupDeploymentWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupDeploymentWait, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupLockCreate(AzureGroupLockCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupLockCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupLockCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupLockCreateSettings.Help"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureGroupLockCreateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupLockCreateSettings.Name"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureGroupLockCreateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupLockCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupLockCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupLockCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupLockCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupLockCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupLockCreate(Configure<AzureGroupLockCreateSettings> configurator)
        {
            return AzureGroupLockCreate(configurator(new AzureGroupLockCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupLockCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupLockCreateSettings.Help"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureGroupLockCreateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupLockCreateSettings.Name"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureGroupLockCreateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupLockCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupLockCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupLockCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupLockCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupLockCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupLockCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupLockCreate(CombinatorialConfigure<AzureGroupLockCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupLockCreate, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupLockDelete(AzureGroupLockDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupLockDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupLockDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupLockDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureGroupLockDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupLockDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupLockDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupLockDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupLockDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupLockDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupLockDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupLockDelete(Configure<AzureGroupLockDeleteSettings> configurator)
        {
            return AzureGroupLockDelete(configurator(new AzureGroupLockDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupLockDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupLockDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureGroupLockDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupLockDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupLockDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupLockDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupLockDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupLockDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupLockDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupLockDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupLockDelete(CombinatorialConfigure<AzureGroupLockDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupLockDelete, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupLockList(AzureGroupLockListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupLockListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupLockListSettings.Debug"/></li>
        ///     <li><c>--filter-string</c> via <see cref="AzureGroupLockListSettings.FilterString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupLockListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupLockListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupLockListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupLockListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupLockListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupLockListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupLockList(Configure<AzureGroupLockListSettings> configurator)
        {
            return AzureGroupLockList(configurator(new AzureGroupLockListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupLockListSettings.Debug"/></li>
        ///     <li><c>--filter-string</c> via <see cref="AzureGroupLockListSettings.FilterString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupLockListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupLockListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupLockListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupLockListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupLockListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupLockListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupLockListSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupLockList(CombinatorialConfigure<AzureGroupLockListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupLockList, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupLockShow(AzureGroupLockShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupLockShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupLockShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupLockShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureGroupLockShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupLockShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupLockShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupLockShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupLockShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupLockShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupLockShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupLockShow(Configure<AzureGroupLockShowSettings> configurator)
        {
            return AzureGroupLockShow(configurator(new AzureGroupLockShowSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupLockShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupLockShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureGroupLockShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupLockShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupLockShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupLockShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupLockShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupLockShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupLockShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupLockShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupLockShow(CombinatorialConfigure<AzureGroupLockShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupLockShow, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupLockUpdate(AzureGroupLockUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupLockUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupLockUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupLockUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureGroupLockUpdateSettings.Ids"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureGroupLockUpdateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupLockUpdateSettings.Name"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureGroupLockUpdateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupLockUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupLockUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupLockUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupLockUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupLockUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupLockUpdate(Configure<AzureGroupLockUpdateSettings> configurator)
        {
            return AzureGroupLockUpdate(configurator(new AzureGroupLockUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupLockUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupLockUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureGroupLockUpdateSettings.Ids"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureGroupLockUpdateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupLockUpdateSettings.Name"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureGroupLockUpdateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupLockUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupLockUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupLockUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupLockUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupLockUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupLockUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupLockUpdate(CombinatorialConfigure<AzureGroupLockUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupLockUpdate, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentOperationList(AzureGroupDeploymentOperationListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupDeploymentOperationListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentOperationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentOperationListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentOperationListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentOperationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentOperationListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentOperationListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentOperationListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureGroupDeploymentOperationListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentOperationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentOperationList(Configure<AzureGroupDeploymentOperationListSettings> configurator)
        {
            return AzureGroupDeploymentOperationList(configurator(new AzureGroupDeploymentOperationListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentOperationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentOperationListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentOperationListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentOperationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentOperationListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentOperationListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentOperationListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureGroupDeploymentOperationListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentOperationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupDeploymentOperationListSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupDeploymentOperationList(CombinatorialConfigure<AzureGroupDeploymentOperationListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupDeploymentOperationList, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentOperationShow(AzureGroupDeploymentOperationShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureGroupDeploymentOperationShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Name"/></li>
        ///     <li><c>--operation-ids</c> via <see cref="AzureGroupDeploymentOperationShowSettings.OperationIds"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentOperationShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureGroupDeploymentOperationShow(Configure<AzureGroupDeploymentOperationShowSettings> configurator)
        {
            return AzureGroupDeploymentOperationShow(configurator(new AzureGroupDeploymentOperationShowSettings()));
        }
        /// <summary>
        ///   <p>Manage resource groups and template deployments.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/group?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Name"/></li>
        ///     <li><c>--operation-ids</c> via <see cref="AzureGroupDeploymentOperationShowSettings.OperationIds"/></li>
        ///     <li><c>--output</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureGroupDeploymentOperationShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureGroupDeploymentOperationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureGroupDeploymentOperationShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureGroupDeploymentOperationShow(CombinatorialConfigure<AzureGroupDeploymentOperationShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureGroupDeploymentOperationShow, AzureGroupLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureGroupCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Name of the new resource group.
        /// </summary>
        public virtual string Name { get; internal set; }
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
              .Add("group create")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
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
    #region AzureGroupDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
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
              .Add("group delete")
              .Add("--name {value}", Name)
              .Add("--no-wait", NoWait)
              .Add("--yes {value}", Yes)
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
    #region AzureGroupExistsSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupExistsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
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
              .Add("group exists")
              .Add("--name {value}", Name)
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
    #region AzureGroupExportSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupExportSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Export template with comments.
        /// </summary>
        public virtual string IncludeComments { get; internal set; }
        /// <summary>
        ///   Export template parameter with default value.
        /// </summary>
        public virtual string IncludeParameterDefaultValue { get; internal set; }
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
              .Add("group export")
              .Add("--name {value}", Name)
              .Add("--include-comments {value}", IncludeComments)
              .Add("--include-parameter-default-value {value}", IncludeParameterDefaultValue)
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
    #region AzureGroupListSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   A single tag in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tag { get; internal set; }
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
              .Add("group list")
              .Add("--tag {value}", Tag)
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
    #region AzureGroupShowSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
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
              .Add("group show")
              .Add("--name {value}", Name)
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
    #region AzureGroupUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
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
              .Add("group update")
              .Add("--name {value}", Name)
              .Add("--tags {value}", Tags)
              .Add("--add {value}", Add)
              .Add("--force-string {value}", ForceString)
              .Add("--remove {value}", Remove)
              .Add("--set {value}", Set)
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
    #region AzureGroupWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
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
              .Add("group wait")
              .Add("--name {value}", Name)
              .Add("--created {value}", Created)
              .Add("--custom {value}", Custom)
              .Add("--deleted {value}", Deleted)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--updated {value}", Updated)
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
    #region AzureGroupDeploymentCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupDeploymentCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Incremental (only add resources to resource group) or Complete (remove extra resources from resource group).
        /// </summary>
        public virtual GroupDeploymentMode Mode { get; internal set; }
        /// <summary>
        ///   The deployment name. Default to template file base name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Supply deployment parameter values.
        /// </summary>
        public virtual string Parameters { get; internal set; }
        /// <summary>
        ///   The name of a deployment to roll back to on error, or use as a flag to roll back to the last successful deployment.
        /// </summary>
        public virtual string RollbackOnError { get; internal set; }
        /// <summary>
        ///   A template file path in the file system.
        /// </summary>
        public virtual string TemplateFile { get; internal set; }
        /// <summary>
        ///   A uri to a remote template file.
        /// </summary>
        public virtual string TemplateUri { get; internal set; }
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
              .Add("group deployment create")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--mode {value}", Mode)
              .Add("--name {value}", Name)
              .Add("--no-wait", NoWait)
              .Add("--parameters {value}", Parameters)
              .Add("--rollback-on-error {value}", RollbackOnError)
              .Add("--template-file {value}", TemplateFile)
              .Add("--template-uri {value}", TemplateUri)
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
    #region AzureGroupDeploymentDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupDeploymentDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   The deployment name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
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
              .Add("group deployment delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
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
    #region AzureGroupDeploymentExportSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupDeploymentExportSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   The deployment name.
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
              .Add("group deployment export")
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
    #region AzureGroupDeploymentListSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupDeploymentListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The filter to apply on the operation. For example, you can use $filter=provisioningState eq '{state}'.
        /// </summary>
        public virtual string Filter { get; internal set; }
        /// <summary>
        ///   The number of results to get. If null is passed, returns all deployments.
        /// </summary>
        public virtual string Top { get; internal set; }
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
              .Add("group deployment list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--filter {value}", Filter)
              .Add("--top {value}", Top)
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
    #region AzureGroupDeploymentShowSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupDeploymentShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   The deployment name.
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
              .Add("group deployment show")
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
    #region AzureGroupDeploymentValidateSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupDeploymentValidateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Incremental (only add resources to resource group) or Complete (remove extra resources from resource group).
        /// </summary>
        public virtual GroupDeploymentMode Mode { get; internal set; }
        /// <summary>
        ///   Supply deployment parameter values.
        /// </summary>
        public virtual string Parameters { get; internal set; }
        /// <summary>
        ///   The name of a deployment to roll back to on error, or use as a flag to roll back to the last successful deployment.
        /// </summary>
        public virtual string RollbackOnError { get; internal set; }
        /// <summary>
        ///   A template file path in the file system.
        /// </summary>
        public virtual string TemplateFile { get; internal set; }
        /// <summary>
        ///   A uri to a remote template file.
        /// </summary>
        public virtual string TemplateUri { get; internal set; }
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
              .Add("group deployment validate")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--mode {value}", Mode)
              .Add("--parameters {value}", Parameters)
              .Add("--rollback-on-error {value}", RollbackOnError)
              .Add("--template-file {value}", TemplateFile)
              .Add("--template-uri {value}", TemplateUri)
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
    #region AzureGroupDeploymentWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupDeploymentWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   The deployment name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("group deployment wait")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--created {value}", Created)
              .Add("--custom {value}", Custom)
              .Add("--deleted {value}", Deleted)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--updated {value}", Updated)
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
    #region AzureGroupLockCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupLockCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   The type of lock restriction.
        /// </summary>
        public virtual GroupLockLockType LockType { get; internal set; }
        /// <summary>
        ///   Name of the lock.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Notes about this lock.
        /// </summary>
        public virtual string Notes { get; internal set; }
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
              .Add("group lock create")
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--notes {value}", Notes)
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
    #region AzureGroupLockDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupLockDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the lock.
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
              .Add("group lock delete")
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
    #region AzureGroupLockListSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupLockListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   A query filter to use to restrict the results.
        /// </summary>
        public virtual string FilterString { get; internal set; }
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
              .Add("group lock list")
              .Add("--filter-string {value}", FilterString)
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
    #region AzureGroupLockShowSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupLockShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the lock.
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
              .Add("group lock show")
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
    #region AzureGroupLockUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupLockUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The type of lock restriction.
        /// </summary>
        public virtual GroupLockLockType LockType { get; internal set; }
        /// <summary>
        ///   Name of the lock.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Notes about this lock.
        /// </summary>
        public virtual string Notes { get; internal set; }
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
              .Add("group lock update")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
              .Add("--notes {value}", Notes)
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
    #region AzureGroupDeploymentOperationListSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupDeploymentOperationListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   The deployment name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The number of results to return.
        /// </summary>
        public virtual string Top { get; internal set; }
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
              .Add("group deployment operation list")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--top {value}", Top)
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
    #region AzureGroupDeploymentOperationShowSettings
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureGroupDeploymentOperationShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureGroup executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureGroupTasks.AzureGroupPath;
        public override Action<OutputType, string> CustomLogger => AzureGroupTasks.AzureGroupLogger;
        /// <summary>
        ///   The deployment name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   A list of operation ids to show.
        /// </summary>
        public virtual string OperationIds { get; internal set; }
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
              .Add("group deployment operation show")
              .Add("--name {value}", Name)
              .Add("--operation-ids {value}", OperationIds)
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
    #region AzureGroupCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupCreateSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings SetLocation(this AzureGroupCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings ResetLocation(this AzureGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupCreateSettings.Name"/></em></p>
        ///   <p>Name of the new resource group.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings SetName(this AzureGroupCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupCreateSettings.Name"/></em></p>
        ///   <p>Name of the new resource group.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings ResetName(this AzureGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings SetTags(this AzureGroupCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings ResetTags(this AzureGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings SetSubscription(this AzureGroupCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings ResetSubscription(this AzureGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings SetDebug(this AzureGroupCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings ResetDebug(this AzureGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings SetHelp(this AzureGroupCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings ResetHelp(this AzureGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings SetOutput(this AzureGroupCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings ResetOutput(this AzureGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings SetQuery(this AzureGroupCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings ResetQuery(this AzureGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings SetVerbose(this AzureGroupCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupCreateSettings ResetVerbose(this AzureGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeleteSettings.Name"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings SetName(this AzureGroupDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeleteSettings.Name"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings ResetName(this AzureGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings SetNoWait(this AzureGroupDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings ResetNoWait(this AzureGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureGroupDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings EnableNoWait(this AzureGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureGroupDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings DisableNoWait(this AzureGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureGroupDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings ToggleNoWait(this AzureGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings SetYes(this AzureGroupDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings ResetYes(this AzureGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings SetSubscription(this AzureGroupDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings ResetSubscription(this AzureGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings SetDebug(this AzureGroupDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings ResetDebug(this AzureGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings SetHelp(this AzureGroupDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings ResetHelp(this AzureGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings SetOutput(this AzureGroupDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings ResetOutput(this AzureGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings SetQuery(this AzureGroupDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings ResetQuery(this AzureGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings SetVerbose(this AzureGroupDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeleteSettings ResetVerbose(this AzureGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupExistsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupExistsSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExistsSettings.Name"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings SetName(this AzureGroupExistsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExistsSettings.Name"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings ResetName(this AzureGroupExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExistsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings SetSubscription(this AzureGroupExistsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExistsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings ResetSubscription(this AzureGroupExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExistsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings SetDebug(this AzureGroupExistsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExistsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings ResetDebug(this AzureGroupExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExistsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings SetHelp(this AzureGroupExistsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExistsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings ResetHelp(this AzureGroupExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExistsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings SetOutput(this AzureGroupExistsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExistsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings ResetOutput(this AzureGroupExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExistsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings SetQuery(this AzureGroupExistsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExistsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings ResetQuery(this AzureGroupExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExistsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings SetVerbose(this AzureGroupExistsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExistsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExistsSettings ResetVerbose(this AzureGroupExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupExportSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupExportSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExportSettings.Name"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings SetName(this AzureGroupExportSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExportSettings.Name"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings ResetName(this AzureGroupExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region IncludeComments
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExportSettings.IncludeComments"/></em></p>
        ///   <p>Export template with comments.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings SetIncludeComments(this AzureGroupExportSettings toolSettings, string includeComments)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeComments = includeComments;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExportSettings.IncludeComments"/></em></p>
        ///   <p>Export template with comments.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings ResetIncludeComments(this AzureGroupExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeComments = null;
            return toolSettings;
        }
        #endregion
        #region IncludeParameterDefaultValue
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExportSettings.IncludeParameterDefaultValue"/></em></p>
        ///   <p>Export template parameter with default value.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings SetIncludeParameterDefaultValue(this AzureGroupExportSettings toolSettings, string includeParameterDefaultValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeParameterDefaultValue = includeParameterDefaultValue;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExportSettings.IncludeParameterDefaultValue"/></em></p>
        ///   <p>Export template parameter with default value.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings ResetIncludeParameterDefaultValue(this AzureGroupExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeParameterDefaultValue = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExportSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings SetSubscription(this AzureGroupExportSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExportSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings ResetSubscription(this AzureGroupExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExportSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings SetDebug(this AzureGroupExportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExportSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings ResetDebug(this AzureGroupExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExportSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings SetHelp(this AzureGroupExportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExportSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings ResetHelp(this AzureGroupExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExportSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings SetOutput(this AzureGroupExportSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExportSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings ResetOutput(this AzureGroupExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExportSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings SetQuery(this AzureGroupExportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExportSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings ResetQuery(this AzureGroupExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupExportSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings SetVerbose(this AzureGroupExportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupExportSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupExportSettings ResetVerbose(this AzureGroupExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupListSettingsExtensions
    {
        #region Tag
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupListSettings.Tag"/></em></p>
        ///   <p>A single tag in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings SetTag(this AzureGroupListSettings toolSettings, string tag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tag = tag;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupListSettings.Tag"/></em></p>
        ///   <p>A single tag in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings ResetTag(this AzureGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tag = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings SetSubscription(this AzureGroupListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings ResetSubscription(this AzureGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings SetDebug(this AzureGroupListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings ResetDebug(this AzureGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings SetHelp(this AzureGroupListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings ResetHelp(this AzureGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings SetOutput(this AzureGroupListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings ResetOutput(this AzureGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings SetQuery(this AzureGroupListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings ResetQuery(this AzureGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings SetVerbose(this AzureGroupListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupListSettings ResetVerbose(this AzureGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupShowSettings.Name"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings SetName(this AzureGroupShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupShowSettings.Name"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings ResetName(this AzureGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings SetSubscription(this AzureGroupShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings ResetSubscription(this AzureGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings SetDebug(this AzureGroupShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings ResetDebug(this AzureGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings SetHelp(this AzureGroupShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings ResetHelp(this AzureGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings SetOutput(this AzureGroupShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings ResetOutput(this AzureGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings SetQuery(this AzureGroupShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings ResetQuery(this AzureGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings SetVerbose(this AzureGroupShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupShowSettings ResetVerbose(this AzureGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupUpdateSettings.Name"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings SetName(this AzureGroupUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupUpdateSettings.Name"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings ResetName(this AzureGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings SetTags(this AzureGroupUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings ResetTags(this AzureGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings SetAdd(this AzureGroupUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings ResetAdd(this AzureGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings SetForceString(this AzureGroupUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings ResetForceString(this AzureGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings SetRemove(this AzureGroupUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings ResetRemove(this AzureGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings SetSet(this AzureGroupUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings ResetSet(this AzureGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings SetSubscription(this AzureGroupUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings ResetSubscription(this AzureGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings SetDebug(this AzureGroupUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings ResetDebug(this AzureGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings SetHelp(this AzureGroupUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings ResetHelp(this AzureGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings SetOutput(this AzureGroupUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings ResetOutput(this AzureGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings SetQuery(this AzureGroupUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings ResetQuery(this AzureGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings SetVerbose(this AzureGroupUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupUpdateSettings ResetVerbose(this AzureGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupWaitSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Name"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetName(this AzureGroupWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Name"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetName(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetCreated(this AzureGroupWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetCreated(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetCustom(this AzureGroupWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetCustom(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetDeleted(this AzureGroupWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetDeleted(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetExists(this AzureGroupWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetExists(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetInterval(this AzureGroupWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetInterval(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetTimeout(this AzureGroupWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetTimeout(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetUpdated(this AzureGroupWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetUpdated(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetSubscription(this AzureGroupWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetSubscription(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetDebug(this AzureGroupWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetDebug(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetHelp(this AzureGroupWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetHelp(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetOutput(this AzureGroupWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetOutput(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetQuery(this AzureGroupWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetQuery(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings SetVerbose(this AzureGroupWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupWaitSettings ResetVerbose(this AzureGroupWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupDeploymentCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupDeploymentCreateSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetResourceGroup(this AzureGroupDeploymentCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetResourceGroup(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Mode
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.Mode"/></em></p>
        ///   <p>Incremental (only add resources to resource group) or Complete (remove extra resources from resource group).</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetMode(this AzureGroupDeploymentCreateSettings toolSettings, GroupDeploymentMode mode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = mode;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.Mode"/></em></p>
        ///   <p>Incremental (only add resources to resource group) or Complete (remove extra resources from resource group).</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetMode(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.Name"/></em></p>
        ///   <p>The deployment name. Default to template file base name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetName(this AzureGroupDeploymentCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.Name"/></em></p>
        ///   <p>The deployment name. Default to template file base name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetName(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetNoWait(this AzureGroupDeploymentCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetNoWait(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureGroupDeploymentCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings EnableNoWait(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureGroupDeploymentCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings DisableNoWait(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureGroupDeploymentCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ToggleNoWait(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Parameters
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.Parameters"/></em></p>
        ///   <p>Supply deployment parameter values.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetParameters(this AzureGroupDeploymentCreateSettings toolSettings, string parameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = parameters;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.Parameters"/></em></p>
        ///   <p>Supply deployment parameter values.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetParameters(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = null;
            return toolSettings;
        }
        #endregion
        #region RollbackOnError
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.RollbackOnError"/></em></p>
        ///   <p>The name of a deployment to roll back to on error, or use as a flag to roll back to the last successful deployment.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetRollbackOnError(this AzureGroupDeploymentCreateSettings toolSettings, string rollbackOnError)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RollbackOnError = rollbackOnError;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.RollbackOnError"/></em></p>
        ///   <p>The name of a deployment to roll back to on error, or use as a flag to roll back to the last successful deployment.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetRollbackOnError(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RollbackOnError = null;
            return toolSettings;
        }
        #endregion
        #region TemplateFile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.TemplateFile"/></em></p>
        ///   <p>A template file path in the file system.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetTemplateFile(this AzureGroupDeploymentCreateSettings toolSettings, string templateFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateFile = templateFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.TemplateFile"/></em></p>
        ///   <p>A template file path in the file system.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetTemplateFile(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateFile = null;
            return toolSettings;
        }
        #endregion
        #region TemplateUri
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.TemplateUri"/></em></p>
        ///   <p>A uri to a remote template file.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetTemplateUri(this AzureGroupDeploymentCreateSettings toolSettings, string templateUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateUri = templateUri;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.TemplateUri"/></em></p>
        ///   <p>A uri to a remote template file.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetTemplateUri(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateUri = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetSubscription(this AzureGroupDeploymentCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetSubscription(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetDebug(this AzureGroupDeploymentCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetDebug(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetHelp(this AzureGroupDeploymentCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetHelp(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetOutput(this AzureGroupDeploymentCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetOutput(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetQuery(this AzureGroupDeploymentCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetQuery(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings SetVerbose(this AzureGroupDeploymentCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentCreateSettings ResetVerbose(this AzureGroupDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupDeploymentDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupDeploymentDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentDeleteSettings.Name"/></em></p>
        ///   <p>The deployment name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings SetName(this AzureGroupDeploymentDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentDeleteSettings.Name"/></em></p>
        ///   <p>The deployment name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings ResetName(this AzureGroupDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings SetResourceGroup(this AzureGroupDeploymentDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings ResetResourceGroup(this AzureGroupDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings SetNoWait(this AzureGroupDeploymentDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings ResetNoWait(this AzureGroupDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureGroupDeploymentDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings EnableNoWait(this AzureGroupDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureGroupDeploymentDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings DisableNoWait(this AzureGroupDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureGroupDeploymentDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings ToggleNoWait(this AzureGroupDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings SetSubscription(this AzureGroupDeploymentDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings ResetSubscription(this AzureGroupDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings SetDebug(this AzureGroupDeploymentDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings ResetDebug(this AzureGroupDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings SetHelp(this AzureGroupDeploymentDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings ResetHelp(this AzureGroupDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings SetOutput(this AzureGroupDeploymentDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings ResetOutput(this AzureGroupDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings SetQuery(this AzureGroupDeploymentDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings ResetQuery(this AzureGroupDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings SetVerbose(this AzureGroupDeploymentDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentDeleteSettings ResetVerbose(this AzureGroupDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupDeploymentExportSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupDeploymentExportSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentExportSettings.Name"/></em></p>
        ///   <p>The deployment name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings SetName(this AzureGroupDeploymentExportSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentExportSettings.Name"/></em></p>
        ///   <p>The deployment name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings ResetName(this AzureGroupDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentExportSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings SetResourceGroup(this AzureGroupDeploymentExportSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentExportSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings ResetResourceGroup(this AzureGroupDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentExportSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings SetSubscription(this AzureGroupDeploymentExportSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentExportSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings ResetSubscription(this AzureGroupDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentExportSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings SetDebug(this AzureGroupDeploymentExportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentExportSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings ResetDebug(this AzureGroupDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentExportSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings SetHelp(this AzureGroupDeploymentExportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentExportSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings ResetHelp(this AzureGroupDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentExportSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings SetOutput(this AzureGroupDeploymentExportSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentExportSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings ResetOutput(this AzureGroupDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentExportSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings SetQuery(this AzureGroupDeploymentExportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentExportSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings ResetQuery(this AzureGroupDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentExportSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings SetVerbose(this AzureGroupDeploymentExportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentExportSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentExportSettings ResetVerbose(this AzureGroupDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupDeploymentListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupDeploymentListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings SetResourceGroup(this AzureGroupDeploymentListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings ResetResourceGroup(this AzureGroupDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentListSettings.Filter"/></em></p>
        ///   <p>The filter to apply on the operation. For example, you can use $filter=provisioningState eq '{state}'.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings SetFilter(this AzureGroupDeploymentListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentListSettings.Filter"/></em></p>
        ///   <p>The filter to apply on the operation. For example, you can use $filter=provisioningState eq '{state}'.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings ResetFilter(this AzureGroupDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentListSettings.Top"/></em></p>
        ///   <p>The number of results to get. If null is passed, returns all deployments.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings SetTop(this AzureGroupDeploymentListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentListSettings.Top"/></em></p>
        ///   <p>The number of results to get. If null is passed, returns all deployments.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings ResetTop(this AzureGroupDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings SetSubscription(this AzureGroupDeploymentListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings ResetSubscription(this AzureGroupDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings SetDebug(this AzureGroupDeploymentListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings ResetDebug(this AzureGroupDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings SetHelp(this AzureGroupDeploymentListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings ResetHelp(this AzureGroupDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings SetOutput(this AzureGroupDeploymentListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings ResetOutput(this AzureGroupDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings SetQuery(this AzureGroupDeploymentListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings ResetQuery(this AzureGroupDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings SetVerbose(this AzureGroupDeploymentListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentListSettings ResetVerbose(this AzureGroupDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupDeploymentShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupDeploymentShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentShowSettings.Name"/></em></p>
        ///   <p>The deployment name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings SetName(this AzureGroupDeploymentShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentShowSettings.Name"/></em></p>
        ///   <p>The deployment name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings ResetName(this AzureGroupDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings SetResourceGroup(this AzureGroupDeploymentShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings ResetResourceGroup(this AzureGroupDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings SetSubscription(this AzureGroupDeploymentShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings ResetSubscription(this AzureGroupDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings SetDebug(this AzureGroupDeploymentShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings ResetDebug(this AzureGroupDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings SetHelp(this AzureGroupDeploymentShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings ResetHelp(this AzureGroupDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings SetOutput(this AzureGroupDeploymentShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings ResetOutput(this AzureGroupDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings SetQuery(this AzureGroupDeploymentShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings ResetQuery(this AzureGroupDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings SetVerbose(this AzureGroupDeploymentShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentShowSettings ResetVerbose(this AzureGroupDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupDeploymentValidateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupDeploymentValidateSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentValidateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings SetResourceGroup(this AzureGroupDeploymentValidateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentValidateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings ResetResourceGroup(this AzureGroupDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Mode
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentValidateSettings.Mode"/></em></p>
        ///   <p>Incremental (only add resources to resource group) or Complete (remove extra resources from resource group).</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings SetMode(this AzureGroupDeploymentValidateSettings toolSettings, GroupDeploymentMode mode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = mode;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentValidateSettings.Mode"/></em></p>
        ///   <p>Incremental (only add resources to resource group) or Complete (remove extra resources from resource group).</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings ResetMode(this AzureGroupDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = null;
            return toolSettings;
        }
        #endregion
        #region Parameters
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentValidateSettings.Parameters"/></em></p>
        ///   <p>Supply deployment parameter values.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings SetParameters(this AzureGroupDeploymentValidateSettings toolSettings, string parameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = parameters;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentValidateSettings.Parameters"/></em></p>
        ///   <p>Supply deployment parameter values.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings ResetParameters(this AzureGroupDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = null;
            return toolSettings;
        }
        #endregion
        #region RollbackOnError
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentValidateSettings.RollbackOnError"/></em></p>
        ///   <p>The name of a deployment to roll back to on error, or use as a flag to roll back to the last successful deployment.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings SetRollbackOnError(this AzureGroupDeploymentValidateSettings toolSettings, string rollbackOnError)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RollbackOnError = rollbackOnError;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentValidateSettings.RollbackOnError"/></em></p>
        ///   <p>The name of a deployment to roll back to on error, or use as a flag to roll back to the last successful deployment.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings ResetRollbackOnError(this AzureGroupDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RollbackOnError = null;
            return toolSettings;
        }
        #endregion
        #region TemplateFile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentValidateSettings.TemplateFile"/></em></p>
        ///   <p>A template file path in the file system.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings SetTemplateFile(this AzureGroupDeploymentValidateSettings toolSettings, string templateFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateFile = templateFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentValidateSettings.TemplateFile"/></em></p>
        ///   <p>A template file path in the file system.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings ResetTemplateFile(this AzureGroupDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateFile = null;
            return toolSettings;
        }
        #endregion
        #region TemplateUri
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentValidateSettings.TemplateUri"/></em></p>
        ///   <p>A uri to a remote template file.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings SetTemplateUri(this AzureGroupDeploymentValidateSettings toolSettings, string templateUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateUri = templateUri;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentValidateSettings.TemplateUri"/></em></p>
        ///   <p>A uri to a remote template file.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings ResetTemplateUri(this AzureGroupDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateUri = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentValidateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings SetSubscription(this AzureGroupDeploymentValidateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentValidateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings ResetSubscription(this AzureGroupDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentValidateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings SetDebug(this AzureGroupDeploymentValidateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentValidateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings ResetDebug(this AzureGroupDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentValidateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings SetHelp(this AzureGroupDeploymentValidateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentValidateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings ResetHelp(this AzureGroupDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentValidateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings SetOutput(this AzureGroupDeploymentValidateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentValidateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings ResetOutput(this AzureGroupDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentValidateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings SetQuery(this AzureGroupDeploymentValidateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentValidateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings ResetQuery(this AzureGroupDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentValidateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings SetVerbose(this AzureGroupDeploymentValidateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentValidateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentValidateSettings ResetVerbose(this AzureGroupDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupDeploymentWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupDeploymentWaitSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Name"/></em></p>
        ///   <p>The deployment name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetName(this AzureGroupDeploymentWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Name"/></em></p>
        ///   <p>The deployment name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetName(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetResourceGroup(this AzureGroupDeploymentWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetResourceGroup(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetCreated(this AzureGroupDeploymentWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetCreated(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetCustom(this AzureGroupDeploymentWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetCustom(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetDeleted(this AzureGroupDeploymentWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetDeleted(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetExists(this AzureGroupDeploymentWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetExists(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetInterval(this AzureGroupDeploymentWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetInterval(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetTimeout(this AzureGroupDeploymentWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetTimeout(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetUpdated(this AzureGroupDeploymentWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetUpdated(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetSubscription(this AzureGroupDeploymentWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetSubscription(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetDebug(this AzureGroupDeploymentWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetDebug(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetHelp(this AzureGroupDeploymentWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetHelp(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetOutput(this AzureGroupDeploymentWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetOutput(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetQuery(this AzureGroupDeploymentWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetQuery(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings SetVerbose(this AzureGroupDeploymentWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentWaitSettings ResetVerbose(this AzureGroupDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupLockCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupLockCreateSettingsExtensions
    {
        #region LockType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockCreateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings SetLockType(this AzureGroupLockCreateSettings toolSettings, GroupLockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockCreateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings ResetLockType(this AzureGroupLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockCreateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings SetName(this AzureGroupLockCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockCreateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings ResetName(this AzureGroupLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings SetResourceGroup(this AzureGroupLockCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings ResetResourceGroup(this AzureGroupLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockCreateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings SetNotes(this AzureGroupLockCreateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockCreateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings ResetNotes(this AzureGroupLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings SetSubscription(this AzureGroupLockCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings ResetSubscription(this AzureGroupLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings SetDebug(this AzureGroupLockCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings ResetDebug(this AzureGroupLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings SetHelp(this AzureGroupLockCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings ResetHelp(this AzureGroupLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings SetOutput(this AzureGroupLockCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings ResetOutput(this AzureGroupLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings SetQuery(this AzureGroupLockCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings ResetQuery(this AzureGroupLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings SetVerbose(this AzureGroupLockCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockCreateSettings ResetVerbose(this AzureGroupLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupLockDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupLockDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings SetIds(this AzureGroupLockDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings SetIds(this AzureGroupLockDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureGroupLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings AddIds(this AzureGroupLockDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureGroupLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings AddIds(this AzureGroupLockDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureGroupLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings ClearIds(this AzureGroupLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureGroupLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings RemoveIds(this AzureGroupLockDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureGroupLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings RemoveIds(this AzureGroupLockDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockDeleteSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings SetName(this AzureGroupLockDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockDeleteSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings ResetName(this AzureGroupLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings SetResourceGroup(this AzureGroupLockDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings ResetResourceGroup(this AzureGroupLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings SetSubscription(this AzureGroupLockDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings ResetSubscription(this AzureGroupLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings SetDebug(this AzureGroupLockDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings ResetDebug(this AzureGroupLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings SetHelp(this AzureGroupLockDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings ResetHelp(this AzureGroupLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings SetOutput(this AzureGroupLockDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings ResetOutput(this AzureGroupLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings SetQuery(this AzureGroupLockDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings ResetQuery(this AzureGroupLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings SetVerbose(this AzureGroupLockDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockDeleteSettings ResetVerbose(this AzureGroupLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupLockListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupLockListSettingsExtensions
    {
        #region FilterString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockListSettings.FilterString"/></em></p>
        ///   <p>A query filter to use to restrict the results.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings SetFilterString(this AzureGroupLockListSettings toolSettings, string filterString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = filterString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockListSettings.FilterString"/></em></p>
        ///   <p>A query filter to use to restrict the results.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings ResetFilterString(this AzureGroupLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings SetResourceGroup(this AzureGroupLockListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings ResetResourceGroup(this AzureGroupLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings SetSubscription(this AzureGroupLockListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings ResetSubscription(this AzureGroupLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings SetDebug(this AzureGroupLockListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings ResetDebug(this AzureGroupLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings SetHelp(this AzureGroupLockListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings ResetHelp(this AzureGroupLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings SetOutput(this AzureGroupLockListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings ResetOutput(this AzureGroupLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings SetQuery(this AzureGroupLockListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings ResetQuery(this AzureGroupLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings SetVerbose(this AzureGroupLockListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockListSettings ResetVerbose(this AzureGroupLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupLockShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupLockShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings SetIds(this AzureGroupLockShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings SetIds(this AzureGroupLockShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureGroupLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings AddIds(this AzureGroupLockShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureGroupLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings AddIds(this AzureGroupLockShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureGroupLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings ClearIds(this AzureGroupLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureGroupLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings RemoveIds(this AzureGroupLockShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureGroupLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings RemoveIds(this AzureGroupLockShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockShowSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings SetName(this AzureGroupLockShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockShowSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings ResetName(this AzureGroupLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings SetResourceGroup(this AzureGroupLockShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings ResetResourceGroup(this AzureGroupLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings SetSubscription(this AzureGroupLockShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings ResetSubscription(this AzureGroupLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings SetDebug(this AzureGroupLockShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings ResetDebug(this AzureGroupLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings SetHelp(this AzureGroupLockShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings ResetHelp(this AzureGroupLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings SetOutput(this AzureGroupLockShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings ResetOutput(this AzureGroupLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings SetQuery(this AzureGroupLockShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings ResetQuery(this AzureGroupLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings SetVerbose(this AzureGroupLockShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockShowSettings ResetVerbose(this AzureGroupLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupLockUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupLockUpdateSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings SetIds(this AzureGroupLockUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings SetIds(this AzureGroupLockUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureGroupLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings AddIds(this AzureGroupLockUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureGroupLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings AddIds(this AzureGroupLockUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureGroupLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings ClearIds(this AzureGroupLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureGroupLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings RemoveIds(this AzureGroupLockUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureGroupLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings RemoveIds(this AzureGroupLockUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region LockType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockUpdateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings SetLockType(this AzureGroupLockUpdateSettings toolSettings, GroupLockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockUpdateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings ResetLockType(this AzureGroupLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockUpdateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings SetName(this AzureGroupLockUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockUpdateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings ResetName(this AzureGroupLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockUpdateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings SetNotes(this AzureGroupLockUpdateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockUpdateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings ResetNotes(this AzureGroupLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings SetResourceGroup(this AzureGroupLockUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings ResetResourceGroup(this AzureGroupLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings SetSubscription(this AzureGroupLockUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings ResetSubscription(this AzureGroupLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings SetDebug(this AzureGroupLockUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings ResetDebug(this AzureGroupLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings SetHelp(this AzureGroupLockUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings ResetHelp(this AzureGroupLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings SetOutput(this AzureGroupLockUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings ResetOutput(this AzureGroupLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings SetQuery(this AzureGroupLockUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings ResetQuery(this AzureGroupLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupLockUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings SetVerbose(this AzureGroupLockUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupLockUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupLockUpdateSettings ResetVerbose(this AzureGroupLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupDeploymentOperationListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupDeploymentOperationListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationListSettings.Name"/></em></p>
        ///   <p>The deployment name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings SetName(this AzureGroupDeploymentOperationListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationListSettings.Name"/></em></p>
        ///   <p>The deployment name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings ResetName(this AzureGroupDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings SetResourceGroup(this AzureGroupDeploymentOperationListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings ResetResourceGroup(this AzureGroupDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationListSettings.Top"/></em></p>
        ///   <p>The number of results to return.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings SetTop(this AzureGroupDeploymentOperationListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationListSettings.Top"/></em></p>
        ///   <p>The number of results to return.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings ResetTop(this AzureGroupDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings SetSubscription(this AzureGroupDeploymentOperationListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings ResetSubscription(this AzureGroupDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings SetDebug(this AzureGroupDeploymentOperationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings ResetDebug(this AzureGroupDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings SetHelp(this AzureGroupDeploymentOperationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings ResetHelp(this AzureGroupDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings SetOutput(this AzureGroupDeploymentOperationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings ResetOutput(this AzureGroupDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings SetQuery(this AzureGroupDeploymentOperationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings ResetQuery(this AzureGroupDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings SetVerbose(this AzureGroupDeploymentOperationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationListSettings ResetVerbose(this AzureGroupDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureGroupDeploymentOperationShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureGroupDeploymentOperationShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationShowSettings.Name"/></em></p>
        ///   <p>The deployment name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings SetName(this AzureGroupDeploymentOperationShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationShowSettings.Name"/></em></p>
        ///   <p>The deployment name.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings ResetName(this AzureGroupDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region OperationIds
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationShowSettings.OperationIds"/></em></p>
        ///   <p>A list of operation ids to show.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings SetOperationIds(this AzureGroupDeploymentOperationShowSettings toolSettings, string operationIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OperationIds = operationIds;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationShowSettings.OperationIds"/></em></p>
        ///   <p>A list of operation ids to show.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings ResetOperationIds(this AzureGroupDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OperationIds = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings SetResourceGroup(this AzureGroupDeploymentOperationShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings ResetResourceGroup(this AzureGroupDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings SetSubscription(this AzureGroupDeploymentOperationShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings ResetSubscription(this AzureGroupDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings SetDebug(this AzureGroupDeploymentOperationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings ResetDebug(this AzureGroupDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings SetHelp(this AzureGroupDeploymentOperationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings ResetHelp(this AzureGroupDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings SetOutput(this AzureGroupDeploymentOperationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings ResetOutput(this AzureGroupDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings SetQuery(this AzureGroupDeploymentOperationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings ResetQuery(this AzureGroupDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureGroupDeploymentOperationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings SetVerbose(this AzureGroupDeploymentOperationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureGroupDeploymentOperationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureGroupDeploymentOperationShowSettings ResetVerbose(this AzureGroupDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region GroupDeploymentMode
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<GroupDeploymentMode>))]
    public partial class GroupDeploymentMode : Enumeration
    {
        public static GroupDeploymentMode complete = new GroupDeploymentMode { Value = "complete" };
        public static GroupDeploymentMode incremental = new GroupDeploymentMode { Value = "incremental" };
    }
    #endregion
    #region GroupLockLockType
    /// <summary>
    ///   Used within <see cref="AzureGroupTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<GroupLockLockType>))]
    public partial class GroupLockLockType : Enumeration
    {
        public static GroupLockLockType cannotdelete = new GroupLockLockType { Value = "cannotdelete" };
        public static GroupLockLockType readonly_ = new GroupLockLockType { Value = "readonly" };
    }
    #endregion
}
