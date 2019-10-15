// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureMysql.json
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
    public static partial class AzureMysqlTasks
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public static string AzureMysqlPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREMYSQL_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureMysqlLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Database for MySQL servers.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysql(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureMysqlPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureMysqlLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysql(AzureMysqlSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysql(Configure<AzureMysqlSettings> configurator)
        {
            return AzureMysql(configurator(new AzureMysqlSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysql(CombinatorialConfigure<AzureMysqlSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysql, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerLogsDownload(AzureMysqlServerLogsDownloadSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerLogsDownloadSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerLogsDownloadSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerLogsDownloadSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerLogsDownload(Configure<AzureMysqlServerLogsDownloadSettings> configurator)
        {
            return AzureMysqlServerLogsDownload(configurator(new AzureMysqlServerLogsDownloadSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerLogsDownloadSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerLogsDownloadSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerLogsDownloadSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerLogsDownloadSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerLogsDownload(CombinatorialConfigure<AzureMysqlServerLogsDownloadSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerLogsDownload, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerLogsList(AzureMysqlServerLogsListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerLogsListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerLogsListSettings.Debug"/></li>
        ///     <li><c>--file-last-written</c> via <see cref="AzureMysqlServerLogsListSettings.FileLastWritten"/></li>
        ///     <li><c>--filename-contains</c> via <see cref="AzureMysqlServerLogsListSettings.FilenameContains"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerLogsListSettings.Help"/></li>
        ///     <li><c>--max-file-size</c> via <see cref="AzureMysqlServerLogsListSettings.MaxFileSize"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerLogsListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerLogsListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerLogsListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerLogsListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerLogsListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerLogsListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerLogsList(Configure<AzureMysqlServerLogsListSettings> configurator)
        {
            return AzureMysqlServerLogsList(configurator(new AzureMysqlServerLogsListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerLogsListSettings.Debug"/></li>
        ///     <li><c>--file-last-written</c> via <see cref="AzureMysqlServerLogsListSettings.FileLastWritten"/></li>
        ///     <li><c>--filename-contains</c> via <see cref="AzureMysqlServerLogsListSettings.FilenameContains"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerLogsListSettings.Help"/></li>
        ///     <li><c>--max-file-size</c> via <see cref="AzureMysqlServerLogsListSettings.MaxFileSize"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerLogsListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerLogsListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerLogsListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerLogsListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerLogsListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerLogsListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerLogsListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerLogsList(CombinatorialConfigure<AzureMysqlServerLogsListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerLogsList, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlDbCreate(AzureMysqlDbCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlDbCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--charset</c> via <see cref="AzureMysqlDbCreateSettings.Charset"/></li>
        ///     <li><c>--collation</c> via <see cref="AzureMysqlDbCreateSettings.Collation"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlDbCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlDbCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlDbCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlDbCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlDbCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlDbCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlDbCreateSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlDbCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlDbCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlDbCreate(Configure<AzureMysqlDbCreateSettings> configurator)
        {
            return AzureMysqlDbCreate(configurator(new AzureMysqlDbCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--charset</c> via <see cref="AzureMysqlDbCreateSettings.Charset"/></li>
        ///     <li><c>--collation</c> via <see cref="AzureMysqlDbCreateSettings.Collation"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlDbCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlDbCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlDbCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlDbCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlDbCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlDbCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlDbCreateSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlDbCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlDbCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlDbCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlDbCreate(CombinatorialConfigure<AzureMysqlDbCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlDbCreate, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlDbDelete(AzureMysqlDbDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlDbDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlDbDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlDbDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlDbDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlDbDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlDbDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlDbDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlDbDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlDbDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlDbDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMysqlDbDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlDbDelete(Configure<AzureMysqlDbDeleteSettings> configurator)
        {
            return AzureMysqlDbDelete(configurator(new AzureMysqlDbDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlDbDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlDbDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlDbDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlDbDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlDbDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlDbDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlDbDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlDbDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlDbDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMysqlDbDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlDbDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlDbDelete(CombinatorialConfigure<AzureMysqlDbDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlDbDelete, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlDbList(AzureMysqlDbListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlDbListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlDbListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlDbListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlDbListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlDbListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlDbListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlDbListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlDbListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlDbListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlDbList(Configure<AzureMysqlDbListSettings> configurator)
        {
            return AzureMysqlDbList(configurator(new AzureMysqlDbListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlDbListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlDbListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlDbListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlDbListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlDbListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlDbListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlDbListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlDbListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlDbListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlDbList(CombinatorialConfigure<AzureMysqlDbListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlDbList, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlDbShow(AzureMysqlDbShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlDbShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlDbShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlDbShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlDbShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlDbShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlDbShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlDbShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlDbShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlDbShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlDbShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlDbShow(Configure<AzureMysqlDbShowSettings> configurator)
        {
            return AzureMysqlDbShow(configurator(new AzureMysqlDbShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlDbShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlDbShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlDbShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlDbShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlDbShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlDbShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlDbShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlDbShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlDbShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlDbShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlDbShow(CombinatorialConfigure<AzureMysqlDbShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlDbShow, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerCreate(AzureMysqlServerCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--admin-password</c> via <see cref="AzureMysqlServerCreateSettings.AdminPassword"/></li>
        ///     <li><c>--admin-user</c> via <see cref="AzureMysqlServerCreateSettings.AdminUser"/></li>
        ///     <li><c>--auto-grow</c> via <see cref="AzureMysqlServerCreateSettings.AutoGrow"/></li>
        ///     <li><c>--backup-retention</c> via <see cref="AzureMysqlServerCreateSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerCreateSettings.Debug"/></li>
        ///     <li><c>--geo-redundant-backup</c> via <see cref="AzureMysqlServerCreateSettings.GeoRedundantBackup"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureMysqlServerCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMysqlServerCreateSettings.SkuName"/></li>
        ///     <li><c>--ssl-enforcement</c> via <see cref="AzureMysqlServerCreateSettings.SslEnforcement"/></li>
        ///     <li><c>--storage-size</c> via <see cref="AzureMysqlServerCreateSettings.StorageSize"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureMysqlServerCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerCreateSettings.Verbose"/></li>
        ///     <li><c>--version</c> via <see cref="AzureMysqlServerCreateSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerCreate(Configure<AzureMysqlServerCreateSettings> configurator)
        {
            return AzureMysqlServerCreate(configurator(new AzureMysqlServerCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--admin-password</c> via <see cref="AzureMysqlServerCreateSettings.AdminPassword"/></li>
        ///     <li><c>--admin-user</c> via <see cref="AzureMysqlServerCreateSettings.AdminUser"/></li>
        ///     <li><c>--auto-grow</c> via <see cref="AzureMysqlServerCreateSettings.AutoGrow"/></li>
        ///     <li><c>--backup-retention</c> via <see cref="AzureMysqlServerCreateSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerCreateSettings.Debug"/></li>
        ///     <li><c>--geo-redundant-backup</c> via <see cref="AzureMysqlServerCreateSettings.GeoRedundantBackup"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureMysqlServerCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMysqlServerCreateSettings.SkuName"/></li>
        ///     <li><c>--ssl-enforcement</c> via <see cref="AzureMysqlServerCreateSettings.SslEnforcement"/></li>
        ///     <li><c>--storage-size</c> via <see cref="AzureMysqlServerCreateSettings.StorageSize"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureMysqlServerCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerCreateSettings.Verbose"/></li>
        ///     <li><c>--version</c> via <see cref="AzureMysqlServerCreateSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerCreate(CombinatorialConfigure<AzureMysqlServerCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerCreate, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerDelete(AzureMysqlServerDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMysqlServerDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerDelete(Configure<AzureMysqlServerDeleteSettings> configurator)
        {
            return AzureMysqlServerDelete(configurator(new AzureMysqlServerDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMysqlServerDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerDelete(CombinatorialConfigure<AzureMysqlServerDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerDelete, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerGeorestore(AzureMysqlServerGeorestoreSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerGeorestoreSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--backup-retention</c> via <see cref="AzureMysqlServerGeorestoreSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerGeorestoreSettings.Debug"/></li>
        ///     <li><c>--geo-redundant-backup</c> via <see cref="AzureMysqlServerGeorestoreSettings.GeoRedundantBackup"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerGeorestoreSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerGeorestoreSettings.Ids"/></li>
        ///     <li><c>--location</c> via <see cref="AzureMysqlServerGeorestoreSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerGeorestoreSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureMysqlServerGeorestoreSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerGeorestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerGeorestoreSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerGeorestoreSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMysqlServerGeorestoreSettings.SkuName"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzureMysqlServerGeorestoreSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerGeorestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerGeorestoreSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerGeorestore(Configure<AzureMysqlServerGeorestoreSettings> configurator)
        {
            return AzureMysqlServerGeorestore(configurator(new AzureMysqlServerGeorestoreSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--backup-retention</c> via <see cref="AzureMysqlServerGeorestoreSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerGeorestoreSettings.Debug"/></li>
        ///     <li><c>--geo-redundant-backup</c> via <see cref="AzureMysqlServerGeorestoreSettings.GeoRedundantBackup"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerGeorestoreSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerGeorestoreSettings.Ids"/></li>
        ///     <li><c>--location</c> via <see cref="AzureMysqlServerGeorestoreSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerGeorestoreSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureMysqlServerGeorestoreSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerGeorestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerGeorestoreSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerGeorestoreSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMysqlServerGeorestoreSettings.SkuName"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzureMysqlServerGeorestoreSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerGeorestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerGeorestoreSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerGeorestoreSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerGeorestore(CombinatorialConfigure<AzureMysqlServerGeorestoreSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerGeorestore, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerList(AzureMysqlServerListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerList(Configure<AzureMysqlServerListSettings> configurator)
        {
            return AzureMysqlServerList(configurator(new AzureMysqlServerListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerList(CombinatorialConfigure<AzureMysqlServerListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerList, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerRestart(AzureMysqlServerRestartSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerRestartSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerRestartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerRestartSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerRestartSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerRestartSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerRestartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerRestartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerRestartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerRestartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerRestartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerRestart(Configure<AzureMysqlServerRestartSettings> configurator)
        {
            return AzureMysqlServerRestart(configurator(new AzureMysqlServerRestartSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerRestartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerRestartSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerRestartSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerRestartSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerRestartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerRestartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerRestartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerRestartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerRestartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerRestartSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerRestart(CombinatorialConfigure<AzureMysqlServerRestartSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerRestart, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerRestore(AzureMysqlServerRestoreSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerRestoreSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerRestoreSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerRestoreSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerRestoreSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerRestoreSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureMysqlServerRestoreSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerRestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerRestoreSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerRestoreSettings.ResourceGroup"/></li>
        ///     <li><c>--restore-point-in-time</c> via <see cref="AzureMysqlServerRestoreSettings.RestorePointInTime"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzureMysqlServerRestoreSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerRestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerRestoreSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerRestore(Configure<AzureMysqlServerRestoreSettings> configurator)
        {
            return AzureMysqlServerRestore(configurator(new AzureMysqlServerRestoreSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerRestoreSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerRestoreSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerRestoreSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerRestoreSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureMysqlServerRestoreSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerRestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerRestoreSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerRestoreSettings.ResourceGroup"/></li>
        ///     <li><c>--restore-point-in-time</c> via <see cref="AzureMysqlServerRestoreSettings.RestorePointInTime"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzureMysqlServerRestoreSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerRestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerRestoreSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerRestoreSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerRestore(CombinatorialConfigure<AzureMysqlServerRestoreSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerRestore, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerShow(AzureMysqlServerShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerShow(Configure<AzureMysqlServerShowSettings> configurator)
        {
            return AzureMysqlServerShow(configurator(new AzureMysqlServerShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerShow(CombinatorialConfigure<AzureMysqlServerShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerShow, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerUpdate(AzureMysqlServerUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMysqlServerUpdateSettings.Add"/></li>
        ///     <li><c>--admin-password</c> via <see cref="AzureMysqlServerUpdateSettings.AdminPassword"/></li>
        ///     <li><c>--auto-grow</c> via <see cref="AzureMysqlServerUpdateSettings.AutoGrow"/></li>
        ///     <li><c>--backup-retention</c> via <see cref="AzureMysqlServerUpdateSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMysqlServerUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMysqlServerUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMysqlServerUpdateSettings.Set"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMysqlServerUpdateSettings.SkuName"/></li>
        ///     <li><c>--ssl-enforcement</c> via <see cref="AzureMysqlServerUpdateSettings.SslEnforcement"/></li>
        ///     <li><c>--storage-size</c> via <see cref="AzureMysqlServerUpdateSettings.StorageSize"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureMysqlServerUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerUpdate(Configure<AzureMysqlServerUpdateSettings> configurator)
        {
            return AzureMysqlServerUpdate(configurator(new AzureMysqlServerUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMysqlServerUpdateSettings.Add"/></li>
        ///     <li><c>--admin-password</c> via <see cref="AzureMysqlServerUpdateSettings.AdminPassword"/></li>
        ///     <li><c>--auto-grow</c> via <see cref="AzureMysqlServerUpdateSettings.AutoGrow"/></li>
        ///     <li><c>--backup-retention</c> via <see cref="AzureMysqlServerUpdateSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMysqlServerUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMysqlServerUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMysqlServerUpdateSettings.Set"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMysqlServerUpdateSettings.SkuName"/></li>
        ///     <li><c>--ssl-enforcement</c> via <see cref="AzureMysqlServerUpdateSettings.SslEnforcement"/></li>
        ///     <li><c>--storage-size</c> via <see cref="AzureMysqlServerUpdateSettings.StorageSize"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureMysqlServerUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerUpdate(CombinatorialConfigure<AzureMysqlServerUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerUpdate, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerWait(AzureMysqlServerWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--custom</c> via <see cref="AzureMysqlServerWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerWaitSettings.Debug"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureMysqlServerWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureMysqlServerWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureMysqlServerWaitSettings.Timeout"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerWait(Configure<AzureMysqlServerWaitSettings> configurator)
        {
            return AzureMysqlServerWait(configurator(new AzureMysqlServerWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--custom</c> via <see cref="AzureMysqlServerWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerWaitSettings.Debug"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureMysqlServerWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureMysqlServerWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureMysqlServerWaitSettings.Timeout"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerWait(CombinatorialConfigure<AzureMysqlServerWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerWait, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerVnetRuleCreate(AzureMysqlServerVnetRuleCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerVnetRuleCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Help"/></li>
        ///     <li><c>--ignore-missing-endpoint</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.ServerName"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerVnetRuleCreate(Configure<AzureMysqlServerVnetRuleCreateSettings> configurator)
        {
            return AzureMysqlServerVnetRuleCreate(configurator(new AzureMysqlServerVnetRuleCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Help"/></li>
        ///     <li><c>--ignore-missing-endpoint</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.ServerName"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureMysqlServerVnetRuleCreateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerVnetRuleCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerVnetRuleCreate(CombinatorialConfigure<AzureMysqlServerVnetRuleCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerVnetRuleCreate, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerVnetRuleDelete(AzureMysqlServerVnetRuleDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerVnetRuleDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerVnetRuleDelete(Configure<AzureMysqlServerVnetRuleDeleteSettings> configurator)
        {
            return AzureMysqlServerVnetRuleDelete(configurator(new AzureMysqlServerVnetRuleDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerVnetRuleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerVnetRuleDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerVnetRuleDelete(CombinatorialConfigure<AzureMysqlServerVnetRuleDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerVnetRuleDelete, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerVnetRuleList(AzureMysqlServerVnetRuleListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerVnetRuleListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerVnetRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerVnetRuleListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerVnetRuleList(Configure<AzureMysqlServerVnetRuleListSettings> configurator)
        {
            return AzureMysqlServerVnetRuleList(configurator(new AzureMysqlServerVnetRuleListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerVnetRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerVnetRuleListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerVnetRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerVnetRuleListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerVnetRuleList(CombinatorialConfigure<AzureMysqlServerVnetRuleListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerVnetRuleList, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerVnetRuleShow(AzureMysqlServerVnetRuleShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerVnetRuleShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerVnetRuleShow(Configure<AzureMysqlServerVnetRuleShowSettings> configurator)
        {
            return AzureMysqlServerVnetRuleShow(configurator(new AzureMysqlServerVnetRuleShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerVnetRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerVnetRuleShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerVnetRuleShow(CombinatorialConfigure<AzureMysqlServerVnetRuleShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerVnetRuleShow, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerVnetRuleUpdate(AzureMysqlServerVnetRuleUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerVnetRuleUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--ignore-missing-endpoint</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.ServerName"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Set"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerVnetRuleUpdate(Configure<AzureMysqlServerVnetRuleUpdateSettings> configurator)
        {
            return AzureMysqlServerVnetRuleUpdate(configurator(new AzureMysqlServerVnetRuleUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--ignore-missing-endpoint</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.ServerName"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Set"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureMysqlServerVnetRuleUpdateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerVnetRuleUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerVnetRuleUpdate(CombinatorialConfigure<AzureMysqlServerVnetRuleUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerVnetRuleUpdate, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerReplicaCreate(AzureMysqlServerReplicaCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerReplicaCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureMysqlServerReplicaCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerReplicaCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMysqlServerReplicaCreateSettings.SkuName"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzureMysqlServerReplicaCreateSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerReplicaCreate(Configure<AzureMysqlServerReplicaCreateSettings> configurator)
        {
            return AzureMysqlServerReplicaCreate(configurator(new AzureMysqlServerReplicaCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureMysqlServerReplicaCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerReplicaCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMysqlServerReplicaCreateSettings.SkuName"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzureMysqlServerReplicaCreateSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerReplicaCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerReplicaCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerReplicaCreate(CombinatorialConfigure<AzureMysqlServerReplicaCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerReplicaCreate, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerReplicaList(AzureMysqlServerReplicaListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerReplicaListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerReplicaListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerReplicaListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerReplicaListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerReplicaListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerReplicaListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerReplicaListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerReplicaListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerReplicaListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerReplicaListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerReplicaList(Configure<AzureMysqlServerReplicaListSettings> configurator)
        {
            return AzureMysqlServerReplicaList(configurator(new AzureMysqlServerReplicaListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerReplicaListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerReplicaListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerReplicaListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerReplicaListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerReplicaListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerReplicaListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerReplicaListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerReplicaListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerReplicaListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerReplicaListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerReplicaList(CombinatorialConfigure<AzureMysqlServerReplicaListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerReplicaList, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerReplicaStop(AzureMysqlServerReplicaStopSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerReplicaStopSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerReplicaStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerReplicaStopSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerReplicaStopSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerReplicaStopSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerReplicaStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerReplicaStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerReplicaStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerReplicaStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerReplicaStopSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMysqlServerReplicaStopSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerReplicaStop(Configure<AzureMysqlServerReplicaStopSettings> configurator)
        {
            return AzureMysqlServerReplicaStop(configurator(new AzureMysqlServerReplicaStopSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerReplicaStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerReplicaStopSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerReplicaStopSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerReplicaStopSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerReplicaStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerReplicaStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerReplicaStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerReplicaStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerReplicaStopSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMysqlServerReplicaStopSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerReplicaStopSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerReplicaStop(CombinatorialConfigure<AzureMysqlServerReplicaStopSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerReplicaStop, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerConfigurationList(AzureMysqlServerConfigurationListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerConfigurationListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerConfigurationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerConfigurationListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerConfigurationListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerConfigurationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerConfigurationListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerConfigurationListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerConfigurationListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerConfigurationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerConfigurationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerConfigurationList(Configure<AzureMysqlServerConfigurationListSettings> configurator)
        {
            return AzureMysqlServerConfigurationList(configurator(new AzureMysqlServerConfigurationListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerConfigurationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerConfigurationListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerConfigurationListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerConfigurationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerConfigurationListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerConfigurationListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerConfigurationListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerConfigurationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerConfigurationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerConfigurationListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerConfigurationList(CombinatorialConfigure<AzureMysqlServerConfigurationListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerConfigurationList, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerConfigurationSet(AzureMysqlServerConfigurationSetSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerConfigurationSetSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerConfigurationSetSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerConfigurationSetSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Subscription"/></li>
        ///     <li><c>--value</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Value"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerConfigurationSet(Configure<AzureMysqlServerConfigurationSetSettings> configurator)
        {
            return AzureMysqlServerConfigurationSet(configurator(new AzureMysqlServerConfigurationSetSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerConfigurationSetSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerConfigurationSetSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Subscription"/></li>
        ///     <li><c>--value</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Value"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerConfigurationSetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerConfigurationSetSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerConfigurationSet(CombinatorialConfigure<AzureMysqlServerConfigurationSetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerConfigurationSet, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerConfigurationShow(AzureMysqlServerConfigurationShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerConfigurationShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerConfigurationShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerConfigurationShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerConfigurationShow(Configure<AzureMysqlServerConfigurationShowSettings> configurator)
        {
            return AzureMysqlServerConfigurationShow(configurator(new AzureMysqlServerConfigurationShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerConfigurationShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerConfigurationShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerConfigurationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerConfigurationShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerConfigurationShow(CombinatorialConfigure<AzureMysqlServerConfigurationShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerConfigurationShow, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerFirewallRuleCreate(AzureMysqlServerFirewallRuleCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerFirewallRuleCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Debug"/></li>
        ///     <li><c>--end-ip-address</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.EndIpAddress"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.ServerName"/></li>
        ///     <li><c>--start-ip-address</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.StartIpAddress"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerFirewallRuleCreate(Configure<AzureMysqlServerFirewallRuleCreateSettings> configurator)
        {
            return AzureMysqlServerFirewallRuleCreate(configurator(new AzureMysqlServerFirewallRuleCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Debug"/></li>
        ///     <li><c>--end-ip-address</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.EndIpAddress"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.ServerName"/></li>
        ///     <li><c>--start-ip-address</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.StartIpAddress"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerFirewallRuleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerFirewallRuleCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerFirewallRuleCreate(CombinatorialConfigure<AzureMysqlServerFirewallRuleCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerFirewallRuleCreate, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerFirewallRuleDelete(AzureMysqlServerFirewallRuleDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerFirewallRuleDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerFirewallRuleDelete(Configure<AzureMysqlServerFirewallRuleDeleteSettings> configurator)
        {
            return AzureMysqlServerFirewallRuleDelete(configurator(new AzureMysqlServerFirewallRuleDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerFirewallRuleDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerFirewallRuleDelete(CombinatorialConfigure<AzureMysqlServerFirewallRuleDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerFirewallRuleDelete, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerFirewallRuleList(AzureMysqlServerFirewallRuleListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerFirewallRuleListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerFirewallRuleList(Configure<AzureMysqlServerFirewallRuleListSettings> configurator)
        {
            return AzureMysqlServerFirewallRuleList(configurator(new AzureMysqlServerFirewallRuleListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerFirewallRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerFirewallRuleListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerFirewallRuleList(CombinatorialConfigure<AzureMysqlServerFirewallRuleListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerFirewallRuleList, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerFirewallRuleShow(AzureMysqlServerFirewallRuleShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerFirewallRuleShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerFirewallRuleShow(Configure<AzureMysqlServerFirewallRuleShowSettings> configurator)
        {
            return AzureMysqlServerFirewallRuleShow(configurator(new AzureMysqlServerFirewallRuleShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerFirewallRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerFirewallRuleShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerFirewallRuleShow(CombinatorialConfigure<AzureMysqlServerFirewallRuleShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerFirewallRuleShow, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMysqlServerFirewallRuleUpdate(AzureMysqlServerFirewallRuleUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMysqlServerFirewallRuleUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--end-ip-address</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.EndIpAddress"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ServerName"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Set"/></li>
        ///     <li><c>--start-ip-address</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.StartIpAddress"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMysqlServerFirewallRuleUpdate(Configure<AzureMysqlServerFirewallRuleUpdateSettings> configurator)
        {
            return AzureMysqlServerFirewallRuleUpdate(configurator(new AzureMysqlServerFirewallRuleUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MySQL servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--end-ip-address</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.EndIpAddress"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ServerName"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Set"/></li>
        ///     <li><c>--start-ip-address</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.StartIpAddress"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMysqlServerFirewallRuleUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMysqlServerFirewallRuleUpdate(CombinatorialConfigure<AzureMysqlServerFirewallRuleUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMysqlServerFirewallRuleUpdate, AzureMysqlLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureMysqlSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerLogsDownloadSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerLogsDownloadSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server-logs download")
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
    #region AzureMysqlServerLogsListSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerLogsListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server-logs list")
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
    #region AzureMysqlDbCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlDbCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql db create")
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
    #region AzureMysqlDbDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlDbDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql db delete")
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
    #region AzureMysqlDbListSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlDbListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql db list")
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
    #region AzureMysqlDbShowSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlDbShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql db show")
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
    #region AzureMysqlServerCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
        ///   Enable or disable autogrow of the storage. Default value is Enabled.
        /// </summary>
        public virtual MysqlServerAutoGrow AutoGrow { get; internal set; }
        /// <summary>
        ///   The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.
        /// </summary>
        public virtual string BackupRetention { get; internal set; }
        /// <summary>
        ///   Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.
        /// </summary>
        public virtual MysqlServerAutoGrow GeoRedundantBackup { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Enable or disable ssl enforcement for connections to server. Default is Enabled.
        /// </summary>
        public virtual MysqlServerAutoGrow SslEnforcement { get; internal set; }
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
              .Add("mysql server create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku-name {value}", SkuName)
              .Add("--auto-grow {value}", AutoGrow)
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
    #region AzureMysqlServerDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server delete")
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
    #region AzureMysqlServerGeorestoreSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerGeorestoreSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server georestore")
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
    #region AzureMysqlServerListSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server list")
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
    #region AzureMysqlServerRestartSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerRestartSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server restart")
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
    #region AzureMysqlServerRestoreSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerRestoreSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server restore")
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
    #region AzureMysqlServerShowSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server show")
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
    #region AzureMysqlServerUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
        /// <summary>
        ///   The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.
        /// </summary>
        public virtual string AdminPassword { get; internal set; }
        /// <summary>
        ///   Enable or disable autogrow of the storage. Default value is Enabled.
        /// </summary>
        public virtual MysqlServerAutoGrow AutoGrow { get; internal set; }
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
        public virtual MysqlServerAutoGrow SslEnforcement { get; internal set; }
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
              .Add("mysql server update")
              .Add("--admin-password {value}", AdminPassword, secret: true)
              .Add("--auto-grow {value}", AutoGrow)
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
    #region AzureMysqlServerWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server wait")
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
    #region AzureMysqlServerVnetRuleCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerVnetRuleCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server vnet-rule create")
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
    #region AzureMysqlServerVnetRuleDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerVnetRuleDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server vnet-rule delete")
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
    #region AzureMysqlServerVnetRuleListSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerVnetRuleListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server vnet-rule list")
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
    #region AzureMysqlServerVnetRuleShowSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerVnetRuleShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server vnet-rule show")
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
    #region AzureMysqlServerVnetRuleUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerVnetRuleUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server vnet-rule update")
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
    #region AzureMysqlServerReplicaCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerReplicaCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
        ///   The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.
        /// </summary>
        public virtual string SkuName { get; internal set; }
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
              .Add("mysql server replica create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--source-server {value}", SourceServer)
              .Add("--location {value}", Location)
              .Add("--no-wait", NoWait)
              .Add("--sku-name {value}", SkuName)
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
    #region AzureMysqlServerReplicaListSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerReplicaListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server replica list")
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
    #region AzureMysqlServerReplicaStopSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerReplicaStopSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server replica stop")
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
    #region AzureMysqlServerConfigurationListSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerConfigurationListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server configuration list")
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
    #region AzureMysqlServerConfigurationSetSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerConfigurationSetSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server configuration set")
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
    #region AzureMysqlServerConfigurationShowSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerConfigurationShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server configuration show")
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
    #region AzureMysqlServerFirewallRuleCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerFirewallRuleCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server firewall-rule create")
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
    #region AzureMysqlServerFirewallRuleDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerFirewallRuleDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server firewall-rule delete")
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
    #region AzureMysqlServerFirewallRuleListSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerFirewallRuleListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server firewall-rule list")
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
    #region AzureMysqlServerFirewallRuleShowSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerFirewallRuleShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server firewall-rule show")
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
    #region AzureMysqlServerFirewallRuleUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerFirewallRuleUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMysql executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        public override Action<OutputType, string> CustomLogger => AzureMysqlTasks.AzureMysqlLogger;
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
              .Add("mysql server firewall-rule update")
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
    #region AzureMysqlSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlSettings SetDebug(this AzureMysqlSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlSettings ResetDebug(this AzureMysqlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlSettings SetHelp(this AzureMysqlSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlSettings ResetHelp(this AzureMysqlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlSettings SetOutput(this AzureMysqlSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlSettings ResetOutput(this AzureMysqlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlSettings SetQuery(this AzureMysqlSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlSettings ResetQuery(this AzureMysqlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlSettings SetVerbose(this AzureMysqlSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlSettings ResetVerbose(this AzureMysqlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerLogsDownloadSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerLogsDownloadSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Name"/> to a new list</em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetName(this AzureMysqlServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal = name.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Name"/> to a new list</em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetName(this AzureMysqlServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal = name.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings AddName(this AzureMysqlServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.AddRange(name);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings AddName(this AzureMysqlServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.AddRange(name);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ClearName(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings RemoveName(this AzureMysqlServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(name);
            toolSettings.NameInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings RemoveName(this AzureMysqlServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(name);
            toolSettings.NameInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetResourceGroup(this AzureMysqlServerLogsDownloadSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetResourceGroup(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetServerName(this AzureMysqlServerLogsDownloadSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetServerName(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetSubscription(this AzureMysqlServerLogsDownloadSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetSubscription(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetDebug(this AzureMysqlServerLogsDownloadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetDebug(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetHelp(this AzureMysqlServerLogsDownloadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetHelp(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetOutput(this AzureMysqlServerLogsDownloadSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetOutput(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetQuery(this AzureMysqlServerLogsDownloadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetQuery(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetVerbose(this AzureMysqlServerLogsDownloadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetVerbose(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerLogsListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerLogsListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetResourceGroup(this AzureMysqlServerLogsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetResourceGroup(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetServerName(this AzureMysqlServerLogsListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetServerName(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region FileLastWritten
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsListSettings.FileLastWritten"/></em></p>
        ///   <p>Integer in hours to indicate file last modify time, default value is 72.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetFileLastWritten(this AzureMysqlServerLogsListSettings toolSettings, string fileLastWritten)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileLastWritten = fileLastWritten;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsListSettings.FileLastWritten"/></em></p>
        ///   <p>Integer in hours to indicate file last modify time, default value is 72.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetFileLastWritten(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileLastWritten = null;
            return toolSettings;
        }
        #endregion
        #region FilenameContains
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsListSettings.FilenameContains"/></em></p>
        ///   <p>The pattern that file name should match.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetFilenameContains(this AzureMysqlServerLogsListSettings toolSettings, string filenameContains)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilenameContains = filenameContains;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsListSettings.FilenameContains"/></em></p>
        ///   <p>The pattern that file name should match.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetFilenameContains(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilenameContains = null;
            return toolSettings;
        }
        #endregion
        #region MaxFileSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsListSettings.MaxFileSize"/></em></p>
        ///   <p>The file size limitation to filter files.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetMaxFileSize(this AzureMysqlServerLogsListSettings toolSettings, string maxFileSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxFileSize = maxFileSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsListSettings.MaxFileSize"/></em></p>
        ///   <p>The file size limitation to filter files.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetMaxFileSize(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxFileSize = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetSubscription(this AzureMysqlServerLogsListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetSubscription(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetDebug(this AzureMysqlServerLogsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetDebug(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetHelp(this AzureMysqlServerLogsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetHelp(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetOutput(this AzureMysqlServerLogsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetOutput(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetQuery(this AzureMysqlServerLogsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetQuery(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerLogsListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetVerbose(this AzureMysqlServerLogsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerLogsListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetVerbose(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlDbCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlDbCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbCreateSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetName(this AzureMysqlDbCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbCreateSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetName(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetResourceGroup(this AzureMysqlDbCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetResourceGroup(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetServerName(this AzureMysqlDbCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetServerName(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Charset
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbCreateSettings.Charset"/></em></p>
        ///   <p>The charset of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetCharset(this AzureMysqlDbCreateSettings toolSettings, string charset)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Charset = charset;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbCreateSettings.Charset"/></em></p>
        ///   <p>The charset of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetCharset(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Charset = null;
            return toolSettings;
        }
        #endregion
        #region Collation
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbCreateSettings.Collation"/></em></p>
        ///   <p>The collation of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetCollation(this AzureMysqlDbCreateSettings toolSettings, string collation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Collation = collation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbCreateSettings.Collation"/></em></p>
        ///   <p>The collation of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetCollation(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Collation = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetSubscription(this AzureMysqlDbCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetSubscription(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetDebug(this AzureMysqlDbCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetDebug(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetHelp(this AzureMysqlDbCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetHelp(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetOutput(this AzureMysqlDbCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetOutput(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetQuery(this AzureMysqlDbCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetQuery(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetVerbose(this AzureMysqlDbCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetVerbose(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlDbDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlDbDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetName(this AzureMysqlDbDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetName(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetResourceGroup(this AzureMysqlDbDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetResourceGroup(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetServerName(this AzureMysqlDbDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetServerName(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetYes(this AzureMysqlDbDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetYes(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetSubscription(this AzureMysqlDbDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetSubscription(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetDebug(this AzureMysqlDbDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetDebug(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetHelp(this AzureMysqlDbDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetHelp(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetOutput(this AzureMysqlDbDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetOutput(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetQuery(this AzureMysqlDbDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetQuery(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetVerbose(this AzureMysqlDbDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetVerbose(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlDbListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlDbListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings SetResourceGroup(this AzureMysqlDbListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetResourceGroup(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings SetServerName(this AzureMysqlDbListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetServerName(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings SetSubscription(this AzureMysqlDbListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetSubscription(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings SetDebug(this AzureMysqlDbListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetDebug(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings SetHelp(this AzureMysqlDbListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetHelp(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings SetOutput(this AzureMysqlDbListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetOutput(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings SetQuery(this AzureMysqlDbListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetQuery(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings SetVerbose(this AzureMysqlDbListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetVerbose(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlDbShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlDbShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbShowSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetName(this AzureMysqlDbShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbShowSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetName(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetResourceGroup(this AzureMysqlDbShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetResourceGroup(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetServerName(this AzureMysqlDbShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetServerName(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetSubscription(this AzureMysqlDbShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetSubscription(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetDebug(this AzureMysqlDbShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetDebug(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetHelp(this AzureMysqlDbShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetHelp(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetOutput(this AzureMysqlDbShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetOutput(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetQuery(this AzureMysqlDbShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetQuery(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlDbShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetVerbose(this AzureMysqlDbShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlDbShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetVerbose(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetName(this AzureMysqlServerCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetName(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetResourceGroup(this AzureMysqlServerCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetResourceGroup(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetSkuName(this AzureMysqlServerCreateSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetSkuName(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region AutoGrow
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.AutoGrow"/></em></p>
        ///   <p>Enable or disable autogrow of the storage. Default value is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetAutoGrow(this AzureMysqlServerCreateSettings toolSettings, MysqlServerAutoGrow autoGrow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoGrow = autoGrow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.AutoGrow"/></em></p>
        ///   <p>Enable or disable autogrow of the storage. Default value is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetAutoGrow(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoGrow = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetBackupRetention(this AzureMysqlServerCreateSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetBackupRetention(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region GeoRedundantBackup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.GeoRedundantBackup"/></em></p>
        ///   <p>Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetGeoRedundantBackup(this AzureMysqlServerCreateSettings toolSettings, MysqlServerAutoGrow geoRedundantBackup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = geoRedundantBackup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.GeoRedundantBackup"/></em></p>
        ///   <p>Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetGeoRedundantBackup(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetLocation(this AzureMysqlServerCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetLocation(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region SslEnforcement
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.SslEnforcement"/></em></p>
        ///   <p>Enable or disable ssl enforcement for connections to server. Default is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetSslEnforcement(this AzureMysqlServerCreateSettings toolSettings, MysqlServerAutoGrow sslEnforcement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = sslEnforcement;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.SslEnforcement"/></em></p>
        ///   <p>Enable or disable ssl enforcement for connections to server. Default is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetSslEnforcement(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = null;
            return toolSettings;
        }
        #endregion
        #region StorageSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.StorageSize"/></em></p>
        ///   <p>The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetStorageSize(this AzureMysqlServerCreateSettings toolSettings, string storageSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = storageSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.StorageSize"/></em></p>
        ///   <p>The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetStorageSize(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetTags(this AzureMysqlServerCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetTags(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.Version"/></em></p>
        ///   <p>Server major version.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetVersion(this AzureMysqlServerCreateSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.Version"/></em></p>
        ///   <p>Server major version.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetVersion(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region AdminPassword
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.AdminPassword"/></em></p>
        ///   <p>The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetAdminPassword(this AzureMysqlServerCreateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.AdminPassword"/></em></p>
        ///   <p>The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetAdminPassword(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region AdminUser
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.AdminUser"/></em></p>
        ///   <p>Administrator username for the server. Once set, it cannot be changed.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetAdminUser(this AzureMysqlServerCreateSettings toolSettings, string adminUser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUser = adminUser;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.AdminUser"/></em></p>
        ///   <p>Administrator username for the server. Once set, it cannot be changed.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetAdminUser(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUser = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetSubscription(this AzureMysqlServerCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetSubscription(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetDebug(this AzureMysqlServerCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetDebug(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetHelp(this AzureMysqlServerCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetHelp(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetOutput(this AzureMysqlServerCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetOutput(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetQuery(this AzureMysqlServerCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetQuery(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetVerbose(this AzureMysqlServerCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetVerbose(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerDeleteSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetYes(this AzureMysqlServerDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetYes(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetIds(this AzureMysqlServerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetIds(this AzureMysqlServerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings AddIds(this AzureMysqlServerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings AddIds(this AzureMysqlServerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ClearIds(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings RemoveIds(this AzureMysqlServerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings RemoveIds(this AzureMysqlServerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetName(this AzureMysqlServerDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetName(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetResourceGroup(this AzureMysqlServerDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetResourceGroup(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetSubscription(this AzureMysqlServerDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetSubscription(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetDebug(this AzureMysqlServerDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetDebug(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetHelp(this AzureMysqlServerDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetHelp(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetOutput(this AzureMysqlServerDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetOutput(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetQuery(this AzureMysqlServerDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetQuery(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetVerbose(this AzureMysqlServerDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetVerbose(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerGeorestoreSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerGeorestoreSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetLocation(this AzureMysqlServerGeorestoreSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetLocation(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region SourceServer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.SourceServer"/></em></p>
        ///   <p>The name or ID of the source server to restore from.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetSourceServer(this AzureMysqlServerGeorestoreSettings toolSettings, string sourceServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = sourceServer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.SourceServer"/></em></p>
        ///   <p>The name or ID of the source server to restore from.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetSourceServer(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetBackupRetention(this AzureMysqlServerGeorestoreSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetBackupRetention(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region GeoRedundantBackup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.GeoRedundantBackup"/></em></p>
        ///   <p>Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetGeoRedundantBackup(this AzureMysqlServerGeorestoreSettings toolSettings, string geoRedundantBackup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = geoRedundantBackup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.GeoRedundantBackup"/></em></p>
        ///   <p>Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetGeoRedundantBackup(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetNoWait(this AzureMysqlServerGeorestoreSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetNoWait(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureMysqlServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings EnableNoWait(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureMysqlServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings DisableNoWait(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureMysqlServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ToggleNoWait(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Defaults to sku of the source server. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetSkuName(this AzureMysqlServerGeorestoreSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Defaults to sku of the source server. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetSkuName(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetIds(this AzureMysqlServerGeorestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetIds(this AzureMysqlServerGeorestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings AddIds(this AzureMysqlServerGeorestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings AddIds(this AzureMysqlServerGeorestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ClearIds(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings RemoveIds(this AzureMysqlServerGeorestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings RemoveIds(this AzureMysqlServerGeorestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetName(this AzureMysqlServerGeorestoreSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetName(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetResourceGroup(this AzureMysqlServerGeorestoreSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetResourceGroup(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetSubscription(this AzureMysqlServerGeorestoreSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetSubscription(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetDebug(this AzureMysqlServerGeorestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetDebug(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetHelp(this AzureMysqlServerGeorestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetHelp(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetOutput(this AzureMysqlServerGeorestoreSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetOutput(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetQuery(this AzureMysqlServerGeorestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetQuery(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetVerbose(this AzureMysqlServerGeorestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetVerbose(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings SetResourceGroup(this AzureMysqlServerListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings ResetResourceGroup(this AzureMysqlServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings SetSubscription(this AzureMysqlServerListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings ResetSubscription(this AzureMysqlServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings SetDebug(this AzureMysqlServerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings ResetDebug(this AzureMysqlServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings SetHelp(this AzureMysqlServerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings ResetHelp(this AzureMysqlServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings SetOutput(this AzureMysqlServerListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings ResetOutput(this AzureMysqlServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings SetQuery(this AzureMysqlServerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings ResetQuery(this AzureMysqlServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings SetVerbose(this AzureMysqlServerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerListSettings ResetVerbose(this AzureMysqlServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerRestartSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerRestartSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestartSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings SetIds(this AzureMysqlServerRestartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestartSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings SetIds(this AzureMysqlServerRestartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings AddIds(this AzureMysqlServerRestartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings AddIds(this AzureMysqlServerRestartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings ClearIds(this AzureMysqlServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings RemoveIds(this AzureMysqlServerRestartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings RemoveIds(this AzureMysqlServerRestartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestartSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings SetName(this AzureMysqlServerRestartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestartSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings ResetName(this AzureMysqlServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings SetResourceGroup(this AzureMysqlServerRestartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings ResetResourceGroup(this AzureMysqlServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings SetSubscription(this AzureMysqlServerRestartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings ResetSubscription(this AzureMysqlServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings SetDebug(this AzureMysqlServerRestartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings ResetDebug(this AzureMysqlServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings SetHelp(this AzureMysqlServerRestartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings ResetHelp(this AzureMysqlServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings SetOutput(this AzureMysqlServerRestartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings ResetOutput(this AzureMysqlServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings SetQuery(this AzureMysqlServerRestartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings ResetQuery(this AzureMysqlServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings SetVerbose(this AzureMysqlServerRestartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestartSettings ResetVerbose(this AzureMysqlServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerRestoreSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerRestoreSettingsExtensions
    {
        #region RestorePointInTime
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestoreSettings.RestorePointInTime"/></em></p>
        ///   <p>The point in time to restore from (ISO8601 format), e.g., 2017-04-26T02:10:00+08:00.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetRestorePointInTime(this AzureMysqlServerRestoreSettings toolSettings, string restorePointInTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestorePointInTime = restorePointInTime;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestoreSettings.RestorePointInTime"/></em></p>
        ///   <p>The point in time to restore from (ISO8601 format), e.g., 2017-04-26T02:10:00+08:00.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetRestorePointInTime(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestorePointInTime = null;
            return toolSettings;
        }
        #endregion
        #region SourceServer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestoreSettings.SourceServer"/></em></p>
        ///   <p>The name or resource ID of the source server to restore from.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetSourceServer(this AzureMysqlServerRestoreSettings toolSettings, string sourceServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = sourceServer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestoreSettings.SourceServer"/></em></p>
        ///   <p>The name or resource ID of the source server to restore from.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetSourceServer(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetNoWait(this AzureMysqlServerRestoreSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetNoWait(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureMysqlServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings EnableNoWait(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureMysqlServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings DisableNoWait(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureMysqlServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ToggleNoWait(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetIds(this AzureMysqlServerRestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetIds(this AzureMysqlServerRestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings AddIds(this AzureMysqlServerRestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings AddIds(this AzureMysqlServerRestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ClearIds(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings RemoveIds(this AzureMysqlServerRestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings RemoveIds(this AzureMysqlServerRestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetName(this AzureMysqlServerRestoreSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestoreSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetName(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestoreSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetResourceGroup(this AzureMysqlServerRestoreSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestoreSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetResourceGroup(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetSubscription(this AzureMysqlServerRestoreSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetSubscription(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetDebug(this AzureMysqlServerRestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetDebug(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetHelp(this AzureMysqlServerRestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetHelp(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetOutput(this AzureMysqlServerRestoreSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetOutput(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetQuery(this AzureMysqlServerRestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetQuery(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetVerbose(this AzureMysqlServerRestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerRestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetVerbose(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetIds(this AzureMysqlServerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetIds(this AzureMysqlServerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings AddIds(this AzureMysqlServerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings AddIds(this AzureMysqlServerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings ClearIds(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings RemoveIds(this AzureMysqlServerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings RemoveIds(this AzureMysqlServerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerShowSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetName(this AzureMysqlServerShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerShowSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetName(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetResourceGroup(this AzureMysqlServerShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetResourceGroup(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetSubscription(this AzureMysqlServerShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetSubscription(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetDebug(this AzureMysqlServerShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetDebug(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetHelp(this AzureMysqlServerShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetHelp(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetOutput(this AzureMysqlServerShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetOutput(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetQuery(this AzureMysqlServerShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetQuery(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetVerbose(this AzureMysqlServerShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetVerbose(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerUpdateSettingsExtensions
    {
        #region AdminPassword
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.AdminPassword"/></em></p>
        ///   <p>The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetAdminPassword(this AzureMysqlServerUpdateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.AdminPassword"/></em></p>
        ///   <p>The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetAdminPassword(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region AutoGrow
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.AutoGrow"/></em></p>
        ///   <p>Enable or disable autogrow of the storage. Default value is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetAutoGrow(this AzureMysqlServerUpdateSettings toolSettings, MysqlServerAutoGrow autoGrow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoGrow = autoGrow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.AutoGrow"/></em></p>
        ///   <p>Enable or disable autogrow of the storage. Default value is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetAutoGrow(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoGrow = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetBackupRetention(this AzureMysqlServerUpdateSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetBackupRetention(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetSkuName(this AzureMysqlServerUpdateSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetSkuName(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region SslEnforcement
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.SslEnforcement"/></em></p>
        ///   <p>Enable or disable ssl enforcement for connections to server. Default is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetSslEnforcement(this AzureMysqlServerUpdateSettings toolSettings, MysqlServerAutoGrow sslEnforcement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = sslEnforcement;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.SslEnforcement"/></em></p>
        ///   <p>Enable or disable ssl enforcement for connections to server. Default is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetSslEnforcement(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = null;
            return toolSettings;
        }
        #endregion
        #region StorageSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.StorageSize"/></em></p>
        ///   <p>The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetStorageSize(this AzureMysqlServerUpdateSettings toolSettings, string storageSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = storageSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.StorageSize"/></em></p>
        ///   <p>The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetStorageSize(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetTags(this AzureMysqlServerUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetTags(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetIds(this AzureMysqlServerUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetIds(this AzureMysqlServerUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings AddIds(this AzureMysqlServerUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings AddIds(this AzureMysqlServerUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ClearIds(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings RemoveIds(this AzureMysqlServerUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings RemoveIds(this AzureMysqlServerUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetName(this AzureMysqlServerUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetName(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetResourceGroup(this AzureMysqlServerUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetResourceGroup(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetSubscription(this AzureMysqlServerUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetSubscription(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetAdd(this AzureMysqlServerUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetAdd(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetForceString(this AzureMysqlServerUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetForceString(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetRemove(this AzureMysqlServerUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetRemove(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetSet(this AzureMysqlServerUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetSet(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetDebug(this AzureMysqlServerUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetDebug(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetHelp(this AzureMysqlServerUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetHelp(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetOutput(this AzureMysqlServerUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetOutput(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetQuery(this AzureMysqlServerUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetQuery(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetVerbose(this AzureMysqlServerUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetVerbose(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerWaitSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetIds(this AzureMysqlServerWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetIds(this AzureMysqlServerWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings AddIds(this AzureMysqlServerWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings AddIds(this AzureMysqlServerWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ClearIds(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings RemoveIds(this AzureMysqlServerWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings RemoveIds(this AzureMysqlServerWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetName(this AzureMysqlServerWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerWaitSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetName(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetResourceGroup(this AzureMysqlServerWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetResourceGroup(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetSubscription(this AzureMysqlServerWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetSubscription(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetCustom(this AzureMysqlServerWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetCustom(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetExists(this AzureMysqlServerWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetExists(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetInterval(this AzureMysqlServerWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetInterval(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetTimeout(this AzureMysqlServerWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetTimeout(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetDebug(this AzureMysqlServerWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetDebug(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetHelp(this AzureMysqlServerWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetHelp(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetOutput(this AzureMysqlServerWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetOutput(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetQuery(this AzureMysqlServerWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetQuery(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetVerbose(this AzureMysqlServerWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetVerbose(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerVnetRuleCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerVnetRuleCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleCreateSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings SetName(this AzureMysqlServerVnetRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleCreateSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings ResetName(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings SetResourceGroup(this AzureMysqlServerVnetRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings ResetResourceGroup(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings SetServerName(this AzureMysqlServerVnetRuleCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings ResetServerName(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleCreateSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings SetSubnet(this AzureMysqlServerVnetRuleCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleCreateSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings ResetSubnet(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region IgnoreMissingEndpoint
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings SetIgnoreMissingEndpoint(this AzureMysqlServerVnetRuleCreateSettings toolSettings, bool? ignoreMissingEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = ignoreMissingEndpoint;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings ResetIgnoreMissingEndpoint(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureMysqlServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings EnableIgnoreMissingEndpoint(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureMysqlServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings DisableIgnoreMissingEndpoint(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureMysqlServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings ToggleIgnoreMissingEndpoint(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = !toolSettings.IgnoreMissingEndpoint;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleCreateSettings.VnetName"/></em></p>
        ///   <p>The virtual network name.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings SetVnetName(this AzureMysqlServerVnetRuleCreateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleCreateSettings.VnetName"/></em></p>
        ///   <p>The virtual network name.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings ResetVnetName(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings SetSubscription(this AzureMysqlServerVnetRuleCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings ResetSubscription(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings SetDebug(this AzureMysqlServerVnetRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings ResetDebug(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings SetHelp(this AzureMysqlServerVnetRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings ResetHelp(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings SetOutput(this AzureMysqlServerVnetRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings ResetOutput(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings SetQuery(this AzureMysqlServerVnetRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings ResetQuery(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings SetVerbose(this AzureMysqlServerVnetRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleCreateSettings ResetVerbose(this AzureMysqlServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerVnetRuleDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerVnetRuleDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings SetIds(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings SetIds(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings AddIds(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings AddIds(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings ClearIds(this AzureMysqlServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings RemoveIds(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings RemoveIds(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings SetName(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings ResetName(this AzureMysqlServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings SetResourceGroup(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings ResetResourceGroup(this AzureMysqlServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings SetServerName(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings ResetServerName(this AzureMysqlServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings SetSubscription(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings ResetSubscription(this AzureMysqlServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings SetDebug(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings ResetDebug(this AzureMysqlServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings SetHelp(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings ResetHelp(this AzureMysqlServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings SetOutput(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings ResetOutput(this AzureMysqlServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings SetQuery(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings ResetQuery(this AzureMysqlServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings SetVerbose(this AzureMysqlServerVnetRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleDeleteSettings ResetVerbose(this AzureMysqlServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerVnetRuleListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerVnetRuleListSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings SetIds(this AzureMysqlServerVnetRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings SetIds(this AzureMysqlServerVnetRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings AddIds(this AzureMysqlServerVnetRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings AddIds(this AzureMysqlServerVnetRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings ClearIds(this AzureMysqlServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings RemoveIds(this AzureMysqlServerVnetRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings RemoveIds(this AzureMysqlServerVnetRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings SetResourceGroup(this AzureMysqlServerVnetRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings ResetResourceGroup(this AzureMysqlServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings SetServerName(this AzureMysqlServerVnetRuleListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings ResetServerName(this AzureMysqlServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings SetSubscription(this AzureMysqlServerVnetRuleListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings ResetSubscription(this AzureMysqlServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings SetDebug(this AzureMysqlServerVnetRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings ResetDebug(this AzureMysqlServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings SetHelp(this AzureMysqlServerVnetRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings ResetHelp(this AzureMysqlServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings SetOutput(this AzureMysqlServerVnetRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings ResetOutput(this AzureMysqlServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings SetQuery(this AzureMysqlServerVnetRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings ResetQuery(this AzureMysqlServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings SetVerbose(this AzureMysqlServerVnetRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleListSettings ResetVerbose(this AzureMysqlServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerVnetRuleShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerVnetRuleShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings SetIds(this AzureMysqlServerVnetRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings SetIds(this AzureMysqlServerVnetRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings AddIds(this AzureMysqlServerVnetRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings AddIds(this AzureMysqlServerVnetRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings ClearIds(this AzureMysqlServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings RemoveIds(this AzureMysqlServerVnetRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings RemoveIds(this AzureMysqlServerVnetRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleShowSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings SetName(this AzureMysqlServerVnetRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleShowSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings ResetName(this AzureMysqlServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings SetResourceGroup(this AzureMysqlServerVnetRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings ResetResourceGroup(this AzureMysqlServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings SetServerName(this AzureMysqlServerVnetRuleShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings ResetServerName(this AzureMysqlServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings SetSubscription(this AzureMysqlServerVnetRuleShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings ResetSubscription(this AzureMysqlServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings SetDebug(this AzureMysqlServerVnetRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings ResetDebug(this AzureMysqlServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings SetHelp(this AzureMysqlServerVnetRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings ResetHelp(this AzureMysqlServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings SetOutput(this AzureMysqlServerVnetRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings ResetOutput(this AzureMysqlServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings SetQuery(this AzureMysqlServerVnetRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings ResetQuery(this AzureMysqlServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings SetVerbose(this AzureMysqlServerVnetRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleShowSettings ResetVerbose(this AzureMysqlServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerVnetRuleUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerVnetRuleUpdateSettingsExtensions
    {
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetSubnet(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetSubnet(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region IgnoreMissingEndpoint
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetIgnoreMissingEndpoint(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, bool? ignoreMissingEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = ignoreMissingEndpoint;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetIgnoreMissingEndpoint(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureMysqlServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings EnableIgnoreMissingEndpoint(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureMysqlServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings DisableIgnoreMissingEndpoint(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureMysqlServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ToggleIgnoreMissingEndpoint(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = !toolSettings.IgnoreMissingEndpoint;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.VnetName"/></em></p>
        ///   <p>The virtual network name.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetVnetName(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.VnetName"/></em></p>
        ///   <p>The virtual network name.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetVnetName(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetIds(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetIds(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings AddIds(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings AddIds(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ClearIds(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings RemoveIds(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings RemoveIds(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetName(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetName(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetResourceGroup(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetResourceGroup(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetServerName(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetServerName(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetSubscription(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetSubscription(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetAdd(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetAdd(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetForceString(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetForceString(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetRemove(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetRemove(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetSet(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetSet(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetDebug(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetDebug(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetHelp(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetHelp(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetOutput(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetOutput(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetQuery(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetQuery(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings SetVerbose(this AzureMysqlServerVnetRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerVnetRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerVnetRuleUpdateSettings ResetVerbose(this AzureMysqlServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerReplicaCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerReplicaCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaCreateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings SetName(this AzureMysqlServerReplicaCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaCreateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings ResetName(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings SetResourceGroup(this AzureMysqlServerReplicaCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings ResetResourceGroup(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SourceServer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaCreateSettings.SourceServer"/></em></p>
        ///   <p>The name or resource ID of the master server to the create replica for.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings SetSourceServer(this AzureMysqlServerReplicaCreateSettings toolSettings, string sourceServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = sourceServer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaCreateSettings.SourceServer"/></em></p>
        ///   <p>The name or resource ID of the master server to the create replica for.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings ResetSourceServer(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. If not provided, the create replica will be in the same location as the master server.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings SetLocation(this AzureMysqlServerReplicaCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. If not provided, the create replica will be in the same location as the master server.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings ResetLocation(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings SetNoWait(this AzureMysqlServerReplicaCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings ResetNoWait(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureMysqlServerReplicaCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings EnableNoWait(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureMysqlServerReplicaCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings DisableNoWait(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureMysqlServerReplicaCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings ToggleNoWait(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaCreateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings SetSkuName(this AzureMysqlServerReplicaCreateSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaCreateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings ResetSkuName(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings SetSubscription(this AzureMysqlServerReplicaCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings ResetSubscription(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings SetDebug(this AzureMysqlServerReplicaCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings ResetDebug(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings SetHelp(this AzureMysqlServerReplicaCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings ResetHelp(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings SetOutput(this AzureMysqlServerReplicaCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings ResetOutput(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings SetQuery(this AzureMysqlServerReplicaCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings ResetQuery(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings SetVerbose(this AzureMysqlServerReplicaCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaCreateSettings ResetVerbose(this AzureMysqlServerReplicaCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerReplicaListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerReplicaListSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings SetIds(this AzureMysqlServerReplicaListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings SetIds(this AzureMysqlServerReplicaListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerReplicaListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings AddIds(this AzureMysqlServerReplicaListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerReplicaListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings AddIds(this AzureMysqlServerReplicaListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerReplicaListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings ClearIds(this AzureMysqlServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerReplicaListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings RemoveIds(this AzureMysqlServerReplicaListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerReplicaListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings RemoveIds(this AzureMysqlServerReplicaListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings SetResourceGroup(this AzureMysqlServerReplicaListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings ResetResourceGroup(this AzureMysqlServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaListSettings.ServerName"/></em></p>
        ///   <p>Name of the master server.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings SetServerName(this AzureMysqlServerReplicaListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaListSettings.ServerName"/></em></p>
        ///   <p>Name of the master server.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings ResetServerName(this AzureMysqlServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings SetSubscription(this AzureMysqlServerReplicaListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings ResetSubscription(this AzureMysqlServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings SetDebug(this AzureMysqlServerReplicaListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings ResetDebug(this AzureMysqlServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings SetHelp(this AzureMysqlServerReplicaListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings ResetHelp(this AzureMysqlServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings SetOutput(this AzureMysqlServerReplicaListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings ResetOutput(this AzureMysqlServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings SetQuery(this AzureMysqlServerReplicaListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings ResetQuery(this AzureMysqlServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings SetVerbose(this AzureMysqlServerReplicaListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaListSettings ResetVerbose(this AzureMysqlServerReplicaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerReplicaStopSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerReplicaStopSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaStopSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings SetYes(this AzureMysqlServerReplicaStopSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaStopSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings ResetYes(this AzureMysqlServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaStopSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings SetIds(this AzureMysqlServerReplicaStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaStopSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings SetIds(this AzureMysqlServerReplicaStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerReplicaStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings AddIds(this AzureMysqlServerReplicaStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerReplicaStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings AddIds(this AzureMysqlServerReplicaStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerReplicaStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings ClearIds(this AzureMysqlServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerReplicaStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings RemoveIds(this AzureMysqlServerReplicaStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerReplicaStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings RemoveIds(this AzureMysqlServerReplicaStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaStopSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings SetName(this AzureMysqlServerReplicaStopSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaStopSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings ResetName(this AzureMysqlServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings SetResourceGroup(this AzureMysqlServerReplicaStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings ResetResourceGroup(this AzureMysqlServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings SetSubscription(this AzureMysqlServerReplicaStopSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings ResetSubscription(this AzureMysqlServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings SetDebug(this AzureMysqlServerReplicaStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings ResetDebug(this AzureMysqlServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings SetHelp(this AzureMysqlServerReplicaStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings ResetHelp(this AzureMysqlServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings SetOutput(this AzureMysqlServerReplicaStopSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings ResetOutput(this AzureMysqlServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings SetQuery(this AzureMysqlServerReplicaStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings ResetQuery(this AzureMysqlServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerReplicaStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings SetVerbose(this AzureMysqlServerReplicaStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerReplicaStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerReplicaStopSettings ResetVerbose(this AzureMysqlServerReplicaStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerConfigurationListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerConfigurationListSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetIds(this AzureMysqlServerConfigurationListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetIds(this AzureMysqlServerConfigurationListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings AddIds(this AzureMysqlServerConfigurationListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings AddIds(this AzureMysqlServerConfigurationListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ClearIds(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings RemoveIds(this AzureMysqlServerConfigurationListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings RemoveIds(this AzureMysqlServerConfigurationListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetResourceGroup(this AzureMysqlServerConfigurationListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetResourceGroup(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetServerName(this AzureMysqlServerConfigurationListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetServerName(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetSubscription(this AzureMysqlServerConfigurationListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetSubscription(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetDebug(this AzureMysqlServerConfigurationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetDebug(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetHelp(this AzureMysqlServerConfigurationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetHelp(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetOutput(this AzureMysqlServerConfigurationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetOutput(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetQuery(this AzureMysqlServerConfigurationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetQuery(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetVerbose(this AzureMysqlServerConfigurationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetVerbose(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerConfigurationSetSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerConfigurationSetSettingsExtensions
    {
        #region Value
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Value"/></em></p>
        ///   <p>Value of the configuration. If not provided, configuration value will be set to default.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetValue(this AzureMysqlServerConfigurationSetSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Value"/></em></p>
        ///   <p>Value of the configuration. If not provided, configuration value will be set to default.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetValue(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetIds(this AzureMysqlServerConfigurationSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetIds(this AzureMysqlServerConfigurationSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings AddIds(this AzureMysqlServerConfigurationSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings AddIds(this AzureMysqlServerConfigurationSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ClearIds(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings RemoveIds(this AzureMysqlServerConfigurationSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings RemoveIds(this AzureMysqlServerConfigurationSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Name"/></em></p>
        ///   <p>The name of the server configuration.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetName(this AzureMysqlServerConfigurationSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Name"/></em></p>
        ///   <p>The name of the server configuration.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetName(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetResourceGroup(this AzureMysqlServerConfigurationSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetResourceGroup(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetServerName(this AzureMysqlServerConfigurationSetSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetServerName(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetSubscription(this AzureMysqlServerConfigurationSetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetSubscription(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetDebug(this AzureMysqlServerConfigurationSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetDebug(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetHelp(this AzureMysqlServerConfigurationSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetHelp(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetOutput(this AzureMysqlServerConfigurationSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetOutput(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetQuery(this AzureMysqlServerConfigurationSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetQuery(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetVerbose(this AzureMysqlServerConfigurationSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetVerbose(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerConfigurationShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerConfigurationShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetIds(this AzureMysqlServerConfigurationShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetIds(this AzureMysqlServerConfigurationShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings AddIds(this AzureMysqlServerConfigurationShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings AddIds(this AzureMysqlServerConfigurationShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ClearIds(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings RemoveIds(this AzureMysqlServerConfigurationShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings RemoveIds(this AzureMysqlServerConfigurationShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Name"/></em></p>
        ///   <p>The name of the server configuration.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetName(this AzureMysqlServerConfigurationShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.Name"/></em></p>
        ///   <p>The name of the server configuration.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetName(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetResourceGroup(this AzureMysqlServerConfigurationShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetResourceGroup(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetServerName(this AzureMysqlServerConfigurationShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetServerName(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetSubscription(this AzureMysqlServerConfigurationShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetSubscription(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetDebug(this AzureMysqlServerConfigurationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetDebug(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetHelp(this AzureMysqlServerConfigurationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetHelp(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetOutput(this AzureMysqlServerConfigurationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetOutput(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetQuery(this AzureMysqlServerConfigurationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetQuery(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetVerbose(this AzureMysqlServerConfigurationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetVerbose(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerFirewallRuleCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerFirewallRuleCreateSettingsExtensions
    {
        #region EndIpAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.EndIpAddress"/></em></p>
        ///   <p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetEndIpAddress(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.EndIpAddress"/></em></p>
        ///   <p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetEndIpAddress(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetName(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetName(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetResourceGroup(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetResourceGroup(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetServerName(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetServerName(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.StartIpAddress"/></em></p>
        ///   <p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetStartIpAddress(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.StartIpAddress"/></em></p>
        ///   <p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetStartIpAddress(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetSubscription(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetSubscription(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetDebug(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetDebug(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetHelp(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetHelp(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetOutput(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetOutput(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetQuery(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetQuery(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetVerbose(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetVerbose(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerFirewallRuleDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerFirewallRuleDeleteSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetYes(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetYes(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetIds(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetIds(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings AddIds(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings AddIds(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ClearIds(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings RemoveIds(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings RemoveIds(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetName(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetName(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetResourceGroup(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetResourceGroup(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetServerName(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetServerName(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetSubscription(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetSubscription(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetDebug(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetDebug(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetHelp(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetHelp(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetOutput(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetOutput(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetQuery(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetQuery(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetVerbose(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetVerbose(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerFirewallRuleListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerFirewallRuleListSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetIds(this AzureMysqlServerFirewallRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetIds(this AzureMysqlServerFirewallRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings AddIds(this AzureMysqlServerFirewallRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings AddIds(this AzureMysqlServerFirewallRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ClearIds(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings RemoveIds(this AzureMysqlServerFirewallRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings RemoveIds(this AzureMysqlServerFirewallRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetResourceGroup(this AzureMysqlServerFirewallRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetResourceGroup(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetServerName(this AzureMysqlServerFirewallRuleListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetServerName(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetSubscription(this AzureMysqlServerFirewallRuleListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetSubscription(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetDebug(this AzureMysqlServerFirewallRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetDebug(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetHelp(this AzureMysqlServerFirewallRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetHelp(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetOutput(this AzureMysqlServerFirewallRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetOutput(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetQuery(this AzureMysqlServerFirewallRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetQuery(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetVerbose(this AzureMysqlServerFirewallRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetVerbose(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerFirewallRuleShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerFirewallRuleShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetIds(this AzureMysqlServerFirewallRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetIds(this AzureMysqlServerFirewallRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings AddIds(this AzureMysqlServerFirewallRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings AddIds(this AzureMysqlServerFirewallRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ClearIds(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings RemoveIds(this AzureMysqlServerFirewallRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings RemoveIds(this AzureMysqlServerFirewallRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetName(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetName(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetResourceGroup(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetResourceGroup(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetServerName(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetServerName(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetSubscription(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetSubscription(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetDebug(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetDebug(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetHelp(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetHelp(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetOutput(this AzureMysqlServerFirewallRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetOutput(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetQuery(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetQuery(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetVerbose(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetVerbose(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerFirewallRuleUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerFirewallRuleUpdateSettingsExtensions
    {
        #region EndIpAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.EndIpAddress"/></em></p>
        ///   <p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetEndIpAddress(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.EndIpAddress"/></em></p>
        ///   <p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetEndIpAddress(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.StartIpAddress"/></em></p>
        ///   <p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetStartIpAddress(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.StartIpAddress"/></em></p>
        ///   <p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetStartIpAddress(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetIds(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetIds(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings AddIds(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings AddIds(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ClearIds(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings RemoveIds(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings RemoveIds(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetName(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetName(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetResourceGroup(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetResourceGroup(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetServerName(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetServerName(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetSubscription(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetSubscription(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetAdd(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetAdd(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetForceString(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetForceString(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetRemove(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetRemove(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetSet(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetSet(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetDebug(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetDebug(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetHelp(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetHelp(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetOutput(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetOutput(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetQuery(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetQuery(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetVerbose(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetVerbose(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region MysqlServerAutoGrow
    /// <summary>
    ///   Used within <see cref="AzureMysqlTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<MysqlServerAutoGrow>))]
    public partial class MysqlServerAutoGrow : Enumeration
    {
        public static MysqlServerAutoGrow disabled = new MysqlServerAutoGrow { Value = "disabled" };
        public static MysqlServerAutoGrow enabled = new MysqlServerAutoGrow { Value = "enabled" };
    }
    #endregion
}
