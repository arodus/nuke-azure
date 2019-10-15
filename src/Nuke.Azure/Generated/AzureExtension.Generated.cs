// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureExtension.json
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
    public static partial class AzureExtensionTasks
    {
        /// <summary>
        ///   Path to the AzureExtension executable.
        /// </summary>
        public static string AzureExtensionPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREEXTENSION_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureExtensionLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage and update CLI extensions.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureExtension(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureExtensionPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureExtensionLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureExtensionAdd(AzureExtensionAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureExtensionAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureExtensionAddSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureExtensionAddSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureExtensionAddSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureExtensionAddSettings.Output"/></li>
        ///     <li><c>--pip-extra-index-urls</c> via <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/></li>
        ///     <li><c>--pip-proxy</c> via <see cref="AzureExtensionAddSettings.PipProxy"/></li>
        ///     <li><c>--query</c> via <see cref="AzureExtensionAddSettings.Query"/></li>
        ///     <li><c>--source</c> via <see cref="AzureExtensionAddSettings.Source"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureExtensionAddSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureExtensionAddSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureExtensionAdd(Configure<AzureExtensionAddSettings> configurator)
        {
            return AzureExtensionAdd(configurator(new AzureExtensionAddSettings()));
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureExtensionAddSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureExtensionAddSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureExtensionAddSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureExtensionAddSettings.Output"/></li>
        ///     <li><c>--pip-extra-index-urls</c> via <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/></li>
        ///     <li><c>--pip-proxy</c> via <see cref="AzureExtensionAddSettings.PipProxy"/></li>
        ///     <li><c>--query</c> via <see cref="AzureExtensionAddSettings.Query"/></li>
        ///     <li><c>--source</c> via <see cref="AzureExtensionAddSettings.Source"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureExtensionAddSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureExtensionAddSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureExtensionAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureExtensionAdd(CombinatorialConfigure<AzureExtensionAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureExtensionAdd, AzureExtensionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureExtensionList(AzureExtensionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureExtensionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureExtensionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureExtensionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureExtensionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureExtensionListSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureExtensionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureExtensionList(Configure<AzureExtensionListSettings> configurator)
        {
            return AzureExtensionList(configurator(new AzureExtensionListSettings()));
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureExtensionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureExtensionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureExtensionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureExtensionListSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureExtensionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureExtensionListSettings Settings, IReadOnlyCollection<Output> Output)> AzureExtensionList(CombinatorialConfigure<AzureExtensionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureExtensionList, AzureExtensionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureExtensionListAvailable(AzureExtensionListAvailableSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureExtensionListAvailableSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureExtensionListAvailableSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureExtensionListAvailableSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureExtensionListAvailableSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureExtensionListAvailableSettings.Query"/></li>
        ///     <li><c>--show-details</c> via <see cref="AzureExtensionListAvailableSettings.ShowDetails"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureExtensionListAvailableSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureExtensionListAvailable(Configure<AzureExtensionListAvailableSettings> configurator)
        {
            return AzureExtensionListAvailable(configurator(new AzureExtensionListAvailableSettings()));
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureExtensionListAvailableSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureExtensionListAvailableSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureExtensionListAvailableSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureExtensionListAvailableSettings.Query"/></li>
        ///     <li><c>--show-details</c> via <see cref="AzureExtensionListAvailableSettings.ShowDetails"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureExtensionListAvailableSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureExtensionListAvailableSettings Settings, IReadOnlyCollection<Output> Output)> AzureExtensionListAvailable(CombinatorialConfigure<AzureExtensionListAvailableSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureExtensionListAvailable, AzureExtensionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureExtensionRemove(AzureExtensionRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureExtensionRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureExtensionRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureExtensionRemoveSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureExtensionRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureExtensionRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureExtensionRemoveSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureExtensionRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureExtensionRemove(Configure<AzureExtensionRemoveSettings> configurator)
        {
            return AzureExtensionRemove(configurator(new AzureExtensionRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureExtensionRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureExtensionRemoveSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureExtensionRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureExtensionRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureExtensionRemoveSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureExtensionRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureExtensionRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureExtensionRemove(CombinatorialConfigure<AzureExtensionRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureExtensionRemove, AzureExtensionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureExtensionShow(AzureExtensionShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureExtensionShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureExtensionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureExtensionShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureExtensionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureExtensionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureExtensionShowSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureExtensionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureExtensionShow(Configure<AzureExtensionShowSettings> configurator)
        {
            return AzureExtensionShow(configurator(new AzureExtensionShowSettings()));
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureExtensionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureExtensionShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureExtensionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureExtensionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureExtensionShowSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureExtensionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureExtensionShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureExtensionShow(CombinatorialConfigure<AzureExtensionShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureExtensionShow, AzureExtensionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureExtensionUpdate(AzureExtensionUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureExtensionUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureExtensionUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureExtensionUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureExtensionUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureExtensionUpdateSettings.Output"/></li>
        ///     <li><c>--pip-extra-index-urls</c> via <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/></li>
        ///     <li><c>--pip-proxy</c> via <see cref="AzureExtensionUpdateSettings.PipProxy"/></li>
        ///     <li><c>--query</c> via <see cref="AzureExtensionUpdateSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureExtensionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureExtensionUpdate(Configure<AzureExtensionUpdateSettings> configurator)
        {
            return AzureExtensionUpdate(configurator(new AzureExtensionUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage and update CLI extensions.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureExtensionUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureExtensionUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureExtensionUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureExtensionUpdateSettings.Output"/></li>
        ///     <li><c>--pip-extra-index-urls</c> via <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/></li>
        ///     <li><c>--pip-proxy</c> via <see cref="AzureExtensionUpdateSettings.PipProxy"/></li>
        ///     <li><c>--query</c> via <see cref="AzureExtensionUpdateSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureExtensionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureExtensionUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureExtensionUpdate(CombinatorialConfigure<AzureExtensionUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureExtensionUpdate, AzureExtensionLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureExtensionAddSettings
    /// <summary>
    ///   Used within <see cref="AzureExtensionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureExtensionAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureExtension executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureExtensionTasks.AzureExtensionPath;
        public override Action<OutputType, string> CustomLogger => AzureExtensionTasks.AzureExtensionLogger;
        /// <summary>
        ///   Name of extension.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Filepath or URL to an extension.
        /// </summary>
        public virtual string Source { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
        /// <summary>
        ///   Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.
        /// </summary>
        public virtual IReadOnlyList<string> PipExtraIndexUrls => PipExtraIndexUrlsInternal.AsReadOnly();
        internal List<string> PipExtraIndexUrlsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Proxy for pip to use for extension dependencies in the form of [user:passwd@]proxy.server:port.
        /// </summary>
        public virtual string PipProxy { get; internal set; }
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
              .Add("extension add")
              .Add("--name {value}", Name)
              .Add("--source {value}", Source)
              .Add("--yes {value}", Yes)
              .Add("--pip-extra-index-urls {value}", PipExtraIndexUrls, separator: ' ')
              .Add("--pip-proxy {value}", PipProxy)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureExtensionListSettings
    /// <summary>
    ///   Used within <see cref="AzureExtensionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureExtensionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureExtension executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureExtensionTasks.AzureExtensionPath;
        public override Action<OutputType, string> CustomLogger => AzureExtensionTasks.AzureExtensionLogger;
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
              .Add("extension list")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureExtensionListAvailableSettings
    /// <summary>
    ///   Used within <see cref="AzureExtensionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureExtensionListAvailableSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureExtension executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureExtensionTasks.AzureExtensionPath;
        public override Action<OutputType, string> CustomLogger => AzureExtensionTasks.AzureExtensionLogger;
        /// <summary>
        ///   Show the raw data from the extension index.
        /// </summary>
        public virtual bool? ShowDetails { get; internal set; }
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
              .Add("extension list-available")
              .Add("--show-details", ShowDetails)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureExtensionRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureExtensionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureExtensionRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureExtension executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureExtensionTasks.AzureExtensionPath;
        public override Action<OutputType, string> CustomLogger => AzureExtensionTasks.AzureExtensionLogger;
        /// <summary>
        ///   Name of extension.
        /// </summary>
        public virtual string Name { get; internal set; }
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
              .Add("extension remove")
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
    #region AzureExtensionShowSettings
    /// <summary>
    ///   Used within <see cref="AzureExtensionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureExtensionShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureExtension executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureExtensionTasks.AzureExtensionPath;
        public override Action<OutputType, string> CustomLogger => AzureExtensionTasks.AzureExtensionLogger;
        /// <summary>
        ///   Name of extension.
        /// </summary>
        public virtual string Name { get; internal set; }
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
              .Add("extension show")
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
    #region AzureExtensionUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureExtensionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureExtensionUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureExtension executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureExtensionTasks.AzureExtensionPath;
        public override Action<OutputType, string> CustomLogger => AzureExtensionTasks.AzureExtensionLogger;
        /// <summary>
        ///   Name of extension.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.
        /// </summary>
        public virtual IReadOnlyList<string> PipExtraIndexUrls => PipExtraIndexUrlsInternal.AsReadOnly();
        internal List<string> PipExtraIndexUrlsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Proxy for pip to use for extension dependencies in the form of [user:passwd@]proxy.server:port.
        /// </summary>
        public virtual string PipProxy { get; internal set; }
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
              .Add("extension update")
              .Add("--name {value}", Name)
              .Add("--pip-extra-index-urls {value}", PipExtraIndexUrls, separator: ' ')
              .Add("--pip-proxy {value}", PipProxy)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureExtensionAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureExtensionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureExtensionAddSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionAddSettings.Name"/></em></p>
        ///   <p>Name of extension.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings SetName(this AzureExtensionAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionAddSettings.Name"/></em></p>
        ///   <p>Name of extension.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings ResetName(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Source
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionAddSettings.Source"/></em></p>
        ///   <p>Filepath or URL to an extension.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings SetSource(this AzureExtensionAddSettings toolSettings, string source)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = source;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionAddSettings.Source"/></em></p>
        ///   <p>Filepath or URL to an extension.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings ResetSource(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionAddSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings SetYes(this AzureExtensionAddSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionAddSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings ResetYes(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region PipExtraIndexUrls
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/> to a new list</em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings SetPipExtraIndexUrls(this AzureExtensionAddSettings toolSettings, params string[] pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal = pipExtraIndexUrls.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/> to a new list</em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings SetPipExtraIndexUrls(this AzureExtensionAddSettings toolSettings, IEnumerable<string> pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal = pipExtraIndexUrls.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/></em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings AddPipExtraIndexUrls(this AzureExtensionAddSettings toolSettings, params string[] pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal.AddRange(pipExtraIndexUrls);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/></em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings AddPipExtraIndexUrls(this AzureExtensionAddSettings toolSettings, IEnumerable<string> pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal.AddRange(pipExtraIndexUrls);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/></em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings ClearPipExtraIndexUrls(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/></em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings RemovePipExtraIndexUrls(this AzureExtensionAddSettings toolSettings, params string[] pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(pipExtraIndexUrls);
            toolSettings.PipExtraIndexUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/></em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings RemovePipExtraIndexUrls(this AzureExtensionAddSettings toolSettings, IEnumerable<string> pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(pipExtraIndexUrls);
            toolSettings.PipExtraIndexUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region PipProxy
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionAddSettings.PipProxy"/></em></p>
        ///   <p>Proxy for pip to use for extension dependencies in the form of [user:passwd@]proxy.server:port.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings SetPipProxy(this AzureExtensionAddSettings toolSettings, string pipProxy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipProxy = pipProxy;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionAddSettings.PipProxy"/></em></p>
        ///   <p>Proxy for pip to use for extension dependencies in the form of [user:passwd@]proxy.server:port.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings ResetPipProxy(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipProxy = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings SetDebug(this AzureExtensionAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings ResetDebug(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings SetHelp(this AzureExtensionAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings ResetHelp(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings SetOutput(this AzureExtensionAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings ResetOutput(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings SetQuery(this AzureExtensionAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings ResetQuery(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings SetVerbose(this AzureExtensionAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionAddSettings ResetVerbose(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureExtensionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureExtensionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureExtensionListSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListSettings SetDebug(this AzureExtensionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListSettings ResetDebug(this AzureExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListSettings SetHelp(this AzureExtensionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListSettings ResetHelp(this AzureExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListSettings SetOutput(this AzureExtensionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListSettings ResetOutput(this AzureExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListSettings SetQuery(this AzureExtensionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListSettings ResetQuery(this AzureExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListSettings SetVerbose(this AzureExtensionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListSettings ResetVerbose(this AzureExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureExtensionListAvailableSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureExtensionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureExtensionListAvailableSettingsExtensions
    {
        #region ShowDetails
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionListAvailableSettings.ShowDetails"/></em></p>
        ///   <p>Show the raw data from the extension index.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings SetShowDetails(this AzureExtensionListAvailableSettings toolSettings, bool? showDetails)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = showDetails;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionListAvailableSettings.ShowDetails"/></em></p>
        ///   <p>Show the raw data from the extension index.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ResetShowDetails(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureExtensionListAvailableSettings.ShowDetails"/></em></p>
        ///   <p>Show the raw data from the extension index.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings EnableShowDetails(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureExtensionListAvailableSettings.ShowDetails"/></em></p>
        ///   <p>Show the raw data from the extension index.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings DisableShowDetails(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureExtensionListAvailableSettings.ShowDetails"/></em></p>
        ///   <p>Show the raw data from the extension index.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ToggleShowDetails(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = !toolSettings.ShowDetails;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionListAvailableSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings SetDebug(this AzureExtensionListAvailableSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionListAvailableSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ResetDebug(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionListAvailableSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings SetHelp(this AzureExtensionListAvailableSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionListAvailableSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ResetHelp(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionListAvailableSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings SetOutput(this AzureExtensionListAvailableSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionListAvailableSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ResetOutput(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionListAvailableSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings SetQuery(this AzureExtensionListAvailableSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionListAvailableSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ResetQuery(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionListAvailableSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings SetVerbose(this AzureExtensionListAvailableSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionListAvailableSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ResetVerbose(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureExtensionRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureExtensionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureExtensionRemoveSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionRemoveSettings.Name"/></em></p>
        ///   <p>Name of extension.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionRemoveSettings SetName(this AzureExtensionRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionRemoveSettings.Name"/></em></p>
        ///   <p>Name of extension.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionRemoveSettings ResetName(this AzureExtensionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionRemoveSettings SetDebug(this AzureExtensionRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionRemoveSettings ResetDebug(this AzureExtensionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionRemoveSettings SetHelp(this AzureExtensionRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionRemoveSettings ResetHelp(this AzureExtensionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionRemoveSettings SetOutput(this AzureExtensionRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionRemoveSettings ResetOutput(this AzureExtensionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionRemoveSettings SetQuery(this AzureExtensionRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionRemoveSettings ResetQuery(this AzureExtensionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionRemoveSettings SetVerbose(this AzureExtensionRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionRemoveSettings ResetVerbose(this AzureExtensionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureExtensionShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureExtensionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureExtensionShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionShowSettings.Name"/></em></p>
        ///   <p>Name of extension.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionShowSettings SetName(this AzureExtensionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionShowSettings.Name"/></em></p>
        ///   <p>Name of extension.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionShowSettings ResetName(this AzureExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionShowSettings SetDebug(this AzureExtensionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionShowSettings ResetDebug(this AzureExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionShowSettings SetHelp(this AzureExtensionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionShowSettings ResetHelp(this AzureExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionShowSettings SetOutput(this AzureExtensionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionShowSettings ResetOutput(this AzureExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionShowSettings SetQuery(this AzureExtensionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionShowSettings ResetQuery(this AzureExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionShowSettings SetVerbose(this AzureExtensionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionShowSettings ResetVerbose(this AzureExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureExtensionUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureExtensionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureExtensionUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionUpdateSettings.Name"/></em></p>
        ///   <p>Name of extension.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetName(this AzureExtensionUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionUpdateSettings.Name"/></em></p>
        ///   <p>Name of extension.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetName(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PipExtraIndexUrls
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/> to a new list</em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetPipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings, params string[] pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal = pipExtraIndexUrls.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/> to a new list</em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetPipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings, IEnumerable<string> pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal = pipExtraIndexUrls.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/></em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings AddPipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings, params string[] pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal.AddRange(pipExtraIndexUrls);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/></em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings AddPipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings, IEnumerable<string> pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal.AddRange(pipExtraIndexUrls);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/></em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings ClearPipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/></em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings RemovePipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings, params string[] pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(pipExtraIndexUrls);
            toolSettings.PipExtraIndexUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/></em></p>
        ///   <p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings RemovePipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings, IEnumerable<string> pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(pipExtraIndexUrls);
            toolSettings.PipExtraIndexUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region PipProxy
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionUpdateSettings.PipProxy"/></em></p>
        ///   <p>Proxy for pip to use for extension dependencies in the form of [user:passwd@]proxy.server:port.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetPipProxy(this AzureExtensionUpdateSettings toolSettings, string pipProxy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipProxy = pipProxy;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionUpdateSettings.PipProxy"/></em></p>
        ///   <p>Proxy for pip to use for extension dependencies in the form of [user:passwd@]proxy.server:port.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetPipProxy(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipProxy = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetDebug(this AzureExtensionUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetDebug(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetHelp(this AzureExtensionUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetHelp(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetOutput(this AzureExtensionUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetOutput(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetQuery(this AzureExtensionUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetQuery(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureExtensionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetVerbose(this AzureExtensionUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureExtensionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetVerbose(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
