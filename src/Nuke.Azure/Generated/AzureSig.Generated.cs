// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureSig.json
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
    public static partial class AzureSigTasks
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public static string AzureSigPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURESIG_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureSigLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage shared image gallery.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSig(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureSigPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureSigLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigCreate(AzureSigCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigCreateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzureSigCreateSettings.Description"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigCreateSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSigCreateSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureSigCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigCreate(Configure<AzureSigCreateSettings> configurator)
        {
            return AzureSigCreate(configurator(new AzureSigCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigCreateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzureSigCreateSettings.Description"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigCreateSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSigCreateSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureSigCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigCreate(CombinatorialConfigure<AzureSigCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigCreate, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigDelete(AzureSigDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigDeleteSettings.Debug"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigDeleteSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigDelete(Configure<AzureSigDeleteSettings> configurator)
        {
            return AzureSigDelete(configurator(new AzureSigDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigDeleteSettings.Debug"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigDeleteSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigDelete(CombinatorialConfigure<AzureSigDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigDelete, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigList(AzureSigListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigList(Configure<AzureSigListSettings> configurator)
        {
            return AzureSigList(configurator(new AzureSigListSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigList(CombinatorialConfigure<AzureSigListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigList, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigShow(AzureSigShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigShowSettings.Debug"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigShowSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSigShowSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigShow(Configure<AzureSigShowSettings> configurator)
        {
            return AzureSigShow(configurator(new AzureSigShowSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigShowSettings.Debug"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigShowSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSigShowSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigShow(CombinatorialConfigure<AzureSigShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigShow, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigUpdate(AzureSigUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureSigUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSigUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureSigUpdateSettings.ForceString"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigUpdateSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigUpdateSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureSigUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureSigUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigUpdate(Configure<AzureSigUpdateSettings> configurator)
        {
            return AzureSigUpdate(configurator(new AzureSigUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureSigUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSigUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureSigUpdateSettings.ForceString"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigUpdateSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigUpdateSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureSigUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureSigUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigUpdate(CombinatorialConfigure<AzureSigUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigUpdate, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigImageDefinitionCreate(AzureSigImageDefinitionCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigImageDefinitionCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageDefinitionCreateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzureSigImageDefinitionCreateSettings.Description"/></li>
        ///     <li><c>--disallowed-disk-types</c> via <see cref="AzureSigImageDefinitionCreateSettings.DisallowedDiskTypes"/></li>
        ///     <li><c>--end-of-life-date</c> via <see cref="AzureSigImageDefinitionCreateSettings.EndOfLifeDate"/></li>
        ///     <li><c>--eula</c> via <see cref="AzureSigImageDefinitionCreateSettings.Eula"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageDefinitionCreateSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageDefinitionCreateSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageDefinitionCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSigImageDefinitionCreateSettings.Location"/></li>
        ///     <li><c>--maximum-cpu-core</c> via <see cref="AzureSigImageDefinitionCreateSettings.MaximumCpuCore"/></li>
        ///     <li><c>--maximum-memory</c> via <see cref="AzureSigImageDefinitionCreateSettings.MaximumMemory"/></li>
        ///     <li><c>--minimum-cpu-core</c> via <see cref="AzureSigImageDefinitionCreateSettings.MinimumCpuCore"/></li>
        ///     <li><c>--minimum-memory</c> via <see cref="AzureSigImageDefinitionCreateSettings.MinimumMemory"/></li>
        ///     <li><c>--offer</c> via <see cref="AzureSigImageDefinitionCreateSettings.Offer"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureSigImageDefinitionCreateSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageDefinitionCreateSettings.Output"/></li>
        ///     <li><c>--plan-name</c> via <see cref="AzureSigImageDefinitionCreateSettings.PlanName"/></li>
        ///     <li><c>--plan-product</c> via <see cref="AzureSigImageDefinitionCreateSettings.PlanProduct"/></li>
        ///     <li><c>--plan-publisher</c> via <see cref="AzureSigImageDefinitionCreateSettings.PlanPublisher"/></li>
        ///     <li><c>--privacy-statement-uri</c> via <see cref="AzureSigImageDefinitionCreateSettings.PrivacyStatementUri"/></li>
        ///     <li><c>--publisher</c> via <see cref="AzureSigImageDefinitionCreateSettings.Publisher"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageDefinitionCreateSettings.Query"/></li>
        ///     <li><c>--release-note-uri</c> via <see cref="AzureSigImageDefinitionCreateSettings.ReleaseNoteUri"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageDefinitionCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureSigImageDefinitionCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageDefinitionCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureSigImageDefinitionCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageDefinitionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigImageDefinitionCreate(Configure<AzureSigImageDefinitionCreateSettings> configurator)
        {
            return AzureSigImageDefinitionCreate(configurator(new AzureSigImageDefinitionCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageDefinitionCreateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzureSigImageDefinitionCreateSettings.Description"/></li>
        ///     <li><c>--disallowed-disk-types</c> via <see cref="AzureSigImageDefinitionCreateSettings.DisallowedDiskTypes"/></li>
        ///     <li><c>--end-of-life-date</c> via <see cref="AzureSigImageDefinitionCreateSettings.EndOfLifeDate"/></li>
        ///     <li><c>--eula</c> via <see cref="AzureSigImageDefinitionCreateSettings.Eula"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageDefinitionCreateSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageDefinitionCreateSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageDefinitionCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSigImageDefinitionCreateSettings.Location"/></li>
        ///     <li><c>--maximum-cpu-core</c> via <see cref="AzureSigImageDefinitionCreateSettings.MaximumCpuCore"/></li>
        ///     <li><c>--maximum-memory</c> via <see cref="AzureSigImageDefinitionCreateSettings.MaximumMemory"/></li>
        ///     <li><c>--minimum-cpu-core</c> via <see cref="AzureSigImageDefinitionCreateSettings.MinimumCpuCore"/></li>
        ///     <li><c>--minimum-memory</c> via <see cref="AzureSigImageDefinitionCreateSettings.MinimumMemory"/></li>
        ///     <li><c>--offer</c> via <see cref="AzureSigImageDefinitionCreateSettings.Offer"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureSigImageDefinitionCreateSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageDefinitionCreateSettings.Output"/></li>
        ///     <li><c>--plan-name</c> via <see cref="AzureSigImageDefinitionCreateSettings.PlanName"/></li>
        ///     <li><c>--plan-product</c> via <see cref="AzureSigImageDefinitionCreateSettings.PlanProduct"/></li>
        ///     <li><c>--plan-publisher</c> via <see cref="AzureSigImageDefinitionCreateSettings.PlanPublisher"/></li>
        ///     <li><c>--privacy-statement-uri</c> via <see cref="AzureSigImageDefinitionCreateSettings.PrivacyStatementUri"/></li>
        ///     <li><c>--publisher</c> via <see cref="AzureSigImageDefinitionCreateSettings.Publisher"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageDefinitionCreateSettings.Query"/></li>
        ///     <li><c>--release-note-uri</c> via <see cref="AzureSigImageDefinitionCreateSettings.ReleaseNoteUri"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageDefinitionCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureSigImageDefinitionCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageDefinitionCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureSigImageDefinitionCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageDefinitionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigImageDefinitionCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigImageDefinitionCreate(CombinatorialConfigure<AzureSigImageDefinitionCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigImageDefinitionCreate, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigImageDefinitionDelete(AzureSigImageDefinitionDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigImageDefinitionDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Debug"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageDefinitionDeleteSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageDefinitionDeleteSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageDefinitionDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigImageDefinitionDelete(Configure<AzureSigImageDefinitionDeleteSettings> configurator)
        {
            return AzureSigImageDefinitionDelete(configurator(new AzureSigImageDefinitionDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Debug"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageDefinitionDeleteSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageDefinitionDeleteSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageDefinitionDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageDefinitionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigImageDefinitionDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigImageDefinitionDelete(CombinatorialConfigure<AzureSigImageDefinitionDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigImageDefinitionDelete, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigImageDefinitionList(AzureSigImageDefinitionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigImageDefinitionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageDefinitionListSettings.Debug"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageDefinitionListSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageDefinitionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageDefinitionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageDefinitionListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageDefinitionListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageDefinitionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageDefinitionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigImageDefinitionList(Configure<AzureSigImageDefinitionListSettings> configurator)
        {
            return AzureSigImageDefinitionList(configurator(new AzureSigImageDefinitionListSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageDefinitionListSettings.Debug"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageDefinitionListSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageDefinitionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageDefinitionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageDefinitionListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageDefinitionListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageDefinitionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageDefinitionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigImageDefinitionListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigImageDefinitionList(CombinatorialConfigure<AzureSigImageDefinitionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigImageDefinitionList, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigImageDefinitionShow(AzureSigImageDefinitionShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigImageDefinitionShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageDefinitionShowSettings.Debug"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageDefinitionShowSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageDefinitionShowSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageDefinitionShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSigImageDefinitionShowSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageDefinitionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageDefinitionShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageDefinitionShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageDefinitionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageDefinitionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigImageDefinitionShow(Configure<AzureSigImageDefinitionShowSettings> configurator)
        {
            return AzureSigImageDefinitionShow(configurator(new AzureSigImageDefinitionShowSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageDefinitionShowSettings.Debug"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageDefinitionShowSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageDefinitionShowSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageDefinitionShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureSigImageDefinitionShowSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageDefinitionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageDefinitionShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageDefinitionShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageDefinitionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageDefinitionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigImageDefinitionShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigImageDefinitionShow(CombinatorialConfigure<AzureSigImageDefinitionShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigImageDefinitionShow, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigImageDefinitionUpdate(AzureSigImageDefinitionUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigImageDefinitionUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureSigImageDefinitionUpdateSettings.ForceString"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageDefinitionUpdateSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageDefinitionUpdateSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageDefinitionUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigImageDefinitionUpdate(Configure<AzureSigImageDefinitionUpdateSettings> configurator)
        {
            return AzureSigImageDefinitionUpdate(configurator(new AzureSigImageDefinitionUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureSigImageDefinitionUpdateSettings.ForceString"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageDefinitionUpdateSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageDefinitionUpdateSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageDefinitionUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageDefinitionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigImageDefinitionUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigImageDefinitionUpdate(CombinatorialConfigure<AzureSigImageDefinitionUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigImageDefinitionUpdate, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigImageVersionCreate(AzureSigImageVersionCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigImageVersionCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageVersionCreateSettings.Debug"/></li>
        ///     <li><c>--end-of-life-date</c> via <see cref="AzureSigImageVersionCreateSettings.EndOfLifeDate"/></li>
        ///     <li><c>--exclude-from-latest</c> via <see cref="AzureSigImageVersionCreateSettings.ExcludeFromLatest"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageVersionCreateSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-image-version</c> via <see cref="AzureSigImageVersionCreateSettings.GalleryImageVersion"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageVersionCreateSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageVersionCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSigImageVersionCreateSettings.Location"/></li>
        ///     <li><c>--managed-image</c> via <see cref="AzureSigImageVersionCreateSettings.ManagedImage"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureSigImageVersionCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageVersionCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageVersionCreateSettings.Query"/></li>
        ///     <li><c>--replica-count</c> via <see cref="AzureSigImageVersionCreateSettings.ReplicaCount"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageVersionCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--storage-account-type</c> via <see cref="AzureSigImageVersionCreateSettings.StorageAccountType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageVersionCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureSigImageVersionCreateSettings.Tags"/></li>
        ///     <li><c>--target-regions</c> via <see cref="AzureSigImageVersionCreateSettings.TargetRegions"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageVersionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigImageVersionCreate(Configure<AzureSigImageVersionCreateSettings> configurator)
        {
            return AzureSigImageVersionCreate(configurator(new AzureSigImageVersionCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageVersionCreateSettings.Debug"/></li>
        ///     <li><c>--end-of-life-date</c> via <see cref="AzureSigImageVersionCreateSettings.EndOfLifeDate"/></li>
        ///     <li><c>--exclude-from-latest</c> via <see cref="AzureSigImageVersionCreateSettings.ExcludeFromLatest"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageVersionCreateSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-image-version</c> via <see cref="AzureSigImageVersionCreateSettings.GalleryImageVersion"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageVersionCreateSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageVersionCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSigImageVersionCreateSettings.Location"/></li>
        ///     <li><c>--managed-image</c> via <see cref="AzureSigImageVersionCreateSettings.ManagedImage"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureSigImageVersionCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageVersionCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageVersionCreateSettings.Query"/></li>
        ///     <li><c>--replica-count</c> via <see cref="AzureSigImageVersionCreateSettings.ReplicaCount"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageVersionCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--storage-account-type</c> via <see cref="AzureSigImageVersionCreateSettings.StorageAccountType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageVersionCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureSigImageVersionCreateSettings.Tags"/></li>
        ///     <li><c>--target-regions</c> via <see cref="AzureSigImageVersionCreateSettings.TargetRegions"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageVersionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigImageVersionCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigImageVersionCreate(CombinatorialConfigure<AzureSigImageVersionCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigImageVersionCreate, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigImageVersionDelete(AzureSigImageVersionDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigImageVersionDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageVersionDeleteSettings.Debug"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageVersionDeleteSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-image-version</c> via <see cref="AzureSigImageVersionDeleteSettings.GalleryImageVersion"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageVersionDeleteSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageVersionDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageVersionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageVersionDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageVersionDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageVersionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageVersionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigImageVersionDelete(Configure<AzureSigImageVersionDeleteSettings> configurator)
        {
            return AzureSigImageVersionDelete(configurator(new AzureSigImageVersionDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageVersionDeleteSettings.Debug"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageVersionDeleteSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-image-version</c> via <see cref="AzureSigImageVersionDeleteSettings.GalleryImageVersion"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageVersionDeleteSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageVersionDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageVersionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageVersionDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageVersionDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageVersionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageVersionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigImageVersionDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigImageVersionDelete(CombinatorialConfigure<AzureSigImageVersionDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigImageVersionDelete, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigImageVersionList(AzureSigImageVersionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigImageVersionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageVersionListSettings.Debug"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageVersionListSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageVersionListSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageVersionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageVersionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageVersionListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageVersionListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageVersionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageVersionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigImageVersionList(Configure<AzureSigImageVersionListSettings> configurator)
        {
            return AzureSigImageVersionList(configurator(new AzureSigImageVersionListSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageVersionListSettings.Debug"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageVersionListSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageVersionListSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageVersionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageVersionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageVersionListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageVersionListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageVersionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageVersionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigImageVersionListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigImageVersionList(CombinatorialConfigure<AzureSigImageVersionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigImageVersionList, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigImageVersionShow(AzureSigImageVersionShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigImageVersionShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageVersionShowSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureSigImageVersionShowSettings.Expand"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageVersionShowSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-image-version</c> via <see cref="AzureSigImageVersionShowSettings.GalleryImageVersion"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageVersionShowSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageVersionShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageVersionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageVersionShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageVersionShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageVersionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageVersionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigImageVersionShow(Configure<AzureSigImageVersionShowSettings> configurator)
        {
            return AzureSigImageVersionShow(configurator(new AzureSigImageVersionShowSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageVersionShowSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureSigImageVersionShowSettings.Expand"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageVersionShowSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-image-version</c> via <see cref="AzureSigImageVersionShowSettings.GalleryImageVersion"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageVersionShowSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageVersionShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageVersionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageVersionShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageVersionShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageVersionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageVersionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigImageVersionShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigImageVersionShow(CombinatorialConfigure<AzureSigImageVersionShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigImageVersionShow, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigImageVersionUpdate(AzureSigImageVersionUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigImageVersionUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureSigImageVersionUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageVersionUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureSigImageVersionUpdateSettings.ForceString"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageVersionUpdateSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-image-version</c> via <see cref="AzureSigImageVersionUpdateSettings.GalleryImageVersion"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageVersionUpdateSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageVersionUpdateSettings.Help"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureSigImageVersionUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageVersionUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageVersionUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureSigImageVersionUpdateSettings.Remove"/></li>
        ///     <li><c>--replica-count</c> via <see cref="AzureSigImageVersionUpdateSettings.ReplicaCount"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageVersionUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureSigImageVersionUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageVersionUpdateSettings.Subscription"/></li>
        ///     <li><c>--target-regions</c> via <see cref="AzureSigImageVersionUpdateSettings.TargetRegions"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageVersionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigImageVersionUpdate(Configure<AzureSigImageVersionUpdateSettings> configurator)
        {
            return AzureSigImageVersionUpdate(configurator(new AzureSigImageVersionUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureSigImageVersionUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageVersionUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureSigImageVersionUpdateSettings.ForceString"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageVersionUpdateSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-image-version</c> via <see cref="AzureSigImageVersionUpdateSettings.GalleryImageVersion"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageVersionUpdateSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageVersionUpdateSettings.Help"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureSigImageVersionUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageVersionUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageVersionUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureSigImageVersionUpdateSettings.Remove"/></li>
        ///     <li><c>--replica-count</c> via <see cref="AzureSigImageVersionUpdateSettings.ReplicaCount"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageVersionUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureSigImageVersionUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageVersionUpdateSettings.Subscription"/></li>
        ///     <li><c>--target-regions</c> via <see cref="AzureSigImageVersionUpdateSettings.TargetRegions"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageVersionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigImageVersionUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigImageVersionUpdate(CombinatorialConfigure<AzureSigImageVersionUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigImageVersionUpdate, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSigImageVersionWait(AzureSigImageVersionWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSigImageVersionWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureSigImageVersionWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureSigImageVersionWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageVersionWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureSigImageVersionWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureSigImageVersionWaitSettings.Exists"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureSigImageVersionWaitSettings.Expand"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageVersionWaitSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-image-version</c> via <see cref="AzureSigImageVersionWaitSettings.GalleryImageVersion"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageVersionWaitSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageVersionWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureSigImageVersionWaitSettings.Interval"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageVersionWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageVersionWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageVersionWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageVersionWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureSigImageVersionWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureSigImageVersionWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageVersionWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSigImageVersionWait(Configure<AzureSigImageVersionWaitSettings> configurator)
        {
            return AzureSigImageVersionWait(configurator(new AzureSigImageVersionWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage shared image gallery.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureSigImageVersionWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureSigImageVersionWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSigImageVersionWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureSigImageVersionWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureSigImageVersionWaitSettings.Exists"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureSigImageVersionWaitSettings.Expand"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureSigImageVersionWaitSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-image-version</c> via <see cref="AzureSigImageVersionWaitSettings.GalleryImageVersion"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureSigImageVersionWaitSettings.GalleryName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSigImageVersionWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureSigImageVersionWaitSettings.Interval"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSigImageVersionWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSigImageVersionWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSigImageVersionWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSigImageVersionWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureSigImageVersionWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureSigImageVersionWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSigImageVersionWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSigImageVersionWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureSigImageVersionWait(CombinatorialConfigure<AzureSigImageVersionWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSigImageVersionWait, AzureSigLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureSigCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The description of the gallery.
        /// </summary>
        public virtual string Description { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
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
              .Add("sig create")
              .Add("--gallery-name {value}", GalleryName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--description {value}", Description)
              .Add("--location {value}", Location)
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
    #region AzureSigDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
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
              .Add("sig delete")
              .Add("--gallery-name {value}", GalleryName)
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
    #region AzureSigListSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
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
              .Add("sig list")
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
    #region AzureSigShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
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
              .Add("sig show")
              .Add("--gallery-name {value}", GalleryName)
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
    #region AzureSigUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("sig update")
              .Add("--gallery-name {value}", GalleryName)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureSigImageDefinitionCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigImageDefinitionCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery image definition.
        /// </summary>
        public virtual string GalleryImageDefinition { get; internal set; }
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
        /// <summary>
        ///   Image offer.
        /// </summary>
        public virtual string Offer { get; internal set; }
        /// <summary>
        ///   The type of the OS that is included in the disk if creating a VM from user-image or a specialized VHD.
        /// </summary>
        public virtual SigImageDefinitionCreateOsType OsType { get; internal set; }
        /// <summary>
        ///   Image publisher.
        /// </summary>
        public virtual string Publisher { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Image sku.
        /// </summary>
        public virtual string Sku { get; internal set; }
        /// <summary>
        ///   The description of the gallery image definition.
        /// </summary>
        public virtual string Description { get; internal set; }
        /// <summary>
        ///   Disk types which would not work with the image, e.g., Standard_LRS.
        /// </summary>
        public virtual string DisallowedDiskTypes { get; internal set; }
        /// <summary>
        ///   The end of life date, e.g. '2020-12-31'.
        /// </summary>
        public virtual string EndOfLifeDate { get; internal set; }
        /// <summary>
        ///   The Eula agreement for the gallery image.
        /// </summary>
        public virtual string Eula { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The privacy statement uri.
        /// </summary>
        public virtual string PrivacyStatementUri { get; internal set; }
        /// <summary>
        ///   The release note uri.
        /// </summary>
        public virtual string ReleaseNoteUri { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   Plan name.
        /// </summary>
        public virtual string PlanName { get; internal set; }
        /// <summary>
        ///   Plan product.
        /// </summary>
        public virtual string PlanProduct { get; internal set; }
        /// <summary>
        ///   Plan publisher.
        /// </summary>
        public virtual string PlanPublisher { get; internal set; }
        /// <summary>
        ///   Maximum cpu cores.
        /// </summary>
        public virtual string MaximumCpuCore { get; internal set; }
        /// <summary>
        ///   Maximum memory in MB.
        /// </summary>
        public virtual string MaximumMemory { get; internal set; }
        /// <summary>
        ///   Minimum cpu cores.
        /// </summary>
        public virtual string MinimumCpuCore { get; internal set; }
        /// <summary>
        ///   Minimum memory in MB.
        /// </summary>
        public virtual string MinimumMemory { get; internal set; }
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
              .Add("sig image-definition create")
              .Add("--gallery-image-definition {value}", GalleryImageDefinition)
              .Add("--gallery-name {value}", GalleryName)
              .Add("--offer {value}", Offer)
              .Add("--os-type {value}", OsType)
              .Add("--publisher {value}", Publisher)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--description {value}", Description)
              .Add("--disallowed-disk-types {value}", DisallowedDiskTypes)
              .Add("--end-of-life-date {value}", EndOfLifeDate)
              .Add("--eula {value}", Eula)
              .Add("--location {value}", Location)
              .Add("--privacy-statement-uri {value}", PrivacyStatementUri)
              .Add("--release-note-uri {value}", ReleaseNoteUri)
              .Add("--tags {value}", Tags)
              .Add("--plan-name {value}", PlanName)
              .Add("--plan-product {value}", PlanProduct)
              .Add("--plan-publisher {value}", PlanPublisher)
              .Add("--maximum-cpu-core {value}", MaximumCpuCore)
              .Add("--maximum-memory {value}", MaximumMemory)
              .Add("--minimum-cpu-core {value}", MinimumCpuCore)
              .Add("--minimum-memory {value}", MinimumMemory)
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
    #region AzureSigImageDefinitionDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigImageDefinitionDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery image definition.
        /// </summary>
        public virtual string GalleryImageDefinition { get; internal set; }
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
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
              .Add("sig image-definition delete")
              .Add("--gallery-image-definition {value}", GalleryImageDefinition)
              .Add("--gallery-name {value}", GalleryName)
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
    #region AzureSigImageDefinitionListSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigImageDefinitionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
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
              .Add("sig image-definition list")
              .Add("--gallery-name {value}", GalleryName)
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
    #region AzureSigImageDefinitionShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigImageDefinitionShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery image definition.
        /// </summary>
        public virtual string GalleryImageDefinition { get; internal set; }
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
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
              .Add("sig image-definition show")
              .Add("--gallery-image-definition {value}", GalleryImageDefinition)
              .Add("--gallery-name {value}", GalleryName)
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
    #region AzureSigImageDefinitionUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigImageDefinitionUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery image definition.
        /// </summary>
        public virtual string GalleryImageDefinition { get; internal set; }
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("sig image-definition update")
              .Add("--gallery-image-definition {value}", GalleryImageDefinition)
              .Add("--gallery-name {value}", GalleryName)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureSigImageVersionCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigImageVersionCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery image definition.
        /// </summary>
        public virtual string GalleryImageDefinition { get; internal set; }
        /// <summary>
        ///   Gallery image version in semantic version pattern. The allowed characters are digit and period. Digits must be within the range of a 32-bit integer, e.g. &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;.
        /// </summary>
        public virtual string GalleryImageVersion { get; internal set; }
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
        /// <summary>
        ///   Image name(if in the same resource group) or resource id.
        /// </summary>
        public virtual string ManagedImage { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The end of life date, e.g. '2020-12-31'.
        /// </summary>
        public virtual string EndOfLifeDate { get; internal set; }
        /// <summary>
        ///   The flag means that if it is set to true, people deploying VMs with version omitted will not use this version.
        /// </summary>
        public virtual bool? ExcludeFromLatest { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   The default number of replicas to be created per region. To set regional replication counts, use --target-regions.
        /// </summary>
        public virtual string ReplicaCount { get; internal set; }
        /// <summary>
        ///   The default storage account type to be used per region. To set regional storage account types, use --target-regions.
        /// </summary>
        public virtual SigImageVersionCreateStorageAccountType StorageAccountType { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.
        /// </summary>
        public virtual IReadOnlyList<string> TargetRegions => TargetRegionsInternal.AsReadOnly();
        internal List<string> TargetRegionsInternal { get; set; } = new List<string>();
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
              .Add("sig image-version create")
              .Add("--gallery-image-definition {value}", GalleryImageDefinition)
              .Add("--gallery-image-version {value}", GalleryImageVersion)
              .Add("--gallery-name {value}", GalleryName)
              .Add("--managed-image {value}", ManagedImage)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--end-of-life-date {value}", EndOfLifeDate)
              .Add("--exclude-from-latest", ExcludeFromLatest)
              .Add("--location {value}", Location)
              .Add("--no-wait", NoWait)
              .Add("--replica-count {value}", ReplicaCount)
              .Add("--storage-account-type {value}", StorageAccountType)
              .Add("--tags {value}", Tags)
              .Add("--target-regions {value}", TargetRegions, separator: ' ')
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
    #region AzureSigImageVersionDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigImageVersionDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery image definition.
        /// </summary>
        public virtual string GalleryImageDefinition { get; internal set; }
        /// <summary>
        ///   The name of the gallery Image Version to be deleted.
        /// </summary>
        public virtual string GalleryImageVersion { get; internal set; }
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
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
              .Add("sig image-version delete")
              .Add("--gallery-image-definition {value}", GalleryImageDefinition)
              .Add("--gallery-image-version {value}", GalleryImageVersion)
              .Add("--gallery-name {value}", GalleryName)
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
    #region AzureSigImageVersionListSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigImageVersionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery image definition.
        /// </summary>
        public virtual string GalleryImageDefinition { get; internal set; }
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
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
              .Add("sig image-version list")
              .Add("--gallery-image-definition {value}", GalleryImageDefinition)
              .Add("--gallery-name {value}", GalleryName)
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
    #region AzureSigImageVersionShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigImageVersionShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery image definition.
        /// </summary>
        public virtual string GalleryImageDefinition { get; internal set; }
        /// <summary>
        ///   The name of the gallery Image Version to be retrieved.
        /// </summary>
        public virtual string GalleryImageVersion { get; internal set; }
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The expand expression to apply on the operation, e.g. 'ReplicationStatus'.
        /// </summary>
        public virtual string Expand { get; internal set; }
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
              .Add("sig image-version show")
              .Add("--gallery-image-definition {value}", GalleryImageDefinition)
              .Add("--gallery-image-version {value}", GalleryImageVersion)
              .Add("--gallery-name {value}", GalleryName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
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
    #region AzureSigImageVersionUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigImageVersionUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery image definition.
        /// </summary>
        public virtual string GalleryImageDefinition { get; internal set; }
        /// <summary>
        ///   The name of the gallery Image Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;.
        /// </summary>
        public virtual string GalleryImageVersion { get; internal set; }
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   The default number of replicas to be created per region. To set regional replication counts, use --target-regions.
        /// </summary>
        public virtual string ReplicaCount { get; internal set; }
        /// <summary>
        ///   Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.
        /// </summary>
        public virtual IReadOnlyList<string> TargetRegions => TargetRegionsInternal.AsReadOnly();
        internal List<string> TargetRegionsInternal { get; set; } = new List<string>();
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
              .Add("sig image-version update")
              .Add("--gallery-image-definition {value}", GalleryImageDefinition)
              .Add("--gallery-image-version {value}", GalleryImageVersion)
              .Add("--gallery-name {value}", GalleryName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
              .Add("--replica-count {value}", ReplicaCount)
              .Add("--target-regions {value}", TargetRegions, separator: ' ')
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
    #region AzureSigImageVersionWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSigImageVersionWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSigTasks.AzureSigPath;
        public override Action<OutputType, string> CustomLogger => AzureSigTasks.AzureSigLogger;
        /// <summary>
        ///   Gallery image definition.
        /// </summary>
        public virtual string GalleryImageDefinition { get; internal set; }
        /// <summary>
        ///   The name of the gallery Image Version to be retrieved.
        /// </summary>
        public virtual string GalleryImageVersion { get; internal set; }
        /// <summary>
        ///   Gallery name.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The expand expression to apply on the operation.
        /// </summary>
        public virtual string Expand { get; internal set; }
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
              .Add("sig image-version wait")
              .Add("--gallery-image-definition {value}", GalleryImageDefinition)
              .Add("--gallery-image-version {value}", GalleryImageVersion)
              .Add("--gallery-name {value}", GalleryName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
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
    #region AzureSigCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigCreateSettingsExtensions
    {
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigCreateSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings SetGalleryName(this AzureSigCreateSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigCreateSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings ResetGalleryName(this AzureSigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings SetResourceGroup(this AzureSigCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings ResetResourceGroup(this AzureSigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigCreateSettings.Description"/></em></p>
        ///   <p>The description of the gallery.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings SetDescription(this AzureSigCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigCreateSettings.Description"/></em></p>
        ///   <p>The description of the gallery.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings ResetDescription(this AzureSigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings SetLocation(this AzureSigCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings ResetLocation(this AzureSigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings SetTags(this AzureSigCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings ResetTags(this AzureSigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings SetSubscription(this AzureSigCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings ResetSubscription(this AzureSigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings SetDebug(this AzureSigCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings ResetDebug(this AzureSigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings SetHelp(this AzureSigCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings ResetHelp(this AzureSigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings SetOutput(this AzureSigCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings ResetOutput(this AzureSigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings SetQuery(this AzureSigCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings ResetQuery(this AzureSigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings SetVerbose(this AzureSigCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigCreateSettings ResetVerbose(this AzureSigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigDeleteSettingsExtensions
    {
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigDeleteSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings SetGalleryName(this AzureSigDeleteSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigDeleteSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings ResetGalleryName(this AzureSigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings SetResourceGroup(this AzureSigDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings ResetResourceGroup(this AzureSigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings SetSubscription(this AzureSigDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings ResetSubscription(this AzureSigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings SetDebug(this AzureSigDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings ResetDebug(this AzureSigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings SetHelp(this AzureSigDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings ResetHelp(this AzureSigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings SetOutput(this AzureSigDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings ResetOutput(this AzureSigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings SetQuery(this AzureSigDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings ResetQuery(this AzureSigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings SetVerbose(this AzureSigDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigDeleteSettings ResetVerbose(this AzureSigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings SetResourceGroup(this AzureSigListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings ResetResourceGroup(this AzureSigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings SetSubscription(this AzureSigListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings ResetSubscription(this AzureSigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings SetDebug(this AzureSigListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings ResetDebug(this AzureSigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings SetHelp(this AzureSigListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings ResetHelp(this AzureSigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings SetOutput(this AzureSigListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings ResetOutput(this AzureSigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings SetQuery(this AzureSigListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings ResetQuery(this AzureSigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings SetVerbose(this AzureSigListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigListSettings ResetVerbose(this AzureSigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigShowSettingsExtensions
    {
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigShowSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings SetGalleryName(this AzureSigShowSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigShowSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings ResetGalleryName(this AzureSigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings SetIds(this AzureSigShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings SetIds(this AzureSigShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSigShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings AddIds(this AzureSigShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSigShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings AddIds(this AzureSigShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSigShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings ClearIds(this AzureSigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSigShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings RemoveIds(this AzureSigShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSigShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings RemoveIds(this AzureSigShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings SetResourceGroup(this AzureSigShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings ResetResourceGroup(this AzureSigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings SetSubscription(this AzureSigShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings ResetSubscription(this AzureSigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings SetDebug(this AzureSigShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings ResetDebug(this AzureSigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings SetHelp(this AzureSigShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings ResetHelp(this AzureSigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings SetOutput(this AzureSigShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings ResetOutput(this AzureSigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings SetQuery(this AzureSigShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings ResetQuery(this AzureSigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings SetVerbose(this AzureSigShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigShowSettings ResetVerbose(this AzureSigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigUpdateSettingsExtensions
    {
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigUpdateSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings SetGalleryName(this AzureSigUpdateSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigUpdateSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings ResetGalleryName(this AzureSigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings SetResourceGroup(this AzureSigUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings ResetResourceGroup(this AzureSigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings SetAdd(this AzureSigUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings ResetAdd(this AzureSigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings SetForceString(this AzureSigUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings ResetForceString(this AzureSigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings SetRemove(this AzureSigUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings ResetRemove(this AzureSigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings SetSet(this AzureSigUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings ResetSet(this AzureSigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings SetSubscription(this AzureSigUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings ResetSubscription(this AzureSigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings SetDebug(this AzureSigUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings ResetDebug(this AzureSigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings SetHelp(this AzureSigUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings ResetHelp(this AzureSigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings SetOutput(this AzureSigUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings ResetOutput(this AzureSigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings SetQuery(this AzureSigUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings ResetQuery(this AzureSigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings SetVerbose(this AzureSigUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigUpdateSettings ResetVerbose(this AzureSigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigImageDefinitionCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigImageDefinitionCreateSettingsExtensions
    {
        #region GalleryImageDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetGalleryImageDefinition(this AzureSigImageDefinitionCreateSettings toolSettings, string galleryImageDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = galleryImageDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetGalleryImageDefinition(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = null;
            return toolSettings;
        }
        #endregion
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetGalleryName(this AzureSigImageDefinitionCreateSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetGalleryName(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region Offer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.Offer"/></em></p>
        ///   <p>Image offer.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetOffer(this AzureSigImageDefinitionCreateSettings toolSettings, string offer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offer = offer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.Offer"/></em></p>
        ///   <p>Image offer.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetOffer(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Offer = null;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.OsType"/></em></p>
        ///   <p>The type of the OS that is included in the disk if creating a VM from user-image or a specialized VHD.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetOsType(this AzureSigImageDefinitionCreateSettings toolSettings, SigImageDefinitionCreateOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.OsType"/></em></p>
        ///   <p>The type of the OS that is included in the disk if creating a VM from user-image or a specialized VHD.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetOsType(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region Publisher
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.Publisher"/></em></p>
        ///   <p>Image publisher.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetPublisher(this AzureSigImageDefinitionCreateSettings toolSettings, string publisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = publisher;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.Publisher"/></em></p>
        ///   <p>Image publisher.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetPublisher(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Publisher = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetResourceGroup(this AzureSigImageDefinitionCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetResourceGroup(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.Sku"/></em></p>
        ///   <p>Image sku.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetSku(this AzureSigImageDefinitionCreateSettings toolSettings, string sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.Sku"/></em></p>
        ///   <p>Image sku.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetSku(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.Description"/></em></p>
        ///   <p>The description of the gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetDescription(this AzureSigImageDefinitionCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.Description"/></em></p>
        ///   <p>The description of the gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetDescription(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DisallowedDiskTypes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.DisallowedDiskTypes"/></em></p>
        ///   <p>Disk types which would not work with the image, e.g., Standard_LRS.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetDisallowedDiskTypes(this AzureSigImageDefinitionCreateSettings toolSettings, string disallowedDiskTypes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisallowedDiskTypes = disallowedDiskTypes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.DisallowedDiskTypes"/></em></p>
        ///   <p>Disk types which would not work with the image, e.g., Standard_LRS.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetDisallowedDiskTypes(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisallowedDiskTypes = null;
            return toolSettings;
        }
        #endregion
        #region EndOfLifeDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.EndOfLifeDate"/></em></p>
        ///   <p>The end of life date, e.g. '2020-12-31'.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetEndOfLifeDate(this AzureSigImageDefinitionCreateSettings toolSettings, string endOfLifeDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndOfLifeDate = endOfLifeDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.EndOfLifeDate"/></em></p>
        ///   <p>The end of life date, e.g. '2020-12-31'.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetEndOfLifeDate(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndOfLifeDate = null;
            return toolSettings;
        }
        #endregion
        #region Eula
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.Eula"/></em></p>
        ///   <p>The Eula agreement for the gallery image.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetEula(this AzureSigImageDefinitionCreateSettings toolSettings, string eula)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Eula = eula;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.Eula"/></em></p>
        ///   <p>The Eula agreement for the gallery image.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetEula(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Eula = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetLocation(this AzureSigImageDefinitionCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetLocation(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region PrivacyStatementUri
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.PrivacyStatementUri"/></em></p>
        ///   <p>The privacy statement uri.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetPrivacyStatementUri(this AzureSigImageDefinitionCreateSettings toolSettings, string privacyStatementUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrivacyStatementUri = privacyStatementUri;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.PrivacyStatementUri"/></em></p>
        ///   <p>The privacy statement uri.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetPrivacyStatementUri(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrivacyStatementUri = null;
            return toolSettings;
        }
        #endregion
        #region ReleaseNoteUri
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.ReleaseNoteUri"/></em></p>
        ///   <p>The release note uri.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetReleaseNoteUri(this AzureSigImageDefinitionCreateSettings toolSettings, string releaseNoteUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseNoteUri = releaseNoteUri;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.ReleaseNoteUri"/></em></p>
        ///   <p>The release note uri.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetReleaseNoteUri(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseNoteUri = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetTags(this AzureSigImageDefinitionCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetTags(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region PlanName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.PlanName"/></em></p>
        ///   <p>Plan name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetPlanName(this AzureSigImageDefinitionCreateSettings toolSettings, string planName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanName = planName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.PlanName"/></em></p>
        ///   <p>Plan name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetPlanName(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanName = null;
            return toolSettings;
        }
        #endregion
        #region PlanProduct
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.PlanProduct"/></em></p>
        ///   <p>Plan product.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetPlanProduct(this AzureSigImageDefinitionCreateSettings toolSettings, string planProduct)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanProduct = planProduct;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.PlanProduct"/></em></p>
        ///   <p>Plan product.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetPlanProduct(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanProduct = null;
            return toolSettings;
        }
        #endregion
        #region PlanPublisher
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.PlanPublisher"/></em></p>
        ///   <p>Plan publisher.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetPlanPublisher(this AzureSigImageDefinitionCreateSettings toolSettings, string planPublisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPublisher = planPublisher;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.PlanPublisher"/></em></p>
        ///   <p>Plan publisher.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetPlanPublisher(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPublisher = null;
            return toolSettings;
        }
        #endregion
        #region MaximumCpuCore
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.MaximumCpuCore"/></em></p>
        ///   <p>Maximum cpu cores.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetMaximumCpuCore(this AzureSigImageDefinitionCreateSettings toolSettings, string maximumCpuCore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaximumCpuCore = maximumCpuCore;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.MaximumCpuCore"/></em></p>
        ///   <p>Maximum cpu cores.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetMaximumCpuCore(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaximumCpuCore = null;
            return toolSettings;
        }
        #endregion
        #region MaximumMemory
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.MaximumMemory"/></em></p>
        ///   <p>Maximum memory in MB.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetMaximumMemory(this AzureSigImageDefinitionCreateSettings toolSettings, string maximumMemory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaximumMemory = maximumMemory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.MaximumMemory"/></em></p>
        ///   <p>Maximum memory in MB.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetMaximumMemory(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaximumMemory = null;
            return toolSettings;
        }
        #endregion
        #region MinimumCpuCore
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.MinimumCpuCore"/></em></p>
        ///   <p>Minimum cpu cores.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetMinimumCpuCore(this AzureSigImageDefinitionCreateSettings toolSettings, string minimumCpuCore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinimumCpuCore = minimumCpuCore;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.MinimumCpuCore"/></em></p>
        ///   <p>Minimum cpu cores.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetMinimumCpuCore(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinimumCpuCore = null;
            return toolSettings;
        }
        #endregion
        #region MinimumMemory
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.MinimumMemory"/></em></p>
        ///   <p>Minimum memory in MB.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetMinimumMemory(this AzureSigImageDefinitionCreateSettings toolSettings, string minimumMemory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinimumMemory = minimumMemory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.MinimumMemory"/></em></p>
        ///   <p>Minimum memory in MB.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetMinimumMemory(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinimumMemory = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetSubscription(this AzureSigImageDefinitionCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetSubscription(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetDebug(this AzureSigImageDefinitionCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetDebug(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetHelp(this AzureSigImageDefinitionCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetHelp(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetOutput(this AzureSigImageDefinitionCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetOutput(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetQuery(this AzureSigImageDefinitionCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetQuery(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings SetVerbose(this AzureSigImageDefinitionCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionCreateSettings ResetVerbose(this AzureSigImageDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigImageDefinitionDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigImageDefinitionDeleteSettingsExtensions
    {
        #region GalleryImageDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionDeleteSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings SetGalleryImageDefinition(this AzureSigImageDefinitionDeleteSettings toolSettings, string galleryImageDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = galleryImageDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionDeleteSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings ResetGalleryImageDefinition(this AzureSigImageDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = null;
            return toolSettings;
        }
        #endregion
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionDeleteSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings SetGalleryName(this AzureSigImageDefinitionDeleteSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionDeleteSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings ResetGalleryName(this AzureSigImageDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings SetIds(this AzureSigImageDefinitionDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings SetIds(this AzureSigImageDefinitionDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSigImageDefinitionDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings AddIds(this AzureSigImageDefinitionDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSigImageDefinitionDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings AddIds(this AzureSigImageDefinitionDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSigImageDefinitionDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings ClearIds(this AzureSigImageDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSigImageDefinitionDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings RemoveIds(this AzureSigImageDefinitionDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSigImageDefinitionDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings RemoveIds(this AzureSigImageDefinitionDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings SetResourceGroup(this AzureSigImageDefinitionDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings ResetResourceGroup(this AzureSigImageDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings SetSubscription(this AzureSigImageDefinitionDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings ResetSubscription(this AzureSigImageDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings SetDebug(this AzureSigImageDefinitionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings ResetDebug(this AzureSigImageDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings SetHelp(this AzureSigImageDefinitionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings ResetHelp(this AzureSigImageDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings SetOutput(this AzureSigImageDefinitionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings ResetOutput(this AzureSigImageDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings SetQuery(this AzureSigImageDefinitionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings ResetQuery(this AzureSigImageDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings SetVerbose(this AzureSigImageDefinitionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionDeleteSettings ResetVerbose(this AzureSigImageDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigImageDefinitionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigImageDefinitionListSettingsExtensions
    {
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionListSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings SetGalleryName(this AzureSigImageDefinitionListSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionListSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings ResetGalleryName(this AzureSigImageDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings SetResourceGroup(this AzureSigImageDefinitionListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings ResetResourceGroup(this AzureSigImageDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings SetSubscription(this AzureSigImageDefinitionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings ResetSubscription(this AzureSigImageDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings SetDebug(this AzureSigImageDefinitionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings ResetDebug(this AzureSigImageDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings SetHelp(this AzureSigImageDefinitionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings ResetHelp(this AzureSigImageDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings SetOutput(this AzureSigImageDefinitionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings ResetOutput(this AzureSigImageDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings SetQuery(this AzureSigImageDefinitionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings ResetQuery(this AzureSigImageDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings SetVerbose(this AzureSigImageDefinitionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionListSettings ResetVerbose(this AzureSigImageDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigImageDefinitionShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigImageDefinitionShowSettingsExtensions
    {
        #region GalleryImageDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionShowSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings SetGalleryImageDefinition(this AzureSigImageDefinitionShowSettings toolSettings, string galleryImageDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = galleryImageDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionShowSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings ResetGalleryImageDefinition(this AzureSigImageDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = null;
            return toolSettings;
        }
        #endregion
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionShowSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings SetGalleryName(this AzureSigImageDefinitionShowSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionShowSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings ResetGalleryName(this AzureSigImageDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings SetIds(this AzureSigImageDefinitionShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings SetIds(this AzureSigImageDefinitionShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSigImageDefinitionShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings AddIds(this AzureSigImageDefinitionShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSigImageDefinitionShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings AddIds(this AzureSigImageDefinitionShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSigImageDefinitionShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings ClearIds(this AzureSigImageDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSigImageDefinitionShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings RemoveIds(this AzureSigImageDefinitionShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSigImageDefinitionShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings RemoveIds(this AzureSigImageDefinitionShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings SetResourceGroup(this AzureSigImageDefinitionShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings ResetResourceGroup(this AzureSigImageDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings SetSubscription(this AzureSigImageDefinitionShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings ResetSubscription(this AzureSigImageDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings SetDebug(this AzureSigImageDefinitionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings ResetDebug(this AzureSigImageDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings SetHelp(this AzureSigImageDefinitionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings ResetHelp(this AzureSigImageDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings SetOutput(this AzureSigImageDefinitionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings ResetOutput(this AzureSigImageDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings SetQuery(this AzureSigImageDefinitionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings ResetQuery(this AzureSigImageDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings SetVerbose(this AzureSigImageDefinitionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionShowSettings ResetVerbose(this AzureSigImageDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigImageDefinitionUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigImageDefinitionUpdateSettingsExtensions
    {
        #region GalleryImageDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionUpdateSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings SetGalleryImageDefinition(this AzureSigImageDefinitionUpdateSettings toolSettings, string galleryImageDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = galleryImageDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionUpdateSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings ResetGalleryImageDefinition(this AzureSigImageDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = null;
            return toolSettings;
        }
        #endregion
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionUpdateSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings SetGalleryName(this AzureSigImageDefinitionUpdateSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionUpdateSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings ResetGalleryName(this AzureSigImageDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings SetResourceGroup(this AzureSigImageDefinitionUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings ResetResourceGroup(this AzureSigImageDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings SetAdd(this AzureSigImageDefinitionUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings ResetAdd(this AzureSigImageDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings SetForceString(this AzureSigImageDefinitionUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings ResetForceString(this AzureSigImageDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings SetRemove(this AzureSigImageDefinitionUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings ResetRemove(this AzureSigImageDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings SetSet(this AzureSigImageDefinitionUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings ResetSet(this AzureSigImageDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings SetSubscription(this AzureSigImageDefinitionUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings ResetSubscription(this AzureSigImageDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings SetDebug(this AzureSigImageDefinitionUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings ResetDebug(this AzureSigImageDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings SetHelp(this AzureSigImageDefinitionUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings ResetHelp(this AzureSigImageDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings SetOutput(this AzureSigImageDefinitionUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings ResetOutput(this AzureSigImageDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings SetQuery(this AzureSigImageDefinitionUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings ResetQuery(this AzureSigImageDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageDefinitionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings SetVerbose(this AzureSigImageDefinitionUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageDefinitionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageDefinitionUpdateSettings ResetVerbose(this AzureSigImageDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigImageVersionCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigImageVersionCreateSettingsExtensions
    {
        #region GalleryImageDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetGalleryImageDefinition(this AzureSigImageVersionCreateSettings toolSettings, string galleryImageDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = galleryImageDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetGalleryImageDefinition(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = null;
            return toolSettings;
        }
        #endregion
        #region GalleryImageVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.GalleryImageVersion"/></em></p>
        ///   <p>Gallery image version in semantic version pattern. The allowed characters are digit and period. Digits must be within the range of a 32-bit integer, e.g. &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetGalleryImageVersion(this AzureSigImageVersionCreateSettings toolSettings, string galleryImageVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageVersion = galleryImageVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.GalleryImageVersion"/></em></p>
        ///   <p>Gallery image version in semantic version pattern. The allowed characters are digit and period. Digits must be within the range of a 32-bit integer, e.g. &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetGalleryImageVersion(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageVersion = null;
            return toolSettings;
        }
        #endregion
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetGalleryName(this AzureSigImageVersionCreateSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetGalleryName(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region ManagedImage
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.ManagedImage"/></em></p>
        ///   <p>Image name(if in the same resource group) or resource id.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetManagedImage(this AzureSigImageVersionCreateSettings toolSettings, string managedImage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagedImage = managedImage;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.ManagedImage"/></em></p>
        ///   <p>Image name(if in the same resource group) or resource id.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetManagedImage(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagedImage = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetResourceGroup(this AzureSigImageVersionCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetResourceGroup(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region EndOfLifeDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.EndOfLifeDate"/></em></p>
        ///   <p>The end of life date, e.g. '2020-12-31'.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetEndOfLifeDate(this AzureSigImageVersionCreateSettings toolSettings, string endOfLifeDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndOfLifeDate = endOfLifeDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.EndOfLifeDate"/></em></p>
        ///   <p>The end of life date, e.g. '2020-12-31'.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetEndOfLifeDate(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndOfLifeDate = null;
            return toolSettings;
        }
        #endregion
        #region ExcludeFromLatest
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.ExcludeFromLatest"/></em></p>
        ///   <p>The flag means that if it is set to true, people deploying VMs with version omitted will not use this version.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetExcludeFromLatest(this AzureSigImageVersionCreateSettings toolSettings, bool? excludeFromLatest)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExcludeFromLatest = excludeFromLatest;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.ExcludeFromLatest"/></em></p>
        ///   <p>The flag means that if it is set to true, people deploying VMs with version omitted will not use this version.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetExcludeFromLatest(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExcludeFromLatest = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureSigImageVersionCreateSettings.ExcludeFromLatest"/></em></p>
        ///   <p>The flag means that if it is set to true, people deploying VMs with version omitted will not use this version.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings EnableExcludeFromLatest(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExcludeFromLatest = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureSigImageVersionCreateSettings.ExcludeFromLatest"/></em></p>
        ///   <p>The flag means that if it is set to true, people deploying VMs with version omitted will not use this version.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings DisableExcludeFromLatest(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExcludeFromLatest = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureSigImageVersionCreateSettings.ExcludeFromLatest"/></em></p>
        ///   <p>The flag means that if it is set to true, people deploying VMs with version omitted will not use this version.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ToggleExcludeFromLatest(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExcludeFromLatest = !toolSettings.ExcludeFromLatest;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetLocation(this AzureSigImageVersionCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetLocation(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetNoWait(this AzureSigImageVersionCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetNoWait(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureSigImageVersionCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings EnableNoWait(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureSigImageVersionCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings DisableNoWait(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureSigImageVersionCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ToggleNoWait(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region ReplicaCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.ReplicaCount"/></em></p>
        ///   <p>The default number of replicas to be created per region. To set regional replication counts, use --target-regions.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetReplicaCount(this AzureSigImageVersionCreateSettings toolSettings, string replicaCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplicaCount = replicaCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.ReplicaCount"/></em></p>
        ///   <p>The default number of replicas to be created per region. To set regional replication counts, use --target-regions.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetReplicaCount(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplicaCount = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.StorageAccountType"/></em></p>
        ///   <p>The default storage account type to be used per region. To set regional storage account types, use --target-regions.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetStorageAccountType(this AzureSigImageVersionCreateSettings toolSettings, SigImageVersionCreateStorageAccountType storageAccountType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountType = storageAccountType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.StorageAccountType"/></em></p>
        ///   <p>The default storage account type to be used per region. To set regional storage account types, use --target-regions.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetStorageAccountType(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountType = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetTags(this AzureSigImageVersionCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetTags(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region TargetRegions
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.TargetRegions"/> to a new list</em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetTargetRegions(this AzureSigImageVersionCreateSettings toolSettings, params string[] targetRegions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetRegionsInternal = targetRegions.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.TargetRegions"/> to a new list</em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetTargetRegions(this AzureSigImageVersionCreateSettings toolSettings, IEnumerable<string> targetRegions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetRegionsInternal = targetRegions.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSigImageVersionCreateSettings.TargetRegions"/></em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings AddTargetRegions(this AzureSigImageVersionCreateSettings toolSettings, params string[] targetRegions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetRegionsInternal.AddRange(targetRegions);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSigImageVersionCreateSettings.TargetRegions"/></em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings AddTargetRegions(this AzureSigImageVersionCreateSettings toolSettings, IEnumerable<string> targetRegions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetRegionsInternal.AddRange(targetRegions);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSigImageVersionCreateSettings.TargetRegions"/></em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ClearTargetRegions(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetRegionsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSigImageVersionCreateSettings.TargetRegions"/></em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings RemoveTargetRegions(this AzureSigImageVersionCreateSettings toolSettings, params string[] targetRegions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(targetRegions);
            toolSettings.TargetRegionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSigImageVersionCreateSettings.TargetRegions"/></em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings RemoveTargetRegions(this AzureSigImageVersionCreateSettings toolSettings, IEnumerable<string> targetRegions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(targetRegions);
            toolSettings.TargetRegionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetSubscription(this AzureSigImageVersionCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetSubscription(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetDebug(this AzureSigImageVersionCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetDebug(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetHelp(this AzureSigImageVersionCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetHelp(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetOutput(this AzureSigImageVersionCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetOutput(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetQuery(this AzureSigImageVersionCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetQuery(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings SetVerbose(this AzureSigImageVersionCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionCreateSettings ResetVerbose(this AzureSigImageVersionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigImageVersionDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigImageVersionDeleteSettingsExtensions
    {
        #region GalleryImageDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionDeleteSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings SetGalleryImageDefinition(this AzureSigImageVersionDeleteSettings toolSettings, string galleryImageDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = galleryImageDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionDeleteSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings ResetGalleryImageDefinition(this AzureSigImageVersionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = null;
            return toolSettings;
        }
        #endregion
        #region GalleryImageVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionDeleteSettings.GalleryImageVersion"/></em></p>
        ///   <p>The name of the gallery Image Version to be deleted.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings SetGalleryImageVersion(this AzureSigImageVersionDeleteSettings toolSettings, string galleryImageVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageVersion = galleryImageVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionDeleteSettings.GalleryImageVersion"/></em></p>
        ///   <p>The name of the gallery Image Version to be deleted.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings ResetGalleryImageVersion(this AzureSigImageVersionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageVersion = null;
            return toolSettings;
        }
        #endregion
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionDeleteSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings SetGalleryName(this AzureSigImageVersionDeleteSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionDeleteSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings ResetGalleryName(this AzureSigImageVersionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings SetResourceGroup(this AzureSigImageVersionDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings ResetResourceGroup(this AzureSigImageVersionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings SetSubscription(this AzureSigImageVersionDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings ResetSubscription(this AzureSigImageVersionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings SetDebug(this AzureSigImageVersionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings ResetDebug(this AzureSigImageVersionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings SetHelp(this AzureSigImageVersionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings ResetHelp(this AzureSigImageVersionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings SetOutput(this AzureSigImageVersionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings ResetOutput(this AzureSigImageVersionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings SetQuery(this AzureSigImageVersionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings ResetQuery(this AzureSigImageVersionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings SetVerbose(this AzureSigImageVersionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionDeleteSettings ResetVerbose(this AzureSigImageVersionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigImageVersionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigImageVersionListSettingsExtensions
    {
        #region GalleryImageDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionListSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings SetGalleryImageDefinition(this AzureSigImageVersionListSettings toolSettings, string galleryImageDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = galleryImageDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionListSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings ResetGalleryImageDefinition(this AzureSigImageVersionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = null;
            return toolSettings;
        }
        #endregion
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionListSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings SetGalleryName(this AzureSigImageVersionListSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionListSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings ResetGalleryName(this AzureSigImageVersionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings SetResourceGroup(this AzureSigImageVersionListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings ResetResourceGroup(this AzureSigImageVersionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings SetSubscription(this AzureSigImageVersionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings ResetSubscription(this AzureSigImageVersionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings SetDebug(this AzureSigImageVersionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings ResetDebug(this AzureSigImageVersionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings SetHelp(this AzureSigImageVersionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings ResetHelp(this AzureSigImageVersionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings SetOutput(this AzureSigImageVersionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings ResetOutput(this AzureSigImageVersionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings SetQuery(this AzureSigImageVersionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings ResetQuery(this AzureSigImageVersionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings SetVerbose(this AzureSigImageVersionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionListSettings ResetVerbose(this AzureSigImageVersionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigImageVersionShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigImageVersionShowSettingsExtensions
    {
        #region GalleryImageDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionShowSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings SetGalleryImageDefinition(this AzureSigImageVersionShowSettings toolSettings, string galleryImageDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = galleryImageDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionShowSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings ResetGalleryImageDefinition(this AzureSigImageVersionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = null;
            return toolSettings;
        }
        #endregion
        #region GalleryImageVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionShowSettings.GalleryImageVersion"/></em></p>
        ///   <p>The name of the gallery Image Version to be retrieved.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings SetGalleryImageVersion(this AzureSigImageVersionShowSettings toolSettings, string galleryImageVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageVersion = galleryImageVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionShowSettings.GalleryImageVersion"/></em></p>
        ///   <p>The name of the gallery Image Version to be retrieved.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings ResetGalleryImageVersion(this AzureSigImageVersionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageVersion = null;
            return toolSettings;
        }
        #endregion
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionShowSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings SetGalleryName(this AzureSigImageVersionShowSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionShowSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings ResetGalleryName(this AzureSigImageVersionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings SetResourceGroup(this AzureSigImageVersionShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings ResetResourceGroup(this AzureSigImageVersionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionShowSettings.Expand"/></em></p>
        ///   <p>The expand expression to apply on the operation, e.g. 'ReplicationStatus'.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings SetExpand(this AzureSigImageVersionShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionShowSettings.Expand"/></em></p>
        ///   <p>The expand expression to apply on the operation, e.g. 'ReplicationStatus'.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings ResetExpand(this AzureSigImageVersionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings SetSubscription(this AzureSigImageVersionShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings ResetSubscription(this AzureSigImageVersionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings SetDebug(this AzureSigImageVersionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings ResetDebug(this AzureSigImageVersionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings SetHelp(this AzureSigImageVersionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings ResetHelp(this AzureSigImageVersionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings SetOutput(this AzureSigImageVersionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings ResetOutput(this AzureSigImageVersionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings SetQuery(this AzureSigImageVersionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings ResetQuery(this AzureSigImageVersionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings SetVerbose(this AzureSigImageVersionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionShowSettings ResetVerbose(this AzureSigImageVersionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigImageVersionUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigImageVersionUpdateSettingsExtensions
    {
        #region GalleryImageDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetGalleryImageDefinition(this AzureSigImageVersionUpdateSettings toolSettings, string galleryImageDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = galleryImageDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetGalleryImageDefinition(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = null;
            return toolSettings;
        }
        #endregion
        #region GalleryImageVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.GalleryImageVersion"/></em></p>
        ///   <p>The name of the gallery Image Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetGalleryImageVersion(this AzureSigImageVersionUpdateSettings toolSettings, string galleryImageVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageVersion = galleryImageVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.GalleryImageVersion"/></em></p>
        ///   <p>The name of the gallery Image Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetGalleryImageVersion(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageVersion = null;
            return toolSettings;
        }
        #endregion
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetGalleryName(this AzureSigImageVersionUpdateSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetGalleryName(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetResourceGroup(this AzureSigImageVersionUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetResourceGroup(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetNoWait(this AzureSigImageVersionUpdateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetNoWait(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureSigImageVersionUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings EnableNoWait(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureSigImageVersionUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings DisableNoWait(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureSigImageVersionUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ToggleNoWait(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region ReplicaCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.ReplicaCount"/></em></p>
        ///   <p>The default number of replicas to be created per region. To set regional replication counts, use --target-regions.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetReplicaCount(this AzureSigImageVersionUpdateSettings toolSettings, string replicaCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplicaCount = replicaCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.ReplicaCount"/></em></p>
        ///   <p>The default number of replicas to be created per region. To set regional replication counts, use --target-regions.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetReplicaCount(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplicaCount = null;
            return toolSettings;
        }
        #endregion
        #region TargetRegions
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.TargetRegions"/> to a new list</em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetTargetRegions(this AzureSigImageVersionUpdateSettings toolSettings, params string[] targetRegions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetRegionsInternal = targetRegions.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.TargetRegions"/> to a new list</em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetTargetRegions(this AzureSigImageVersionUpdateSettings toolSettings, IEnumerable<string> targetRegions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetRegionsInternal = targetRegions.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSigImageVersionUpdateSettings.TargetRegions"/></em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings AddTargetRegions(this AzureSigImageVersionUpdateSettings toolSettings, params string[] targetRegions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetRegionsInternal.AddRange(targetRegions);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSigImageVersionUpdateSettings.TargetRegions"/></em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings AddTargetRegions(this AzureSigImageVersionUpdateSettings toolSettings, IEnumerable<string> targetRegions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetRegionsInternal.AddRange(targetRegions);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSigImageVersionUpdateSettings.TargetRegions"/></em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ClearTargetRegions(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetRegionsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSigImageVersionUpdateSettings.TargetRegions"/></em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings RemoveTargetRegions(this AzureSigImageVersionUpdateSettings toolSettings, params string[] targetRegions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(targetRegions);
            toolSettings.TargetRegionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSigImageVersionUpdateSettings.TargetRegions"/></em></p>
        ///   <p>Space-separated list of regions and their replica counts. Use "&lt;region&gt;[=&lt;replica count&gt;][=&lt;storage account type&gt;]" to optionally set the replica count and/or storage account type for each region. If a replica count is not specified, the default replica count will be used. If a storage account type is not specified, the default storage account type will be used.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings RemoveTargetRegions(this AzureSigImageVersionUpdateSettings toolSettings, IEnumerable<string> targetRegions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(targetRegions);
            toolSettings.TargetRegionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetAdd(this AzureSigImageVersionUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetAdd(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetForceString(this AzureSigImageVersionUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetForceString(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetRemove(this AzureSigImageVersionUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetRemove(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetSet(this AzureSigImageVersionUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetSet(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetSubscription(this AzureSigImageVersionUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetSubscription(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetDebug(this AzureSigImageVersionUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetDebug(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetHelp(this AzureSigImageVersionUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetHelp(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetOutput(this AzureSigImageVersionUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetOutput(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetQuery(this AzureSigImageVersionUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetQuery(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings SetVerbose(this AzureSigImageVersionUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionUpdateSettings ResetVerbose(this AzureSigImageVersionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSigImageVersionWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSigImageVersionWaitSettingsExtensions
    {
        #region GalleryImageDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetGalleryImageDefinition(this AzureSigImageVersionWaitSettings toolSettings, string galleryImageDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = galleryImageDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Gallery image definition.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetGalleryImageDefinition(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = null;
            return toolSettings;
        }
        #endregion
        #region GalleryImageVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.GalleryImageVersion"/></em></p>
        ///   <p>The name of the gallery Image Version to be retrieved.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetGalleryImageVersion(this AzureSigImageVersionWaitSettings toolSettings, string galleryImageVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageVersion = galleryImageVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.GalleryImageVersion"/></em></p>
        ///   <p>The name of the gallery Image Version to be retrieved.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetGalleryImageVersion(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageVersion = null;
            return toolSettings;
        }
        #endregion
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetGalleryName(this AzureSigImageVersionWaitSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.GalleryName"/></em></p>
        ///   <p>Gallery name.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetGalleryName(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetResourceGroup(this AzureSigImageVersionWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetResourceGroup(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Expand"/></em></p>
        ///   <p>The expand expression to apply on the operation.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetExpand(this AzureSigImageVersionWaitSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Expand"/></em></p>
        ///   <p>The expand expression to apply on the operation.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetExpand(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetCreated(this AzureSigImageVersionWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetCreated(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetCustom(this AzureSigImageVersionWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetCustom(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetDeleted(this AzureSigImageVersionWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetDeleted(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetExists(this AzureSigImageVersionWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetExists(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetInterval(this AzureSigImageVersionWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetInterval(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetTimeout(this AzureSigImageVersionWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetTimeout(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetUpdated(this AzureSigImageVersionWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetUpdated(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetSubscription(this AzureSigImageVersionWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetSubscription(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetDebug(this AzureSigImageVersionWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetDebug(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetHelp(this AzureSigImageVersionWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetHelp(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetOutput(this AzureSigImageVersionWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetOutput(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetQuery(this AzureSigImageVersionWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetQuery(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSigImageVersionWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings SetVerbose(this AzureSigImageVersionWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSigImageVersionWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSigImageVersionWaitSettings ResetVerbose(this AzureSigImageVersionWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region SigImageDefinitionCreateOsType
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<SigImageDefinitionCreateOsType>))]
    public partial class SigImageDefinitionCreateOsType : Enumeration
    {
        public static SigImageDefinitionCreateOsType linux = new SigImageDefinitionCreateOsType { Value = "linux" };
        public static SigImageDefinitionCreateOsType windows = new SigImageDefinitionCreateOsType { Value = "windows" };
    }
    #endregion
    #region SigImageVersionCreateStorageAccountType
    /// <summary>
    ///   Used within <see cref="AzureSigTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<SigImageVersionCreateStorageAccountType>))]
    public partial class SigImageVersionCreateStorageAccountType : Enumeration
    {
        public static SigImageVersionCreateStorageAccountType standard_lrs = new SigImageVersionCreateStorageAccountType { Value = "standard_lrs" };
        public static SigImageVersionCreateStorageAccountType standard_zrs = new SigImageVersionCreateStorageAccountType { Value = "standard_zrs" };
    }
    #endregion
}
