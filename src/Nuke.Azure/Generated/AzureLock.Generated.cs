// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzureLock.json
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
    public static partial class AzureLockTasks
    {
        /// <summary>
        ///   Path to the AzureLock executable.
        /// </summary>
        public static string AzureLockPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURELOCK_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureLockLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure locks.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureLock(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureLockPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureLockLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureLockCreate(AzureLockCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureLockCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureLockCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLockCreateSettings.Help"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureLockCreateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureLockCreateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureLockCreateSettings.Namespace"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureLockCreateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLockCreateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureLockCreateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLockCreateSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureLockCreateSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureLockCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureLockCreateSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureLockCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLockCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureLockCreate(Configure<AzureLockCreateSettings> configurator)
        {
            return AzureLockCreate(configurator(new AzureLockCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureLockCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLockCreateSettings.Help"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureLockCreateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureLockCreateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureLockCreateSettings.Namespace"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureLockCreateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLockCreateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureLockCreateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLockCreateSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureLockCreateSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureLockCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureLockCreateSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureLockCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLockCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureLockCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureLockCreate(CombinatorialConfigure<AzureLockCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureLockCreate, AzureLockLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureLockDelete(AzureLockDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureLockDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureLockDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLockDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureLockDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureLockDeleteSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureLockDeleteSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLockDeleteSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureLockDeleteSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLockDeleteSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureLockDeleteSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureLockDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureLockDeleteSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureLockDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLockDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureLockDelete(Configure<AzureLockDeleteSettings> configurator)
        {
            return AzureLockDelete(configurator(new AzureLockDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureLockDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLockDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureLockDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureLockDeleteSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureLockDeleteSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLockDeleteSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureLockDeleteSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLockDeleteSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureLockDeleteSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureLockDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureLockDeleteSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureLockDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLockDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureLockDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureLockDelete(CombinatorialConfigure<AzureLockDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureLockDelete, AzureLockLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureLockList(AzureLockListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureLockListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureLockListSettings.Debug"/></li>
        ///     <li><c>--filter-string</c> via <see cref="AzureLockListSettings.FilterString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLockListSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureLockListSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLockListSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureLockListSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLockListSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureLockListSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureLockListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureLockListSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureLockListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLockListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureLockList(Configure<AzureLockListSettings> configurator)
        {
            return AzureLockList(configurator(new AzureLockListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureLockListSettings.Debug"/></li>
        ///     <li><c>--filter-string</c> via <see cref="AzureLockListSettings.FilterString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLockListSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureLockListSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLockListSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureLockListSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLockListSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureLockListSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureLockListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureLockListSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureLockListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLockListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureLockListSettings Settings, IReadOnlyCollection<Output> Output)> AzureLockList(CombinatorialConfigure<AzureLockListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureLockList, AzureLockLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureLockShow(AzureLockShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureLockShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureLockShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLockShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureLockShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureLockShowSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureLockShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLockShowSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureLockShowSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLockShowSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureLockShowSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureLockShowSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureLockShowSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureLockShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLockShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureLockShow(Configure<AzureLockShowSettings> configurator)
        {
            return AzureLockShow(configurator(new AzureLockShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureLockShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLockShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureLockShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureLockShowSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureLockShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLockShowSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureLockShowSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLockShowSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureLockShowSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureLockShowSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureLockShowSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureLockShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLockShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureLockShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureLockShow(CombinatorialConfigure<AzureLockShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureLockShow, AzureLockLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureLockUpdate(AzureLockUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureLockUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureLockUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLockUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureLockUpdateSettings.Ids"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureLockUpdateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureLockUpdateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureLockUpdateSettings.Namespace"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureLockUpdateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLockUpdateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureLockUpdateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLockUpdateSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureLockUpdateSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureLockUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureLockUpdateSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureLockUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLockUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureLockUpdate(Configure<AzureLockUpdateSettings> configurator)
        {
            return AzureLockUpdate(configurator(new AzureLockUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure locks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureLockUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLockUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureLockUpdateSettings.Ids"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureLockUpdateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureLockUpdateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureLockUpdateSettings.Namespace"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureLockUpdateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLockUpdateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureLockUpdateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLockUpdateSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureLockUpdateSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureLockUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureLockUpdateSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureLockUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLockUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureLockUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureLockUpdate(CombinatorialConfigure<AzureLockUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureLockUpdate, AzureLockLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureLockCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureLockTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLockCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureLock executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureLockTasks.AzureLockPath;
        public override Action<OutputType, string> CustomLogger => AzureLockTasks.AzureLockLogger;
        /// <summary>
        ///   The type of lock restriction.
        /// </summary>
        public virtual LockLockType LockType { get; internal set; }
        /// <summary>
        ///   Name of the lock.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   Notes about this lock.
        /// </summary>
        public virtual string Notes { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
        /// </summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("lock create")
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--notes {value}", Notes)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
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
    #region AzureLockDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureLockTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLockDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureLock executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureLockTasks.AzureLockPath;
        public override Action<OutputType, string> CustomLogger => AzureLockTasks.AzureLockLogger;
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
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
        /// </summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("lock delete")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
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
    #region AzureLockListSettings
    /// <summary>
    ///   Used within <see cref="AzureLockTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLockListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureLock executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureLockTasks.AzureLockPath;
        public override Action<OutputType, string> CustomLogger => AzureLockTasks.AzureLockLogger;
        /// <summary>
        ///   A query filter to use to restrict the results.
        /// </summary>
        public virtual string FilterString { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
        /// </summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("lock list")
              .Add("--filter-string {value}", FilterString)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
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
    #region AzureLockShowSettings
    /// <summary>
    ///   Used within <see cref="AzureLockTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLockShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureLock executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureLockTasks.AzureLockPath;
        public override Action<OutputType, string> CustomLogger => AzureLockTasks.AzureLockLogger;
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
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
        /// </summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("lock show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
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
    #region AzureLockUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureLockTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLockUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureLock executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureLockTasks.AzureLockPath;
        public override Action<OutputType, string> CustomLogger => AzureLockTasks.AzureLockLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The type of lock restriction.
        /// </summary>
        public virtual LockLockType LockType { get; internal set; }
        /// <summary>
        ///   Name of the lock.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   Notes about this lock.
        /// </summary>
        public virtual string Notes { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
        /// </summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("lock update")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--notes {value}", Notes)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
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
    #region AzureLockCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureLockTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLockCreateSettingsExtensions
    {
        #region LockType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetLockType(this AzureLockCreateSettings toolSettings, LockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetLockType(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetName(this AzureLockCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetName(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetNamespace(this AzureLockCreateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetNamespace(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetNotes(this AzureLockCreateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetNotes(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetParent(this AzureLockCreateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetParent(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.Resource"/></em></p>
        ///   <p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetResource(this AzureLockCreateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.Resource"/></em></p>
        ///   <p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetResource(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetResourceGroup(this AzureLockCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetResourceGroup(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetResourceType(this AzureLockCreateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetResourceType(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetSubscription(this AzureLockCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetSubscription(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetDebug(this AzureLockCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetDebug(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetHelp(this AzureLockCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetHelp(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetOutput(this AzureLockCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetOutput(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetQuery(this AzureLockCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetQuery(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings SetVerbose(this AzureLockCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockCreateSettings ResetVerbose(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLockDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureLockTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLockDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetIds(this AzureLockDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetIds(this AzureLockDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings AddIds(this AzureLockDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings AddIds(this AzureLockDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings ClearIds(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings RemoveIds(this AzureLockDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings RemoveIds(this AzureLockDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetName(this AzureLockDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockDeleteSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings ResetName(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetNamespace(this AzureLockDeleteSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockDeleteSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings ResetNamespace(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetParent(this AzureLockDeleteSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockDeleteSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings ResetParent(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.Resource"/></em></p>
        ///   <p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetResource(this AzureLockDeleteSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockDeleteSettings.Resource"/></em></p>
        ///   <p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings ResetResource(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetResourceGroup(this AzureLockDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings ResetResourceGroup(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetResourceType(this AzureLockDeleteSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockDeleteSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings ResetResourceType(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetSubscription(this AzureLockDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings ResetSubscription(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetDebug(this AzureLockDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings ResetDebug(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetHelp(this AzureLockDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings ResetHelp(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetOutput(this AzureLockDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings ResetOutput(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetQuery(this AzureLockDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings ResetQuery(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings SetVerbose(this AzureLockDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockDeleteSettings ResetVerbose(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLockListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureLockTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLockListSettingsExtensions
    {
        #region FilterString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockListSettings.FilterString"/></em></p>
        ///   <p>A query filter to use to restrict the results.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings SetFilterString(this AzureLockListSettings toolSettings, string filterString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = filterString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockListSettings.FilterString"/></em></p>
        ///   <p>A query filter to use to restrict the results.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings ResetFilterString(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings SetNamespace(this AzureLockListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings ResetNamespace(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockListSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings SetParent(this AzureLockListSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockListSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings ResetParent(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockListSettings.Resource"/></em></p>
        ///   <p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings SetResource(this AzureLockListSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockListSettings.Resource"/></em></p>
        ///   <p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings ResetResource(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings SetResourceGroup(this AzureLockListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings ResetResourceGroup(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockListSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings SetResourceType(this AzureLockListSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockListSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings ResetResourceType(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings SetSubscription(this AzureLockListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings ResetSubscription(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings SetDebug(this AzureLockListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings ResetDebug(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings SetHelp(this AzureLockListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings ResetHelp(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings SetOutput(this AzureLockListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings ResetOutput(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings SetQuery(this AzureLockListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings ResetQuery(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings SetVerbose(this AzureLockListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockListSettings ResetVerbose(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLockShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureLockTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLockShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetIds(this AzureLockShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetIds(this AzureLockShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings AddIds(this AzureLockShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings AddIds(this AzureLockShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings ClearIds(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings RemoveIds(this AzureLockShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings RemoveIds(this AzureLockShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetName(this AzureLockShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockShowSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings ResetName(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetNamespace(this AzureLockShowSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockShowSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings ResetNamespace(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetParent(this AzureLockShowSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockShowSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings ResetParent(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.Resource"/></em></p>
        ///   <p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetResource(this AzureLockShowSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockShowSettings.Resource"/></em></p>
        ///   <p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings ResetResource(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetResourceGroup(this AzureLockShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings ResetResourceGroup(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetResourceType(this AzureLockShowSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockShowSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings ResetResourceType(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetSubscription(this AzureLockShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings ResetSubscription(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetDebug(this AzureLockShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings ResetDebug(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetHelp(this AzureLockShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings ResetHelp(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetOutput(this AzureLockShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings ResetOutput(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetQuery(this AzureLockShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings ResetQuery(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings SetVerbose(this AzureLockShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockShowSettings ResetVerbose(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLockUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureLockTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLockUpdateSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetIds(this AzureLockUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetIds(this AzureLockUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings AddIds(this AzureLockUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings AddIds(this AzureLockUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ClearIds(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings RemoveIds(this AzureLockUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings RemoveIds(this AzureLockUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region LockType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetLockType(this AzureLockUpdateSettings toolSettings, LockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetLockType(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetName(this AzureLockUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetName(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetNamespace(this AzureLockUpdateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetNamespace(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetNotes(this AzureLockUpdateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetNotes(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetParent(this AzureLockUpdateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetParent(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.Resource"/></em></p>
        ///   <p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetResource(this AzureLockUpdateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.Resource"/></em></p>
        ///   <p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetResource(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetResourceGroup(this AzureLockUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetResourceGroup(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetResourceType(this AzureLockUpdateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetResourceType(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetSubscription(this AzureLockUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetSubscription(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetDebug(this AzureLockUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetDebug(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetHelp(this AzureLockUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetHelp(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetOutput(this AzureLockUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetOutput(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetQuery(this AzureLockUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetQuery(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLockUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings SetVerbose(this AzureLockUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLockUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLockUpdateSettings ResetVerbose(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region LockLockType
    /// <summary>
    ///   Used within <see cref="AzureLockTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<LockLockType>))]
    public partial class LockLockType : Enumeration
    {
        public static LockLockType cannotdelete = new LockLockType { Value = "cannotdelete" };
        public static LockLockType readonly_ = new LockLockType { Value = "readonly" };
    }
    #endregion
}
