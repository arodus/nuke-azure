// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureDms.json
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
    public static partial class AzureDmsTasks
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public static string AzureDmsPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREDMS_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureDmsLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Data Migration Service (DMS) instances.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDms(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureDmsPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureDmsLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsCheckName(AzureDmsCheckNameSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsCheckNameSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsCheckNameSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsCheckNameSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDmsCheckNameSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsCheckNameSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsCheckNameSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsCheckNameSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsCheckNameSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsCheckNameSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsCheckName(Configure<AzureDmsCheckNameSettings> configurator)
        {
            return AzureDmsCheckName(configurator(new AzureDmsCheckNameSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsCheckNameSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsCheckNameSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDmsCheckNameSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsCheckNameSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsCheckNameSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsCheckNameSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsCheckNameSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsCheckNameSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsCheckNameSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsCheckName(CombinatorialConfigure<AzureDmsCheckNameSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsCheckName, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsCheckStatus(AzureDmsCheckStatusSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsCheckStatusSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsCheckStatusSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsCheckStatusSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsCheckStatusSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsCheckStatusSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsCheckStatusSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsCheckStatusSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsCheckStatusSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsCheckStatusSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsCheckStatus(Configure<AzureDmsCheckStatusSettings> configurator)
        {
            return AzureDmsCheckStatus(configurator(new AzureDmsCheckStatusSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsCheckStatusSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsCheckStatusSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsCheckStatusSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsCheckStatusSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsCheckStatusSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsCheckStatusSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsCheckStatusSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsCheckStatusSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsCheckStatusSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsCheckStatus(CombinatorialConfigure<AzureDmsCheckStatusSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsCheckStatus, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsCreate(AzureDmsCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDmsCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDmsCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureDmsCreateSettings.SkuName"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureDmsCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDmsCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsCreate(Configure<AzureDmsCreateSettings> configurator)
        {
            return AzureDmsCreate(configurator(new AzureDmsCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDmsCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDmsCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureDmsCreateSettings.SkuName"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureDmsCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDmsCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsCreate(CombinatorialConfigure<AzureDmsCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsCreate, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsDelete(AzureDmsDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsDeleteSettings.Debug"/></li>
        ///     <li><c>--delete-running-tasks</c> via <see cref="AzureDmsDeleteSettings.DeleteRunningTasks"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDmsDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDmsDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsDelete(Configure<AzureDmsDeleteSettings> configurator)
        {
            return AzureDmsDelete(configurator(new AzureDmsDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsDeleteSettings.Debug"/></li>
        ///     <li><c>--delete-running-tasks</c> via <see cref="AzureDmsDeleteSettings.DeleteRunningTasks"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDmsDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDmsDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsDelete(CombinatorialConfigure<AzureDmsDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsDelete, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsList(AzureDmsListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsList(Configure<AzureDmsListSettings> configurator)
        {
            return AzureDmsList(configurator(new AzureDmsListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsListSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsList(CombinatorialConfigure<AzureDmsListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsList, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsListSkus(AzureDmsListSkusSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsListSkusSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsListSkusSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsListSkusSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsListSkusSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsListSkusSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsListSkusSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsListSkusSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsListSkus(Configure<AzureDmsListSkusSettings> configurator)
        {
            return AzureDmsListSkus(configurator(new AzureDmsListSkusSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsListSkusSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsListSkusSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsListSkusSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsListSkusSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsListSkusSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsListSkusSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsListSkusSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsListSkus(CombinatorialConfigure<AzureDmsListSkusSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsListSkus, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsShow(AzureDmsShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsShow(Configure<AzureDmsShowSettings> configurator)
        {
            return AzureDmsShow(configurator(new AzureDmsShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsShow(CombinatorialConfigure<AzureDmsShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsShow, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsStart(AzureDmsStartSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsStartSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsStartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsStartSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsStartSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDmsStartSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsStartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsStartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsStartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsStartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsStartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsStart(Configure<AzureDmsStartSettings> configurator)
        {
            return AzureDmsStart(configurator(new AzureDmsStartSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsStartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsStartSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsStartSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDmsStartSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsStartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsStartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsStartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsStartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsStartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsStartSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsStart(CombinatorialConfigure<AzureDmsStartSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsStart, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsStop(AzureDmsStopSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsStopSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsStopSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsStopSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDmsStopSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsStopSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsStop(Configure<AzureDmsStopSettings> configurator)
        {
            return AzureDmsStop(configurator(new AzureDmsStopSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsStopSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsStopSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureDmsStopSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsStopSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsStopSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsStop(CombinatorialConfigure<AzureDmsStopSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsStop, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsWait(AzureDmsWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureDmsWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureDmsWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDmsWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureDmsWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureDmsWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureDmsWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureDmsWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureDmsWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsWait(Configure<AzureDmsWaitSettings> configurator)
        {
            return AzureDmsWait(configurator(new AzureDmsWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureDmsWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureDmsWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDmsWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureDmsWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureDmsWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureDmsWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureDmsWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureDmsWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsWait(CombinatorialConfigure<AzureDmsWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsWait, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsProjectCheckName(AzureDmsProjectCheckNameSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsProjectCheckNameSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectCheckNameSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectCheckNameSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectCheckNameSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectCheckNameSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectCheckNameSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectCheckNameSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectCheckNameSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectCheckNameSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectCheckNameSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsProjectCheckName(Configure<AzureDmsProjectCheckNameSettings> configurator)
        {
            return AzureDmsProjectCheckName(configurator(new AzureDmsProjectCheckNameSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectCheckNameSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectCheckNameSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectCheckNameSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectCheckNameSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectCheckNameSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectCheckNameSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectCheckNameSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectCheckNameSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectCheckNameSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsProjectCheckNameSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsProjectCheckName(CombinatorialConfigure<AzureDmsProjectCheckNameSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsProjectCheckName, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsProjectCreate(AzureDmsProjectCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsProjectCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDmsProjectCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectCreateSettings.ServiceName"/></li>
        ///     <li><c>--source-platform</c> via <see cref="AzureDmsProjectCreateSettings.SourcePlatform"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDmsProjectCreateSettings.Tags"/></li>
        ///     <li><c>--target-platform</c> via <see cref="AzureDmsProjectCreateSettings.TargetPlatform"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsProjectCreate(Configure<AzureDmsProjectCreateSettings> configurator)
        {
            return AzureDmsProjectCreate(configurator(new AzureDmsProjectCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDmsProjectCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectCreateSettings.ServiceName"/></li>
        ///     <li><c>--source-platform</c> via <see cref="AzureDmsProjectCreateSettings.SourcePlatform"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDmsProjectCreateSettings.Tags"/></li>
        ///     <li><c>--target-platform</c> via <see cref="AzureDmsProjectCreateSettings.TargetPlatform"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsProjectCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsProjectCreate(CombinatorialConfigure<AzureDmsProjectCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsProjectCreate, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsProjectDelete(AzureDmsProjectDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsProjectDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectDeleteSettings.Debug"/></li>
        ///     <li><c>--delete-running-tasks</c> via <see cref="AzureDmsProjectDeleteSettings.DeleteRunningTasks"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectDeleteSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDmsProjectDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsProjectDelete(Configure<AzureDmsProjectDeleteSettings> configurator)
        {
            return AzureDmsProjectDelete(configurator(new AzureDmsProjectDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectDeleteSettings.Debug"/></li>
        ///     <li><c>--delete-running-tasks</c> via <see cref="AzureDmsProjectDeleteSettings.DeleteRunningTasks"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectDeleteSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDmsProjectDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsProjectDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsProjectDelete(CombinatorialConfigure<AzureDmsProjectDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsProjectDelete, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsProjectList(AzureDmsProjectListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsProjectListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectListSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectListSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsProjectList(Configure<AzureDmsProjectListSettings> configurator)
        {
            return AzureDmsProjectList(configurator(new AzureDmsProjectListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectListSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectListSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsProjectListSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsProjectList(CombinatorialConfigure<AzureDmsProjectListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsProjectList, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsProjectShow(AzureDmsProjectShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsProjectShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectShowSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectShowSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsProjectShow(Configure<AzureDmsProjectShowSettings> configurator)
        {
            return AzureDmsProjectShow(configurator(new AzureDmsProjectShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectShowSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectShowSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsProjectShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsProjectShow(CombinatorialConfigure<AzureDmsProjectShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsProjectShow, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsProjectTaskCancel(AzureDmsProjectTaskCancelSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsProjectTaskCancelSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectTaskCancelSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectTaskCancelSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectTaskCancelSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectTaskCancelSettings.Output"/></li>
        ///     <li><c>--project-name</c> via <see cref="AzureDmsProjectTaskCancelSettings.ProjectName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectTaskCancelSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectTaskCancelSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectTaskCancelSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectTaskCancelSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectTaskCancelSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsProjectTaskCancel(Configure<AzureDmsProjectTaskCancelSettings> configurator)
        {
            return AzureDmsProjectTaskCancel(configurator(new AzureDmsProjectTaskCancelSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectTaskCancelSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectTaskCancelSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectTaskCancelSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectTaskCancelSettings.Output"/></li>
        ///     <li><c>--project-name</c> via <see cref="AzureDmsProjectTaskCancelSettings.ProjectName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectTaskCancelSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectTaskCancelSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectTaskCancelSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectTaskCancelSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectTaskCancelSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsProjectTaskCancelSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsProjectTaskCancel(CombinatorialConfigure<AzureDmsProjectTaskCancelSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsProjectTaskCancel, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsProjectTaskCheckName(AzureDmsProjectTaskCheckNameSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsProjectTaskCheckNameSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Output"/></li>
        ///     <li><c>--project-name</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.ProjectName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsProjectTaskCheckName(Configure<AzureDmsProjectTaskCheckNameSettings> configurator)
        {
            return AzureDmsProjectTaskCheckName(configurator(new AzureDmsProjectTaskCheckNameSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Output"/></li>
        ///     <li><c>--project-name</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.ProjectName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectTaskCheckNameSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsProjectTaskCheckNameSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsProjectTaskCheckName(CombinatorialConfigure<AzureDmsProjectTaskCheckNameSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsProjectTaskCheckName, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsProjectTaskCreate(AzureDmsProjectTaskCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsProjectTaskCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--database-options-json</c> via <see cref="AzureDmsProjectTaskCreateSettings.DatabaseOptionsJson"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectTaskCreateSettings.Debug"/></li>
        ///     <li><c>--enable-data-integrity-validation</c> via <see cref="AzureDmsProjectTaskCreateSettings.EnableDataIntegrityValidation"/></li>
        ///     <li><c>--enable-query-analysis-validation</c> via <see cref="AzureDmsProjectTaskCreateSettings.EnableQueryAnalysisValidation"/></li>
        ///     <li><c>--enable-schema-validation</c> via <see cref="AzureDmsProjectTaskCreateSettings.EnableSchemaValidation"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectTaskCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectTaskCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectTaskCreateSettings.Output"/></li>
        ///     <li><c>--project-name</c> via <see cref="AzureDmsProjectTaskCreateSettings.ProjectName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectTaskCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectTaskCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectTaskCreateSettings.ServiceName"/></li>
        ///     <li><c>--source-connection-json</c> via <see cref="AzureDmsProjectTaskCreateSettings.SourceConnectionJson"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectTaskCreateSettings.Subscription"/></li>
        ///     <li><c>--target-connection-json</c> via <see cref="AzureDmsProjectTaskCreateSettings.TargetConnectionJson"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectTaskCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsProjectTaskCreate(Configure<AzureDmsProjectTaskCreateSettings> configurator)
        {
            return AzureDmsProjectTaskCreate(configurator(new AzureDmsProjectTaskCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--database-options-json</c> via <see cref="AzureDmsProjectTaskCreateSettings.DatabaseOptionsJson"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectTaskCreateSettings.Debug"/></li>
        ///     <li><c>--enable-data-integrity-validation</c> via <see cref="AzureDmsProjectTaskCreateSettings.EnableDataIntegrityValidation"/></li>
        ///     <li><c>--enable-query-analysis-validation</c> via <see cref="AzureDmsProjectTaskCreateSettings.EnableQueryAnalysisValidation"/></li>
        ///     <li><c>--enable-schema-validation</c> via <see cref="AzureDmsProjectTaskCreateSettings.EnableSchemaValidation"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectTaskCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectTaskCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectTaskCreateSettings.Output"/></li>
        ///     <li><c>--project-name</c> via <see cref="AzureDmsProjectTaskCreateSettings.ProjectName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectTaskCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectTaskCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectTaskCreateSettings.ServiceName"/></li>
        ///     <li><c>--source-connection-json</c> via <see cref="AzureDmsProjectTaskCreateSettings.SourceConnectionJson"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectTaskCreateSettings.Subscription"/></li>
        ///     <li><c>--target-connection-json</c> via <see cref="AzureDmsProjectTaskCreateSettings.TargetConnectionJson"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectTaskCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsProjectTaskCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsProjectTaskCreate(CombinatorialConfigure<AzureDmsProjectTaskCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsProjectTaskCreate, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsProjectTaskDelete(AzureDmsProjectTaskDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsProjectTaskDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Debug"/></li>
        ///     <li><c>--delete-running-tasks</c> via <see cref="AzureDmsProjectTaskDeleteSettings.DeleteRunningTasks"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Output"/></li>
        ///     <li><c>--project-name</c> via <see cref="AzureDmsProjectTaskDeleteSettings.ProjectName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectTaskDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectTaskDeleteSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsProjectTaskDelete(Configure<AzureDmsProjectTaskDeleteSettings> configurator)
        {
            return AzureDmsProjectTaskDelete(configurator(new AzureDmsProjectTaskDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Debug"/></li>
        ///     <li><c>--delete-running-tasks</c> via <see cref="AzureDmsProjectTaskDeleteSettings.DeleteRunningTasks"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Output"/></li>
        ///     <li><c>--project-name</c> via <see cref="AzureDmsProjectTaskDeleteSettings.ProjectName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectTaskDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectTaskDeleteSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDmsProjectTaskDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsProjectTaskDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsProjectTaskDelete(CombinatorialConfigure<AzureDmsProjectTaskDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsProjectTaskDelete, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsProjectTaskList(AzureDmsProjectTaskListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsProjectTaskListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectTaskListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectTaskListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectTaskListSettings.Output"/></li>
        ///     <li><c>--project-name</c> via <see cref="AzureDmsProjectTaskListSettings.ProjectName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectTaskListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectTaskListSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectTaskListSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectTaskListSettings.Subscription"/></li>
        ///     <li><c>--task-type</c> via <see cref="AzureDmsProjectTaskListSettings.TaskType"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectTaskListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsProjectTaskList(Configure<AzureDmsProjectTaskListSettings> configurator)
        {
            return AzureDmsProjectTaskList(configurator(new AzureDmsProjectTaskListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectTaskListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectTaskListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectTaskListSettings.Output"/></li>
        ///     <li><c>--project-name</c> via <see cref="AzureDmsProjectTaskListSettings.ProjectName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectTaskListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectTaskListSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectTaskListSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectTaskListSettings.Subscription"/></li>
        ///     <li><c>--task-type</c> via <see cref="AzureDmsProjectTaskListSettings.TaskType"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectTaskListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsProjectTaskListSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsProjectTaskList(CombinatorialConfigure<AzureDmsProjectTaskListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsProjectTaskList, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDmsProjectTaskShow(AzureDmsProjectTaskShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDmsProjectTaskShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectTaskShowSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureDmsProjectTaskShowSettings.Expand"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectTaskShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectTaskShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectTaskShowSettings.Output"/></li>
        ///     <li><c>--project-name</c> via <see cref="AzureDmsProjectTaskShowSettings.ProjectName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectTaskShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectTaskShowSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectTaskShowSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectTaskShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectTaskShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDmsProjectTaskShow(Configure<AzureDmsProjectTaskShowSettings> configurator)
        {
            return AzureDmsProjectTaskShow(configurator(new AzureDmsProjectTaskShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Data Migration Service (DMS) instances.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/dms?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDmsProjectTaskShowSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureDmsProjectTaskShowSettings.Expand"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDmsProjectTaskShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDmsProjectTaskShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDmsProjectTaskShowSettings.Output"/></li>
        ///     <li><c>--project-name</c> via <see cref="AzureDmsProjectTaskShowSettings.ProjectName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDmsProjectTaskShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDmsProjectTaskShowSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDmsProjectTaskShowSettings.ServiceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDmsProjectTaskShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDmsProjectTaskShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDmsProjectTaskShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureDmsProjectTaskShow(CombinatorialConfigure<AzureDmsProjectTaskShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDmsProjectTaskShow, AzureDmsLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureDmsCheckNameSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsCheckNameSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The Service name to check.
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
              .Add("dms check-name")
              .Add("--location {value}", Location)
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
    #region AzureDmsCheckStatusSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsCheckStatusSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The name of the Service.
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
              .Add("dms check-status")
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
    #region AzureDmsCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The name of the Service.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the CPU SKU on which the service's Virtual Machine will run. Check the name and the availability of SKUs in your area with "az dms list-skus".
        /// </summary>
        public virtual string SkuName { get; internal set; }
        /// <summary>
        ///   The Resource ID of the VNet's Subnet you will use to connect the source and target DBs. Use "az network vnet subnet show -h" for help to get your subnet's ID.
        /// </summary>
        public virtual string Subnet { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   A space-delimited list of tags in "tag1[=value1]" format.
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
              .Add("dms create")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku-name {value}", SkuName)
              .Add("--subnet {value}", Subnet)
              .Add("--no-wait", NoWait)
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
    #region AzureDmsDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The name of the Service.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Cancel any running tasks before deleting the service.
        /// </summary>
        public virtual string DeleteRunningTasks { get; internal set; }
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
              .Add("dms delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--delete-running-tasks {value}", DeleteRunningTasks)
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
    #region AzureDmsListSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
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
              .Add("dms list")
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
    #region AzureDmsListSkusSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsListSkusSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
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
              .Add("dms list-skus")
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
    #region AzureDmsShowSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The name of the Service.
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
              .Add("dms show")
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
    #region AzureDmsStartSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsStartSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The name of the Service.
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
              .Add("dms start")
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
    #region AzureDmsStopSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsStopSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The name of the Service.
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
              .Add("dms stop")
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
    #region AzureDmsWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The name of the Service.
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
              .Add("dms wait")
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
    #region AzureDmsProjectCheckNameSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsProjectCheckNameSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The Project name to check.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the Service.
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
              .Add("dms project check-name")
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
    #region AzureDmsProjectCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsProjectCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The name of the Project.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the Service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
        /// <summary>
        ///   The type of server for the source database. The supported types are: SQL.
        /// </summary>
        public virtual string SourcePlatform { get; internal set; }
        /// <summary>
        ///   The type of service for the target database. The supported types are: SQLDB.
        /// </summary>
        public virtual string TargetPlatform { get; internal set; }
        /// <summary>
        ///   A space-delimited list of tags in "tag1[=value1]" format.
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
              .Add("dms project create")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
              .Add("--source-platform {value}", SourcePlatform)
              .Add("--target-platform {value}", TargetPlatform)
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
    #region AzureDmsProjectDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsProjectDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The name of the Project.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the Service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
        /// <summary>
        ///   Cancel any running tasks before deleting the Project.
        /// </summary>
        public virtual string DeleteRunningTasks { get; internal set; }
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
              .Add("dms project delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
              .Add("--delete-running-tasks {value}", DeleteRunningTasks)
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
    #region AzureDmsProjectListSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsProjectListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the Service.
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
              .Add("dms project list")
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
    #region AzureDmsProjectShowSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsProjectShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The name of the Project.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the Service.
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
              .Add("dms project show")
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
    #region AzureDmsProjectTaskCancelSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsProjectTaskCancelSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The name of the Task.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the Project.
        /// </summary>
        public virtual string ProjectName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the Service.
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
              .Add("dms project task cancel")
              .Add("--name {value}", Name)
              .Add("--project-name {value}", ProjectName)
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
    #region AzureDmsProjectTaskCheckNameSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsProjectTaskCheckNameSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The Task name to check.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the Project.
        /// </summary>
        public virtual string ProjectName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the Service.
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
              .Add("dms project task check-name")
              .Add("--name {value}", Name)
              .Add("--project-name {value}", ProjectName)
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
    #region AzureDmsProjectTaskCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsProjectTaskCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   Database and table information. This can be either a JSON-formatted string or the location to a file containing the JSON object. See example below for the format.
        /// </summary>
        public virtual string DatabaseOptionsJson { get; internal set; }
        /// <summary>
        ///   The name of the Task.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the Project.
        /// </summary>
        public virtual string ProjectName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the Service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
        /// <summary>
        ///   The connection information to the source server. This can be either a JSON-formatted string or the location to a file containing the JSON object. See example below for the format.
        /// </summary>
        public virtual string SourceConnectionJson { get; internal set; }
        /// <summary>
        ///   The connection information to the target server. This can be either a JSON-formatted string or the location to a file containing the JSON object. See example below for the format.
        /// </summary>
        public virtual string TargetConnectionJson { get; internal set; }
        /// <summary>
        ///   Whether to perform a checksum based data integrity validation between source and target for the selected database and tables.
        /// </summary>
        public virtual string EnableDataIntegrityValidation { get; internal set; }
        /// <summary>
        ///   Whether to perform a quick and intelligent query analysis by retrieving queries from the source database and executing them in the target. The result will have execution statistics for executions in source and target databases for the extracted queries.
        /// </summary>
        public virtual string EnableQueryAnalysisValidation { get; internal set; }
        /// <summary>
        ///   Whether to compare the schema information between source and target.
        /// </summary>
        public virtual string EnableSchemaValidation { get; internal set; }
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
              .Add("dms project task create")
              .Add("--database-options-json {value}", DatabaseOptionsJson)
              .Add("--name {value}", Name)
              .Add("--project-name {value}", ProjectName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
              .Add("--source-connection-json {value}", SourceConnectionJson)
              .Add("--target-connection-json {value}", TargetConnectionJson)
              .Add("--enable-data-integrity-validation {value}", EnableDataIntegrityValidation)
              .Add("--enable-query-analysis-validation {value}", EnableQueryAnalysisValidation)
              .Add("--enable-schema-validation {value}", EnableSchemaValidation)
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
    #region AzureDmsProjectTaskDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsProjectTaskDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The name of the Task.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the Project.
        /// </summary>
        public virtual string ProjectName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the Service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
        /// <summary>
        ///   If the Task is currently running, cancel the Task before deleting the Project.
        /// </summary>
        public virtual string DeleteRunningTasks { get; internal set; }
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
              .Add("dms project task delete")
              .Add("--name {value}", Name)
              .Add("--project-name {value}", ProjectName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
              .Add("--delete-running-tasks {value}", DeleteRunningTasks)
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
    #region AzureDmsProjectTaskListSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsProjectTaskListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The name of the Project.
        /// </summary>
        public virtual string ProjectName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the Service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
        /// <summary>
        ///   Filters the list by the type of task. For the list of possible types see "az dms check-status".
        /// </summary>
        public virtual string TaskType { get; internal set; }
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
              .Add("dms project task list")
              .Add("--project-name {value}", ProjectName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
              .Add("--task-type {value}", TaskType)
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
    #region AzureDmsProjectTaskShowSettings
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDmsProjectTaskShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDms executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDmsTasks.AzureDmsPath;
        public override Action<OutputType, string> CustomLogger => AzureDmsTasks.AzureDmsLogger;
        /// <summary>
        ///   The name of the Task.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the Project.
        /// </summary>
        public virtual string ProjectName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the Service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
        /// <summary>
        ///   Expand the response to provide more details. Use with "command" to see more details of the Task. Use with "output" to see the results of the Task's migration.
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
              .Add("dms project task show")
              .Add("--name {value}", Name)
              .Add("--project-name {value}", ProjectName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
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
    #region AzureDmsCheckNameSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsCheckNameSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckNameSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings SetLocation(this AzureDmsCheckNameSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckNameSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings ResetLocation(this AzureDmsCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckNameSettings.Name"/></em></p>
        ///   <p>The Service name to check.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings SetName(this AzureDmsCheckNameSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckNameSettings.Name"/></em></p>
        ///   <p>The Service name to check.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings ResetName(this AzureDmsCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckNameSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings SetSubscription(this AzureDmsCheckNameSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckNameSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings ResetSubscription(this AzureDmsCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckNameSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings SetDebug(this AzureDmsCheckNameSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckNameSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings ResetDebug(this AzureDmsCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckNameSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings SetHelp(this AzureDmsCheckNameSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckNameSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings ResetHelp(this AzureDmsCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckNameSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings SetOutput(this AzureDmsCheckNameSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckNameSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings ResetOutput(this AzureDmsCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckNameSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings SetQuery(this AzureDmsCheckNameSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckNameSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings ResetQuery(this AzureDmsCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckNameSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings SetVerbose(this AzureDmsCheckNameSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckNameSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckNameSettings ResetVerbose(this AzureDmsCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsCheckStatusSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsCheckStatusSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckStatusSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings SetName(this AzureDmsCheckStatusSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckStatusSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings ResetName(this AzureDmsCheckStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckStatusSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings SetResourceGroup(this AzureDmsCheckStatusSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckStatusSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings ResetResourceGroup(this AzureDmsCheckStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckStatusSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings SetSubscription(this AzureDmsCheckStatusSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckStatusSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings ResetSubscription(this AzureDmsCheckStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckStatusSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings SetDebug(this AzureDmsCheckStatusSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckStatusSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings ResetDebug(this AzureDmsCheckStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckStatusSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings SetHelp(this AzureDmsCheckStatusSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckStatusSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings ResetHelp(this AzureDmsCheckStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckStatusSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings SetOutput(this AzureDmsCheckStatusSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckStatusSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings ResetOutput(this AzureDmsCheckStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckStatusSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings SetQuery(this AzureDmsCheckStatusSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckStatusSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings ResetQuery(this AzureDmsCheckStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCheckStatusSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings SetVerbose(this AzureDmsCheckStatusSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCheckStatusSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCheckStatusSettings ResetVerbose(this AzureDmsCheckStatusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsCreateSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings SetLocation(this AzureDmsCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ResetLocation(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCreateSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings SetName(this AzureDmsCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCreateSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ResetName(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings SetResourceGroup(this AzureDmsCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ResetResourceGroup(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCreateSettings.SkuName"/></em></p>
        ///   <p>The name of the CPU SKU on which the service's Virtual Machine will run. Check the name and the availability of SKUs in your area with "az dms list-skus".</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings SetSkuName(this AzureDmsCreateSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCreateSettings.SkuName"/></em></p>
        ///   <p>The name of the CPU SKU on which the service's Virtual Machine will run. Check the name and the availability of SKUs in your area with "az dms list-skus".</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ResetSkuName(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCreateSettings.Subnet"/></em></p>
        ///   <p>The Resource ID of the VNet's Subnet you will use to connect the source and target DBs. Use "az network vnet subnet show -h" for help to get your subnet's ID.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings SetSubnet(this AzureDmsCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCreateSettings.Subnet"/></em></p>
        ///   <p>The Resource ID of the VNet's Subnet you will use to connect the source and target DBs. Use "az network vnet subnet show -h" for help to get your subnet's ID.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ResetSubnet(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings SetNoWait(this AzureDmsCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ResetNoWait(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureDmsCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings EnableNoWait(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureDmsCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings DisableNoWait(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureDmsCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ToggleNoWait(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCreateSettings.Tags"/></em></p>
        ///   <p>A space-delimited list of tags in "tag1[=value1]" format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings SetTags(this AzureDmsCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCreateSettings.Tags"/></em></p>
        ///   <p>A space-delimited list of tags in "tag1[=value1]" format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ResetTags(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings SetSubscription(this AzureDmsCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ResetSubscription(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings SetDebug(this AzureDmsCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ResetDebug(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings SetHelp(this AzureDmsCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ResetHelp(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings SetOutput(this AzureDmsCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ResetOutput(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings SetQuery(this AzureDmsCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ResetQuery(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings SetVerbose(this AzureDmsCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsCreateSettings ResetVerbose(this AzureDmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsDeleteSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings SetName(this AzureDmsDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsDeleteSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings ResetName(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings SetResourceGroup(this AzureDmsDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings ResetResourceGroup(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DeleteRunningTasks
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsDeleteSettings.DeleteRunningTasks"/></em></p>
        ///   <p>Cancel any running tasks before deleting the service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings SetDeleteRunningTasks(this AzureDmsDeleteSettings toolSettings, string deleteRunningTasks)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteRunningTasks = deleteRunningTasks;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsDeleteSettings.DeleteRunningTasks"/></em></p>
        ///   <p>Cancel any running tasks before deleting the service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings ResetDeleteRunningTasks(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteRunningTasks = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings SetNoWait(this AzureDmsDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings ResetNoWait(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureDmsDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings EnableNoWait(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureDmsDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings DisableNoWait(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureDmsDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings ToggleNoWait(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings SetYes(this AzureDmsDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings ResetYes(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings SetSubscription(this AzureDmsDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings ResetSubscription(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings SetDebug(this AzureDmsDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings ResetDebug(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings SetHelp(this AzureDmsDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings ResetHelp(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings SetOutput(this AzureDmsDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings ResetOutput(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings SetQuery(this AzureDmsDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings ResetQuery(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings SetVerbose(this AzureDmsDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsDeleteSettings ResetVerbose(this AzureDmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings SetResourceGroup(this AzureDmsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings ResetResourceGroup(this AzureDmsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings SetSubscription(this AzureDmsListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings ResetSubscription(this AzureDmsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings SetDebug(this AzureDmsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings ResetDebug(this AzureDmsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings SetHelp(this AzureDmsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings ResetHelp(this AzureDmsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings SetOutput(this AzureDmsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings ResetOutput(this AzureDmsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings SetQuery(this AzureDmsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings ResetQuery(this AzureDmsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings SetVerbose(this AzureDmsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSettings ResetVerbose(this AzureDmsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsListSkusSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsListSkusSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsListSkusSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSkusSettings SetSubscription(this AzureDmsListSkusSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsListSkusSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSkusSettings ResetSubscription(this AzureDmsListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsListSkusSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSkusSettings SetDebug(this AzureDmsListSkusSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsListSkusSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSkusSettings ResetDebug(this AzureDmsListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsListSkusSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSkusSettings SetHelp(this AzureDmsListSkusSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsListSkusSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSkusSettings ResetHelp(this AzureDmsListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsListSkusSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSkusSettings SetOutput(this AzureDmsListSkusSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsListSkusSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSkusSettings ResetOutput(this AzureDmsListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsListSkusSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSkusSettings SetQuery(this AzureDmsListSkusSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsListSkusSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSkusSettings ResetQuery(this AzureDmsListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsListSkusSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSkusSettings SetVerbose(this AzureDmsListSkusSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsListSkusSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsListSkusSettings ResetVerbose(this AzureDmsListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsShowSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings SetName(this AzureDmsShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsShowSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings ResetName(this AzureDmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings SetResourceGroup(this AzureDmsShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings ResetResourceGroup(this AzureDmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings SetSubscription(this AzureDmsShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings ResetSubscription(this AzureDmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings SetDebug(this AzureDmsShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings ResetDebug(this AzureDmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings SetHelp(this AzureDmsShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings ResetHelp(this AzureDmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings SetOutput(this AzureDmsShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings ResetOutput(this AzureDmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings SetQuery(this AzureDmsShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings ResetQuery(this AzureDmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings SetVerbose(this AzureDmsShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsShowSettings ResetVerbose(this AzureDmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsStartSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsStartSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStartSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings SetName(this AzureDmsStartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStartSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings ResetName(this AzureDmsStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings SetResourceGroup(this AzureDmsStartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings ResetResourceGroup(this AzureDmsStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings SetNoWait(this AzureDmsStartSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings ResetNoWait(this AzureDmsStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureDmsStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings EnableNoWait(this AzureDmsStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureDmsStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings DisableNoWait(this AzureDmsStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureDmsStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings ToggleNoWait(this AzureDmsStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings SetSubscription(this AzureDmsStartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings ResetSubscription(this AzureDmsStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings SetDebug(this AzureDmsStartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings ResetDebug(this AzureDmsStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings SetHelp(this AzureDmsStartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings ResetHelp(this AzureDmsStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings SetOutput(this AzureDmsStartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings ResetOutput(this AzureDmsStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings SetQuery(this AzureDmsStartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings ResetQuery(this AzureDmsStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings SetVerbose(this AzureDmsStartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStartSettings ResetVerbose(this AzureDmsStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsStopSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsStopSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStopSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings SetName(this AzureDmsStopSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStopSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings ResetName(this AzureDmsStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings SetResourceGroup(this AzureDmsStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings ResetResourceGroup(this AzureDmsStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings SetNoWait(this AzureDmsStopSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings ResetNoWait(this AzureDmsStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureDmsStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings EnableNoWait(this AzureDmsStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureDmsStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings DisableNoWait(this AzureDmsStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureDmsStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings ToggleNoWait(this AzureDmsStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings SetSubscription(this AzureDmsStopSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings ResetSubscription(this AzureDmsStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings SetDebug(this AzureDmsStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings ResetDebug(this AzureDmsStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings SetHelp(this AzureDmsStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings ResetHelp(this AzureDmsStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings SetOutput(this AzureDmsStopSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings ResetOutput(this AzureDmsStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings SetQuery(this AzureDmsStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings ResetQuery(this AzureDmsStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings SetVerbose(this AzureDmsStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsStopSettings ResetVerbose(this AzureDmsStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsWaitSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetName(this AzureDmsWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Name"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetName(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetResourceGroup(this AzureDmsWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetResourceGroup(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetCreated(this AzureDmsWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetCreated(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetCustom(this AzureDmsWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetCustom(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetDeleted(this AzureDmsWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetDeleted(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetExists(this AzureDmsWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetExists(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetInterval(this AzureDmsWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetInterval(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetTimeout(this AzureDmsWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetTimeout(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetUpdated(this AzureDmsWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetUpdated(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetSubscription(this AzureDmsWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetSubscription(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetDebug(this AzureDmsWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetDebug(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetHelp(this AzureDmsWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetHelp(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetOutput(this AzureDmsWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetOutput(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetQuery(this AzureDmsWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetQuery(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings SetVerbose(this AzureDmsWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsWaitSettings ResetVerbose(this AzureDmsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsProjectCheckNameSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsProjectCheckNameSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCheckNameSettings.Name"/></em></p>
        ///   <p>The Project name to check.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings SetName(this AzureDmsProjectCheckNameSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCheckNameSettings.Name"/></em></p>
        ///   <p>The Project name to check.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings ResetName(this AzureDmsProjectCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCheckNameSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings SetResourceGroup(this AzureDmsProjectCheckNameSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCheckNameSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings ResetResourceGroup(this AzureDmsProjectCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCheckNameSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings SetServiceName(this AzureDmsProjectCheckNameSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCheckNameSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings ResetServiceName(this AzureDmsProjectCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCheckNameSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings SetSubscription(this AzureDmsProjectCheckNameSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCheckNameSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings ResetSubscription(this AzureDmsProjectCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCheckNameSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings SetDebug(this AzureDmsProjectCheckNameSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCheckNameSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings ResetDebug(this AzureDmsProjectCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCheckNameSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings SetHelp(this AzureDmsProjectCheckNameSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCheckNameSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings ResetHelp(this AzureDmsProjectCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCheckNameSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings SetOutput(this AzureDmsProjectCheckNameSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCheckNameSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings ResetOutput(this AzureDmsProjectCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCheckNameSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings SetQuery(this AzureDmsProjectCheckNameSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCheckNameSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings ResetQuery(this AzureDmsProjectCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCheckNameSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings SetVerbose(this AzureDmsProjectCheckNameSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCheckNameSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCheckNameSettings ResetVerbose(this AzureDmsProjectCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsProjectCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsProjectCreateSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings SetLocation(this AzureDmsProjectCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings ResetLocation(this AzureDmsProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCreateSettings.Name"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings SetName(this AzureDmsProjectCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCreateSettings.Name"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings ResetName(this AzureDmsProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings SetResourceGroup(this AzureDmsProjectCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings ResetResourceGroup(this AzureDmsProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCreateSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings SetServiceName(this AzureDmsProjectCreateSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCreateSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings ResetServiceName(this AzureDmsProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region SourcePlatform
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCreateSettings.SourcePlatform"/></em></p>
        ///   <p>The type of server for the source database. The supported types are: SQL.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings SetSourcePlatform(this AzureDmsProjectCreateSettings toolSettings, string sourcePlatform)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourcePlatform = sourcePlatform;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCreateSettings.SourcePlatform"/></em></p>
        ///   <p>The type of server for the source database. The supported types are: SQL.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings ResetSourcePlatform(this AzureDmsProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourcePlatform = null;
            return toolSettings;
        }
        #endregion
        #region TargetPlatform
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCreateSettings.TargetPlatform"/></em></p>
        ///   <p>The type of service for the target database. The supported types are: SQLDB.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings SetTargetPlatform(this AzureDmsProjectCreateSettings toolSettings, string targetPlatform)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetPlatform = targetPlatform;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCreateSettings.TargetPlatform"/></em></p>
        ///   <p>The type of service for the target database. The supported types are: SQLDB.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings ResetTargetPlatform(this AzureDmsProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetPlatform = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCreateSettings.Tags"/></em></p>
        ///   <p>A space-delimited list of tags in "tag1[=value1]" format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings SetTags(this AzureDmsProjectCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCreateSettings.Tags"/></em></p>
        ///   <p>A space-delimited list of tags in "tag1[=value1]" format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings ResetTags(this AzureDmsProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings SetSubscription(this AzureDmsProjectCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings ResetSubscription(this AzureDmsProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings SetDebug(this AzureDmsProjectCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings ResetDebug(this AzureDmsProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings SetHelp(this AzureDmsProjectCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings ResetHelp(this AzureDmsProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings SetOutput(this AzureDmsProjectCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings ResetOutput(this AzureDmsProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings SetQuery(this AzureDmsProjectCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings ResetQuery(this AzureDmsProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings SetVerbose(this AzureDmsProjectCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectCreateSettings ResetVerbose(this AzureDmsProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsProjectDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsProjectDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectDeleteSettings.Name"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings SetName(this AzureDmsProjectDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectDeleteSettings.Name"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings ResetName(this AzureDmsProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings SetResourceGroup(this AzureDmsProjectDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings ResetResourceGroup(this AzureDmsProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectDeleteSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings SetServiceName(this AzureDmsProjectDeleteSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectDeleteSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings ResetServiceName(this AzureDmsProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region DeleteRunningTasks
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectDeleteSettings.DeleteRunningTasks"/></em></p>
        ///   <p>Cancel any running tasks before deleting the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings SetDeleteRunningTasks(this AzureDmsProjectDeleteSettings toolSettings, string deleteRunningTasks)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteRunningTasks = deleteRunningTasks;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectDeleteSettings.DeleteRunningTasks"/></em></p>
        ///   <p>Cancel any running tasks before deleting the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings ResetDeleteRunningTasks(this AzureDmsProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteRunningTasks = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings SetYes(this AzureDmsProjectDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings ResetYes(this AzureDmsProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings SetSubscription(this AzureDmsProjectDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings ResetSubscription(this AzureDmsProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings SetDebug(this AzureDmsProjectDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings ResetDebug(this AzureDmsProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings SetHelp(this AzureDmsProjectDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings ResetHelp(this AzureDmsProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings SetOutput(this AzureDmsProjectDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings ResetOutput(this AzureDmsProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings SetQuery(this AzureDmsProjectDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings ResetQuery(this AzureDmsProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings SetVerbose(this AzureDmsProjectDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectDeleteSettings ResetVerbose(this AzureDmsProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsProjectListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsProjectListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings SetResourceGroup(this AzureDmsProjectListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings ResetResourceGroup(this AzureDmsProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectListSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings SetServiceName(this AzureDmsProjectListSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectListSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings ResetServiceName(this AzureDmsProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings SetSubscription(this AzureDmsProjectListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings ResetSubscription(this AzureDmsProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings SetDebug(this AzureDmsProjectListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings ResetDebug(this AzureDmsProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings SetHelp(this AzureDmsProjectListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings ResetHelp(this AzureDmsProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings SetOutput(this AzureDmsProjectListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings ResetOutput(this AzureDmsProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings SetQuery(this AzureDmsProjectListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings ResetQuery(this AzureDmsProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings SetVerbose(this AzureDmsProjectListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectListSettings ResetVerbose(this AzureDmsProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsProjectShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsProjectShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectShowSettings.Name"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings SetName(this AzureDmsProjectShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectShowSettings.Name"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings ResetName(this AzureDmsProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings SetResourceGroup(this AzureDmsProjectShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings ResetResourceGroup(this AzureDmsProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectShowSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings SetServiceName(this AzureDmsProjectShowSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectShowSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings ResetServiceName(this AzureDmsProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings SetSubscription(this AzureDmsProjectShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings ResetSubscription(this AzureDmsProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings SetDebug(this AzureDmsProjectShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings ResetDebug(this AzureDmsProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings SetHelp(this AzureDmsProjectShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings ResetHelp(this AzureDmsProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings SetOutput(this AzureDmsProjectShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings ResetOutput(this AzureDmsProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings SetQuery(this AzureDmsProjectShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings ResetQuery(this AzureDmsProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings SetVerbose(this AzureDmsProjectShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectShowSettings ResetVerbose(this AzureDmsProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsProjectTaskCancelSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsProjectTaskCancelSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCancelSettings.Name"/></em></p>
        ///   <p>The name of the Task.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings SetName(this AzureDmsProjectTaskCancelSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCancelSettings.Name"/></em></p>
        ///   <p>The name of the Task.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings ResetName(this AzureDmsProjectTaskCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProjectName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCancelSettings.ProjectName"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings SetProjectName(this AzureDmsProjectTaskCancelSettings toolSettings, string projectName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjectName = projectName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCancelSettings.ProjectName"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings ResetProjectName(this AzureDmsProjectTaskCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjectName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCancelSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings SetResourceGroup(this AzureDmsProjectTaskCancelSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCancelSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings ResetResourceGroup(this AzureDmsProjectTaskCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCancelSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings SetServiceName(this AzureDmsProjectTaskCancelSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCancelSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings ResetServiceName(this AzureDmsProjectTaskCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCancelSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings SetSubscription(this AzureDmsProjectTaskCancelSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCancelSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings ResetSubscription(this AzureDmsProjectTaskCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCancelSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings SetDebug(this AzureDmsProjectTaskCancelSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCancelSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings ResetDebug(this AzureDmsProjectTaskCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCancelSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings SetHelp(this AzureDmsProjectTaskCancelSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCancelSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings ResetHelp(this AzureDmsProjectTaskCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCancelSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings SetOutput(this AzureDmsProjectTaskCancelSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCancelSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings ResetOutput(this AzureDmsProjectTaskCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCancelSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings SetQuery(this AzureDmsProjectTaskCancelSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCancelSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings ResetQuery(this AzureDmsProjectTaskCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCancelSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings SetVerbose(this AzureDmsProjectTaskCancelSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCancelSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCancelSettings ResetVerbose(this AzureDmsProjectTaskCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsProjectTaskCheckNameSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsProjectTaskCheckNameSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCheckNameSettings.Name"/></em></p>
        ///   <p>The Task name to check.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings SetName(this AzureDmsProjectTaskCheckNameSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCheckNameSettings.Name"/></em></p>
        ///   <p>The Task name to check.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings ResetName(this AzureDmsProjectTaskCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProjectName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCheckNameSettings.ProjectName"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings SetProjectName(this AzureDmsProjectTaskCheckNameSettings toolSettings, string projectName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjectName = projectName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCheckNameSettings.ProjectName"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings ResetProjectName(this AzureDmsProjectTaskCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjectName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCheckNameSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings SetResourceGroup(this AzureDmsProjectTaskCheckNameSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCheckNameSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings ResetResourceGroup(this AzureDmsProjectTaskCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCheckNameSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings SetServiceName(this AzureDmsProjectTaskCheckNameSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCheckNameSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings ResetServiceName(this AzureDmsProjectTaskCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCheckNameSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings SetSubscription(this AzureDmsProjectTaskCheckNameSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCheckNameSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings ResetSubscription(this AzureDmsProjectTaskCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCheckNameSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings SetDebug(this AzureDmsProjectTaskCheckNameSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCheckNameSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings ResetDebug(this AzureDmsProjectTaskCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCheckNameSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings SetHelp(this AzureDmsProjectTaskCheckNameSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCheckNameSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings ResetHelp(this AzureDmsProjectTaskCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCheckNameSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings SetOutput(this AzureDmsProjectTaskCheckNameSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCheckNameSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings ResetOutput(this AzureDmsProjectTaskCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCheckNameSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings SetQuery(this AzureDmsProjectTaskCheckNameSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCheckNameSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings ResetQuery(this AzureDmsProjectTaskCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCheckNameSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings SetVerbose(this AzureDmsProjectTaskCheckNameSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCheckNameSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCheckNameSettings ResetVerbose(this AzureDmsProjectTaskCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsProjectTaskCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsProjectTaskCreateSettingsExtensions
    {
        #region DatabaseOptionsJson
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.DatabaseOptionsJson"/></em></p>
        ///   <p>Database and table information. This can be either a JSON-formatted string or the location to a file containing the JSON object. See example below for the format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetDatabaseOptionsJson(this AzureDmsProjectTaskCreateSettings toolSettings, string databaseOptionsJson)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseOptionsJson = databaseOptionsJson;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.DatabaseOptionsJson"/></em></p>
        ///   <p>Database and table information. This can be either a JSON-formatted string or the location to a file containing the JSON object. See example below for the format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetDatabaseOptionsJson(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DatabaseOptionsJson = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.Name"/></em></p>
        ///   <p>The name of the Task.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetName(this AzureDmsProjectTaskCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.Name"/></em></p>
        ///   <p>The name of the Task.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetName(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProjectName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.ProjectName"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetProjectName(this AzureDmsProjectTaskCreateSettings toolSettings, string projectName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjectName = projectName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.ProjectName"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetProjectName(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjectName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetResourceGroup(this AzureDmsProjectTaskCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetResourceGroup(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetServiceName(this AzureDmsProjectTaskCreateSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetServiceName(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region SourceConnectionJson
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.SourceConnectionJson"/></em></p>
        ///   <p>The connection information to the source server. This can be either a JSON-formatted string or the location to a file containing the JSON object. See example below for the format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetSourceConnectionJson(this AzureDmsProjectTaskCreateSettings toolSettings, string sourceConnectionJson)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceConnectionJson = sourceConnectionJson;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.SourceConnectionJson"/></em></p>
        ///   <p>The connection information to the source server. This can be either a JSON-formatted string or the location to a file containing the JSON object. See example below for the format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetSourceConnectionJson(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceConnectionJson = null;
            return toolSettings;
        }
        #endregion
        #region TargetConnectionJson
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.TargetConnectionJson"/></em></p>
        ///   <p>The connection information to the target server. This can be either a JSON-formatted string or the location to a file containing the JSON object. See example below for the format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetTargetConnectionJson(this AzureDmsProjectTaskCreateSettings toolSettings, string targetConnectionJson)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetConnectionJson = targetConnectionJson;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.TargetConnectionJson"/></em></p>
        ///   <p>The connection information to the target server. This can be either a JSON-formatted string or the location to a file containing the JSON object. See example below for the format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetTargetConnectionJson(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetConnectionJson = null;
            return toolSettings;
        }
        #endregion
        #region EnableDataIntegrityValidation
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.EnableDataIntegrityValidation"/></em></p>
        ///   <p>Whether to perform a checksum based data integrity validation between source and target for the selected database and tables.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetEnableDataIntegrityValidation(this AzureDmsProjectTaskCreateSettings toolSettings, string enableDataIntegrityValidation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableDataIntegrityValidation = enableDataIntegrityValidation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.EnableDataIntegrityValidation"/></em></p>
        ///   <p>Whether to perform a checksum based data integrity validation between source and target for the selected database and tables.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetEnableDataIntegrityValidation(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableDataIntegrityValidation = null;
            return toolSettings;
        }
        #endregion
        #region EnableQueryAnalysisValidation
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.EnableQueryAnalysisValidation"/></em></p>
        ///   <p>Whether to perform a quick and intelligent query analysis by retrieving queries from the source database and executing them in the target. The result will have execution statistics for executions in source and target databases for the extracted queries.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetEnableQueryAnalysisValidation(this AzureDmsProjectTaskCreateSettings toolSettings, string enableQueryAnalysisValidation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableQueryAnalysisValidation = enableQueryAnalysisValidation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.EnableQueryAnalysisValidation"/></em></p>
        ///   <p>Whether to perform a quick and intelligent query analysis by retrieving queries from the source database and executing them in the target. The result will have execution statistics for executions in source and target databases for the extracted queries.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetEnableQueryAnalysisValidation(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableQueryAnalysisValidation = null;
            return toolSettings;
        }
        #endregion
        #region EnableSchemaValidation
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.EnableSchemaValidation"/></em></p>
        ///   <p>Whether to compare the schema information between source and target.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetEnableSchemaValidation(this AzureDmsProjectTaskCreateSettings toolSettings, string enableSchemaValidation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableSchemaValidation = enableSchemaValidation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.EnableSchemaValidation"/></em></p>
        ///   <p>Whether to compare the schema information between source and target.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetEnableSchemaValidation(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableSchemaValidation = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetSubscription(this AzureDmsProjectTaskCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetSubscription(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetDebug(this AzureDmsProjectTaskCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetDebug(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetHelp(this AzureDmsProjectTaskCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetHelp(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetOutput(this AzureDmsProjectTaskCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetOutput(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetQuery(this AzureDmsProjectTaskCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetQuery(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings SetVerbose(this AzureDmsProjectTaskCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskCreateSettings ResetVerbose(this AzureDmsProjectTaskCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsProjectTaskDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsProjectTaskDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskDeleteSettings.Name"/></em></p>
        ///   <p>The name of the Task.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings SetName(this AzureDmsProjectTaskDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskDeleteSettings.Name"/></em></p>
        ///   <p>The name of the Task.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings ResetName(this AzureDmsProjectTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProjectName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskDeleteSettings.ProjectName"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings SetProjectName(this AzureDmsProjectTaskDeleteSettings toolSettings, string projectName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjectName = projectName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskDeleteSettings.ProjectName"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings ResetProjectName(this AzureDmsProjectTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjectName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings SetResourceGroup(this AzureDmsProjectTaskDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings ResetResourceGroup(this AzureDmsProjectTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskDeleteSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings SetServiceName(this AzureDmsProjectTaskDeleteSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskDeleteSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings ResetServiceName(this AzureDmsProjectTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region DeleteRunningTasks
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskDeleteSettings.DeleteRunningTasks"/></em></p>
        ///   <p>If the Task is currently running, cancel the Task before deleting the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings SetDeleteRunningTasks(this AzureDmsProjectTaskDeleteSettings toolSettings, string deleteRunningTasks)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteRunningTasks = deleteRunningTasks;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskDeleteSettings.DeleteRunningTasks"/></em></p>
        ///   <p>If the Task is currently running, cancel the Task before deleting the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings ResetDeleteRunningTasks(this AzureDmsProjectTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeleteRunningTasks = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings SetYes(this AzureDmsProjectTaskDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings ResetYes(this AzureDmsProjectTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings SetSubscription(this AzureDmsProjectTaskDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings ResetSubscription(this AzureDmsProjectTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings SetDebug(this AzureDmsProjectTaskDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings ResetDebug(this AzureDmsProjectTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings SetHelp(this AzureDmsProjectTaskDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings ResetHelp(this AzureDmsProjectTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings SetOutput(this AzureDmsProjectTaskDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings ResetOutput(this AzureDmsProjectTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings SetQuery(this AzureDmsProjectTaskDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings ResetQuery(this AzureDmsProjectTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings SetVerbose(this AzureDmsProjectTaskDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskDeleteSettings ResetVerbose(this AzureDmsProjectTaskDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsProjectTaskListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsProjectTaskListSettingsExtensions
    {
        #region ProjectName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskListSettings.ProjectName"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings SetProjectName(this AzureDmsProjectTaskListSettings toolSettings, string projectName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjectName = projectName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskListSettings.ProjectName"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings ResetProjectName(this AzureDmsProjectTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjectName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings SetResourceGroup(this AzureDmsProjectTaskListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings ResetResourceGroup(this AzureDmsProjectTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskListSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings SetServiceName(this AzureDmsProjectTaskListSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskListSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings ResetServiceName(this AzureDmsProjectTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region TaskType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskListSettings.TaskType"/></em></p>
        ///   <p>Filters the list by the type of task. For the list of possible types see "az dms check-status".</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings SetTaskType(this AzureDmsProjectTaskListSettings toolSettings, string taskType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TaskType = taskType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskListSettings.TaskType"/></em></p>
        ///   <p>Filters the list by the type of task. For the list of possible types see "az dms check-status".</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings ResetTaskType(this AzureDmsProjectTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TaskType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings SetSubscription(this AzureDmsProjectTaskListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings ResetSubscription(this AzureDmsProjectTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings SetDebug(this AzureDmsProjectTaskListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings ResetDebug(this AzureDmsProjectTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings SetHelp(this AzureDmsProjectTaskListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings ResetHelp(this AzureDmsProjectTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings SetOutput(this AzureDmsProjectTaskListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings ResetOutput(this AzureDmsProjectTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings SetQuery(this AzureDmsProjectTaskListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings ResetQuery(this AzureDmsProjectTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings SetVerbose(this AzureDmsProjectTaskListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskListSettings ResetVerbose(this AzureDmsProjectTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDmsProjectTaskShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDmsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDmsProjectTaskShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskShowSettings.Name"/></em></p>
        ///   <p>The name of the Task.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings SetName(this AzureDmsProjectTaskShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskShowSettings.Name"/></em></p>
        ///   <p>The name of the Task.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings ResetName(this AzureDmsProjectTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProjectName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskShowSettings.ProjectName"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings SetProjectName(this AzureDmsProjectTaskShowSettings toolSettings, string projectName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjectName = projectName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskShowSettings.ProjectName"/></em></p>
        ///   <p>The name of the Project.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings ResetProjectName(this AzureDmsProjectTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjectName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings SetResourceGroup(this AzureDmsProjectTaskShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings ResetResourceGroup(this AzureDmsProjectTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskShowSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings SetServiceName(this AzureDmsProjectTaskShowSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskShowSettings.ServiceName"/></em></p>
        ///   <p>The name of the Service.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings ResetServiceName(this AzureDmsProjectTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskShowSettings.Expand"/></em></p>
        ///   <p>Expand the response to provide more details. Use with "command" to see more details of the Task. Use with "output" to see the results of the Task's migration.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings SetExpand(this AzureDmsProjectTaskShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskShowSettings.Expand"/></em></p>
        ///   <p>Expand the response to provide more details. Use with "command" to see more details of the Task. Use with "output" to see the results of the Task's migration.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings ResetExpand(this AzureDmsProjectTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings SetSubscription(this AzureDmsProjectTaskShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings ResetSubscription(this AzureDmsProjectTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings SetDebug(this AzureDmsProjectTaskShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings ResetDebug(this AzureDmsProjectTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings SetHelp(this AzureDmsProjectTaskShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings ResetHelp(this AzureDmsProjectTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings SetOutput(this AzureDmsProjectTaskShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings ResetOutput(this AzureDmsProjectTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings SetQuery(this AzureDmsProjectTaskShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings ResetQuery(this AzureDmsProjectTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDmsProjectTaskShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings SetVerbose(this AzureDmsProjectTaskShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDmsProjectTaskShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDmsProjectTaskShowSettings ResetVerbose(this AzureDmsProjectTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
