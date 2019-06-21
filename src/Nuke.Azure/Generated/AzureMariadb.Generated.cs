// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureMariadb.json
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
    public static partial class AzureMariadbTasks
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public static string AzureMariadbPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREMARIADB_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureMariadbLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Database for MariaDB servers.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadb(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureMariadbPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureMariadbLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadb(AzureMariadbSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadb(Configure<AzureMariadbSettings> configurator)
        {
            return AzureMariadb(configurator(new AzureMariadbSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadb(CombinatorialConfigure<AzureMariadbSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadb, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbDbCreate(AzureMariadbDbCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbDbCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--charset</c> via <see cref="AzureMariadbDbCreateSettings.Charset"/></li>
        ///     <li><c>--collation</c> via <see cref="AzureMariadbDbCreateSettings.Collation"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbDbCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbDbCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbDbCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbDbCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbDbCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbDbCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbDbCreateSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbDbCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbDbCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbDbCreate(Configure<AzureMariadbDbCreateSettings> configurator)
        {
            return AzureMariadbDbCreate(configurator(new AzureMariadbDbCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--charset</c> via <see cref="AzureMariadbDbCreateSettings.Charset"/></li>
        ///     <li><c>--collation</c> via <see cref="AzureMariadbDbCreateSettings.Collation"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbDbCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbDbCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbDbCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbDbCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbDbCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbDbCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbDbCreateSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbDbCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbDbCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbDbCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbDbCreate(CombinatorialConfigure<AzureMariadbDbCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbDbCreate, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbDbDelete(AzureMariadbDbDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbDbDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbDbDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbDbDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbDbDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbDbDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbDbDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbDbDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbDbDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbDbDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbDbDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMariadbDbDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbDbDelete(Configure<AzureMariadbDbDeleteSettings> configurator)
        {
            return AzureMariadbDbDelete(configurator(new AzureMariadbDbDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbDbDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbDbDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbDbDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbDbDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbDbDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbDbDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbDbDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbDbDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbDbDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMariadbDbDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbDbDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbDbDelete(CombinatorialConfigure<AzureMariadbDbDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbDbDelete, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbDbList(AzureMariadbDbListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbDbListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbDbListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbDbListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbDbListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbDbListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbDbListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbDbListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbDbListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbDbListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbDbList(Configure<AzureMariadbDbListSettings> configurator)
        {
            return AzureMariadbDbList(configurator(new AzureMariadbDbListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbDbListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbDbListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbDbListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbDbListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbDbListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbDbListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbDbListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbDbListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbDbListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbDbList(CombinatorialConfigure<AzureMariadbDbListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbDbList, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbDbShow(AzureMariadbDbShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbDbShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbDbShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbDbShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbDbShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbDbShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbDbShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbDbShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbDbShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbDbShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbDbShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbDbShow(Configure<AzureMariadbDbShowSettings> configurator)
        {
            return AzureMariadbDbShow(configurator(new AzureMariadbDbShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbDbShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbDbShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbDbShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbDbShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbDbShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbDbShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbDbShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbDbShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbDbShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbDbShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbDbShow(CombinatorialConfigure<AzureMariadbDbShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbDbShow, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerLogsDownload(AzureMariadbServerLogsDownloadSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerLogsDownloadSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerLogsDownloadSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerLogsDownloadSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerLogsDownload(Configure<AzureMariadbServerLogsDownloadSettings> configurator)
        {
            return AzureMariadbServerLogsDownload(configurator(new AzureMariadbServerLogsDownloadSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerLogsDownloadSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerLogsDownloadSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerLogsDownloadSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerLogsDownloadSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerLogsDownload(CombinatorialConfigure<AzureMariadbServerLogsDownloadSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerLogsDownload, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerLogsList(AzureMariadbServerLogsListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerLogsListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerLogsListSettings.Debug"/></li>
        ///     <li><c>--file-last-written</c> via <see cref="AzureMariadbServerLogsListSettings.FileLastWritten"/></li>
        ///     <li><c>--filename-contains</c> via <see cref="AzureMariadbServerLogsListSettings.FilenameContains"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerLogsListSettings.Help"/></li>
        ///     <li><c>--max-file-size</c> via <see cref="AzureMariadbServerLogsListSettings.MaxFileSize"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerLogsListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerLogsListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerLogsListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerLogsListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerLogsListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerLogsListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerLogsList(Configure<AzureMariadbServerLogsListSettings> configurator)
        {
            return AzureMariadbServerLogsList(configurator(new AzureMariadbServerLogsListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerLogsListSettings.Debug"/></li>
        ///     <li><c>--file-last-written</c> via <see cref="AzureMariadbServerLogsListSettings.FileLastWritten"/></li>
        ///     <li><c>--filename-contains</c> via <see cref="AzureMariadbServerLogsListSettings.FilenameContains"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerLogsListSettings.Help"/></li>
        ///     <li><c>--max-file-size</c> via <see cref="AzureMariadbServerLogsListSettings.MaxFileSize"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerLogsListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerLogsListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerLogsListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerLogsListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerLogsListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerLogsListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerLogsListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerLogsList(CombinatorialConfigure<AzureMariadbServerLogsListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerLogsList, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerCreate(AzureMariadbServerCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--admin-password</c> via <see cref="AzureMariadbServerCreateSettings.AdminPassword"/></li>
        ///     <li><c>--admin-user</c> via <see cref="AzureMariadbServerCreateSettings.AdminUser"/></li>
        ///     <li><c>--backup-retention</c> via <see cref="AzureMariadbServerCreateSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerCreateSettings.Debug"/></li>
        ///     <li><c>--geo-redundant-backup</c> via <see cref="AzureMariadbServerCreateSettings.GeoRedundantBackup"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureMariadbServerCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMariadbServerCreateSettings.SkuName"/></li>
        ///     <li><c>--ssl-enforcement</c> via <see cref="AzureMariadbServerCreateSettings.SslEnforcement"/></li>
        ///     <li><c>--storage-size</c> via <see cref="AzureMariadbServerCreateSettings.StorageSize"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureMariadbServerCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerCreateSettings.Verbose"/></li>
        ///     <li><c>--version</c> via <see cref="AzureMariadbServerCreateSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerCreate(Configure<AzureMariadbServerCreateSettings> configurator)
        {
            return AzureMariadbServerCreate(configurator(new AzureMariadbServerCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--admin-password</c> via <see cref="AzureMariadbServerCreateSettings.AdminPassword"/></li>
        ///     <li><c>--admin-user</c> via <see cref="AzureMariadbServerCreateSettings.AdminUser"/></li>
        ///     <li><c>--backup-retention</c> via <see cref="AzureMariadbServerCreateSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerCreateSettings.Debug"/></li>
        ///     <li><c>--geo-redundant-backup</c> via <see cref="AzureMariadbServerCreateSettings.GeoRedundantBackup"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureMariadbServerCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMariadbServerCreateSettings.SkuName"/></li>
        ///     <li><c>--ssl-enforcement</c> via <see cref="AzureMariadbServerCreateSettings.SslEnforcement"/></li>
        ///     <li><c>--storage-size</c> via <see cref="AzureMariadbServerCreateSettings.StorageSize"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureMariadbServerCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerCreateSettings.Verbose"/></li>
        ///     <li><c>--version</c> via <see cref="AzureMariadbServerCreateSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerCreate(CombinatorialConfigure<AzureMariadbServerCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerCreate, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerDelete(AzureMariadbServerDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMariadbServerDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerDelete(Configure<AzureMariadbServerDeleteSettings> configurator)
        {
            return AzureMariadbServerDelete(configurator(new AzureMariadbServerDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMariadbServerDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerDelete(CombinatorialConfigure<AzureMariadbServerDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerDelete, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerGeorestore(AzureMariadbServerGeorestoreSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerGeorestoreSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--backup-retention</c> via <see cref="AzureMariadbServerGeorestoreSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerGeorestoreSettings.Debug"/></li>
        ///     <li><c>--geo-redundant-backup</c> via <see cref="AzureMariadbServerGeorestoreSettings.GeoRedundantBackup"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerGeorestoreSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerGeorestoreSettings.Ids"/></li>
        ///     <li><c>--location</c> via <see cref="AzureMariadbServerGeorestoreSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerGeorestoreSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureMariadbServerGeorestoreSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerGeorestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerGeorestoreSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerGeorestoreSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMariadbServerGeorestoreSettings.SkuName"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzureMariadbServerGeorestoreSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerGeorestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerGeorestoreSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerGeorestore(Configure<AzureMariadbServerGeorestoreSettings> configurator)
        {
            return AzureMariadbServerGeorestore(configurator(new AzureMariadbServerGeorestoreSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--backup-retention</c> via <see cref="AzureMariadbServerGeorestoreSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerGeorestoreSettings.Debug"/></li>
        ///     <li><c>--geo-redundant-backup</c> via <see cref="AzureMariadbServerGeorestoreSettings.GeoRedundantBackup"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerGeorestoreSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerGeorestoreSettings.Ids"/></li>
        ///     <li><c>--location</c> via <see cref="AzureMariadbServerGeorestoreSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerGeorestoreSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureMariadbServerGeorestoreSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerGeorestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerGeorestoreSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerGeorestoreSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMariadbServerGeorestoreSettings.SkuName"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzureMariadbServerGeorestoreSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerGeorestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerGeorestoreSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerGeorestoreSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerGeorestore(CombinatorialConfigure<AzureMariadbServerGeorestoreSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerGeorestore, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerList(AzureMariadbServerListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerList(Configure<AzureMariadbServerListSettings> configurator)
        {
            return AzureMariadbServerList(configurator(new AzureMariadbServerListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerList(CombinatorialConfigure<AzureMariadbServerListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerList, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerRestart(AzureMariadbServerRestartSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerRestartSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerRestartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerRestartSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerRestartSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerRestartSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerRestartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerRestartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerRestartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerRestartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerRestartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerRestart(Configure<AzureMariadbServerRestartSettings> configurator)
        {
            return AzureMariadbServerRestart(configurator(new AzureMariadbServerRestartSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerRestartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerRestartSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerRestartSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerRestartSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerRestartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerRestartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerRestartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerRestartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerRestartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerRestartSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerRestart(CombinatorialConfigure<AzureMariadbServerRestartSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerRestart, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerRestore(AzureMariadbServerRestoreSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerRestoreSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerRestoreSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerRestoreSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerRestoreSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerRestoreSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureMariadbServerRestoreSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerRestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerRestoreSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerRestoreSettings.ResourceGroup"/></li>
        ///     <li><c>--restore-point-in-time</c> via <see cref="AzureMariadbServerRestoreSettings.RestorePointInTime"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzureMariadbServerRestoreSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerRestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerRestoreSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerRestore(Configure<AzureMariadbServerRestoreSettings> configurator)
        {
            return AzureMariadbServerRestore(configurator(new AzureMariadbServerRestoreSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerRestoreSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerRestoreSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerRestoreSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerRestoreSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureMariadbServerRestoreSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerRestoreSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerRestoreSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerRestoreSettings.ResourceGroup"/></li>
        ///     <li><c>--restore-point-in-time</c> via <see cref="AzureMariadbServerRestoreSettings.RestorePointInTime"/></li>
        ///     <li><c>--source-server</c> via <see cref="AzureMariadbServerRestoreSettings.SourceServer"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerRestoreSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerRestoreSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerRestoreSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerRestore(CombinatorialConfigure<AzureMariadbServerRestoreSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerRestore, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerShow(AzureMariadbServerShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerShow(Configure<AzureMariadbServerShowSettings> configurator)
        {
            return AzureMariadbServerShow(configurator(new AzureMariadbServerShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerShow(CombinatorialConfigure<AzureMariadbServerShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerShow, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerUpdate(AzureMariadbServerUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMariadbServerUpdateSettings.Add"/></li>
        ///     <li><c>--admin-password</c> via <see cref="AzureMariadbServerUpdateSettings.AdminPassword"/></li>
        ///     <li><c>--backup-retention</c> via <see cref="AzureMariadbServerUpdateSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMariadbServerUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMariadbServerUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMariadbServerUpdateSettings.Set"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMariadbServerUpdateSettings.SkuName"/></li>
        ///     <li><c>--ssl-enforcement</c> via <see cref="AzureMariadbServerUpdateSettings.SslEnforcement"/></li>
        ///     <li><c>--storage-size</c> via <see cref="AzureMariadbServerUpdateSettings.StorageSize"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureMariadbServerUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerUpdate(Configure<AzureMariadbServerUpdateSettings> configurator)
        {
            return AzureMariadbServerUpdate(configurator(new AzureMariadbServerUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMariadbServerUpdateSettings.Add"/></li>
        ///     <li><c>--admin-password</c> via <see cref="AzureMariadbServerUpdateSettings.AdminPassword"/></li>
        ///     <li><c>--backup-retention</c> via <see cref="AzureMariadbServerUpdateSettings.BackupRetention"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMariadbServerUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMariadbServerUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMariadbServerUpdateSettings.Set"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureMariadbServerUpdateSettings.SkuName"/></li>
        ///     <li><c>--ssl-enforcement</c> via <see cref="AzureMariadbServerUpdateSettings.SslEnforcement"/></li>
        ///     <li><c>--storage-size</c> via <see cref="AzureMariadbServerUpdateSettings.StorageSize"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureMariadbServerUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerUpdate(CombinatorialConfigure<AzureMariadbServerUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerUpdate, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerWait(AzureMariadbServerWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--custom</c> via <see cref="AzureMariadbServerWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerWaitSettings.Debug"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureMariadbServerWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureMariadbServerWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureMariadbServerWaitSettings.Timeout"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerWait(Configure<AzureMariadbServerWaitSettings> configurator)
        {
            return AzureMariadbServerWait(configurator(new AzureMariadbServerWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--custom</c> via <see cref="AzureMariadbServerWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerWaitSettings.Debug"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureMariadbServerWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureMariadbServerWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureMariadbServerWaitSettings.Timeout"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerWait(CombinatorialConfigure<AzureMariadbServerWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerWait, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerConfigurationList(AzureMariadbServerConfigurationListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerConfigurationListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerConfigurationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerConfigurationListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerConfigurationListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerConfigurationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerConfigurationListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerConfigurationListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerConfigurationListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerConfigurationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerConfigurationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerConfigurationList(Configure<AzureMariadbServerConfigurationListSettings> configurator)
        {
            return AzureMariadbServerConfigurationList(configurator(new AzureMariadbServerConfigurationListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerConfigurationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerConfigurationListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerConfigurationListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerConfigurationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerConfigurationListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerConfigurationListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerConfigurationListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerConfigurationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerConfigurationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerConfigurationListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerConfigurationList(CombinatorialConfigure<AzureMariadbServerConfigurationListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerConfigurationList, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerConfigurationSet(AzureMariadbServerConfigurationSetSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerConfigurationSetSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerConfigurationSetSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerConfigurationSetSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Subscription"/></li>
        ///     <li><c>--value</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Value"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerConfigurationSet(Configure<AzureMariadbServerConfigurationSetSettings> configurator)
        {
            return AzureMariadbServerConfigurationSet(configurator(new AzureMariadbServerConfigurationSetSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerConfigurationSetSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerConfigurationSetSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Subscription"/></li>
        ///     <li><c>--value</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Value"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerConfigurationSetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerConfigurationSetSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerConfigurationSet(CombinatorialConfigure<AzureMariadbServerConfigurationSetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerConfigurationSet, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerConfigurationShow(AzureMariadbServerConfigurationShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerConfigurationShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerConfigurationShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerConfigurationShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerConfigurationShow(Configure<AzureMariadbServerConfigurationShowSettings> configurator)
        {
            return AzureMariadbServerConfigurationShow(configurator(new AzureMariadbServerConfigurationShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerConfigurationShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerConfigurationShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerConfigurationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerConfigurationShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerConfigurationShow(CombinatorialConfigure<AzureMariadbServerConfigurationShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerConfigurationShow, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerFirewallRuleCreate(AzureMariadbServerFirewallRuleCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerFirewallRuleCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Debug"/></li>
        ///     <li><c>--end-ip-address</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.EndIpAddress"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.ServerName"/></li>
        ///     <li><c>--start-ip-address</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.StartIpAddress"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerFirewallRuleCreate(Configure<AzureMariadbServerFirewallRuleCreateSettings> configurator)
        {
            return AzureMariadbServerFirewallRuleCreate(configurator(new AzureMariadbServerFirewallRuleCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Debug"/></li>
        ///     <li><c>--end-ip-address</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.EndIpAddress"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.ServerName"/></li>
        ///     <li><c>--start-ip-address</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.StartIpAddress"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerFirewallRuleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerFirewallRuleCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerFirewallRuleCreate(CombinatorialConfigure<AzureMariadbServerFirewallRuleCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerFirewallRuleCreate, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerFirewallRuleDelete(AzureMariadbServerFirewallRuleDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerFirewallRuleDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerFirewallRuleDelete(Configure<AzureMariadbServerFirewallRuleDeleteSettings> configurator)
        {
            return AzureMariadbServerFirewallRuleDelete(configurator(new AzureMariadbServerFirewallRuleDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerFirewallRuleDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerFirewallRuleDelete(CombinatorialConfigure<AzureMariadbServerFirewallRuleDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerFirewallRuleDelete, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerFirewallRuleList(AzureMariadbServerFirewallRuleListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerFirewallRuleListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerFirewallRuleList(Configure<AzureMariadbServerFirewallRuleListSettings> configurator)
        {
            return AzureMariadbServerFirewallRuleList(configurator(new AzureMariadbServerFirewallRuleListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerFirewallRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerFirewallRuleListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerFirewallRuleList(CombinatorialConfigure<AzureMariadbServerFirewallRuleListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerFirewallRuleList, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerFirewallRuleShow(AzureMariadbServerFirewallRuleShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerFirewallRuleShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerFirewallRuleShow(Configure<AzureMariadbServerFirewallRuleShowSettings> configurator)
        {
            return AzureMariadbServerFirewallRuleShow(configurator(new AzureMariadbServerFirewallRuleShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerFirewallRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerFirewallRuleShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerFirewallRuleShow(CombinatorialConfigure<AzureMariadbServerFirewallRuleShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerFirewallRuleShow, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerFirewallRuleUpdate(AzureMariadbServerFirewallRuleUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerFirewallRuleUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--end-ip-address</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.EndIpAddress"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.ServerName"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Set"/></li>
        ///     <li><c>--start-ip-address</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.StartIpAddress"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerFirewallRuleUpdate(Configure<AzureMariadbServerFirewallRuleUpdateSettings> configurator)
        {
            return AzureMariadbServerFirewallRuleUpdate(configurator(new AzureMariadbServerFirewallRuleUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--end-ip-address</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.EndIpAddress"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.ServerName"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Set"/></li>
        ///     <li><c>--start-ip-address</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.StartIpAddress"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerFirewallRuleUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerFirewallRuleUpdate(CombinatorialConfigure<AzureMariadbServerFirewallRuleUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerFirewallRuleUpdate, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerVnetRuleCreate(AzureMariadbServerVnetRuleCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerVnetRuleCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Help"/></li>
        ///     <li><c>--ignore-missing-endpoint</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.ServerName"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerVnetRuleCreate(Configure<AzureMariadbServerVnetRuleCreateSettings> configurator)
        {
            return AzureMariadbServerVnetRuleCreate(configurator(new AzureMariadbServerVnetRuleCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Help"/></li>
        ///     <li><c>--ignore-missing-endpoint</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.ServerName"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureMariadbServerVnetRuleCreateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerVnetRuleCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerVnetRuleCreate(CombinatorialConfigure<AzureMariadbServerVnetRuleCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerVnetRuleCreate, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerVnetRuleDelete(AzureMariadbServerVnetRuleDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerVnetRuleDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerVnetRuleDelete(Configure<AzureMariadbServerVnetRuleDeleteSettings> configurator)
        {
            return AzureMariadbServerVnetRuleDelete(configurator(new AzureMariadbServerVnetRuleDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerVnetRuleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerVnetRuleDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerVnetRuleDelete(CombinatorialConfigure<AzureMariadbServerVnetRuleDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerVnetRuleDelete, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerVnetRuleList(AzureMariadbServerVnetRuleListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerVnetRuleListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerVnetRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerVnetRuleListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerVnetRuleList(Configure<AzureMariadbServerVnetRuleListSettings> configurator)
        {
            return AzureMariadbServerVnetRuleList(configurator(new AzureMariadbServerVnetRuleListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerVnetRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerVnetRuleListSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerVnetRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerVnetRuleListSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerVnetRuleList(CombinatorialConfigure<AzureMariadbServerVnetRuleListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerVnetRuleList, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerVnetRuleShow(AzureMariadbServerVnetRuleShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerVnetRuleShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerVnetRuleShow(Configure<AzureMariadbServerVnetRuleShowSettings> configurator)
        {
            return AzureMariadbServerVnetRuleShow(configurator(new AzureMariadbServerVnetRuleShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.ServerName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerVnetRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerVnetRuleShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerVnetRuleShow(CombinatorialConfigure<AzureMariadbServerVnetRuleShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerVnetRuleShow, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureMariadbServerVnetRuleUpdate(AzureMariadbServerVnetRuleUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureMariadbServerVnetRuleUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--ignore-missing-endpoint</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.ServerName"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Set"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureMariadbServerVnetRuleUpdate(Configure<AzureMariadbServerVnetRuleUpdateSettings> configurator)
        {
            return AzureMariadbServerVnetRuleUpdate(configurator(new AzureMariadbServerVnetRuleUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Database for MariaDB servers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mariadb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--ignore-missing-endpoint</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-name</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.ServerName"/></li>
        ///     <li><c>--set</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Set"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureMariadbServerVnetRuleUpdateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureMariadbServerVnetRuleUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureMariadbServerVnetRuleUpdate(CombinatorialConfigure<AzureMariadbServerVnetRuleUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureMariadbServerVnetRuleUpdate, AzureMariadbLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureMariadbSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMariadbDbCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbDbCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb db create")
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
    #region AzureMariadbDbDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbDbDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb db delete")
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
    #region AzureMariadbDbListSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbDbListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb db list")
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
    #region AzureMariadbDbShowSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbDbShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb db show")
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
    #region AzureMariadbServerLogsDownloadSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerLogsDownloadSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server-logs download")
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
    #region AzureMariadbServerLogsListSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerLogsListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server-logs list")
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
    #region AzureMariadbServerCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
        public virtual MariadbServerCreateGeoRedundantBackup GeoRedundantBackup { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Enable or disable ssl enforcement for connections to server. Default is Enabled.
        /// </summary>
        public virtual MariadbServerCreateGeoRedundantBackup SslEnforcement { get; internal set; }
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
              .Add("mariadb server create")
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
    #region AzureMariadbServerDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server delete")
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
    #region AzureMariadbServerGeorestoreSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerGeorestoreSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server georestore")
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
    #region AzureMariadbServerListSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server list")
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
    #region AzureMariadbServerRestartSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerRestartSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server restart")
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
    #region AzureMariadbServerRestoreSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerRestoreSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server restore")
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
    #region AzureMariadbServerShowSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server show")
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
    #region AzureMariadbServerUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
        public virtual MariadbServerCreateGeoRedundantBackup SslEnforcement { get; internal set; }
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
              .Add("mariadb server update")
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
    #region AzureMariadbServerWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server wait")
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
    #region AzureMariadbServerConfigurationListSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerConfigurationListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server configuration list")
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
    #region AzureMariadbServerConfigurationSetSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerConfigurationSetSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server configuration set")
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
    #region AzureMariadbServerConfigurationShowSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerConfigurationShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server configuration show")
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
    #region AzureMariadbServerFirewallRuleCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerFirewallRuleCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server firewall-rule create")
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
    #region AzureMariadbServerFirewallRuleDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerFirewallRuleDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server firewall-rule delete")
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
    #region AzureMariadbServerFirewallRuleListSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerFirewallRuleListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server firewall-rule list")
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
    #region AzureMariadbServerFirewallRuleShowSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerFirewallRuleShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server firewall-rule show")
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
    #region AzureMariadbServerFirewallRuleUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerFirewallRuleUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server firewall-rule update")
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
    #region AzureMariadbServerVnetRuleCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerVnetRuleCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server vnet-rule create")
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
    #region AzureMariadbServerVnetRuleDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerVnetRuleDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server vnet-rule delete")
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
    #region AzureMariadbServerVnetRuleListSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerVnetRuleListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server vnet-rule list")
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
    #region AzureMariadbServerVnetRuleShowSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerVnetRuleShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server vnet-rule show")
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
    #region AzureMariadbServerVnetRuleUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMariadbServerVnetRuleUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureMariadb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureMariadbTasks.AzureMariadbPath;
        public override Action<OutputType, string> CustomLogger => AzureMariadbTasks.AzureMariadbLogger;
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
              .Add("mariadb server vnet-rule update")
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
    #region AzureMariadbSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbSettings SetDebug(this AzureMariadbSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbSettings ResetDebug(this AzureMariadbSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbSettings SetHelp(this AzureMariadbSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbSettings ResetHelp(this AzureMariadbSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbSettings SetOutput(this AzureMariadbSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbSettings ResetOutput(this AzureMariadbSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbSettings SetQuery(this AzureMariadbSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbSettings ResetQuery(this AzureMariadbSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbSettings SetVerbose(this AzureMariadbSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbSettings ResetVerbose(this AzureMariadbSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbDbCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbDbCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbCreateSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings SetName(this AzureMariadbDbCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbCreateSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings ResetName(this AzureMariadbDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings SetResourceGroup(this AzureMariadbDbCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings ResetResourceGroup(this AzureMariadbDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings SetServerName(this AzureMariadbDbCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings ResetServerName(this AzureMariadbDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Charset
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbCreateSettings.Charset"/></em></p>
        ///   <p>The charset of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings SetCharset(this AzureMariadbDbCreateSettings toolSettings, string charset)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Charset = charset;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbCreateSettings.Charset"/></em></p>
        ///   <p>The charset of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings ResetCharset(this AzureMariadbDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Charset = null;
            return toolSettings;
        }
        #endregion
        #region Collation
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbCreateSettings.Collation"/></em></p>
        ///   <p>The collation of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings SetCollation(this AzureMariadbDbCreateSettings toolSettings, string collation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Collation = collation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbCreateSettings.Collation"/></em></p>
        ///   <p>The collation of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings ResetCollation(this AzureMariadbDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Collation = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings SetSubscription(this AzureMariadbDbCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings ResetSubscription(this AzureMariadbDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings SetDebug(this AzureMariadbDbCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings ResetDebug(this AzureMariadbDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings SetHelp(this AzureMariadbDbCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings ResetHelp(this AzureMariadbDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings SetOutput(this AzureMariadbDbCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings ResetOutput(this AzureMariadbDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings SetQuery(this AzureMariadbDbCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings ResetQuery(this AzureMariadbDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings SetVerbose(this AzureMariadbDbCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbCreateSettings ResetVerbose(this AzureMariadbDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbDbDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbDbDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbDeleteSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings SetName(this AzureMariadbDbDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbDeleteSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings ResetName(this AzureMariadbDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings SetResourceGroup(this AzureMariadbDbDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings ResetResourceGroup(this AzureMariadbDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings SetServerName(this AzureMariadbDbDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings ResetServerName(this AzureMariadbDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings SetYes(this AzureMariadbDbDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings ResetYes(this AzureMariadbDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings SetSubscription(this AzureMariadbDbDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings ResetSubscription(this AzureMariadbDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings SetDebug(this AzureMariadbDbDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings ResetDebug(this AzureMariadbDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings SetHelp(this AzureMariadbDbDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings ResetHelp(this AzureMariadbDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings SetOutput(this AzureMariadbDbDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings ResetOutput(this AzureMariadbDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings SetQuery(this AzureMariadbDbDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings ResetQuery(this AzureMariadbDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings SetVerbose(this AzureMariadbDbDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbDeleteSettings ResetVerbose(this AzureMariadbDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbDbListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbDbListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings SetResourceGroup(this AzureMariadbDbListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings ResetResourceGroup(this AzureMariadbDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings SetServerName(this AzureMariadbDbListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings ResetServerName(this AzureMariadbDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings SetSubscription(this AzureMariadbDbListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings ResetSubscription(this AzureMariadbDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings SetDebug(this AzureMariadbDbListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings ResetDebug(this AzureMariadbDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings SetHelp(this AzureMariadbDbListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings ResetHelp(this AzureMariadbDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings SetOutput(this AzureMariadbDbListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings ResetOutput(this AzureMariadbDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings SetQuery(this AzureMariadbDbListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings ResetQuery(this AzureMariadbDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings SetVerbose(this AzureMariadbDbListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbListSettings ResetVerbose(this AzureMariadbDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbDbShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbDbShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbShowSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings SetName(this AzureMariadbDbShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbShowSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings ResetName(this AzureMariadbDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings SetResourceGroup(this AzureMariadbDbShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings ResetResourceGroup(this AzureMariadbDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings SetServerName(this AzureMariadbDbShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings ResetServerName(this AzureMariadbDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings SetSubscription(this AzureMariadbDbShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings ResetSubscription(this AzureMariadbDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings SetDebug(this AzureMariadbDbShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings ResetDebug(this AzureMariadbDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings SetHelp(this AzureMariadbDbShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings ResetHelp(this AzureMariadbDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings SetOutput(this AzureMariadbDbShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings ResetOutput(this AzureMariadbDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings SetQuery(this AzureMariadbDbShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings ResetQuery(this AzureMariadbDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbDbShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings SetVerbose(this AzureMariadbDbShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbDbShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbDbShowSettings ResetVerbose(this AzureMariadbDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerLogsDownloadSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerLogsDownloadSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsDownloadSettings.Name"/> to a new list</em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings SetName(this AzureMariadbServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal = name.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsDownloadSettings.Name"/> to a new list</em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings SetName(this AzureMariadbServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal = name.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings AddName(this AzureMariadbServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.AddRange(name);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings AddName(this AzureMariadbServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.AddRange(name);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings ClearName(this AzureMariadbServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings RemoveName(this AzureMariadbServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(name);
            toolSettings.NameInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerLogsDownloadSettings.Name"/></em></p>
        ///   <p>Space-separated list of log filenames on the server to download.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings RemoveName(this AzureMariadbServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(name);
            toolSettings.NameInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsDownloadSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings SetResourceGroup(this AzureMariadbServerLogsDownloadSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsDownloadSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings ResetResourceGroup(this AzureMariadbServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsDownloadSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings SetServerName(this AzureMariadbServerLogsDownloadSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsDownloadSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings ResetServerName(this AzureMariadbServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsDownloadSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings SetSubscription(this AzureMariadbServerLogsDownloadSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsDownloadSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings ResetSubscription(this AzureMariadbServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsDownloadSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings SetDebug(this AzureMariadbServerLogsDownloadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsDownloadSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings ResetDebug(this AzureMariadbServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsDownloadSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings SetHelp(this AzureMariadbServerLogsDownloadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsDownloadSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings ResetHelp(this AzureMariadbServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsDownloadSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings SetOutput(this AzureMariadbServerLogsDownloadSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsDownloadSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings ResetOutput(this AzureMariadbServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsDownloadSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings SetQuery(this AzureMariadbServerLogsDownloadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsDownloadSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings ResetQuery(this AzureMariadbServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsDownloadSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings SetVerbose(this AzureMariadbServerLogsDownloadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsDownloadSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsDownloadSettings ResetVerbose(this AzureMariadbServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerLogsListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerLogsListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings SetResourceGroup(this AzureMariadbServerLogsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings ResetResourceGroup(this AzureMariadbServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings SetServerName(this AzureMariadbServerLogsListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings ResetServerName(this AzureMariadbServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region FileLastWritten
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsListSettings.FileLastWritten"/></em></p>
        ///   <p>Integer in hours to indicate file last modify time, default value is 72.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings SetFileLastWritten(this AzureMariadbServerLogsListSettings toolSettings, string fileLastWritten)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileLastWritten = fileLastWritten;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsListSettings.FileLastWritten"/></em></p>
        ///   <p>Integer in hours to indicate file last modify time, default value is 72.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings ResetFileLastWritten(this AzureMariadbServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileLastWritten = null;
            return toolSettings;
        }
        #endregion
        #region FilenameContains
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsListSettings.FilenameContains"/></em></p>
        ///   <p>The pattern that file name should match.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings SetFilenameContains(this AzureMariadbServerLogsListSettings toolSettings, string filenameContains)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilenameContains = filenameContains;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsListSettings.FilenameContains"/></em></p>
        ///   <p>The pattern that file name should match.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings ResetFilenameContains(this AzureMariadbServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilenameContains = null;
            return toolSettings;
        }
        #endregion
        #region MaxFileSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsListSettings.MaxFileSize"/></em></p>
        ///   <p>The file size limitation to filter files.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings SetMaxFileSize(this AzureMariadbServerLogsListSettings toolSettings, string maxFileSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxFileSize = maxFileSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsListSettings.MaxFileSize"/></em></p>
        ///   <p>The file size limitation to filter files.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings ResetMaxFileSize(this AzureMariadbServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxFileSize = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings SetSubscription(this AzureMariadbServerLogsListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings ResetSubscription(this AzureMariadbServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings SetDebug(this AzureMariadbServerLogsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings ResetDebug(this AzureMariadbServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings SetHelp(this AzureMariadbServerLogsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings ResetHelp(this AzureMariadbServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings SetOutput(this AzureMariadbServerLogsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings ResetOutput(this AzureMariadbServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings SetQuery(this AzureMariadbServerLogsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings ResetQuery(this AzureMariadbServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerLogsListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings SetVerbose(this AzureMariadbServerLogsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerLogsListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerLogsListSettings ResetVerbose(this AzureMariadbServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetName(this AzureMariadbServerCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetName(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetResourceGroup(this AzureMariadbServerCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetResourceGroup(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetSkuName(this AzureMariadbServerCreateSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetSkuName(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetBackupRetention(this AzureMariadbServerCreateSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetBackupRetention(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region GeoRedundantBackup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.GeoRedundantBackup"/></em></p>
        ///   <p>Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetGeoRedundantBackup(this AzureMariadbServerCreateSettings toolSettings, MariadbServerCreateGeoRedundantBackup geoRedundantBackup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = geoRedundantBackup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.GeoRedundantBackup"/></em></p>
        ///   <p>Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetGeoRedundantBackup(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetLocation(this AzureMariadbServerCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetLocation(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region SslEnforcement
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.SslEnforcement"/></em></p>
        ///   <p>Enable or disable ssl enforcement for connections to server. Default is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetSslEnforcement(this AzureMariadbServerCreateSettings toolSettings, MariadbServerCreateGeoRedundantBackup sslEnforcement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = sslEnforcement;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.SslEnforcement"/></em></p>
        ///   <p>Enable or disable ssl enforcement for connections to server. Default is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetSslEnforcement(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = null;
            return toolSettings;
        }
        #endregion
        #region StorageSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.StorageSize"/></em></p>
        ///   <p>The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetStorageSize(this AzureMariadbServerCreateSettings toolSettings, string storageSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = storageSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.StorageSize"/></em></p>
        ///   <p>The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetStorageSize(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetTags(this AzureMariadbServerCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetTags(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.Version"/></em></p>
        ///   <p>Server major version.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetVersion(this AzureMariadbServerCreateSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.Version"/></em></p>
        ///   <p>Server major version.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetVersion(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region AdminPassword
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.AdminPassword"/></em></p>
        ///   <p>The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetAdminPassword(this AzureMariadbServerCreateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.AdminPassword"/></em></p>
        ///   <p>The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetAdminPassword(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region AdminUser
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.AdminUser"/></em></p>
        ///   <p>Administrator username for the server. Once set, it cannot be changed.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetAdminUser(this AzureMariadbServerCreateSettings toolSettings, string adminUser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUser = adminUser;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.AdminUser"/></em></p>
        ///   <p>Administrator username for the server. Once set, it cannot be changed.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetAdminUser(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUser = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetSubscription(this AzureMariadbServerCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetSubscription(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetDebug(this AzureMariadbServerCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetDebug(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetHelp(this AzureMariadbServerCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetHelp(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetOutput(this AzureMariadbServerCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetOutput(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetQuery(this AzureMariadbServerCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetQuery(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings SetVerbose(this AzureMariadbServerCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerCreateSettings ResetVerbose(this AzureMariadbServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerDeleteSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings SetYes(this AzureMariadbServerDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings ResetYes(this AzureMariadbServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings SetIds(this AzureMariadbServerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings SetIds(this AzureMariadbServerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings AddIds(this AzureMariadbServerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings AddIds(this AzureMariadbServerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings ClearIds(this AzureMariadbServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings RemoveIds(this AzureMariadbServerDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings RemoveIds(this AzureMariadbServerDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerDeleteSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings SetName(this AzureMariadbServerDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerDeleteSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings ResetName(this AzureMariadbServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings SetResourceGroup(this AzureMariadbServerDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings ResetResourceGroup(this AzureMariadbServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings SetSubscription(this AzureMariadbServerDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings ResetSubscription(this AzureMariadbServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings SetDebug(this AzureMariadbServerDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings ResetDebug(this AzureMariadbServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings SetHelp(this AzureMariadbServerDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings ResetHelp(this AzureMariadbServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings SetOutput(this AzureMariadbServerDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings ResetOutput(this AzureMariadbServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings SetQuery(this AzureMariadbServerDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings ResetQuery(this AzureMariadbServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings SetVerbose(this AzureMariadbServerDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerDeleteSettings ResetVerbose(this AzureMariadbServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerGeorestoreSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerGeorestoreSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetLocation(this AzureMariadbServerGeorestoreSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetLocation(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region SourceServer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.SourceServer"/></em></p>
        ///   <p>The name or ID of the source server to restore from.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetSourceServer(this AzureMariadbServerGeorestoreSettings toolSettings, string sourceServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = sourceServer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.SourceServer"/></em></p>
        ///   <p>The name or ID of the source server to restore from.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetSourceServer(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetBackupRetention(this AzureMariadbServerGeorestoreSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetBackupRetention(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region GeoRedundantBackup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.GeoRedundantBackup"/></em></p>
        ///   <p>Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetGeoRedundantBackup(this AzureMariadbServerGeorestoreSettings toolSettings, string geoRedundantBackup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = geoRedundantBackup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.GeoRedundantBackup"/></em></p>
        ///   <p>Enable or disable geo-redundant backups. Default value is Disabled. Not supported in Basic pricing tier.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetGeoRedundantBackup(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetNoWait(this AzureMariadbServerGeorestoreSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetNoWait(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureMariadbServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings EnableNoWait(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureMariadbServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings DisableNoWait(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureMariadbServerGeorestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ToggleNoWait(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Defaults to sku of the source server. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetSkuName(this AzureMariadbServerGeorestoreSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Defaults to sku of the source server. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetSkuName(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetIds(this AzureMariadbServerGeorestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetIds(this AzureMariadbServerGeorestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings AddIds(this AzureMariadbServerGeorestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings AddIds(this AzureMariadbServerGeorestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ClearIds(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings RemoveIds(this AzureMariadbServerGeorestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerGeorestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings RemoveIds(this AzureMariadbServerGeorestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetName(this AzureMariadbServerGeorestoreSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetName(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetResourceGroup(this AzureMariadbServerGeorestoreSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetResourceGroup(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetSubscription(this AzureMariadbServerGeorestoreSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetSubscription(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetDebug(this AzureMariadbServerGeorestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetDebug(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetHelp(this AzureMariadbServerGeorestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetHelp(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetOutput(this AzureMariadbServerGeorestoreSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetOutput(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetQuery(this AzureMariadbServerGeorestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetQuery(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerGeorestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings SetVerbose(this AzureMariadbServerGeorestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerGeorestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerGeorestoreSettings ResetVerbose(this AzureMariadbServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings SetResourceGroup(this AzureMariadbServerListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings ResetResourceGroup(this AzureMariadbServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings SetSubscription(this AzureMariadbServerListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings ResetSubscription(this AzureMariadbServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings SetDebug(this AzureMariadbServerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings ResetDebug(this AzureMariadbServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings SetHelp(this AzureMariadbServerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings ResetHelp(this AzureMariadbServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings SetOutput(this AzureMariadbServerListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings ResetOutput(this AzureMariadbServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings SetQuery(this AzureMariadbServerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings ResetQuery(this AzureMariadbServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings SetVerbose(this AzureMariadbServerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerListSettings ResetVerbose(this AzureMariadbServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerRestartSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerRestartSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestartSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings SetIds(this AzureMariadbServerRestartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestartSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings SetIds(this AzureMariadbServerRestartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings AddIds(this AzureMariadbServerRestartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings AddIds(this AzureMariadbServerRestartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings ClearIds(this AzureMariadbServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings RemoveIds(this AzureMariadbServerRestartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerRestartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings RemoveIds(this AzureMariadbServerRestartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestartSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings SetName(this AzureMariadbServerRestartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestartSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings ResetName(this AzureMariadbServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings SetResourceGroup(this AzureMariadbServerRestartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings ResetResourceGroup(this AzureMariadbServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings SetSubscription(this AzureMariadbServerRestartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings ResetSubscription(this AzureMariadbServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings SetDebug(this AzureMariadbServerRestartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings ResetDebug(this AzureMariadbServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings SetHelp(this AzureMariadbServerRestartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings ResetHelp(this AzureMariadbServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings SetOutput(this AzureMariadbServerRestartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings ResetOutput(this AzureMariadbServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings SetQuery(this AzureMariadbServerRestartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings ResetQuery(this AzureMariadbServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings SetVerbose(this AzureMariadbServerRestartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestartSettings ResetVerbose(this AzureMariadbServerRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerRestoreSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerRestoreSettingsExtensions
    {
        #region RestorePointInTime
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestoreSettings.RestorePointInTime"/></em></p>
        ///   <p>The point in time to restore from (ISO8601 format), e.g., 2017-04-26T02:10:00+08:00.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings SetRestorePointInTime(this AzureMariadbServerRestoreSettings toolSettings, string restorePointInTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestorePointInTime = restorePointInTime;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestoreSettings.RestorePointInTime"/></em></p>
        ///   <p>The point in time to restore from (ISO8601 format), e.g., 2017-04-26T02:10:00+08:00.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings ResetRestorePointInTime(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestorePointInTime = null;
            return toolSettings;
        }
        #endregion
        #region SourceServer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestoreSettings.SourceServer"/></em></p>
        ///   <p>The name or resource ID of the source server to restore from.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings SetSourceServer(this AzureMariadbServerRestoreSettings toolSettings, string sourceServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = sourceServer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestoreSettings.SourceServer"/></em></p>
        ///   <p>The name or resource ID of the source server to restore from.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings ResetSourceServer(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings SetNoWait(this AzureMariadbServerRestoreSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings ResetNoWait(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureMariadbServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings EnableNoWait(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureMariadbServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings DisableNoWait(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureMariadbServerRestoreSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings ToggleNoWait(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestoreSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings SetIds(this AzureMariadbServerRestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestoreSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings SetIds(this AzureMariadbServerRestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings AddIds(this AzureMariadbServerRestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings AddIds(this AzureMariadbServerRestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings ClearIds(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings RemoveIds(this AzureMariadbServerRestoreSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerRestoreSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings RemoveIds(this AzureMariadbServerRestoreSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestoreSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings SetName(this AzureMariadbServerRestoreSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestoreSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings ResetName(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestoreSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings SetResourceGroup(this AzureMariadbServerRestoreSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestoreSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings ResetResourceGroup(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings SetSubscription(this AzureMariadbServerRestoreSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestoreSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings ResetSubscription(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings SetDebug(this AzureMariadbServerRestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestoreSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings ResetDebug(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings SetHelp(this AzureMariadbServerRestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestoreSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings ResetHelp(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings SetOutput(this AzureMariadbServerRestoreSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestoreSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings ResetOutput(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings SetQuery(this AzureMariadbServerRestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestoreSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings ResetQuery(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerRestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings SetVerbose(this AzureMariadbServerRestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerRestoreSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerRestoreSettings ResetVerbose(this AzureMariadbServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings SetIds(this AzureMariadbServerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings SetIds(this AzureMariadbServerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings AddIds(this AzureMariadbServerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings AddIds(this AzureMariadbServerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings ClearIds(this AzureMariadbServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings RemoveIds(this AzureMariadbServerShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings RemoveIds(this AzureMariadbServerShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerShowSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings SetName(this AzureMariadbServerShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerShowSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings ResetName(this AzureMariadbServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings SetResourceGroup(this AzureMariadbServerShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings ResetResourceGroup(this AzureMariadbServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings SetSubscription(this AzureMariadbServerShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings ResetSubscription(this AzureMariadbServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings SetDebug(this AzureMariadbServerShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings ResetDebug(this AzureMariadbServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings SetHelp(this AzureMariadbServerShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings ResetHelp(this AzureMariadbServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings SetOutput(this AzureMariadbServerShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings ResetOutput(this AzureMariadbServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings SetQuery(this AzureMariadbServerShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings ResetQuery(this AzureMariadbServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings SetVerbose(this AzureMariadbServerShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerShowSettings ResetVerbose(this AzureMariadbServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerUpdateSettingsExtensions
    {
        #region AdminPassword
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.AdminPassword"/></em></p>
        ///   <p>The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetAdminPassword(this AzureMariadbServerUpdateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.AdminPassword"/></em></p>
        ///   <p>The password of the administrator. Minimum 8 characters and maximum 128 characters. Password must contain characters from three of the following categories: English uppercase letters, English lowercase letters, numbers, and non-alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetAdminPassword(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetBackupRetention(this AzureMariadbServerUpdateSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.BackupRetention"/></em></p>
        ///   <p>The number of days a backup is retained. Range of 7 to 35 days. Default is 7 days.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetBackupRetention(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetSkuName(this AzureMariadbServerUpdateSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.SkuName"/></em></p>
        ///   <p>The name of the sku. Follows the convention {pricing tier}_{compute generation}_{vCores} in shorthand. Examples: B_Gen5_1, GP_Gen5_4, MO_Gen5_16.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetSkuName(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region SslEnforcement
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.SslEnforcement"/></em></p>
        ///   <p>Enable or disable ssl enforcement for connections to server. Default is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetSslEnforcement(this AzureMariadbServerUpdateSettings toolSettings, MariadbServerCreateGeoRedundantBackup sslEnforcement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = sslEnforcement;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.SslEnforcement"/></em></p>
        ///   <p>Enable or disable ssl enforcement for connections to server. Default is Enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetSslEnforcement(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = null;
            return toolSettings;
        }
        #endregion
        #region StorageSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.StorageSize"/></em></p>
        ///   <p>The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetStorageSize(this AzureMariadbServerUpdateSettings toolSettings, string storageSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = storageSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.StorageSize"/></em></p>
        ///   <p>The storage capacity of the server (unit is megabytes). Minimum 5120 and increases in 1024 increments. Default is 51200.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetStorageSize(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetTags(this AzureMariadbServerUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetTags(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetIds(this AzureMariadbServerUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetIds(this AzureMariadbServerUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings AddIds(this AzureMariadbServerUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings AddIds(this AzureMariadbServerUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ClearIds(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings RemoveIds(this AzureMariadbServerUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings RemoveIds(this AzureMariadbServerUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetName(this AzureMariadbServerUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetName(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetResourceGroup(this AzureMariadbServerUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetResourceGroup(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetSubscription(this AzureMariadbServerUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetSubscription(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetAdd(this AzureMariadbServerUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetAdd(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetForceString(this AzureMariadbServerUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetForceString(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetRemove(this AzureMariadbServerUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetRemove(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetSet(this AzureMariadbServerUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetSet(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetDebug(this AzureMariadbServerUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetDebug(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetHelp(this AzureMariadbServerUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetHelp(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetOutput(this AzureMariadbServerUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetOutput(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetQuery(this AzureMariadbServerUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetQuery(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings SetVerbose(this AzureMariadbServerUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerUpdateSettings ResetVerbose(this AzureMariadbServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerWaitSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetIds(this AzureMariadbServerWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetIds(this AzureMariadbServerWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings AddIds(this AzureMariadbServerWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings AddIds(this AzureMariadbServerWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings ClearIds(this AzureMariadbServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings RemoveIds(this AzureMariadbServerWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings RemoveIds(this AzureMariadbServerWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetName(this AzureMariadbServerWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerWaitSettings.Name"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings ResetName(this AzureMariadbServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetResourceGroup(this AzureMariadbServerWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings ResetResourceGroup(this AzureMariadbServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetSubscription(this AzureMariadbServerWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings ResetSubscription(this AzureMariadbServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetCustom(this AzureMariadbServerWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings ResetCustom(this AzureMariadbServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetExists(this AzureMariadbServerWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings ResetExists(this AzureMariadbServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetInterval(this AzureMariadbServerWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings ResetInterval(this AzureMariadbServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetTimeout(this AzureMariadbServerWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings ResetTimeout(this AzureMariadbServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetDebug(this AzureMariadbServerWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings ResetDebug(this AzureMariadbServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetHelp(this AzureMariadbServerWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings ResetHelp(this AzureMariadbServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetOutput(this AzureMariadbServerWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings ResetOutput(this AzureMariadbServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetQuery(this AzureMariadbServerWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings ResetQuery(this AzureMariadbServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings SetVerbose(this AzureMariadbServerWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerWaitSettings ResetVerbose(this AzureMariadbServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerConfigurationListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerConfigurationListSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings SetIds(this AzureMariadbServerConfigurationListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings SetIds(this AzureMariadbServerConfigurationListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings AddIds(this AzureMariadbServerConfigurationListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings AddIds(this AzureMariadbServerConfigurationListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings ClearIds(this AzureMariadbServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings RemoveIds(this AzureMariadbServerConfigurationListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerConfigurationListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings RemoveIds(this AzureMariadbServerConfigurationListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings SetResourceGroup(this AzureMariadbServerConfigurationListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings ResetResourceGroup(this AzureMariadbServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings SetServerName(this AzureMariadbServerConfigurationListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings ResetServerName(this AzureMariadbServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings SetSubscription(this AzureMariadbServerConfigurationListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings ResetSubscription(this AzureMariadbServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings SetDebug(this AzureMariadbServerConfigurationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings ResetDebug(this AzureMariadbServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings SetHelp(this AzureMariadbServerConfigurationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings ResetHelp(this AzureMariadbServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings SetOutput(this AzureMariadbServerConfigurationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings ResetOutput(this AzureMariadbServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings SetQuery(this AzureMariadbServerConfigurationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings ResetQuery(this AzureMariadbServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings SetVerbose(this AzureMariadbServerConfigurationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationListSettings ResetVerbose(this AzureMariadbServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerConfigurationSetSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerConfigurationSetSettingsExtensions
    {
        #region Value
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationSetSettings.Value"/></em></p>
        ///   <p>Value of the configuration. If not provided, configuration value will be set to default.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings SetValue(this AzureMariadbServerConfigurationSetSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationSetSettings.Value"/></em></p>
        ///   <p>Value of the configuration. If not provided, configuration value will be set to default.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings ResetValue(this AzureMariadbServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationSetSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings SetIds(this AzureMariadbServerConfigurationSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationSetSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings SetIds(this AzureMariadbServerConfigurationSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings AddIds(this AzureMariadbServerConfigurationSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings AddIds(this AzureMariadbServerConfigurationSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings ClearIds(this AzureMariadbServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings RemoveIds(this AzureMariadbServerConfigurationSetSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerConfigurationSetSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings RemoveIds(this AzureMariadbServerConfigurationSetSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationSetSettings.Name"/></em></p>
        ///   <p>The name of the server configuration.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings SetName(this AzureMariadbServerConfigurationSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationSetSettings.Name"/></em></p>
        ///   <p>The name of the server configuration.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings ResetName(this AzureMariadbServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationSetSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings SetResourceGroup(this AzureMariadbServerConfigurationSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationSetSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings ResetResourceGroup(this AzureMariadbServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationSetSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings SetServerName(this AzureMariadbServerConfigurationSetSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationSetSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings ResetServerName(this AzureMariadbServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationSetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings SetSubscription(this AzureMariadbServerConfigurationSetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationSetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings ResetSubscription(this AzureMariadbServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationSetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings SetDebug(this AzureMariadbServerConfigurationSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationSetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings ResetDebug(this AzureMariadbServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationSetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings SetHelp(this AzureMariadbServerConfigurationSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationSetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings ResetHelp(this AzureMariadbServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationSetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings SetOutput(this AzureMariadbServerConfigurationSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationSetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings ResetOutput(this AzureMariadbServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationSetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings SetQuery(this AzureMariadbServerConfigurationSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationSetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings ResetQuery(this AzureMariadbServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationSetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings SetVerbose(this AzureMariadbServerConfigurationSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationSetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationSetSettings ResetVerbose(this AzureMariadbServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerConfigurationShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerConfigurationShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings SetIds(this AzureMariadbServerConfigurationShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings SetIds(this AzureMariadbServerConfigurationShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings AddIds(this AzureMariadbServerConfigurationShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings AddIds(this AzureMariadbServerConfigurationShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings ClearIds(this AzureMariadbServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings RemoveIds(this AzureMariadbServerConfigurationShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerConfigurationShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings RemoveIds(this AzureMariadbServerConfigurationShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationShowSettings.Name"/></em></p>
        ///   <p>The name of the server configuration.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings SetName(this AzureMariadbServerConfigurationShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationShowSettings.Name"/></em></p>
        ///   <p>The name of the server configuration.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings ResetName(this AzureMariadbServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings SetResourceGroup(this AzureMariadbServerConfigurationShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings ResetResourceGroup(this AzureMariadbServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings SetServerName(this AzureMariadbServerConfigurationShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings ResetServerName(this AzureMariadbServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings SetSubscription(this AzureMariadbServerConfigurationShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings ResetSubscription(this AzureMariadbServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings SetDebug(this AzureMariadbServerConfigurationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings ResetDebug(this AzureMariadbServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings SetHelp(this AzureMariadbServerConfigurationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings ResetHelp(this AzureMariadbServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings SetOutput(this AzureMariadbServerConfigurationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings ResetOutput(this AzureMariadbServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings SetQuery(this AzureMariadbServerConfigurationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings ResetQuery(this AzureMariadbServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerConfigurationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings SetVerbose(this AzureMariadbServerConfigurationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerConfigurationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerConfigurationShowSettings ResetVerbose(this AzureMariadbServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerFirewallRuleCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerFirewallRuleCreateSettingsExtensions
    {
        #region EndIpAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleCreateSettings.EndIpAddress"/></em></p>
        ///   <p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings SetEndIpAddress(this AzureMariadbServerFirewallRuleCreateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleCreateSettings.EndIpAddress"/></em></p>
        ///   <p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings ResetEndIpAddress(this AzureMariadbServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings SetName(this AzureMariadbServerFirewallRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings ResetName(this AzureMariadbServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings SetResourceGroup(this AzureMariadbServerFirewallRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings ResetResourceGroup(this AzureMariadbServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings SetServerName(this AzureMariadbServerFirewallRuleCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings ResetServerName(this AzureMariadbServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleCreateSettings.StartIpAddress"/></em></p>
        ///   <p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings SetStartIpAddress(this AzureMariadbServerFirewallRuleCreateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleCreateSettings.StartIpAddress"/></em></p>
        ///   <p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings ResetStartIpAddress(this AzureMariadbServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings SetSubscription(this AzureMariadbServerFirewallRuleCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings ResetSubscription(this AzureMariadbServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings SetDebug(this AzureMariadbServerFirewallRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings ResetDebug(this AzureMariadbServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings SetHelp(this AzureMariadbServerFirewallRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings ResetHelp(this AzureMariadbServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings SetOutput(this AzureMariadbServerFirewallRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings ResetOutput(this AzureMariadbServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings SetQuery(this AzureMariadbServerFirewallRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings ResetQuery(this AzureMariadbServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings SetVerbose(this AzureMariadbServerFirewallRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleCreateSettings ResetVerbose(this AzureMariadbServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerFirewallRuleDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerFirewallRuleDeleteSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings SetYes(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings ResetYes(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings SetIds(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings SetIds(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings AddIds(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings AddIds(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings ClearIds(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings RemoveIds(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings RemoveIds(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings SetName(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings ResetName(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings SetResourceGroup(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings ResetResourceGroup(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings SetServerName(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings ResetServerName(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings SetSubscription(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings ResetSubscription(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings SetDebug(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings ResetDebug(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings SetHelp(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings ResetHelp(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings SetOutput(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings ResetOutput(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings SetQuery(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings ResetQuery(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings SetVerbose(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleDeleteSettings ResetVerbose(this AzureMariadbServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerFirewallRuleListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerFirewallRuleListSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings SetIds(this AzureMariadbServerFirewallRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings SetIds(this AzureMariadbServerFirewallRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings AddIds(this AzureMariadbServerFirewallRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings AddIds(this AzureMariadbServerFirewallRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings ClearIds(this AzureMariadbServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings RemoveIds(this AzureMariadbServerFirewallRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerFirewallRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings RemoveIds(this AzureMariadbServerFirewallRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings SetResourceGroup(this AzureMariadbServerFirewallRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings ResetResourceGroup(this AzureMariadbServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings SetServerName(this AzureMariadbServerFirewallRuleListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings ResetServerName(this AzureMariadbServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings SetSubscription(this AzureMariadbServerFirewallRuleListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings ResetSubscription(this AzureMariadbServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings SetDebug(this AzureMariadbServerFirewallRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings ResetDebug(this AzureMariadbServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings SetHelp(this AzureMariadbServerFirewallRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings ResetHelp(this AzureMariadbServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings SetOutput(this AzureMariadbServerFirewallRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings ResetOutput(this AzureMariadbServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings SetQuery(this AzureMariadbServerFirewallRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings ResetQuery(this AzureMariadbServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings SetVerbose(this AzureMariadbServerFirewallRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleListSettings ResetVerbose(this AzureMariadbServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerFirewallRuleShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerFirewallRuleShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings SetIds(this AzureMariadbServerFirewallRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings SetIds(this AzureMariadbServerFirewallRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings AddIds(this AzureMariadbServerFirewallRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings AddIds(this AzureMariadbServerFirewallRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings ClearIds(this AzureMariadbServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings RemoveIds(this AzureMariadbServerFirewallRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerFirewallRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings RemoveIds(this AzureMariadbServerFirewallRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleShowSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings SetName(this AzureMariadbServerFirewallRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleShowSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings ResetName(this AzureMariadbServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings SetResourceGroup(this AzureMariadbServerFirewallRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings ResetResourceGroup(this AzureMariadbServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings SetServerName(this AzureMariadbServerFirewallRuleShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings ResetServerName(this AzureMariadbServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings SetSubscription(this AzureMariadbServerFirewallRuleShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings ResetSubscription(this AzureMariadbServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings SetDebug(this AzureMariadbServerFirewallRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings ResetDebug(this AzureMariadbServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings SetHelp(this AzureMariadbServerFirewallRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings ResetHelp(this AzureMariadbServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings SetOutput(this AzureMariadbServerFirewallRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings ResetOutput(this AzureMariadbServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings SetQuery(this AzureMariadbServerFirewallRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings ResetQuery(this AzureMariadbServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings SetVerbose(this AzureMariadbServerFirewallRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleShowSettings ResetVerbose(this AzureMariadbServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerFirewallRuleUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerFirewallRuleUpdateSettingsExtensions
    {
        #region EndIpAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.EndIpAddress"/></em></p>
        ///   <p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetEndIpAddress(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.EndIpAddress"/></em></p>
        ///   <p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetEndIpAddress(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.StartIpAddress"/></em></p>
        ///   <p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetStartIpAddress(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.StartIpAddress"/></em></p>
        ///   <p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetStartIpAddress(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetIds(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetIds(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings AddIds(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings AddIds(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ClearIds(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings RemoveIds(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings RemoveIds(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetName(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Name"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetName(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetResourceGroup(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetResourceGroup(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetServerName(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetServerName(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetSubscription(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetSubscription(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetAdd(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetAdd(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetForceString(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetForceString(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetRemove(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetRemove(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetSet(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetSet(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetDebug(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetDebug(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetHelp(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetHelp(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetOutput(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetOutput(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetQuery(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetQuery(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings SetVerbose(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerFirewallRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerFirewallRuleUpdateSettings ResetVerbose(this AzureMariadbServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerVnetRuleCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerVnetRuleCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleCreateSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings SetName(this AzureMariadbServerVnetRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleCreateSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings ResetName(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings SetResourceGroup(this AzureMariadbServerVnetRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings ResetResourceGroup(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings SetServerName(this AzureMariadbServerVnetRuleCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleCreateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings ResetServerName(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleCreateSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings SetSubnet(this AzureMariadbServerVnetRuleCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleCreateSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings ResetSubnet(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region IgnoreMissingEndpoint
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings SetIgnoreMissingEndpoint(this AzureMariadbServerVnetRuleCreateSettings toolSettings, bool? ignoreMissingEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = ignoreMissingEndpoint;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings ResetIgnoreMissingEndpoint(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureMariadbServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings EnableIgnoreMissingEndpoint(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureMariadbServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings DisableIgnoreMissingEndpoint(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureMariadbServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings ToggleIgnoreMissingEndpoint(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = !toolSettings.IgnoreMissingEndpoint;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleCreateSettings.VnetName"/></em></p>
        ///   <p>The virtual network name.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings SetVnetName(this AzureMariadbServerVnetRuleCreateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleCreateSettings.VnetName"/></em></p>
        ///   <p>The virtual network name.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings ResetVnetName(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings SetSubscription(this AzureMariadbServerVnetRuleCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings ResetSubscription(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings SetDebug(this AzureMariadbServerVnetRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings ResetDebug(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings SetHelp(this AzureMariadbServerVnetRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings ResetHelp(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings SetOutput(this AzureMariadbServerVnetRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings ResetOutput(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings SetQuery(this AzureMariadbServerVnetRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings ResetQuery(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings SetVerbose(this AzureMariadbServerVnetRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleCreateSettings ResetVerbose(this AzureMariadbServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerVnetRuleDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerVnetRuleDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings SetIds(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings SetIds(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings AddIds(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings AddIds(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings ClearIds(this AzureMariadbServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings RemoveIds(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerVnetRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings RemoveIds(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings SetName(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings ResetName(this AzureMariadbServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings SetResourceGroup(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings ResetResourceGroup(this AzureMariadbServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings SetServerName(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleDeleteSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings ResetServerName(this AzureMariadbServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings SetSubscription(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings ResetSubscription(this AzureMariadbServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings SetDebug(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings ResetDebug(this AzureMariadbServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings SetHelp(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings ResetHelp(this AzureMariadbServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings SetOutput(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings ResetOutput(this AzureMariadbServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings SetQuery(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings ResetQuery(this AzureMariadbServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings SetVerbose(this AzureMariadbServerVnetRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleDeleteSettings ResetVerbose(this AzureMariadbServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerVnetRuleListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerVnetRuleListSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings SetIds(this AzureMariadbServerVnetRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleListSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings SetIds(this AzureMariadbServerVnetRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings AddIds(this AzureMariadbServerVnetRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings AddIds(this AzureMariadbServerVnetRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings ClearIds(this AzureMariadbServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings RemoveIds(this AzureMariadbServerVnetRuleListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerVnetRuleListSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings RemoveIds(this AzureMariadbServerVnetRuleListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings SetResourceGroup(this AzureMariadbServerVnetRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings ResetResourceGroup(this AzureMariadbServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings SetServerName(this AzureMariadbServerVnetRuleListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleListSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings ResetServerName(this AzureMariadbServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings SetSubscription(this AzureMariadbServerVnetRuleListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings ResetSubscription(this AzureMariadbServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings SetDebug(this AzureMariadbServerVnetRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings ResetDebug(this AzureMariadbServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings SetHelp(this AzureMariadbServerVnetRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings ResetHelp(this AzureMariadbServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings SetOutput(this AzureMariadbServerVnetRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings ResetOutput(this AzureMariadbServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings SetQuery(this AzureMariadbServerVnetRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings ResetQuery(this AzureMariadbServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings SetVerbose(this AzureMariadbServerVnetRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleListSettings ResetVerbose(this AzureMariadbServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerVnetRuleShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerVnetRuleShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings SetIds(this AzureMariadbServerVnetRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings SetIds(this AzureMariadbServerVnetRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings AddIds(this AzureMariadbServerVnetRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings AddIds(this AzureMariadbServerVnetRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings ClearIds(this AzureMariadbServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings RemoveIds(this AzureMariadbServerVnetRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerVnetRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings RemoveIds(this AzureMariadbServerVnetRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleShowSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings SetName(this AzureMariadbServerVnetRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleShowSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings ResetName(this AzureMariadbServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings SetResourceGroup(this AzureMariadbServerVnetRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings ResetResourceGroup(this AzureMariadbServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings SetServerName(this AzureMariadbServerVnetRuleShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleShowSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings ResetServerName(this AzureMariadbServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings SetSubscription(this AzureMariadbServerVnetRuleShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings ResetSubscription(this AzureMariadbServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings SetDebug(this AzureMariadbServerVnetRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings ResetDebug(this AzureMariadbServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings SetHelp(this AzureMariadbServerVnetRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings ResetHelp(this AzureMariadbServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings SetOutput(this AzureMariadbServerVnetRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings ResetOutput(this AzureMariadbServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings SetQuery(this AzureMariadbServerVnetRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings ResetQuery(this AzureMariadbServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings SetVerbose(this AzureMariadbServerVnetRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleShowSettings ResetVerbose(this AzureMariadbServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMariadbServerVnetRuleUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMariadbServerVnetRuleUpdateSettingsExtensions
    {
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetSubnet(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetSubnet(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region IgnoreMissingEndpoint
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetIgnoreMissingEndpoint(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, bool? ignoreMissingEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = ignoreMissingEndpoint;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetIgnoreMissingEndpoint(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureMariadbServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings EnableIgnoreMissingEndpoint(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureMariadbServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings DisableIgnoreMissingEndpoint(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureMariadbServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/></em></p>
        ///   <p>Create vnet rule before virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ToggleIgnoreMissingEndpoint(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = !toolSettings.IgnoreMissingEndpoint;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.VnetName"/></em></p>
        ///   <p>The virtual network name.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetVnetName(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.VnetName"/></em></p>
        ///   <p>The virtual network name.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetVnetName(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetIds(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetIds(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings AddIds(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureMariadbServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings AddIds(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureMariadbServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ClearIds(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings RemoveIds(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureMariadbServerVnetRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings RemoveIds(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetName(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Name"/></em></p>
        ///   <p>The name of the vnet rule.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetName(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetResourceGroup(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetResourceGroup(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetServerName(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.ServerName"/></em></p>
        ///   <p>Name of the server. The name can contain only lowercase letters, numbers, and the hyphen (-) character. Minimum 3 characters and maximum 63 characters.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetServerName(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetSubscription(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetSubscription(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetAdd(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetAdd(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetForceString(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetForceString(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetRemove(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetRemove(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetSet(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetSet(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetDebug(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetDebug(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetHelp(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetHelp(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetOutput(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetOutput(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetQuery(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetQuery(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings SetVerbose(this AzureMariadbServerVnetRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureMariadbServerVnetRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureMariadbServerVnetRuleUpdateSettings ResetVerbose(this AzureMariadbServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region MariadbServerCreateGeoRedundantBackup
    /// <summary>
    ///   Used within <see cref="AzureMariadbTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<MariadbServerCreateGeoRedundantBackup>))]
    public partial class MariadbServerCreateGeoRedundantBackup : Enumeration
    {
        public static MariadbServerCreateGeoRedundantBackup disabled = new MariadbServerCreateGeoRedundantBackup { Value = "disabled" };
        public static MariadbServerCreateGeoRedundantBackup enabled = new MariadbServerCreateGeoRedundantBackup { Value = "enabled" };
    }
    #endregion
}
