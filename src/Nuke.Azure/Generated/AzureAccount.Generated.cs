// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAccount.json
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
    public static partial class AzureAccountTasks
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public static string AzureAccountPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREACCOUNT_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureAccountLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure subscription information.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccount(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureAccountPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureAccountLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountClear(AzureAccountClearSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountClearSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountClearSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountClearSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountClearSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountClearSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountClearSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountClearSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountClear(Configure<AzureAccountClearSettings> configurator)
        {
            return AzureAccountClear(configurator(new AzureAccountClearSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountClearSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountClearSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountClearSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountClearSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountClearSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountClearSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountClearSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountClear(CombinatorialConfigure<AzureAccountClearSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountClear, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountGetAccessToken(AzureAccountGetAccessTokenSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountGetAccessTokenSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountGetAccessTokenSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountGetAccessTokenSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountGetAccessTokenSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountGetAccessTokenSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureAccountGetAccessTokenSettings.Resource"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountGetAccessTokenSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountGetAccessTokenSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountGetAccessToken(Configure<AzureAccountGetAccessTokenSettings> configurator)
        {
            return AzureAccountGetAccessToken(configurator(new AzureAccountGetAccessTokenSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountGetAccessTokenSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountGetAccessTokenSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountGetAccessTokenSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountGetAccessTokenSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureAccountGetAccessTokenSettings.Resource"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountGetAccessTokenSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountGetAccessTokenSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountGetAccessTokenSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountGetAccessToken(CombinatorialConfigure<AzureAccountGetAccessTokenSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountGetAccessToken, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountList(AzureAccountListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--all</c> via <see cref="AzureAccountListSettings.All"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAccountListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountListSettings.Query"/></li>
        ///     <li><c>--refresh</c> via <see cref="AzureAccountListSettings.Refresh"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountList(Configure<AzureAccountListSettings> configurator)
        {
            return AzureAccountList(configurator(new AzureAccountListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--all</c> via <see cref="AzureAccountListSettings.All"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAccountListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountListSettings.Query"/></li>
        ///     <li><c>--refresh</c> via <see cref="AzureAccountListSettings.Refresh"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountList(CombinatorialConfigure<AzureAccountListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountList, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountListLocations(AzureAccountListLocationsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountListLocationsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountListLocationsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountListLocationsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountListLocationsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountListLocationsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountListLocationsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountListLocationsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountListLocations(Configure<AzureAccountListLocationsSettings> configurator)
        {
            return AzureAccountListLocations(configurator(new AzureAccountListLocationsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountListLocationsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountListLocationsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountListLocationsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountListLocationsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountListLocationsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountListLocationsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountListLocationsSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountListLocations(CombinatorialConfigure<AzureAccountListLocationsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountListLocations, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountSet(AzureAccountSetSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountSetSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountSetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountSetSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountSetSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountSetSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountSetSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountSetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountSet(Configure<AzureAccountSetSettings> configurator)
        {
            return AzureAccountSet(configurator(new AzureAccountSetSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountSetSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountSetSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountSetSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountSetSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountSetSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountSetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountSetSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountSet(CombinatorialConfigure<AzureAccountSetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountSet, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountShow(AzureAccountShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountShowSettings.Query"/></li>
        ///     <li><c>--sdk-auth</c> via <see cref="AzureAccountShowSettings.SdkAuth"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountShow(Configure<AzureAccountShowSettings> configurator)
        {
            return AzureAccountShow(configurator(new AzureAccountShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountShowSettings.Query"/></li>
        ///     <li><c>--sdk-auth</c> via <see cref="AzureAccountShowSettings.SdkAuth"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountShow(CombinatorialConfigure<AzureAccountShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountShow, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountLockCreate(AzureAccountLockCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountLockCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountLockCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountLockCreateSettings.Help"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureAccountLockCreateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountLockCreateSettings.Name"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureAccountLockCreateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountLockCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountLockCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountLockCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountLockCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountLockCreate(Configure<AzureAccountLockCreateSettings> configurator)
        {
            return AzureAccountLockCreate(configurator(new AzureAccountLockCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountLockCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountLockCreateSettings.Help"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureAccountLockCreateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountLockCreateSettings.Name"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureAccountLockCreateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountLockCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountLockCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountLockCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountLockCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountLockCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountLockCreate(CombinatorialConfigure<AzureAccountLockCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountLockCreate, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountLockDelete(AzureAccountLockDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountLockDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountLockDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountLockDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAccountLockDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountLockDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountLockDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountLockDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountLockDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountLockDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountLockDelete(Configure<AzureAccountLockDeleteSettings> configurator)
        {
            return AzureAccountLockDelete(configurator(new AzureAccountLockDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountLockDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountLockDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAccountLockDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountLockDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountLockDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountLockDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountLockDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountLockDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountLockDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountLockDelete(CombinatorialConfigure<AzureAccountLockDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountLockDelete, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountLockList(AzureAccountLockListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountLockListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountLockListSettings.Debug"/></li>
        ///     <li><c>--filter-string</c> via <see cref="AzureAccountLockListSettings.FilterString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountLockListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountLockListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountLockListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountLockListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountLockListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountLockList(Configure<AzureAccountLockListSettings> configurator)
        {
            return AzureAccountLockList(configurator(new AzureAccountLockListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountLockListSettings.Debug"/></li>
        ///     <li><c>--filter-string</c> via <see cref="AzureAccountLockListSettings.FilterString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountLockListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountLockListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountLockListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountLockListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountLockListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountLockListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountLockList(CombinatorialConfigure<AzureAccountLockListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountLockList, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountLockShow(AzureAccountLockShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountLockShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountLockShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountLockShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAccountLockShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountLockShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountLockShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountLockShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountLockShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountLockShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountLockShow(Configure<AzureAccountLockShowSettings> configurator)
        {
            return AzureAccountLockShow(configurator(new AzureAccountLockShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountLockShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountLockShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAccountLockShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountLockShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountLockShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountLockShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountLockShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountLockShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountLockShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountLockShow(CombinatorialConfigure<AzureAccountLockShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountLockShow, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountLockUpdate(AzureAccountLockUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountLockUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountLockUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountLockUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAccountLockUpdateSettings.Ids"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureAccountLockUpdateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountLockUpdateSettings.Name"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureAccountLockUpdateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountLockUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountLockUpdateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountLockUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountLockUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountLockUpdate(Configure<AzureAccountLockUpdateSettings> configurator)
        {
            return AzureAccountLockUpdate(configurator(new AzureAccountLockUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountLockUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountLockUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAccountLockUpdateSettings.Ids"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureAccountLockUpdateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountLockUpdateSettings.Name"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureAccountLockUpdateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountLockUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountLockUpdateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountLockUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountLockUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountLockUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountLockUpdate(CombinatorialConfigure<AzureAccountLockUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountLockUpdate, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupCreate(AzureAccountManagementGroupCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountManagementGroupCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupCreateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAccountManagementGroupCreateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountManagementGroupCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupCreateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureAccountManagementGroupCreateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupCreate(Configure<AzureAccountManagementGroupCreateSettings> configurator)
        {
            return AzureAccountManagementGroupCreate(configurator(new AzureAccountManagementGroupCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupCreateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAccountManagementGroupCreateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountManagementGroupCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupCreateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureAccountManagementGroupCreateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountManagementGroupCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountManagementGroupCreate(CombinatorialConfigure<AzureAccountManagementGroupCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountManagementGroupCreate, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupDelete(AzureAccountManagementGroupDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountManagementGroupDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupDelete(Configure<AzureAccountManagementGroupDeleteSettings> configurator)
        {
            return AzureAccountManagementGroupDelete(configurator(new AzureAccountManagementGroupDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountManagementGroupDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountManagementGroupDelete(CombinatorialConfigure<AzureAccountManagementGroupDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountManagementGroupDelete, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupList(AzureAccountManagementGroupListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountManagementGroupListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupList(Configure<AzureAccountManagementGroupListSettings> configurator)
        {
            return AzureAccountManagementGroupList(configurator(new AzureAccountManagementGroupListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountManagementGroupListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountManagementGroupList(CombinatorialConfigure<AzureAccountManagementGroupListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountManagementGroupList, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupShow(AzureAccountManagementGroupShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountManagementGroupShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupShowSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureAccountManagementGroupShowSettings.Expand"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountManagementGroupShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupShowSettings.Query"/></li>
        ///     <li><c>--recurse</c> via <see cref="AzureAccountManagementGroupShowSettings.Recurse"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupShow(Configure<AzureAccountManagementGroupShowSettings> configurator)
        {
            return AzureAccountManagementGroupShow(configurator(new AzureAccountManagementGroupShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupShowSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureAccountManagementGroupShowSettings.Expand"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountManagementGroupShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupShowSettings.Query"/></li>
        ///     <li><c>--recurse</c> via <see cref="AzureAccountManagementGroupShowSettings.Recurse"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountManagementGroupShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountManagementGroupShow(CombinatorialConfigure<AzureAccountManagementGroupShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountManagementGroupShow, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupUpdate(AzureAccountManagementGroupUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountManagementGroupUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAccountManagementGroupUpdateSettings.DisplayName"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureAccountManagementGroupUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Remove"/></li>
        ///     <li><c>--set</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupUpdate(Configure<AzureAccountManagementGroupUpdateSettings> configurator)
        {
            return AzureAccountManagementGroupUpdate(configurator(new AzureAccountManagementGroupUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAccountManagementGroupUpdateSettings.DisplayName"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureAccountManagementGroupUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Remove"/></li>
        ///     <li><c>--set</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountManagementGroupUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountManagementGroupUpdate(CombinatorialConfigure<AzureAccountManagementGroupUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountManagementGroupUpdate, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupSubscriptionAdd(AzureAccountManagementGroupSubscriptionAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountManagementGroupSubscriptionAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupSubscriptionAdd(Configure<AzureAccountManagementGroupSubscriptionAddSettings> configurator)
        {
            return AzureAccountManagementGroupSubscriptionAdd(configurator(new AzureAccountManagementGroupSubscriptionAddSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountManagementGroupSubscriptionAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountManagementGroupSubscriptionAdd(CombinatorialConfigure<AzureAccountManagementGroupSubscriptionAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountManagementGroupSubscriptionAdd, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupSubscriptionRemove(AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAccountManagementGroupSubscriptionRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAccountManagementGroupSubscriptionRemove(Configure<AzureAccountManagementGroupSubscriptionRemoveSettings> configurator)
        {
            return AzureAccountManagementGroupSubscriptionRemove(configurator(new AzureAccountManagementGroupSubscriptionRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure subscription information.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAccountManagementGroupSubscriptionRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureAccountManagementGroupSubscriptionRemove(CombinatorialConfigure<AzureAccountManagementGroupSubscriptionRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAccountManagementGroupSubscriptionRemove, AzureAccountLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureAccountClearSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountClearSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
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
              .Add("account clear")
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
    #region AzureAccountGetAccessTokenSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountGetAccessTokenSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
        /// <summary>
        ///   Azure resource endpoints. Default to Azure Resource Manager Use 'az cloud show' command for other Azure resources.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription.
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
              .Add("account get-access-token")
              .Add("--resource {value}", Resource)
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
    #region AzureAccountListSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
        /// <summary>
        ///   List all subscriptions, rather just 'Enabled' ones.
        /// </summary>
        public virtual string All { get; internal set; }
        /// <summary>
        ///   Retrieve up-to-date subscriptions from server.
        /// </summary>
        public virtual string Refresh { get; internal set; }
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
              .Add("account list")
              .Add("--all {value}", All)
              .Add("--refresh {value}", Refresh)
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
    #region AzureAccountListLocationsSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountListLocationsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
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
              .Add("account list-locations")
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
    #region AzureAccountSetSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountSetSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
        /// <summary>
        ///   Name or ID of subscription.
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
              .Add("account set")
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
    #region AzureAccountShowSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
        /// <summary>
        ///   Output result to a file compatible with Azure SDK auth. Only applicable when authenticating with a Service Principal.
        /// </summary>
        public virtual string SdkAuth { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription.
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
              .Add("account show")
              .Add("--sdk-auth {value}", SdkAuth)
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
    #region AzureAccountLockCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountLockCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
        /// <summary>
        ///   The type of lock restriction.
        /// </summary>
        public virtual AccountLockLockType LockType { get; internal set; }
        /// <summary>
        ///   Name of the lock.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Notes about this lock.
        /// </summary>
        public virtual string Notes { get; internal set; }
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
              .Add("account lock create")
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
              .Add("--notes {value}", Notes)
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
    #region AzureAccountLockDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountLockDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
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
              .Add("account lock delete")
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
    #region AzureAccountLockListSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountLockListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
        /// <summary>
        ///   A query filter to use to restrict the results.
        /// </summary>
        public virtual string FilterString { get; internal set; }
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
              .Add("account lock list")
              .Add("--filter-string {value}", FilterString)
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
    #region AzureAccountLockShowSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountLockShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
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
              .Add("account lock show")
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
    #region AzureAccountLockUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountLockUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The type of lock restriction.
        /// </summary>
        public virtual AccountLockLockType LockType { get; internal set; }
        /// <summary>
        ///   Name of the lock.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Notes about this lock.
        /// </summary>
        public virtual string Notes { get; internal set; }
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
              .Add("account lock update")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
              .Add("--notes {value}", Notes)
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
    #region AzureAccountManagementGroupCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountManagementGroupCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
        /// <summary>
        ///   Name of the management group.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Sets the display name of the management group. If null, the group name is set as the display name.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   Sets the parent of the management group. Can be the fully qualified id or the name of the management group. If null, the root tenant group is set as the parent.
        /// </summary>
        public virtual string Parent { get; internal set; }
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
              .Add("account management-group create")
              .Add("--name {value}", Name)
              .Add("--display-name {value}", DisplayName)
              .Add("--parent {value}", Parent)
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
    #region AzureAccountManagementGroupDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountManagementGroupDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
        /// <summary>
        ///   Name of the management group.
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
              .Add("account management-group delete")
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
    #region AzureAccountManagementGroupListSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountManagementGroupListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
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
              .Add("account management-group list")
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
    #region AzureAccountManagementGroupShowSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountManagementGroupShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
        /// <summary>
        ///   Name of the management group.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   If given, lists the children in the first level of hierarchy.
        /// </summary>
        public virtual string Expand { get; internal set; }
        /// <summary>
        ///   If given, lists the children in all levels of hierarchy.
        /// </summary>
        public virtual string Recurse { get; internal set; }
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
              .Add("account management-group show")
              .Add("--name {value}", Name)
              .Add("--expand {value}", Expand)
              .Add("--recurse {value}", Recurse)
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
    #region AzureAccountManagementGroupUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountManagementGroupUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
        /// <summary>
        ///   Name of the management group.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Updates the display name of the management group. If null, no change is made.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   Update the parent of the management group. Can be the fully qualified id or the name of the management group. If null, no change is made.
        /// </summary>
        public virtual string Parent { get; internal set; }
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
              .Add("account management-group update")
              .Add("--name {value}", Name)
              .Add("--display-name {value}", DisplayName)
              .Add("--parent {value}", Parent)
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
    #region AzureAccountManagementGroupSubscriptionAddSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountManagementGroupSubscriptionAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
        /// <summary>
        ///   Name of the management group.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Subscription Id or Name.
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
              .Add("account management-group subscription add")
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
    #region AzureAccountManagementGroupSubscriptionRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountManagementGroupSubscriptionRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAccount executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        public override Action<OutputType, string> CustomLogger => AzureAccountTasks.AzureAccountLogger;
        /// <summary>
        ///   Name of the management group.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Subscription Id or Name.
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
              .Add("account management-group subscription remove")
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
    #region AzureAccountClearSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountClearSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountClearSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountClearSettings SetSubscription(this AzureAccountClearSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountClearSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountClearSettings ResetSubscription(this AzureAccountClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountClearSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountClearSettings SetDebug(this AzureAccountClearSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountClearSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountClearSettings ResetDebug(this AzureAccountClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountClearSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountClearSettings SetHelp(this AzureAccountClearSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountClearSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountClearSettings ResetHelp(this AzureAccountClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountClearSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountClearSettings SetOutput(this AzureAccountClearSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountClearSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountClearSettings ResetOutput(this AzureAccountClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountClearSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountClearSettings SetQuery(this AzureAccountClearSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountClearSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountClearSettings ResetQuery(this AzureAccountClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountClearSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountClearSettings SetVerbose(this AzureAccountClearSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountClearSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountClearSettings ResetVerbose(this AzureAccountClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountGetAccessTokenSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountGetAccessTokenSettingsExtensions
    {
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Resource"/></em></p>
        ///   <p>Azure resource endpoints. Default to Azure Resource Manager Use 'az cloud show' command for other Azure resources.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetResource(this AzureAccountGetAccessTokenSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Resource"/></em></p>
        ///   <p>Azure resource endpoints. Default to Azure Resource Manager Use 'az cloud show' command for other Azure resources.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetResource(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetSubscription(this AzureAccountGetAccessTokenSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetSubscription(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetDebug(this AzureAccountGetAccessTokenSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetDebug(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetHelp(this AzureAccountGetAccessTokenSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetHelp(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetOutput(this AzureAccountGetAccessTokenSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetOutput(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetQuery(this AzureAccountGetAccessTokenSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetQuery(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetVerbose(this AzureAccountGetAccessTokenSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetVerbose(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountListSettingsExtensions
    {
        #region All
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListSettings.All"/></em></p>
        ///   <p>List all subscriptions, rather just 'Enabled' ones.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings SetAll(this AzureAccountListSettings toolSettings, string all)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = all;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListSettings.All"/></em></p>
        ///   <p>List all subscriptions, rather just 'Enabled' ones.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings ResetAll(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = null;
            return toolSettings;
        }
        #endregion
        #region Refresh
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListSettings.Refresh"/></em></p>
        ///   <p>Retrieve up-to-date subscriptions from server.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings SetRefresh(this AzureAccountListSettings toolSettings, string refresh)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = refresh;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListSettings.Refresh"/></em></p>
        ///   <p>Retrieve up-to-date subscriptions from server.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings ResetRefresh(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings SetSubscription(this AzureAccountListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings ResetSubscription(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings SetDebug(this AzureAccountListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings ResetDebug(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings SetHelp(this AzureAccountListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings ResetHelp(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings SetOutput(this AzureAccountListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings ResetOutput(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings SetQuery(this AzureAccountListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings ResetQuery(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings SetVerbose(this AzureAccountListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListSettings ResetVerbose(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountListLocationsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountListLocationsSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListLocationsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListLocationsSettings SetSubscription(this AzureAccountListLocationsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListLocationsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListLocationsSettings ResetSubscription(this AzureAccountListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListLocationsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListLocationsSettings SetDebug(this AzureAccountListLocationsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListLocationsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListLocationsSettings ResetDebug(this AzureAccountListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListLocationsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListLocationsSettings SetHelp(this AzureAccountListLocationsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListLocationsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListLocationsSettings ResetHelp(this AzureAccountListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListLocationsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListLocationsSettings SetOutput(this AzureAccountListLocationsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListLocationsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListLocationsSettings ResetOutput(this AzureAccountListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListLocationsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListLocationsSettings SetQuery(this AzureAccountListLocationsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListLocationsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListLocationsSettings ResetQuery(this AzureAccountListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountListLocationsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListLocationsSettings SetVerbose(this AzureAccountListLocationsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountListLocationsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountListLocationsSettings ResetVerbose(this AzureAccountListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountSetSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountSetSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountSetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAccountSetSettings SetSubscription(this AzureAccountSetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountSetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAccountSetSettings ResetSubscription(this AzureAccountSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountSetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountSetSettings SetDebug(this AzureAccountSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountSetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountSetSettings ResetDebug(this AzureAccountSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountSetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountSetSettings SetHelp(this AzureAccountSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountSetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountSetSettings ResetHelp(this AzureAccountSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountSetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountSetSettings SetOutput(this AzureAccountSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountSetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountSetSettings ResetOutput(this AzureAccountSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountSetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountSetSettings SetQuery(this AzureAccountSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountSetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountSetSettings ResetQuery(this AzureAccountSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountSetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountSetSettings SetVerbose(this AzureAccountSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountSetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountSetSettings ResetVerbose(this AzureAccountSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountShowSettingsExtensions
    {
        #region SdkAuth
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountShowSettings.SdkAuth"/></em></p>
        ///   <p>Output result to a file compatible with Azure SDK auth. Only applicable when authenticating with a Service Principal.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings SetSdkAuth(this AzureAccountShowSettings toolSettings, string sdkAuth)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = sdkAuth;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountShowSettings.SdkAuth"/></em></p>
        ///   <p>Output result to a file compatible with Azure SDK auth. Only applicable when authenticating with a Service Principal.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings ResetSdkAuth(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings SetSubscription(this AzureAccountShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings ResetSubscription(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings SetDebug(this AzureAccountShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings ResetDebug(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings SetHelp(this AzureAccountShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings ResetHelp(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings SetOutput(this AzureAccountShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings ResetOutput(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings SetQuery(this AzureAccountShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings ResetQuery(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings SetVerbose(this AzureAccountShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountShowSettings ResetVerbose(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountLockCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountLockCreateSettingsExtensions
    {
        #region LockType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockCreateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetLockType(this AzureAccountLockCreateSettings toolSettings, AccountLockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockCreateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetLockType(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockCreateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetName(this AzureAccountLockCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockCreateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetName(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockCreateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetNotes(this AzureAccountLockCreateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockCreateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetNotes(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetSubscription(this AzureAccountLockCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetSubscription(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetDebug(this AzureAccountLockCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetDebug(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetHelp(this AzureAccountLockCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetHelp(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetOutput(this AzureAccountLockCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetOutput(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetQuery(this AzureAccountLockCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetQuery(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetVerbose(this AzureAccountLockCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetVerbose(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountLockDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountLockDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetIds(this AzureAccountLockDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetIds(this AzureAccountLockDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAccountLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings AddIds(this AzureAccountLockDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAccountLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings AddIds(this AzureAccountLockDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAccountLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ClearIds(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAccountLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings RemoveIds(this AzureAccountLockDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAccountLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings RemoveIds(this AzureAccountLockDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockDeleteSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetName(this AzureAccountLockDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockDeleteSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetName(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetSubscription(this AzureAccountLockDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetSubscription(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetDebug(this AzureAccountLockDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetDebug(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetHelp(this AzureAccountLockDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetHelp(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetOutput(this AzureAccountLockDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetOutput(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetQuery(this AzureAccountLockDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetQuery(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetVerbose(this AzureAccountLockDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetVerbose(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountLockListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountLockListSettingsExtensions
    {
        #region FilterString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockListSettings.FilterString"/></em></p>
        ///   <p>A query filter to use to restrict the results.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings SetFilterString(this AzureAccountLockListSettings toolSettings, string filterString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = filterString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockListSettings.FilterString"/></em></p>
        ///   <p>A query filter to use to restrict the results.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings ResetFilterString(this AzureAccountLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings SetSubscription(this AzureAccountLockListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings ResetSubscription(this AzureAccountLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings SetDebug(this AzureAccountLockListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings ResetDebug(this AzureAccountLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings SetHelp(this AzureAccountLockListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings ResetHelp(this AzureAccountLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings SetOutput(this AzureAccountLockListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings ResetOutput(this AzureAccountLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings SetQuery(this AzureAccountLockListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings ResetQuery(this AzureAccountLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings SetVerbose(this AzureAccountLockListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockListSettings ResetVerbose(this AzureAccountLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountLockShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountLockShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings SetIds(this AzureAccountLockShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings SetIds(this AzureAccountLockShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAccountLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings AddIds(this AzureAccountLockShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAccountLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings AddIds(this AzureAccountLockShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAccountLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings ClearIds(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAccountLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings RemoveIds(this AzureAccountLockShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAccountLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings RemoveIds(this AzureAccountLockShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockShowSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings SetName(this AzureAccountLockShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockShowSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetName(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings SetSubscription(this AzureAccountLockShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetSubscription(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings SetDebug(this AzureAccountLockShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetDebug(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings SetHelp(this AzureAccountLockShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetHelp(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings SetOutput(this AzureAccountLockShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetOutput(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings SetQuery(this AzureAccountLockShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetQuery(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings SetVerbose(this AzureAccountLockShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetVerbose(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountLockUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountLockUpdateSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetIds(this AzureAccountLockUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetIds(this AzureAccountLockUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAccountLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings AddIds(this AzureAccountLockUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAccountLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings AddIds(this AzureAccountLockUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAccountLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ClearIds(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAccountLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings RemoveIds(this AzureAccountLockUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAccountLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings RemoveIds(this AzureAccountLockUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region LockType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockUpdateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetLockType(this AzureAccountLockUpdateSettings toolSettings, AccountLockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockUpdateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetLockType(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockUpdateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetName(this AzureAccountLockUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockUpdateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetName(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockUpdateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetNotes(this AzureAccountLockUpdateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockUpdateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetNotes(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetSubscription(this AzureAccountLockUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetSubscription(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetDebug(this AzureAccountLockUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetDebug(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetHelp(this AzureAccountLockUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetHelp(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetOutput(this AzureAccountLockUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetOutput(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetQuery(this AzureAccountLockUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetQuery(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountLockUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetVerbose(this AzureAccountLockUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountLockUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetVerbose(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountManagementGroupCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountManagementGroupCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupCreateSettings.Name"/></em></p>
        ///   <p>Name of the management group.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings SetName(this AzureAccountManagementGroupCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupCreateSettings.Name"/></em></p>
        ///   <p>Name of the management group.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings ResetName(this AzureAccountManagementGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupCreateSettings.DisplayName"/></em></p>
        ///   <p>Sets the display name of the management group. If null, the group name is set as the display name.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings SetDisplayName(this AzureAccountManagementGroupCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupCreateSettings.DisplayName"/></em></p>
        ///   <p>Sets the display name of the management group. If null, the group name is set as the display name.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings ResetDisplayName(this AzureAccountManagementGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupCreateSettings.Parent"/></em></p>
        ///   <p>Sets the parent of the management group. Can be the fully qualified id or the name of the management group. If null, the root tenant group is set as the parent.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings SetParent(this AzureAccountManagementGroupCreateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupCreateSettings.Parent"/></em></p>
        ///   <p>Sets the parent of the management group. Can be the fully qualified id or the name of the management group. If null, the root tenant group is set as the parent.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings ResetParent(this AzureAccountManagementGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings SetSubscription(this AzureAccountManagementGroupCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings ResetSubscription(this AzureAccountManagementGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings SetDebug(this AzureAccountManagementGroupCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings ResetDebug(this AzureAccountManagementGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings SetHelp(this AzureAccountManagementGroupCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings ResetHelp(this AzureAccountManagementGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings SetOutput(this AzureAccountManagementGroupCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings ResetOutput(this AzureAccountManagementGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings SetQuery(this AzureAccountManagementGroupCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings ResetQuery(this AzureAccountManagementGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings SetVerbose(this AzureAccountManagementGroupCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupCreateSettings ResetVerbose(this AzureAccountManagementGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountManagementGroupDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountManagementGroupDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupDeleteSettings.Name"/></em></p>
        ///   <p>Name of the management group.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings SetName(this AzureAccountManagementGroupDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupDeleteSettings.Name"/></em></p>
        ///   <p>Name of the management group.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings ResetName(this AzureAccountManagementGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings SetSubscription(this AzureAccountManagementGroupDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings ResetSubscription(this AzureAccountManagementGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings SetDebug(this AzureAccountManagementGroupDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings ResetDebug(this AzureAccountManagementGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings SetHelp(this AzureAccountManagementGroupDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings ResetHelp(this AzureAccountManagementGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings SetOutput(this AzureAccountManagementGroupDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings ResetOutput(this AzureAccountManagementGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings SetQuery(this AzureAccountManagementGroupDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings ResetQuery(this AzureAccountManagementGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings SetVerbose(this AzureAccountManagementGroupDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupDeleteSettings ResetVerbose(this AzureAccountManagementGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountManagementGroupListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountManagementGroupListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupListSettings SetSubscription(this AzureAccountManagementGroupListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupListSettings ResetSubscription(this AzureAccountManagementGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupListSettings SetDebug(this AzureAccountManagementGroupListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupListSettings ResetDebug(this AzureAccountManagementGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupListSettings SetHelp(this AzureAccountManagementGroupListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupListSettings ResetHelp(this AzureAccountManagementGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupListSettings SetOutput(this AzureAccountManagementGroupListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupListSettings ResetOutput(this AzureAccountManagementGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupListSettings SetQuery(this AzureAccountManagementGroupListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupListSettings ResetQuery(this AzureAccountManagementGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupListSettings SetVerbose(this AzureAccountManagementGroupListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupListSettings ResetVerbose(this AzureAccountManagementGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountManagementGroupShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountManagementGroupShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupShowSettings.Name"/></em></p>
        ///   <p>Name of the management group.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings SetName(this AzureAccountManagementGroupShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupShowSettings.Name"/></em></p>
        ///   <p>Name of the management group.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings ResetName(this AzureAccountManagementGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupShowSettings.Expand"/></em></p>
        ///   <p>If given, lists the children in the first level of hierarchy.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings SetExpand(this AzureAccountManagementGroupShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupShowSettings.Expand"/></em></p>
        ///   <p>If given, lists the children in the first level of hierarchy.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings ResetExpand(this AzureAccountManagementGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Recurse
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupShowSettings.Recurse"/></em></p>
        ///   <p>If given, lists the children in all levels of hierarchy.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings SetRecurse(this AzureAccountManagementGroupShowSettings toolSettings, string recurse)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Recurse = recurse;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupShowSettings.Recurse"/></em></p>
        ///   <p>If given, lists the children in all levels of hierarchy.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings ResetRecurse(this AzureAccountManagementGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Recurse = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings SetSubscription(this AzureAccountManagementGroupShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings ResetSubscription(this AzureAccountManagementGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings SetDebug(this AzureAccountManagementGroupShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings ResetDebug(this AzureAccountManagementGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings SetHelp(this AzureAccountManagementGroupShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings ResetHelp(this AzureAccountManagementGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings SetOutput(this AzureAccountManagementGroupShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings ResetOutput(this AzureAccountManagementGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings SetQuery(this AzureAccountManagementGroupShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings ResetQuery(this AzureAccountManagementGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings SetVerbose(this AzureAccountManagementGroupShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupShowSettings ResetVerbose(this AzureAccountManagementGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountManagementGroupUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountManagementGroupUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupUpdateSettings.Name"/></em></p>
        ///   <p>Name of the management group.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings SetName(this AzureAccountManagementGroupUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupUpdateSettings.Name"/></em></p>
        ///   <p>Name of the management group.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings ResetName(this AzureAccountManagementGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupUpdateSettings.DisplayName"/></em></p>
        ///   <p>Updates the display name of the management group. If null, no change is made.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings SetDisplayName(this AzureAccountManagementGroupUpdateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupUpdateSettings.DisplayName"/></em></p>
        ///   <p>Updates the display name of the management group. If null, no change is made.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings ResetDisplayName(this AzureAccountManagementGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupUpdateSettings.Parent"/></em></p>
        ///   <p>Update the parent of the management group. Can be the fully qualified id or the name of the management group. If null, no change is made.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings SetParent(this AzureAccountManagementGroupUpdateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupUpdateSettings.Parent"/></em></p>
        ///   <p>Update the parent of the management group. Can be the fully qualified id or the name of the management group. If null, no change is made.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings ResetParent(this AzureAccountManagementGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings SetAdd(this AzureAccountManagementGroupUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings ResetAdd(this AzureAccountManagementGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings SetForceString(this AzureAccountManagementGroupUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings ResetForceString(this AzureAccountManagementGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings SetRemove(this AzureAccountManagementGroupUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings ResetRemove(this AzureAccountManagementGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings SetSet(this AzureAccountManagementGroupUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings ResetSet(this AzureAccountManagementGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings SetSubscription(this AzureAccountManagementGroupUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings ResetSubscription(this AzureAccountManagementGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings SetDebug(this AzureAccountManagementGroupUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings ResetDebug(this AzureAccountManagementGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings SetHelp(this AzureAccountManagementGroupUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings ResetHelp(this AzureAccountManagementGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings SetOutput(this AzureAccountManagementGroupUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings ResetOutput(this AzureAccountManagementGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings SetQuery(this AzureAccountManagementGroupUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings ResetQuery(this AzureAccountManagementGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings SetVerbose(this AzureAccountManagementGroupUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupUpdateSettings ResetVerbose(this AzureAccountManagementGroupUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountManagementGroupSubscriptionAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountManagementGroupSubscriptionAddSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Name"/></em></p>
        ///   <p>Name of the management group.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings SetName(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Name"/></em></p>
        ///   <p>Name of the management group.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings ResetName(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Subscription"/></em></p>
        ///   <p>Subscription Id or Name.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings SetSubscription(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Subscription"/></em></p>
        ///   <p>Subscription Id or Name.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings ResetSubscription(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings SetDebug(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings ResetDebug(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings SetHelp(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings ResetHelp(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings SetOutput(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings ResetOutput(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings SetQuery(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings ResetQuery(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings SetVerbose(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionAddSettings ResetVerbose(this AzureAccountManagementGroupSubscriptionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountManagementGroupSubscriptionRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountManagementGroupSubscriptionRemoveSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Name"/></em></p>
        ///   <p>Name of the management group.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings SetName(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Name"/></em></p>
        ///   <p>Name of the management group.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings ResetName(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Subscription"/></em></p>
        ///   <p>Subscription Id or Name.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings SetSubscription(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Subscription"/></em></p>
        ///   <p>Subscription Id or Name.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings ResetSubscription(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings SetDebug(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings ResetDebug(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings SetHelp(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings ResetHelp(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings SetOutput(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings ResetOutput(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings SetQuery(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings ResetQuery(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings SetVerbose(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAccountManagementGroupSubscriptionRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAccountManagementGroupSubscriptionRemoveSettings ResetVerbose(this AzureAccountManagementGroupSubscriptionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AccountLockLockType
    /// <summary>
    ///   Used within <see cref="AzureAccountTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AccountLockLockType>))]
    public partial class AccountLockLockType : Enumeration
    {
        public static AccountLockLockType cannotdelete = new AccountLockLockType { Value = "cannotdelete" };
        public static AccountLockLockType readonly_ = new AccountLockLockType { Value = "readonly" };
    }
    #endregion
}
