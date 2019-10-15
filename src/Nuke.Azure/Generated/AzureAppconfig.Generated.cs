// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAppconfig.json
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
    public static partial class AzureAppconfigTasks
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public static string AzureAppconfigPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREAPPCONFIG_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureAppconfigLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage App Configurations.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfig(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureAppconfigPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureAppconfigLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigCreate(AzureAppconfigCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAppconfigCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigCreate(Configure<AzureAppconfigCreateSettings> configurator)
        {
            return AzureAppconfigCreate(configurator(new AzureAppconfigCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAppconfigCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigCreate(CombinatorialConfigure<AzureAppconfigCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigCreate, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigDelete(AzureAppconfigDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigDelete(Configure<AzureAppconfigDeleteSettings> configurator)
        {
            return AzureAppconfigDelete(configurator(new AzureAppconfigDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigDelete(CombinatorialConfigure<AzureAppconfigDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigDelete, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigList(AzureAppconfigListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigList(Configure<AzureAppconfigListSettings> configurator)
        {
            return AzureAppconfigList(configurator(new AzureAppconfigListSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigList(CombinatorialConfigure<AzureAppconfigListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigList, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigShow(AzureAppconfigShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigShow(Configure<AzureAppconfigShowSettings> configurator)
        {
            return AzureAppconfigShow(configurator(new AzureAppconfigShowSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigShow(CombinatorialConfigure<AzureAppconfigShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigShow, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigUpdate(AzureAppconfigUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureAppconfigUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureAppconfigUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureAppconfigUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureAppconfigUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureAppconfigUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigUpdate(Configure<AzureAppconfigUpdateSettings> configurator)
        {
            return AzureAppconfigUpdate(configurator(new AzureAppconfigUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureAppconfigUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureAppconfigUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureAppconfigUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureAppconfigUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureAppconfigUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigUpdate(CombinatorialConfigure<AzureAppconfigUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigUpdate, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigCredentialList(AzureAppconfigCredentialListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigCredentialListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigCredentialListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigCredentialListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigCredentialListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigCredentialListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigCredentialListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigCredentialListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigCredentialListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigCredentialListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigCredentialList(Configure<AzureAppconfigCredentialListSettings> configurator)
        {
            return AzureAppconfigCredentialList(configurator(new AzureAppconfigCredentialListSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigCredentialListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigCredentialListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigCredentialListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigCredentialListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigCredentialListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigCredentialListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigCredentialListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigCredentialListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigCredentialListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigCredentialList(CombinatorialConfigure<AzureAppconfigCredentialListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigCredentialList, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigCredentialRegenerate(AzureAppconfigCredentialRegenerateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigCredentialRegenerateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Id"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigCredentialRegenerate(Configure<AzureAppconfigCredentialRegenerateSettings> configurator)
        {
            return AzureAppconfigCredentialRegenerate(configurator(new AzureAppconfigCredentialRegenerateSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Id"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigCredentialRegenerateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigCredentialRegenerateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigCredentialRegenerate(CombinatorialConfigure<AzureAppconfigCredentialRegenerateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigCredentialRegenerate, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigKvDelete(AzureAppconfigKvDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigKvDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvDeleteSettings.ConnectionString"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigKvDeleteSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvDeleteSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvDeleteSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigKvDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigKvDelete(Configure<AzureAppconfigKvDeleteSettings> configurator)
        {
            return AzureAppconfigKvDelete(configurator(new AzureAppconfigKvDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvDeleteSettings.ConnectionString"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigKvDeleteSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvDeleteSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvDeleteSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigKvDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigKvDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigKvDelete(CombinatorialConfigure<AzureAppconfigKvDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigKvDelete, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigKvExport(AzureAppconfigKvExportSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigKvExportSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--appservice-account</c> via <see cref="AzureAppconfigKvExportSettings.AppserviceAccount"/></li>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvExportSettings.ConnectionString"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvExportSettings.Debug"/></li>
        ///     <li><c>--dest-connection-string</c> via <see cref="AzureAppconfigKvExportSettings.DestConnectionString"/></li>
        ///     <li><c>--dest-label</c> via <see cref="AzureAppconfigKvExportSettings.DestLabel"/></li>
        ///     <li><c>--dest-name</c> via <see cref="AzureAppconfigKvExportSettings.DestName"/></li>
        ///     <li><c>--destination</c> via <see cref="AzureAppconfigKvExportSettings.Destination"/></li>
        ///     <li><c>--format</c> via <see cref="AzureAppconfigKvExportSettings.Format"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvExportSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigKvExportSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvExportSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvExportSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvExportSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvExportSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureAppconfigKvExportSettings.Path"/></li>
        ///     <li><c>--prefix</c> via <see cref="AzureAppconfigKvExportSettings.Prefix"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvExportSettings.Query"/></li>
        ///     <li><c>--separator</c> via <see cref="AzureAppconfigKvExportSettings.Separator"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvExportSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvExportSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigKvExportSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigKvExport(Configure<AzureAppconfigKvExportSettings> configurator)
        {
            return AzureAppconfigKvExport(configurator(new AzureAppconfigKvExportSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--appservice-account</c> via <see cref="AzureAppconfigKvExportSettings.AppserviceAccount"/></li>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvExportSettings.ConnectionString"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvExportSettings.Debug"/></li>
        ///     <li><c>--dest-connection-string</c> via <see cref="AzureAppconfigKvExportSettings.DestConnectionString"/></li>
        ///     <li><c>--dest-label</c> via <see cref="AzureAppconfigKvExportSettings.DestLabel"/></li>
        ///     <li><c>--dest-name</c> via <see cref="AzureAppconfigKvExportSettings.DestName"/></li>
        ///     <li><c>--destination</c> via <see cref="AzureAppconfigKvExportSettings.Destination"/></li>
        ///     <li><c>--format</c> via <see cref="AzureAppconfigKvExportSettings.Format"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvExportSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigKvExportSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvExportSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvExportSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvExportSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvExportSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureAppconfigKvExportSettings.Path"/></li>
        ///     <li><c>--prefix</c> via <see cref="AzureAppconfigKvExportSettings.Prefix"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvExportSettings.Query"/></li>
        ///     <li><c>--separator</c> via <see cref="AzureAppconfigKvExportSettings.Separator"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvExportSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvExportSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigKvExportSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigKvExportSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigKvExport(CombinatorialConfigure<AzureAppconfigKvExportSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigKvExport, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigKvList(AzureAppconfigKvListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigKvListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--all</c> via <see cref="AzureAppconfigKvListSettings.All"/></li>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvListSettings.ConnectionString"/></li>
        ///     <li><c>--datetime</c> via <see cref="AzureAppconfigKvListSettings.Datetime"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvListSettings.Debug"/></li>
        ///     <li><c>--fields</c> via <see cref="AzureAppconfigKvListSettings.Fields"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvListSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvListSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvListSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureAppconfigKvListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigKvList(Configure<AzureAppconfigKvListSettings> configurator)
        {
            return AzureAppconfigKvList(configurator(new AzureAppconfigKvListSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--all</c> via <see cref="AzureAppconfigKvListSettings.All"/></li>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvListSettings.ConnectionString"/></li>
        ///     <li><c>--datetime</c> via <see cref="AzureAppconfigKvListSettings.Datetime"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvListSettings.Debug"/></li>
        ///     <li><c>--fields</c> via <see cref="AzureAppconfigKvListSettings.Fields"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvListSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvListSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvListSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureAppconfigKvListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigKvListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigKvList(CombinatorialConfigure<AzureAppconfigKvListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigKvList, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigKvLock(AzureAppconfigKvLockSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigKvLockSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvLockSettings.ConnectionString"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvLockSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvLockSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigKvLockSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvLockSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvLockSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvLockSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvLockSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvLockSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvLockSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvLockSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigKvLockSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigKvLock(Configure<AzureAppconfigKvLockSettings> configurator)
        {
            return AzureAppconfigKvLock(configurator(new AzureAppconfigKvLockSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvLockSettings.ConnectionString"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvLockSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvLockSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigKvLockSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvLockSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvLockSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvLockSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvLockSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvLockSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvLockSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvLockSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigKvLockSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigKvLockSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigKvLock(CombinatorialConfigure<AzureAppconfigKvLockSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigKvLock, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigKvRestore(AzureAppconfigKvRestoreSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigKvRestoreSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvRestoreSettings.ConnectionString"/></li>
        ///     <li><c>--datetime</c> via <see cref="AzureAppconfigKvRestoreSettings.Datetime"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvRestoreSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvRestoreSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvRestoreSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvRestoreSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvRestoreSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvRestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvRestoreSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvRestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvRestoreSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigKvRestoreSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigKvRestore(Configure<AzureAppconfigKvRestoreSettings> configurator)
        {
            return AzureAppconfigKvRestore(configurator(new AzureAppconfigKvRestoreSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvRestoreSettings.ConnectionString"/></li>
        ///     <li><c>--datetime</c> via <see cref="AzureAppconfigKvRestoreSettings.Datetime"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvRestoreSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvRestoreSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvRestoreSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvRestoreSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvRestoreSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvRestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvRestoreSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvRestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvRestoreSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigKvRestoreSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigKvRestoreSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigKvRestore(CombinatorialConfigure<AzureAppconfigKvRestoreSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigKvRestore, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigKvSet(AzureAppconfigKvSetSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigKvSetSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvSetSettings.ConnectionString"/></li>
        ///     <li><c>--content-type</c> via <see cref="AzureAppconfigKvSetSettings.ContentType"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvSetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvSetSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigKvSetSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvSetSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvSetSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvSetSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvSetSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvSetSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvSetSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureAppconfigKvSetSettings.Tags"/></li>
        ///     <li><c>--value</c> via <see cref="AzureAppconfigKvSetSettings.Value"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvSetSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigKvSetSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigKvSet(Configure<AzureAppconfigKvSetSettings> configurator)
        {
            return AzureAppconfigKvSet(configurator(new AzureAppconfigKvSetSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvSetSettings.ConnectionString"/></li>
        ///     <li><c>--content-type</c> via <see cref="AzureAppconfigKvSetSettings.ContentType"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvSetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvSetSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigKvSetSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvSetSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvSetSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvSetSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvSetSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvSetSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvSetSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureAppconfigKvSetSettings.Tags"/></li>
        ///     <li><c>--value</c> via <see cref="AzureAppconfigKvSetSettings.Value"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvSetSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigKvSetSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigKvSetSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigKvSet(CombinatorialConfigure<AzureAppconfigKvSetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigKvSet, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigKvShow(AzureAppconfigKvShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigKvShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvShowSettings.ConnectionString"/></li>
        ///     <li><c>--datetime</c> via <see cref="AzureAppconfigKvShowSettings.Datetime"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigKvShowSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvShowSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvShowSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigKvShow(Configure<AzureAppconfigKvShowSettings> configurator)
        {
            return AzureAppconfigKvShow(configurator(new AzureAppconfigKvShowSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvShowSettings.ConnectionString"/></li>
        ///     <li><c>--datetime</c> via <see cref="AzureAppconfigKvShowSettings.Datetime"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigKvShowSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvShowSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvShowSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigKvShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigKvShow(CombinatorialConfigure<AzureAppconfigKvShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigKvShow, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigKvUnlock(AzureAppconfigKvUnlockSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigKvUnlockSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvUnlockSettings.ConnectionString"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvUnlockSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvUnlockSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigKvUnlockSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvUnlockSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvUnlockSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvUnlockSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvUnlockSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvUnlockSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvUnlockSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvUnlockSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigKvUnlockSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigKvUnlock(Configure<AzureAppconfigKvUnlockSettings> configurator)
        {
            return AzureAppconfigKvUnlock(configurator(new AzureAppconfigKvUnlockSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigKvUnlockSettings.ConnectionString"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigKvUnlockSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigKvUnlockSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppconfigKvUnlockSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigKvUnlockSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigKvUnlockSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigKvUnlockSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigKvUnlockSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigKvUnlockSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigKvUnlockSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigKvUnlockSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppconfigKvUnlockSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigKvUnlockSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigKvUnlock(CombinatorialConfigure<AzureAppconfigKvUnlockSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigKvUnlock, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppconfigRevisionList(AzureAppconfigRevisionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppconfigRevisionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--all</c> via <see cref="AzureAppconfigRevisionListSettings.All"/></li>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigRevisionListSettings.ConnectionString"/></li>
        ///     <li><c>--datetime</c> via <see cref="AzureAppconfigRevisionListSettings.Datetime"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigRevisionListSettings.Debug"/></li>
        ///     <li><c>--fields</c> via <see cref="AzureAppconfigRevisionListSettings.Fields"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigRevisionListSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigRevisionListSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigRevisionListSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigRevisionListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigRevisionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigRevisionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigRevisionListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureAppconfigRevisionListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigRevisionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppconfigRevisionList(Configure<AzureAppconfigRevisionListSettings> configurator)
        {
            return AzureAppconfigRevisionList(configurator(new AzureAppconfigRevisionListSettings()));
        }
        /// <summary>
        ///   <p>Manage App Configurations.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appconfig?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--all</c> via <see cref="AzureAppconfigRevisionListSettings.All"/></li>
        ///     <li><c>--connection-string</c> via <see cref="AzureAppconfigRevisionListSettings.ConnectionString"/></li>
        ///     <li><c>--datetime</c> via <see cref="AzureAppconfigRevisionListSettings.Datetime"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppconfigRevisionListSettings.Debug"/></li>
        ///     <li><c>--fields</c> via <see cref="AzureAppconfigRevisionListSettings.Fields"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppconfigRevisionListSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureAppconfigRevisionListSettings.Key"/></li>
        ///     <li><c>--label</c> via <see cref="AzureAppconfigRevisionListSettings.Label"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppconfigRevisionListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppconfigRevisionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppconfigRevisionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppconfigRevisionListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureAppconfigRevisionListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppconfigRevisionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppconfigRevisionListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppconfigRevisionList(CombinatorialConfigure<AzureAppconfigRevisionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppconfigRevisionList, AzureAppconfigLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureAppconfigCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
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
              .Add("appconfig create")
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
    #region AzureAppconfigDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
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
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
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
              .Add("appconfig delete")
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
    #region AzureAppconfigListSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
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
              .Add("appconfig list")
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
    #region AzureAppconfigShowSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
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
              .Add("appconfig show")
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
    #region AzureAppconfigUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
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
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
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
              .Add("appconfig update")
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
    #region AzureAppconfigCredentialListSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigCredentialListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
        /// <summary>
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
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
              .Add("appconfig credential list")
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
    #region AzureAppconfigCredentialRegenerateSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigCredentialRegenerateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
        /// <summary>
        ///   Id of the key to be regenerated. Can be found using az appconfig credential list command.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
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
              .Add("appconfig credential regenerate")
              .Add("--id {value}", Id)
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
    #region AzureAppconfigKvDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigKvDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
        /// <summary>
        ///   Support star sign as filters, for instance \* means all key and abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.
        /// </summary>
        public virtual string ConnectionString { get; internal set; }
        /// <summary>
        ///   If no label specified, delete entry with null label. Support star sign as filters, for instance \* means all label and abc\* means labels with abc as prefix. Similarly, \*abc and \*abc\* are also supported.
        /// </summary>
        public virtual string Label { get; internal set; }
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
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
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
              .Add("appconfig kv delete")
              .Add("--key {value}", Key)
              .Add("--connection-string {value}", ConnectionString)
              .Add("--label {value}", Label)
              .Add("--yes {value}", Yes)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureAppconfigKvExportSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigKvExportSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
        /// <summary>
        ///   The destination of exporting.
        /// </summary>
        public virtual AppconfigKvExportDestination Destination { get; internal set; }
        /// <summary>
        ///   Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.
        /// </summary>
        public virtual string ConnectionString { get; internal set; }
        /// <summary>
        ///   If no key specified, return all keys by default. Support star sign as filters, for instance abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Only keys with this label will be exported. If no label specified, export keys with null label by default.
        /// </summary>
        public virtual string Label { get; internal set; }
        /// <summary>
        ///   Prefix to be trimed from keys.
        /// </summary>
        public virtual string Prefix { get; internal set; }
        /// <summary>
        ///   Do not prompt for preview.
        /// </summary>
        public virtual string Yes { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Connections of access key and endpoint of the destination store.
        /// </summary>
        public virtual string DestConnectionString { get; internal set; }
        /// <summary>
        ///   Exported KVs will be labeled with this destination label.
        /// </summary>
        public virtual string DestLabel { get; internal set; }
        /// <summary>
        ///   The name of the destination App Configuration.
        /// </summary>
        public virtual string DestName { get; internal set; }
        /// <summary>
        ///   ARM ID for AppService OR the name of the AppService, assuming the it is in the same subscription and resource group as the App Configuration. Required for AppService arguments.
        /// </summary>
        public virtual string AppserviceAccount { get; internal set; }
        /// <summary>
        ///   File format exporting to. Required for file arguments.
        /// </summary>
        public virtual AppconfigKvExportFormat Format { get; internal set; }
        /// <summary>
        ///   Local configuration file path. Required for file arguments.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Delimiter for flatterning the json or yaml file to key-value pairs. Required for importing hierarchical structure. Not applicable for property files. Supported values: '.', ',', ';', '-', '_', '__', '/', ':', ''.
        /// </summary>
        public virtual string Separator { get; internal set; }
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
              .Add("appconfig kv export")
              .Add("--destination {value}", Destination)
              .Add("--connection-string {value}", ConnectionString)
              .Add("--key {value}", Key)
              .Add("--label {value}", Label)
              .Add("--prefix {value}", Prefix)
              .Add("--yes {value}", Yes)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--subscription {value}", Subscription)
              .Add("--dest-connection-string {value}", DestConnectionString)
              .Add("--dest-label {value}", DestLabel)
              .Add("--dest-name {value}", DestName)
              .Add("--appservice-account {value}", AppserviceAccount)
              .Add("--format {value}", Format)
              .Add("--path {value}", Path)
              .Add("--separator {value}", Separator)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAppconfigKvListSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigKvListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
        /// <summary>
        ///   List all items.
        /// </summary>
        public virtual string All { get; internal set; }
        /// <summary>
        ///   Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.
        /// </summary>
        public virtual string ConnectionString { get; internal set; }
        /// <summary>
        ///   Format: "YYYY-MM-DDThh:mm:ssZ". If no time zone specified, use UTC by default.
        /// </summary>
        public virtual string Datetime { get; internal set; }
        /// <summary>
        ///   Customize output fields.
        /// </summary>
        public virtual AppconfigKvFields Fields { get; internal set; }
        /// <summary>
        ///   If no key specified, return all keys by default. Support star sign as filters, for instance abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   If no label specified, list all labels. Support star sign as filters, for instance abc\* means labels with abc as prefix. Similarly, \*abc and \*abc\* are also supported.
        /// </summary>
        public virtual string Label { get; internal set; }
        /// <summary>
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Maximum number of items to return. Default to 100.
        /// </summary>
        public virtual int? Top { get; internal set; }
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
              .Add("appconfig kv list")
              .Add("--all {value}", All)
              .Add("--connection-string {value}", ConnectionString)
              .Add("--datetime {value}", Datetime)
              .Add("--fields {value}", Fields)
              .Add("--key {value}", Key)
              .Add("--label {value}", Label)
              .Add("--name {value}", Name)
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
    #region AzureAppconfigKvLockSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigKvLockSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
        /// <summary>
        ///   Key to be locked.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.
        /// </summary>
        public virtual string ConnectionString { get; internal set; }
        /// <summary>
        ///   If no label specified, lock entry with null label. Does NOT support filters like other commands.
        /// </summary>
        public virtual string Label { get; internal set; }
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
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
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
              .Add("appconfig kv lock")
              .Add("--key {value}", Key)
              .Add("--connection-string {value}", ConnectionString)
              .Add("--label {value}", Label)
              .Add("--yes {value}", Yes)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureAppconfigKvRestoreSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigKvRestoreSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
        /// <summary>
        ///   Format: "YYYY-MM-DDThh:mm:ssZ". If no time zone specified, use UTC by default.
        /// </summary>
        public virtual string Datetime { get; internal set; }
        /// <summary>
        ///   Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.
        /// </summary>
        public virtual string ConnectionString { get; internal set; }
        /// <summary>
        ///   If no key specified, restore all keys by default. Support star sign as filters, for instance abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   If no label specified, restore all key-value pairs with all labels. Support star sign as filters, for instance abc\* means labels with abc as prefix. Similarly, \*abc and \*abc\* are also supported.
        /// </summary>
        public virtual string Label { get; internal set; }
        /// <summary>
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
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
              .Add("appconfig kv restore")
              .Add("--datetime {value}", Datetime)
              .Add("--connection-string {value}", ConnectionString)
              .Add("--key {value}", Key)
              .Add("--label {value}", Label)
              .Add("--name {value}", Name)
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
    #region AzureAppconfigKvSetSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigKvSetSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
        /// <summary>
        ///   Key to be set.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.
        /// </summary>
        public virtual string ConnectionString { get; internal set; }
        /// <summary>
        ///   Content type of the keyvalue to be set.
        /// </summary>
        public virtual string ContentType { get; internal set; }
        /// <summary>
        ///   If no label specified, set the key with null label by default.
        /// </summary>
        public virtual string Label { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   Value of the keyvalue to be set.
        /// </summary>
        public virtual string Value { get; internal set; }
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
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
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
              .Add("appconfig kv set")
              .Add("--key {value}", Key)
              .Add("--connection-string {value}", ConnectionString)
              .Add("--content-type {value}", ContentType)
              .Add("--label {value}", Label)
              .Add("--tags {value}", Tags)
              .Add("--value {value}", Value)
              .Add("--yes {value}", Yes)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureAppconfigKvShowSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigKvShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
        /// <summary>
        ///   Key to be showed.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.
        /// </summary>
        public virtual string ConnectionString { get; internal set; }
        /// <summary>
        ///   Format: "YYYY-MM-DDThh:mm:ssZ". If no time zone specified, use UTC by default.
        /// </summary>
        public virtual string Datetime { get; internal set; }
        /// <summary>
        ///   If no label specified, show entry with null label. Does NOT support filters like other commands.
        /// </summary>
        public virtual string Label { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
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
              .Add("appconfig kv show")
              .Add("--key {value}", Key)
              .Add("--connection-string {value}", ConnectionString)
              .Add("--datetime {value}", Datetime)
              .Add("--label {value}", Label)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureAppconfigKvUnlockSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigKvUnlockSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
        /// <summary>
        ///   Key to be unlocked.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.
        /// </summary>
        public virtual string ConnectionString { get; internal set; }
        /// <summary>
        ///   If no label specified, unlock entry with null label. Does NOT support filters like other commands.
        /// </summary>
        public virtual string Label { get; internal set; }
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
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
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
              .Add("appconfig kv unlock")
              .Add("--key {value}", Key)
              .Add("--connection-string {value}", ConnectionString)
              .Add("--label {value}", Label)
              .Add("--yes {value}", Yes)
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureAppconfigRevisionListSettings
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppconfigRevisionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppconfig executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppconfigTasks.AzureAppconfigPath;
        public override Action<OutputType, string> CustomLogger => AzureAppconfigTasks.AzureAppconfigLogger;
        /// <summary>
        ///   List all items.
        /// </summary>
        public virtual string All { get; internal set; }
        /// <summary>
        ///   Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.
        /// </summary>
        public virtual string ConnectionString { get; internal set; }
        /// <summary>
        ///   Format: "YYYY-MM-DDThh:mm:ssZ". If no time zone specified, use UTC by default.
        /// </summary>
        public virtual string Datetime { get; internal set; }
        /// <summary>
        ///   Customize output fields.
        /// </summary>
        public virtual AppconfigKvFields Fields { get; internal set; }
        /// <summary>
        ///   If no key specified, return all keys by default. Support star sign as filters, for instance abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   If no label specified, list all labels. Support star sign as filters, for instance abc\* means labels with abc as prefix. Similarly, \*abc and \*abc\* are also supported.
        /// </summary>
        public virtual string Label { get; internal set; }
        /// <summary>
        ///   Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Maximum number of items to return. Default to 100.
        /// </summary>
        public virtual int? Top { get; internal set; }
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
              .Add("appconfig revision list")
              .Add("--all {value}", All)
              .Add("--connection-string {value}", ConnectionString)
              .Add("--datetime {value}", Datetime)
              .Add("--fields {value}", Fields)
              .Add("--key {value}", Key)
              .Add("--label {value}", Label)
              .Add("--name {value}", Name)
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
    #region AzureAppconfigCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigCreateSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings SetLocation(this AzureAppconfigCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings ResetLocation(this AzureAppconfigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCreateSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings SetName(this AzureAppconfigCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCreateSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings ResetName(this AzureAppconfigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings SetResourceGroup(this AzureAppconfigCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings ResetResourceGroup(this AzureAppconfigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings SetSubscription(this AzureAppconfigCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings ResetSubscription(this AzureAppconfigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings SetDebug(this AzureAppconfigCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings ResetDebug(this AzureAppconfigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings SetHelp(this AzureAppconfigCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings ResetHelp(this AzureAppconfigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings SetOutput(this AzureAppconfigCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings ResetOutput(this AzureAppconfigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings SetQuery(this AzureAppconfigCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings ResetQuery(this AzureAppconfigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings SetVerbose(this AzureAppconfigCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCreateSettings ResetVerbose(this AzureAppconfigCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigDeleteSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings SetYes(this AzureAppconfigDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings ResetYes(this AzureAppconfigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings SetIds(this AzureAppconfigDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings SetIds(this AzureAppconfigDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings AddIds(this AzureAppconfigDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings AddIds(this AzureAppconfigDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAppconfigDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings ClearIds(this AzureAppconfigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings RemoveIds(this AzureAppconfigDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings RemoveIds(this AzureAppconfigDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigDeleteSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings SetName(this AzureAppconfigDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigDeleteSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings ResetName(this AzureAppconfigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings SetResourceGroup(this AzureAppconfigDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings ResetResourceGroup(this AzureAppconfigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings SetSubscription(this AzureAppconfigDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings ResetSubscription(this AzureAppconfigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings SetDebug(this AzureAppconfigDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings ResetDebug(this AzureAppconfigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings SetHelp(this AzureAppconfigDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings ResetHelp(this AzureAppconfigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings SetOutput(this AzureAppconfigDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings ResetOutput(this AzureAppconfigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings SetQuery(this AzureAppconfigDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings ResetQuery(this AzureAppconfigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings SetVerbose(this AzureAppconfigDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigDeleteSettings ResetVerbose(this AzureAppconfigDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings SetResourceGroup(this AzureAppconfigListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings ResetResourceGroup(this AzureAppconfigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings SetSubscription(this AzureAppconfigListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings ResetSubscription(this AzureAppconfigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings SetDebug(this AzureAppconfigListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings ResetDebug(this AzureAppconfigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings SetHelp(this AzureAppconfigListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings ResetHelp(this AzureAppconfigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings SetOutput(this AzureAppconfigListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings ResetOutput(this AzureAppconfigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings SetQuery(this AzureAppconfigListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings ResetQuery(this AzureAppconfigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings SetVerbose(this AzureAppconfigListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigListSettings ResetVerbose(this AzureAppconfigListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings SetIds(this AzureAppconfigShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings SetIds(this AzureAppconfigShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings AddIds(this AzureAppconfigShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings AddIds(this AzureAppconfigShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAppconfigShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings ClearIds(this AzureAppconfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings RemoveIds(this AzureAppconfigShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings RemoveIds(this AzureAppconfigShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigShowSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings SetName(this AzureAppconfigShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigShowSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings ResetName(this AzureAppconfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings SetResourceGroup(this AzureAppconfigShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings ResetResourceGroup(this AzureAppconfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings SetSubscription(this AzureAppconfigShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings ResetSubscription(this AzureAppconfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings SetDebug(this AzureAppconfigShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings ResetDebug(this AzureAppconfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings SetHelp(this AzureAppconfigShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings ResetHelp(this AzureAppconfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings SetOutput(this AzureAppconfigShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings ResetOutput(this AzureAppconfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings SetQuery(this AzureAppconfigShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings ResetQuery(this AzureAppconfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings SetVerbose(this AzureAppconfigShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigShowSettings ResetVerbose(this AzureAppconfigShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigUpdateSettingsExtensions
    {
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetTags(this AzureAppconfigUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ResetTags(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetIds(this AzureAppconfigUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetIds(this AzureAppconfigUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings AddIds(this AzureAppconfigUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings AddIds(this AzureAppconfigUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAppconfigUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ClearIds(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings RemoveIds(this AzureAppconfigUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings RemoveIds(this AzureAppconfigUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetName(this AzureAppconfigUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigUpdateSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ResetName(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetResourceGroup(this AzureAppconfigUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ResetResourceGroup(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetSubscription(this AzureAppconfigUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ResetSubscription(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetAdd(this AzureAppconfigUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ResetAdd(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetForceString(this AzureAppconfigUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ResetForceString(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetRemove(this AzureAppconfigUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ResetRemove(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetSet(this AzureAppconfigUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ResetSet(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetDebug(this AzureAppconfigUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ResetDebug(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetHelp(this AzureAppconfigUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ResetHelp(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetOutput(this AzureAppconfigUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ResetOutput(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetQuery(this AzureAppconfigUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ResetQuery(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings SetVerbose(this AzureAppconfigUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigUpdateSettings ResetVerbose(this AzureAppconfigUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigCredentialListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigCredentialListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialListSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings SetName(this AzureAppconfigCredentialListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialListSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings ResetName(this AzureAppconfigCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings SetResourceGroup(this AzureAppconfigCredentialListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings ResetResourceGroup(this AzureAppconfigCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings SetSubscription(this AzureAppconfigCredentialListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings ResetSubscription(this AzureAppconfigCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings SetDebug(this AzureAppconfigCredentialListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings ResetDebug(this AzureAppconfigCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings SetHelp(this AzureAppconfigCredentialListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings ResetHelp(this AzureAppconfigCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings SetOutput(this AzureAppconfigCredentialListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings ResetOutput(this AzureAppconfigCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings SetQuery(this AzureAppconfigCredentialListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings ResetQuery(this AzureAppconfigCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings SetVerbose(this AzureAppconfigCredentialListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialListSettings ResetVerbose(this AzureAppconfigCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigCredentialRegenerateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigCredentialRegenerateSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialRegenerateSettings.Id"/></em></p>
        ///   <p>Id of the key to be regenerated. Can be found using az appconfig credential list command.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings SetId(this AzureAppconfigCredentialRegenerateSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialRegenerateSettings.Id"/></em></p>
        ///   <p>Id of the key to be regenerated. Can be found using az appconfig credential list command.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings ResetId(this AzureAppconfigCredentialRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialRegenerateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings SetIds(this AzureAppconfigCredentialRegenerateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialRegenerateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings SetIds(this AzureAppconfigCredentialRegenerateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigCredentialRegenerateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings AddIds(this AzureAppconfigCredentialRegenerateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigCredentialRegenerateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings AddIds(this AzureAppconfigCredentialRegenerateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAppconfigCredentialRegenerateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings ClearIds(this AzureAppconfigCredentialRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigCredentialRegenerateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings RemoveIds(this AzureAppconfigCredentialRegenerateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigCredentialRegenerateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings RemoveIds(this AzureAppconfigCredentialRegenerateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialRegenerateSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings SetName(this AzureAppconfigCredentialRegenerateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialRegenerateSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings ResetName(this AzureAppconfigCredentialRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialRegenerateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings SetResourceGroup(this AzureAppconfigCredentialRegenerateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialRegenerateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings ResetResourceGroup(this AzureAppconfigCredentialRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialRegenerateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings SetSubscription(this AzureAppconfigCredentialRegenerateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialRegenerateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings ResetSubscription(this AzureAppconfigCredentialRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialRegenerateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings SetDebug(this AzureAppconfigCredentialRegenerateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialRegenerateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings ResetDebug(this AzureAppconfigCredentialRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialRegenerateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings SetHelp(this AzureAppconfigCredentialRegenerateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialRegenerateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings ResetHelp(this AzureAppconfigCredentialRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialRegenerateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings SetOutput(this AzureAppconfigCredentialRegenerateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialRegenerateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings ResetOutput(this AzureAppconfigCredentialRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialRegenerateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings SetQuery(this AzureAppconfigCredentialRegenerateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialRegenerateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings ResetQuery(this AzureAppconfigCredentialRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigCredentialRegenerateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings SetVerbose(this AzureAppconfigCredentialRegenerateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigCredentialRegenerateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigCredentialRegenerateSettings ResetVerbose(this AzureAppconfigCredentialRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigKvDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigKvDeleteSettingsExtensions
    {
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvDeleteSettings.Key"/></em></p>
        ///   <p>Support star sign as filters, for instance \* means all key and abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings SetKey(this AzureAppconfigKvDeleteSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvDeleteSettings.Key"/></em></p>
        ///   <p>Support star sign as filters, for instance \* means all key and abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings ResetKey(this AzureAppconfigKvDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region ConnectionString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvDeleteSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings SetConnectionString(this AzureAppconfigKvDeleteSettings toolSettings, string connectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = connectionString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvDeleteSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings ResetConnectionString(this AzureAppconfigKvDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region Label
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvDeleteSettings.Label"/></em></p>
        ///   <p>If no label specified, delete entry with null label. Support star sign as filters, for instance \* means all label and abc\* means labels with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings SetLabel(this AzureAppconfigKvDeleteSettings toolSettings, string label)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = label;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvDeleteSettings.Label"/></em></p>
        ///   <p>If no label specified, delete entry with null label. Support star sign as filters, for instance \* means all label and abc\* means labels with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings ResetLabel(this AzureAppconfigKvDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings SetYes(this AzureAppconfigKvDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings ResetYes(this AzureAppconfigKvDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings SetIds(this AzureAppconfigKvDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings SetIds(this AzureAppconfigKvDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigKvDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings AddIds(this AzureAppconfigKvDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigKvDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings AddIds(this AzureAppconfigKvDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAppconfigKvDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings ClearIds(this AzureAppconfigKvDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigKvDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings RemoveIds(this AzureAppconfigKvDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigKvDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings RemoveIds(this AzureAppconfigKvDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvDeleteSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings SetName(this AzureAppconfigKvDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvDeleteSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings ResetName(this AzureAppconfigKvDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings SetSubscription(this AzureAppconfigKvDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings ResetSubscription(this AzureAppconfigKvDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings SetDebug(this AzureAppconfigKvDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings ResetDebug(this AzureAppconfigKvDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings SetHelp(this AzureAppconfigKvDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings ResetHelp(this AzureAppconfigKvDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings SetOutput(this AzureAppconfigKvDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings ResetOutput(this AzureAppconfigKvDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings SetQuery(this AzureAppconfigKvDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings ResetQuery(this AzureAppconfigKvDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings SetVerbose(this AzureAppconfigKvDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvDeleteSettings ResetVerbose(this AzureAppconfigKvDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigKvExportSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigKvExportSettingsExtensions
    {
        #region Destination
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Destination"/></em></p>
        ///   <p>The destination of exporting.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetDestination(this AzureAppconfigKvExportSettings toolSettings, AppconfigKvExportDestination destination)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Destination = destination;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Destination"/></em></p>
        ///   <p>The destination of exporting.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetDestination(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Destination = null;
            return toolSettings;
        }
        #endregion
        #region ConnectionString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetConnectionString(this AzureAppconfigKvExportSettings toolSettings, string connectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = connectionString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetConnectionString(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Key"/></em></p>
        ///   <p>If no key specified, return all keys by default. Support star sign as filters, for instance abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetKey(this AzureAppconfigKvExportSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Key"/></em></p>
        ///   <p>If no key specified, return all keys by default. Support star sign as filters, for instance abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetKey(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Label
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Label"/></em></p>
        ///   <p>Only keys with this label will be exported. If no label specified, export keys with null label by default.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetLabel(this AzureAppconfigKvExportSettings toolSettings, string label)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = label;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Label"/></em></p>
        ///   <p>Only keys with this label will be exported. If no label specified, export keys with null label by default.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetLabel(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = null;
            return toolSettings;
        }
        #endregion
        #region Prefix
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Prefix"/></em></p>
        ///   <p>Prefix to be trimed from keys.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetPrefix(this AzureAppconfigKvExportSettings toolSettings, string prefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Prefix = prefix;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Prefix"/></em></p>
        ///   <p>Prefix to be trimed from keys.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetPrefix(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Prefix = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Yes"/></em></p>
        ///   <p>Do not prompt for preview.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetYes(this AzureAppconfigKvExportSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Yes"/></em></p>
        ///   <p>Do not prompt for preview.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetYes(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetIds(this AzureAppconfigKvExportSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetIds(this AzureAppconfigKvExportSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigKvExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings AddIds(this AzureAppconfigKvExportSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigKvExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings AddIds(this AzureAppconfigKvExportSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAppconfigKvExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ClearIds(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigKvExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings RemoveIds(this AzureAppconfigKvExportSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigKvExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings RemoveIds(this AzureAppconfigKvExportSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetName(this AzureAppconfigKvExportSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetName(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetSubscription(this AzureAppconfigKvExportSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetSubscription(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region DestConnectionString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.DestConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of the destination store.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetDestConnectionString(this AzureAppconfigKvExportSettings toolSettings, string destConnectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestConnectionString = destConnectionString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.DestConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of the destination store.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetDestConnectionString(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region DestLabel
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.DestLabel"/></em></p>
        ///   <p>Exported KVs will be labeled with this destination label.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetDestLabel(this AzureAppconfigKvExportSettings toolSettings, string destLabel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestLabel = destLabel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.DestLabel"/></em></p>
        ///   <p>Exported KVs will be labeled with this destination label.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetDestLabel(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestLabel = null;
            return toolSettings;
        }
        #endregion
        #region DestName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.DestName"/></em></p>
        ///   <p>The name of the destination App Configuration.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetDestName(this AzureAppconfigKvExportSettings toolSettings, string destName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestName = destName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.DestName"/></em></p>
        ///   <p>The name of the destination App Configuration.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetDestName(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestName = null;
            return toolSettings;
        }
        #endregion
        #region AppserviceAccount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.AppserviceAccount"/></em></p>
        ///   <p>ARM ID for AppService OR the name of the AppService, assuming the it is in the same subscription and resource group as the App Configuration. Required for AppService arguments.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetAppserviceAccount(this AzureAppconfigKvExportSettings toolSettings, string appserviceAccount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppserviceAccount = appserviceAccount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.AppserviceAccount"/></em></p>
        ///   <p>ARM ID for AppService OR the name of the AppService, assuming the it is in the same subscription and resource group as the App Configuration. Required for AppService arguments.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetAppserviceAccount(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppserviceAccount = null;
            return toolSettings;
        }
        #endregion
        #region Format
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Format"/></em></p>
        ///   <p>File format exporting to. Required for file arguments.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetFormat(this AzureAppconfigKvExportSettings toolSettings, AppconfigKvExportFormat format)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Format = format;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Format"/></em></p>
        ///   <p>File format exporting to. Required for file arguments.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetFormat(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Format = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Path"/></em></p>
        ///   <p>Local configuration file path. Required for file arguments.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetPath(this AzureAppconfigKvExportSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Path"/></em></p>
        ///   <p>Local configuration file path. Required for file arguments.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetPath(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Separator
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Separator"/></em></p>
        ///   <p>Delimiter for flatterning the json or yaml file to key-value pairs. Required for importing hierarchical structure. Not applicable for property files. Supported values: '.', ',', ';', '-', '_', '__', '/', ':', ''.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetSeparator(this AzureAppconfigKvExportSettings toolSettings, string separator)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Separator = separator;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Separator"/></em></p>
        ///   <p>Delimiter for flatterning the json or yaml file to key-value pairs. Required for importing hierarchical structure. Not applicable for property files. Supported values: '.', ',', ';', '-', '_', '__', '/', ':', ''.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetSeparator(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Separator = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetDebug(this AzureAppconfigKvExportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetDebug(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetHelp(this AzureAppconfigKvExportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetHelp(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetOutput(this AzureAppconfigKvExportSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetOutput(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetQuery(this AzureAppconfigKvExportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetQuery(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvExportSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings SetVerbose(this AzureAppconfigKvExportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvExportSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvExportSettings ResetVerbose(this AzureAppconfigKvExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigKvListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigKvListSettingsExtensions
    {
        #region All
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.All"/></em></p>
        ///   <p>List all items.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetAll(this AzureAppconfigKvListSettings toolSettings, string all)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = all;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.All"/></em></p>
        ///   <p>List all items.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetAll(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = null;
            return toolSettings;
        }
        #endregion
        #region ConnectionString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetConnectionString(this AzureAppconfigKvListSettings toolSettings, string connectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = connectionString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetConnectionString(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region Datetime
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.Datetime"/></em></p>
        ///   <p>Format: "YYYY-MM-DDThh:mm:ssZ". If no time zone specified, use UTC by default.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetDatetime(this AzureAppconfigKvListSettings toolSettings, string datetime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Datetime = datetime;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.Datetime"/></em></p>
        ///   <p>Format: "YYYY-MM-DDThh:mm:ssZ". If no time zone specified, use UTC by default.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetDatetime(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Datetime = null;
            return toolSettings;
        }
        #endregion
        #region Fields
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.Fields"/></em></p>
        ///   <p>Customize output fields.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetFields(this AzureAppconfigKvListSettings toolSettings, AppconfigKvFields fields)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Fields = fields;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.Fields"/></em></p>
        ///   <p>Customize output fields.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetFields(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Fields = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.Key"/></em></p>
        ///   <p>If no key specified, return all keys by default. Support star sign as filters, for instance abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetKey(this AzureAppconfigKvListSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.Key"/></em></p>
        ///   <p>If no key specified, return all keys by default. Support star sign as filters, for instance abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetKey(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Label
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.Label"/></em></p>
        ///   <p>If no label specified, list all labels. Support star sign as filters, for instance abc\* means labels with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetLabel(this AzureAppconfigKvListSettings toolSettings, string label)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = label;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.Label"/></em></p>
        ///   <p>If no label specified, list all labels. Support star sign as filters, for instance abc\* means labels with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetLabel(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetName(this AzureAppconfigKvListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetName(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.Top"/></em></p>
        ///   <p>Maximum number of items to return. Default to 100.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetTop(this AzureAppconfigKvListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.Top"/></em></p>
        ///   <p>Maximum number of items to return. Default to 100.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetTop(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetSubscription(this AzureAppconfigKvListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetSubscription(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetDebug(this AzureAppconfigKvListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetDebug(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetHelp(this AzureAppconfigKvListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetHelp(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetOutput(this AzureAppconfigKvListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetOutput(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetQuery(this AzureAppconfigKvListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetQuery(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings SetVerbose(this AzureAppconfigKvListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvListSettings ResetVerbose(this AzureAppconfigKvListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigKvLockSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigKvLockSettingsExtensions
    {
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvLockSettings.Key"/></em></p>
        ///   <p>Key to be locked.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings SetKey(this AzureAppconfigKvLockSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvLockSettings.Key"/></em></p>
        ///   <p>Key to be locked.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings ResetKey(this AzureAppconfigKvLockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region ConnectionString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvLockSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings SetConnectionString(this AzureAppconfigKvLockSettings toolSettings, string connectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = connectionString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvLockSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings ResetConnectionString(this AzureAppconfigKvLockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region Label
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvLockSettings.Label"/></em></p>
        ///   <p>If no label specified, lock entry with null label. Does NOT support filters like other commands.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings SetLabel(this AzureAppconfigKvLockSettings toolSettings, string label)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = label;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvLockSettings.Label"/></em></p>
        ///   <p>If no label specified, lock entry with null label. Does NOT support filters like other commands.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings ResetLabel(this AzureAppconfigKvLockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvLockSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings SetYes(this AzureAppconfigKvLockSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvLockSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings ResetYes(this AzureAppconfigKvLockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvLockSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings SetIds(this AzureAppconfigKvLockSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvLockSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings SetIds(this AzureAppconfigKvLockSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigKvLockSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings AddIds(this AzureAppconfigKvLockSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigKvLockSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings AddIds(this AzureAppconfigKvLockSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAppconfigKvLockSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings ClearIds(this AzureAppconfigKvLockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigKvLockSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings RemoveIds(this AzureAppconfigKvLockSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigKvLockSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings RemoveIds(this AzureAppconfigKvLockSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvLockSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings SetName(this AzureAppconfigKvLockSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvLockSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings ResetName(this AzureAppconfigKvLockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvLockSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings SetSubscription(this AzureAppconfigKvLockSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvLockSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings ResetSubscription(this AzureAppconfigKvLockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvLockSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings SetDebug(this AzureAppconfigKvLockSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvLockSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings ResetDebug(this AzureAppconfigKvLockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvLockSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings SetHelp(this AzureAppconfigKvLockSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvLockSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings ResetHelp(this AzureAppconfigKvLockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvLockSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings SetOutput(this AzureAppconfigKvLockSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvLockSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings ResetOutput(this AzureAppconfigKvLockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvLockSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings SetQuery(this AzureAppconfigKvLockSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvLockSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings ResetQuery(this AzureAppconfigKvLockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvLockSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings SetVerbose(this AzureAppconfigKvLockSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvLockSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvLockSettings ResetVerbose(this AzureAppconfigKvLockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigKvRestoreSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigKvRestoreSettingsExtensions
    {
        #region Datetime
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvRestoreSettings.Datetime"/></em></p>
        ///   <p>Format: "YYYY-MM-DDThh:mm:ssZ". If no time zone specified, use UTC by default.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings SetDatetime(this AzureAppconfigKvRestoreSettings toolSettings, string datetime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Datetime = datetime;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvRestoreSettings.Datetime"/></em></p>
        ///   <p>Format: "YYYY-MM-DDThh:mm:ssZ". If no time zone specified, use UTC by default.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings ResetDatetime(this AzureAppconfigKvRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Datetime = null;
            return toolSettings;
        }
        #endregion
        #region ConnectionString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvRestoreSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings SetConnectionString(this AzureAppconfigKvRestoreSettings toolSettings, string connectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = connectionString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvRestoreSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings ResetConnectionString(this AzureAppconfigKvRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvRestoreSettings.Key"/></em></p>
        ///   <p>If no key specified, restore all keys by default. Support star sign as filters, for instance abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings SetKey(this AzureAppconfigKvRestoreSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvRestoreSettings.Key"/></em></p>
        ///   <p>If no key specified, restore all keys by default. Support star sign as filters, for instance abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings ResetKey(this AzureAppconfigKvRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Label
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvRestoreSettings.Label"/></em></p>
        ///   <p>If no label specified, restore all key-value pairs with all labels. Support star sign as filters, for instance abc\* means labels with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings SetLabel(this AzureAppconfigKvRestoreSettings toolSettings, string label)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = label;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvRestoreSettings.Label"/></em></p>
        ///   <p>If no label specified, restore all key-value pairs with all labels. Support star sign as filters, for instance abc\* means labels with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings ResetLabel(this AzureAppconfigKvRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvRestoreSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings SetName(this AzureAppconfigKvRestoreSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvRestoreSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings ResetName(this AzureAppconfigKvRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvRestoreSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings SetYes(this AzureAppconfigKvRestoreSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvRestoreSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings ResetYes(this AzureAppconfigKvRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvRestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings SetSubscription(this AzureAppconfigKvRestoreSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvRestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings ResetSubscription(this AzureAppconfigKvRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvRestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings SetDebug(this AzureAppconfigKvRestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvRestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings ResetDebug(this AzureAppconfigKvRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvRestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings SetHelp(this AzureAppconfigKvRestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvRestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings ResetHelp(this AzureAppconfigKvRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvRestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings SetOutput(this AzureAppconfigKvRestoreSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvRestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings ResetOutput(this AzureAppconfigKvRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvRestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings SetQuery(this AzureAppconfigKvRestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvRestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings ResetQuery(this AzureAppconfigKvRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvRestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings SetVerbose(this AzureAppconfigKvRestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvRestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvRestoreSettings ResetVerbose(this AzureAppconfigKvRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigKvSetSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigKvSetSettingsExtensions
    {
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Key"/></em></p>
        ///   <p>Key to be set.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetKey(this AzureAppconfigKvSetSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.Key"/></em></p>
        ///   <p>Key to be set.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetKey(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region ConnectionString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetConnectionString(this AzureAppconfigKvSetSettings toolSettings, string connectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = connectionString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetConnectionString(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region ContentType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.ContentType"/></em></p>
        ///   <p>Content type of the keyvalue to be set.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetContentType(this AzureAppconfigKvSetSettings toolSettings, string contentType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentType = contentType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.ContentType"/></em></p>
        ///   <p>Content type of the keyvalue to be set.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetContentType(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentType = null;
            return toolSettings;
        }
        #endregion
        #region Label
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Label"/></em></p>
        ///   <p>If no label specified, set the key with null label by default.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetLabel(this AzureAppconfigKvSetSettings toolSettings, string label)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = label;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.Label"/></em></p>
        ///   <p>If no label specified, set the key with null label by default.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetLabel(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetTags(this AzureAppconfigKvSetSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetTags(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Value
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Value"/></em></p>
        ///   <p>Value of the keyvalue to be set.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetValue(this AzureAppconfigKvSetSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.Value"/></em></p>
        ///   <p>Value of the keyvalue to be set.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetValue(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetYes(this AzureAppconfigKvSetSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetYes(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetIds(this AzureAppconfigKvSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetIds(this AzureAppconfigKvSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigKvSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings AddIds(this AzureAppconfigKvSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigKvSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings AddIds(this AzureAppconfigKvSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAppconfigKvSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ClearIds(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigKvSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings RemoveIds(this AzureAppconfigKvSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigKvSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings RemoveIds(this AzureAppconfigKvSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetName(this AzureAppconfigKvSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetName(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetSubscription(this AzureAppconfigKvSetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetSubscription(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetDebug(this AzureAppconfigKvSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetDebug(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetHelp(this AzureAppconfigKvSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetHelp(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetOutput(this AzureAppconfigKvSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetOutput(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetQuery(this AzureAppconfigKvSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetQuery(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvSetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings SetVerbose(this AzureAppconfigKvSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvSetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvSetSettings ResetVerbose(this AzureAppconfigKvSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigKvShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigKvShowSettingsExtensions
    {
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvShowSettings.Key"/></em></p>
        ///   <p>Key to be showed.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings SetKey(this AzureAppconfigKvShowSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvShowSettings.Key"/></em></p>
        ///   <p>Key to be showed.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings ResetKey(this AzureAppconfigKvShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region ConnectionString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvShowSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings SetConnectionString(this AzureAppconfigKvShowSettings toolSettings, string connectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = connectionString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvShowSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings ResetConnectionString(this AzureAppconfigKvShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region Datetime
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvShowSettings.Datetime"/></em></p>
        ///   <p>Format: "YYYY-MM-DDThh:mm:ssZ". If no time zone specified, use UTC by default.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings SetDatetime(this AzureAppconfigKvShowSettings toolSettings, string datetime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Datetime = datetime;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvShowSettings.Datetime"/></em></p>
        ///   <p>Format: "YYYY-MM-DDThh:mm:ssZ". If no time zone specified, use UTC by default.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings ResetDatetime(this AzureAppconfigKvShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Datetime = null;
            return toolSettings;
        }
        #endregion
        #region Label
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvShowSettings.Label"/></em></p>
        ///   <p>If no label specified, show entry with null label. Does NOT support filters like other commands.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings SetLabel(this AzureAppconfigKvShowSettings toolSettings, string label)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = label;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvShowSettings.Label"/></em></p>
        ///   <p>If no label specified, show entry with null label. Does NOT support filters like other commands.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings ResetLabel(this AzureAppconfigKvShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings SetIds(this AzureAppconfigKvShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings SetIds(this AzureAppconfigKvShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigKvShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings AddIds(this AzureAppconfigKvShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigKvShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings AddIds(this AzureAppconfigKvShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAppconfigKvShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings ClearIds(this AzureAppconfigKvShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigKvShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings RemoveIds(this AzureAppconfigKvShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigKvShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings RemoveIds(this AzureAppconfigKvShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvShowSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings SetName(this AzureAppconfigKvShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvShowSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings ResetName(this AzureAppconfigKvShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings SetSubscription(this AzureAppconfigKvShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings ResetSubscription(this AzureAppconfigKvShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings SetDebug(this AzureAppconfigKvShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings ResetDebug(this AzureAppconfigKvShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings SetHelp(this AzureAppconfigKvShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings ResetHelp(this AzureAppconfigKvShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings SetOutput(this AzureAppconfigKvShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings ResetOutput(this AzureAppconfigKvShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings SetQuery(this AzureAppconfigKvShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings ResetQuery(this AzureAppconfigKvShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings SetVerbose(this AzureAppconfigKvShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvShowSettings ResetVerbose(this AzureAppconfigKvShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigKvUnlockSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigKvUnlockSettingsExtensions
    {
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvUnlockSettings.Key"/></em></p>
        ///   <p>Key to be unlocked.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings SetKey(this AzureAppconfigKvUnlockSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvUnlockSettings.Key"/></em></p>
        ///   <p>Key to be unlocked.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings ResetKey(this AzureAppconfigKvUnlockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region ConnectionString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvUnlockSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings SetConnectionString(this AzureAppconfigKvUnlockSettings toolSettings, string connectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = connectionString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvUnlockSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings ResetConnectionString(this AzureAppconfigKvUnlockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region Label
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvUnlockSettings.Label"/></em></p>
        ///   <p>If no label specified, unlock entry with null label. Does NOT support filters like other commands.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings SetLabel(this AzureAppconfigKvUnlockSettings toolSettings, string label)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = label;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvUnlockSettings.Label"/></em></p>
        ///   <p>If no label specified, unlock entry with null label. Does NOT support filters like other commands.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings ResetLabel(this AzureAppconfigKvUnlockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvUnlockSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings SetYes(this AzureAppconfigKvUnlockSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvUnlockSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings ResetYes(this AzureAppconfigKvUnlockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvUnlockSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings SetIds(this AzureAppconfigKvUnlockSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvUnlockSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings SetIds(this AzureAppconfigKvUnlockSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigKvUnlockSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings AddIds(this AzureAppconfigKvUnlockSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppconfigKvUnlockSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings AddIds(this AzureAppconfigKvUnlockSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAppconfigKvUnlockSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings ClearIds(this AzureAppconfigKvUnlockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigKvUnlockSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings RemoveIds(this AzureAppconfigKvUnlockSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppconfigKvUnlockSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings RemoveIds(this AzureAppconfigKvUnlockSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvUnlockSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings SetName(this AzureAppconfigKvUnlockSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvUnlockSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings ResetName(this AzureAppconfigKvUnlockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvUnlockSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings SetSubscription(this AzureAppconfigKvUnlockSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvUnlockSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings ResetSubscription(this AzureAppconfigKvUnlockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvUnlockSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings SetDebug(this AzureAppconfigKvUnlockSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvUnlockSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings ResetDebug(this AzureAppconfigKvUnlockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvUnlockSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings SetHelp(this AzureAppconfigKvUnlockSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvUnlockSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings ResetHelp(this AzureAppconfigKvUnlockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvUnlockSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings SetOutput(this AzureAppconfigKvUnlockSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvUnlockSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings ResetOutput(this AzureAppconfigKvUnlockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvUnlockSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings SetQuery(this AzureAppconfigKvUnlockSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvUnlockSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings ResetQuery(this AzureAppconfigKvUnlockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigKvUnlockSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings SetVerbose(this AzureAppconfigKvUnlockSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigKvUnlockSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigKvUnlockSettings ResetVerbose(this AzureAppconfigKvUnlockSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppconfigRevisionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppconfigRevisionListSettingsExtensions
    {
        #region All
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.All"/></em></p>
        ///   <p>List all items.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetAll(this AzureAppconfigRevisionListSettings toolSettings, string all)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = all;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.All"/></em></p>
        ///   <p>List all items.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetAll(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = null;
            return toolSettings;
        }
        #endregion
        #region ConnectionString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetConnectionString(this AzureAppconfigRevisionListSettings toolSettings, string connectionString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = connectionString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.ConnectionString"/></em></p>
        ///   <p>Connections of access key and endpoint of App Configuration. Can be found using 'az appconfig credential list'. Users can preset it using `az configure --defaults appconfig_connection_string=&amp;lt;connection_string&amp;gt;` or environment variable with the name AZURE_APPCONFIG_CONNECTION_STRING.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetConnectionString(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectionString = null;
            return toolSettings;
        }
        #endregion
        #region Datetime
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.Datetime"/></em></p>
        ///   <p>Format: "YYYY-MM-DDThh:mm:ssZ". If no time zone specified, use UTC by default.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetDatetime(this AzureAppconfigRevisionListSettings toolSettings, string datetime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Datetime = datetime;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.Datetime"/></em></p>
        ///   <p>Format: "YYYY-MM-DDThh:mm:ssZ". If no time zone specified, use UTC by default.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetDatetime(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Datetime = null;
            return toolSettings;
        }
        #endregion
        #region Fields
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.Fields"/></em></p>
        ///   <p>Customize output fields.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetFields(this AzureAppconfigRevisionListSettings toolSettings, AppconfigKvFields fields)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Fields = fields;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.Fields"/></em></p>
        ///   <p>Customize output fields.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetFields(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Fields = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.Key"/></em></p>
        ///   <p>If no key specified, return all keys by default. Support star sign as filters, for instance abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetKey(this AzureAppconfigRevisionListSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.Key"/></em></p>
        ///   <p>If no key specified, return all keys by default. Support star sign as filters, for instance abc\* means keys with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetKey(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Label
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.Label"/></em></p>
        ///   <p>If no label specified, list all labels. Support star sign as filters, for instance abc\* means labels with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetLabel(this AzureAppconfigRevisionListSettings toolSettings, string label)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = label;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.Label"/></em></p>
        ///   <p>If no label specified, list all labels. Support star sign as filters, for instance abc\* means labels with abc as prefix. Similarly, \*abc and \*abc\* are also supported.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetLabel(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Label = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetName(this AzureAppconfigRevisionListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.Name"/></em></p>
        ///   <p>Name of the App Configuration. You can configure the default name using `az configure --defaults app_configuration_store=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetName(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.Top"/></em></p>
        ///   <p>Maximum number of items to return. Default to 100.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetTop(this AzureAppconfigRevisionListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.Top"/></em></p>
        ///   <p>Maximum number of items to return. Default to 100.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetTop(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetSubscription(this AzureAppconfigRevisionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetSubscription(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetDebug(this AzureAppconfigRevisionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetDebug(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetHelp(this AzureAppconfigRevisionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetHelp(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetOutput(this AzureAppconfigRevisionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetOutput(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetQuery(this AzureAppconfigRevisionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetQuery(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppconfigRevisionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings SetVerbose(this AzureAppconfigRevisionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppconfigRevisionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppconfigRevisionListSettings ResetVerbose(this AzureAppconfigRevisionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AppconfigKvExportDestination
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AppconfigKvExportDestination>))]
    public partial class AppconfigKvExportDestination : Enumeration
    {
        public static AppconfigKvExportDestination appconfig = new AppconfigKvExportDestination { Value = "appconfig" };
        public static AppconfigKvExportDestination appservice = new AppconfigKvExportDestination { Value = "appservice" };
        public static AppconfigKvExportDestination file = new AppconfigKvExportDestination { Value = "file" };
    }
    #endregion
    #region AppconfigKvExportFormat
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AppconfigKvExportFormat>))]
    public partial class AppconfigKvExportFormat : Enumeration
    {
        public static AppconfigKvExportFormat json = new AppconfigKvExportFormat { Value = "json" };
        public static AppconfigKvExportFormat properties = new AppconfigKvExportFormat { Value = "properties" };
        public static AppconfigKvExportFormat yaml = new AppconfigKvExportFormat { Value = "yaml" };
    }
    #endregion
    #region AppconfigKvFields
    /// <summary>
    ///   Used within <see cref="AzureAppconfigTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AppconfigKvFields>))]
    public partial class AppconfigKvFields : Enumeration
    {
        public static AppconfigKvFields content_type = new AppconfigKvFields { Value = "content_type" };
        public static AppconfigKvFields etag = new AppconfigKvFields { Value = "etag" };
        public static AppconfigKvFields key = new AppconfigKvFields { Value = "key" };
        public static AppconfigKvFields label = new AppconfigKvFields { Value = "label" };
        public static AppconfigKvFields last_modified = new AppconfigKvFields { Value = "last_modified" };
        public static AppconfigKvFields locked = new AppconfigKvFields { Value = "locked" };
        public static AppconfigKvFields value = new AppconfigKvFields { Value = "value" };
    }
    #endregion
}
