// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzureMaps.json
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
    public static partial class AzureMapsTasks
    {
        /// <summary>
        ///   Path to the AzureMaps executable.
        /// </summary>
        public static string AzureMapsPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREMAPS_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureMapsLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Maps.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMaps(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureMapsPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureMapsLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMaps(AzureMapsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMapsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMapsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMaps(Configure<AzureMapsSettings> configurator)
        {
            return AzureMaps(configurator(new AzureMapsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMapsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMapsSettings Settings, IReadOnlyCollection<Output> Output)> AzureMaps(CombinatorialConfigure<AzureMapsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMaps, AzureMapsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMapsAccountCreate(AzureMapsAccountCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMapsAccountCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--accept-tos</c> via <see cref="AzureMapsAccountCreateSettings.AcceptTos"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMapsAccountCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureMapsAccountCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureMapsAccountCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMapsAccountCreate(Configure<AzureMapsAccountCreateSettings> configurator)
        {
            return AzureMapsAccountCreate(configurator(new AzureMapsAccountCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--accept-tos</c> via <see cref="AzureMapsAccountCreateSettings.AcceptTos"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMapsAccountCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureMapsAccountCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureMapsAccountCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMapsAccountCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMapsAccountCreate(CombinatorialConfigure<AzureMapsAccountCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMapsAccountCreate, AzureMapsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMapsAccountDelete(AzureMapsAccountDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMapsAccountDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMapsAccountDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMapsAccountDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMapsAccountDelete(Configure<AzureMapsAccountDeleteSettings> configurator)
        {
            return AzureMapsAccountDelete(configurator(new AzureMapsAccountDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMapsAccountDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMapsAccountDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMapsAccountDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureMapsAccountDelete(CombinatorialConfigure<AzureMapsAccountDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMapsAccountDelete, AzureMapsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMapsAccountList(AzureMapsAccountListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMapsAccountListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMapsAccountList(Configure<AzureMapsAccountListSettings> configurator)
        {
            return AzureMapsAccountList(configurator(new AzureMapsAccountListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMapsAccountListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMapsAccountList(CombinatorialConfigure<AzureMapsAccountListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMapsAccountList, AzureMapsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMapsAccountShow(AzureMapsAccountShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMapsAccountShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMapsAccountShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMapsAccountShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMapsAccountShow(Configure<AzureMapsAccountShowSettings> configurator)
        {
            return AzureMapsAccountShow(configurator(new AzureMapsAccountShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMapsAccountShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMapsAccountShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMapsAccountShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureMapsAccountShow(CombinatorialConfigure<AzureMapsAccountShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMapsAccountShow, AzureMapsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMapsAccountUpdate(AzureMapsAccountUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMapsAccountUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMapsAccountUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMapsAccountUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMapsAccountUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMapsAccountUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMapsAccountUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMapsAccountUpdateSettings.Set"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureMapsAccountUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureMapsAccountUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMapsAccountUpdate(Configure<AzureMapsAccountUpdateSettings> configurator)
        {
            return AzureMapsAccountUpdate(configurator(new AzureMapsAccountUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMapsAccountUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMapsAccountUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMapsAccountUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMapsAccountUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMapsAccountUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMapsAccountUpdateSettings.Set"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureMapsAccountUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureMapsAccountUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMapsAccountUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMapsAccountUpdate(CombinatorialConfigure<AzureMapsAccountUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMapsAccountUpdate, AzureMapsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMapsAccountKeysList(AzureMapsAccountKeysListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMapsAccountKeysListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountKeysListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountKeysListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMapsAccountKeysListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountKeysListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountKeysListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountKeysListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountKeysListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountKeysListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMapsAccountKeysList(Configure<AzureMapsAccountKeysListSettings> configurator)
        {
            return AzureMapsAccountKeysList(configurator(new AzureMapsAccountKeysListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountKeysListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountKeysListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMapsAccountKeysListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountKeysListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountKeysListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountKeysListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountKeysListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountKeysListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMapsAccountKeysListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMapsAccountKeysList(CombinatorialConfigure<AzureMapsAccountKeysListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMapsAccountKeysList, AzureMapsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMapsAccountKeysRenew(AzureMapsAccountKeysRenewSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMapsAccountKeysRenewSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountKeysRenewSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountKeysRenewSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureMapsAccountKeysRenewSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMapsAccountKeysRenewSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountKeysRenewSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountKeysRenewSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountKeysRenewSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountKeysRenewSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountKeysRenewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMapsAccountKeysRenew(Configure<AzureMapsAccountKeysRenewSettings> configurator)
        {
            return AzureMapsAccountKeysRenew(configurator(new AzureMapsAccountKeysRenewSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Maps.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/maps?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMapsAccountKeysRenewSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMapsAccountKeysRenewSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureMapsAccountKeysRenewSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMapsAccountKeysRenewSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMapsAccountKeysRenewSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMapsAccountKeysRenewSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMapsAccountKeysRenewSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMapsAccountKeysRenewSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMapsAccountKeysRenewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMapsAccountKeysRenewSettings Settings, IReadOnlyCollection<Output> Output)> AzureMapsAccountKeysRenew(CombinatorialConfigure<AzureMapsAccountKeysRenewSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMapsAccountKeysRenew, AzureMapsLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureMapsSettings
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMapsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMaps executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMapsTasks.AzureMapsPath;
        public override Action<OutputType, string> CustomLogger => AzureMapsTasks.AzureMapsLogger;
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
              .Add("maps")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMapsAccountCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMapsAccountCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMaps executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMapsTasks.AzureMapsPath;
        public override Action<OutputType, string> CustomLogger => AzureMapsTasks.AzureMapsLogger;
        /// <summary>
        ///   The name of the maps account.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Resource group name.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Accept the Terms of Service, and do not prompt for confirmation.
        /// </summary>
        public virtual string AcceptTos { get; internal set; }
        /// <summary>
        ///   The name of the SKU.
        /// </summary>
        public virtual MapsAccountSku Sku { get; internal set; }
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
              .Add("maps account create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--accept-tos {value}", AcceptTos)
              .Add("--sku {value}", Sku)
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
    #region AzureMapsAccountDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMapsAccountDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMaps executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMapsTasks.AzureMapsPath;
        public override Action<OutputType, string> CustomLogger => AzureMapsTasks.AzureMapsLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the maps account.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Resource group name.
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
              .Add("maps account delete")
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
    #region AzureMapsAccountListSettings
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMapsAccountListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMaps executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMapsTasks.AzureMapsPath;
        public override Action<OutputType, string> CustomLogger => AzureMapsTasks.AzureMapsLogger;
        /// <summary>
        ///   Resource group name.
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
              .Add("maps account list")
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
    #region AzureMapsAccountShowSettings
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMapsAccountShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMaps executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMapsTasks.AzureMapsPath;
        public override Action<OutputType, string> CustomLogger => AzureMapsTasks.AzureMapsLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the maps account.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Resource group name.
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
              .Add("maps account show")
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
    #region AzureMapsAccountUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMapsAccountUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMaps executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMapsTasks.AzureMapsPath;
        public override Action<OutputType, string> CustomLogger => AzureMapsTasks.AzureMapsLogger;
        /// <summary>
        ///   The name of the SKU.
        /// </summary>
        public virtual MapsAccountSku Sku { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the maps account.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Resource group name.
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
              .Add("maps account update")
              .Add("--sku {value}", Sku)
              .Add("--tags {value}", Tags)
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
    #region AzureMapsAccountKeysListSettings
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMapsAccountKeysListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMaps executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMapsTasks.AzureMapsPath;
        public override Action<OutputType, string> CustomLogger => AzureMapsTasks.AzureMapsLogger;
        /// <summary>
        ///   The name of the maps account.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Resource group name.
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
              .Add("maps account keys list")
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
    #region AzureMapsAccountKeysRenewSettings
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMapsAccountKeysRenewSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMaps executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMapsTasks.AzureMapsPath;
        public override Action<OutputType, string> CustomLogger => AzureMapsTasks.AzureMapsLogger;
        /// <summary>
        ///   Whether the operation refers to the primary or secondary key.
        /// </summary>
        public virtual MapsAccountKeysRenewKey Key { get; internal set; }
        /// <summary>
        ///   The name of the maps account.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Resource group name.
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
              .Add("maps account keys renew")
              .Add("--key {value}", Key)
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
    #region AzureMapsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMapsSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsSettings SetDebug(this AzureMapsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsSettings ResetDebug(this AzureMapsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsSettings SetHelp(this AzureMapsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsSettings ResetHelp(this AzureMapsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsSettings SetOutput(this AzureMapsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsSettings ResetOutput(this AzureMapsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsSettings SetQuery(this AzureMapsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsSettings ResetQuery(this AzureMapsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsSettings SetVerbose(this AzureMapsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsSettings ResetVerbose(this AzureMapsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMapsAccountCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMapsAccountCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountCreateSettings.Name"/></em></p>
        ///   <p>The name of the maps account.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings SetName(this AzureMapsAccountCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountCreateSettings.Name"/></em></p>
        ///   <p>The name of the maps account.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings ResetName(this AzureMapsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings SetResourceGroup(this AzureMapsAccountCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings ResetResourceGroup(this AzureMapsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AcceptTos
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountCreateSettings.AcceptTos"/></em></p>
        ///   <p>Accept the Terms of Service, and do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings SetAcceptTos(this AzureMapsAccountCreateSettings toolSettings, string acceptTos)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AcceptTos = acceptTos;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountCreateSettings.AcceptTos"/></em></p>
        ///   <p>Accept the Terms of Service, and do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings ResetAcceptTos(this AzureMapsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AcceptTos = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountCreateSettings.Sku"/></em></p>
        ///   <p>The name of the SKU.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings SetSku(this AzureMapsAccountCreateSettings toolSettings, MapsAccountSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountCreateSettings.Sku"/></em></p>
        ///   <p>The name of the SKU.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings ResetSku(this AzureMapsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings SetTags(this AzureMapsAccountCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings ResetTags(this AzureMapsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings SetSubscription(this AzureMapsAccountCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings ResetSubscription(this AzureMapsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings SetDebug(this AzureMapsAccountCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings ResetDebug(this AzureMapsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings SetHelp(this AzureMapsAccountCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings ResetHelp(this AzureMapsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings SetOutput(this AzureMapsAccountCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings ResetOutput(this AzureMapsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings SetQuery(this AzureMapsAccountCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings ResetQuery(this AzureMapsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings SetVerbose(this AzureMapsAccountCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountCreateSettings ResetVerbose(this AzureMapsAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMapsAccountDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMapsAccountDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings SetIds(this AzureMapsAccountDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings SetIds(this AzureMapsAccountDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMapsAccountDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings AddIds(this AzureMapsAccountDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMapsAccountDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings AddIds(this AzureMapsAccountDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMapsAccountDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings ClearIds(this AzureMapsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMapsAccountDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings RemoveIds(this AzureMapsAccountDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMapsAccountDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings RemoveIds(this AzureMapsAccountDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountDeleteSettings.Name"/></em></p>
        ///   <p>The name of the maps account.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings SetName(this AzureMapsAccountDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountDeleteSettings.Name"/></em></p>
        ///   <p>The name of the maps account.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings ResetName(this AzureMapsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings SetResourceGroup(this AzureMapsAccountDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings ResetResourceGroup(this AzureMapsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings SetSubscription(this AzureMapsAccountDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings ResetSubscription(this AzureMapsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings SetDebug(this AzureMapsAccountDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings ResetDebug(this AzureMapsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings SetHelp(this AzureMapsAccountDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings ResetHelp(this AzureMapsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings SetOutput(this AzureMapsAccountDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings ResetOutput(this AzureMapsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings SetQuery(this AzureMapsAccountDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings ResetQuery(this AzureMapsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings SetVerbose(this AzureMapsAccountDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountDeleteSettings ResetVerbose(this AzureMapsAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMapsAccountListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMapsAccountListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountListSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings SetResourceGroup(this AzureMapsAccountListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountListSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings ResetResourceGroup(this AzureMapsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings SetSubscription(this AzureMapsAccountListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings ResetSubscription(this AzureMapsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings SetDebug(this AzureMapsAccountListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings ResetDebug(this AzureMapsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings SetHelp(this AzureMapsAccountListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings ResetHelp(this AzureMapsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings SetOutput(this AzureMapsAccountListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings ResetOutput(this AzureMapsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings SetQuery(this AzureMapsAccountListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings ResetQuery(this AzureMapsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings SetVerbose(this AzureMapsAccountListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountListSettings ResetVerbose(this AzureMapsAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMapsAccountShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMapsAccountShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings SetIds(this AzureMapsAccountShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings SetIds(this AzureMapsAccountShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMapsAccountShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings AddIds(this AzureMapsAccountShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMapsAccountShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings AddIds(this AzureMapsAccountShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMapsAccountShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings ClearIds(this AzureMapsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMapsAccountShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings RemoveIds(this AzureMapsAccountShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMapsAccountShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings RemoveIds(this AzureMapsAccountShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountShowSettings.Name"/></em></p>
        ///   <p>The name of the maps account.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings SetName(this AzureMapsAccountShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountShowSettings.Name"/></em></p>
        ///   <p>The name of the maps account.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings ResetName(this AzureMapsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountShowSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings SetResourceGroup(this AzureMapsAccountShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountShowSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings ResetResourceGroup(this AzureMapsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings SetSubscription(this AzureMapsAccountShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings ResetSubscription(this AzureMapsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings SetDebug(this AzureMapsAccountShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings ResetDebug(this AzureMapsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings SetHelp(this AzureMapsAccountShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings ResetHelp(this AzureMapsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings SetOutput(this AzureMapsAccountShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings ResetOutput(this AzureMapsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings SetQuery(this AzureMapsAccountShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings ResetQuery(this AzureMapsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings SetVerbose(this AzureMapsAccountShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountShowSettings ResetVerbose(this AzureMapsAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMapsAccountUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMapsAccountUpdateSettingsExtensions
    {
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Sku"/></em></p>
        ///   <p>The name of the SKU.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetSku(this AzureMapsAccountUpdateSettings toolSettings, MapsAccountSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.Sku"/></em></p>
        ///   <p>The name of the SKU.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetSku(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetTags(this AzureMapsAccountUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetTags(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetIds(this AzureMapsAccountUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetIds(this AzureMapsAccountUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMapsAccountUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings AddIds(this AzureMapsAccountUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMapsAccountUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings AddIds(this AzureMapsAccountUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMapsAccountUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ClearIds(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMapsAccountUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings RemoveIds(this AzureMapsAccountUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMapsAccountUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings RemoveIds(this AzureMapsAccountUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Name"/></em></p>
        ///   <p>The name of the maps account.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetName(this AzureMapsAccountUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.Name"/></em></p>
        ///   <p>The name of the maps account.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetName(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetResourceGroup(this AzureMapsAccountUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetResourceGroup(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetSubscription(this AzureMapsAccountUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetSubscription(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetAdd(this AzureMapsAccountUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetAdd(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetForceString(this AzureMapsAccountUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetForceString(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetRemove(this AzureMapsAccountUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetRemove(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetSet(this AzureMapsAccountUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetSet(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetDebug(this AzureMapsAccountUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetDebug(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetHelp(this AzureMapsAccountUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetHelp(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetOutput(this AzureMapsAccountUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetOutput(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetQuery(this AzureMapsAccountUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetQuery(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings SetVerbose(this AzureMapsAccountUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountUpdateSettings ResetVerbose(this AzureMapsAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMapsAccountKeysListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMapsAccountKeysListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysListSettings.Name"/></em></p>
        ///   <p>The name of the maps account.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings SetName(this AzureMapsAccountKeysListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysListSettings.Name"/></em></p>
        ///   <p>The name of the maps account.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings ResetName(this AzureMapsAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysListSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings SetResourceGroup(this AzureMapsAccountKeysListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysListSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings ResetResourceGroup(this AzureMapsAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings SetSubscription(this AzureMapsAccountKeysListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings ResetSubscription(this AzureMapsAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings SetDebug(this AzureMapsAccountKeysListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings ResetDebug(this AzureMapsAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings SetHelp(this AzureMapsAccountKeysListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings ResetHelp(this AzureMapsAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings SetOutput(this AzureMapsAccountKeysListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings ResetOutput(this AzureMapsAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings SetQuery(this AzureMapsAccountKeysListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings ResetQuery(this AzureMapsAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings SetVerbose(this AzureMapsAccountKeysListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysListSettings ResetVerbose(this AzureMapsAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMapsAccountKeysRenewSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMapsAccountKeysRenewSettingsExtensions
    {
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysRenewSettings.Key"/></em></p>
        ///   <p>Whether the operation refers to the primary or secondary key.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings SetKey(this AzureMapsAccountKeysRenewSettings toolSettings, MapsAccountKeysRenewKey key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysRenewSettings.Key"/></em></p>
        ///   <p>Whether the operation refers to the primary or secondary key.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings ResetKey(this AzureMapsAccountKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysRenewSettings.Name"/></em></p>
        ///   <p>The name of the maps account.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings SetName(this AzureMapsAccountKeysRenewSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysRenewSettings.Name"/></em></p>
        ///   <p>The name of the maps account.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings ResetName(this AzureMapsAccountKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysRenewSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings SetResourceGroup(this AzureMapsAccountKeysRenewSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysRenewSettings.ResourceGroup"/></em></p>
        ///   <p>Resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings ResetResourceGroup(this AzureMapsAccountKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysRenewSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings SetSubscription(this AzureMapsAccountKeysRenewSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysRenewSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings ResetSubscription(this AzureMapsAccountKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysRenewSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings SetDebug(this AzureMapsAccountKeysRenewSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysRenewSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings ResetDebug(this AzureMapsAccountKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysRenewSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings SetHelp(this AzureMapsAccountKeysRenewSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysRenewSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings ResetHelp(this AzureMapsAccountKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysRenewSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings SetOutput(this AzureMapsAccountKeysRenewSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysRenewSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings ResetOutput(this AzureMapsAccountKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysRenewSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings SetQuery(this AzureMapsAccountKeysRenewSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysRenewSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings ResetQuery(this AzureMapsAccountKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMapsAccountKeysRenewSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings SetVerbose(this AzureMapsAccountKeysRenewSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMapsAccountKeysRenewSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMapsAccountKeysRenewSettings ResetVerbose(this AzureMapsAccountKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region MapsAccountSku
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<MapsAccountSku>))]
    public partial class MapsAccountSku : Enumeration
    {
        public static MapsAccountSku s0 = new MapsAccountSku { Value = "s0" };
        public static MapsAccountSku s1 = new MapsAccountSku { Value = "s1" };
    }
    #endregion
    #region MapsAccountKeysRenewKey
    /// <summary>
    ///   Used within <see cref="AzureMapsTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<MapsAccountKeysRenewKey>))]
    public partial class MapsAccountKeysRenewKey : Enumeration
    {
        public static MapsAccountKeysRenewKey primary = new MapsAccountKeysRenewKey { Value = "primary" };
        public static MapsAccountKeysRenewKey secondary = new MapsAccountKeysRenewKey { Value = "secondary" };
    }
    #endregion
}
