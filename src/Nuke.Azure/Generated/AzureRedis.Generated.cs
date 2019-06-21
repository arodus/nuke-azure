// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzureRedis.json
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
    public static partial class AzureRedisTasks
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public static string AzureRedisPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREREDIS_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureRedisLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage dedicated Redis caches for your Azure applications.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedis(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureRedisPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureRedisLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisCreate(AzureRedisCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisCreateSettings.Debug"/></li>
        ///     <li><c>--enable-non-ssl-port</c> via <see cref="AzureRedisCreateSettings.EnableNonSslPort"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureRedisCreateSettings.Location"/></li>
        ///     <li><c>--minimum-tls-version</c> via <see cref="AzureRedisCreateSettings.MinimumTlsVersion"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisCreateSettings.Query"/></li>
        ///     <li><c>--redis-configuration</c> via <see cref="AzureRedisCreateSettings.RedisConfiguration"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--shard-count</c> via <see cref="AzureRedisCreateSettings.ShardCount"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureRedisCreateSettings.Sku"/></li>
        ///     <li><c>--static-ip</c> via <see cref="AzureRedisCreateSettings.StaticIp"/></li>
        ///     <li><c>--subnet-id</c> via <see cref="AzureRedisCreateSettings.SubnetId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureRedisCreateSettings.Tags"/></li>
        ///     <li><c>--tenant-settings</c> via <see cref="AzureRedisCreateSettings.TenantSettings"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisCreateSettings.Verbose"/></li>
        ///     <li><c>--vm-size</c> via <see cref="AzureRedisCreateSettings.VmSize"/></li>
        ///     <li><c>--zones</c> via <see cref="AzureRedisCreateSettings.Zones"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisCreate(Configure<AzureRedisCreateSettings> configurator)
        {
            return AzureRedisCreate(configurator(new AzureRedisCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisCreateSettings.Debug"/></li>
        ///     <li><c>--enable-non-ssl-port</c> via <see cref="AzureRedisCreateSettings.EnableNonSslPort"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureRedisCreateSettings.Location"/></li>
        ///     <li><c>--minimum-tls-version</c> via <see cref="AzureRedisCreateSettings.MinimumTlsVersion"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisCreateSettings.Query"/></li>
        ///     <li><c>--redis-configuration</c> via <see cref="AzureRedisCreateSettings.RedisConfiguration"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--shard-count</c> via <see cref="AzureRedisCreateSettings.ShardCount"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureRedisCreateSettings.Sku"/></li>
        ///     <li><c>--static-ip</c> via <see cref="AzureRedisCreateSettings.StaticIp"/></li>
        ///     <li><c>--subnet-id</c> via <see cref="AzureRedisCreateSettings.SubnetId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureRedisCreateSettings.Tags"/></li>
        ///     <li><c>--tenant-settings</c> via <see cref="AzureRedisCreateSettings.TenantSettings"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisCreateSettings.Verbose"/></li>
        ///     <li><c>--vm-size</c> via <see cref="AzureRedisCreateSettings.VmSize"/></li>
        ///     <li><c>--zones</c> via <see cref="AzureRedisCreateSettings.Zones"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisCreate(CombinatorialConfigure<AzureRedisCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisCreate, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisDelete(AzureRedisDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureRedisDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisDelete(Configure<AzureRedisDeleteSettings> configurator)
        {
            return AzureRedisDelete(configurator(new AzureRedisDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureRedisDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisDelete(CombinatorialConfigure<AzureRedisDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisDelete, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisExport(AzureRedisExportSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisExportSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container</c> via <see cref="AzureRedisExportSettings.Container"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRedisExportSettings.Debug"/></li>
        ///     <li><c>--file-format</c> via <see cref="AzureRedisExportSettings.FileFormat"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisExportSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisExportSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisExportSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisExportSettings.Output"/></li>
        ///     <li><c>--prefix</c> via <see cref="AzureRedisExportSettings.Prefix"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisExportSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisExportSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisExportSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisExportSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisExport(Configure<AzureRedisExportSettings> configurator)
        {
            return AzureRedisExport(configurator(new AzureRedisExportSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--container</c> via <see cref="AzureRedisExportSettings.Container"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRedisExportSettings.Debug"/></li>
        ///     <li><c>--file-format</c> via <see cref="AzureRedisExportSettings.FileFormat"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisExportSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisExportSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisExportSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisExportSettings.Output"/></li>
        ///     <li><c>--prefix</c> via <see cref="AzureRedisExportSettings.Prefix"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisExportSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisExportSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisExportSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisExportSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisExportSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisExport(CombinatorialConfigure<AzureRedisExportSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisExport, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisForceReboot(AzureRedisForceRebootSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisForceRebootSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisForceRebootSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisForceRebootSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisForceRebootSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisForceRebootSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisForceRebootSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisForceRebootSettings.Query"/></li>
        ///     <li><c>--reboot-type</c> via <see cref="AzureRedisForceRebootSettings.RebootType"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisForceRebootSettings.ResourceGroup"/></li>
        ///     <li><c>--shard-id</c> via <see cref="AzureRedisForceRebootSettings.ShardId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisForceRebootSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisForceRebootSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisForceReboot(Configure<AzureRedisForceRebootSettings> configurator)
        {
            return AzureRedisForceReboot(configurator(new AzureRedisForceRebootSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisForceRebootSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisForceRebootSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisForceRebootSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisForceRebootSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisForceRebootSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisForceRebootSettings.Query"/></li>
        ///     <li><c>--reboot-type</c> via <see cref="AzureRedisForceRebootSettings.RebootType"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisForceRebootSettings.ResourceGroup"/></li>
        ///     <li><c>--shard-id</c> via <see cref="AzureRedisForceRebootSettings.ShardId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisForceRebootSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisForceRebootSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisForceRebootSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisForceReboot(CombinatorialConfigure<AzureRedisForceRebootSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisForceReboot, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisImport(AzureRedisImportSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisImportSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisImportSettings.Debug"/></li>
        ///     <li><c>--file-format</c> via <see cref="AzureRedisImportSettings.FileFormat"/></li>
        ///     <li><c>--files</c> via <see cref="AzureRedisImportSettings.Files"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisImportSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisImportSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisImportSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisImportSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisImportSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisImportSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisImportSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisImportSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisImport(Configure<AzureRedisImportSettings> configurator)
        {
            return AzureRedisImport(configurator(new AzureRedisImportSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisImportSettings.Debug"/></li>
        ///     <li><c>--file-format</c> via <see cref="AzureRedisImportSettings.FileFormat"/></li>
        ///     <li><c>--files</c> via <see cref="AzureRedisImportSettings.Files"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisImportSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisImportSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisImportSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisImportSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisImportSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisImportSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisImportSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisImportSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisImportSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisImport(CombinatorialConfigure<AzureRedisImportSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisImport, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisImportMethod(AzureRedisImportMethodSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisImportMethodSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisImportMethodSettings.Debug"/></li>
        ///     <li><c>--file-format</c> via <see cref="AzureRedisImportMethodSettings.FileFormat"/></li>
        ///     <li><c>--files</c> via <see cref="AzureRedisImportMethodSettings.Files"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisImportMethodSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisImportMethodSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisImportMethodSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisImportMethodSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisImportMethodSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisImportMethodSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisImportMethodSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisImportMethodSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisImportMethod(Configure<AzureRedisImportMethodSettings> configurator)
        {
            return AzureRedisImportMethod(configurator(new AzureRedisImportMethodSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisImportMethodSettings.Debug"/></li>
        ///     <li><c>--file-format</c> via <see cref="AzureRedisImportMethodSettings.FileFormat"/></li>
        ///     <li><c>--files</c> via <see cref="AzureRedisImportMethodSettings.Files"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisImportMethodSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisImportMethodSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisImportMethodSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisImportMethodSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisImportMethodSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisImportMethodSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisImportMethodSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisImportMethodSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisImportMethodSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisImportMethod(CombinatorialConfigure<AzureRedisImportMethodSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisImportMethod, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisList(AzureRedisListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisList(Configure<AzureRedisListSettings> configurator)
        {
            return AzureRedisList(configurator(new AzureRedisListSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisListSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisList(CombinatorialConfigure<AzureRedisListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisList, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisListKeys(AzureRedisListKeysSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisListKeysSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisListKeysSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisListKeysSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisListKeysSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisListKeysSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisListKeysSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisListKeysSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisListKeysSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisListKeysSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisListKeysSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisListKeys(Configure<AzureRedisListKeysSettings> configurator)
        {
            return AzureRedisListKeys(configurator(new AzureRedisListKeysSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisListKeysSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisListKeysSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisListKeysSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisListKeysSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisListKeysSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisListKeysSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisListKeysSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisListKeysSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisListKeysSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisListKeysSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisListKeys(CombinatorialConfigure<AzureRedisListKeysSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisListKeys, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisRegenerateKeys(AzureRedisRegenerateKeysSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisRegenerateKeysSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisRegenerateKeysSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisRegenerateKeysSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisRegenerateKeysSettings.Ids"/></li>
        ///     <li><c>--key-type</c> via <see cref="AzureRedisRegenerateKeysSettings.KeyType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisRegenerateKeysSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisRegenerateKeysSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisRegenerateKeysSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisRegenerateKeysSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisRegenerateKeysSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisRegenerateKeysSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisRegenerateKeys(Configure<AzureRedisRegenerateKeysSettings> configurator)
        {
            return AzureRedisRegenerateKeys(configurator(new AzureRedisRegenerateKeysSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisRegenerateKeysSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisRegenerateKeysSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisRegenerateKeysSettings.Ids"/></li>
        ///     <li><c>--key-type</c> via <see cref="AzureRedisRegenerateKeysSettings.KeyType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisRegenerateKeysSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisRegenerateKeysSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisRegenerateKeysSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisRegenerateKeysSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisRegenerateKeysSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisRegenerateKeysSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisRegenerateKeysSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisRegenerateKeys(CombinatorialConfigure<AzureRedisRegenerateKeysSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisRegenerateKeys, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisShow(AzureRedisShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisShow(Configure<AzureRedisShowSettings> configurator)
        {
            return AzureRedisShow(configurator(new AzureRedisShowSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisShow(CombinatorialConfigure<AzureRedisShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisShow, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisUpdate(AzureRedisUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRedisUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRedisUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRedisUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRedisUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRedisUpdateSettings.Set"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureRedisUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisUpdateSettings.Verbose"/></li>
        ///     <li><c>--vm-size</c> via <see cref="AzureRedisUpdateSettings.VmSize"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisUpdate(Configure<AzureRedisUpdateSettings> configurator)
        {
            return AzureRedisUpdate(configurator(new AzureRedisUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRedisUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRedisUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRedisUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRedisUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRedisUpdateSettings.Set"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureRedisUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisUpdateSettings.Verbose"/></li>
        ///     <li><c>--vm-size</c> via <see cref="AzureRedisUpdateSettings.VmSize"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisUpdate(CombinatorialConfigure<AzureRedisUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisUpdate, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisFirewallRulesCreate(AzureRedisFirewallRulesCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisFirewallRulesCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Debug"/></li>
        ///     <li><c>--end-ip</c> via <see cref="AzureRedisFirewallRulesCreateSettings.EndIp"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisFirewallRulesCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--rule-name</c> via <see cref="AzureRedisFirewallRulesCreateSettings.RuleName"/></li>
        ///     <li><c>--start-ip</c> via <see cref="AzureRedisFirewallRulesCreateSettings.StartIp"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisFirewallRulesCreate(Configure<AzureRedisFirewallRulesCreateSettings> configurator)
        {
            return AzureRedisFirewallRulesCreate(configurator(new AzureRedisFirewallRulesCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Debug"/></li>
        ///     <li><c>--end-ip</c> via <see cref="AzureRedisFirewallRulesCreateSettings.EndIp"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisFirewallRulesCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--rule-name</c> via <see cref="AzureRedisFirewallRulesCreateSettings.RuleName"/></li>
        ///     <li><c>--start-ip</c> via <see cref="AzureRedisFirewallRulesCreateSettings.StartIp"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisFirewallRulesCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisFirewallRulesCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisFirewallRulesCreate(CombinatorialConfigure<AzureRedisFirewallRulesCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisFirewallRulesCreate, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisFirewallRulesDelete(AzureRedisFirewallRulesDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisFirewallRulesDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--rule-name</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.RuleName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisFirewallRulesDelete(Configure<AzureRedisFirewallRulesDeleteSettings> configurator)
        {
            return AzureRedisFirewallRulesDelete(configurator(new AzureRedisFirewallRulesDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--rule-name</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.RuleName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisFirewallRulesDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisFirewallRulesDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisFirewallRulesDelete(CombinatorialConfigure<AzureRedisFirewallRulesDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisFirewallRulesDelete, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisFirewallRulesList(AzureRedisFirewallRulesListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisFirewallRulesListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisFirewallRulesListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisFirewallRulesListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisFirewallRulesListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisFirewallRulesListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisFirewallRulesListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisFirewallRulesListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisFirewallRulesListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisFirewallRulesListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisFirewallRulesList(Configure<AzureRedisFirewallRulesListSettings> configurator)
        {
            return AzureRedisFirewallRulesList(configurator(new AzureRedisFirewallRulesListSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisFirewallRulesListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisFirewallRulesListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisFirewallRulesListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisFirewallRulesListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisFirewallRulesListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisFirewallRulesListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisFirewallRulesListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisFirewallRulesListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisFirewallRulesListSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisFirewallRulesList(CombinatorialConfigure<AzureRedisFirewallRulesListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisFirewallRulesList, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisFirewallRulesShow(AzureRedisFirewallRulesShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisFirewallRulesShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisFirewallRulesShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisFirewallRulesShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisFirewallRulesShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisFirewallRulesShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisFirewallRulesShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisFirewallRulesShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisFirewallRulesShowSettings.ResourceGroup"/></li>
        ///     <li><c>--rule-name</c> via <see cref="AzureRedisFirewallRulesShowSettings.RuleName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisFirewallRulesShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisFirewallRulesShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisFirewallRulesShow(Configure<AzureRedisFirewallRulesShowSettings> configurator)
        {
            return AzureRedisFirewallRulesShow(configurator(new AzureRedisFirewallRulesShowSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisFirewallRulesShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisFirewallRulesShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisFirewallRulesShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisFirewallRulesShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisFirewallRulesShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisFirewallRulesShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisFirewallRulesShowSettings.ResourceGroup"/></li>
        ///     <li><c>--rule-name</c> via <see cref="AzureRedisFirewallRulesShowSettings.RuleName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisFirewallRulesShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisFirewallRulesShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisFirewallRulesShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisFirewallRulesShow(CombinatorialConfigure<AzureRedisFirewallRulesShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisFirewallRulesShow, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisFirewallRulesUpdate(AzureRedisFirewallRulesUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisFirewallRulesUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Debug"/></li>
        ///     <li><c>--end-ip</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.EndIp"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--rule-name</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.RuleName"/></li>
        ///     <li><c>--start-ip</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.StartIp"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisFirewallRulesUpdate(Configure<AzureRedisFirewallRulesUpdateSettings> configurator)
        {
            return AzureRedisFirewallRulesUpdate(configurator(new AzureRedisFirewallRulesUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Debug"/></li>
        ///     <li><c>--end-ip</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.EndIp"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--rule-name</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.RuleName"/></li>
        ///     <li><c>--start-ip</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.StartIp"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisFirewallRulesUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisFirewallRulesUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisFirewallRulesUpdate(CombinatorialConfigure<AzureRedisFirewallRulesUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisFirewallRulesUpdate, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisPatchScheduleCreate(AzureRedisPatchScheduleCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisPatchScheduleCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisPatchScheduleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--schedule-entries</c> via <see cref="AzureRedisPatchScheduleCreateSettings.ScheduleEntries"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisPatchScheduleCreate(Configure<AzureRedisPatchScheduleCreateSettings> configurator)
        {
            return AzureRedisPatchScheduleCreate(configurator(new AzureRedisPatchScheduleCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisPatchScheduleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--schedule-entries</c> via <see cref="AzureRedisPatchScheduleCreateSettings.ScheduleEntries"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisPatchScheduleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisPatchScheduleCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisPatchScheduleCreate(CombinatorialConfigure<AzureRedisPatchScheduleCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisPatchScheduleCreate, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisPatchScheduleDelete(AzureRedisPatchScheduleDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisPatchScheduleDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisPatchScheduleDelete(Configure<AzureRedisPatchScheduleDeleteSettings> configurator)
        {
            return AzureRedisPatchScheduleDelete(configurator(new AzureRedisPatchScheduleDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisPatchScheduleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisPatchScheduleDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisPatchScheduleDelete(CombinatorialConfigure<AzureRedisPatchScheduleDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisPatchScheduleDelete, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisPatchScheduleShow(AzureRedisPatchScheduleShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisPatchScheduleShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisPatchScheduleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisPatchScheduleShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisPatchScheduleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisPatchScheduleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisPatchScheduleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisPatchScheduleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisPatchScheduleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisPatchScheduleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisPatchScheduleShow(Configure<AzureRedisPatchScheduleShowSettings> configurator)
        {
            return AzureRedisPatchScheduleShow(configurator(new AzureRedisPatchScheduleShowSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisPatchScheduleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisPatchScheduleShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisPatchScheduleShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisPatchScheduleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisPatchScheduleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisPatchScheduleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisPatchScheduleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisPatchScheduleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisPatchScheduleShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisPatchScheduleShow(CombinatorialConfigure<AzureRedisPatchScheduleShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisPatchScheduleShow, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisPatchScheduleUpdate(AzureRedisPatchScheduleUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisPatchScheduleUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--schedule-entries</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.ScheduleEntries"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisPatchScheduleUpdate(Configure<AzureRedisPatchScheduleUpdateSettings> configurator)
        {
            return AzureRedisPatchScheduleUpdate(configurator(new AzureRedisPatchScheduleUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--schedule-entries</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.ScheduleEntries"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisPatchScheduleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisPatchScheduleUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisPatchScheduleUpdate(CombinatorialConfigure<AzureRedisPatchScheduleUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisPatchScheduleUpdate, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisServerLinkCreate(AzureRedisServerLinkCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisServerLinkCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisServerLinkCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisServerLinkCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisServerLinkCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisServerLinkCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisServerLinkCreateSettings.Query"/></li>
        ///     <li><c>--replication-role</c> via <see cref="AzureRedisServerLinkCreateSettings.ReplicationRole"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisServerLinkCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-to-link</c> via <see cref="AzureRedisServerLinkCreateSettings.ServerToLink"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisServerLinkCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisServerLinkCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisServerLinkCreate(Configure<AzureRedisServerLinkCreateSettings> configurator)
        {
            return AzureRedisServerLinkCreate(configurator(new AzureRedisServerLinkCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisServerLinkCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisServerLinkCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisServerLinkCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisServerLinkCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisServerLinkCreateSettings.Query"/></li>
        ///     <li><c>--replication-role</c> via <see cref="AzureRedisServerLinkCreateSettings.ReplicationRole"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisServerLinkCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--server-to-link</c> via <see cref="AzureRedisServerLinkCreateSettings.ServerToLink"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisServerLinkCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisServerLinkCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisServerLinkCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisServerLinkCreate(CombinatorialConfigure<AzureRedisServerLinkCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisServerLinkCreate, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisServerLinkDelete(AzureRedisServerLinkDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisServerLinkDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisServerLinkDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisServerLinkDeleteSettings.Help"/></li>
        ///     <li><c>--linked-server-name</c> via <see cref="AzureRedisServerLinkDeleteSettings.LinkedServerName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisServerLinkDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisServerLinkDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisServerLinkDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisServerLinkDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisServerLinkDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisServerLinkDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisServerLinkDelete(Configure<AzureRedisServerLinkDeleteSettings> configurator)
        {
            return AzureRedisServerLinkDelete(configurator(new AzureRedisServerLinkDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisServerLinkDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisServerLinkDeleteSettings.Help"/></li>
        ///     <li><c>--linked-server-name</c> via <see cref="AzureRedisServerLinkDeleteSettings.LinkedServerName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisServerLinkDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisServerLinkDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisServerLinkDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisServerLinkDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisServerLinkDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisServerLinkDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisServerLinkDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisServerLinkDelete(CombinatorialConfigure<AzureRedisServerLinkDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisServerLinkDelete, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisServerLinkList(AzureRedisServerLinkListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisServerLinkListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisServerLinkListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisServerLinkListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisServerLinkListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisServerLinkListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisServerLinkListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisServerLinkListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisServerLinkListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisServerLinkListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisServerLinkList(Configure<AzureRedisServerLinkListSettings> configurator)
        {
            return AzureRedisServerLinkList(configurator(new AzureRedisServerLinkListSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisServerLinkListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisServerLinkListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisServerLinkListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisServerLinkListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisServerLinkListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisServerLinkListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisServerLinkListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisServerLinkListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisServerLinkListSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisServerLinkList(CombinatorialConfigure<AzureRedisServerLinkListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisServerLinkList, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRedisServerLinkShow(AzureRedisServerLinkShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRedisServerLinkShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisServerLinkShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisServerLinkShowSettings.Help"/></li>
        ///     <li><c>--linked-server-name</c> via <see cref="AzureRedisServerLinkShowSettings.LinkedServerName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisServerLinkShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisServerLinkShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisServerLinkShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisServerLinkShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisServerLinkShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisServerLinkShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRedisServerLinkShow(Configure<AzureRedisServerLinkShowSettings> configurator)
        {
            return AzureRedisServerLinkShow(configurator(new AzureRedisServerLinkShowSettings()));
        }
        /// <summary>
        ///   <p>Manage dedicated Redis caches for your Azure applications.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRedisServerLinkShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRedisServerLinkShowSettings.Help"/></li>
        ///     <li><c>--linked-server-name</c> via <see cref="AzureRedisServerLinkShowSettings.LinkedServerName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRedisServerLinkShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRedisServerLinkShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRedisServerLinkShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRedisServerLinkShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRedisServerLinkShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRedisServerLinkShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRedisServerLinkShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureRedisServerLinkShow(CombinatorialConfigure<AzureRedisServerLinkShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRedisServerLinkShow, AzureRedisLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureRedisCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Name of the Redis cache.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Type of Redis cache.
        /// </summary>
        public virtual RedisSku Sku { get; internal set; }
        /// <summary>
        ///   Size of Redis cache to deploy. Basic and Standard Cache sizes start with C. Premium Cache sizes start with P.
        /// </summary>
        public virtual RedisVmSize VmSize { get; internal set; }
        /// <summary>
        ///   If the value is true, then the non-ssl redis server port (6379) will be enabled.
        /// </summary>
        public virtual string EnableNonSslPort { get; internal set; }
        /// <summary>
        ///   Specifies the TLS version required by clients to connect to cache.
        /// </summary>
        public virtual RedisCreateMinimumTlsVersion MinimumTlsVersion { get; internal set; }
        /// <summary>
        ///   JSON encoded configuration settings. Use @{file} to load from a file.
        /// </summary>
        public virtual string RedisConfiguration { get; internal set; }
        /// <summary>
        ///   The number of shards to be created on a Premium Cluster Cache.
        /// </summary>
        public virtual string ShardCount { get; internal set; }
        /// <summary>
        ///   Specify a static ip if required for the VNET. If you do not specify a static IP then an IP address is chosen automatically.
        /// </summary>
        public virtual string StaticIp { get; internal set; }
        /// <summary>
        ///   The full resource ID of a subnet in a virtual network to deploy the redis cache in. Example format /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1.
        /// </summary>
        public virtual string SubnetId { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   Space-separated tenant settings in key[=value] format.
        /// </summary>
        public virtual IReadOnlyList<string> TenantSettings => TenantSettingsInternal.AsReadOnly();
        internal List<string> TenantSettingsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Space-separated list of availability zones into which to provision the resource.
        /// </summary>
        public virtual IReadOnlyList<RedisCreateZones> Zones => ZonesInternal.AsReadOnly();
        internal List<RedisCreateZones> ZonesInternal { get; set; } = new List<RedisCreateZones>();
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
              .Add("redis create")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--vm-size {value}", VmSize)
              .Add("--enable-non-ssl-port {value}", EnableNonSslPort)
              .Add("--minimum-tls-version {value}", MinimumTlsVersion)
              .Add("--redis-configuration {value}", RedisConfiguration)
              .Add("--shard-count {value}", ShardCount)
              .Add("--static-ip {value}", StaticIp)
              .Add("--subnet-id {value}", SubnetId)
              .Add("--tags {value}", Tags)
              .Add("--tenant-settings {value}", TenantSettings, separator: ' ')
              .Add("--zones {value}", Zones, separator: ' ')
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
    #region AzureRedisDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
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
        ///   Name of the Redis cache.
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
              .Add("redis delete")
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
    #region AzureRedisExportSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisExportSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   SAS url for container where data needs to be exported to.
        /// </summary>
        public virtual string Container { get; internal set; }
        /// <summary>
        ///   Prefix to use for exported files.
        /// </summary>
        public virtual string Prefix { get; internal set; }
        /// <summary>
        ///   Format of the blob (Currently rdb is the only supported format, with other formats expected in the future).
        /// </summary>
        public virtual string FileFormat { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis export")
              .Add("--container {value}", Container)
              .Add("--prefix {value}", Prefix)
              .Add("--file-format {value}", FileFormat)
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
    #region AzureRedisForceRebootSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisForceRebootSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Which Redis node(s) to reboot. Depending on this value data loss is possible.
        /// </summary>
        public virtual RedisForceRebootRebootType RebootType { get; internal set; }
        /// <summary>
        ///   If clustering is enabled, the ID of the shard to be rebooted.
        /// </summary>
        public virtual string ShardId { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis force-reboot")
              .Add("--reboot-type {value}", RebootType)
              .Add("--shard-id {value}", ShardId)
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
    #region AzureRedisImportSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisImportSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   SAS url for blobs that needs to be imported.
        /// </summary>
        public virtual string Files { get; internal set; }
        /// <summary>
        ///   Format of the blob (Currently rdb is the only supported format, with other formats expected in the future).
        /// </summary>
        public virtual string FileFormat { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis import")
              .Add("--files {value}", Files)
              .Add("--file-format {value}", FileFormat)
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
    #region AzureRedisImportMethodSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisImportMethodSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   SAS url for blobs that needs to be imported.
        /// </summary>
        public virtual string Files { get; internal set; }
        /// <summary>
        ///   Format of the blob (Currently rdb is the only supported format, with other formats expected in the future).
        /// </summary>
        public virtual string FileFormat { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis import-method")
              .Add("--files {value}", Files)
              .Add("--file-format {value}", FileFormat)
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
    #region AzureRedisListSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
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
              .Add("redis list")
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
    #region AzureRedisListKeysSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisListKeysSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis list-keys")
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
    #region AzureRedisRegenerateKeysSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisRegenerateKeysSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   The Redis access key to regenerate.
        /// </summary>
        public virtual RedisRegenerateKeysKeyType KeyType { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis regenerate-keys")
              .Add("--key-type {value}", KeyType)
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
    #region AzureRedisShowSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis show")
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
    #region AzureRedisUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Type of Redis cache.
        /// </summary>
        public virtual RedisSku Sku { get; internal set; }
        /// <summary>
        ///   Size of Redis cache to deploy. Basic and Standard Cache sizes start with C. Premium Cache sizes start with P.
        /// </summary>
        public virtual RedisVmSize VmSize { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis update")
              .Add("--sku {value}", Sku)
              .Add("--vm-size {value}", VmSize)
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
    #region AzureRedisFirewallRulesCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisFirewallRulesCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Highest IP address included in the range.
        /// </summary>
        public virtual string EndIp { get; internal set; }
        /// <summary>
        ///   Name of the Redis cache.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the firewall rule.
        /// </summary>
        public virtual string RuleName { get; internal set; }
        /// <summary>
        ///   Lowest IP address included in the range.
        /// </summary>
        public virtual string StartIp { get; internal set; }
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
              .Add("redis firewall-rules create")
              .Add("--end-ip {value}", EndIp)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--rule-name {value}", RuleName)
              .Add("--start-ip {value}", StartIp)
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
    #region AzureRedisFirewallRulesDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisFirewallRulesDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   The name of the firewall rule.
        /// </summary>
        public virtual string RuleName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis firewall-rules delete")
              .Add("--rule-name {value}", RuleName)
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
    #region AzureRedisFirewallRulesListSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisFirewallRulesListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis firewall-rules list")
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
    #region AzureRedisFirewallRulesShowSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisFirewallRulesShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   The name of the firewall rule.
        /// </summary>
        public virtual string RuleName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis firewall-rules show")
              .Add("--rule-name {value}", RuleName)
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
    #region AzureRedisFirewallRulesUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisFirewallRulesUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Highest IP address included in the range.
        /// </summary>
        public virtual string EndIp { get; internal set; }
        /// <summary>
        ///   The name of the firewall rule.
        /// </summary>
        public virtual string RuleName { get; internal set; }
        /// <summary>
        ///   Lowest IP address included in the range.
        /// </summary>
        public virtual string StartIp { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis firewall-rules update")
              .Add("--end-ip {value}", EndIp)
              .Add("--rule-name {value}", RuleName)
              .Add("--start-ip {value}", StartIp)
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
    #region AzureRedisPatchScheduleCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisPatchScheduleCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Name of the Redis cache.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   List of Patch schedule entries. Example Value:[{"dayOfWeek":"Monday","startHourUtc":"00","maintenanceWindow":"PT5H"}].
        /// </summary>
        public virtual string ScheduleEntries { get; internal set; }
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
              .Add("redis patch-schedule create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--schedule-entries {value}", ScheduleEntries)
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
    #region AzureRedisPatchScheduleDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisPatchScheduleDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis patch-schedule delete")
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
    #region AzureRedisPatchScheduleShowSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisPatchScheduleShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis patch-schedule show")
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
    #region AzureRedisPatchScheduleUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisPatchScheduleUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Name of the Redis cache.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   List of Patch schedule entries. Example Value:[{"dayOfWeek":"Monday","startHourUtc":"00","maintenanceWindow":"PT5H"}].
        /// </summary>
        public virtual string ScheduleEntries { get; internal set; }
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
              .Add("redis patch-schedule update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--schedule-entries {value}", ScheduleEntries)
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
    #region AzureRedisServerLinkCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisServerLinkCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Name of the Redis cache.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Role of the redis cache to be linked.
        /// </summary>
        public virtual RedisRegenerateKeysKeyType ReplicationRole { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Resource ID or name of the redis cache to be linked.
        /// </summary>
        public virtual string ServerToLink { get; internal set; }
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
              .Add("redis server-link create")
              .Add("--name {value}", Name)
              .Add("--replication-role {value}", ReplicationRole)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-to-link {value}", ServerToLink)
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
    #region AzureRedisServerLinkDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisServerLinkDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Name of the linked redis cache.
        /// </summary>
        public virtual string LinkedServerName { get; internal set; }
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis server-link delete")
              .Add("--linked-server-name {value}", LinkedServerName)
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
    #region AzureRedisServerLinkListSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisServerLinkListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis server-link list")
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
    #region AzureRedisServerLinkShowSettings
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisServerLinkShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRedis executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        public override Action<OutputType, string> CustomLogger => AzureRedisTasks.AzureRedisLogger;
        /// <summary>
        ///   Name of the linked redis cache.
        /// </summary>
        public virtual string LinkedServerName { get; internal set; }
        /// <summary>
        ///   Name of the Redis cache.
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
              .Add("redis server-link show")
              .Add("--linked-server-name {value}", LinkedServerName)
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
    #region AzureRedisCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisCreateSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetLocation(this AzureRedisCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetLocation(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetName(this AzureRedisCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetName(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetResourceGroup(this AzureRedisCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetResourceGroup(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.Sku"/></em></p>
        ///   <p>Type of Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetSku(this AzureRedisCreateSettings toolSettings, RedisSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.Sku"/></em></p>
        ///   <p>Type of Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetSku(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region VmSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.VmSize"/></em></p>
        ///   <p>Size of Redis cache to deploy. Basic and Standard Cache sizes start with C. Premium Cache sizes start with P.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetVmSize(this AzureRedisCreateSettings toolSettings, RedisVmSize vmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = vmSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.VmSize"/></em></p>
        ///   <p>Size of Redis cache to deploy. Basic and Standard Cache sizes start with C. Premium Cache sizes start with P.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetVmSize(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = null;
            return toolSettings;
        }
        #endregion
        #region EnableNonSslPort
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.EnableNonSslPort"/></em></p>
        ///   <p>If the value is true, then the non-ssl redis server port (6379) will be enabled.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetEnableNonSslPort(this AzureRedisCreateSettings toolSettings, string enableNonSslPort)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableNonSslPort = enableNonSslPort;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.EnableNonSslPort"/></em></p>
        ///   <p>If the value is true, then the non-ssl redis server port (6379) will be enabled.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetEnableNonSslPort(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableNonSslPort = null;
            return toolSettings;
        }
        #endregion
        #region MinimumTlsVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.MinimumTlsVersion"/></em></p>
        ///   <p>Specifies the TLS version required by clients to connect to cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetMinimumTlsVersion(this AzureRedisCreateSettings toolSettings, RedisCreateMinimumTlsVersion minimumTlsVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinimumTlsVersion = minimumTlsVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.MinimumTlsVersion"/></em></p>
        ///   <p>Specifies the TLS version required by clients to connect to cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetMinimumTlsVersion(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MinimumTlsVersion = null;
            return toolSettings;
        }
        #endregion
        #region RedisConfiguration
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.RedisConfiguration"/></em></p>
        ///   <p>JSON encoded configuration settings. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetRedisConfiguration(this AzureRedisCreateSettings toolSettings, string redisConfiguration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RedisConfiguration = redisConfiguration;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.RedisConfiguration"/></em></p>
        ///   <p>JSON encoded configuration settings. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetRedisConfiguration(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RedisConfiguration = null;
            return toolSettings;
        }
        #endregion
        #region ShardCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.ShardCount"/></em></p>
        ///   <p>The number of shards to be created on a Premium Cluster Cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetShardCount(this AzureRedisCreateSettings toolSettings, string shardCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShardCount = shardCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.ShardCount"/></em></p>
        ///   <p>The number of shards to be created on a Premium Cluster Cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetShardCount(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShardCount = null;
            return toolSettings;
        }
        #endregion
        #region StaticIp
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.StaticIp"/></em></p>
        ///   <p>Specify a static ip if required for the VNET. If you do not specify a static IP then an IP address is chosen automatically.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetStaticIp(this AzureRedisCreateSettings toolSettings, string staticIp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StaticIp = staticIp;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.StaticIp"/></em></p>
        ///   <p>Specify a static ip if required for the VNET. If you do not specify a static IP then an IP address is chosen automatically.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetStaticIp(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StaticIp = null;
            return toolSettings;
        }
        #endregion
        #region SubnetId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.SubnetId"/></em></p>
        ///   <p>The full resource ID of a subnet in a virtual network to deploy the redis cache in. Example format /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetSubnetId(this AzureRedisCreateSettings toolSettings, string subnetId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetId = subnetId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.SubnetId"/></em></p>
        ///   <p>The full resource ID of a subnet in a virtual network to deploy the redis cache in. Example format /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetSubnetId(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetId = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetTags(this AzureRedisCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetTags(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region TenantSettings
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.TenantSettings"/> to a new list</em></p>
        ///   <p>Space-separated tenant settings in key[=value] format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetTenantSettings(this AzureRedisCreateSettings toolSettings, params string[] tenantSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TenantSettingsInternal = tenantSettings.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.TenantSettings"/> to a new list</em></p>
        ///   <p>Space-separated tenant settings in key[=value] format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetTenantSettings(this AzureRedisCreateSettings toolSettings, IEnumerable<string> tenantSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TenantSettingsInternal = tenantSettings.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisCreateSettings.TenantSettings"/></em></p>
        ///   <p>Space-separated tenant settings in key[=value] format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings AddTenantSettings(this AzureRedisCreateSettings toolSettings, params string[] tenantSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TenantSettingsInternal.AddRange(tenantSettings);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisCreateSettings.TenantSettings"/></em></p>
        ///   <p>Space-separated tenant settings in key[=value] format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings AddTenantSettings(this AzureRedisCreateSettings toolSettings, IEnumerable<string> tenantSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TenantSettingsInternal.AddRange(tenantSettings);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisCreateSettings.TenantSettings"/></em></p>
        ///   <p>Space-separated tenant settings in key[=value] format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ClearTenantSettings(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TenantSettingsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisCreateSettings.TenantSettings"/></em></p>
        ///   <p>Space-separated tenant settings in key[=value] format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings RemoveTenantSettings(this AzureRedisCreateSettings toolSettings, params string[] tenantSettings)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(tenantSettings);
            toolSettings.TenantSettingsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisCreateSettings.TenantSettings"/></em></p>
        ///   <p>Space-separated tenant settings in key[=value] format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings RemoveTenantSettings(this AzureRedisCreateSettings toolSettings, IEnumerable<string> tenantSettings)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(tenantSettings);
            toolSettings.TenantSettingsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Zones
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.Zones"/> to a new list</em></p>
        ///   <p>Space-separated list of availability zones into which to provision the resource.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetZones(this AzureRedisCreateSettings toolSettings, params RedisCreateZones[] zones)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZonesInternal = zones.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.Zones"/> to a new list</em></p>
        ///   <p>Space-separated list of availability zones into which to provision the resource.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetZones(this AzureRedisCreateSettings toolSettings, IEnumerable<RedisCreateZones> zones)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZonesInternal = zones.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisCreateSettings.Zones"/></em></p>
        ///   <p>Space-separated list of availability zones into which to provision the resource.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings AddZones(this AzureRedisCreateSettings toolSettings, params RedisCreateZones[] zones)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZonesInternal.AddRange(zones);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisCreateSettings.Zones"/></em></p>
        ///   <p>Space-separated list of availability zones into which to provision the resource.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings AddZones(this AzureRedisCreateSettings toolSettings, IEnumerable<RedisCreateZones> zones)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZonesInternal.AddRange(zones);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisCreateSettings.Zones"/></em></p>
        ///   <p>Space-separated list of availability zones into which to provision the resource.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ClearZones(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZonesInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisCreateSettings.Zones"/></em></p>
        ///   <p>Space-separated list of availability zones into which to provision the resource.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings RemoveZones(this AzureRedisCreateSettings toolSettings, params RedisCreateZones[] zones)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RedisCreateZones>(zones);
            toolSettings.ZonesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisCreateSettings.Zones"/></em></p>
        ///   <p>Space-separated list of availability zones into which to provision the resource.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings RemoveZones(this AzureRedisCreateSettings toolSettings, IEnumerable<RedisCreateZones> zones)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RedisCreateZones>(zones);
            toolSettings.ZonesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetSubscription(this AzureRedisCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetSubscription(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetDebug(this AzureRedisCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetDebug(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetHelp(this AzureRedisCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetHelp(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetOutput(this AzureRedisCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetOutput(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetQuery(this AzureRedisCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetQuery(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings SetVerbose(this AzureRedisCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisCreateSettings ResetVerbose(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisDeleteSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings SetYes(this AzureRedisDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetYes(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings SetIds(this AzureRedisDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings SetIds(this AzureRedisDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings AddIds(this AzureRedisDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings AddIds(this AzureRedisDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings ClearIds(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings RemoveIds(this AzureRedisDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings RemoveIds(this AzureRedisDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisDeleteSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings SetName(this AzureRedisDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisDeleteSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetName(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings SetResourceGroup(this AzureRedisDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetResourceGroup(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings SetSubscription(this AzureRedisDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetSubscription(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings SetDebug(this AzureRedisDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetDebug(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings SetHelp(this AzureRedisDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetHelp(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings SetOutput(this AzureRedisDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetOutput(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings SetQuery(this AzureRedisDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetQuery(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings SetVerbose(this AzureRedisDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetVerbose(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisExportSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisExportSettingsExtensions
    {
        #region Container
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisExportSettings.Container"/></em></p>
        ///   <p>SAS url for container where data needs to be exported to.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings SetContainer(this AzureRedisExportSettings toolSettings, string container)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Container = container;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisExportSettings.Container"/></em></p>
        ///   <p>SAS url for container where data needs to be exported to.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings ResetContainer(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Container = null;
            return toolSettings;
        }
        #endregion
        #region Prefix
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisExportSettings.Prefix"/></em></p>
        ///   <p>Prefix to use for exported files.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings SetPrefix(this AzureRedisExportSettings toolSettings, string prefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Prefix = prefix;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisExportSettings.Prefix"/></em></p>
        ///   <p>Prefix to use for exported files.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings ResetPrefix(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Prefix = null;
            return toolSettings;
        }
        #endregion
        #region FileFormat
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisExportSettings.FileFormat"/></em></p>
        ///   <p>Format of the blob (Currently rdb is the only supported format, with other formats expected in the future).</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings SetFileFormat(this AzureRedisExportSettings toolSettings, string fileFormat)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFormat = fileFormat;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisExportSettings.FileFormat"/></em></p>
        ///   <p>Format of the blob (Currently rdb is the only supported format, with other formats expected in the future).</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings ResetFileFormat(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFormat = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisExportSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings SetIds(this AzureRedisExportSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisExportSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings SetIds(this AzureRedisExportSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings AddIds(this AzureRedisExportSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings AddIds(this AzureRedisExportSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings ClearIds(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings RemoveIds(this AzureRedisExportSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisExportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings RemoveIds(this AzureRedisExportSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisExportSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings SetName(this AzureRedisExportSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisExportSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings ResetName(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisExportSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings SetResourceGroup(this AzureRedisExportSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisExportSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings ResetResourceGroup(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisExportSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings SetSubscription(this AzureRedisExportSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisExportSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings ResetSubscription(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisExportSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings SetDebug(this AzureRedisExportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisExportSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings ResetDebug(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisExportSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings SetHelp(this AzureRedisExportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisExportSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings ResetHelp(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisExportSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings SetOutput(this AzureRedisExportSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisExportSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings ResetOutput(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisExportSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings SetQuery(this AzureRedisExportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisExportSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings ResetQuery(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisExportSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings SetVerbose(this AzureRedisExportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisExportSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisExportSettings ResetVerbose(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisForceRebootSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisForceRebootSettingsExtensions
    {
        #region RebootType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisForceRebootSettings.RebootType"/></em></p>
        ///   <p>Which Redis node(s) to reboot. Depending on this value data loss is possible.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetRebootType(this AzureRedisForceRebootSettings toolSettings, RedisForceRebootRebootType rebootType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RebootType = rebootType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisForceRebootSettings.RebootType"/></em></p>
        ///   <p>Which Redis node(s) to reboot. Depending on this value data loss is possible.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetRebootType(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RebootType = null;
            return toolSettings;
        }
        #endregion
        #region ShardId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisForceRebootSettings.ShardId"/></em></p>
        ///   <p>If clustering is enabled, the ID of the shard to be rebooted.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetShardId(this AzureRedisForceRebootSettings toolSettings, string shardId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShardId = shardId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisForceRebootSettings.ShardId"/></em></p>
        ///   <p>If clustering is enabled, the ID of the shard to be rebooted.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetShardId(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShardId = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisForceRebootSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetIds(this AzureRedisForceRebootSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisForceRebootSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetIds(this AzureRedisForceRebootSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisForceRebootSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings AddIds(this AzureRedisForceRebootSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisForceRebootSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings AddIds(this AzureRedisForceRebootSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisForceRebootSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings ClearIds(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisForceRebootSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings RemoveIds(this AzureRedisForceRebootSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisForceRebootSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings RemoveIds(this AzureRedisForceRebootSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisForceRebootSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetName(this AzureRedisForceRebootSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisForceRebootSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetName(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisForceRebootSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetResourceGroup(this AzureRedisForceRebootSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisForceRebootSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetResourceGroup(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisForceRebootSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetSubscription(this AzureRedisForceRebootSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisForceRebootSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetSubscription(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisForceRebootSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetDebug(this AzureRedisForceRebootSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisForceRebootSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetDebug(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisForceRebootSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetHelp(this AzureRedisForceRebootSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisForceRebootSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetHelp(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisForceRebootSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetOutput(this AzureRedisForceRebootSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisForceRebootSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetOutput(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisForceRebootSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetQuery(this AzureRedisForceRebootSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisForceRebootSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetQuery(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisForceRebootSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetVerbose(this AzureRedisForceRebootSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisForceRebootSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetVerbose(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisImportSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisImportSettingsExtensions
    {
        #region Files
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportSettings.Files"/></em></p>
        ///   <p>SAS url for blobs that needs to be imported.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings SetFiles(this AzureRedisImportSettings toolSettings, string files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Files = files;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportSettings.Files"/></em></p>
        ///   <p>SAS url for blobs that needs to be imported.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings ResetFiles(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Files = null;
            return toolSettings;
        }
        #endregion
        #region FileFormat
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportSettings.FileFormat"/></em></p>
        ///   <p>Format of the blob (Currently rdb is the only supported format, with other formats expected in the future).</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings SetFileFormat(this AzureRedisImportSettings toolSettings, string fileFormat)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFormat = fileFormat;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportSettings.FileFormat"/></em></p>
        ///   <p>Format of the blob (Currently rdb is the only supported format, with other formats expected in the future).</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings ResetFileFormat(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFormat = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings SetIds(this AzureRedisImportSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings SetIds(this AzureRedisImportSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisImportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings AddIds(this AzureRedisImportSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisImportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings AddIds(this AzureRedisImportSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisImportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings ClearIds(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisImportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings RemoveIds(this AzureRedisImportSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisImportSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings RemoveIds(this AzureRedisImportSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings SetName(this AzureRedisImportSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings ResetName(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings SetResourceGroup(this AzureRedisImportSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings ResetResourceGroup(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings SetSubscription(this AzureRedisImportSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings ResetSubscription(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings SetDebug(this AzureRedisImportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings ResetDebug(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings SetHelp(this AzureRedisImportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings ResetHelp(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings SetOutput(this AzureRedisImportSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings ResetOutput(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings SetQuery(this AzureRedisImportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings ResetQuery(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings SetVerbose(this AzureRedisImportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportSettings ResetVerbose(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisImportMethodSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisImportMethodSettingsExtensions
    {
        #region Files
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportMethodSettings.Files"/></em></p>
        ///   <p>SAS url for blobs that needs to be imported.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetFiles(this AzureRedisImportMethodSettings toolSettings, string files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Files = files;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportMethodSettings.Files"/></em></p>
        ///   <p>SAS url for blobs that needs to be imported.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetFiles(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Files = null;
            return toolSettings;
        }
        #endregion
        #region FileFormat
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportMethodSettings.FileFormat"/></em></p>
        ///   <p>Format of the blob (Currently rdb is the only supported format, with other formats expected in the future).</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetFileFormat(this AzureRedisImportMethodSettings toolSettings, string fileFormat)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFormat = fileFormat;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportMethodSettings.FileFormat"/></em></p>
        ///   <p>Format of the blob (Currently rdb is the only supported format, with other formats expected in the future).</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetFileFormat(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFormat = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportMethodSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetIds(this AzureRedisImportMethodSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportMethodSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetIds(this AzureRedisImportMethodSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisImportMethodSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings AddIds(this AzureRedisImportMethodSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisImportMethodSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings AddIds(this AzureRedisImportMethodSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisImportMethodSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings ClearIds(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisImportMethodSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings RemoveIds(this AzureRedisImportMethodSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisImportMethodSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings RemoveIds(this AzureRedisImportMethodSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportMethodSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetName(this AzureRedisImportMethodSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportMethodSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetName(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportMethodSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetResourceGroup(this AzureRedisImportMethodSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportMethodSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetResourceGroup(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportMethodSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetSubscription(this AzureRedisImportMethodSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportMethodSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetSubscription(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportMethodSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetDebug(this AzureRedisImportMethodSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportMethodSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetDebug(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportMethodSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetHelp(this AzureRedisImportMethodSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportMethodSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetHelp(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportMethodSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetOutput(this AzureRedisImportMethodSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportMethodSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetOutput(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportMethodSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetQuery(this AzureRedisImportMethodSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportMethodSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetQuery(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisImportMethodSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetVerbose(this AzureRedisImportMethodSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisImportMethodSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetVerbose(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings SetResourceGroup(this AzureRedisListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings ResetResourceGroup(this AzureRedisListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings SetSubscription(this AzureRedisListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings ResetSubscription(this AzureRedisListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings SetDebug(this AzureRedisListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings ResetDebug(this AzureRedisListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings SetHelp(this AzureRedisListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings ResetHelp(this AzureRedisListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings SetOutput(this AzureRedisListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings ResetOutput(this AzureRedisListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings SetQuery(this AzureRedisListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings ResetQuery(this AzureRedisListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings SetVerbose(this AzureRedisListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListSettings ResetVerbose(this AzureRedisListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisListKeysSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisListKeysSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListKeysSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings SetIds(this AzureRedisListKeysSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListKeysSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings SetIds(this AzureRedisListKeysSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisListKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings AddIds(this AzureRedisListKeysSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisListKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings AddIds(this AzureRedisListKeysSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisListKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings ClearIds(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisListKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings RemoveIds(this AzureRedisListKeysSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisListKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings RemoveIds(this AzureRedisListKeysSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListKeysSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings SetName(this AzureRedisListKeysSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListKeysSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetName(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListKeysSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings SetResourceGroup(this AzureRedisListKeysSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListKeysSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetResourceGroup(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListKeysSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings SetSubscription(this AzureRedisListKeysSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListKeysSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetSubscription(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListKeysSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings SetDebug(this AzureRedisListKeysSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListKeysSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetDebug(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListKeysSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings SetHelp(this AzureRedisListKeysSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListKeysSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetHelp(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListKeysSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings SetOutput(this AzureRedisListKeysSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListKeysSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetOutput(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListKeysSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings SetQuery(this AzureRedisListKeysSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListKeysSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetQuery(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisListKeysSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings SetVerbose(this AzureRedisListKeysSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisListKeysSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetVerbose(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisRegenerateKeysSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisRegenerateKeysSettingsExtensions
    {
        #region KeyType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.KeyType"/></em></p>
        ///   <p>The Redis access key to regenerate.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetKeyType(this AzureRedisRegenerateKeysSettings toolSettings, RedisRegenerateKeysKeyType keyType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = keyType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.KeyType"/></em></p>
        ///   <p>The Redis access key to regenerate.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetKeyType(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetIds(this AzureRedisRegenerateKeysSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetIds(this AzureRedisRegenerateKeysSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisRegenerateKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings AddIds(this AzureRedisRegenerateKeysSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisRegenerateKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings AddIds(this AzureRedisRegenerateKeysSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisRegenerateKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ClearIds(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisRegenerateKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings RemoveIds(this AzureRedisRegenerateKeysSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisRegenerateKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings RemoveIds(this AzureRedisRegenerateKeysSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetName(this AzureRedisRegenerateKeysSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetName(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetResourceGroup(this AzureRedisRegenerateKeysSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetResourceGroup(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetSubscription(this AzureRedisRegenerateKeysSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetSubscription(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetDebug(this AzureRedisRegenerateKeysSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetDebug(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetHelp(this AzureRedisRegenerateKeysSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetHelp(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetOutput(this AzureRedisRegenerateKeysSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetOutput(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetQuery(this AzureRedisRegenerateKeysSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetQuery(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetVerbose(this AzureRedisRegenerateKeysSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetVerbose(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings SetIds(this AzureRedisShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings SetIds(this AzureRedisShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings AddIds(this AzureRedisShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings AddIds(this AzureRedisShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings ClearIds(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings RemoveIds(this AzureRedisShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings RemoveIds(this AzureRedisShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisShowSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings SetName(this AzureRedisShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisShowSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings ResetName(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings SetResourceGroup(this AzureRedisShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings ResetResourceGroup(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings SetSubscription(this AzureRedisShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings ResetSubscription(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings SetDebug(this AzureRedisShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings ResetDebug(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings SetHelp(this AzureRedisShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings ResetHelp(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings SetOutput(this AzureRedisShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings ResetOutput(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings SetQuery(this AzureRedisShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings ResetQuery(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings SetVerbose(this AzureRedisShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisShowSettings ResetVerbose(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisUpdateSettingsExtensions
    {
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.Sku"/></em></p>
        ///   <p>Type of Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetSku(this AzureRedisUpdateSettings toolSettings, RedisSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.Sku"/></em></p>
        ///   <p>Type of Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetSku(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region VmSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.VmSize"/></em></p>
        ///   <p>Size of Redis cache to deploy. Basic and Standard Cache sizes start with C. Premium Cache sizes start with P.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetVmSize(this AzureRedisUpdateSettings toolSettings, RedisVmSize vmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = vmSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.VmSize"/></em></p>
        ///   <p>Size of Redis cache to deploy. Basic and Standard Cache sizes start with C. Premium Cache sizes start with P.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetVmSize(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetIds(this AzureRedisUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetIds(this AzureRedisUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings AddIds(this AzureRedisUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings AddIds(this AzureRedisUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ClearIds(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings RemoveIds(this AzureRedisUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings RemoveIds(this AzureRedisUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetName(this AzureRedisUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetName(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetResourceGroup(this AzureRedisUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetResourceGroup(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetSubscription(this AzureRedisUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetSubscription(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetAdd(this AzureRedisUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetAdd(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetForceString(this AzureRedisUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetForceString(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetRemove(this AzureRedisUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetRemove(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetSet(this AzureRedisUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetSet(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetDebug(this AzureRedisUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetDebug(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetHelp(this AzureRedisUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetHelp(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetOutput(this AzureRedisUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetOutput(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetQuery(this AzureRedisUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetQuery(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings SetVerbose(this AzureRedisUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetVerbose(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisFirewallRulesCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisFirewallRulesCreateSettingsExtensions
    {
        #region EndIp
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesCreateSettings.EndIp"/></em></p>
        ///   <p>Highest IP address included in the range.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings SetEndIp(this AzureRedisFirewallRulesCreateSettings toolSettings, string endIp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIp = endIp;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesCreateSettings.EndIp"/></em></p>
        ///   <p>Highest IP address included in the range.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings ResetEndIp(this AzureRedisFirewallRulesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIp = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesCreateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings SetName(this AzureRedisFirewallRulesCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesCreateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings ResetName(this AzureRedisFirewallRulesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings SetResourceGroup(this AzureRedisFirewallRulesCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings ResetResourceGroup(this AzureRedisFirewallRulesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region RuleName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesCreateSettings.RuleName"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings SetRuleName(this AzureRedisFirewallRulesCreateSettings toolSettings, string ruleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleName = ruleName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesCreateSettings.RuleName"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings ResetRuleName(this AzureRedisFirewallRulesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleName = null;
            return toolSettings;
        }
        #endregion
        #region StartIp
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesCreateSettings.StartIp"/></em></p>
        ///   <p>Lowest IP address included in the range.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings SetStartIp(this AzureRedisFirewallRulesCreateSettings toolSettings, string startIp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIp = startIp;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesCreateSettings.StartIp"/></em></p>
        ///   <p>Lowest IP address included in the range.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings ResetStartIp(this AzureRedisFirewallRulesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIp = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings SetSubscription(this AzureRedisFirewallRulesCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings ResetSubscription(this AzureRedisFirewallRulesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings SetDebug(this AzureRedisFirewallRulesCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings ResetDebug(this AzureRedisFirewallRulesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings SetHelp(this AzureRedisFirewallRulesCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings ResetHelp(this AzureRedisFirewallRulesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings SetOutput(this AzureRedisFirewallRulesCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings ResetOutput(this AzureRedisFirewallRulesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings SetQuery(this AzureRedisFirewallRulesCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings ResetQuery(this AzureRedisFirewallRulesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings SetVerbose(this AzureRedisFirewallRulesCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesCreateSettings ResetVerbose(this AzureRedisFirewallRulesCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisFirewallRulesDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisFirewallRulesDeleteSettingsExtensions
    {
        #region RuleName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesDeleteSettings.RuleName"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings SetRuleName(this AzureRedisFirewallRulesDeleteSettings toolSettings, string ruleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleName = ruleName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesDeleteSettings.RuleName"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings ResetRuleName(this AzureRedisFirewallRulesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings SetIds(this AzureRedisFirewallRulesDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings SetIds(this AzureRedisFirewallRulesDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisFirewallRulesDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings AddIds(this AzureRedisFirewallRulesDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisFirewallRulesDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings AddIds(this AzureRedisFirewallRulesDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisFirewallRulesDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings ClearIds(this AzureRedisFirewallRulesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisFirewallRulesDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings RemoveIds(this AzureRedisFirewallRulesDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisFirewallRulesDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings RemoveIds(this AzureRedisFirewallRulesDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesDeleteSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings SetName(this AzureRedisFirewallRulesDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesDeleteSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings ResetName(this AzureRedisFirewallRulesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings SetResourceGroup(this AzureRedisFirewallRulesDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings ResetResourceGroup(this AzureRedisFirewallRulesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings SetSubscription(this AzureRedisFirewallRulesDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings ResetSubscription(this AzureRedisFirewallRulesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings SetDebug(this AzureRedisFirewallRulesDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings ResetDebug(this AzureRedisFirewallRulesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings SetHelp(this AzureRedisFirewallRulesDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings ResetHelp(this AzureRedisFirewallRulesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings SetOutput(this AzureRedisFirewallRulesDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings ResetOutput(this AzureRedisFirewallRulesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings SetQuery(this AzureRedisFirewallRulesDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings ResetQuery(this AzureRedisFirewallRulesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings SetVerbose(this AzureRedisFirewallRulesDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesDeleteSettings ResetVerbose(this AzureRedisFirewallRulesDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisFirewallRulesListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisFirewallRulesListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesListSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings SetName(this AzureRedisFirewallRulesListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesListSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings ResetName(this AzureRedisFirewallRulesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings SetResourceGroup(this AzureRedisFirewallRulesListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings ResetResourceGroup(this AzureRedisFirewallRulesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings SetSubscription(this AzureRedisFirewallRulesListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings ResetSubscription(this AzureRedisFirewallRulesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings SetDebug(this AzureRedisFirewallRulesListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings ResetDebug(this AzureRedisFirewallRulesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings SetHelp(this AzureRedisFirewallRulesListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings ResetHelp(this AzureRedisFirewallRulesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings SetOutput(this AzureRedisFirewallRulesListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings ResetOutput(this AzureRedisFirewallRulesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings SetQuery(this AzureRedisFirewallRulesListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings ResetQuery(this AzureRedisFirewallRulesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings SetVerbose(this AzureRedisFirewallRulesListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesListSettings ResetVerbose(this AzureRedisFirewallRulesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisFirewallRulesShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisFirewallRulesShowSettingsExtensions
    {
        #region RuleName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesShowSettings.RuleName"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings SetRuleName(this AzureRedisFirewallRulesShowSettings toolSettings, string ruleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleName = ruleName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesShowSettings.RuleName"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings ResetRuleName(this AzureRedisFirewallRulesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings SetIds(this AzureRedisFirewallRulesShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings SetIds(this AzureRedisFirewallRulesShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisFirewallRulesShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings AddIds(this AzureRedisFirewallRulesShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisFirewallRulesShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings AddIds(this AzureRedisFirewallRulesShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisFirewallRulesShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings ClearIds(this AzureRedisFirewallRulesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisFirewallRulesShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings RemoveIds(this AzureRedisFirewallRulesShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisFirewallRulesShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings RemoveIds(this AzureRedisFirewallRulesShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesShowSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings SetName(this AzureRedisFirewallRulesShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesShowSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings ResetName(this AzureRedisFirewallRulesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings SetResourceGroup(this AzureRedisFirewallRulesShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings ResetResourceGroup(this AzureRedisFirewallRulesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings SetSubscription(this AzureRedisFirewallRulesShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings ResetSubscription(this AzureRedisFirewallRulesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings SetDebug(this AzureRedisFirewallRulesShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings ResetDebug(this AzureRedisFirewallRulesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings SetHelp(this AzureRedisFirewallRulesShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings ResetHelp(this AzureRedisFirewallRulesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings SetOutput(this AzureRedisFirewallRulesShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings ResetOutput(this AzureRedisFirewallRulesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings SetQuery(this AzureRedisFirewallRulesShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings ResetQuery(this AzureRedisFirewallRulesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings SetVerbose(this AzureRedisFirewallRulesShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesShowSettings ResetVerbose(this AzureRedisFirewallRulesShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisFirewallRulesUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisFirewallRulesUpdateSettingsExtensions
    {
        #region EndIp
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesUpdateSettings.EndIp"/></em></p>
        ///   <p>Highest IP address included in the range.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings SetEndIp(this AzureRedisFirewallRulesUpdateSettings toolSettings, string endIp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIp = endIp;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesUpdateSettings.EndIp"/></em></p>
        ///   <p>Highest IP address included in the range.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings ResetEndIp(this AzureRedisFirewallRulesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIp = null;
            return toolSettings;
        }
        #endregion
        #region RuleName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesUpdateSettings.RuleName"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings SetRuleName(this AzureRedisFirewallRulesUpdateSettings toolSettings, string ruleName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleName = ruleName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesUpdateSettings.RuleName"/></em></p>
        ///   <p>The name of the firewall rule.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings ResetRuleName(this AzureRedisFirewallRulesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RuleName = null;
            return toolSettings;
        }
        #endregion
        #region StartIp
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesUpdateSettings.StartIp"/></em></p>
        ///   <p>Lowest IP address included in the range.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings SetStartIp(this AzureRedisFirewallRulesUpdateSettings toolSettings, string startIp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIp = startIp;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesUpdateSettings.StartIp"/></em></p>
        ///   <p>Lowest IP address included in the range.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings ResetStartIp(this AzureRedisFirewallRulesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIp = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings SetIds(this AzureRedisFirewallRulesUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings SetIds(this AzureRedisFirewallRulesUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisFirewallRulesUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings AddIds(this AzureRedisFirewallRulesUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRedisFirewallRulesUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings AddIds(this AzureRedisFirewallRulesUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRedisFirewallRulesUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings ClearIds(this AzureRedisFirewallRulesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisFirewallRulesUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings RemoveIds(this AzureRedisFirewallRulesUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRedisFirewallRulesUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings RemoveIds(this AzureRedisFirewallRulesUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesUpdateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings SetName(this AzureRedisFirewallRulesUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesUpdateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings ResetName(this AzureRedisFirewallRulesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings SetResourceGroup(this AzureRedisFirewallRulesUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings ResetResourceGroup(this AzureRedisFirewallRulesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings SetSubscription(this AzureRedisFirewallRulesUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings ResetSubscription(this AzureRedisFirewallRulesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings SetDebug(this AzureRedisFirewallRulesUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings ResetDebug(this AzureRedisFirewallRulesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings SetHelp(this AzureRedisFirewallRulesUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings ResetHelp(this AzureRedisFirewallRulesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings SetOutput(this AzureRedisFirewallRulesUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings ResetOutput(this AzureRedisFirewallRulesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings SetQuery(this AzureRedisFirewallRulesUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings ResetQuery(this AzureRedisFirewallRulesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisFirewallRulesUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings SetVerbose(this AzureRedisFirewallRulesUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisFirewallRulesUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisFirewallRulesUpdateSettings ResetVerbose(this AzureRedisFirewallRulesUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisPatchScheduleCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisPatchScheduleCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleCreateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings SetName(this AzureRedisPatchScheduleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleCreateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings ResetName(this AzureRedisPatchScheduleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings SetResourceGroup(this AzureRedisPatchScheduleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings ResetResourceGroup(this AzureRedisPatchScheduleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ScheduleEntries
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleCreateSettings.ScheduleEntries"/></em></p>
        ///   <p>List of Patch schedule entries. Example Value:[{"dayOfWeek":"Monday","startHourUtc":"00","maintenanceWindow":"PT5H"}].</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings SetScheduleEntries(this AzureRedisPatchScheduleCreateSettings toolSettings, string scheduleEntries)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScheduleEntries = scheduleEntries;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleCreateSettings.ScheduleEntries"/></em></p>
        ///   <p>List of Patch schedule entries. Example Value:[{"dayOfWeek":"Monday","startHourUtc":"00","maintenanceWindow":"PT5H"}].</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings ResetScheduleEntries(this AzureRedisPatchScheduleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScheduleEntries = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings SetSubscription(this AzureRedisPatchScheduleCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings ResetSubscription(this AzureRedisPatchScheduleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings SetDebug(this AzureRedisPatchScheduleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings ResetDebug(this AzureRedisPatchScheduleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings SetHelp(this AzureRedisPatchScheduleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings ResetHelp(this AzureRedisPatchScheduleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings SetOutput(this AzureRedisPatchScheduleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings ResetOutput(this AzureRedisPatchScheduleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings SetQuery(this AzureRedisPatchScheduleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings ResetQuery(this AzureRedisPatchScheduleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings SetVerbose(this AzureRedisPatchScheduleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleCreateSettings ResetVerbose(this AzureRedisPatchScheduleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisPatchScheduleDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisPatchScheduleDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetName(this AzureRedisPatchScheduleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetName(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetResourceGroup(this AzureRedisPatchScheduleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetResourceGroup(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetSubscription(this AzureRedisPatchScheduleDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetSubscription(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetDebug(this AzureRedisPatchScheduleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetDebug(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetHelp(this AzureRedisPatchScheduleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetHelp(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetOutput(this AzureRedisPatchScheduleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetOutput(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetQuery(this AzureRedisPatchScheduleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetQuery(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetVerbose(this AzureRedisPatchScheduleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetVerbose(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisPatchScheduleShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisPatchScheduleShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetName(this AzureRedisPatchScheduleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetName(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetResourceGroup(this AzureRedisPatchScheduleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetResourceGroup(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetSubscription(this AzureRedisPatchScheduleShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetSubscription(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetDebug(this AzureRedisPatchScheduleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetDebug(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetHelp(this AzureRedisPatchScheduleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetHelp(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetOutput(this AzureRedisPatchScheduleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetOutput(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetQuery(this AzureRedisPatchScheduleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetQuery(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetVerbose(this AzureRedisPatchScheduleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetVerbose(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisPatchScheduleUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisPatchScheduleUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleUpdateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings SetName(this AzureRedisPatchScheduleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleUpdateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings ResetName(this AzureRedisPatchScheduleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings SetResourceGroup(this AzureRedisPatchScheduleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings ResetResourceGroup(this AzureRedisPatchScheduleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ScheduleEntries
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleUpdateSettings.ScheduleEntries"/></em></p>
        ///   <p>List of Patch schedule entries. Example Value:[{"dayOfWeek":"Monday","startHourUtc":"00","maintenanceWindow":"PT5H"}].</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings SetScheduleEntries(this AzureRedisPatchScheduleUpdateSettings toolSettings, string scheduleEntries)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScheduleEntries = scheduleEntries;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleUpdateSettings.ScheduleEntries"/></em></p>
        ///   <p>List of Patch schedule entries. Example Value:[{"dayOfWeek":"Monday","startHourUtc":"00","maintenanceWindow":"PT5H"}].</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings ResetScheduleEntries(this AzureRedisPatchScheduleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScheduleEntries = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings SetSubscription(this AzureRedisPatchScheduleUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings ResetSubscription(this AzureRedisPatchScheduleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings SetDebug(this AzureRedisPatchScheduleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings ResetDebug(this AzureRedisPatchScheduleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings SetHelp(this AzureRedisPatchScheduleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings ResetHelp(this AzureRedisPatchScheduleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings SetOutput(this AzureRedisPatchScheduleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings ResetOutput(this AzureRedisPatchScheduleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings SetQuery(this AzureRedisPatchScheduleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings ResetQuery(this AzureRedisPatchScheduleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisPatchScheduleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings SetVerbose(this AzureRedisPatchScheduleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisPatchScheduleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisPatchScheduleUpdateSettings ResetVerbose(this AzureRedisPatchScheduleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisServerLinkCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisServerLinkCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkCreateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings SetName(this AzureRedisServerLinkCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkCreateSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings ResetName(this AzureRedisServerLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ReplicationRole
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkCreateSettings.ReplicationRole"/></em></p>
        ///   <p>Role of the redis cache to be linked.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings SetReplicationRole(this AzureRedisServerLinkCreateSettings toolSettings, RedisRegenerateKeysKeyType replicationRole)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplicationRole = replicationRole;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkCreateSettings.ReplicationRole"/></em></p>
        ///   <p>Role of the redis cache to be linked.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings ResetReplicationRole(this AzureRedisServerLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplicationRole = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings SetResourceGroup(this AzureRedisServerLinkCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings ResetResourceGroup(this AzureRedisServerLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerToLink
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkCreateSettings.ServerToLink"/></em></p>
        ///   <p>Resource ID or name of the redis cache to be linked.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings SetServerToLink(this AzureRedisServerLinkCreateSettings toolSettings, string serverToLink)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerToLink = serverToLink;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkCreateSettings.ServerToLink"/></em></p>
        ///   <p>Resource ID or name of the redis cache to be linked.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings ResetServerToLink(this AzureRedisServerLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerToLink = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings SetSubscription(this AzureRedisServerLinkCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings ResetSubscription(this AzureRedisServerLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings SetDebug(this AzureRedisServerLinkCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings ResetDebug(this AzureRedisServerLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings SetHelp(this AzureRedisServerLinkCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings ResetHelp(this AzureRedisServerLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings SetOutput(this AzureRedisServerLinkCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings ResetOutput(this AzureRedisServerLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings SetQuery(this AzureRedisServerLinkCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings ResetQuery(this AzureRedisServerLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings SetVerbose(this AzureRedisServerLinkCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkCreateSettings ResetVerbose(this AzureRedisServerLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisServerLinkDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisServerLinkDeleteSettingsExtensions
    {
        #region LinkedServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkDeleteSettings.LinkedServerName"/></em></p>
        ///   <p>Name of the linked redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings SetLinkedServerName(this AzureRedisServerLinkDeleteSettings toolSettings, string linkedServerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkedServerName = linkedServerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkDeleteSettings.LinkedServerName"/></em></p>
        ///   <p>Name of the linked redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings ResetLinkedServerName(this AzureRedisServerLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkedServerName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkDeleteSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings SetName(this AzureRedisServerLinkDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkDeleteSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings ResetName(this AzureRedisServerLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings SetResourceGroup(this AzureRedisServerLinkDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings ResetResourceGroup(this AzureRedisServerLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings SetSubscription(this AzureRedisServerLinkDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings ResetSubscription(this AzureRedisServerLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings SetDebug(this AzureRedisServerLinkDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings ResetDebug(this AzureRedisServerLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings SetHelp(this AzureRedisServerLinkDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings ResetHelp(this AzureRedisServerLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings SetOutput(this AzureRedisServerLinkDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings ResetOutput(this AzureRedisServerLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings SetQuery(this AzureRedisServerLinkDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings ResetQuery(this AzureRedisServerLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings SetVerbose(this AzureRedisServerLinkDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkDeleteSettings ResetVerbose(this AzureRedisServerLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisServerLinkListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisServerLinkListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkListSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings SetName(this AzureRedisServerLinkListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkListSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings ResetName(this AzureRedisServerLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings SetResourceGroup(this AzureRedisServerLinkListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings ResetResourceGroup(this AzureRedisServerLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings SetSubscription(this AzureRedisServerLinkListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings ResetSubscription(this AzureRedisServerLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings SetDebug(this AzureRedisServerLinkListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings ResetDebug(this AzureRedisServerLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings SetHelp(this AzureRedisServerLinkListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings ResetHelp(this AzureRedisServerLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings SetOutput(this AzureRedisServerLinkListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings ResetOutput(this AzureRedisServerLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings SetQuery(this AzureRedisServerLinkListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings ResetQuery(this AzureRedisServerLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings SetVerbose(this AzureRedisServerLinkListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkListSettings ResetVerbose(this AzureRedisServerLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisServerLinkShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisServerLinkShowSettingsExtensions
    {
        #region LinkedServerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkShowSettings.LinkedServerName"/></em></p>
        ///   <p>Name of the linked redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings SetLinkedServerName(this AzureRedisServerLinkShowSettings toolSettings, string linkedServerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkedServerName = linkedServerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkShowSettings.LinkedServerName"/></em></p>
        ///   <p>Name of the linked redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings ResetLinkedServerName(this AzureRedisServerLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkedServerName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkShowSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings SetName(this AzureRedisServerLinkShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkShowSettings.Name"/></em></p>
        ///   <p>Name of the Redis cache.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings ResetName(this AzureRedisServerLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings SetResourceGroup(this AzureRedisServerLinkShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings ResetResourceGroup(this AzureRedisServerLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings SetSubscription(this AzureRedisServerLinkShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings ResetSubscription(this AzureRedisServerLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings SetDebug(this AzureRedisServerLinkShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings ResetDebug(this AzureRedisServerLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings SetHelp(this AzureRedisServerLinkShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings ResetHelp(this AzureRedisServerLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings SetOutput(this AzureRedisServerLinkShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings ResetOutput(this AzureRedisServerLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings SetQuery(this AzureRedisServerLinkShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings ResetQuery(this AzureRedisServerLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRedisServerLinkShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings SetVerbose(this AzureRedisServerLinkShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRedisServerLinkShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRedisServerLinkShowSettings ResetVerbose(this AzureRedisServerLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region RedisSku
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<RedisSku>))]
    public partial class RedisSku : Enumeration
    {
        public static RedisSku basic = new RedisSku { Value = "basic" };
        public static RedisSku premium = new RedisSku { Value = "premium" };
        public static RedisSku standard = new RedisSku { Value = "standard" };
    }
    #endregion
    #region RedisVmSize
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<RedisVmSize>))]
    public partial class RedisVmSize : Enumeration
    {
        public static RedisVmSize c0 = new RedisVmSize { Value = "c0" };
        public static RedisVmSize c1 = new RedisVmSize { Value = "c1" };
        public static RedisVmSize c2 = new RedisVmSize { Value = "c2" };
        public static RedisVmSize c3 = new RedisVmSize { Value = "c3" };
        public static RedisVmSize c4 = new RedisVmSize { Value = "c4" };
        public static RedisVmSize c5 = new RedisVmSize { Value = "c5" };
        public static RedisVmSize c6 = new RedisVmSize { Value = "c6" };
        public static RedisVmSize p1 = new RedisVmSize { Value = "p1" };
        public static RedisVmSize p2 = new RedisVmSize { Value = "p2" };
        public static RedisVmSize p3 = new RedisVmSize { Value = "p3" };
        public static RedisVmSize p4 = new RedisVmSize { Value = "p4" };
        public static RedisVmSize p5 = new RedisVmSize { Value = "p5" };
    }
    #endregion
    #region RedisCreateMinimumTlsVersion
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<RedisCreateMinimumTlsVersion>))]
    public partial class RedisCreateMinimumTlsVersion : Enumeration
    {
        public static RedisCreateMinimumTlsVersion _1_0 = new RedisCreateMinimumTlsVersion { Value = "1.0" };
        public static RedisCreateMinimumTlsVersion _1_1 = new RedisCreateMinimumTlsVersion { Value = "1.1" };
        public static RedisCreateMinimumTlsVersion _1_2 = new RedisCreateMinimumTlsVersion { Value = "1.2" };
    }
    #endregion
    #region RedisCreateZones
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<RedisCreateZones>))]
    public partial class RedisCreateZones : Enumeration
    {
        public static RedisCreateZones _1 = new RedisCreateZones { Value = "1" };
        public static RedisCreateZones _2 = new RedisCreateZones { Value = "2" };
        public static RedisCreateZones _3 = new RedisCreateZones { Value = "3" };
    }
    #endregion
    #region RedisForceRebootRebootType
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<RedisForceRebootRebootType>))]
    public partial class RedisForceRebootRebootType : Enumeration
    {
        public static RedisForceRebootRebootType allnodes = new RedisForceRebootRebootType { Value = "allnodes" };
        public static RedisForceRebootRebootType primarynode = new RedisForceRebootRebootType { Value = "primarynode" };
        public static RedisForceRebootRebootType secondarynode = new RedisForceRebootRebootType { Value = "secondarynode" };
    }
    #endregion
    #region RedisRegenerateKeysKeyType
    /// <summary>
    ///   Used within <see cref="AzureRedisTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<RedisRegenerateKeysKeyType>))]
    public partial class RedisRegenerateKeysKeyType : Enumeration
    {
        public static RedisRegenerateKeysKeyType primary = new RedisRegenerateKeysKeyType { Value = "primary" };
        public static RedisRegenerateKeysKeyType secondary = new RedisRegenerateKeysKeyType { Value = "secondary" };
    }
    #endregion
}
