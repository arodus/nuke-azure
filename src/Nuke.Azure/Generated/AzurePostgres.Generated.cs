// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzurePostgres.json
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
    public static partial class AzurePostgresTasks
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public static string AzurePostgresPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREPOSTGRES_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzurePostgresLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Database for PostgreSQL servers.
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgres(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzurePostgresPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzurePostgresLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgres(AzurePostgresSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgres(Configure<AzurePostgresSettings> configurator)
        {
            return AzurePostgres(configurator(new AzurePostgresSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgres(CombinatorialConfigure<AzurePostgresSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgres, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresDbCreate(AzurePostgresDbCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresDbCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--charset</c> via <see cref="AzurePostgresDbCreateSettings.Charset"/></li>
        ///     <li><c>--collation</c> via <see cref="AzurePostgresDbCreateSettings.Collation"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresDbCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresDbCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresDbCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresDbCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresDbCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresDbCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresDbCreateSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresDbCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresDbCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresDbCreate(Configure<AzurePostgresDbCreateSettings> configurator)
        {
            return AzurePostgresDbCreate(configurator(new AzurePostgresDbCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--charset</c> via <see cref="AzurePostgresDbCreateSettings.Charset"/></li>
        ///     <li><c>--collation</c> via <see cref="AzurePostgresDbCreateSettings.Collation"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresDbCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresDbCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresDbCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresDbCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresDbCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresDbCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresDbCreateSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresDbCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresDbCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresDbCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresDbCreate(CombinatorialConfigure<AzurePostgresDbCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresDbCreate, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresDbDelete(AzurePostgresDbDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresDbDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresDbDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresDbDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresDbDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresDbDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresDbDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresDbDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresDbDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresDbDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresDbDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzurePostgresDbDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresDbDelete(Configure<AzurePostgresDbDeleteSettings> configurator)
        {
            return AzurePostgresDbDelete(configurator(new AzurePostgresDbDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresDbDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresDbDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresDbDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresDbDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresDbDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresDbDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresDbDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresDbDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresDbDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzurePostgresDbDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresDbDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresDbDelete(CombinatorialConfigure<AzurePostgresDbDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresDbDelete, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresDbList(AzurePostgresDbListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresDbListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresDbListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresDbListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresDbListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresDbListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresDbListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresDbListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresDbListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresDbListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresDbList(Configure<AzurePostgresDbListSettings> configurator)
        {
            return AzurePostgresDbList(configurator(new AzurePostgresDbListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresDbListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresDbListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresDbListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresDbListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresDbListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresDbListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresDbListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresDbListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresDbListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresDbList(CombinatorialConfigure<AzurePostgresDbListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresDbList, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresDbShow(AzurePostgresDbShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresDbShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresDbShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresDbShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresDbShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresDbShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresDbShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresDbShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresDbShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresDbShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresDbShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresDbShow(Configure<AzurePostgresDbShowSettings> configurator)
        {
            return AzurePostgresDbShow(configurator(new AzurePostgresDbShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresDbShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresDbShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresDbShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresDbShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresDbShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresDbShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresDbShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresDbShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresDbShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresDbShowSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresDbShow(CombinatorialConfigure<AzurePostgresDbShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresDbShow, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerLogsDownload(AzurePostgresServerLogsDownloadSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerLogsDownloadSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerLogsDownloadSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerLogsDownloadSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerLogsDownload(Configure<AzurePostgresServerLogsDownloadSettings> configurator)
        {
            return AzurePostgresServerLogsDownload(configurator(new AzurePostgresServerLogsDownloadSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerLogsDownloadSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerLogsDownloadSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerLogsDownloadSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerLogsDownloadSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerLogsDownload(CombinatorialConfigure<AzurePostgresServerLogsDownloadSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerLogsDownload, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerLogsList(AzurePostgresServerLogsListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerLogsListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerLogsListSettings.Debug"/></li>
        ///     <li><c>--file-last-written</c> via <see cref="AzurePostgresServerLogsListSettings.FileLastWritten"/></li>
        ///     <li><c>--filename-contains</c> via <see cref="AzurePostgresServerLogsListSettings.FilenameContains"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerLogsListSettings.Help"/></li>
        ///     <li><c>--max-file-size</c> via <see cref="AzurePostgresServerLogsListSettings.MaxFileSize"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerLogsListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerLogsListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerLogsListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerLogsListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerLogsListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerLogsListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerLogsList(Configure<AzurePostgresServerLogsListSettings> configurator)
        {
            return AzurePostgresServerLogsList(configurator(new AzurePostgresServerLogsListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerLogsListSettings.Debug"/></li>
        ///     <li><c>--file-last-written</c> via <see cref="AzurePostgresServerLogsListSettings.FileLastWritten"/></li>
        ///     <li><c>--filename-contains</c> via <see cref="AzurePostgresServerLogsListSettings.FilenameContains"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerLogsListSettings.Help"/></li>
        ///     <li><c>--max-file-size</c> via <see cref="AzurePostgresServerLogsListSettings.MaxFileSize"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerLogsListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerLogsListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerLogsListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerLogsListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerLogsListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerLogsListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerLogsListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerLogsList(CombinatorialConfigure<AzurePostgresServerLogsListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerLogsList, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerCreate(AzurePostgresServerCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--admin-password</c> via <see cref="AzurePostgresServerCreateSettings.AdminPassword"/></li>
        ///     <li><c>--admin-user</c> via <see cref="AzurePostgresServerCreateSettings.AdminUser"/></li>
        ///     <li><c>--backup-retention</c> via <see cref="AzurePostgresServerCreateSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerCreateSettings.Debug"/></li>
        ///     <li><c>--geo-redundant-backup</c> via <see cref="AzurePostgresServerCreateSettings.GeoRedundantBackup"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzurePostgresServerCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzurePostgresServerCreateSettings.SkuName"/></li>
        ///     <li><c>--ssl-enforcement</c> via <see cref="AzurePostgresServerCreateSettings.SslEnforcement"/></li>
        ///     <li><c>--storage-size</c> via <see cref="AzurePostgresServerCreateSettings.StorageSize"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzurePostgresServerCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerCreateSettings.Verbose"/></li>
        ///     <li><c>--version</c> via <see cref="AzurePostgresServerCreateSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerCreate(Configure<AzurePostgresServerCreateSettings> configurator)
        {
            return AzurePostgresServerCreate(configurator(new AzurePostgresServerCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--admin-password</c> via <see cref="AzurePostgresServerCreateSettings.AdminPassword"/></li>
        ///     <li><c>--admin-user</c> via <see cref="AzurePostgresServerCreateSettings.AdminUser"/></li>
        ///     <li><c>--backup-retention</c> via <see cref="AzurePostgresServerCreateSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerCreateSettings.Debug"/></li>
        ///     <li><c>--geo-redundant-backup</c> via <see cref="AzurePostgresServerCreateSettings.GeoRedundantBackup"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzurePostgresServerCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzurePostgresServerCreateSettings.SkuName"/></li>
        ///     <li><c>--ssl-enforcement</c> via <see cref="AzurePostgresServerCreateSettings.SslEnforcement"/></li>
        ///     <li><c>--storage-size</c> via <see cref="AzurePostgresServerCreateSettings.StorageSize"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzurePostgresServerCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerCreateSettings.Verbose"/></li>
        ///     <li><c>--version</c> via <see cref="AzurePostgresServerCreateSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerCreate(CombinatorialConfigure<AzurePostgresServerCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerCreate, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerDelete(AzurePostgresServerDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzurePostgresServerDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerDelete(Configure<AzurePostgresServerDeleteSettings> configurator)
        {
            return AzurePostgresServerDelete(configurator(new AzurePostgresServerDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzurePostgresServerDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerDelete(CombinatorialConfigure<AzurePostgresServerDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerDelete, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerGeorestore(AzurePostgresServerGeorestoreSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerGeorestoreSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--backup-retention</c> via <see cref="AzurePostgresServerGeorestoreSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerGeorestoreSettings.Debug"/></li>
        ///     <li><c>--geo-redundant-backup</c> via <see cref="AzurePostgresServerGeorestoreSettings.GeoRedundantBackup"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerGeorestoreSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerGeorestoreSettings.Ids"/></li>
        ///     <li><c>--location</c> via <see cref="AzurePostgresServerGeorestoreSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerGeorestoreSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzurePostgresServerGeorestoreSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerGeorestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerGeorestoreSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerGeorestoreSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzurePostgresServerGeorestoreSettings.SkuName"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzurePostgresServerGeorestoreSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerGeorestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerGeorestoreSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerGeorestore(Configure<AzurePostgresServerGeorestoreSettings> configurator)
        {
            return AzurePostgresServerGeorestore(configurator(new AzurePostgresServerGeorestoreSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--backup-retention</c> via <see cref="AzurePostgresServerGeorestoreSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerGeorestoreSettings.Debug"/></li>
        ///     <li><c>--geo-redundant-backup</c> via <see cref="AzurePostgresServerGeorestoreSettings.GeoRedundantBackup"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerGeorestoreSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerGeorestoreSettings.Ids"/></li>
        ///     <li><c>--location</c> via <see cref="AzurePostgresServerGeorestoreSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerGeorestoreSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzurePostgresServerGeorestoreSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerGeorestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerGeorestoreSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerGeorestoreSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzurePostgresServerGeorestoreSettings.SkuName"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzurePostgresServerGeorestoreSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerGeorestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerGeorestoreSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerGeorestoreSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerGeorestore(CombinatorialConfigure<AzurePostgresServerGeorestoreSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerGeorestore, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerList(AzurePostgresServerListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerList(Configure<AzurePostgresServerListSettings> configurator)
        {
            return AzurePostgresServerList(configurator(new AzurePostgresServerListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerList(CombinatorialConfigure<AzurePostgresServerListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerList, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerRestart(AzurePostgresServerRestartSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerRestartSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerRestartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerRestartSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerRestartSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerRestartSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerRestartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerRestartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerRestartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerRestartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerRestartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerRestart(Configure<AzurePostgresServerRestartSettings> configurator)
        {
            return AzurePostgresServerRestart(configurator(new AzurePostgresServerRestartSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerRestartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerRestartSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerRestartSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerRestartSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerRestartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerRestartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerRestartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerRestartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerRestartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerRestartSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerRestart(CombinatorialConfigure<AzurePostgresServerRestartSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerRestart, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerRestore(AzurePostgresServerRestoreSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerRestoreSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerRestoreSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerRestoreSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerRestoreSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerRestoreSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzurePostgresServerRestoreSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerRestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerRestoreSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerRestoreSettings.ResourceGroup"/></li>
        ///     <li><c>--restore-point-in-time</c> via <see cref="AzurePostgresServerRestoreSettings.RestorePointInTime"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzurePostgresServerRestoreSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerRestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerRestoreSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerRestore(Configure<AzurePostgresServerRestoreSettings> configurator)
        {
            return AzurePostgresServerRestore(configurator(new AzurePostgresServerRestoreSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerRestoreSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerRestoreSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerRestoreSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerRestoreSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzurePostgresServerRestoreSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerRestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerRestoreSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerRestoreSettings.ResourceGroup"/></li>
        ///     <li><c>--restore-point-in-time</c> via <see cref="AzurePostgresServerRestoreSettings.RestorePointInTime"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzurePostgresServerRestoreSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerRestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerRestoreSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerRestoreSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerRestore(CombinatorialConfigure<AzurePostgresServerRestoreSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerRestore, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerShow(AzurePostgresServerShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerShow(Configure<AzurePostgresServerShowSettings> configurator)
        {
            return AzurePostgresServerShow(configurator(new AzurePostgresServerShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerShowSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerShow(CombinatorialConfigure<AzurePostgresServerShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerShow, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerUpdate(AzurePostgresServerUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzurePostgresServerUpdateSettings.Add"/></li>
        ///     <li><c>--admin-password</c> via <see cref="AzurePostgresServerUpdateSettings.AdminPassword"/></li>
        ///     <li><c>--backup-retention</c> via <see cref="AzurePostgresServerUpdateSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzurePostgresServerUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzurePostgresServerUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzurePostgresServerUpdateSettings.Set"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzurePostgresServerUpdateSettings.SkuName"/></li>
        ///     <li><c>--ssl-enforcement</c> via <see cref="AzurePostgresServerUpdateSettings.SslEnforcement"/></li>
        ///     <li><c>--storage-size</c> via <see cref="AzurePostgresServerUpdateSettings.StorageSize"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzurePostgresServerUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerUpdate(Configure<AzurePostgresServerUpdateSettings> configurator)
        {
            return AzurePostgresServerUpdate(configurator(new AzurePostgresServerUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzurePostgresServerUpdateSettings.Add"/></li>
        ///     <li><c>--admin-password</c> via <see cref="AzurePostgresServerUpdateSettings.AdminPassword"/></li>
        ///     <li><c>--backup-retention</c> via <see cref="AzurePostgresServerUpdateSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzurePostgresServerUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzurePostgresServerUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzurePostgresServerUpdateSettings.Set"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzurePostgresServerUpdateSettings.SkuName"/></li>
        ///     <li><c>--ssl-enforcement</c> via <see cref="AzurePostgresServerUpdateSettings.SslEnforcement"/></li>
        ///     <li><c>--storage-size</c> via <see cref="AzurePostgresServerUpdateSettings.StorageSize"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzurePostgresServerUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerUpdate(CombinatorialConfigure<AzurePostgresServerUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerUpdate, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerWait(AzurePostgresServerWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--custom</c> via <see cref="AzurePostgresServerWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerWaitSettings.Debug"/></li>
        ///     <li><c>--exists</c> via <see cref="AzurePostgresServerWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzurePostgresServerWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzurePostgresServerWaitSettings.Timeout"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerWait(Configure<AzurePostgresServerWaitSettings> configurator)
        {
            return AzurePostgresServerWait(configurator(new AzurePostgresServerWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--custom</c> via <see cref="AzurePostgresServerWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerWaitSettings.Debug"/></li>
        ///     <li><c>--exists</c> via <see cref="AzurePostgresServerWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzurePostgresServerWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzurePostgresServerWaitSettings.Timeout"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerWait(CombinatorialConfigure<AzurePostgresServerWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerWait, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerConfigurationList(AzurePostgresServerConfigurationListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerConfigurationListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerConfigurationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerConfigurationListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerConfigurationListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerConfigurationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerConfigurationListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerConfigurationListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerConfigurationListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerConfigurationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerConfigurationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerConfigurationList(Configure<AzurePostgresServerConfigurationListSettings> configurator)
        {
            return AzurePostgresServerConfigurationList(configurator(new AzurePostgresServerConfigurationListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerConfigurationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerConfigurationListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerConfigurationListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerConfigurationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerConfigurationListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerConfigurationListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerConfigurationListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerConfigurationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerConfigurationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerConfigurationListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerConfigurationList(CombinatorialConfigure<AzurePostgresServerConfigurationListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerConfigurationList, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerConfigurationSet(AzurePostgresServerConfigurationSetSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerConfigurationSetSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerConfigurationSetSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerConfigurationSetSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Subscription"/></li>
        ///     <li><c>--value</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Value"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerConfigurationSet(Configure<AzurePostgresServerConfigurationSetSettings> configurator)
        {
            return AzurePostgresServerConfigurationSet(configurator(new AzurePostgresServerConfigurationSetSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerConfigurationSetSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerConfigurationSetSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Subscription"/></li>
        ///     <li><c>--value</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Value"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerConfigurationSetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerConfigurationSetSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerConfigurationSet(CombinatorialConfigure<AzurePostgresServerConfigurationSetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerConfigurationSet, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerConfigurationShow(AzurePostgresServerConfigurationShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerConfigurationShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerConfigurationShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerConfigurationShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerConfigurationShow(Configure<AzurePostgresServerConfigurationShowSettings> configurator)
        {
            return AzurePostgresServerConfigurationShow(configurator(new AzurePostgresServerConfigurationShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerConfigurationShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerConfigurationShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerConfigurationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerConfigurationShowSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerConfigurationShow(CombinatorialConfigure<AzurePostgresServerConfigurationShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerConfigurationShow, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleCreate(AzurePostgresServerFirewallRuleCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerFirewallRuleCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Debug"/></li>
        ///     <li><c>--end-ip-address</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.EndIpAddress"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.ServerName"/></li>
        ///     <li><c>--start-ip-address</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.StartIpAddress"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleCreate(Configure<AzurePostgresServerFirewallRuleCreateSettings> configurator)
        {
            return AzurePostgresServerFirewallRuleCreate(configurator(new AzurePostgresServerFirewallRuleCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Debug"/></li>
        ///     <li><c>--end-ip-address</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.EndIpAddress"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.ServerName"/></li>
        ///     <li><c>--start-ip-address</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.StartIpAddress"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerFirewallRuleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerFirewallRuleCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerFirewallRuleCreate(CombinatorialConfigure<AzurePostgresServerFirewallRuleCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerFirewallRuleCreate, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleDelete(AzurePostgresServerFirewallRuleDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerFirewallRuleDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleDelete(Configure<AzurePostgresServerFirewallRuleDeleteSettings> configurator)
        {
            return AzurePostgresServerFirewallRuleDelete(configurator(new AzurePostgresServerFirewallRuleDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerFirewallRuleDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerFirewallRuleDelete(CombinatorialConfigure<AzurePostgresServerFirewallRuleDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerFirewallRuleDelete, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleList(AzurePostgresServerFirewallRuleListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerFirewallRuleListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleList(Configure<AzurePostgresServerFirewallRuleListSettings> configurator)
        {
            return AzurePostgresServerFirewallRuleList(configurator(new AzurePostgresServerFirewallRuleListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerFirewallRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerFirewallRuleListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerFirewallRuleList(CombinatorialConfigure<AzurePostgresServerFirewallRuleListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerFirewallRuleList, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleShow(AzurePostgresServerFirewallRuleShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerFirewallRuleShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleShow(Configure<AzurePostgresServerFirewallRuleShowSettings> configurator)
        {
            return AzurePostgresServerFirewallRuleShow(configurator(new AzurePostgresServerFirewallRuleShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerFirewallRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerFirewallRuleShowSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerFirewallRuleShow(CombinatorialConfigure<AzurePostgresServerFirewallRuleShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerFirewallRuleShow, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleUpdate(AzurePostgresServerFirewallRuleUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerFirewallRuleUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--end-ip-address</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.EndIpAddress"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ServerName"/></li>
        ///     <li><c>--set</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Set"/></li>
        ///     <li><c>--start-ip-address</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.StartIpAddress"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleUpdate(Configure<AzurePostgresServerFirewallRuleUpdateSettings> configurator)
        {
            return AzurePostgresServerFirewallRuleUpdate(configurator(new AzurePostgresServerFirewallRuleUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--end-ip-address</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.EndIpAddress"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ServerName"/></li>
        ///     <li><c>--set</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Set"/></li>
        ///     <li><c>--start-ip-address</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.StartIpAddress"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerFirewallRuleUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerFirewallRuleUpdate(CombinatorialConfigure<AzurePostgresServerFirewallRuleUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerFirewallRuleUpdate, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerReplicaCreate(AzurePostgresServerReplicaCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerReplicaCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzurePostgresServerReplicaCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerReplicaCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzurePostgresServerReplicaCreateSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerReplicaCreate(Configure<AzurePostgresServerReplicaCreateSettings> configurator)
        {
            return AzurePostgresServerReplicaCreate(configurator(new AzurePostgresServerReplicaCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzurePostgresServerReplicaCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerReplicaCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzurePostgresServerReplicaCreateSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerReplicaCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerReplicaCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerReplicaCreate(CombinatorialConfigure<AzurePostgresServerReplicaCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerReplicaCreate, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerReplicaList(AzurePostgresServerReplicaListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerReplicaListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerReplicaListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerReplicaListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerReplicaListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerReplicaListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerReplicaListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerReplicaListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerReplicaListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerReplicaListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerReplicaListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerReplicaList(Configure<AzurePostgresServerReplicaListSettings> configurator)
        {
            return AzurePostgresServerReplicaList(configurator(new AzurePostgresServerReplicaListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerReplicaListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerReplicaListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerReplicaListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerReplicaListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerReplicaListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerReplicaListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerReplicaListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerReplicaListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerReplicaListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerReplicaListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerReplicaList(CombinatorialConfigure<AzurePostgresServerReplicaListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerReplicaList, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerReplicaStop(AzurePostgresServerReplicaStopSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerReplicaStopSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerReplicaStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerReplicaStopSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerReplicaStopSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerReplicaStopSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerReplicaStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerReplicaStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerReplicaStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerReplicaStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerReplicaStopSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzurePostgresServerReplicaStopSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerReplicaStop(Configure<AzurePostgresServerReplicaStopSettings> configurator)
        {
            return AzurePostgresServerReplicaStop(configurator(new AzurePostgresServerReplicaStopSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerReplicaStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerReplicaStopSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerReplicaStopSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerReplicaStopSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerReplicaStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerReplicaStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerReplicaStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerReplicaStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerReplicaStopSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzurePostgresServerReplicaStopSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerReplicaStopSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerReplicaStop(CombinatorialConfigure<AzurePostgresServerReplicaStopSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerReplicaStop, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleCreate(AzurePostgresServerVnetRuleCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerVnetRuleCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Help"/></li>
        ///     <li><c>--ignore-missing-endpoint</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.ServerName"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleCreate(Configure<AzurePostgresServerVnetRuleCreateSettings> configurator)
        {
            return AzurePostgresServerVnetRuleCreate(configurator(new AzurePostgresServerVnetRuleCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Help"/></li>
        ///     <li><c>--ignore-missing-endpoint</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.ServerName"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzurePostgresServerVnetRuleCreateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerVnetRuleCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerVnetRuleCreate(CombinatorialConfigure<AzurePostgresServerVnetRuleCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerVnetRuleCreate, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleDelete(AzurePostgresServerVnetRuleDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerVnetRuleDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleDelete(Configure<AzurePostgresServerVnetRuleDeleteSettings> configurator)
        {
            return AzurePostgresServerVnetRuleDelete(configurator(new AzurePostgresServerVnetRuleDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerVnetRuleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerVnetRuleDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerVnetRuleDelete(CombinatorialConfigure<AzurePostgresServerVnetRuleDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerVnetRuleDelete, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleList(AzurePostgresServerVnetRuleListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerVnetRuleListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerVnetRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerVnetRuleListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleList(Configure<AzurePostgresServerVnetRuleListSettings> configurator)
        {
            return AzurePostgresServerVnetRuleList(configurator(new AzurePostgresServerVnetRuleListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerVnetRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerVnetRuleListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerVnetRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerVnetRuleListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerVnetRuleList(CombinatorialConfigure<AzurePostgresServerVnetRuleListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerVnetRuleList, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleShow(AzurePostgresServerVnetRuleShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerVnetRuleShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleShow(Configure<AzurePostgresServerVnetRuleShowSettings> configurator)
        {
            return AzurePostgresServerVnetRuleShow(configurator(new AzurePostgresServerVnetRuleShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerVnetRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerVnetRuleShowSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerVnetRuleShow(CombinatorialConfigure<AzurePostgresServerVnetRuleShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerVnetRuleShow, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleUpdate(AzurePostgresServerVnetRuleUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePostgresServerVnetRuleUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--ignore-missing-endpoint</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.ServerName"/></li>
        ///     <li><c>--set</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Set"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleUpdate(Configure<AzurePostgresServerVnetRuleUpdateSettings> configurator)
        {
            return AzurePostgresServerVnetRuleUpdate(configurator(new AzurePostgresServerVnetRuleUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for PostgreSQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--ignore-missing-endpoint</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.ServerName"/></li>
        ///     <li><c>--set</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Set"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzurePostgresServerVnetRuleUpdateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePostgresServerVnetRuleUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePostgresServerVnetRuleUpdate(CombinatorialConfigure<AzurePostgresServerVnetRuleUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePostgresServerVnetRuleUpdate, AzurePostgresLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzurePostgresSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
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
              .Add("postgres")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresDbCreateSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresDbCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   The name of the database.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
        /// <summary>
        ///   The charset of the database.
        /// </summary>
        public virtual string Charset { get; internal set; }
        /// <summary>
        ///   The collation of the database.
        /// </summary>
        public virtual string Collation { get; internal set; }
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
              .Add("postgres db create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--charset {value}", Charset)
              .Add("--collation {value}", Collation)
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
    #region AzurePostgresDbDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresDbDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   The name of the database.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres db delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresDbListSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresDbListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres db list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresDbShowSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresDbShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   The name of the database.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres db show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresServerLogsDownloadSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerLogsDownloadSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   Space-separated list of log filenames on the server to download.
        /// </summary>
        public virtual IReadOnlyList<string> Name => NameInternal.AsReadOnly();
        internal List<string> NameInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server-logs download")
              .Add("--name {value}", Name, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresServerLogsListSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerLogsListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
        /// <summary>
        ///   Integer in hours to indicate file last modify time, default value is 72.
        /// </summary>
        public virtual string FileLastWritten { get; internal set; }
        /// <summary>
        ///   The pattern that file name should match.
        /// </summary>
        public virtual string FilenameContains { get; internal set; }
        /// <summary>
        ///   The file size limitation to filter files.
        /// </summary>
        public virtual string MaxFileSize { get; internal set; }
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
              .Add("postgres server-logs list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--file-last-written {value}", FileLastWritten)
              .Add("--filename-contains {value}", FilenameContains)
              .Add("--max-file-size {value}", MaxFileSize)
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
    #region AzurePostgresServerCreateSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.
        /// </summary>
        public virtual string SkuName { get; internal set; }
        /// <summary>
        ///   The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.
        /// </summary>
        public virtual string BackupRetention { get; internal set; }
        /// <summary>
        ///   Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.
        /// </summary>
        public virtual PostgresServerCreateGeoRedundantBackup GeoRedundantBackup { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Enable or disable ssl enforcement for connections to server. Default is Enabled.
        /// </summary>
        public virtual PostgresServerCreateGeoRedundantBackup SslEnforcement { get; internal set; }
        /// <summary>
        ///   The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.
        /// </summary>
        public virtual string StorageSize { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   Server major version.
        /// </summary>
        public virtual string Version { get; internal set; }
        /// <summary>
        ///   The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.
        /// </summary>
        public virtual string AdminPassword { get; internal set; }
        /// <summary>
        ///   Administrator username for the server. Once set, it cannot be changed.
        /// </summary>
        public virtual string AdminUser { get; internal set; }
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
              .Add("postgres server create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku-name {value}", SkuName)
              .Add("--backup-retention {value}", BackupRetention)
              .Add("--geo-redundant-backup {value}", GeoRedundantBackup)
              .Add("--location {value}", Location)
              .Add("--ssl-enforcement {value}", SslEnforcement)
              .Add("--storage-size {value}", StorageSize)
              .Add("--tags {value}", Tags)
              .Add("--version {value}", Version)
              .Add("--admin-password {value}", AdminPassword, secret: true)
              .Add("--admin-user {value}", AdminUser)
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
    #region AzurePostgresServerDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
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
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
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
              .Add("postgres server delete")
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
    #region AzurePostgresServerGeorestoreSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerGeorestoreSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The name or ID of the source server to restore from.
        /// </summary>
        public virtual string SourceServer { get; internal set; }
        /// <summary>
        ///   The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.
        /// </summary>
        public virtual string BackupRetention { get; internal set; }
        /// <summary>
        ///   Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.
        /// </summary>
        public virtual string GeoRedundantBackup { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   The name of the sku. Defaults to sku of the source server. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.
        /// </summary>
        public virtual string SkuName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
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
              .Add("postgres server georestore")
              .Add("--location {value}", Location)
              .Add("--source-server {value}", SourceServer)
              .Add("--backup-retention {value}", BackupRetention)
              .Add("--geo-redundant-backup {value}", GeoRedundantBackup)
              .Add("--no-wait", NoWait)
              .Add("--sku-name {value}", SkuName)
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
    #region AzurePostgresServerListSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
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
              .Add("postgres server list")
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
    #region AzurePostgresServerRestartSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerRestartSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
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
              .Add("postgres server restart")
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
    #region AzurePostgresServerRestoreSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerRestoreSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   The point in time to restore from (ISO8601 format), e.g., 2017-04-26T02:10:00+08:00.
        /// </summary>
        public virtual string RestorePointInTime { get; internal set; }
        /// <summary>
        ///   The name or resource ID of the source server to restore from.
        /// </summary>
        public virtual string SourceServer { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
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
              .Add("postgres server restore")
              .Add("--restore-point-in-time {value}", RestorePointInTime)
              .Add("--source-server {value}", SourceServer)
              .Add("--no-wait", NoWait)
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
    #region AzurePostgresServerShowSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
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
              .Add("postgres server show")
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
    #region AzurePostgresServerUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.
        /// </summary>
        public virtual string AdminPassword { get; internal set; }
        /// <summary>
        ///   The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.
        /// </summary>
        public virtual string BackupRetention { get; internal set; }
        /// <summary>
        ///   The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.
        /// </summary>
        public virtual string SkuName { get; internal set; }
        /// <summary>
        ///   Enable or disable ssl enforcement for connections to server. Default is Enabled.
        /// </summary>
        public virtual PostgresServerCreateGeoRedundantBackup SslEnforcement { get; internal set; }
        /// <summary>
        ///   The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.
        /// </summary>
        public virtual string StorageSize { get; internal set; }
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
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
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
              .Add("postgres server update")
              .Add("--admin-password {value}", AdminPassword, secret: true)
              .Add("--backup-retention {value}", BackupRetention)
              .Add("--sku-name {value}", SkuName)
              .Add("--ssl-enforcement {value}", SslEnforcement)
              .Add("--storage-size {value}", StorageSize)
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
    #region AzurePostgresServerWaitSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
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
        ///   Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].
        /// </summary>
        public virtual string Custom { get; internal set; }
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
              .Add("postgres server wait")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--custom {value}", Custom)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerConfigurationListSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerConfigurationListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
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
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server configuration list")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresServerConfigurationSetSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerConfigurationSetSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   Value of the configuration. If not provided, configuration value will be set to default.
        /// </summary>
        public virtual string Value { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the server configuration.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server configuration set")
              .Add("--value {value}", Value)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresServerConfigurationShowSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerConfigurationShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the server configuration.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server configuration show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresServerFirewallRuleCreateSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerFirewallRuleCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.
        /// </summary>
        public virtual string EndIpAddress { get; internal set; }
        /// <summary>
        ///   The name of the firewall rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
        /// <summary>
        ///   The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.
        /// </summary>
        public virtual string StartIpAddress { get; internal set; }
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
              .Add("postgres server firewall-rule create")
              .Add("--end-ip-address {value}", EndIpAddress)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--start-ip-address {value}", StartIpAddress)
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
    #region AzurePostgresServerFirewallRuleDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerFirewallRuleDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
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
        ///   The name of the firewall rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server firewall-rule delete")
              .Add("--yes {value}", Yes)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresServerFirewallRuleListSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerFirewallRuleListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
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
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server firewall-rule list")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresServerFirewallRuleShowSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerFirewallRuleShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the firewall rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server firewall-rule show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresServerFirewallRuleUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerFirewallRuleUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.
        /// </summary>
        public virtual string EndIpAddress { get; internal set; }
        /// <summary>
        ///   The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.
        /// </summary>
        public virtual string StartIpAddress { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the firewall rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server firewall-rule update")
              .Add("--end-ip-address {value}", EndIpAddress)
              .Add("--start-ip-address {value}", StartIpAddress)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresServerReplicaCreateSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerReplicaCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name or resource ID of the master server to the create replica for.
        /// </summary>
        public virtual string SourceServer { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. If not provided, the create replica will be in the same location as the master server.
        /// </summary>
        public virtual string Location { get; internal set; }
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
              .Add("postgres server replica create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--source-server {value}", SourceServer)
              .Add("--location {value}", Location)
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
    #region AzurePostgresServerReplicaListSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerReplicaListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
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
        ///   Name of the master server.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server replica list")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresServerReplicaStopSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerReplicaStopSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
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
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
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
              .Add("postgres server replica stop")
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
    #region AzurePostgresServerVnetRuleCreateSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerVnetRuleCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   The name of the vnet rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
        /// <summary>
        ///   Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.
        /// </summary>
        public virtual string Subnet { get; internal set; }
        /// <summary>
        ///   Create vnet rule before virtual network has vnet service endpoint enabled.
        /// </summary>
        public virtual bool? IgnoreMissingEndpoint { get; internal set; }
        /// <summary>
        ///   The virtual network name.
        /// </summary>
        public virtual string VnetName { get; internal set; }
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
              .Add("postgres server vnet-rule create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--subnet {value}", Subnet)
              .Add("--ignore-missing-endpoint", IgnoreMissingEndpoint)
              .Add("--vnet-name {value}", VnetName)
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
    #region AzurePostgresServerVnetRuleDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerVnetRuleDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the vnet rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server vnet-rule delete")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresServerVnetRuleListSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerVnetRuleListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
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
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server vnet-rule list")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresServerVnetRuleShowSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerVnetRuleShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the vnet rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server vnet-rule show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresServerVnetRuleUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerVnetRuleUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePostgres executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        public override Action<OutputType, string> CustomLogger => AzurePostgresTasks.AzurePostgresLogger;
        /// <summary>
        ///   Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.
        /// </summary>
        public virtual string Subnet { get; internal set; }
        /// <summary>
        ///   Create vnet rule before virtual network has vnet service endpoint enabled.
        /// </summary>
        public virtual bool? IgnoreMissingEndpoint { get; internal set; }
        /// <summary>
        ///   The virtual network name.
        /// </summary>
        public virtual string VnetName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the vnet rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.
        /// </summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server vnet-rule update")
              .Add("--subnet {value}", Subnet)
              .Add("--ignore-missing-endpoint", IgnoreMissingEndpoint)
              .Add("--vnet-name {value}", VnetName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzurePostgresSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresSettings SetDebug(this AzurePostgresSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresSettings ResetDebug(this AzurePostgresSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresSettings SetHelp(this AzurePostgresSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresSettings ResetHelp(this AzurePostgresSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresSettings SetOutput(this AzurePostgresSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresSettings ResetOutput(this AzurePostgresSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresSettings SetQuery(this AzurePostgresSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresSettings ResetQuery(this AzurePostgresSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresSettings SetVerbose(this AzurePostgresSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresSettings ResetVerbose(this AzurePostgresSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresDbCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresDbCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbCreateSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetName(this AzurePostgresDbCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbCreateSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetName(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetResourceGroup(this AzurePostgresDbCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetResourceGroup(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetServerName(this AzurePostgresDbCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetServerName(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Charset
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbCreateSettings.Charset"/></em></p>
        ///   <p>The charset of the database.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetCharset(this AzurePostgresDbCreateSettings toolSettings, string charset)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Charset = charset;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbCreateSettings.Charset"/></em></p>
        ///   <p>The charset of the database.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetCharset(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Charset = null;
            return toolSettings;
        }
        #endregion
        #region Collation
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbCreateSettings.Collation"/></em></p>
        ///   <p>The collation of the database.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetCollation(this AzurePostgresDbCreateSettings toolSettings, string collation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Collation = collation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbCreateSettings.Collation"/></em></p>
        ///   <p>The collation of the database.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetCollation(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Collation = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetSubscription(this AzurePostgresDbCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetSubscription(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetDebug(this AzurePostgresDbCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetDebug(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetHelp(this AzurePostgresDbCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetHelp(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetOutput(this AzurePostgresDbCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetOutput(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetQuery(this AzurePostgresDbCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetQuery(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetVerbose(this AzurePostgresDbCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetVerbose(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresDbDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresDbDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetName(this AzurePostgresDbDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetName(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetResourceGroup(this AzurePostgresDbDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetResourceGroup(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetServerName(this AzurePostgresDbDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetServerName(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetYes(this AzurePostgresDbDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetYes(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetSubscription(this AzurePostgresDbDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetSubscription(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetDebug(this AzurePostgresDbDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetDebug(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetHelp(this AzurePostgresDbDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetHelp(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetOutput(this AzurePostgresDbDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetOutput(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetQuery(this AzurePostgresDbDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetQuery(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetVerbose(this AzurePostgresDbDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetVerbose(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresDbListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresDbListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings SetResourceGroup(this AzurePostgresDbListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetResourceGroup(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings SetServerName(this AzurePostgresDbListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetServerName(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings SetSubscription(this AzurePostgresDbListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetSubscription(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings SetDebug(this AzurePostgresDbListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetDebug(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings SetHelp(this AzurePostgresDbListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetHelp(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings SetOutput(this AzurePostgresDbListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetOutput(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings SetQuery(this AzurePostgresDbListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetQuery(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings SetVerbose(this AzurePostgresDbListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetVerbose(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresDbShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresDbShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbShowSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetName(this AzurePostgresDbShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbShowSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetName(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetResourceGroup(this AzurePostgresDbShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetResourceGroup(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetServerName(this AzurePostgresDbShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetServerName(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetSubscription(this AzurePostgresDbShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetSubscription(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetDebug(this AzurePostgresDbShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetDebug(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetHelp(this AzurePostgresDbShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetHelp(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetOutput(this AzurePostgresDbShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetOutput(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetQuery(this AzurePostgresDbShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetQuery(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresDbShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetVerbose(this AzurePostgresDbShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresDbShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetVerbose(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerLogsDownloadSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerLogsDownloadSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Name"/> to a new list</em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetName(this AzurePostgresServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal = name.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Name"/> to a new list</em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetName(this AzurePostgresServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal = name.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings AddName(this AzurePostgresServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.AddRange(name);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings AddName(this AzurePostgresServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.AddRange(name);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ClearName(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings RemoveName(this AzurePostgresServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(name);
            toolSettings.NameInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings RemoveName(this AzurePostgresServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(name);
            toolSettings.NameInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetResourceGroup(this AzurePostgresServerLogsDownloadSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetResourceGroup(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetServerName(this AzurePostgresServerLogsDownloadSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetServerName(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetSubscription(this AzurePostgresServerLogsDownloadSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetSubscription(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetDebug(this AzurePostgresServerLogsDownloadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetDebug(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetHelp(this AzurePostgresServerLogsDownloadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetHelp(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetOutput(this AzurePostgresServerLogsDownloadSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetOutput(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetQuery(this AzurePostgresServerLogsDownloadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetQuery(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetVerbose(this AzurePostgresServerLogsDownloadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetVerbose(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerLogsListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerLogsListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetResourceGroup(this AzurePostgresServerLogsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetResourceGroup(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetServerName(this AzurePostgresServerLogsListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetServerName(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region FileLastWritten
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsListSettings.FileLastWritten"/></em></p>
        ///   <p>Integer in hours to indicate file last modify time, default value is 72.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetFileLastWritten(this AzurePostgresServerLogsListSettings toolSettings, string fileLastWritten)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileLastWritten = fileLastWritten;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsListSettings.FileLastWritten"/></em></p>
        ///   <p>Integer in hours to indicate file last modify time, default value is 72.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetFileLastWritten(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileLastWritten = null;
            return toolSettings;
        }
        #endregion
        #region FilenameContains
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsListSettings.FilenameContains"/></em></p>
        ///   <p>The pattern that file name should match.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetFilenameContains(this AzurePostgresServerLogsListSettings toolSettings, string filenameContains)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilenameContains = filenameContains;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsListSettings.FilenameContains"/></em></p>
        ///   <p>The pattern that file name should match.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetFilenameContains(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilenameContains = null;
            return toolSettings;
        }
        #endregion
        #region MaxFileSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsListSettings.MaxFileSize"/></em></p>
        ///   <p>The file size limitation to filter files.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetMaxFileSize(this AzurePostgresServerLogsListSettings toolSettings, string maxFileSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxFileSize = maxFileSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsListSettings.MaxFileSize"/></em></p>
        ///   <p>The file size limitation to filter files.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetMaxFileSize(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxFileSize = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetSubscription(this AzurePostgresServerLogsListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetSubscription(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetDebug(this AzurePostgresServerLogsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetDebug(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetHelp(this AzurePostgresServerLogsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetHelp(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetOutput(this AzurePostgresServerLogsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetOutput(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetQuery(this AzurePostgresServerLogsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetQuery(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerLogsListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetVerbose(this AzurePostgresServerLogsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerLogsListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetVerbose(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetName(this AzurePostgresServerCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetName(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetResourceGroup(this AzurePostgresServerCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetResourceGroup(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetSkuName(this AzurePostgresServerCreateSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetSkuName(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetBackupRetention(this AzurePostgresServerCreateSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetBackupRetention(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region GeoRedundantBackup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.GeoRedundantBackup"/></em></p>
        ///   <p>Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetGeoRedundantBackup(this AzurePostgresServerCreateSettings toolSettings, PostgresServerCreateGeoRedundantBackup geoRedundantBackup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = geoRedundantBackup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.GeoRedundantBackup"/></em></p>
        ///   <p>Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetGeoRedundantBackup(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetLocation(this AzurePostgresServerCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetLocation(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region SslEnforcement
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.SslEnforcement"/></em></p>
        ///   <p>Enable or disable ssl enforcement for connections to server. Default is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetSslEnforcement(this AzurePostgresServerCreateSettings toolSettings, PostgresServerCreateGeoRedundantBackup sslEnforcement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = sslEnforcement;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.SslEnforcement"/></em></p>
        ///   <p>Enable or disable ssl enforcement for connections to server. Default is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetSslEnforcement(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = null;
            return toolSettings;
        }
        #endregion
        #region StorageSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.StorageSize"/></em></p>
        ///   <p>The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetStorageSize(this AzurePostgresServerCreateSettings toolSettings, string storageSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = storageSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.StorageSize"/></em></p>
        ///   <p>The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetStorageSize(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetTags(this AzurePostgresServerCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetTags(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.Version"/></em></p>
        ///   <p>Server major version.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetVersion(this AzurePostgresServerCreateSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.Version"/></em></p>
        ///   <p>Server major version.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetVersion(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region AdminPassword
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.AdminPassword"/></em></p>
        ///   <p>The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetAdminPassword(this AzurePostgresServerCreateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.AdminPassword"/></em></p>
        ///   <p>The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetAdminPassword(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region AdminUser
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.AdminUser"/></em></p>
        ///   <p>Administrator username for the server. Once set, it cannot be changed.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetAdminUser(this AzurePostgresServerCreateSettings toolSettings, string adminUser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUser = adminUser;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.AdminUser"/></em></p>
        ///   <p>Administrator username for the server. Once set, it cannot be changed.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetAdminUser(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUser = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetSubscription(this AzurePostgresServerCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetSubscription(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetDebug(this AzurePostgresServerCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetDebug(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetHelp(this AzurePostgresServerCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetHelp(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetOutput(this AzurePostgresServerCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetOutput(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetQuery(this AzurePostgresServerCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetQuery(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetVerbose(this AzurePostgresServerCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetVerbose(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerDeleteSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetYes(this AzurePostgresServerDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetYes(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetIds(this AzurePostgresServerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetIds(this AzurePostgresServerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings AddIds(this AzurePostgresServerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings AddIds(this AzurePostgresServerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ClearIds(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings RemoveIds(this AzurePostgresServerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings RemoveIds(this AzurePostgresServerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetName(this AzurePostgresServerDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetName(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetResourceGroup(this AzurePostgresServerDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetResourceGroup(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetSubscription(this AzurePostgresServerDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetSubscription(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetDebug(this AzurePostgresServerDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetDebug(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetHelp(this AzurePostgresServerDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetHelp(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetOutput(this AzurePostgresServerDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetOutput(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetQuery(this AzurePostgresServerDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetQuery(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetVerbose(this AzurePostgresServerDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetVerbose(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerGeorestoreSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerGeorestoreSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetLocation(this AzurePostgresServerGeorestoreSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetLocation(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region SourceServer
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.SourceServer"/></em></p>
        ///   <p>The name or ID of the source server to restore from.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetSourceServer(this AzurePostgresServerGeorestoreSettings toolSettings, string sourceServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = sourceServer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.SourceServer"/></em></p>
        ///   <p>The name or ID of the source server to restore from.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetSourceServer(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetBackupRetention(this AzurePostgresServerGeorestoreSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetBackupRetention(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region GeoRedundantBackup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.GeoRedundantBackup"/></em></p>
        ///   <p>Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetGeoRedundantBackup(this AzurePostgresServerGeorestoreSettings toolSettings, string geoRedundantBackup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = geoRedundantBackup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.GeoRedundantBackup"/></em></p>
        ///   <p>Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetGeoRedundantBackup(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetNoWait(this AzurePostgresServerGeorestoreSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetNoWait(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzurePostgresServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings EnableNoWait(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzurePostgresServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings DisableNoWait(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzurePostgresServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ToggleNoWait(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Defaults to sku of the source server. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetSkuName(this AzurePostgresServerGeorestoreSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Defaults to sku of the source server. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetSkuName(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetIds(this AzurePostgresServerGeorestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetIds(this AzurePostgresServerGeorestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings AddIds(this AzurePostgresServerGeorestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings AddIds(this AzurePostgresServerGeorestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ClearIds(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings RemoveIds(this AzurePostgresServerGeorestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings RemoveIds(this AzurePostgresServerGeorestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetName(this AzurePostgresServerGeorestoreSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetName(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetResourceGroup(this AzurePostgresServerGeorestoreSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetResourceGroup(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetSubscription(this AzurePostgresServerGeorestoreSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetSubscription(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetDebug(this AzurePostgresServerGeorestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetDebug(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetHelp(this AzurePostgresServerGeorestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetHelp(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetOutput(this AzurePostgresServerGeorestoreSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetOutput(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetQuery(this AzurePostgresServerGeorestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetQuery(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetVerbose(this AzurePostgresServerGeorestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetVerbose(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings SetResourceGroup(this AzurePostgresServerListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings ResetResourceGroup(this AzurePostgresServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings SetSubscription(this AzurePostgresServerListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings ResetSubscription(this AzurePostgresServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings SetDebug(this AzurePostgresServerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings ResetDebug(this AzurePostgresServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings SetHelp(this AzurePostgresServerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings ResetHelp(this AzurePostgresServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings SetOutput(this AzurePostgresServerListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings ResetOutput(this AzurePostgresServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings SetQuery(this AzurePostgresServerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings ResetQuery(this AzurePostgresServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings SetVerbose(this AzurePostgresServerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerListSettings ResetVerbose(this AzurePostgresServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerRestartSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerRestartSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestartSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings SetIds(this AzurePostgresServerRestartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestartSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings SetIds(this AzurePostgresServerRestartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings AddIds(this AzurePostgresServerRestartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings AddIds(this AzurePostgresServerRestartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings ClearIds(this AzurePostgresServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings RemoveIds(this AzurePostgresServerRestartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings RemoveIds(this AzurePostgresServerRestartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestartSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings SetName(this AzurePostgresServerRestartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestartSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings ResetName(this AzurePostgresServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings SetResourceGroup(this AzurePostgresServerRestartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings ResetResourceGroup(this AzurePostgresServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings SetSubscription(this AzurePostgresServerRestartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings ResetSubscription(this AzurePostgresServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings SetDebug(this AzurePostgresServerRestartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings ResetDebug(this AzurePostgresServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings SetHelp(this AzurePostgresServerRestartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings ResetHelp(this AzurePostgresServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings SetOutput(this AzurePostgresServerRestartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings ResetOutput(this AzurePostgresServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings SetQuery(this AzurePostgresServerRestartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings ResetQuery(this AzurePostgresServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings SetVerbose(this AzurePostgresServerRestartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestartSettings ResetVerbose(this AzurePostgresServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerRestoreSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerRestoreSettingsExtensions
    {
        #region RestorePointInTime
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestoreSettings.RestorePointInTime"/></em></p>
        ///   <p>The point in time to restore from (ISO8601 format), e.g., 2017-04-26T02:10:00+08:00.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetRestorePointInTime(this AzurePostgresServerRestoreSettings toolSettings, string restorePointInTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestorePointInTime = restorePointInTime;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestoreSettings.RestorePointInTime"/></em></p>
        ///   <p>The point in time to restore from (ISO8601 format), e.g., 2017-04-26T02:10:00+08:00.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetRestorePointInTime(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestorePointInTime = null;
            return toolSettings;
        }
        #endregion
        #region SourceServer
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestoreSettings.SourceServer"/></em></p>
        ///   <p>The name or resource ID of the source server to restore from.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetSourceServer(this AzurePostgresServerRestoreSettings toolSettings, string sourceServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = sourceServer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestoreSettings.SourceServer"/></em></p>
        ///   <p>The name or resource ID of the source server to restore from.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetSourceServer(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetNoWait(this AzurePostgresServerRestoreSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetNoWait(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzurePostgresServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings EnableNoWait(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzurePostgresServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings DisableNoWait(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzurePostgresServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ToggleNoWait(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetIds(this AzurePostgresServerRestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetIds(this AzurePostgresServerRestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings AddIds(this AzurePostgresServerRestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings AddIds(this AzurePostgresServerRestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ClearIds(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings RemoveIds(this AzurePostgresServerRestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings RemoveIds(this AzurePostgresServerRestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetName(this AzurePostgresServerRestoreSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestoreSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetName(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestoreSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetResourceGroup(this AzurePostgresServerRestoreSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestoreSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetResourceGroup(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetSubscription(this AzurePostgresServerRestoreSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetSubscription(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetDebug(this AzurePostgresServerRestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetDebug(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetHelp(this AzurePostgresServerRestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetHelp(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetOutput(this AzurePostgresServerRestoreSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetOutput(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetQuery(this AzurePostgresServerRestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetQuery(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetVerbose(this AzurePostgresServerRestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerRestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetVerbose(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetIds(this AzurePostgresServerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetIds(this AzurePostgresServerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings AddIds(this AzurePostgresServerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings AddIds(this AzurePostgresServerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings ClearIds(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings RemoveIds(this AzurePostgresServerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings RemoveIds(this AzurePostgresServerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerShowSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetName(this AzurePostgresServerShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerShowSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetName(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetResourceGroup(this AzurePostgresServerShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetResourceGroup(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetSubscription(this AzurePostgresServerShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetSubscription(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetDebug(this AzurePostgresServerShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetDebug(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetHelp(this AzurePostgresServerShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetHelp(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetOutput(this AzurePostgresServerShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetOutput(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetQuery(this AzurePostgresServerShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetQuery(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetVerbose(this AzurePostgresServerShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetVerbose(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerUpdateSettingsExtensions
    {
        #region AdminPassword
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.AdminPassword"/></em></p>
        ///   <p>The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetAdminPassword(this AzurePostgresServerUpdateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.AdminPassword"/></em></p>
        ///   <p>The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetAdminPassword(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetBackupRetention(this AzurePostgresServerUpdateSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetBackupRetention(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetSkuName(this AzurePostgresServerUpdateSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetSkuName(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region SslEnforcement
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.SslEnforcement"/></em></p>
        ///   <p>Enable or disable ssl enforcement for connections to server. Default is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetSslEnforcement(this AzurePostgresServerUpdateSettings toolSettings, PostgresServerCreateGeoRedundantBackup sslEnforcement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = sslEnforcement;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.SslEnforcement"/></em></p>
        ///   <p>Enable or disable ssl enforcement for connections to server. Default is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetSslEnforcement(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = null;
            return toolSettings;
        }
        #endregion
        #region StorageSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.StorageSize"/></em></p>
        ///   <p>The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetStorageSize(this AzurePostgresServerUpdateSettings toolSettings, string storageSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = storageSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.StorageSize"/></em></p>
        ///   <p>The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetStorageSize(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetTags(this AzurePostgresServerUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetTags(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetIds(this AzurePostgresServerUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetIds(this AzurePostgresServerUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings AddIds(this AzurePostgresServerUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings AddIds(this AzurePostgresServerUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ClearIds(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings RemoveIds(this AzurePostgresServerUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings RemoveIds(this AzurePostgresServerUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetName(this AzurePostgresServerUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetName(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetResourceGroup(this AzurePostgresServerUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetResourceGroup(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetSubscription(this AzurePostgresServerUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetSubscription(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetAdd(this AzurePostgresServerUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetAdd(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetForceString(this AzurePostgresServerUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetForceString(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetRemove(this AzurePostgresServerUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetRemove(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetSet(this AzurePostgresServerUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetSet(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetDebug(this AzurePostgresServerUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetDebug(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetHelp(this AzurePostgresServerUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetHelp(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetOutput(this AzurePostgresServerUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetOutput(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetQuery(this AzurePostgresServerUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetQuery(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetVerbose(this AzurePostgresServerUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetVerbose(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerWaitSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetIds(this AzurePostgresServerWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetIds(this AzurePostgresServerWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings AddIds(this AzurePostgresServerWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings AddIds(this AzurePostgresServerWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ClearIds(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings RemoveIds(this AzurePostgresServerWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings RemoveIds(this AzurePostgresServerWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetName(this AzurePostgresServerWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerWaitSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetName(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetResourceGroup(this AzurePostgresServerWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetResourceGroup(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetSubscription(this AzurePostgresServerWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetSubscription(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetCustom(this AzurePostgresServerWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetCustom(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetExists(this AzurePostgresServerWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetExists(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetInterval(this AzurePostgresServerWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetInterval(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetTimeout(this AzurePostgresServerWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetTimeout(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetDebug(this AzurePostgresServerWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetDebug(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetHelp(this AzurePostgresServerWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetHelp(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetOutput(this AzurePostgresServerWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetOutput(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetQuery(this AzurePostgresServerWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetQuery(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetVerbose(this AzurePostgresServerWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetVerbose(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerConfigurationListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerConfigurationListSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetIds(this AzurePostgresServerConfigurationListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetIds(this AzurePostgresServerConfigurationListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings AddIds(this AzurePostgresServerConfigurationListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings AddIds(this AzurePostgresServerConfigurationListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ClearIds(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings RemoveIds(this AzurePostgresServerConfigurationListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings RemoveIds(this AzurePostgresServerConfigurationListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetResourceGroup(this AzurePostgresServerConfigurationListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetResourceGroup(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetServerName(this AzurePostgresServerConfigurationListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetServerName(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetSubscription(this AzurePostgresServerConfigurationListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetSubscription(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetDebug(this AzurePostgresServerConfigurationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetDebug(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetHelp(this AzurePostgresServerConfigurationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetHelp(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetOutput(this AzurePostgresServerConfigurationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetOutput(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetQuery(this AzurePostgresServerConfigurationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetQuery(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetVerbose(this AzurePostgresServerConfigurationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetVerbose(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerConfigurationSetSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerConfigurationSetSettingsExtensions
    {
        #region Value
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Value"/></em></p>
        ///   <p>Value of the configuration. If not provided, configuration value will be set to default.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetValue(this AzurePostgresServerConfigurationSetSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Value"/></em></p>
        ///   <p>Value of the configuration. If not provided, configuration value will be set to default.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetValue(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetIds(this AzurePostgresServerConfigurationSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetIds(this AzurePostgresServerConfigurationSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings AddIds(this AzurePostgresServerConfigurationSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings AddIds(this AzurePostgresServerConfigurationSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ClearIds(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings RemoveIds(this AzurePostgresServerConfigurationSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings RemoveIds(this AzurePostgresServerConfigurationSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Name"/></em></p>
        ///   <p>The name of the server configuration.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetName(this AzurePostgresServerConfigurationSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Name"/></em></p>
        ///   <p>The name of the server configuration.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetName(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetResourceGroup(this AzurePostgresServerConfigurationSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetResourceGroup(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetServerName(this AzurePostgresServerConfigurationSetSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetServerName(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetSubscription(this AzurePostgresServerConfigurationSetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetSubscription(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetDebug(this AzurePostgresServerConfigurationSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetDebug(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetHelp(this AzurePostgresServerConfigurationSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetHelp(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetOutput(this AzurePostgresServerConfigurationSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetOutput(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetQuery(this AzurePostgresServerConfigurationSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetQuery(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetVerbose(this AzurePostgresServerConfigurationSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetVerbose(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerConfigurationShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerConfigurationShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetIds(this AzurePostgresServerConfigurationShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetIds(this AzurePostgresServerConfigurationShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings AddIds(this AzurePostgresServerConfigurationShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings AddIds(this AzurePostgresServerConfigurationShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ClearIds(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings RemoveIds(this AzurePostgresServerConfigurationShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings RemoveIds(this AzurePostgresServerConfigurationShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Name"/></em></p>
        ///   <p>The name of the server configuration.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetName(this AzurePostgresServerConfigurationShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.Name"/></em></p>
        ///   <p>The name of the server configuration.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetName(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetResourceGroup(this AzurePostgresServerConfigurationShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetResourceGroup(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetServerName(this AzurePostgresServerConfigurationShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetServerName(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetSubscription(this AzurePostgresServerConfigurationShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetSubscription(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetDebug(this AzurePostgresServerConfigurationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetDebug(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetHelp(this AzurePostgresServerConfigurationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetHelp(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetOutput(this AzurePostgresServerConfigurationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetOutput(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetQuery(this AzurePostgresServerConfigurationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetQuery(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetVerbose(this AzurePostgresServerConfigurationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetVerbose(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerFirewallRuleCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerFirewallRuleCreateSettingsExtensions
    {
        #region EndIpAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.EndIpAddress"/></em></p>
        ///   <p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetEndIpAddress(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.EndIpAddress"/></em></p>
        ///   <p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetEndIpAddress(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetName(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetName(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetResourceGroup(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetResourceGroup(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetServerName(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetServerName(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.StartIpAddress"/></em></p>
        ///   <p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetStartIpAddress(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.StartIpAddress"/></em></p>
        ///   <p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetStartIpAddress(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetSubscription(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetSubscription(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetDebug(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetDebug(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetHelp(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetHelp(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetOutput(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetOutput(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetQuery(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetQuery(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetVerbose(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetVerbose(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerFirewallRuleDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerFirewallRuleDeleteSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetYes(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetYes(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetIds(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetIds(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings AddIds(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings AddIds(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ClearIds(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings RemoveIds(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings RemoveIds(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetName(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetName(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetResourceGroup(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetResourceGroup(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetServerName(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetServerName(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetSubscription(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetSubscription(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetDebug(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetDebug(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetHelp(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetHelp(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetOutput(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetOutput(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetQuery(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetQuery(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetVerbose(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetVerbose(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerFirewallRuleListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerFirewallRuleListSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetIds(this AzurePostgresServerFirewallRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetIds(this AzurePostgresServerFirewallRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings AddIds(this AzurePostgresServerFirewallRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings AddIds(this AzurePostgresServerFirewallRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ClearIds(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings RemoveIds(this AzurePostgresServerFirewallRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings RemoveIds(this AzurePostgresServerFirewallRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetResourceGroup(this AzurePostgresServerFirewallRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetResourceGroup(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetServerName(this AzurePostgresServerFirewallRuleListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetServerName(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetSubscription(this AzurePostgresServerFirewallRuleListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetSubscription(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetDebug(this AzurePostgresServerFirewallRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetDebug(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetHelp(this AzurePostgresServerFirewallRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetHelp(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetOutput(this AzurePostgresServerFirewallRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetOutput(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetQuery(this AzurePostgresServerFirewallRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetQuery(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetVerbose(this AzurePostgresServerFirewallRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetVerbose(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerFirewallRuleShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerFirewallRuleShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetIds(this AzurePostgresServerFirewallRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetIds(this AzurePostgresServerFirewallRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings AddIds(this AzurePostgresServerFirewallRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings AddIds(this AzurePostgresServerFirewallRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ClearIds(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings RemoveIds(this AzurePostgresServerFirewallRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings RemoveIds(this AzurePostgresServerFirewallRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetName(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetName(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetResourceGroup(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetResourceGroup(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetServerName(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetServerName(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetSubscription(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetSubscription(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetDebug(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetDebug(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetHelp(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetHelp(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetOutput(this AzurePostgresServerFirewallRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetOutput(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetQuery(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetQuery(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetVerbose(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetVerbose(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerFirewallRuleUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerFirewallRuleUpdateSettingsExtensions
    {
        #region EndIpAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.EndIpAddress"/></em></p>
        ///   <p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetEndIpAddress(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.EndIpAddress"/></em></p>
        ///   <p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetEndIpAddress(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.StartIpAddress"/></em></p>
        ///   <p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetStartIpAddress(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.StartIpAddress"/></em></p>
        ///   <p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetStartIpAddress(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetIds(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetIds(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings AddIds(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings AddIds(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ClearIds(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings RemoveIds(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings RemoveIds(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetName(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetName(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetResourceGroup(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetResourceGroup(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetServerName(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetServerName(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetSubscription(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetSubscription(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetAdd(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetAdd(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetForceString(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetForceString(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetRemove(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetRemove(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetSet(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetSet(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetDebug(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetDebug(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetHelp(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetHelp(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetOutput(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetOutput(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetQuery(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetQuery(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetVerbose(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetVerbose(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerReplicaCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerReplicaCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaCreateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings SetName(this AzurePostgresServerReplicaCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaCreateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings ResetName(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings SetResourceGroup(this AzurePostgresServerReplicaCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings ResetResourceGroup(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SourceServer
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaCreateSettings.SourceServer"/></em></p>
        ///   <p>The name or resource ID of the master server to the create replica for.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings SetSourceServer(this AzurePostgresServerReplicaCreateSettings toolSettings, string sourceServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = sourceServer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaCreateSettings.SourceServer"/></em></p>
        ///   <p>The name or resource ID of the master server to the create replica for.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings ResetSourceServer(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. If not provided, the create replica will be in the same location as the master server.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings SetLocation(this AzurePostgresServerReplicaCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. If not provided, the create replica will be in the same location as the master server.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings ResetLocation(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings SetNoWait(this AzurePostgresServerReplicaCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings ResetNoWait(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzurePostgresServerReplicaCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings EnableNoWait(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzurePostgresServerReplicaCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings DisableNoWait(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzurePostgresServerReplicaCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings ToggleNoWait(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings SetSubscription(this AzurePostgresServerReplicaCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings ResetSubscription(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings SetDebug(this AzurePostgresServerReplicaCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings ResetDebug(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings SetHelp(this AzurePostgresServerReplicaCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings ResetHelp(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings SetOutput(this AzurePostgresServerReplicaCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings ResetOutput(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings SetQuery(this AzurePostgresServerReplicaCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings ResetQuery(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings SetVerbose(this AzurePostgresServerReplicaCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaCreateSettings ResetVerbose(this AzurePostgresServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerReplicaListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerReplicaListSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings SetIds(this AzurePostgresServerReplicaListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings SetIds(this AzurePostgresServerReplicaListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerReplicaListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings AddIds(this AzurePostgresServerReplicaListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerReplicaListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings AddIds(this AzurePostgresServerReplicaListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerReplicaListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings ClearIds(this AzurePostgresServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerReplicaListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings RemoveIds(this AzurePostgresServerReplicaListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerReplicaListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings RemoveIds(this AzurePostgresServerReplicaListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings SetResourceGroup(this AzurePostgresServerReplicaListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings ResetResourceGroup(this AzurePostgresServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaListSettings.ServerName"/></em></p>
        ///   <p>Name of the master server.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings SetServerName(this AzurePostgresServerReplicaListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaListSettings.ServerName"/></em></p>
        ///   <p>Name of the master server.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings ResetServerName(this AzurePostgresServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings SetSubscription(this AzurePostgresServerReplicaListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings ResetSubscription(this AzurePostgresServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings SetDebug(this AzurePostgresServerReplicaListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings ResetDebug(this AzurePostgresServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings SetHelp(this AzurePostgresServerReplicaListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings ResetHelp(this AzurePostgresServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings SetOutput(this AzurePostgresServerReplicaListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings ResetOutput(this AzurePostgresServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings SetQuery(this AzurePostgresServerReplicaListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings ResetQuery(this AzurePostgresServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings SetVerbose(this AzurePostgresServerReplicaListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaListSettings ResetVerbose(this AzurePostgresServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerReplicaStopSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerReplicaStopSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaStopSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings SetYes(this AzurePostgresServerReplicaStopSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaStopSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings ResetYes(this AzurePostgresServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaStopSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings SetIds(this AzurePostgresServerReplicaStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaStopSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings SetIds(this AzurePostgresServerReplicaStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerReplicaStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings AddIds(this AzurePostgresServerReplicaStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerReplicaStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings AddIds(this AzurePostgresServerReplicaStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerReplicaStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings ClearIds(this AzurePostgresServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerReplicaStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings RemoveIds(this AzurePostgresServerReplicaStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerReplicaStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings RemoveIds(this AzurePostgresServerReplicaStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaStopSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings SetName(this AzurePostgresServerReplicaStopSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaStopSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings ResetName(this AzurePostgresServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings SetResourceGroup(this AzurePostgresServerReplicaStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings ResetResourceGroup(this AzurePostgresServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings SetSubscription(this AzurePostgresServerReplicaStopSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings ResetSubscription(this AzurePostgresServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings SetDebug(this AzurePostgresServerReplicaStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings ResetDebug(this AzurePostgresServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings SetHelp(this AzurePostgresServerReplicaStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings ResetHelp(this AzurePostgresServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings SetOutput(this AzurePostgresServerReplicaStopSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings ResetOutput(this AzurePostgresServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings SetQuery(this AzurePostgresServerReplicaStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings ResetQuery(this AzurePostgresServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerReplicaStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings SetVerbose(this AzurePostgresServerReplicaStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerReplicaStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerReplicaStopSettings ResetVerbose(this AzurePostgresServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerVnetRuleCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerVnetRuleCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetName(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetName(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetResourceGroup(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetResourceGroup(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetServerName(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetServerName(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetSubnet(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetSubnet(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region IgnoreMissingEndpoint
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleCreateSettings toolSettings, bool? ignoreMissingEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = ignoreMissingEndpoint;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzurePostgresServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings EnableIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzurePostgresServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings DisableIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzurePostgresServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ToggleIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = !toolSettings.IgnoreMissingEndpoint;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.VnetName"/></em></p>
        ///   <p>The virtual network name.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetVnetName(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.VnetName"/></em></p>
        ///   <p>The virtual network name.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetVnetName(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetSubscription(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetSubscription(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetDebug(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetDebug(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetHelp(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetHelp(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetOutput(this AzurePostgresServerVnetRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetOutput(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetQuery(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetQuery(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetVerbose(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetVerbose(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerVnetRuleDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerVnetRuleDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetIds(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetIds(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings AddIds(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings AddIds(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ClearIds(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings RemoveIds(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings RemoveIds(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetName(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetName(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetResourceGroup(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetResourceGroup(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetServerName(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetServerName(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetSubscription(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetSubscription(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetDebug(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetDebug(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetHelp(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetHelp(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetOutput(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetOutput(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetQuery(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetQuery(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetVerbose(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetVerbose(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerVnetRuleListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerVnetRuleListSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetIds(this AzurePostgresServerVnetRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetIds(this AzurePostgresServerVnetRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings AddIds(this AzurePostgresServerVnetRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings AddIds(this AzurePostgresServerVnetRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ClearIds(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings RemoveIds(this AzurePostgresServerVnetRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings RemoveIds(this AzurePostgresServerVnetRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetResourceGroup(this AzurePostgresServerVnetRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetResourceGroup(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetServerName(this AzurePostgresServerVnetRuleListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetServerName(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetSubscription(this AzurePostgresServerVnetRuleListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetSubscription(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetDebug(this AzurePostgresServerVnetRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetDebug(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetHelp(this AzurePostgresServerVnetRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetHelp(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetOutput(this AzurePostgresServerVnetRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetOutput(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetQuery(this AzurePostgresServerVnetRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetQuery(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetVerbose(this AzurePostgresServerVnetRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetVerbose(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerVnetRuleShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerVnetRuleShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetIds(this AzurePostgresServerVnetRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetIds(this AzurePostgresServerVnetRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings AddIds(this AzurePostgresServerVnetRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings AddIds(this AzurePostgresServerVnetRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ClearIds(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings RemoveIds(this AzurePostgresServerVnetRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings RemoveIds(this AzurePostgresServerVnetRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetName(this AzurePostgresServerVnetRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetName(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetResourceGroup(this AzurePostgresServerVnetRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetResourceGroup(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetServerName(this AzurePostgresServerVnetRuleShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetServerName(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetSubscription(this AzurePostgresServerVnetRuleShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetSubscription(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetDebug(this AzurePostgresServerVnetRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetDebug(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetHelp(this AzurePostgresServerVnetRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetHelp(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetOutput(this AzurePostgresServerVnetRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetOutput(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetQuery(this AzurePostgresServerVnetRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetQuery(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetVerbose(this AzurePostgresServerVnetRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetVerbose(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerVnetRuleUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerVnetRuleUpdateSettingsExtensions
    {
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetSubnet(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetSubnet(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region IgnoreMissingEndpoint
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, bool? ignoreMissingEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = ignoreMissingEndpoint;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzurePostgresServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings EnableIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzurePostgresServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings DisableIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzurePostgresServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ToggleIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = !toolSettings.IgnoreMissingEndpoint;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.VnetName"/></em></p>
        ///   <p>The virtual network name.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetVnetName(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.VnetName"/></em></p>
        ///   <p>The virtual network name.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetVnetName(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetIds(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetIds(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings AddIds(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePostgresServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings AddIds(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePostgresServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ClearIds(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings RemoveIds(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePostgresServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings RemoveIds(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetName(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetName(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetResourceGroup(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetResourceGroup(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetServerName(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetServerName(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetSubscription(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetSubscription(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetAdd(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetAdd(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetForceString(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetForceString(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetRemove(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetRemove(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetSet(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetSet(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetDebug(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetDebug(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetHelp(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetHelp(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetOutput(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetOutput(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetQuery(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetQuery(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetVerbose(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetVerbose(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PostgresServerCreateGeoRedundantBackup
    /// <summary>
    ///   Used within <see cref="AzurePostgresTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<PostgresServerCreateGeoRedundantBackup>))]
    public partial class PostgresServerCreateGeoRedundantBackup : Enumeration
    {
        public static PostgresServerCreateGeoRedundantBackup disabled = new PostgresServerCreateGeoRedundantBackup { Value = "disabled" };
        public static PostgresServerCreateGeoRedundantBackup enabled = new PostgresServerCreateGeoRedundantBackup { Value = "enabled" };
    }
    #endregion
}
