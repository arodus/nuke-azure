// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureSearch.json
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
    public static partial class AzureSearchTasks
    {
        /// <summary>
        ///   Path to the AzureSearch executable.
        /// </summary>
        public static string AzureSearchPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURESEARCH_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureSearchLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Search services, admin keys and query keys.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSearch(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureSearchPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureSearchLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSearch(AzureSearchSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSearchSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSearch(Configure<AzureSearchSettings> configurator)
        {
            return AzureSearch(configurator(new AzureSearchSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSearchSettings Settings, IReadOnlyCollection<Output> Output)> AzureSearch(CombinatorialConfigure<AzureSearchSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSearch, AzureSearchLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSearchServiceCreate(AzureSearchServiceCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSearchServiceCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchServiceCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchServiceCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSearchServiceCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSearchServiceCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchServiceCreateSettings.Output"/></li>
        ///     <li><c>--partition-count</c> via <see cref="AzureSearchServiceCreateSettings.PartitionCount"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchServiceCreateSettings.Query"/></li>
        ///     <li><c>--replica-count</c> via <see cref="AzureSearchServiceCreateSettings.ReplicaCount"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchServiceCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureSearchServiceCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchServiceCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchServiceCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSearchServiceCreate(Configure<AzureSearchServiceCreateSettings> configurator)
        {
            return AzureSearchServiceCreate(configurator(new AzureSearchServiceCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchServiceCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchServiceCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSearchServiceCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSearchServiceCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchServiceCreateSettings.Output"/></li>
        ///     <li><c>--partition-count</c> via <see cref="AzureSearchServiceCreateSettings.PartitionCount"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchServiceCreateSettings.Query"/></li>
        ///     <li><c>--replica-count</c> via <see cref="AzureSearchServiceCreateSettings.ReplicaCount"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchServiceCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureSearchServiceCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchServiceCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchServiceCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSearchServiceCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSearchServiceCreate(CombinatorialConfigure<AzureSearchServiceCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSearchServiceCreate, AzureSearchLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSearchServiceDelete(AzureSearchServiceDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSearchServiceDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchServiceDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchServiceDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSearchServiceDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchServiceDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchServiceDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchServiceDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchServiceDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchServiceDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureSearchServiceDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSearchServiceDelete(Configure<AzureSearchServiceDeleteSettings> configurator)
        {
            return AzureSearchServiceDelete(configurator(new AzureSearchServiceDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchServiceDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchServiceDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSearchServiceDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchServiceDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchServiceDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchServiceDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchServiceDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchServiceDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureSearchServiceDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSearchServiceDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureSearchServiceDelete(CombinatorialConfigure<AzureSearchServiceDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSearchServiceDelete, AzureSearchLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSearchServiceList(AzureSearchServiceListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSearchServiceListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchServiceListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchServiceListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchServiceListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchServiceListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchServiceListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchServiceListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchServiceListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSearchServiceList(Configure<AzureSearchServiceListSettings> configurator)
        {
            return AzureSearchServiceList(configurator(new AzureSearchServiceListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchServiceListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchServiceListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchServiceListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchServiceListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchServiceListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchServiceListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchServiceListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSearchServiceListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSearchServiceList(CombinatorialConfigure<AzureSearchServiceListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSearchServiceList, AzureSearchLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSearchServiceShow(AzureSearchServiceShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSearchServiceShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchServiceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchServiceShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSearchServiceShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchServiceShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchServiceShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchServiceShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchServiceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchServiceShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSearchServiceShow(Configure<AzureSearchServiceShowSettings> configurator)
        {
            return AzureSearchServiceShow(configurator(new AzureSearchServiceShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchServiceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchServiceShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSearchServiceShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchServiceShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchServiceShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchServiceShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchServiceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchServiceShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSearchServiceShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSearchServiceShow(CombinatorialConfigure<AzureSearchServiceShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSearchServiceShow, AzureSearchLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSearchServiceUpdate(AzureSearchServiceUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSearchServiceUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureSearchServiceUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSearchServiceUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureSearchServiceUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchServiceUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSearchServiceUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchServiceUpdateSettings.Output"/></li>
        ///     <li><c>--partition-count</c> via <see cref="AzureSearchServiceUpdateSettings.PartitionCount"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchServiceUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureSearchServiceUpdateSettings.Remove"/></li>
        ///     <li><c>--replica-count</c> via <see cref="AzureSearchServiceUpdateSettings.ReplicaCount"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchServiceUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureSearchServiceUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchServiceUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchServiceUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSearchServiceUpdate(Configure<AzureSearchServiceUpdateSettings> configurator)
        {
            return AzureSearchServiceUpdate(configurator(new AzureSearchServiceUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureSearchServiceUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSearchServiceUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureSearchServiceUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchServiceUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSearchServiceUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchServiceUpdateSettings.Output"/></li>
        ///     <li><c>--partition-count</c> via <see cref="AzureSearchServiceUpdateSettings.PartitionCount"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchServiceUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureSearchServiceUpdateSettings.Remove"/></li>
        ///     <li><c>--replica-count</c> via <see cref="AzureSearchServiceUpdateSettings.ReplicaCount"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchServiceUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureSearchServiceUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchServiceUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchServiceUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSearchServiceUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSearchServiceUpdate(CombinatorialConfigure<AzureSearchServiceUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSearchServiceUpdate, AzureSearchLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSearchAdminKeyRenew(AzureSearchAdminKeyRenewSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSearchAdminKeyRenewSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchAdminKeyRenewSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchAdminKeyRenewSettings.Help"/></li>
        ///     <li><c>--key-kind</c> via <see cref="AzureSearchAdminKeyRenewSettings.KeyKind"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchAdminKeyRenewSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchAdminKeyRenewSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchAdminKeyRenewSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureSearchAdminKeyRenewSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchAdminKeyRenewSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchAdminKeyRenewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSearchAdminKeyRenew(Configure<AzureSearchAdminKeyRenewSettings> configurator)
        {
            return AzureSearchAdminKeyRenew(configurator(new AzureSearchAdminKeyRenewSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchAdminKeyRenewSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchAdminKeyRenewSettings.Help"/></li>
        ///     <li><c>--key-kind</c> via <see cref="AzureSearchAdminKeyRenewSettings.KeyKind"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchAdminKeyRenewSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchAdminKeyRenewSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchAdminKeyRenewSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureSearchAdminKeyRenewSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchAdminKeyRenewSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchAdminKeyRenewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSearchAdminKeyRenewSettings Settings, IReadOnlyCollection<Output> Output)> AzureSearchAdminKeyRenew(CombinatorialConfigure<AzureSearchAdminKeyRenewSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSearchAdminKeyRenew, AzureSearchLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSearchAdminKeyShow(AzureSearchAdminKeyShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSearchAdminKeyShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchAdminKeyShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchAdminKeyShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchAdminKeyShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchAdminKeyShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchAdminKeyShowSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureSearchAdminKeyShowSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchAdminKeyShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchAdminKeyShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSearchAdminKeyShow(Configure<AzureSearchAdminKeyShowSettings> configurator)
        {
            return AzureSearchAdminKeyShow(configurator(new AzureSearchAdminKeyShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchAdminKeyShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchAdminKeyShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchAdminKeyShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchAdminKeyShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchAdminKeyShowSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureSearchAdminKeyShowSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchAdminKeyShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchAdminKeyShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSearchAdminKeyShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSearchAdminKeyShow(CombinatorialConfigure<AzureSearchAdminKeyShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSearchAdminKeyShow, AzureSearchLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSearchQueryKeyCreate(AzureSearchQueryKeyCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSearchQueryKeyCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchQueryKeyCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchQueryKeyCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSearchQueryKeyCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchQueryKeyCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchQueryKeyCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchQueryKeyCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureSearchQueryKeyCreateSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchQueryKeyCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchQueryKeyCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSearchQueryKeyCreate(Configure<AzureSearchQueryKeyCreateSettings> configurator)
        {
            return AzureSearchQueryKeyCreate(configurator(new AzureSearchQueryKeyCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchQueryKeyCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchQueryKeyCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSearchQueryKeyCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchQueryKeyCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchQueryKeyCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchQueryKeyCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureSearchQueryKeyCreateSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchQueryKeyCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchQueryKeyCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSearchQueryKeyCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSearchQueryKeyCreate(CombinatorialConfigure<AzureSearchQueryKeyCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSearchQueryKeyCreate, AzureSearchLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSearchQueryKeyDelete(AzureSearchQueryKeyDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSearchQueryKeyDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchQueryKeyDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchQueryKeyDeleteSettings.Help"/></li>
        ///     <li><c>--key-value</c> via <see cref="AzureSearchQueryKeyDeleteSettings.KeyValue"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchQueryKeyDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchQueryKeyDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchQueryKeyDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureSearchQueryKeyDeleteSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchQueryKeyDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchQueryKeyDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSearchQueryKeyDelete(Configure<AzureSearchQueryKeyDeleteSettings> configurator)
        {
            return AzureSearchQueryKeyDelete(configurator(new AzureSearchQueryKeyDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchQueryKeyDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchQueryKeyDeleteSettings.Help"/></li>
        ///     <li><c>--key-value</c> via <see cref="AzureSearchQueryKeyDeleteSettings.KeyValue"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchQueryKeyDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchQueryKeyDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchQueryKeyDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureSearchQueryKeyDeleteSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchQueryKeyDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchQueryKeyDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSearchQueryKeyDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureSearchQueryKeyDelete(CombinatorialConfigure<AzureSearchQueryKeyDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSearchQueryKeyDelete, AzureSearchLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSearchQueryKeyList(AzureSearchQueryKeyListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSearchQueryKeyListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchQueryKeyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchQueryKeyListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchQueryKeyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchQueryKeyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchQueryKeyListSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureSearchQueryKeyListSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchQueryKeyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchQueryKeyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSearchQueryKeyList(Configure<AzureSearchQueryKeyListSettings> configurator)
        {
            return AzureSearchQueryKeyList(configurator(new AzureSearchQueryKeyListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Search services, admin keys and query keys.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/search?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSearchQueryKeyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSearchQueryKeyListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSearchQueryKeyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSearchQueryKeyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSearchQueryKeyListSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureSearchQueryKeyListSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSearchQueryKeyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSearchQueryKeyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSearchQueryKeyListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSearchQueryKeyList(CombinatorialConfigure<AzureSearchQueryKeyListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSearchQueryKeyList, AzureSearchLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureSearchSettings
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSearchSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSearch executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSearchTasks.AzureSearchPath;
        public override Action<OutputType, string> CustomLogger => AzureSearchTasks.AzureSearchLogger;
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
              .Add("search")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSearchServiceCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSearchServiceCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSearch executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSearchTasks.AzureSearchPath;
        public override Action<OutputType, string> CustomLogger => AzureSearchTasks.AzureSearchLogger;
        /// <summary>
        ///   The name of the search service.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The SKU of the search service, which determines price tier and capacity limits.
        /// </summary>
        public virtual string Sku { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Number of partitions in the search service.
        /// </summary>
        public virtual int? PartitionCount { get; internal set; }
        /// <summary>
        ///   Number of replicas in the search service.
        /// </summary>
        public virtual int? ReplicaCount { get; internal set; }
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
              .Add("search service create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--location {value}", Location)
              .Add("--partition-count {value}", PartitionCount)
              .Add("--replica-count {value}", ReplicaCount)
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
    #region AzureSearchServiceDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSearchServiceDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSearch executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSearchTasks.AzureSearchPath;
        public override Action<OutputType, string> CustomLogger => AzureSearchTasks.AzureSearchLogger;
        /// <summary>
        ///   The name of the search service.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("search service delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureSearchServiceListSettings
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSearchServiceListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSearch executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSearchTasks.AzureSearchPath;
        public override Action<OutputType, string> CustomLogger => AzureSearchTasks.AzureSearchLogger;
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
              .Add("search service list")
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
    #region AzureSearchServiceShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSearchServiceShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSearch executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSearchTasks.AzureSearchPath;
        public override Action<OutputType, string> CustomLogger => AzureSearchTasks.AzureSearchLogger;
        /// <summary>
        ///   The name of the search service.
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
              .Add("search service show")
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
    #region AzureSearchServiceUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSearchServiceUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSearch executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSearchTasks.AzureSearchPath;
        public override Action<OutputType, string> CustomLogger => AzureSearchTasks.AzureSearchLogger;
        /// <summary>
        ///   The name of the search service.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Number of partitions in the search service.
        /// </summary>
        public virtual int? PartitionCount { get; internal set; }
        /// <summary>
        ///   Number of replicas in the search service.
        /// </summary>
        public virtual int? ReplicaCount { get; internal set; }
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
              .Add("search service update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--partition-count {value}", PartitionCount)
              .Add("--replica-count {value}", ReplicaCount)
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
    #region AzureSearchAdminKeyRenewSettings
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSearchAdminKeyRenewSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSearch executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSearchTasks.AzureSearchPath;
        public override Action<OutputType, string> CustomLogger => AzureSearchTasks.AzureSearchLogger;
        /// <summary>
        ///   The type (primary or secondary) of the admin key.
        /// </summary>
        public virtual string KeyKind { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the search service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
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
              .Add("search admin-key renew")
              .Add("--key-kind {value}", KeyKind)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
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
    #region AzureSearchAdminKeyShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSearchAdminKeyShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSearch executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSearchTasks.AzureSearchPath;
        public override Action<OutputType, string> CustomLogger => AzureSearchTasks.AzureSearchLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the search service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
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
              .Add("search admin-key show")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
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
    #region AzureSearchQueryKeyCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSearchQueryKeyCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSearch executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSearchTasks.AzureSearchPath;
        public override Action<OutputType, string> CustomLogger => AzureSearchTasks.AzureSearchLogger;
        /// <summary>
        ///   The name of the query key.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the search service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
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
              .Add("search query-key create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
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
    #region AzureSearchQueryKeyDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSearchQueryKeyDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSearch executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSearchTasks.AzureSearchPath;
        public override Action<OutputType, string> CustomLogger => AzureSearchTasks.AzureSearchLogger;
        /// <summary>
        ///   The value of the query key.
        /// </summary>
        public virtual string KeyValue { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the search service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
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
              .Add("search query-key delete")
              .Add("--key-value {value}", KeyValue)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
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
    #region AzureSearchQueryKeyListSettings
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSearchQueryKeyListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSearch executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSearchTasks.AzureSearchPath;
        public override Action<OutputType, string> CustomLogger => AzureSearchTasks.AzureSearchLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the search service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
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
              .Add("search query-key list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
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
    #region AzureSearchSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSearchSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchSettings SetDebug(this AzureSearchSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchSettings ResetDebug(this AzureSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchSettings SetHelp(this AzureSearchSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchSettings ResetHelp(this AzureSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchSettings SetOutput(this AzureSearchSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchSettings ResetOutput(this AzureSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchSettings SetQuery(this AzureSearchSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchSettings ResetQuery(this AzureSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchSettings SetVerbose(this AzureSearchSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchSettings ResetVerbose(this AzureSearchSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSearchServiceCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSearchServiceCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceCreateSettings.Name"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings SetName(this AzureSearchServiceCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceCreateSettings.Name"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings ResetName(this AzureSearchServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings SetResourceGroup(this AzureSearchServiceCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings ResetResourceGroup(this AzureSearchServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceCreateSettings.Sku"/></em></p>
        ///   <p>The SKU of the search service, which determines price tier and capacity limits.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings SetSku(this AzureSearchServiceCreateSettings toolSettings, string sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceCreateSettings.Sku"/></em></p>
        ///   <p>The SKU of the search service, which determines price tier and capacity limits.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings ResetSku(this AzureSearchServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings SetLocation(this AzureSearchServiceCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings ResetLocation(this AzureSearchServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region PartitionCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceCreateSettings.PartitionCount"/></em></p>
        ///   <p>Number of partitions in the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings SetPartitionCount(this AzureSearchServiceCreateSettings toolSettings, int? partitionCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionCount = partitionCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceCreateSettings.PartitionCount"/></em></p>
        ///   <p>Number of partitions in the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings ResetPartitionCount(this AzureSearchServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionCount = null;
            return toolSettings;
        }
        #endregion
        #region ReplicaCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceCreateSettings.ReplicaCount"/></em></p>
        ///   <p>Number of replicas in the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings SetReplicaCount(this AzureSearchServiceCreateSettings toolSettings, int? replicaCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplicaCount = replicaCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceCreateSettings.ReplicaCount"/></em></p>
        ///   <p>Number of replicas in the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings ResetReplicaCount(this AzureSearchServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplicaCount = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings SetSubscription(this AzureSearchServiceCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings ResetSubscription(this AzureSearchServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings SetDebug(this AzureSearchServiceCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings ResetDebug(this AzureSearchServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings SetHelp(this AzureSearchServiceCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings ResetHelp(this AzureSearchServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings SetOutput(this AzureSearchServiceCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings ResetOutput(this AzureSearchServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings SetQuery(this AzureSearchServiceCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings ResetQuery(this AzureSearchServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings SetVerbose(this AzureSearchServiceCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceCreateSettings ResetVerbose(this AzureSearchServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSearchServiceDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSearchServiceDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceDeleteSettings.Name"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings SetName(this AzureSearchServiceDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceDeleteSettings.Name"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings ResetName(this AzureSearchServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings SetResourceGroup(this AzureSearchServiceDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings ResetResourceGroup(this AzureSearchServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings SetYes(this AzureSearchServiceDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings ResetYes(this AzureSearchServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings SetSubscription(this AzureSearchServiceDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings ResetSubscription(this AzureSearchServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings SetDebug(this AzureSearchServiceDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings ResetDebug(this AzureSearchServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings SetHelp(this AzureSearchServiceDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings ResetHelp(this AzureSearchServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings SetOutput(this AzureSearchServiceDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings ResetOutput(this AzureSearchServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings SetQuery(this AzureSearchServiceDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings ResetQuery(this AzureSearchServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings SetVerbose(this AzureSearchServiceDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceDeleteSettings ResetVerbose(this AzureSearchServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSearchServiceListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSearchServiceListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings SetResourceGroup(this AzureSearchServiceListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings ResetResourceGroup(this AzureSearchServiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings SetSubscription(this AzureSearchServiceListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings ResetSubscription(this AzureSearchServiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings SetDebug(this AzureSearchServiceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings ResetDebug(this AzureSearchServiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings SetHelp(this AzureSearchServiceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings ResetHelp(this AzureSearchServiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings SetOutput(this AzureSearchServiceListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings ResetOutput(this AzureSearchServiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings SetQuery(this AzureSearchServiceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings ResetQuery(this AzureSearchServiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings SetVerbose(this AzureSearchServiceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceListSettings ResetVerbose(this AzureSearchServiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSearchServiceShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSearchServiceShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceShowSettings.Name"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings SetName(this AzureSearchServiceShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceShowSettings.Name"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings ResetName(this AzureSearchServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings SetResourceGroup(this AzureSearchServiceShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings ResetResourceGroup(this AzureSearchServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings SetSubscription(this AzureSearchServiceShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings ResetSubscription(this AzureSearchServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings SetDebug(this AzureSearchServiceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings ResetDebug(this AzureSearchServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings SetHelp(this AzureSearchServiceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings ResetHelp(this AzureSearchServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings SetOutput(this AzureSearchServiceShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings ResetOutput(this AzureSearchServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings SetQuery(this AzureSearchServiceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings ResetQuery(this AzureSearchServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings SetVerbose(this AzureSearchServiceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceShowSettings ResetVerbose(this AzureSearchServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSearchServiceUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSearchServiceUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.Name"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetName(this AzureSearchServiceUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.Name"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetName(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetResourceGroup(this AzureSearchServiceUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetResourceGroup(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region PartitionCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.PartitionCount"/></em></p>
        ///   <p>Number of partitions in the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetPartitionCount(this AzureSearchServiceUpdateSettings toolSettings, int? partitionCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionCount = partitionCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.PartitionCount"/></em></p>
        ///   <p>Number of partitions in the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetPartitionCount(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionCount = null;
            return toolSettings;
        }
        #endregion
        #region ReplicaCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.ReplicaCount"/></em></p>
        ///   <p>Number of replicas in the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetReplicaCount(this AzureSearchServiceUpdateSettings toolSettings, int? replicaCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplicaCount = replicaCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.ReplicaCount"/></em></p>
        ///   <p>Number of replicas in the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetReplicaCount(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplicaCount = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetAdd(this AzureSearchServiceUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetAdd(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetForceString(this AzureSearchServiceUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetForceString(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetRemove(this AzureSearchServiceUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetRemove(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetSet(this AzureSearchServiceUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetSet(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetSubscription(this AzureSearchServiceUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetSubscription(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetDebug(this AzureSearchServiceUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetDebug(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetHelp(this AzureSearchServiceUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetHelp(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetOutput(this AzureSearchServiceUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetOutput(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetQuery(this AzureSearchServiceUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetQuery(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchServiceUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings SetVerbose(this AzureSearchServiceUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchServiceUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchServiceUpdateSettings ResetVerbose(this AzureSearchServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSearchAdminKeyRenewSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSearchAdminKeyRenewSettingsExtensions
    {
        #region KeyKind
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyRenewSettings.KeyKind"/></em></p>
        ///   <p>The type (primary or secondary) of the admin key.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings SetKeyKind(this AzureSearchAdminKeyRenewSettings toolSettings, string keyKind)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyKind = keyKind;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyRenewSettings.KeyKind"/></em></p>
        ///   <p>The type (primary or secondary) of the admin key.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings ResetKeyKind(this AzureSearchAdminKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyKind = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyRenewSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings SetResourceGroup(this AzureSearchAdminKeyRenewSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyRenewSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings ResetResourceGroup(this AzureSearchAdminKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyRenewSettings.ServiceName"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings SetServiceName(this AzureSearchAdminKeyRenewSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyRenewSettings.ServiceName"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings ResetServiceName(this AzureSearchAdminKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyRenewSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings SetSubscription(this AzureSearchAdminKeyRenewSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyRenewSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings ResetSubscription(this AzureSearchAdminKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyRenewSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings SetDebug(this AzureSearchAdminKeyRenewSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyRenewSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings ResetDebug(this AzureSearchAdminKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyRenewSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings SetHelp(this AzureSearchAdminKeyRenewSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyRenewSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings ResetHelp(this AzureSearchAdminKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyRenewSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings SetOutput(this AzureSearchAdminKeyRenewSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyRenewSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings ResetOutput(this AzureSearchAdminKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyRenewSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings SetQuery(this AzureSearchAdminKeyRenewSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyRenewSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings ResetQuery(this AzureSearchAdminKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyRenewSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings SetVerbose(this AzureSearchAdminKeyRenewSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyRenewSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyRenewSettings ResetVerbose(this AzureSearchAdminKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSearchAdminKeyShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSearchAdminKeyShowSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings SetResourceGroup(this AzureSearchAdminKeyShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings ResetResourceGroup(this AzureSearchAdminKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyShowSettings.ServiceName"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings SetServiceName(this AzureSearchAdminKeyShowSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyShowSettings.ServiceName"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings ResetServiceName(this AzureSearchAdminKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings SetSubscription(this AzureSearchAdminKeyShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings ResetSubscription(this AzureSearchAdminKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings SetDebug(this AzureSearchAdminKeyShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings ResetDebug(this AzureSearchAdminKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings SetHelp(this AzureSearchAdminKeyShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings ResetHelp(this AzureSearchAdminKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings SetOutput(this AzureSearchAdminKeyShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings ResetOutput(this AzureSearchAdminKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings SetQuery(this AzureSearchAdminKeyShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings ResetQuery(this AzureSearchAdminKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchAdminKeyShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings SetVerbose(this AzureSearchAdminKeyShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchAdminKeyShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchAdminKeyShowSettings ResetVerbose(this AzureSearchAdminKeyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSearchQueryKeyCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSearchQueryKeyCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyCreateSettings.Name"/></em></p>
        ///   <p>The name of the query key.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings SetName(this AzureSearchQueryKeyCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyCreateSettings.Name"/></em></p>
        ///   <p>The name of the query key.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings ResetName(this AzureSearchQueryKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings SetResourceGroup(this AzureSearchQueryKeyCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings ResetResourceGroup(this AzureSearchQueryKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyCreateSettings.ServiceName"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings SetServiceName(this AzureSearchQueryKeyCreateSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyCreateSettings.ServiceName"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings ResetServiceName(this AzureSearchQueryKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings SetSubscription(this AzureSearchQueryKeyCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings ResetSubscription(this AzureSearchQueryKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings SetDebug(this AzureSearchQueryKeyCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings ResetDebug(this AzureSearchQueryKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings SetHelp(this AzureSearchQueryKeyCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings ResetHelp(this AzureSearchQueryKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings SetOutput(this AzureSearchQueryKeyCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings ResetOutput(this AzureSearchQueryKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings SetQuery(this AzureSearchQueryKeyCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings ResetQuery(this AzureSearchQueryKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings SetVerbose(this AzureSearchQueryKeyCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyCreateSettings ResetVerbose(this AzureSearchQueryKeyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSearchQueryKeyDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSearchQueryKeyDeleteSettingsExtensions
    {
        #region KeyValue
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyDeleteSettings.KeyValue"/></em></p>
        ///   <p>The value of the query key.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings SetKeyValue(this AzureSearchQueryKeyDeleteSettings toolSettings, string keyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = keyValue;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyDeleteSettings.KeyValue"/></em></p>
        ///   <p>The value of the query key.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings ResetKeyValue(this AzureSearchQueryKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings SetResourceGroup(this AzureSearchQueryKeyDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings ResetResourceGroup(this AzureSearchQueryKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyDeleteSettings.ServiceName"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings SetServiceName(this AzureSearchQueryKeyDeleteSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyDeleteSettings.ServiceName"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings ResetServiceName(this AzureSearchQueryKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings SetSubscription(this AzureSearchQueryKeyDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings ResetSubscription(this AzureSearchQueryKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings SetDebug(this AzureSearchQueryKeyDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings ResetDebug(this AzureSearchQueryKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings SetHelp(this AzureSearchQueryKeyDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings ResetHelp(this AzureSearchQueryKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings SetOutput(this AzureSearchQueryKeyDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings ResetOutput(this AzureSearchQueryKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings SetQuery(this AzureSearchQueryKeyDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings ResetQuery(this AzureSearchQueryKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings SetVerbose(this AzureSearchQueryKeyDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyDeleteSettings ResetVerbose(this AzureSearchQueryKeyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSearchQueryKeyListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSearchTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSearchQueryKeyListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings SetResourceGroup(this AzureSearchQueryKeyListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings ResetResourceGroup(this AzureSearchQueryKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyListSettings.ServiceName"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings SetServiceName(this AzureSearchQueryKeyListSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyListSettings.ServiceName"/></em></p>
        ///   <p>The name of the search service.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings ResetServiceName(this AzureSearchQueryKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings SetSubscription(this AzureSearchQueryKeyListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings ResetSubscription(this AzureSearchQueryKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings SetDebug(this AzureSearchQueryKeyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings ResetDebug(this AzureSearchQueryKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings SetHelp(this AzureSearchQueryKeyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings ResetHelp(this AzureSearchQueryKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings SetOutput(this AzureSearchQueryKeyListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings ResetOutput(this AzureSearchQueryKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings SetQuery(this AzureSearchQueryKeyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings ResetQuery(this AzureSearchQueryKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSearchQueryKeyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings SetVerbose(this AzureSearchQueryKeyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSearchQueryKeyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSearchQueryKeyListSettings ResetVerbose(this AzureSearchQueryKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
