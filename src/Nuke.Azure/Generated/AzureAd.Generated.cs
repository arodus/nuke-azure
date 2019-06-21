// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzureAd.json
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
    public static partial class AzureAdTasks
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public static string AzureAdPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREAD_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureAdLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Active Directory Graph entities needed for Role Based Access Control.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAd(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureAdPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureAdLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAd(AzureAdSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAd(Configure<AzureAdSettings> configurator)
        {
            return AzureAd(configurator(new AzureAdSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdSettings Settings, IReadOnlyCollection<Output> Output)> AzureAd(CombinatorialConfigure<AzureAdSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAd, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppCreate(AzureAdAppCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--app-roles</c> via <see cref="AzureAdAppCreateSettings.AppRoles"/></li>
        ///     <li><c>--available-to-other-tenants</c> via <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/></li>
        ///     <li><c>--credential-description</c> via <see cref="AzureAdAppCreateSettings.CredentialDescription"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppCreateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdAppCreateSettings.DisplayName"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureAdAppCreateSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppCreateSettings.Help"/></li>
        ///     <li><c>--homepage</c> via <see cref="AzureAdAppCreateSettings.Homepage"/></li>
        ///     <li><c>--identifier-uris</c> via <see cref="AzureAdAppCreateSettings.IdentifierUris"/></li>
        ///     <li><c>--key-type</c> via <see cref="AzureAdAppCreateSettings.KeyType"/></li>
        ///     <li><c>--key-usage</c> via <see cref="AzureAdAppCreateSettings.KeyUsage"/></li>
        ///     <li><c>--key-value</c> via <see cref="AzureAdAppCreateSettings.KeyValue"/></li>
        ///     <li><c>--native-app</c> via <see cref="AzureAdAppCreateSettings.NativeApp"/></li>
        ///     <li><c>--oauth2-allow-implicit-flow</c> via <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppCreateSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureAdAppCreateSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppCreateSettings.Query"/></li>
        ///     <li><c>--reply-urls</c> via <see cref="AzureAdAppCreateSettings.ReplyUrls"/></li>
        ///     <li><c>--required-resource-accesses</c> via <see cref="AzureAdAppCreateSettings.RequiredResourceAccesses"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureAdAppCreateSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppCreate(Configure<AzureAdAppCreateSettings> configurator)
        {
            return AzureAdAppCreate(configurator(new AzureAdAppCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--app-roles</c> via <see cref="AzureAdAppCreateSettings.AppRoles"/></li>
        ///     <li><c>--available-to-other-tenants</c> via <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/></li>
        ///     <li><c>--credential-description</c> via <see cref="AzureAdAppCreateSettings.CredentialDescription"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppCreateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdAppCreateSettings.DisplayName"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureAdAppCreateSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppCreateSettings.Help"/></li>
        ///     <li><c>--homepage</c> via <see cref="AzureAdAppCreateSettings.Homepage"/></li>
        ///     <li><c>--identifier-uris</c> via <see cref="AzureAdAppCreateSettings.IdentifierUris"/></li>
        ///     <li><c>--key-type</c> via <see cref="AzureAdAppCreateSettings.KeyType"/></li>
        ///     <li><c>--key-usage</c> via <see cref="AzureAdAppCreateSettings.KeyUsage"/></li>
        ///     <li><c>--key-value</c> via <see cref="AzureAdAppCreateSettings.KeyValue"/></li>
        ///     <li><c>--native-app</c> via <see cref="AzureAdAppCreateSettings.NativeApp"/></li>
        ///     <li><c>--oauth2-allow-implicit-flow</c> via <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppCreateSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureAdAppCreateSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppCreateSettings.Query"/></li>
        ///     <li><c>--reply-urls</c> via <see cref="AzureAdAppCreateSettings.ReplyUrls"/></li>
        ///     <li><c>--required-resource-accesses</c> via <see cref="AzureAdAppCreateSettings.RequiredResourceAccesses"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureAdAppCreateSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppCreate(CombinatorialConfigure<AzureAdAppCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppCreate, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppDelete(AzureAdAppDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppDeleteSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppDeleteSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppDelete(Configure<AzureAdAppDeleteSettings> configurator)
        {
            return AzureAdAppDelete(configurator(new AzureAdAppDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppDeleteSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppDeleteSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppDelete(CombinatorialConfigure<AzureAdAppDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppDelete, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppList(AzureAdAppListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--all</c> via <see cref="AzureAdAppListSettings.All"/></li>
        ///     <li><c>--app-id</c> via <see cref="AzureAdAppListSettings.AppId"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppListSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdAppListSettings.DisplayName"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureAdAppListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppListSettings.Help"/></li>
        ///     <li><c>--identifier-uri</c> via <see cref="AzureAdAppListSettings.IdentifierUri"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppListSettings.Query"/></li>
        ///     <li><c>--show-mine</c> via <see cref="AzureAdAppListSettings.ShowMine"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppList(Configure<AzureAdAppListSettings> configurator)
        {
            return AzureAdAppList(configurator(new AzureAdAppListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--all</c> via <see cref="AzureAdAppListSettings.All"/></li>
        ///     <li><c>--app-id</c> via <see cref="AzureAdAppListSettings.AppId"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppListSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdAppListSettings.DisplayName"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureAdAppListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppListSettings.Help"/></li>
        ///     <li><c>--identifier-uri</c> via <see cref="AzureAdAppListSettings.IdentifierUri"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppListSettings.Query"/></li>
        ///     <li><c>--show-mine</c> via <see cref="AzureAdAppListSettings.ShowMine"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppList(CombinatorialConfigure<AzureAdAppListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppList, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppShow(AzureAdAppShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppShowSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppShowSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppShow(Configure<AzureAdAppShowSettings> configurator)
        {
            return AzureAdAppShow(configurator(new AzureAdAppShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppShowSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppShowSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppShow(CombinatorialConfigure<AzureAdAppShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppShow, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppUpdate(AzureAdAppUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureAdAppUpdateSettings.Add"/></li>
        ///     <li><c>--app-roles</c> via <see cref="AzureAdAppUpdateSettings.AppRoles"/></li>
        ///     <li><c>--available-to-other-tenants</c> via <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/></li>
        ///     <li><c>--credential-description</c> via <see cref="AzureAdAppUpdateSettings.CredentialDescription"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppUpdateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdAppUpdateSettings.DisplayName"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureAdAppUpdateSettings.EndDate"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureAdAppUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppUpdateSettings.Help"/></li>
        ///     <li><c>--homepage</c> via <see cref="AzureAdAppUpdateSettings.Homepage"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppUpdateSettings.Id"/></li>
        ///     <li><c>--identifier-uris</c> via <see cref="AzureAdAppUpdateSettings.IdentifierUris"/></li>
        ///     <li><c>--key-type</c> via <see cref="AzureAdAppUpdateSettings.KeyType"/></li>
        ///     <li><c>--key-usage</c> via <see cref="AzureAdAppUpdateSettings.KeyUsage"/></li>
        ///     <li><c>--key-value</c> via <see cref="AzureAdAppUpdateSettings.KeyValue"/></li>
        ///     <li><c>--oauth2-allow-implicit-flow</c> via <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppUpdateSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureAdAppUpdateSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureAdAppUpdateSettings.Remove"/></li>
        ///     <li><c>--reply-urls</c> via <see cref="AzureAdAppUpdateSettings.ReplyUrls"/></li>
        ///     <li><c>--required-resource-accesses</c> via <see cref="AzureAdAppUpdateSettings.RequiredResourceAccesses"/></li>
        ///     <li><c>--set</c> via <see cref="AzureAdAppUpdateSettings.Set"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureAdAppUpdateSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppUpdate(Configure<AzureAdAppUpdateSettings> configurator)
        {
            return AzureAdAppUpdate(configurator(new AzureAdAppUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureAdAppUpdateSettings.Add"/></li>
        ///     <li><c>--app-roles</c> via <see cref="AzureAdAppUpdateSettings.AppRoles"/></li>
        ///     <li><c>--available-to-other-tenants</c> via <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/></li>
        ///     <li><c>--credential-description</c> via <see cref="AzureAdAppUpdateSettings.CredentialDescription"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppUpdateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdAppUpdateSettings.DisplayName"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureAdAppUpdateSettings.EndDate"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureAdAppUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppUpdateSettings.Help"/></li>
        ///     <li><c>--homepage</c> via <see cref="AzureAdAppUpdateSettings.Homepage"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppUpdateSettings.Id"/></li>
        ///     <li><c>--identifier-uris</c> via <see cref="AzureAdAppUpdateSettings.IdentifierUris"/></li>
        ///     <li><c>--key-type</c> via <see cref="AzureAdAppUpdateSettings.KeyType"/></li>
        ///     <li><c>--key-usage</c> via <see cref="AzureAdAppUpdateSettings.KeyUsage"/></li>
        ///     <li><c>--key-value</c> via <see cref="AzureAdAppUpdateSettings.KeyValue"/></li>
        ///     <li><c>--oauth2-allow-implicit-flow</c> via <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppUpdateSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureAdAppUpdateSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureAdAppUpdateSettings.Remove"/></li>
        ///     <li><c>--reply-urls</c> via <see cref="AzureAdAppUpdateSettings.ReplyUrls"/></li>
        ///     <li><c>--required-resource-accesses</c> via <see cref="AzureAdAppUpdateSettings.RequiredResourceAccesses"/></li>
        ///     <li><c>--set</c> via <see cref="AzureAdAppUpdateSettings.Set"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureAdAppUpdateSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppUpdate(CombinatorialConfigure<AzureAdAppUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppUpdate, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdGroupCreate(AzureAdGroupCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdGroupCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupCreateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdGroupCreateSettings.DisplayName"/></li>
        ///     <li><c>--force</c> via <see cref="AzureAdGroupCreateSettings.Force"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupCreateSettings.Help"/></li>
        ///     <li><c>--mail-nickname</c> via <see cref="AzureAdGroupCreateSettings.MailNickname"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdGroupCreate(Configure<AzureAdGroupCreateSettings> configurator)
        {
            return AzureAdGroupCreate(configurator(new AzureAdGroupCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupCreateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdGroupCreateSettings.DisplayName"/></li>
        ///     <li><c>--force</c> via <see cref="AzureAdGroupCreateSettings.Force"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupCreateSettings.Help"/></li>
        ///     <li><c>--mail-nickname</c> via <see cref="AzureAdGroupCreateSettings.MailNickname"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdGroupCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdGroupCreate(CombinatorialConfigure<AzureAdGroupCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdGroupCreate, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdGroupDelete(AzureAdGroupDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdGroupDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupDeleteSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupDeleteSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdGroupDelete(Configure<AzureAdGroupDeleteSettings> configurator)
        {
            return AzureAdGroupDelete(configurator(new AzureAdGroupDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupDeleteSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupDeleteSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdGroupDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdGroupDelete(CombinatorialConfigure<AzureAdGroupDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdGroupDelete, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdGroupGetMemberGroups(AzureAdGroupGetMemberGroupsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdGroupGetMemberGroupsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--additional-properties</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.AdditionalProperties"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Query"/></li>
        ///     <li><c>--security-enabled-only</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdGroupGetMemberGroups(Configure<AzureAdGroupGetMemberGroupsSettings> configurator)
        {
            return AzureAdGroupGetMemberGroups(configurator(new AzureAdGroupGetMemberGroupsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--additional-properties</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.AdditionalProperties"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Query"/></li>
        ///     <li><c>--security-enabled-only</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupGetMemberGroupsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdGroupGetMemberGroupsSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdGroupGetMemberGroups(CombinatorialConfigure<AzureAdGroupGetMemberGroupsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdGroupGetMemberGroups, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdGroupList(AzureAdGroupListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdGroupListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupListSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdGroupListSettings.DisplayName"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureAdGroupListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdGroupList(Configure<AzureAdGroupListSettings> configurator)
        {
            return AzureAdGroupList(configurator(new AzureAdGroupListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupListSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdGroupListSettings.DisplayName"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureAdGroupListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdGroupListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdGroupList(CombinatorialConfigure<AzureAdGroupListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdGroupList, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdGroupShow(AzureAdGroupShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdGroupShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupShowSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupShowSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdGroupShow(Configure<AzureAdGroupShowSettings> configurator)
        {
            return AzureAdGroupShow(configurator(new AzureAdGroupShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupShowSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupShowSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdGroupShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdGroupShow(CombinatorialConfigure<AzureAdGroupShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdGroupShow, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdSignedInUserListOwnedObjects(AzureAdSignedInUserListOwnedObjectsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdSignedInUserListOwnedObjectsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Subscription"/></li>
        ///     <li><c>--type</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Type"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdSignedInUserListOwnedObjects(Configure<AzureAdSignedInUserListOwnedObjectsSettings> configurator)
        {
            return AzureAdSignedInUserListOwnedObjects(configurator(new AzureAdSignedInUserListOwnedObjectsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Subscription"/></li>
        ///     <li><c>--type</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Type"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdSignedInUserListOwnedObjectsSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdSignedInUserListOwnedObjects(CombinatorialConfigure<AzureAdSignedInUserListOwnedObjectsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdSignedInUserListOwnedObjects, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdSignedInUserShow(AzureAdSignedInUserShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdSignedInUserShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSignedInUserShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSignedInUserShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSignedInUserShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSignedInUserShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSignedInUserShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSignedInUserShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdSignedInUserShow(Configure<AzureAdSignedInUserShowSettings> configurator)
        {
            return AzureAdSignedInUserShow(configurator(new AzureAdSignedInUserShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSignedInUserShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSignedInUserShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSignedInUserShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSignedInUserShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSignedInUserShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSignedInUserShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdSignedInUserShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdSignedInUserShow(CombinatorialConfigure<AzureAdSignedInUserShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdSignedInUserShow, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdSpCreate(AzureAdSpCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdSpCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpCreateSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpCreateSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdSpCreate(Configure<AzureAdSpCreateSettings> configurator)
        {
            return AzureAdSpCreate(configurator(new AzureAdSpCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpCreateSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpCreateSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdSpCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdSpCreate(CombinatorialConfigure<AzureAdSpCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdSpCreate, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdSpCreateForRbac(AzureAdSpCreateForRbacSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdSpCreateForRbacSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cert</c> via <see cref="AzureAdSpCreateForRbacSettings.Cert"/></li>
        ///     <li><c>--create-cert</c> via <see cref="AzureAdSpCreateForRbacSettings.CreateCert"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpCreateForRbacSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpCreateForRbacSettings.Help"/></li>
        ///     <li><c>--keyvault</c> via <see cref="AzureAdSpCreateForRbacSettings.Keyvault"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAdSpCreateForRbacSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpCreateForRbacSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureAdSpCreateForRbacSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpCreateForRbacSettings.Query"/></li>
        ///     <li><c>--role</c> via <see cref="AzureAdSpCreateForRbacSettings.Role"/></li>
        ///     <li><c>--scopes</c> via <see cref="AzureAdSpCreateForRbacSettings.Scopes"/></li>
        ///     <li><c>--sdk-auth</c> via <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/></li>
        ///     <li><c>--skip-assignment</c> via <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpCreateForRbacSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpCreateForRbacSettings.Verbose"/></li>
        ///     <li><c>--years</c> via <see cref="AzureAdSpCreateForRbacSettings.Years"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdSpCreateForRbac(Configure<AzureAdSpCreateForRbacSettings> configurator)
        {
            return AzureAdSpCreateForRbac(configurator(new AzureAdSpCreateForRbacSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cert</c> via <see cref="AzureAdSpCreateForRbacSettings.Cert"/></li>
        ///     <li><c>--create-cert</c> via <see cref="AzureAdSpCreateForRbacSettings.CreateCert"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpCreateForRbacSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpCreateForRbacSettings.Help"/></li>
        ///     <li><c>--keyvault</c> via <see cref="AzureAdSpCreateForRbacSettings.Keyvault"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAdSpCreateForRbacSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpCreateForRbacSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureAdSpCreateForRbacSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpCreateForRbacSettings.Query"/></li>
        ///     <li><c>--role</c> via <see cref="AzureAdSpCreateForRbacSettings.Role"/></li>
        ///     <li><c>--scopes</c> via <see cref="AzureAdSpCreateForRbacSettings.Scopes"/></li>
        ///     <li><c>--sdk-auth</c> via <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/></li>
        ///     <li><c>--skip-assignment</c> via <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpCreateForRbacSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpCreateForRbacSettings.Verbose"/></li>
        ///     <li><c>--years</c> via <see cref="AzureAdSpCreateForRbacSettings.Years"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdSpCreateForRbacSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdSpCreateForRbac(CombinatorialConfigure<AzureAdSpCreateForRbacSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdSpCreateForRbac, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdSpDelete(AzureAdSpDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdSpDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpDeleteSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpDeleteSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdSpDelete(Configure<AzureAdSpDeleteSettings> configurator)
        {
            return AzureAdSpDelete(configurator(new AzureAdSpDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpDeleteSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpDeleteSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdSpDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdSpDelete(CombinatorialConfigure<AzureAdSpDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdSpDelete, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdSpList(AzureAdSpListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdSpListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--all</c> via <see cref="AzureAdSpListSettings.All"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpListSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdSpListSettings.DisplayName"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureAdSpListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpListSettings.Query"/></li>
        ///     <li><c>--show-mine</c> via <see cref="AzureAdSpListSettings.ShowMine"/></li>
        ///     <li><c>--spn</c> via <see cref="AzureAdSpListSettings.Spn"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdSpList(Configure<AzureAdSpListSettings> configurator)
        {
            return AzureAdSpList(configurator(new AzureAdSpListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--all</c> via <see cref="AzureAdSpListSettings.All"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpListSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdSpListSettings.DisplayName"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureAdSpListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpListSettings.Query"/></li>
        ///     <li><c>--show-mine</c> via <see cref="AzureAdSpListSettings.ShowMine"/></li>
        ///     <li><c>--spn</c> via <see cref="AzureAdSpListSettings.Spn"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdSpListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdSpList(CombinatorialConfigure<AzureAdSpListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdSpList, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdSpShow(AzureAdSpShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdSpShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpShowSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpShowSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdSpShow(Configure<AzureAdSpShowSettings> configurator)
        {
            return AzureAdSpShow(configurator(new AzureAdSpShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpShowSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpShowSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdSpShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdSpShow(CombinatorialConfigure<AzureAdSpShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdSpShow, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdSpUpdate(AzureAdSpUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdSpUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureAdSpUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureAdSpUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpUpdateSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpUpdateSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureAdSpUpdateSettings.Remove"/></li>
        ///     <li><c>--set</c> via <see cref="AzureAdSpUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdSpUpdate(Configure<AzureAdSpUpdateSettings> configurator)
        {
            return AzureAdSpUpdate(configurator(new AzureAdSpUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureAdSpUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureAdSpUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpUpdateSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpUpdateSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureAdSpUpdateSettings.Remove"/></li>
        ///     <li><c>--set</c> via <see cref="AzureAdSpUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdSpUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdSpUpdate(CombinatorialConfigure<AzureAdSpUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdSpUpdate, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdUserCreate(AzureAdUserCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdUserCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdUserCreateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdUserCreateSettings.DisplayName"/></li>
        ///     <li><c>--force-change-password-next-login</c> via <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdUserCreateSettings.Help"/></li>
        ///     <li><c>--immutable-id</c> via <see cref="AzureAdUserCreateSettings.ImmutableId"/></li>
        ///     <li><c>--mail-nickname</c> via <see cref="AzureAdUserCreateSettings.MailNickname"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdUserCreateSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureAdUserCreateSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdUserCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdUserCreateSettings.Subscription"/></li>
        ///     <li><c>--user-principal-name</c> via <see cref="AzureAdUserCreateSettings.UserPrincipalName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdUserCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdUserCreate(Configure<AzureAdUserCreateSettings> configurator)
        {
            return AzureAdUserCreate(configurator(new AzureAdUserCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdUserCreateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdUserCreateSettings.DisplayName"/></li>
        ///     <li><c>--force-change-password-next-login</c> via <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdUserCreateSettings.Help"/></li>
        ///     <li><c>--immutable-id</c> via <see cref="AzureAdUserCreateSettings.ImmutableId"/></li>
        ///     <li><c>--mail-nickname</c> via <see cref="AzureAdUserCreateSettings.MailNickname"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdUserCreateSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureAdUserCreateSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdUserCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdUserCreateSettings.Subscription"/></li>
        ///     <li><c>--user-principal-name</c> via <see cref="AzureAdUserCreateSettings.UserPrincipalName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdUserCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdUserCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdUserCreate(CombinatorialConfigure<AzureAdUserCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdUserCreate, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdUserDelete(AzureAdUserDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdUserDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdUserDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdUserDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdUserDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdUserDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdUserDeleteSettings.Subscription"/></li>
        ///     <li><c>--upn-or-object-id</c> via <see cref="AzureAdUserDeleteSettings.UpnOrObjectId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdUserDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdUserDelete(Configure<AzureAdUserDeleteSettings> configurator)
        {
            return AzureAdUserDelete(configurator(new AzureAdUserDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdUserDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdUserDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdUserDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdUserDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdUserDeleteSettings.Subscription"/></li>
        ///     <li><c>--upn-or-object-id</c> via <see cref="AzureAdUserDeleteSettings.UpnOrObjectId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdUserDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdUserDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdUserDelete(CombinatorialConfigure<AzureAdUserDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdUserDelete, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdUserGetMemberGroups(AzureAdUserGetMemberGroupsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdUserGetMemberGroupsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdUserGetMemberGroupsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdUserGetMemberGroupsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdUserGetMemberGroupsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdUserGetMemberGroupsSettings.Query"/></li>
        ///     <li><c>--security-enabled-only</c> via <see cref="AzureAdUserGetMemberGroupsSettings.SecurityEnabledOnly"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdUserGetMemberGroupsSettings.Subscription"/></li>
        ///     <li><c>--upn-or-object-id</c> via <see cref="AzureAdUserGetMemberGroupsSettings.UpnOrObjectId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdUserGetMemberGroupsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdUserGetMemberGroups(Configure<AzureAdUserGetMemberGroupsSettings> configurator)
        {
            return AzureAdUserGetMemberGroups(configurator(new AzureAdUserGetMemberGroupsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdUserGetMemberGroupsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdUserGetMemberGroupsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdUserGetMemberGroupsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdUserGetMemberGroupsSettings.Query"/></li>
        ///     <li><c>--security-enabled-only</c> via <see cref="AzureAdUserGetMemberGroupsSettings.SecurityEnabledOnly"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdUserGetMemberGroupsSettings.Subscription"/></li>
        ///     <li><c>--upn-or-object-id</c> via <see cref="AzureAdUserGetMemberGroupsSettings.UpnOrObjectId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdUserGetMemberGroupsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdUserGetMemberGroupsSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdUserGetMemberGroups(CombinatorialConfigure<AzureAdUserGetMemberGroupsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdUserGetMemberGroups, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdUserList(AzureAdUserListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdUserListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdUserListSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdUserListSettings.DisplayName"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureAdUserListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdUserListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdUserListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdUserListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdUserListSettings.Subscription"/></li>
        ///     <li><c>--upn</c> via <see cref="AzureAdUserListSettings.Upn"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdUserListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdUserList(Configure<AzureAdUserListSettings> configurator)
        {
            return AzureAdUserList(configurator(new AzureAdUserListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdUserListSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureAdUserListSettings.DisplayName"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureAdUserListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdUserListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdUserListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdUserListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdUserListSettings.Subscription"/></li>
        ///     <li><c>--upn</c> via <see cref="AzureAdUserListSettings.Upn"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdUserListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdUserListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdUserList(CombinatorialConfigure<AzureAdUserListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdUserList, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdUserShow(AzureAdUserShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdUserShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdUserShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdUserShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdUserShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdUserShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdUserShowSettings.Subscription"/></li>
        ///     <li><c>--upn-or-object-id</c> via <see cref="AzureAdUserShowSettings.UpnOrObjectId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdUserShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdUserShow(Configure<AzureAdUserShowSettings> configurator)
        {
            return AzureAdUserShow(configurator(new AzureAdUserShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdUserShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdUserShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdUserShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdUserShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdUserShowSettings.Subscription"/></li>
        ///     <li><c>--upn-or-object-id</c> via <see cref="AzureAdUserShowSettings.UpnOrObjectId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdUserShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdUserShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdUserShow(CombinatorialConfigure<AzureAdUserShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdUserShow, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppCredentialDelete(AzureAdAppCredentialDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppCredentialDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cert</c> via <see cref="AzureAdAppCredentialDeleteSettings.Cert"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppCredentialDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppCredentialDeleteSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppCredentialDeleteSettings.Id"/></li>
        ///     <li><c>--key-id</c> via <see cref="AzureAdAppCredentialDeleteSettings.KeyId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppCredentialDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppCredentialDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppCredentialDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppCredentialDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppCredentialDelete(Configure<AzureAdAppCredentialDeleteSettings> configurator)
        {
            return AzureAdAppCredentialDelete(configurator(new AzureAdAppCredentialDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cert</c> via <see cref="AzureAdAppCredentialDeleteSettings.Cert"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppCredentialDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppCredentialDeleteSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppCredentialDeleteSettings.Id"/></li>
        ///     <li><c>--key-id</c> via <see cref="AzureAdAppCredentialDeleteSettings.KeyId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppCredentialDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppCredentialDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppCredentialDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppCredentialDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppCredentialDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppCredentialDelete(CombinatorialConfigure<AzureAdAppCredentialDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppCredentialDelete, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppCredentialList(AzureAdAppCredentialListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppCredentialListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cert</c> via <see cref="AzureAdAppCredentialListSettings.Cert"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppCredentialListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppCredentialListSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppCredentialListSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppCredentialListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppCredentialListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppCredentialListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppCredentialListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppCredentialList(Configure<AzureAdAppCredentialListSettings> configurator)
        {
            return AzureAdAppCredentialList(configurator(new AzureAdAppCredentialListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cert</c> via <see cref="AzureAdAppCredentialListSettings.Cert"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppCredentialListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppCredentialListSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppCredentialListSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppCredentialListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppCredentialListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppCredentialListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppCredentialListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppCredentialListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppCredentialList(CombinatorialConfigure<AzureAdAppCredentialListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppCredentialList, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppCredentialReset(AzureAdAppCredentialResetSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppCredentialResetSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--append</c> via <see cref="AzureAdAppCredentialResetSettings.Append"/></li>
        ///     <li><c>--cert</c> via <see cref="AzureAdAppCredentialResetSettings.Cert"/></li>
        ///     <li><c>--create-cert</c> via <see cref="AzureAdAppCredentialResetSettings.CreateCert"/></li>
        ///     <li><c>--credential-description</c> via <see cref="AzureAdAppCredentialResetSettings.CredentialDescription"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppCredentialResetSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureAdAppCredentialResetSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppCredentialResetSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppCredentialResetSettings.Id"/></li>
        ///     <li><c>--keyvault</c> via <see cref="AzureAdAppCredentialResetSettings.Keyvault"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppCredentialResetSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureAdAppCredentialResetSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppCredentialResetSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppCredentialResetSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppCredentialResetSettings.Verbose"/></li>
        ///     <li><c>--years</c> via <see cref="AzureAdAppCredentialResetSettings.Years"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppCredentialReset(Configure<AzureAdAppCredentialResetSettings> configurator)
        {
            return AzureAdAppCredentialReset(configurator(new AzureAdAppCredentialResetSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--append</c> via <see cref="AzureAdAppCredentialResetSettings.Append"/></li>
        ///     <li><c>--cert</c> via <see cref="AzureAdAppCredentialResetSettings.Cert"/></li>
        ///     <li><c>--create-cert</c> via <see cref="AzureAdAppCredentialResetSettings.CreateCert"/></li>
        ///     <li><c>--credential-description</c> via <see cref="AzureAdAppCredentialResetSettings.CredentialDescription"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppCredentialResetSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureAdAppCredentialResetSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppCredentialResetSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppCredentialResetSettings.Id"/></li>
        ///     <li><c>--keyvault</c> via <see cref="AzureAdAppCredentialResetSettings.Keyvault"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppCredentialResetSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureAdAppCredentialResetSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppCredentialResetSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppCredentialResetSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppCredentialResetSettings.Verbose"/></li>
        ///     <li><c>--years</c> via <see cref="AzureAdAppCredentialResetSettings.Years"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppCredentialResetSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppCredentialReset(CombinatorialConfigure<AzureAdAppCredentialResetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppCredentialReset, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppOwnerAdd(AzureAdAppOwnerAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppOwnerAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppOwnerAddSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppOwnerAddSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppOwnerAddSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppOwnerAddSettings.Output"/></li>
        ///     <li><c>--owner-object-id</c> via <see cref="AzureAdAppOwnerAddSettings.OwnerObjectId"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppOwnerAddSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppOwnerAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppOwnerAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppOwnerAdd(Configure<AzureAdAppOwnerAddSettings> configurator)
        {
            return AzureAdAppOwnerAdd(configurator(new AzureAdAppOwnerAddSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppOwnerAddSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppOwnerAddSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppOwnerAddSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppOwnerAddSettings.Output"/></li>
        ///     <li><c>--owner-object-id</c> via <see cref="AzureAdAppOwnerAddSettings.OwnerObjectId"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppOwnerAddSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppOwnerAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppOwnerAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppOwnerAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppOwnerAdd(CombinatorialConfigure<AzureAdAppOwnerAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppOwnerAdd, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppOwnerList(AzureAdAppOwnerListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppOwnerListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppOwnerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppOwnerListSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppOwnerListSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppOwnerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppOwnerListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppOwnerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppOwnerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppOwnerList(Configure<AzureAdAppOwnerListSettings> configurator)
        {
            return AzureAdAppOwnerList(configurator(new AzureAdAppOwnerListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppOwnerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppOwnerListSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppOwnerListSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppOwnerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppOwnerListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppOwnerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppOwnerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppOwnerListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppOwnerList(CombinatorialConfigure<AzureAdAppOwnerListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppOwnerList, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppOwnerRemove(AzureAdAppOwnerRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppOwnerRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppOwnerRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppOwnerRemoveSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppOwnerRemoveSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppOwnerRemoveSettings.Output"/></li>
        ///     <li><c>--owner-object-id</c> via <see cref="AzureAdAppOwnerRemoveSettings.OwnerObjectId"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppOwnerRemoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppOwnerRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppOwnerRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppOwnerRemove(Configure<AzureAdAppOwnerRemoveSettings> configurator)
        {
            return AzureAdAppOwnerRemove(configurator(new AzureAdAppOwnerRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppOwnerRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppOwnerRemoveSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppOwnerRemoveSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppOwnerRemoveSettings.Output"/></li>
        ///     <li><c>--owner-object-id</c> via <see cref="AzureAdAppOwnerRemoveSettings.OwnerObjectId"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppOwnerRemoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppOwnerRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppOwnerRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppOwnerRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppOwnerRemove(CombinatorialConfigure<AzureAdAppOwnerRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppOwnerRemove, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionAdd(AzureAdAppPermissionAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppPermissionAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api</c> via <see cref="AzureAdAppPermissionAddSettings.Api"/></li>
        ///     <li><c>--api-permissions</c> via <see cref="AzureAdAppPermissionAddSettings.ApiPermissions"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppPermissionAddSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppPermissionAddSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppPermissionAddSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppPermissionAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppPermissionAddSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppPermissionAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppPermissionAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionAdd(Configure<AzureAdAppPermissionAddSettings> configurator)
        {
            return AzureAdAppPermissionAdd(configurator(new AzureAdAppPermissionAddSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api</c> via <see cref="AzureAdAppPermissionAddSettings.Api"/></li>
        ///     <li><c>--api-permissions</c> via <see cref="AzureAdAppPermissionAddSettings.ApiPermissions"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppPermissionAddSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppPermissionAddSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppPermissionAddSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppPermissionAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppPermissionAddSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppPermissionAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppPermissionAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppPermissionAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppPermissionAdd(CombinatorialConfigure<AzureAdAppPermissionAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppPermissionAdd, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionAdminConsent(AzureAdAppPermissionAdminConsentSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppPermissionAdminConsentSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionAdminConsent(Configure<AzureAdAppPermissionAdminConsentSettings> configurator)
        {
            return AzureAdAppPermissionAdminConsent(configurator(new AzureAdAppPermissionAdminConsentSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppPermissionAdminConsentSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppPermissionAdminConsentSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppPermissionAdminConsent(CombinatorialConfigure<AzureAdAppPermissionAdminConsentSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppPermissionAdminConsent, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionDelete(AzureAdAppPermissionDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppPermissionDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api</c> via <see cref="AzureAdAppPermissionDeleteSettings.Api"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppPermissionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppPermissionDeleteSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppPermissionDeleteSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppPermissionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppPermissionDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppPermissionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppPermissionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionDelete(Configure<AzureAdAppPermissionDeleteSettings> configurator)
        {
            return AzureAdAppPermissionDelete(configurator(new AzureAdAppPermissionDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api</c> via <see cref="AzureAdAppPermissionDeleteSettings.Api"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppPermissionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppPermissionDeleteSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppPermissionDeleteSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppPermissionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppPermissionDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppPermissionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppPermissionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppPermissionDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppPermissionDelete(CombinatorialConfigure<AzureAdAppPermissionDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppPermissionDelete, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionGrant(AzureAdAppPermissionGrantSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppPermissionGrantSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api</c> via <see cref="AzureAdAppPermissionGrantSettings.Api"/></li>
        ///     <li><c>--consent-type</c> via <see cref="AzureAdAppPermissionGrantSettings.ConsentType"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppPermissionGrantSettings.Debug"/></li>
        ///     <li><c>--expires</c> via <see cref="AzureAdAppPermissionGrantSettings.Expires"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppPermissionGrantSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppPermissionGrantSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppPermissionGrantSettings.Output"/></li>
        ///     <li><c>--principal-id</c> via <see cref="AzureAdAppPermissionGrantSettings.PrincipalId"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppPermissionGrantSettings.Query"/></li>
        ///     <li><c>--scope</c> via <see cref="AzureAdAppPermissionGrantSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppPermissionGrantSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppPermissionGrantSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionGrant(Configure<AzureAdAppPermissionGrantSettings> configurator)
        {
            return AzureAdAppPermissionGrant(configurator(new AzureAdAppPermissionGrantSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api</c> via <see cref="AzureAdAppPermissionGrantSettings.Api"/></li>
        ///     <li><c>--consent-type</c> via <see cref="AzureAdAppPermissionGrantSettings.ConsentType"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppPermissionGrantSettings.Debug"/></li>
        ///     <li><c>--expires</c> via <see cref="AzureAdAppPermissionGrantSettings.Expires"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppPermissionGrantSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppPermissionGrantSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppPermissionGrantSettings.Output"/></li>
        ///     <li><c>--principal-id</c> via <see cref="AzureAdAppPermissionGrantSettings.PrincipalId"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppPermissionGrantSettings.Query"/></li>
        ///     <li><c>--scope</c> via <see cref="AzureAdAppPermissionGrantSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppPermissionGrantSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppPermissionGrantSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppPermissionGrantSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppPermissionGrant(CombinatorialConfigure<AzureAdAppPermissionGrantSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppPermissionGrant, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionList(AzureAdAppPermissionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppPermissionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppPermissionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppPermissionListSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppPermissionListSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppPermissionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppPermissionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppPermissionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppPermissionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionList(Configure<AzureAdAppPermissionListSettings> configurator)
        {
            return AzureAdAppPermissionList(configurator(new AzureAdAppPermissionListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppPermissionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppPermissionListSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppPermissionListSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppPermissionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppPermissionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppPermissionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppPermissionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppPermissionListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppPermissionList(CombinatorialConfigure<AzureAdAppPermissionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppPermissionList, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionListGrants(AzureAdAppPermissionListGrantsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdAppPermissionListGrantsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Debug"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Query"/></li>
        ///     <li><c>--show-resource-name</c> via <see cref="AzureAdAppPermissionListGrantsSettings.ShowResourceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionListGrants(Configure<AzureAdAppPermissionListGrantsSettings> configurator)
        {
            return AzureAdAppPermissionListGrants(configurator(new AzureAdAppPermissionListGrantsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Debug"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Query"/></li>
        ///     <li><c>--show-resource-name</c> via <see cref="AzureAdAppPermissionListGrantsSettings.ShowResourceName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdAppPermissionListGrantsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdAppPermissionListGrantsSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdAppPermissionListGrants(CombinatorialConfigure<AzureAdAppPermissionListGrantsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdAppPermissionListGrants, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberAdd(AzureAdGroupMemberAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdGroupMemberAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--additional-properties</c> via <see cref="AzureAdGroupMemberAddSettings.AdditionalProperties"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupMemberAddSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupMemberAddSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupMemberAddSettings.Help"/></li>
        ///     <li><c>--member-id</c> via <see cref="AzureAdGroupMemberAddSettings.MemberId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupMemberAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupMemberAddSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupMemberAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupMemberAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberAdd(Configure<AzureAdGroupMemberAddSettings> configurator)
        {
            return AzureAdGroupMemberAdd(configurator(new AzureAdGroupMemberAddSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--additional-properties</c> via <see cref="AzureAdGroupMemberAddSettings.AdditionalProperties"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupMemberAddSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupMemberAddSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupMemberAddSettings.Help"/></li>
        ///     <li><c>--member-id</c> via <see cref="AzureAdGroupMemberAddSettings.MemberId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupMemberAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupMemberAddSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupMemberAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupMemberAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdGroupMemberAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdGroupMemberAdd(CombinatorialConfigure<AzureAdGroupMemberAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdGroupMemberAdd, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberCheck(AzureAdGroupMemberCheckSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdGroupMemberCheckSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupMemberCheckSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupMemberCheckSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupMemberCheckSettings.Help"/></li>
        ///     <li><c>--member-id</c> via <see cref="AzureAdGroupMemberCheckSettings.MemberId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupMemberCheckSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupMemberCheckSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupMemberCheckSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupMemberCheckSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberCheck(Configure<AzureAdGroupMemberCheckSettings> configurator)
        {
            return AzureAdGroupMemberCheck(configurator(new AzureAdGroupMemberCheckSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupMemberCheckSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupMemberCheckSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupMemberCheckSettings.Help"/></li>
        ///     <li><c>--member-id</c> via <see cref="AzureAdGroupMemberCheckSettings.MemberId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupMemberCheckSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupMemberCheckSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupMemberCheckSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupMemberCheckSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdGroupMemberCheckSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdGroupMemberCheck(CombinatorialConfigure<AzureAdGroupMemberCheckSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdGroupMemberCheck, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberList(AzureAdGroupMemberListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdGroupMemberListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupMemberListSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupMemberListSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupMemberListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupMemberListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupMemberListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupMemberListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupMemberListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberList(Configure<AzureAdGroupMemberListSettings> configurator)
        {
            return AzureAdGroupMemberList(configurator(new AzureAdGroupMemberListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupMemberListSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupMemberListSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupMemberListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupMemberListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupMemberListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupMemberListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupMemberListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdGroupMemberListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdGroupMemberList(CombinatorialConfigure<AzureAdGroupMemberListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdGroupMemberList, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberRemove(AzureAdGroupMemberRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdGroupMemberRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupMemberRemoveSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupMemberRemoveSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupMemberRemoveSettings.Help"/></li>
        ///     <li><c>--member-id</c> via <see cref="AzureAdGroupMemberRemoveSettings.MemberId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupMemberRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupMemberRemoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupMemberRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupMemberRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberRemove(Configure<AzureAdGroupMemberRemoveSettings> configurator)
        {
            return AzureAdGroupMemberRemove(configurator(new AzureAdGroupMemberRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupMemberRemoveSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupMemberRemoveSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupMemberRemoveSettings.Help"/></li>
        ///     <li><c>--member-id</c> via <see cref="AzureAdGroupMemberRemoveSettings.MemberId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupMemberRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupMemberRemoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupMemberRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupMemberRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdGroupMemberRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdGroupMemberRemove(CombinatorialConfigure<AzureAdGroupMemberRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdGroupMemberRemove, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdGroupOwnerAdd(AzureAdGroupOwnerAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdGroupOwnerAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupOwnerAddSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupOwnerAddSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupOwnerAddSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupOwnerAddSettings.Output"/></li>
        ///     <li><c>--owner-object-id</c> via <see cref="AzureAdGroupOwnerAddSettings.OwnerObjectId"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupOwnerAddSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupOwnerAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupOwnerAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdGroupOwnerAdd(Configure<AzureAdGroupOwnerAddSettings> configurator)
        {
            return AzureAdGroupOwnerAdd(configurator(new AzureAdGroupOwnerAddSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupOwnerAddSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupOwnerAddSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupOwnerAddSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupOwnerAddSettings.Output"/></li>
        ///     <li><c>--owner-object-id</c> via <see cref="AzureAdGroupOwnerAddSettings.OwnerObjectId"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupOwnerAddSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupOwnerAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupOwnerAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdGroupOwnerAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdGroupOwnerAdd(CombinatorialConfigure<AzureAdGroupOwnerAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdGroupOwnerAdd, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdGroupOwnerList(AzureAdGroupOwnerListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdGroupOwnerListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupOwnerListSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupOwnerListSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupOwnerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupOwnerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupOwnerListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupOwnerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupOwnerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdGroupOwnerList(Configure<AzureAdGroupOwnerListSettings> configurator)
        {
            return AzureAdGroupOwnerList(configurator(new AzureAdGroupOwnerListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupOwnerListSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupOwnerListSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupOwnerListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupOwnerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupOwnerListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupOwnerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupOwnerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdGroupOwnerListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdGroupOwnerList(CombinatorialConfigure<AzureAdGroupOwnerListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdGroupOwnerList, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdGroupOwnerRemove(AzureAdGroupOwnerRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdGroupOwnerRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Output"/></li>
        ///     <li><c>--owner-object-id</c> via <see cref="AzureAdGroupOwnerRemoveSettings.OwnerObjectId"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdGroupOwnerRemove(Configure<AzureAdGroupOwnerRemoveSettings> configurator)
        {
            return AzureAdGroupOwnerRemove(configurator(new AzureAdGroupOwnerRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Debug"/></li>
        ///     <li><c>--group</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Output"/></li>
        ///     <li><c>--owner-object-id</c> via <see cref="AzureAdGroupOwnerRemoveSettings.OwnerObjectId"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdGroupOwnerRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdGroupOwnerRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdGroupOwnerRemove(CombinatorialConfigure<AzureAdGroupOwnerRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdGroupOwnerRemove, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdSpCredentialDelete(AzureAdSpCredentialDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdSpCredentialDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cert</c> via <see cref="AzureAdSpCredentialDeleteSettings.Cert"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpCredentialDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpCredentialDeleteSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpCredentialDeleteSettings.Id"/></li>
        ///     <li><c>--key-id</c> via <see cref="AzureAdSpCredentialDeleteSettings.KeyId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpCredentialDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpCredentialDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpCredentialDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpCredentialDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdSpCredentialDelete(Configure<AzureAdSpCredentialDeleteSettings> configurator)
        {
            return AzureAdSpCredentialDelete(configurator(new AzureAdSpCredentialDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cert</c> via <see cref="AzureAdSpCredentialDeleteSettings.Cert"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpCredentialDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpCredentialDeleteSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpCredentialDeleteSettings.Id"/></li>
        ///     <li><c>--key-id</c> via <see cref="AzureAdSpCredentialDeleteSettings.KeyId"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpCredentialDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpCredentialDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpCredentialDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpCredentialDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdSpCredentialDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdSpCredentialDelete(CombinatorialConfigure<AzureAdSpCredentialDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdSpCredentialDelete, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdSpCredentialList(AzureAdSpCredentialListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdSpCredentialListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cert</c> via <see cref="AzureAdSpCredentialListSettings.Cert"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpCredentialListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpCredentialListSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpCredentialListSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpCredentialListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpCredentialListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpCredentialListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpCredentialListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdSpCredentialList(Configure<AzureAdSpCredentialListSettings> configurator)
        {
            return AzureAdSpCredentialList(configurator(new AzureAdSpCredentialListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cert</c> via <see cref="AzureAdSpCredentialListSettings.Cert"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpCredentialListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpCredentialListSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpCredentialListSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpCredentialListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpCredentialListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpCredentialListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpCredentialListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdSpCredentialListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdSpCredentialList(CombinatorialConfigure<AzureAdSpCredentialListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdSpCredentialList, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdSpCredentialReset(AzureAdSpCredentialResetSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdSpCredentialResetSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--append</c> via <see cref="AzureAdSpCredentialResetSettings.Append"/></li>
        ///     <li><c>--cert</c> via <see cref="AzureAdSpCredentialResetSettings.Cert"/></li>
        ///     <li><c>--create-cert</c> via <see cref="AzureAdSpCredentialResetSettings.CreateCert"/></li>
        ///     <li><c>--credential-description</c> via <see cref="AzureAdSpCredentialResetSettings.CredentialDescription"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpCredentialResetSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureAdSpCredentialResetSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpCredentialResetSettings.Help"/></li>
        ///     <li><c>--keyvault</c> via <see cref="AzureAdSpCredentialResetSettings.Keyvault"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAdSpCredentialResetSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpCredentialResetSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureAdSpCredentialResetSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpCredentialResetSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpCredentialResetSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpCredentialResetSettings.Verbose"/></li>
        ///     <li><c>--years</c> via <see cref="AzureAdSpCredentialResetSettings.Years"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdSpCredentialReset(Configure<AzureAdSpCredentialResetSettings> configurator)
        {
            return AzureAdSpCredentialReset(configurator(new AzureAdSpCredentialResetSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--append</c> via <see cref="AzureAdSpCredentialResetSettings.Append"/></li>
        ///     <li><c>--cert</c> via <see cref="AzureAdSpCredentialResetSettings.Cert"/></li>
        ///     <li><c>--create-cert</c> via <see cref="AzureAdSpCredentialResetSettings.CreateCert"/></li>
        ///     <li><c>--credential-description</c> via <see cref="AzureAdSpCredentialResetSettings.CredentialDescription"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpCredentialResetSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureAdSpCredentialResetSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpCredentialResetSettings.Help"/></li>
        ///     <li><c>--keyvault</c> via <see cref="AzureAdSpCredentialResetSettings.Keyvault"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAdSpCredentialResetSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpCredentialResetSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureAdSpCredentialResetSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpCredentialResetSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpCredentialResetSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpCredentialResetSettings.Verbose"/></li>
        ///     <li><c>--years</c> via <see cref="AzureAdSpCredentialResetSettings.Years"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdSpCredentialResetSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdSpCredentialReset(CombinatorialConfigure<AzureAdSpCredentialResetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdSpCredentialReset, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAdSpOwnerList(AzureAdSpOwnerListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAdSpOwnerListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpOwnerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpOwnerListSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpOwnerListSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpOwnerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpOwnerListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpOwnerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpOwnerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAdSpOwnerList(Configure<AzureAdSpOwnerListSettings> configurator)
        {
            return AzureAdSpOwnerList(configurator(new AzureAdSpOwnerListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAdSpOwnerListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAdSpOwnerListSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureAdSpOwnerListSettings.Id"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAdSpOwnerListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAdSpOwnerListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAdSpOwnerListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAdSpOwnerListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAdSpOwnerListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAdSpOwnerList(CombinatorialConfigure<AzureAdSpOwnerListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAdSpOwnerList, AzureAdLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureAdSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
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
              .Add("ad")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdAppCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   The display name of the application.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   Declare the roles you want to associate with your application. Should be in manifest json format. See examples below for details.
        /// </summary>
        public virtual string AppRoles { get; internal set; }
        /// <summary>
        ///   The application can be used from any Azure AD tenants.
        /// </summary>
        public virtual bool? AvailableToOtherTenants { get; internal set; }
        /// <summary>
        ///   The description of the password.
        /// </summary>
        public virtual string CredentialDescription { get; internal set; }
        /// <summary>
        ///   Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.
        /// </summary>
        public virtual string EndDate { get; internal set; }
        /// <summary>
        ///   The url where users can sign in and use your app.
        /// </summary>
        public virtual string Homepage { get; internal set; }
        /// <summary>
        ///   Space-separated unique URIs that Azure AD can use for this app.
        /// </summary>
        public virtual IReadOnlyList<string> IdentifierUris => IdentifierUrisInternal.AsReadOnly();
        internal List<string> IdentifierUrisInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The type of the key credentials associated with the application.
        /// </summary>
        public virtual AdAppKeyType KeyType { get; internal set; }
        /// <summary>
        ///   The usage of the key credentials associated with the application.
        /// </summary>
        public virtual AdAppKeyUsage KeyUsage { get; internal set; }
        /// <summary>
        ///   The value for the key credentials associated with the application.
        /// </summary>
        public virtual string KeyValue { get; internal set; }
        /// <summary>
        ///   An application which can be installed on a user's device or computer.
        /// </summary>
        public virtual bool? NativeApp { get; internal set; }
        /// <summary>
        ///   Whether to allow implicit grant flow for OAuth2.
        /// </summary>
        public virtual bool? Oauth2AllowImplicitFlow { get; internal set; }
        /// <summary>
        ///   App password, aka 'client secret'.
        /// </summary>
        public virtual string Password { get; internal set; }
        /// <summary>
        ///   Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.
        /// </summary>
        public virtual IReadOnlyList<string> ReplyUrls => ReplyUrlsInternal.AsReadOnly();
        internal List<string> ReplyUrlsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.
        /// </summary>
        public virtual string RequiredResourceAccesses { get; internal set; }
        /// <summary>
        ///   Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.
        /// </summary>
        public virtual string StartDate { get; internal set; }
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
              .Add("ad app create")
              .Add("--display-name {value}", DisplayName)
              .Add("--app-roles {value}", AppRoles)
              .Add("--available-to-other-tenants", AvailableToOtherTenants)
              .Add("--credential-description {value}", CredentialDescription)
              .Add("--end-date {value}", EndDate)
              .Add("--homepage {value}", Homepage)
              .Add("--identifier-uris {value}", IdentifierUris, separator: ' ')
              .Add("--key-type {value}", KeyType)
              .Add("--key-usage {value}", KeyUsage)
              .Add("--key-value {value}", KeyValue)
              .Add("--native-app", NativeApp)
              .Add("--oauth2-allow-implicit-flow", Oauth2AllowImplicitFlow)
              .Add("--password {value}", Password, secret: true)
              .Add("--reply-urls {value}", ReplyUrls, separator: ' ')
              .Add("--required-resource-accesses {value}", RequiredResourceAccesses)
              .Add("--start-date {value}", StartDate)
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
    #region AzureAdAppDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Identifier uri, application id, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app delete")
              .Add("--id {value}", Id)
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
    #region AzureAdAppListSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   List all entities, expect long delay if under a big organization.
        /// </summary>
        public virtual string All { get; internal set; }
        /// <summary>
        ///   Application id.
        /// </summary>
        public virtual string AppId { get; internal set; }
        /// <summary>
        ///   The display name of the application.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   OData filter.
        /// </summary>
        public virtual string Filter { get; internal set; }
        /// <summary>
        ///   Graph application identifier, must be in uri format.
        /// </summary>
        public virtual string IdentifierUri { get; internal set; }
        /// <summary>
        ///   List entities owned by the current user.
        /// </summary>
        public virtual string ShowMine { get; internal set; }
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
              .Add("ad app list")
              .Add("--all {value}", All)
              .Add("--app-id {value}", AppId)
              .Add("--display-name {value}", DisplayName)
              .Add("--filter {value}", Filter)
              .Add("--identifier-uri {value}", IdentifierUri)
              .Add("--show-mine {value}", ShowMine)
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
    #region AzureAdAppShowSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Identifier uri, application id, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app show")
              .Add("--id {value}", Id)
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
    #region AzureAdAppUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Identifier uri, application id, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Declare the roles you want to associate with your application. Should be in manifest json format. See examples below for details.
        /// </summary>
        public virtual string AppRoles { get; internal set; }
        /// <summary>
        ///   The application can be used from any Azure AD tenants.
        /// </summary>
        public virtual bool? AvailableToOtherTenants { get; internal set; }
        /// <summary>
        ///   The description of the password.
        /// </summary>
        public virtual string CredentialDescription { get; internal set; }
        /// <summary>
        ///   The display name of the application.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.
        /// </summary>
        public virtual string EndDate { get; internal set; }
        /// <summary>
        ///   The url where users can sign in and use your app.
        /// </summary>
        public virtual string Homepage { get; internal set; }
        /// <summary>
        ///   Space-separated unique URIs that Azure AD can use for this app.
        /// </summary>
        public virtual IReadOnlyList<string> IdentifierUris => IdentifierUrisInternal.AsReadOnly();
        internal List<string> IdentifierUrisInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The type of the key credentials associated with the application.
        /// </summary>
        public virtual AdAppKeyType KeyType { get; internal set; }
        /// <summary>
        ///   The usage of the key credentials associated with the application.
        /// </summary>
        public virtual AdAppKeyUsage KeyUsage { get; internal set; }
        /// <summary>
        ///   The value for the key credentials associated with the application.
        /// </summary>
        public virtual string KeyValue { get; internal set; }
        /// <summary>
        ///   Whether to allow implicit grant flow for OAuth2.
        /// </summary>
        public virtual bool? Oauth2AllowImplicitFlow { get; internal set; }
        /// <summary>
        ///   App password, aka 'client secret'.
        /// </summary>
        public virtual string Password { get; internal set; }
        /// <summary>
        ///   Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.
        /// </summary>
        public virtual IReadOnlyList<string> ReplyUrls => ReplyUrlsInternal.AsReadOnly();
        internal List<string> ReplyUrlsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.
        /// </summary>
        public virtual string RequiredResourceAccesses { get; internal set; }
        /// <summary>
        ///   Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.
        /// </summary>
        public virtual string StartDate { get; internal set; }
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
              .Add("ad app update")
              .Add("--id {value}", Id)
              .Add("--app-roles {value}", AppRoles)
              .Add("--available-to-other-tenants", AvailableToOtherTenants)
              .Add("--credential-description {value}", CredentialDescription)
              .Add("--display-name {value}", DisplayName)
              .Add("--end-date {value}", EndDate)
              .Add("--homepage {value}", Homepage)
              .Add("--identifier-uris {value}", IdentifierUris, separator: ' ')
              .Add("--key-type {value}", KeyType)
              .Add("--key-usage {value}", KeyUsage)
              .Add("--key-value {value}", KeyValue)
              .Add("--oauth2-allow-implicit-flow", Oauth2AllowImplicitFlow)
              .Add("--password {value}", Password, secret: true)
              .Add("--reply-urls {value}", ReplyUrls, separator: ' ')
              .Add("--required-resource-accesses {value}", RequiredResourceAccesses)
              .Add("--start-date {value}", StartDate)
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
    #region AzureAdGroupCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Object's display name or its prefix.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   Mail nickname.
        /// </summary>
        public virtual string MailNickname { get; internal set; }
        /// <summary>
        ///   Always create a new group instead of updating the one with same display and mail nickname.
        /// </summary>
        public virtual bool? Force { get; internal set; }
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
              .Add("ad group create")
              .Add("--display-name {value}", DisplayName)
              .Add("--mail-nickname {value}", MailNickname)
              .Add("--force", Force)
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
    #region AzureAdGroupDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Group's object id or display name(prefix also works if there is a unique match).
        /// </summary>
        public virtual string Group { get; internal set; }
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
              .Add("ad group delete")
              .Add("--group {value}", Group)
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
    #region AzureAdGroupGetMemberGroupsSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupGetMemberGroupsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Group's object id or display name(prefix also works if there is a unique match).
        /// </summary>
        public virtual string Group { get; internal set; }
        /// <summary>
        ///   Unmatched properties from the message are deserialized this collection.
        /// </summary>
        public virtual string AdditionalProperties { get; internal set; }
        /// <summary>
        ///   If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.
        /// </summary>
        public virtual bool? SecurityEnabledOnly { get; internal set; }
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
              .Add("ad group get-member-groups")
              .Add("--group {value}", Group)
              .Add("--additional-properties {value}", AdditionalProperties)
              .Add("--security-enabled-only", SecurityEnabledOnly)
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
    #region AzureAdGroupListSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Object's display name or its prefix.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   OData filter.
        /// </summary>
        public virtual string Filter { get; internal set; }
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
              .Add("ad group list")
              .Add("--display-name {value}", DisplayName)
              .Add("--filter {value}", Filter)
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
    #region AzureAdGroupShowSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Group's object id or display name(prefix also works if there is a unique match).
        /// </summary>
        public virtual string Group { get; internal set; }
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
              .Add("ad group show")
              .Add("--group {value}", Group)
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
    #region AzureAdSignedInUserListOwnedObjectsSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSignedInUserListOwnedObjectsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Object type filter, e.g. "application", "servicePrincipal"  "group", etc.
        /// </summary>
        public virtual string Type { get; internal set; }
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
              .Add("ad signed-in-user list-owned-objects")
              .Add("--type {value}", Type)
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
    #region AzureAdSignedInUserShowSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSignedInUserShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
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
              .Add("ad signed-in-user show")
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
    #region AzureAdSpCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Identifier uri, application id, or object id of the associated application.
        /// </summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad sp create")
              .Add("--id {value}", Id)
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
    #region AzureAdSpCreateForRbacSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCreateForRbacSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   A URI to use as the logic name. It doesn't need to exist. If not present, CLI will generate one.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Role of the service principal.
        /// </summary>
        public virtual string Role { get; internal set; }
        /// <summary>
        ///   Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.
        /// </summary>
        public virtual IReadOnlyList<string> Scopes => ScopesInternal.AsReadOnly();
        internal List<string> ScopesInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Output result in compatible with Azure SDK auth file.
        /// </summary>
        public virtual bool? SdkAuth { get; internal set; }
        /// <summary>
        ///   Skip creating the default assignment, which allows the service principal to access resources under the current subscription.
        /// </summary>
        public virtual bool? SkipAssignment { get; internal set; }
        /// <summary>
        ///   Certificate to use for credentials.
        /// </summary>
        public virtual string Cert { get; internal set; }
        /// <summary>
        ///   Create a self-signed certificate to use for the credential.
        /// </summary>
        public virtual string CreateCert { get; internal set; }
        /// <summary>
        ///   Name or ID of a KeyVault to use for creating or retrieving certificates.
        /// </summary>
        public virtual string Keyvault { get; internal set; }
        /// <summary>
        ///   Password.
        /// </summary>
        public virtual string Password { get; internal set; }
        /// <summary>
        ///   Number of years for which the credentials will be valid. Default: 1 year.
        /// </summary>
        public virtual int? Years { get; internal set; }
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
              .Add("ad sp create-for-rbac")
              .Add("--name {value}", Name)
              .Add("--role {value}", Role)
              .Add("--scopes {value}", Scopes, separator: ' ')
              .Add("--sdk-auth", SdkAuth)
              .Add("--skip-assignment", SkipAssignment)
              .Add("--cert {value}", Cert)
              .Add("--create-cert {value}", CreateCert)
              .Add("--keyvault {value}", Keyvault)
              .Add("--password {value}", Password, secret: true)
              .Add("--years {value}", Years)
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
    #region AzureAdSpDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Service principal name, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad sp delete")
              .Add("--id {value}", Id)
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
    #region AzureAdSpListSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   List all entities, expect long delay if under a big organization.
        /// </summary>
        public virtual string All { get; internal set; }
        /// <summary>
        ///   Object's display name or its prefix.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   OData filter.
        /// </summary>
        public virtual string Filter { get; internal set; }
        /// <summary>
        ///   List entities owned by the current user.
        /// </summary>
        public virtual string ShowMine { get; internal set; }
        /// <summary>
        ///   Service principal name.
        /// </summary>
        public virtual string Spn { get; internal set; }
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
              .Add("ad sp list")
              .Add("--all {value}", All)
              .Add("--display-name {value}", DisplayName)
              .Add("--filter {value}", Filter)
              .Add("--show-mine {value}", ShowMine)
              .Add("--spn {value}", Spn)
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
    #region AzureAdSpShowSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Service principal name, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad sp show")
              .Add("--id {value}", Id)
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
    #region AzureAdSpUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Service principal name, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad sp update")
              .Add("--id {value}", Id)
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
    #region AzureAdUserCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Object's display name or its prefix.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   User password.
        /// </summary>
        public virtual string Password { get; internal set; }
        /// <summary>
        ///   Required. The user principal name (someuser@contoso.com). It must contain one of the verified domains for the tenant.
        /// </summary>
        public virtual string UserPrincipalName { get; internal set; }
        /// <summary>
        ///   Require the user to change their password the next time they log in.
        /// </summary>
        public virtual bool? ForceChangePasswordNextLogin { get; internal set; }
        /// <summary>
        ///   This must be specified if you are using a federated domain for the user's userPrincipalName (UPN) property when creating a new user account. It is used to associate an on-premises Active Directory user account with their Azure AD user object.
        /// </summary>
        public virtual string ImmutableId { get; internal set; }
        /// <summary>
        ///   Mail alias. Defaults to user principal name.
        /// </summary>
        public virtual string MailNickname { get; internal set; }
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
              .Add("ad user create")
              .Add("--display-name {value}", DisplayName)
              .Add("--password {value}", Password, secret: true)
              .Add("--user-principal-name {value}", UserPrincipalName)
              .Add("--force-change-password-next-login", ForceChangePasswordNextLogin, secret: true)
              .Add("--immutable-id {value}", ImmutableId)
              .Add("--mail-nickname {value}", MailNickname)
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
    #region AzureAdUserDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   The object ID or principal name of the user to delete.
        /// </summary>
        public virtual string UpnOrObjectId { get; internal set; }
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
              .Add("ad user delete")
              .Add("--upn-or-object-id {value}", UpnOrObjectId)
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
    #region AzureAdUserGetMemberGroupsSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserGetMemberGroupsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   The object ID or principal name of the user for which to get information.
        /// </summary>
        public virtual string UpnOrObjectId { get; internal set; }
        /// <summary>
        ///   If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.
        /// </summary>
        public virtual bool? SecurityEnabledOnly { get; internal set; }
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
              .Add("ad user get-member-groups")
              .Add("--upn-or-object-id {value}", UpnOrObjectId)
              .Add("--security-enabled-only", SecurityEnabledOnly)
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
    #region AzureAdUserListSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Object's display name or its prefix.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   OData filter.
        /// </summary>
        public virtual string Filter { get; internal set; }
        /// <summary>
        ///   User principal name, e.g. john.doe@contoso.com.
        /// </summary>
        public virtual string Upn { get; internal set; }
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
              .Add("ad user list")
              .Add("--display-name {value}", DisplayName)
              .Add("--filter {value}", Filter)
              .Add("--upn {value}", Upn)
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
    #region AzureAdUserShowSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   The object ID or principal name of the user for which to get information.
        /// </summary>
        public virtual string UpnOrObjectId { get; internal set; }
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
              .Add("ad user show")
              .Add("--upn-or-object-id {value}", UpnOrObjectId)
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
    #region AzureAdAppCredentialDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppCredentialDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Identifier uri, application id, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Credential key id.
        /// </summary>
        public virtual string KeyId { get; internal set; }
        /// <summary>
        ///   A certificate based credential.
        /// </summary>
        public virtual string Cert { get; internal set; }
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
              .Add("ad app credential delete")
              .Add("--id {value}", Id)
              .Add("--key-id {value}", KeyId)
              .Add("--cert {value}", Cert)
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
    #region AzureAdAppCredentialListSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppCredentialListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Identifier uri, application id, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   A certificate based credential.
        /// </summary>
        public virtual string Cert { get; internal set; }
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
              .Add("ad app credential list")
              .Add("--id {value}", Id)
              .Add("--cert {value}", Cert)
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
    #region AzureAdAppCredentialResetSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppCredentialResetSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Identifier uri, application id, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Append the new credential instead of overwriting.
        /// </summary>
        public virtual string Append { get; internal set; }
        /// <summary>
        ///   The description of the password.
        /// </summary>
        public virtual string CredentialDescription { get; internal set; }
        /// <summary>
        ///   Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.
        /// </summary>
        public virtual string EndDate { get; internal set; }
        /// <summary>
        ///   Certificate to use for credentials.
        /// </summary>
        public virtual string Cert { get; internal set; }
        /// <summary>
        ///   Create a self-signed certificate to use for the credential.
        /// </summary>
        public virtual string CreateCert { get; internal set; }
        /// <summary>
        ///   Name or ID of a KeyVault to use for creating or retrieving certificates.
        /// </summary>
        public virtual string Keyvault { get; internal set; }
        /// <summary>
        ///   App password, aka 'client secret'.
        /// </summary>
        public virtual string Password { get; internal set; }
        /// <summary>
        ///   Number of years for which the credentials will be valid.
        /// </summary>
        public virtual int? Years { get; internal set; }
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
              .Add("ad app credential reset")
              .Add("--id {value}", Id)
              .Add("--append {value}", Append)
              .Add("--credential-description {value}", CredentialDescription)
              .Add("--end-date {value}", EndDate)
              .Add("--cert {value}", Cert)
              .Add("--create-cert {value}", CreateCert)
              .Add("--keyvault {value}", Keyvault)
              .Add("--password {value}", Password, secret: true)
              .Add("--years {value}", Years)
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
    #region AzureAdAppOwnerAddSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppOwnerAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Identifier uri, application id, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Owner's object id.
        /// </summary>
        public virtual string OwnerObjectId { get; internal set; }
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
              .Add("ad app owner add")
              .Add("--id {value}", Id)
              .Add("--owner-object-id {value}", OwnerObjectId)
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
    #region AzureAdAppOwnerListSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppOwnerListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Identifier uri, application id, or object id of the application.
        /// </summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app owner list")
              .Add("--id {value}", Id)
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
    #region AzureAdAppOwnerRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppOwnerRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Identifier uri, application id, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Owner's object id.
        /// </summary>
        public virtual string OwnerObjectId { get; internal set; }
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
              .Add("ad app owner remove")
              .Add("--id {value}", Id)
              .Add("--owner-object-id {value}", OwnerObjectId)
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
    #region AzureAdAppPermissionAddSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppPermissionAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   The target API to access.
        /// </summary>
        public virtual string Api { get; internal set; }
        /// <summary>
        ///   Space seperated list of &lt;resource-access-id&gt;=&lt;type&gt;.
        /// </summary>
        public virtual string ApiPermissions { get; internal set; }
        /// <summary>
        ///   Identifier uri, application id, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app permission add")
              .Add("--api {value}", Api)
              .Add("--api-permissions {value}", ApiPermissions)
              .Add("--id {value}", Id)
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
    #region AzureAdAppPermissionAdminConsentSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppPermissionAdminConsentSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Identifier uri, application id, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app permission admin-consent")
              .Add("--id {value}", Id)
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
    #region AzureAdAppPermissionDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppPermissionDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   The target API to access.
        /// </summary>
        public virtual string Api { get; internal set; }
        /// <summary>
        ///   Identifier uri, application id, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app permission delete")
              .Add("--api {value}", Api)
              .Add("--id {value}", Id)
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
    #region AzureAdAppPermissionGrantSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppPermissionGrantSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   The target API to access.
        /// </summary>
        public virtual string Api { get; internal set; }
        /// <summary>
        ///   Identifier uri, application id, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Indicates if consent was provided by the administrator (on behalf of the organization) or by an individual.
        /// </summary>
        public virtual AdAppPermissionGrantConsentType ConsentType { get; internal set; }
        /// <summary>
        ///   Expiry date for the permissions in years. e.g. 1, 2 or "never".
        /// </summary>
        public virtual string Expires { get; internal set; }
        /// <summary>
        ///   If --consent-type is "Principal", this argument specifies the object of the user that granted consent and applies only for that user.
        /// </summary>
        public virtual string PrincipalId { get; internal set; }
        /// <summary>
        ///   Specifies the value of the scope claim that the resource application should expect in the OAuth 2.0 access token, e.g. User.Read.
        /// </summary>
        public virtual string Scope { get; internal set; }
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
              .Add("ad app permission grant")
              .Add("--api {value}", Api)
              .Add("--id {value}", Id)
              .Add("--consent-type {value}", ConsentType)
              .Add("--expires {value}", Expires)
              .Add("--principal-id {value}", PrincipalId)
              .Add("--scope {value}", Scope)
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
    #region AzureAdAppPermissionListSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppPermissionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Identifier uri, application id, or object id of the associated application.
        /// </summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app permission list")
              .Add("--id {value}", Id)
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
    #region AzureAdAppPermissionListGrantsSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppPermissionListGrantsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   OData filter.
        /// </summary>
        public virtual string Filter { get; internal set; }
        /// <summary>
        ///   Identifier uri, application id, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Show resource's display name.
        /// </summary>
        public virtual bool? ShowResourceName { get; internal set; }
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
              .Add("ad app permission list-grants")
              .Add("--filter {value}", Filter)
              .Add("--id {value}", Id)
              .Add("--show-resource-name", ShowResourceName)
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
    #region AzureAdGroupMemberAddSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupMemberAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Group's object id or display name(prefix also works if there is a unique match).
        /// </summary>
        public virtual string Group { get; internal set; }
        /// <summary>
        ///   The object ID of the contact, group, user, or service principal.
        /// </summary>
        public virtual string MemberId { get; internal set; }
        /// <summary>
        ///   Unmatched properties from the message are deserialized this collection.
        /// </summary>
        public virtual string AdditionalProperties { get; internal set; }
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
              .Add("ad group member add")
              .Add("--group {value}", Group)
              .Add("--member-id {value}", MemberId)
              .Add("--additional-properties {value}", AdditionalProperties)
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
    #region AzureAdGroupMemberCheckSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupMemberCheckSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Group's object id or display name(prefix also works if there is a unique match).
        /// </summary>
        public virtual string Group { get; internal set; }
        /// <summary>
        ///   The object ID of the contact, group, user, or service principal.
        /// </summary>
        public virtual string MemberId { get; internal set; }
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
              .Add("ad group member check")
              .Add("--group {value}", Group)
              .Add("--member-id {value}", MemberId)
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
    #region AzureAdGroupMemberListSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupMemberListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Group's object id or display name(prefix also works if there is a unique match).
        /// </summary>
        public virtual string Group { get; internal set; }
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
              .Add("ad group member list")
              .Add("--group {value}", Group)
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
    #region AzureAdGroupMemberRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupMemberRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Group's object id or display name(prefix also works if there is a unique match).
        /// </summary>
        public virtual string Group { get; internal set; }
        /// <summary>
        ///   The object ID of the contact, group, user, or service principal.
        /// </summary>
        public virtual string MemberId { get; internal set; }
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
              .Add("ad group member remove")
              .Add("--group {value}", Group)
              .Add("--member-id {value}", MemberId)
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
    #region AzureAdGroupOwnerAddSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupOwnerAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Group's object id or display name(prefix also works if there is a unique match).
        /// </summary>
        public virtual string Group { get; internal set; }
        /// <summary>
        ///   Owner's object id.
        /// </summary>
        public virtual string OwnerObjectId { get; internal set; }
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
              .Add("ad group owner add")
              .Add("--group {value}", Group)
              .Add("--owner-object-id {value}", OwnerObjectId)
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
    #region AzureAdGroupOwnerListSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupOwnerListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Group's object id or display name(prefix also works if there is a unique match).
        /// </summary>
        public virtual string Group { get; internal set; }
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
              .Add("ad group owner list")
              .Add("--group {value}", Group)
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
    #region AzureAdGroupOwnerRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupOwnerRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Group's object id or display name(prefix also works if there is a unique match).
        /// </summary>
        public virtual string Group { get; internal set; }
        /// <summary>
        ///   Owner's object id.
        /// </summary>
        public virtual string OwnerObjectId { get; internal set; }
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
              .Add("ad group owner remove")
              .Add("--group {value}", Group)
              .Add("--owner-object-id {value}", OwnerObjectId)
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
    #region AzureAdSpCredentialDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCredentialDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Service principal name, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Credential key id.
        /// </summary>
        public virtual string KeyId { get; internal set; }
        /// <summary>
        ///   A certificate based credential.
        /// </summary>
        public virtual string Cert { get; internal set; }
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
              .Add("ad sp credential delete")
              .Add("--id {value}", Id)
              .Add("--key-id {value}", KeyId)
              .Add("--cert {value}", Cert)
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
    #region AzureAdSpCredentialListSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCredentialListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Service principal name, or object id.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   A certificate based credential.
        /// </summary>
        public virtual string Cert { get; internal set; }
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
              .Add("ad sp credential list")
              .Add("--id {value}", Id)
              .Add("--cert {value}", Cert)
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
    #region AzureAdSpCredentialResetSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCredentialResetSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Name or app ID of the service principal.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Append the new credential instead of overwriting.
        /// </summary>
        public virtual string Append { get; internal set; }
        /// <summary>
        ///   Certificate to use for credentials.
        /// </summary>
        public virtual string Cert { get; internal set; }
        /// <summary>
        ///   Create a self-signed certificate to use for the credential.
        /// </summary>
        public virtual string CreateCert { get; internal set; }
        /// <summary>
        ///   The description of the password.
        /// </summary>
        public virtual string CredentialDescription { get; internal set; }
        /// <summary>
        ///   Finer grain of expiry time if '--years' is insufficient, e.g. '2020-12-31T11:59:59+00:00' or '2299-12-31'.
        /// </summary>
        public virtual string EndDate { get; internal set; }
        /// <summary>
        ///   Name or ID of a KeyVault to use for creating or retrieving certificates.
        /// </summary>
        public virtual string Keyvault { get; internal set; }
        /// <summary>
        ///   The password used to log in.
        /// </summary>
        public virtual string Password { get; internal set; }
        /// <summary>
        ///   Number of years for which the credentials will be valid. Default: 1 year.
        /// </summary>
        public virtual int? Years { get; internal set; }
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
              .Add("ad sp credential reset")
              .Add("--name {value}", Name)
              .Add("--append {value}", Append)
              .Add("--cert {value}", Cert)
              .Add("--create-cert {value}", CreateCert)
              .Add("--credential-description {value}", CredentialDescription)
              .Add("--end-date {value}", EndDate)
              .Add("--keyvault {value}", Keyvault)
              .Add("--password {value}", Password, secret: true)
              .Add("--years {value}", Years)
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
    #region AzureAdSpOwnerListSettings
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpOwnerListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAd executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        public override Action<OutputType, string> CustomLogger => AzureAdTasks.AzureAdLogger;
        /// <summary>
        ///   Service principal name, or object id or the service principal.
        /// </summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad sp owner list")
              .Add("--id {value}", Id)
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
    #region AzureAdSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSettings SetDebug(this AzureAdSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSettings ResetDebug(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSettings SetHelp(this AzureAdSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSettings ResetHelp(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSettings SetOutput(this AzureAdSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSettings ResetOutput(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSettings SetQuery(this AzureAdSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSettings ResetQuery(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSettings SetVerbose(this AzureAdSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSettings ResetVerbose(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppCreateSettingsExtensions
    {
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.DisplayName"/></em></p>
        ///   <p>The display name of the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetDisplayName(this AzureAdAppCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.DisplayName"/></em></p>
        ///   <p>The display name of the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetDisplayName(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region AppRoles
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.AppRoles"/></em></p>
        ///   <p>Declare the roles you want to associate with your application. Should be in manifest json format. See examples below for details.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetAppRoles(this AzureAdAppCreateSettings toolSettings, string appRoles)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppRoles = appRoles;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.AppRoles"/></em></p>
        ///   <p>Declare the roles you want to associate with your application. Should be in manifest json format. See examples below for details.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetAppRoles(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppRoles = null;
            return toolSettings;
        }
        #endregion
        #region AvailableToOtherTenants
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/></em></p>
        ///   <p>The application can be used from any Azure AD tenants.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings, bool? availableToOtherTenants)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = availableToOtherTenants;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/></em></p>
        ///   <p>The application can be used from any Azure AD tenants.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/></em></p>
        ///   <p>The application can be used from any Azure AD tenants.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings EnableAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/></em></p>
        ///   <p>The application can be used from any Azure AD tenants.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings DisableAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/></em></p>
        ///   <p>The application can be used from any Azure AD tenants.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ToggleAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = !toolSettings.AvailableToOtherTenants;
            return toolSettings;
        }
        #endregion
        #region CredentialDescription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.CredentialDescription"/></em></p>
        ///   <p>The description of the password.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetCredentialDescription(this AzureAdAppCreateSettings toolSettings, string credentialDescription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = credentialDescription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.CredentialDescription"/></em></p>
        ///   <p>The description of the password.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetCredentialDescription(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.EndDate"/></em></p>
        ///   <p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetEndDate(this AzureAdAppCreateSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.EndDate"/></em></p>
        ///   <p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetEndDate(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region Homepage
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.Homepage"/></em></p>
        ///   <p>The url where users can sign in and use your app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetHomepage(this AzureAdAppCreateSettings toolSettings, string homepage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Homepage = homepage;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.Homepage"/></em></p>
        ///   <p>The url where users can sign in and use your app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetHomepage(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Homepage = null;
            return toolSettings;
        }
        #endregion
        #region IdentifierUris
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.IdentifierUris"/> to a new list</em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetIdentifierUris(this AzureAdAppCreateSettings toolSettings, params string[] identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal = identifierUris.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.IdentifierUris"/> to a new list</em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetIdentifierUris(this AzureAdAppCreateSettings toolSettings, IEnumerable<string> identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal = identifierUris.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAdAppCreateSettings.IdentifierUris"/></em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings AddIdentifierUris(this AzureAdAppCreateSettings toolSettings, params string[] identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal.AddRange(identifierUris);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAdAppCreateSettings.IdentifierUris"/></em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings AddIdentifierUris(this AzureAdAppCreateSettings toolSettings, IEnumerable<string> identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal.AddRange(identifierUris);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAdAppCreateSettings.IdentifierUris"/></em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ClearIdentifierUris(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAdAppCreateSettings.IdentifierUris"/></em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings RemoveIdentifierUris(this AzureAdAppCreateSettings toolSettings, params string[] identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(identifierUris);
            toolSettings.IdentifierUrisInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAdAppCreateSettings.IdentifierUris"/></em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings RemoveIdentifierUris(this AzureAdAppCreateSettings toolSettings, IEnumerable<string> identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(identifierUris);
            toolSettings.IdentifierUrisInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region KeyType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.KeyType"/></em></p>
        ///   <p>The type of the key credentials associated with the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetKeyType(this AzureAdAppCreateSettings toolSettings, AdAppKeyType keyType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = keyType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.KeyType"/></em></p>
        ///   <p>The type of the key credentials associated with the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetKeyType(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = null;
            return toolSettings;
        }
        #endregion
        #region KeyUsage
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.KeyUsage"/></em></p>
        ///   <p>The usage of the key credentials associated with the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetKeyUsage(this AzureAdAppCreateSettings toolSettings, AdAppKeyUsage keyUsage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyUsage = keyUsage;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.KeyUsage"/></em></p>
        ///   <p>The usage of the key credentials associated with the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetKeyUsage(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyUsage = null;
            return toolSettings;
        }
        #endregion
        #region KeyValue
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.KeyValue"/></em></p>
        ///   <p>The value for the key credentials associated with the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetKeyValue(this AzureAdAppCreateSettings toolSettings, string keyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = keyValue;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.KeyValue"/></em></p>
        ///   <p>The value for the key credentials associated with the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetKeyValue(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = null;
            return toolSettings;
        }
        #endregion
        #region NativeApp
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.NativeApp"/></em></p>
        ///   <p>An application which can be installed on a user's device or computer.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetNativeApp(this AzureAdAppCreateSettings toolSettings, bool? nativeApp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = nativeApp;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.NativeApp"/></em></p>
        ///   <p>An application which can be installed on a user's device or computer.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetNativeApp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAdAppCreateSettings.NativeApp"/></em></p>
        ///   <p>An application which can be installed on a user's device or computer.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings EnableNativeApp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAdAppCreateSettings.NativeApp"/></em></p>
        ///   <p>An application which can be installed on a user's device or computer.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings DisableNativeApp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAdAppCreateSettings.NativeApp"/></em></p>
        ///   <p>An application which can be installed on a user's device or computer.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ToggleNativeApp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = !toolSettings.NativeApp;
            return toolSettings;
        }
        #endregion
        #region Oauth2AllowImplicitFlow
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/></em></p>
        ///   <p>Whether to allow implicit grant flow for OAuth2.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings, bool? oauth2AllowImplicitFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = oauth2AllowImplicitFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/></em></p>
        ///   <p>Whether to allow implicit grant flow for OAuth2.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/></em></p>
        ///   <p>Whether to allow implicit grant flow for OAuth2.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings EnableOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/></em></p>
        ///   <p>Whether to allow implicit grant flow for OAuth2.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings DisableOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/></em></p>
        ///   <p>Whether to allow implicit grant flow for OAuth2.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ToggleOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = !toolSettings.Oauth2AllowImplicitFlow;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.Password"/></em></p>
        ///   <p>App password, aka 'client secret'.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetPassword(this AzureAdAppCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.Password"/></em></p>
        ///   <p>App password, aka 'client secret'.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetPassword(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ReplyUrls
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.ReplyUrls"/> to a new list</em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetReplyUrls(this AzureAdAppCreateSettings toolSettings, params string[] replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal = replyUrls.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.ReplyUrls"/> to a new list</em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetReplyUrls(this AzureAdAppCreateSettings toolSettings, IEnumerable<string> replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal = replyUrls.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAdAppCreateSettings.ReplyUrls"/></em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings AddReplyUrls(this AzureAdAppCreateSettings toolSettings, params string[] replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal.AddRange(replyUrls);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAdAppCreateSettings.ReplyUrls"/></em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings AddReplyUrls(this AzureAdAppCreateSettings toolSettings, IEnumerable<string> replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal.AddRange(replyUrls);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAdAppCreateSettings.ReplyUrls"/></em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ClearReplyUrls(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAdAppCreateSettings.ReplyUrls"/></em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings RemoveReplyUrls(this AzureAdAppCreateSettings toolSettings, params string[] replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(replyUrls);
            toolSettings.ReplyUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAdAppCreateSettings.ReplyUrls"/></em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings RemoveReplyUrls(this AzureAdAppCreateSettings toolSettings, IEnumerable<string> replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(replyUrls);
            toolSettings.ReplyUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region RequiredResourceAccesses
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.RequiredResourceAccesses"/></em></p>
        ///   <p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetRequiredResourceAccesses(this AzureAdAppCreateSettings toolSettings, string requiredResourceAccesses)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiredResourceAccesses = requiredResourceAccesses;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.RequiredResourceAccesses"/></em></p>
        ///   <p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetRequiredResourceAccesses(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiredResourceAccesses = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.StartDate"/></em></p>
        ///   <p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetStartDate(this AzureAdAppCreateSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.StartDate"/></em></p>
        ///   <p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetStartDate(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetSubscription(this AzureAdAppCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetSubscription(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetDebug(this AzureAdAppCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetDebug(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetHelp(this AzureAdAppCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetHelp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetOutput(this AzureAdAppCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetOutput(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetQuery(this AzureAdAppCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetQuery(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings SetVerbose(this AzureAdAppCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetVerbose(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppDeleteSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppDeleteSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetId(this AzureAdAppDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppDeleteSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetId(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetSubscription(this AzureAdAppDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetSubscription(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetDebug(this AzureAdAppDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetDebug(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetHelp(this AzureAdAppDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetHelp(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetOutput(this AzureAdAppDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetOutput(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetQuery(this AzureAdAppDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetQuery(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetVerbose(this AzureAdAppDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetVerbose(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppListSettingsExtensions
    {
        #region All
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppListSettings.All"/></em></p>
        ///   <p>List all entities, expect long delay if under a big organization.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings SetAll(this AzureAdAppListSettings toolSettings, string all)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = all;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppListSettings.All"/></em></p>
        ///   <p>List all entities, expect long delay if under a big organization.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings ResetAll(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = null;
            return toolSettings;
        }
        #endregion
        #region AppId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppListSettings.AppId"/></em></p>
        ///   <p>Application id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings SetAppId(this AzureAdAppListSettings toolSettings, string appId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppId = appId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppListSettings.AppId"/></em></p>
        ///   <p>Application id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings ResetAppId(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppId = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppListSettings.DisplayName"/></em></p>
        ///   <p>The display name of the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings SetDisplayName(this AzureAdAppListSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppListSettings.DisplayName"/></em></p>
        ///   <p>The display name of the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings ResetDisplayName(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppListSettings.Filter"/></em></p>
        ///   <p>OData filter.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings SetFilter(this AzureAdAppListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppListSettings.Filter"/></em></p>
        ///   <p>OData filter.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings ResetFilter(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region IdentifierUri
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppListSettings.IdentifierUri"/></em></p>
        ///   <p>Graph application identifier, must be in uri format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings SetIdentifierUri(this AzureAdAppListSettings toolSettings, string identifierUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUri = identifierUri;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppListSettings.IdentifierUri"/></em></p>
        ///   <p>Graph application identifier, must be in uri format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings ResetIdentifierUri(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUri = null;
            return toolSettings;
        }
        #endregion
        #region ShowMine
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppListSettings.ShowMine"/></em></p>
        ///   <p>List entities owned by the current user.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings SetShowMine(this AzureAdAppListSettings toolSettings, string showMine)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowMine = showMine;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppListSettings.ShowMine"/></em></p>
        ///   <p>List entities owned by the current user.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings ResetShowMine(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowMine = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings SetSubscription(this AzureAdAppListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings ResetSubscription(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings SetDebug(this AzureAdAppListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings ResetDebug(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings SetHelp(this AzureAdAppListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings ResetHelp(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings SetOutput(this AzureAdAppListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings ResetOutput(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings SetQuery(this AzureAdAppListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings ResetQuery(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings SetVerbose(this AzureAdAppListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppListSettings ResetVerbose(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppShowSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppShowSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings SetId(this AzureAdAppShowSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppShowSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings ResetId(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings SetSubscription(this AzureAdAppShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings ResetSubscription(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings SetDebug(this AzureAdAppShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings ResetDebug(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings SetHelp(this AzureAdAppShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings ResetHelp(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings SetOutput(this AzureAdAppShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings ResetOutput(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings SetQuery(this AzureAdAppShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings ResetQuery(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings SetVerbose(this AzureAdAppShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppShowSettings ResetVerbose(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppUpdateSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetId(this AzureAdAppUpdateSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetId(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region AppRoles
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.AppRoles"/></em></p>
        ///   <p>Declare the roles you want to associate with your application. Should be in manifest json format. See examples below for details.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetAppRoles(this AzureAdAppUpdateSettings toolSettings, string appRoles)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppRoles = appRoles;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.AppRoles"/></em></p>
        ///   <p>Declare the roles you want to associate with your application. Should be in manifest json format. See examples below for details.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetAppRoles(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppRoles = null;
            return toolSettings;
        }
        #endregion
        #region AvailableToOtherTenants
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/></em></p>
        ///   <p>The application can be used from any Azure AD tenants.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings, bool? availableToOtherTenants)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = availableToOtherTenants;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/></em></p>
        ///   <p>The application can be used from any Azure AD tenants.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/></em></p>
        ///   <p>The application can be used from any Azure AD tenants.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings EnableAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/></em></p>
        ///   <p>The application can be used from any Azure AD tenants.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings DisableAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/></em></p>
        ///   <p>The application can be used from any Azure AD tenants.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ToggleAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = !toolSettings.AvailableToOtherTenants;
            return toolSettings;
        }
        #endregion
        #region CredentialDescription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.CredentialDescription"/></em></p>
        ///   <p>The description of the password.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetCredentialDescription(this AzureAdAppUpdateSettings toolSettings, string credentialDescription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = credentialDescription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.CredentialDescription"/></em></p>
        ///   <p>The description of the password.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetCredentialDescription(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.DisplayName"/></em></p>
        ///   <p>The display name of the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetDisplayName(this AzureAdAppUpdateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.DisplayName"/></em></p>
        ///   <p>The display name of the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetDisplayName(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.EndDate"/></em></p>
        ///   <p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetEndDate(this AzureAdAppUpdateSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.EndDate"/></em></p>
        ///   <p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetEndDate(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region Homepage
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.Homepage"/></em></p>
        ///   <p>The url where users can sign in and use your app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetHomepage(this AzureAdAppUpdateSettings toolSettings, string homepage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Homepage = homepage;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.Homepage"/></em></p>
        ///   <p>The url where users can sign in and use your app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetHomepage(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Homepage = null;
            return toolSettings;
        }
        #endregion
        #region IdentifierUris
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.IdentifierUris"/> to a new list</em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetIdentifierUris(this AzureAdAppUpdateSettings toolSettings, params string[] identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal = identifierUris.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.IdentifierUris"/> to a new list</em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetIdentifierUris(this AzureAdAppUpdateSettings toolSettings, IEnumerable<string> identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal = identifierUris.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAdAppUpdateSettings.IdentifierUris"/></em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings AddIdentifierUris(this AzureAdAppUpdateSettings toolSettings, params string[] identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal.AddRange(identifierUris);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAdAppUpdateSettings.IdentifierUris"/></em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings AddIdentifierUris(this AzureAdAppUpdateSettings toolSettings, IEnumerable<string> identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal.AddRange(identifierUris);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAdAppUpdateSettings.IdentifierUris"/></em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ClearIdentifierUris(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAdAppUpdateSettings.IdentifierUris"/></em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings RemoveIdentifierUris(this AzureAdAppUpdateSettings toolSettings, params string[] identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(identifierUris);
            toolSettings.IdentifierUrisInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAdAppUpdateSettings.IdentifierUris"/></em></p>
        ///   <p>Space-separated unique URIs that Azure AD can use for this app.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings RemoveIdentifierUris(this AzureAdAppUpdateSettings toolSettings, IEnumerable<string> identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(identifierUris);
            toolSettings.IdentifierUrisInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region KeyType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.KeyType"/></em></p>
        ///   <p>The type of the key credentials associated with the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetKeyType(this AzureAdAppUpdateSettings toolSettings, AdAppKeyType keyType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = keyType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.KeyType"/></em></p>
        ///   <p>The type of the key credentials associated with the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetKeyType(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = null;
            return toolSettings;
        }
        #endregion
        #region KeyUsage
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.KeyUsage"/></em></p>
        ///   <p>The usage of the key credentials associated with the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetKeyUsage(this AzureAdAppUpdateSettings toolSettings, AdAppKeyUsage keyUsage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyUsage = keyUsage;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.KeyUsage"/></em></p>
        ///   <p>The usage of the key credentials associated with the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetKeyUsage(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyUsage = null;
            return toolSettings;
        }
        #endregion
        #region KeyValue
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.KeyValue"/></em></p>
        ///   <p>The value for the key credentials associated with the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetKeyValue(this AzureAdAppUpdateSettings toolSettings, string keyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = keyValue;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.KeyValue"/></em></p>
        ///   <p>The value for the key credentials associated with the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetKeyValue(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = null;
            return toolSettings;
        }
        #endregion
        #region Oauth2AllowImplicitFlow
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/></em></p>
        ///   <p>Whether to allow implicit grant flow for OAuth2.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings, bool? oauth2AllowImplicitFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = oauth2AllowImplicitFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/></em></p>
        ///   <p>Whether to allow implicit grant flow for OAuth2.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/></em></p>
        ///   <p>Whether to allow implicit grant flow for OAuth2.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings EnableOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/></em></p>
        ///   <p>Whether to allow implicit grant flow for OAuth2.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings DisableOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/></em></p>
        ///   <p>Whether to allow implicit grant flow for OAuth2.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ToggleOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = !toolSettings.Oauth2AllowImplicitFlow;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.Password"/></em></p>
        ///   <p>App password, aka 'client secret'.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetPassword(this AzureAdAppUpdateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.Password"/></em></p>
        ///   <p>App password, aka 'client secret'.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetPassword(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ReplyUrls
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.ReplyUrls"/> to a new list</em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetReplyUrls(this AzureAdAppUpdateSettings toolSettings, params string[] replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal = replyUrls.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.ReplyUrls"/> to a new list</em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetReplyUrls(this AzureAdAppUpdateSettings toolSettings, IEnumerable<string> replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal = replyUrls.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAdAppUpdateSettings.ReplyUrls"/></em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings AddReplyUrls(this AzureAdAppUpdateSettings toolSettings, params string[] replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal.AddRange(replyUrls);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAdAppUpdateSettings.ReplyUrls"/></em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings AddReplyUrls(this AzureAdAppUpdateSettings toolSettings, IEnumerable<string> replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal.AddRange(replyUrls);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAdAppUpdateSettings.ReplyUrls"/></em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ClearReplyUrls(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAdAppUpdateSettings.ReplyUrls"/></em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings RemoveReplyUrls(this AzureAdAppUpdateSettings toolSettings, params string[] replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(replyUrls);
            toolSettings.ReplyUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAdAppUpdateSettings.ReplyUrls"/></em></p>
        ///   <p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings RemoveReplyUrls(this AzureAdAppUpdateSettings toolSettings, IEnumerable<string> replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(replyUrls);
            toolSettings.ReplyUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region RequiredResourceAccesses
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.RequiredResourceAccesses"/></em></p>
        ///   <p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetRequiredResourceAccesses(this AzureAdAppUpdateSettings toolSettings, string requiredResourceAccesses)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiredResourceAccesses = requiredResourceAccesses;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.RequiredResourceAccesses"/></em></p>
        ///   <p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetRequiredResourceAccesses(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiredResourceAccesses = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.StartDate"/></em></p>
        ///   <p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetStartDate(this AzureAdAppUpdateSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.StartDate"/></em></p>
        ///   <p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetStartDate(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetAdd(this AzureAdAppUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetAdd(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetForceString(this AzureAdAppUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetForceString(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetRemove(this AzureAdAppUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetRemove(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetSet(this AzureAdAppUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetSet(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetSubscription(this AzureAdAppUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetSubscription(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetDebug(this AzureAdAppUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetDebug(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetHelp(this AzureAdAppUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetHelp(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetOutput(this AzureAdAppUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetOutput(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetQuery(this AzureAdAppUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetQuery(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetVerbose(this AzureAdAppUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetVerbose(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupCreateSettingsExtensions
    {
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupCreateSettings.DisplayName"/></em></p>
        ///   <p>Object's display name or its prefix.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetDisplayName(this AzureAdGroupCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupCreateSettings.DisplayName"/></em></p>
        ///   <p>Object's display name or its prefix.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetDisplayName(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region MailNickname
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupCreateSettings.MailNickname"/></em></p>
        ///   <p>Mail nickname.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetMailNickname(this AzureAdGroupCreateSettings toolSettings, string mailNickname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MailNickname = mailNickname;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupCreateSettings.MailNickname"/></em></p>
        ///   <p>Mail nickname.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetMailNickname(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MailNickname = null;
            return toolSettings;
        }
        #endregion
        #region Force
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupCreateSettings.Force"/></em></p>
        ///   <p>Always create a new group instead of updating the one with same display and mail nickname.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetForce(this AzureAdGroupCreateSettings toolSettings, bool? force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupCreateSettings.Force"/></em></p>
        ///   <p>Always create a new group instead of updating the one with same display and mail nickname.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetForce(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAdGroupCreateSettings.Force"/></em></p>
        ///   <p>Always create a new group instead of updating the one with same display and mail nickname.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings EnableForce(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAdGroupCreateSettings.Force"/></em></p>
        ///   <p>Always create a new group instead of updating the one with same display and mail nickname.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings DisableForce(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAdGroupCreateSettings.Force"/></em></p>
        ///   <p>Always create a new group instead of updating the one with same display and mail nickname.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings ToggleForce(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = !toolSettings.Force;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetSubscription(this AzureAdGroupCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetSubscription(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetDebug(this AzureAdGroupCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetDebug(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetHelp(this AzureAdGroupCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetHelp(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetOutput(this AzureAdGroupCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetOutput(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetQuery(this AzureAdGroupCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetQuery(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetVerbose(this AzureAdGroupCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetVerbose(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupDeleteSettingsExtensions
    {
        #region Group
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupDeleteSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetGroup(this AzureAdGroupDeleteSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupDeleteSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetGroup(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetSubscription(this AzureAdGroupDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetSubscription(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetDebug(this AzureAdGroupDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetDebug(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetHelp(this AzureAdGroupDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetHelp(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetOutput(this AzureAdGroupDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetOutput(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetQuery(this AzureAdGroupDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetQuery(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetVerbose(this AzureAdGroupDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetVerbose(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupGetMemberGroupsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupGetMemberGroupsSettingsExtensions
    {
        #region Group
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetGroup(this AzureAdGroupGetMemberGroupsSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetGroup(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region AdditionalProperties
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.AdditionalProperties"/></em></p>
        ///   <p>Unmatched properties from the message are deserialized this collection.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetAdditionalProperties(this AzureAdGroupGetMemberGroupsSettings toolSettings, string additionalProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdditionalProperties = additionalProperties;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.AdditionalProperties"/></em></p>
        ///   <p>Unmatched properties from the message are deserialized this collection.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetAdditionalProperties(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdditionalProperties = null;
            return toolSettings;
        }
        #endregion
        #region SecurityEnabledOnly
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/></em></p>
        ///   <p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings, bool? securityEnabledOnly)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = securityEnabledOnly;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/></em></p>
        ///   <p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/></em></p>
        ///   <p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings EnableSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/></em></p>
        ///   <p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings DisableSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/></em></p>
        ///   <p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ToggleSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = !toolSettings.SecurityEnabledOnly;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetSubscription(this AzureAdGroupGetMemberGroupsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetSubscription(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetDebug(this AzureAdGroupGetMemberGroupsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetDebug(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetHelp(this AzureAdGroupGetMemberGroupsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetHelp(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetOutput(this AzureAdGroupGetMemberGroupsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetOutput(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetQuery(this AzureAdGroupGetMemberGroupsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetQuery(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetVerbose(this AzureAdGroupGetMemberGroupsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetVerbose(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupListSettingsExtensions
    {
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupListSettings.DisplayName"/></em></p>
        ///   <p>Object's display name or its prefix.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings SetDisplayName(this AzureAdGroupListSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupListSettings.DisplayName"/></em></p>
        ///   <p>Object's display name or its prefix.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings ResetDisplayName(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupListSettings.Filter"/></em></p>
        ///   <p>OData filter.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings SetFilter(this AzureAdGroupListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupListSettings.Filter"/></em></p>
        ///   <p>OData filter.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings ResetFilter(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings SetSubscription(this AzureAdGroupListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings ResetSubscription(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings SetDebug(this AzureAdGroupListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings ResetDebug(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings SetHelp(this AzureAdGroupListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings ResetHelp(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings SetOutput(this AzureAdGroupListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings ResetOutput(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings SetQuery(this AzureAdGroupListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings ResetQuery(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings SetVerbose(this AzureAdGroupListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupListSettings ResetVerbose(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupShowSettingsExtensions
    {
        #region Group
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupShowSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings SetGroup(this AzureAdGroupShowSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupShowSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetGroup(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings SetSubscription(this AzureAdGroupShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetSubscription(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings SetDebug(this AzureAdGroupShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetDebug(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings SetHelp(this AzureAdGroupShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetHelp(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings SetOutput(this AzureAdGroupShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetOutput(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings SetQuery(this AzureAdGroupShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetQuery(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings SetVerbose(this AzureAdGroupShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetVerbose(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSignedInUserListOwnedObjectsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSignedInUserListOwnedObjectsSettingsExtensions
    {
        #region Type
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Type"/></em></p>
        ///   <p>Object type filter, e.g. "application", "servicePrincipal"  "group", etc.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetType(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, string type)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = type;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Type"/></em></p>
        ///   <p>Object type filter, e.g. "application", "servicePrincipal"  "group", etc.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetType(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetSubscription(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetSubscription(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetDebug(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetDebug(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetHelp(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetHelp(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetOutput(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetOutput(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetQuery(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetQuery(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetVerbose(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetVerbose(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSignedInUserShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSignedInUserShowSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSignedInUserShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings SetSubscription(this AzureAdSignedInUserShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSignedInUserShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings ResetSubscription(this AzureAdSignedInUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSignedInUserShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings SetDebug(this AzureAdSignedInUserShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSignedInUserShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings ResetDebug(this AzureAdSignedInUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSignedInUserShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings SetHelp(this AzureAdSignedInUserShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSignedInUserShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings ResetHelp(this AzureAdSignedInUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSignedInUserShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings SetOutput(this AzureAdSignedInUserShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSignedInUserShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings ResetOutput(this AzureAdSignedInUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSignedInUserShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings SetQuery(this AzureAdSignedInUserShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSignedInUserShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings ResetQuery(this AzureAdSignedInUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSignedInUserShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings SetVerbose(this AzureAdSignedInUserShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSignedInUserShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings ResetVerbose(this AzureAdSignedInUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCreateSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id of the associated application.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings SetId(this AzureAdSpCreateSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id of the associated application.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetId(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings SetSubscription(this AzureAdSpCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetSubscription(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings SetDebug(this AzureAdSpCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetDebug(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings SetHelp(this AzureAdSpCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetHelp(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings SetOutput(this AzureAdSpCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetOutput(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings SetQuery(this AzureAdSpCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetQuery(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings SetVerbose(this AzureAdSpCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetVerbose(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCreateForRbacSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCreateForRbacSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Name"/></em></p>
        ///   <p>A URI to use as the logic name. It doesn't need to exist. If not present, CLI will generate one.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetName(this AzureAdSpCreateForRbacSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Name"/></em></p>
        ///   <p>A URI to use as the logic name. It doesn't need to exist. If not present, CLI will generate one.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetName(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Role"/></em></p>
        ///   <p>Role of the service principal.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetRole(this AzureAdSpCreateForRbacSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Role"/></em></p>
        ///   <p>Role of the service principal.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetRole(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Scopes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Scopes"/> to a new list</em></p>
        ///   <p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetScopes(this AzureAdSpCreateForRbacSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal = scopes.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Scopes"/> to a new list</em></p>
        ///   <p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetScopes(this AzureAdSpCreateForRbacSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal = scopes.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAdSpCreateForRbacSettings.Scopes"/></em></p>
        ///   <p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings AddScopes(this AzureAdSpCreateForRbacSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.AddRange(scopes);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAdSpCreateForRbacSettings.Scopes"/></em></p>
        ///   <p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings AddScopes(this AzureAdSpCreateForRbacSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.AddRange(scopes);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAdSpCreateForRbacSettings.Scopes"/></em></p>
        ///   <p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ClearScopes(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAdSpCreateForRbacSettings.Scopes"/></em></p>
        ///   <p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings RemoveScopes(this AzureAdSpCreateForRbacSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(scopes);
            toolSettings.ScopesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAdSpCreateForRbacSettings.Scopes"/></em></p>
        ///   <p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings RemoveScopes(this AzureAdSpCreateForRbacSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(scopes);
            toolSettings.ScopesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region SdkAuth
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/></em></p>
        ///   <p>Output result in compatible with Azure SDK auth file.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings, bool? sdkAuth)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = sdkAuth;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/></em></p>
        ///   <p>Output result in compatible with Azure SDK auth file.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/></em></p>
        ///   <p>Output result in compatible with Azure SDK auth file.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings EnableSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/></em></p>
        ///   <p>Output result in compatible with Azure SDK auth file.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings DisableSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/></em></p>
        ///   <p>Output result in compatible with Azure SDK auth file.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ToggleSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = !toolSettings.SdkAuth;
            return toolSettings;
        }
        #endregion
        #region SkipAssignment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/></em></p>
        ///   <p>Skip creating the default assignment, which allows the service principal to access resources under the current subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings, bool? skipAssignment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = skipAssignment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/></em></p>
        ///   <p>Skip creating the default assignment, which allows the service principal to access resources under the current subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/></em></p>
        ///   <p>Skip creating the default assignment, which allows the service principal to access resources under the current subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings EnableSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/></em></p>
        ///   <p>Skip creating the default assignment, which allows the service principal to access resources under the current subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings DisableSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/></em></p>
        ///   <p>Skip creating the default assignment, which allows the service principal to access resources under the current subscription.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ToggleSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = !toolSettings.SkipAssignment;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Cert"/></em></p>
        ///   <p>Certificate to use for credentials.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetCert(this AzureAdSpCreateForRbacSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Cert"/></em></p>
        ///   <p>Certificate to use for credentials.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetCert(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region CreateCert
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.CreateCert"/></em></p>
        ///   <p>Create a self-signed certificate to use for the credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetCreateCert(this AzureAdSpCreateForRbacSettings toolSettings, string createCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = createCert;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.CreateCert"/></em></p>
        ///   <p>Create a self-signed certificate to use for the credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetCreateCert(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = null;
            return toolSettings;
        }
        #endregion
        #region Keyvault
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Keyvault"/></em></p>
        ///   <p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetKeyvault(this AzureAdSpCreateForRbacSettings toolSettings, string keyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = keyvault;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Keyvault"/></em></p>
        ///   <p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetKeyvault(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Password"/></em></p>
        ///   <p>Password.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetPassword(this AzureAdSpCreateForRbacSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Password"/></em></p>
        ///   <p>Password.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetPassword(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Years
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Years"/></em></p>
        ///   <p>Number of years for which the credentials will be valid. Default: 1 year.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetYears(this AzureAdSpCreateForRbacSettings toolSettings, int? years)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = years;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Years"/></em></p>
        ///   <p>Number of years for which the credentials will be valid. Default: 1 year.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetYears(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetSubscription(this AzureAdSpCreateForRbacSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetSubscription(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetDebug(this AzureAdSpCreateForRbacSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetDebug(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetHelp(this AzureAdSpCreateForRbacSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetHelp(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetOutput(this AzureAdSpCreateForRbacSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetOutput(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetQuery(this AzureAdSpCreateForRbacSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetQuery(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetVerbose(this AzureAdSpCreateForRbacSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetVerbose(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpDeleteSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpDeleteSettings.Id"/></em></p>
        ///   <p>Service principal name, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetId(this AzureAdSpDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpDeleteSettings.Id"/></em></p>
        ///   <p>Service principal name, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetId(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetSubscription(this AzureAdSpDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetSubscription(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetDebug(this AzureAdSpDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetDebug(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetHelp(this AzureAdSpDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetHelp(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetOutput(this AzureAdSpDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetOutput(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetQuery(this AzureAdSpDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetQuery(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetVerbose(this AzureAdSpDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetVerbose(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpListSettingsExtensions
    {
        #region All
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpListSettings.All"/></em></p>
        ///   <p>List all entities, expect long delay if under a big organization.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings SetAll(this AzureAdSpListSettings toolSettings, string all)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = all;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpListSettings.All"/></em></p>
        ///   <p>List all entities, expect long delay if under a big organization.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings ResetAll(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpListSettings.DisplayName"/></em></p>
        ///   <p>Object's display name or its prefix.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings SetDisplayName(this AzureAdSpListSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpListSettings.DisplayName"/></em></p>
        ///   <p>Object's display name or its prefix.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings ResetDisplayName(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpListSettings.Filter"/></em></p>
        ///   <p>OData filter.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings SetFilter(this AzureAdSpListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpListSettings.Filter"/></em></p>
        ///   <p>OData filter.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings ResetFilter(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region ShowMine
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpListSettings.ShowMine"/></em></p>
        ///   <p>List entities owned by the current user.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings SetShowMine(this AzureAdSpListSettings toolSettings, string showMine)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowMine = showMine;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpListSettings.ShowMine"/></em></p>
        ///   <p>List entities owned by the current user.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings ResetShowMine(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowMine = null;
            return toolSettings;
        }
        #endregion
        #region Spn
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpListSettings.Spn"/></em></p>
        ///   <p>Service principal name.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings SetSpn(this AzureAdSpListSettings toolSettings, string spn)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Spn = spn;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpListSettings.Spn"/></em></p>
        ///   <p>Service principal name.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings ResetSpn(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Spn = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings SetSubscription(this AzureAdSpListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings ResetSubscription(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings SetDebug(this AzureAdSpListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings ResetDebug(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings SetHelp(this AzureAdSpListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings ResetHelp(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings SetOutput(this AzureAdSpListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings ResetOutput(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings SetQuery(this AzureAdSpListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings ResetQuery(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings SetVerbose(this AzureAdSpListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpListSettings ResetVerbose(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpShowSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpShowSettings.Id"/></em></p>
        ///   <p>Service principal name, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings SetId(this AzureAdSpShowSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpShowSettings.Id"/></em></p>
        ///   <p>Service principal name, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings ResetId(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings SetSubscription(this AzureAdSpShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings ResetSubscription(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings SetDebug(this AzureAdSpShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings ResetDebug(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings SetHelp(this AzureAdSpShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings ResetHelp(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings SetOutput(this AzureAdSpShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings ResetOutput(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings SetQuery(this AzureAdSpShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings ResetQuery(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings SetVerbose(this AzureAdSpShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpShowSettings ResetVerbose(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpUpdateSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpUpdateSettings.Id"/></em></p>
        ///   <p>Service principal name, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings SetId(this AzureAdSpUpdateSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpUpdateSettings.Id"/></em></p>
        ///   <p>Service principal name, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings ResetId(this AzureAdSpUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings SetAdd(this AzureAdSpUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings ResetAdd(this AzureAdSpUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings SetForceString(this AzureAdSpUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings ResetForceString(this AzureAdSpUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings SetRemove(this AzureAdSpUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings ResetRemove(this AzureAdSpUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings SetSet(this AzureAdSpUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings ResetSet(this AzureAdSpUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings SetSubscription(this AzureAdSpUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings ResetSubscription(this AzureAdSpUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings SetDebug(this AzureAdSpUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings ResetDebug(this AzureAdSpUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings SetHelp(this AzureAdSpUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings ResetHelp(this AzureAdSpUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings SetOutput(this AzureAdSpUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings ResetOutput(this AzureAdSpUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings SetQuery(this AzureAdSpUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings ResetQuery(this AzureAdSpUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings SetVerbose(this AzureAdSpUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpUpdateSettings ResetVerbose(this AzureAdSpUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserCreateSettingsExtensions
    {
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserCreateSettings.DisplayName"/></em></p>
        ///   <p>Object's display name or its prefix.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings SetDisplayName(this AzureAdUserCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserCreateSettings.DisplayName"/></em></p>
        ///   <p>Object's display name or its prefix.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetDisplayName(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserCreateSettings.Password"/></em></p>
        ///   <p>User password.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings SetPassword(this AzureAdUserCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserCreateSettings.Password"/></em></p>
        ///   <p>User password.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetPassword(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region UserPrincipalName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserCreateSettings.UserPrincipalName"/></em></p>
        ///   <p>Required. The user principal name (someuser@contoso.com). It must contain one of the verified domains for the tenant.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings SetUserPrincipalName(this AzureAdUserCreateSettings toolSettings, string userPrincipalName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserPrincipalName = userPrincipalName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserCreateSettings.UserPrincipalName"/></em></p>
        ///   <p>Required. The user principal name (someuser@contoso.com). It must contain one of the verified domains for the tenant.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetUserPrincipalName(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserPrincipalName = null;
            return toolSettings;
        }
        #endregion
        #region ForceChangePasswordNextLogin
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/></em></p>
        ///   <p>Require the user to change their password the next time they log in.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings SetForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings, bool? forceChangePasswordNextLogin)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = forceChangePasswordNextLogin;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/></em></p>
        ///   <p>Require the user to change their password the next time they log in.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/></em></p>
        ///   <p>Require the user to change their password the next time they log in.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings EnableForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/></em></p>
        ///   <p>Require the user to change their password the next time they log in.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings DisableForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/></em></p>
        ///   <p>Require the user to change their password the next time they log in.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings ToggleForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = !toolSettings.ForceChangePasswordNextLogin;
            return toolSettings;
        }
        #endregion
        #region ImmutableId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserCreateSettings.ImmutableId"/></em></p>
        ///   <p>This must be specified if you are using a federated domain for the user's userPrincipalName (UPN) property when creating a new user account. It is used to associate an on-premises Active Directory user account with their Azure AD user object.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings SetImmutableId(this AzureAdUserCreateSettings toolSettings, string immutableId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImmutableId = immutableId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserCreateSettings.ImmutableId"/></em></p>
        ///   <p>This must be specified if you are using a federated domain for the user's userPrincipalName (UPN) property when creating a new user account. It is used to associate an on-premises Active Directory user account with their Azure AD user object.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetImmutableId(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImmutableId = null;
            return toolSettings;
        }
        #endregion
        #region MailNickname
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserCreateSettings.MailNickname"/></em></p>
        ///   <p>Mail alias. Defaults to user principal name.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings SetMailNickname(this AzureAdUserCreateSettings toolSettings, string mailNickname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MailNickname = mailNickname;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserCreateSettings.MailNickname"/></em></p>
        ///   <p>Mail alias. Defaults to user principal name.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetMailNickname(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MailNickname = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings SetSubscription(this AzureAdUserCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetSubscription(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings SetDebug(this AzureAdUserCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetDebug(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings SetHelp(this AzureAdUserCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetHelp(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings SetOutput(this AzureAdUserCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetOutput(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings SetQuery(this AzureAdUserCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetQuery(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings SetVerbose(this AzureAdUserCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetVerbose(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserDeleteSettingsExtensions
    {
        #region UpnOrObjectId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserDeleteSettings.UpnOrObjectId"/></em></p>
        ///   <p>The object ID or principal name of the user to delete.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetUpnOrObjectId(this AzureAdUserDeleteSettings toolSettings, string upnOrObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = upnOrObjectId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserDeleteSettings.UpnOrObjectId"/></em></p>
        ///   <p>The object ID or principal name of the user to delete.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetUpnOrObjectId(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetSubscription(this AzureAdUserDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetSubscription(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetDebug(this AzureAdUserDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetDebug(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetHelp(this AzureAdUserDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetHelp(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetOutput(this AzureAdUserDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetOutput(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetQuery(this AzureAdUserDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetQuery(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetVerbose(this AzureAdUserDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetVerbose(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserGetMemberGroupsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserGetMemberGroupsSettingsExtensions
    {
        #region UpnOrObjectId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.UpnOrObjectId"/></em></p>
        ///   <p>The object ID or principal name of the user for which to get information.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetUpnOrObjectId(this AzureAdUserGetMemberGroupsSettings toolSettings, string upnOrObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = upnOrObjectId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.UpnOrObjectId"/></em></p>
        ///   <p>The object ID or principal name of the user for which to get information.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetUpnOrObjectId(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = null;
            return toolSettings;
        }
        #endregion
        #region SecurityEnabledOnly
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.SecurityEnabledOnly"/></em></p>
        ///   <p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetSecurityEnabledOnly(this AzureAdUserGetMemberGroupsSettings toolSettings, bool? securityEnabledOnly)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = securityEnabledOnly;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.SecurityEnabledOnly"/></em></p>
        ///   <p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetSecurityEnabledOnly(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAdUserGetMemberGroupsSettings.SecurityEnabledOnly"/></em></p>
        ///   <p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings EnableSecurityEnabledOnly(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAdUserGetMemberGroupsSettings.SecurityEnabledOnly"/></em></p>
        ///   <p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings DisableSecurityEnabledOnly(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAdUserGetMemberGroupsSettings.SecurityEnabledOnly"/></em></p>
        ///   <p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ToggleSecurityEnabledOnly(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = !toolSettings.SecurityEnabledOnly;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetSubscription(this AzureAdUserGetMemberGroupsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetSubscription(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetDebug(this AzureAdUserGetMemberGroupsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetDebug(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetHelp(this AzureAdUserGetMemberGroupsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetHelp(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetOutput(this AzureAdUserGetMemberGroupsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetOutput(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetQuery(this AzureAdUserGetMemberGroupsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetQuery(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetVerbose(this AzureAdUserGetMemberGroupsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetVerbose(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserListSettingsExtensions
    {
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserListSettings.DisplayName"/></em></p>
        ///   <p>Object's display name or its prefix.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings SetDisplayName(this AzureAdUserListSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserListSettings.DisplayName"/></em></p>
        ///   <p>Object's display name or its prefix.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings ResetDisplayName(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserListSettings.Filter"/></em></p>
        ///   <p>OData filter.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings SetFilter(this AzureAdUserListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserListSettings.Filter"/></em></p>
        ///   <p>OData filter.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings ResetFilter(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Upn
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserListSettings.Upn"/></em></p>
        ///   <p>User principal name, e.g. john.doe@contoso.com.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings SetUpn(this AzureAdUserListSettings toolSettings, string upn)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upn = upn;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserListSettings.Upn"/></em></p>
        ///   <p>User principal name, e.g. john.doe@contoso.com.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings ResetUpn(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upn = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings SetSubscription(this AzureAdUserListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings ResetSubscription(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings SetDebug(this AzureAdUserListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings ResetDebug(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings SetHelp(this AzureAdUserListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings ResetHelp(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings SetOutput(this AzureAdUserListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings ResetOutput(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings SetQuery(this AzureAdUserListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings ResetQuery(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings SetVerbose(this AzureAdUserListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserListSettings ResetVerbose(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserShowSettingsExtensions
    {
        #region UpnOrObjectId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserShowSettings.UpnOrObjectId"/></em></p>
        ///   <p>The object ID or principal name of the user for which to get information.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings SetUpnOrObjectId(this AzureAdUserShowSettings toolSettings, string upnOrObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = upnOrObjectId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserShowSettings.UpnOrObjectId"/></em></p>
        ///   <p>The object ID or principal name of the user for which to get information.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings ResetUpnOrObjectId(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings SetSubscription(this AzureAdUserShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings ResetSubscription(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings SetDebug(this AzureAdUserShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings ResetDebug(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings SetHelp(this AzureAdUserShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings ResetHelp(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings SetOutput(this AzureAdUserShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings ResetOutput(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings SetQuery(this AzureAdUserShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings ResetQuery(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdUserShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings SetVerbose(this AzureAdUserShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdUserShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdUserShowSettings ResetVerbose(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppCredentialDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppCredentialDeleteSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetId(this AzureAdAppCredentialDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetId(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region KeyId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.KeyId"/></em></p>
        ///   <p>Credential key id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetKeyId(this AzureAdAppCredentialDeleteSettings toolSettings, string keyId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyId = keyId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.KeyId"/></em></p>
        ///   <p>Credential key id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetKeyId(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyId = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Cert"/></em></p>
        ///   <p>A certificate based credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetCert(this AzureAdAppCredentialDeleteSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Cert"/></em></p>
        ///   <p>A certificate based credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetCert(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetSubscription(this AzureAdAppCredentialDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetSubscription(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetDebug(this AzureAdAppCredentialDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetDebug(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetHelp(this AzureAdAppCredentialDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetHelp(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetOutput(this AzureAdAppCredentialDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetOutput(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetQuery(this AzureAdAppCredentialDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetQuery(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetVerbose(this AzureAdAppCredentialDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetVerbose(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppCredentialListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppCredentialListSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialListSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetId(this AzureAdAppCredentialListSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialListSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetId(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialListSettings.Cert"/></em></p>
        ///   <p>A certificate based credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetCert(this AzureAdAppCredentialListSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialListSettings.Cert"/></em></p>
        ///   <p>A certificate based credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetCert(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetSubscription(this AzureAdAppCredentialListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetSubscription(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetDebug(this AzureAdAppCredentialListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetDebug(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetHelp(this AzureAdAppCredentialListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetHelp(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetOutput(this AzureAdAppCredentialListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetOutput(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetQuery(this AzureAdAppCredentialListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetQuery(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetVerbose(this AzureAdAppCredentialListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetVerbose(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppCredentialResetSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppCredentialResetSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetId(this AzureAdAppCredentialResetSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetId(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Append
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Append"/></em></p>
        ///   <p>Append the new credential instead of overwriting.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetAppend(this AzureAdAppCredentialResetSettings toolSettings, string append)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Append = append;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Append"/></em></p>
        ///   <p>Append the new credential instead of overwriting.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetAppend(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Append = null;
            return toolSettings;
        }
        #endregion
        #region CredentialDescription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.CredentialDescription"/></em></p>
        ///   <p>The description of the password.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetCredentialDescription(this AzureAdAppCredentialResetSettings toolSettings, string credentialDescription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = credentialDescription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.CredentialDescription"/></em></p>
        ///   <p>The description of the password.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetCredentialDescription(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.EndDate"/></em></p>
        ///   <p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetEndDate(this AzureAdAppCredentialResetSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.EndDate"/></em></p>
        ///   <p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetEndDate(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Cert"/></em></p>
        ///   <p>Certificate to use for credentials.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetCert(this AzureAdAppCredentialResetSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Cert"/></em></p>
        ///   <p>Certificate to use for credentials.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetCert(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region CreateCert
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.CreateCert"/></em></p>
        ///   <p>Create a self-signed certificate to use for the credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetCreateCert(this AzureAdAppCredentialResetSettings toolSettings, string createCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = createCert;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.CreateCert"/></em></p>
        ///   <p>Create a self-signed certificate to use for the credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetCreateCert(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = null;
            return toolSettings;
        }
        #endregion
        #region Keyvault
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Keyvault"/></em></p>
        ///   <p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetKeyvault(this AzureAdAppCredentialResetSettings toolSettings, string keyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = keyvault;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Keyvault"/></em></p>
        ///   <p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetKeyvault(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Password"/></em></p>
        ///   <p>App password, aka 'client secret'.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetPassword(this AzureAdAppCredentialResetSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Password"/></em></p>
        ///   <p>App password, aka 'client secret'.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetPassword(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Years
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Years"/></em></p>
        ///   <p>Number of years for which the credentials will be valid.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetYears(this AzureAdAppCredentialResetSettings toolSettings, int? years)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = years;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Years"/></em></p>
        ///   <p>Number of years for which the credentials will be valid.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetYears(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetSubscription(this AzureAdAppCredentialResetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetSubscription(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetDebug(this AzureAdAppCredentialResetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetDebug(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetHelp(this AzureAdAppCredentialResetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetHelp(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetOutput(this AzureAdAppCredentialResetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetOutput(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetQuery(this AzureAdAppCredentialResetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetQuery(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetVerbose(this AzureAdAppCredentialResetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetVerbose(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppOwnerAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppOwnerAddSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetId(this AzureAdAppOwnerAddSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetId(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region OwnerObjectId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerAddSettings.OwnerObjectId"/></em></p>
        ///   <p>Owner's object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetOwnerObjectId(this AzureAdAppOwnerAddSettings toolSettings, string ownerObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = ownerObjectId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerAddSettings.OwnerObjectId"/></em></p>
        ///   <p>Owner's object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetOwnerObjectId(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetSubscription(this AzureAdAppOwnerAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetSubscription(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetDebug(this AzureAdAppOwnerAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetDebug(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetHelp(this AzureAdAppOwnerAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetHelp(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetOutput(this AzureAdAppOwnerAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetOutput(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetQuery(this AzureAdAppOwnerAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetQuery(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetVerbose(this AzureAdAppOwnerAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetVerbose(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppOwnerListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppOwnerListSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerListSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id of the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetId(this AzureAdAppOwnerListSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerListSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id of the application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetId(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetSubscription(this AzureAdAppOwnerListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetSubscription(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetDebug(this AzureAdAppOwnerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetDebug(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetHelp(this AzureAdAppOwnerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetHelp(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetOutput(this AzureAdAppOwnerListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetOutput(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetQuery(this AzureAdAppOwnerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetQuery(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetVerbose(this AzureAdAppOwnerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetVerbose(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppOwnerRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppOwnerRemoveSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetId(this AzureAdAppOwnerRemoveSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetId(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region OwnerObjectId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.OwnerObjectId"/></em></p>
        ///   <p>Owner's object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetOwnerObjectId(this AzureAdAppOwnerRemoveSettings toolSettings, string ownerObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = ownerObjectId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.OwnerObjectId"/></em></p>
        ///   <p>Owner's object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetOwnerObjectId(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetSubscription(this AzureAdAppOwnerRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetSubscription(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetDebug(this AzureAdAppOwnerRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetDebug(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetHelp(this AzureAdAppOwnerRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetHelp(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetOutput(this AzureAdAppOwnerRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetOutput(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetQuery(this AzureAdAppOwnerRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetQuery(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetVerbose(this AzureAdAppOwnerRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetVerbose(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppPermissionAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppPermissionAddSettingsExtensions
    {
        #region Api
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Api"/></em></p>
        ///   <p>The target API to access.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetApi(this AzureAdAppPermissionAddSettings toolSettings, string api)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Api = api;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Api"/></em></p>
        ///   <p>The target API to access.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetApi(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Api = null;
            return toolSettings;
        }
        #endregion
        #region ApiPermissions
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAddSettings.ApiPermissions"/></em></p>
        ///   <p>Space seperated list of &lt;resource-access-id&gt;=&lt;type&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetApiPermissions(this AzureAdAppPermissionAddSettings toolSettings, string apiPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiPermissions = apiPermissions;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAddSettings.ApiPermissions"/></em></p>
        ///   <p>Space seperated list of &lt;resource-access-id&gt;=&lt;type&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetApiPermissions(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiPermissions = null;
            return toolSettings;
        }
        #endregion
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetId(this AzureAdAppPermissionAddSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetId(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetSubscription(this AzureAdAppPermissionAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetSubscription(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetDebug(this AzureAdAppPermissionAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetDebug(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetHelp(this AzureAdAppPermissionAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetHelp(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetOutput(this AzureAdAppPermissionAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetOutput(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetQuery(this AzureAdAppPermissionAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetQuery(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetVerbose(this AzureAdAppPermissionAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetVerbose(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppPermissionAdminConsentSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppPermissionAdminConsentSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAdminConsentSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings SetId(this AzureAdAppPermissionAdminConsentSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAdminConsentSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings ResetId(this AzureAdAppPermissionAdminConsentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAdminConsentSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings SetSubscription(this AzureAdAppPermissionAdminConsentSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAdminConsentSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings ResetSubscription(this AzureAdAppPermissionAdminConsentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAdminConsentSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings SetDebug(this AzureAdAppPermissionAdminConsentSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAdminConsentSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings ResetDebug(this AzureAdAppPermissionAdminConsentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAdminConsentSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings SetHelp(this AzureAdAppPermissionAdminConsentSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAdminConsentSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings ResetHelp(this AzureAdAppPermissionAdminConsentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAdminConsentSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings SetOutput(this AzureAdAppPermissionAdminConsentSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAdminConsentSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings ResetOutput(this AzureAdAppPermissionAdminConsentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAdminConsentSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings SetQuery(this AzureAdAppPermissionAdminConsentSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAdminConsentSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings ResetQuery(this AzureAdAppPermissionAdminConsentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionAdminConsentSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings SetVerbose(this AzureAdAppPermissionAdminConsentSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionAdminConsentSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionAdminConsentSettings ResetVerbose(this AzureAdAppPermissionAdminConsentSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppPermissionDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppPermissionDeleteSettingsExtensions
    {
        #region Api
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Api"/></em></p>
        ///   <p>The target API to access.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetApi(this AzureAdAppPermissionDeleteSettings toolSettings, string api)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Api = api;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Api"/></em></p>
        ///   <p>The target API to access.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetApi(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Api = null;
            return toolSettings;
        }
        #endregion
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetId(this AzureAdAppPermissionDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetId(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetSubscription(this AzureAdAppPermissionDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetSubscription(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetDebug(this AzureAdAppPermissionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetDebug(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetHelp(this AzureAdAppPermissionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetHelp(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetOutput(this AzureAdAppPermissionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetOutput(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetQuery(this AzureAdAppPermissionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetQuery(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetVerbose(this AzureAdAppPermissionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetVerbose(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppPermissionGrantSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppPermissionGrantSettingsExtensions
    {
        #region Api
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Api"/></em></p>
        ///   <p>The target API to access.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetApi(this AzureAdAppPermissionGrantSettings toolSettings, string api)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Api = api;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Api"/></em></p>
        ///   <p>The target API to access.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetApi(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Api = null;
            return toolSettings;
        }
        #endregion
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetId(this AzureAdAppPermissionGrantSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetId(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region ConsentType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.ConsentType"/></em></p>
        ///   <p>Indicates if consent was provided by the administrator (on behalf of the organization) or by an individual.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetConsentType(this AzureAdAppPermissionGrantSettings toolSettings, AdAppPermissionGrantConsentType consentType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConsentType = consentType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.ConsentType"/></em></p>
        ///   <p>Indicates if consent was provided by the administrator (on behalf of the organization) or by an individual.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetConsentType(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConsentType = null;
            return toolSettings;
        }
        #endregion
        #region Expires
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Expires"/></em></p>
        ///   <p>Expiry date for the permissions in years. e.g. 1, 2 or "never".</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetExpires(this AzureAdAppPermissionGrantSettings toolSettings, string expires)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = expires;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Expires"/></em></p>
        ///   <p>Expiry date for the permissions in years. e.g. 1, 2 or "never".</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetExpires(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = null;
            return toolSettings;
        }
        #endregion
        #region PrincipalId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.PrincipalId"/></em></p>
        ///   <p>If --consent-type is "Principal", this argument specifies the object of the user that granted consent and applies only for that user.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetPrincipalId(this AzureAdAppPermissionGrantSettings toolSettings, string principalId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrincipalId = principalId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.PrincipalId"/></em></p>
        ///   <p>If --consent-type is "Principal", this argument specifies the object of the user that granted consent and applies only for that user.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetPrincipalId(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrincipalId = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Scope"/></em></p>
        ///   <p>Specifies the value of the scope claim that the resource application should expect in the OAuth 2.0 access token, e.g. User.Read.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetScope(this AzureAdAppPermissionGrantSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Scope"/></em></p>
        ///   <p>Specifies the value of the scope claim that the resource application should expect in the OAuth 2.0 access token, e.g. User.Read.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetScope(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetSubscription(this AzureAdAppPermissionGrantSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetSubscription(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetDebug(this AzureAdAppPermissionGrantSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetDebug(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetHelp(this AzureAdAppPermissionGrantSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetHelp(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetOutput(this AzureAdAppPermissionGrantSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetOutput(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetQuery(this AzureAdAppPermissionGrantSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetQuery(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetVerbose(this AzureAdAppPermissionGrantSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetVerbose(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppPermissionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppPermissionListSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id of the associated application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetId(this AzureAdAppPermissionListSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id of the associated application.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetId(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetSubscription(this AzureAdAppPermissionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetSubscription(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetDebug(this AzureAdAppPermissionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetDebug(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetHelp(this AzureAdAppPermissionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetHelp(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetOutput(this AzureAdAppPermissionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetOutput(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetQuery(this AzureAdAppPermissionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetQuery(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetVerbose(this AzureAdAppPermissionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetVerbose(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppPermissionListGrantsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppPermissionListGrantsSettingsExtensions
    {
        #region Filter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListGrantsSettings.Filter"/></em></p>
        ///   <p>OData filter.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings SetFilter(this AzureAdAppPermissionListGrantsSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListGrantsSettings.Filter"/></em></p>
        ///   <p>OData filter.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings ResetFilter(this AzureAdAppPermissionListGrantsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListGrantsSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings SetId(this AzureAdAppPermissionListGrantsSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListGrantsSettings.Id"/></em></p>
        ///   <p>Identifier uri, application id, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings ResetId(this AzureAdAppPermissionListGrantsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region ShowResourceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListGrantsSettings.ShowResourceName"/></em></p>
        ///   <p>Show resource's display name.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings SetShowResourceName(this AzureAdAppPermissionListGrantsSettings toolSettings, bool? showResourceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowResourceName = showResourceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListGrantsSettings.ShowResourceName"/></em></p>
        ///   <p>Show resource's display name.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings ResetShowResourceName(this AzureAdAppPermissionListGrantsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowResourceName = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAdAppPermissionListGrantsSettings.ShowResourceName"/></em></p>
        ///   <p>Show resource's display name.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings EnableShowResourceName(this AzureAdAppPermissionListGrantsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowResourceName = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAdAppPermissionListGrantsSettings.ShowResourceName"/></em></p>
        ///   <p>Show resource's display name.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings DisableShowResourceName(this AzureAdAppPermissionListGrantsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowResourceName = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAdAppPermissionListGrantsSettings.ShowResourceName"/></em></p>
        ///   <p>Show resource's display name.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings ToggleShowResourceName(this AzureAdAppPermissionListGrantsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowResourceName = !toolSettings.ShowResourceName;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListGrantsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings SetSubscription(this AzureAdAppPermissionListGrantsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListGrantsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings ResetSubscription(this AzureAdAppPermissionListGrantsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListGrantsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings SetDebug(this AzureAdAppPermissionListGrantsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListGrantsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings ResetDebug(this AzureAdAppPermissionListGrantsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListGrantsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings SetHelp(this AzureAdAppPermissionListGrantsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListGrantsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings ResetHelp(this AzureAdAppPermissionListGrantsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListGrantsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings SetOutput(this AzureAdAppPermissionListGrantsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListGrantsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings ResetOutput(this AzureAdAppPermissionListGrantsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListGrantsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings SetQuery(this AzureAdAppPermissionListGrantsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListGrantsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings ResetQuery(this AzureAdAppPermissionListGrantsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdAppPermissionListGrantsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings SetVerbose(this AzureAdAppPermissionListGrantsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdAppPermissionListGrantsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdAppPermissionListGrantsSettings ResetVerbose(this AzureAdAppPermissionListGrantsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupMemberAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupMemberAddSettingsExtensions
    {
        #region Group
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetGroup(this AzureAdGroupMemberAddSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetGroup(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region MemberId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberAddSettings.MemberId"/></em></p>
        ///   <p>The object ID of the contact, group, user, or service principal.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetMemberId(this AzureAdGroupMemberAddSettings toolSettings, string memberId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = memberId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberAddSettings.MemberId"/></em></p>
        ///   <p>The object ID of the contact, group, user, or service principal.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetMemberId(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = null;
            return toolSettings;
        }
        #endregion
        #region AdditionalProperties
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberAddSettings.AdditionalProperties"/></em></p>
        ///   <p>Unmatched properties from the message are deserialized this collection.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetAdditionalProperties(this AzureAdGroupMemberAddSettings toolSettings, string additionalProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdditionalProperties = additionalProperties;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberAddSettings.AdditionalProperties"/></em></p>
        ///   <p>Unmatched properties from the message are deserialized this collection.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetAdditionalProperties(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdditionalProperties = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetSubscription(this AzureAdGroupMemberAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetSubscription(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetDebug(this AzureAdGroupMemberAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetDebug(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetHelp(this AzureAdGroupMemberAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetHelp(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetOutput(this AzureAdGroupMemberAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetOutput(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetQuery(this AzureAdGroupMemberAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetQuery(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetVerbose(this AzureAdGroupMemberAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetVerbose(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupMemberCheckSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupMemberCheckSettingsExtensions
    {
        #region Group
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetGroup(this AzureAdGroupMemberCheckSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetGroup(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region MemberId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.MemberId"/></em></p>
        ///   <p>The object ID of the contact, group, user, or service principal.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetMemberId(this AzureAdGroupMemberCheckSettings toolSettings, string memberId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = memberId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.MemberId"/></em></p>
        ///   <p>The object ID of the contact, group, user, or service principal.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetMemberId(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetSubscription(this AzureAdGroupMemberCheckSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetSubscription(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetDebug(this AzureAdGroupMemberCheckSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetDebug(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetHelp(this AzureAdGroupMemberCheckSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetHelp(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetOutput(this AzureAdGroupMemberCheckSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetOutput(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetQuery(this AzureAdGroupMemberCheckSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetQuery(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetVerbose(this AzureAdGroupMemberCheckSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetVerbose(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupMemberListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupMemberListSettingsExtensions
    {
        #region Group
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberListSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetGroup(this AzureAdGroupMemberListSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberListSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetGroup(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetSubscription(this AzureAdGroupMemberListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetSubscription(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetDebug(this AzureAdGroupMemberListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetDebug(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetHelp(this AzureAdGroupMemberListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetHelp(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetOutput(this AzureAdGroupMemberListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetOutput(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetQuery(this AzureAdGroupMemberListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetQuery(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetVerbose(this AzureAdGroupMemberListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetVerbose(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupMemberRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupMemberRemoveSettingsExtensions
    {
        #region Group
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetGroup(this AzureAdGroupMemberRemoveSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetGroup(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region MemberId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.MemberId"/></em></p>
        ///   <p>The object ID of the contact, group, user, or service principal.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetMemberId(this AzureAdGroupMemberRemoveSettings toolSettings, string memberId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = memberId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.MemberId"/></em></p>
        ///   <p>The object ID of the contact, group, user, or service principal.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetMemberId(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetSubscription(this AzureAdGroupMemberRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetSubscription(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetDebug(this AzureAdGroupMemberRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetDebug(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetHelp(this AzureAdGroupMemberRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetHelp(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetOutput(this AzureAdGroupMemberRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetOutput(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetQuery(this AzureAdGroupMemberRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetQuery(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetVerbose(this AzureAdGroupMemberRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetVerbose(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupOwnerAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupOwnerAddSettingsExtensions
    {
        #region Group
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetGroup(this AzureAdGroupOwnerAddSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetGroup(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region OwnerObjectId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.OwnerObjectId"/></em></p>
        ///   <p>Owner's object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetOwnerObjectId(this AzureAdGroupOwnerAddSettings toolSettings, string ownerObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = ownerObjectId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.OwnerObjectId"/></em></p>
        ///   <p>Owner's object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetOwnerObjectId(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetSubscription(this AzureAdGroupOwnerAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetSubscription(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetDebug(this AzureAdGroupOwnerAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetDebug(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetHelp(this AzureAdGroupOwnerAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetHelp(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetOutput(this AzureAdGroupOwnerAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetOutput(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetQuery(this AzureAdGroupOwnerAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetQuery(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetVerbose(this AzureAdGroupOwnerAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetVerbose(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupOwnerListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupOwnerListSettingsExtensions
    {
        #region Group
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetGroup(this AzureAdGroupOwnerListSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetGroup(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetSubscription(this AzureAdGroupOwnerListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetSubscription(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetDebug(this AzureAdGroupOwnerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetDebug(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetHelp(this AzureAdGroupOwnerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetHelp(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetOutput(this AzureAdGroupOwnerListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetOutput(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetQuery(this AzureAdGroupOwnerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetQuery(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetVerbose(this AzureAdGroupOwnerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetVerbose(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupOwnerRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupOwnerRemoveSettingsExtensions
    {
        #region Group
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetGroup(this AzureAdGroupOwnerRemoveSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Group"/></em></p>
        ///   <p>Group's object id or display name(prefix also works if there is a unique match).</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetGroup(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region OwnerObjectId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.OwnerObjectId"/></em></p>
        ///   <p>Owner's object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetOwnerObjectId(this AzureAdGroupOwnerRemoveSettings toolSettings, string ownerObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = ownerObjectId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.OwnerObjectId"/></em></p>
        ///   <p>Owner's object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetOwnerObjectId(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetSubscription(this AzureAdGroupOwnerRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetSubscription(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetDebug(this AzureAdGroupOwnerRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetDebug(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetHelp(this AzureAdGroupOwnerRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetHelp(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetOutput(this AzureAdGroupOwnerRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetOutput(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetQuery(this AzureAdGroupOwnerRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetQuery(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetVerbose(this AzureAdGroupOwnerRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetVerbose(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCredentialDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCredentialDeleteSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Id"/></em></p>
        ///   <p>Service principal name, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetId(this AzureAdSpCredentialDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Id"/></em></p>
        ///   <p>Service principal name, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetId(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region KeyId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.KeyId"/></em></p>
        ///   <p>Credential key id.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetKeyId(this AzureAdSpCredentialDeleteSettings toolSettings, string keyId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyId = keyId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.KeyId"/></em></p>
        ///   <p>Credential key id.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetKeyId(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyId = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Cert"/></em></p>
        ///   <p>A certificate based credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetCert(this AzureAdSpCredentialDeleteSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Cert"/></em></p>
        ///   <p>A certificate based credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetCert(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetSubscription(this AzureAdSpCredentialDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetSubscription(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetDebug(this AzureAdSpCredentialDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetDebug(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetHelp(this AzureAdSpCredentialDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetHelp(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetOutput(this AzureAdSpCredentialDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetOutput(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetQuery(this AzureAdSpCredentialDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetQuery(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetVerbose(this AzureAdSpCredentialDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetVerbose(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCredentialListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCredentialListSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialListSettings.Id"/></em></p>
        ///   <p>Service principal name, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetId(this AzureAdSpCredentialListSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialListSettings.Id"/></em></p>
        ///   <p>Service principal name, or object id.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetId(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialListSettings.Cert"/></em></p>
        ///   <p>A certificate based credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetCert(this AzureAdSpCredentialListSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialListSettings.Cert"/></em></p>
        ///   <p>A certificate based credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetCert(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetSubscription(this AzureAdSpCredentialListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetSubscription(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetDebug(this AzureAdSpCredentialListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetDebug(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetHelp(this AzureAdSpCredentialListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetHelp(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetOutput(this AzureAdSpCredentialListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetOutput(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetQuery(this AzureAdSpCredentialListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetQuery(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetVerbose(this AzureAdSpCredentialListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetVerbose(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCredentialResetSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCredentialResetSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Name"/></em></p>
        ///   <p>Name or app ID of the service principal.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetName(this AzureAdSpCredentialResetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Name"/></em></p>
        ///   <p>Name or app ID of the service principal.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetName(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Append
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Append"/></em></p>
        ///   <p>Append the new credential instead of overwriting.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetAppend(this AzureAdSpCredentialResetSettings toolSettings, string append)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Append = append;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Append"/></em></p>
        ///   <p>Append the new credential instead of overwriting.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetAppend(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Append = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Cert"/></em></p>
        ///   <p>Certificate to use for credentials.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetCert(this AzureAdSpCredentialResetSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Cert"/></em></p>
        ///   <p>Certificate to use for credentials.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetCert(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region CreateCert
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.CreateCert"/></em></p>
        ///   <p>Create a self-signed certificate to use for the credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetCreateCert(this AzureAdSpCredentialResetSettings toolSettings, string createCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = createCert;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.CreateCert"/></em></p>
        ///   <p>Create a self-signed certificate to use for the credential.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetCreateCert(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = null;
            return toolSettings;
        }
        #endregion
        #region CredentialDescription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.CredentialDescription"/></em></p>
        ///   <p>The description of the password.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetCredentialDescription(this AzureAdSpCredentialResetSettings toolSettings, string credentialDescription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = credentialDescription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.CredentialDescription"/></em></p>
        ///   <p>The description of the password.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetCredentialDescription(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.EndDate"/></em></p>
        ///   <p>Finer grain of expiry time if '--years' is insufficient, e.g. '2020-12-31T11:59:59+00:00' or '2299-12-31'.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetEndDate(this AzureAdSpCredentialResetSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.EndDate"/></em></p>
        ///   <p>Finer grain of expiry time if '--years' is insufficient, e.g. '2020-12-31T11:59:59+00:00' or '2299-12-31'.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetEndDate(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region Keyvault
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Keyvault"/></em></p>
        ///   <p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetKeyvault(this AzureAdSpCredentialResetSettings toolSettings, string keyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = keyvault;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Keyvault"/></em></p>
        ///   <p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetKeyvault(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Password"/></em></p>
        ///   <p>The password used to log in.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetPassword(this AzureAdSpCredentialResetSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Password"/></em></p>
        ///   <p>The password used to log in.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetPassword(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Years
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Years"/></em></p>
        ///   <p>Number of years for which the credentials will be valid. Default: 1 year.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetYears(this AzureAdSpCredentialResetSettings toolSettings, int? years)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = years;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Years"/></em></p>
        ///   <p>Number of years for which the credentials will be valid. Default: 1 year.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetYears(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetSubscription(this AzureAdSpCredentialResetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetSubscription(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetDebug(this AzureAdSpCredentialResetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetDebug(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetHelp(this AzureAdSpCredentialResetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetHelp(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetOutput(this AzureAdSpCredentialResetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetOutput(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetQuery(this AzureAdSpCredentialResetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetQuery(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetVerbose(this AzureAdSpCredentialResetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetVerbose(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpOwnerListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpOwnerListSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpOwnerListSettings.Id"/></em></p>
        ///   <p>Service principal name, or object id or the service principal.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetId(this AzureAdSpOwnerListSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpOwnerListSettings.Id"/></em></p>
        ///   <p>Service principal name, or object id or the service principal.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetId(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpOwnerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetSubscription(this AzureAdSpOwnerListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpOwnerListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetSubscription(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpOwnerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetDebug(this AzureAdSpOwnerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpOwnerListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetDebug(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpOwnerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetHelp(this AzureAdSpOwnerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpOwnerListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetHelp(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpOwnerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetOutput(this AzureAdSpOwnerListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpOwnerListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetOutput(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpOwnerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetQuery(this AzureAdSpOwnerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpOwnerListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetQuery(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAdSpOwnerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetVerbose(this AzureAdSpOwnerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAdSpOwnerListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetVerbose(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AdAppKeyType
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AdAppKeyType>))]
    public partial class AdAppKeyType : Enumeration
    {
        public static AdAppKeyType asymmetricx509cert = new AdAppKeyType { Value = "asymmetricx509cert" };
        public static AdAppKeyType password = new AdAppKeyType { Value = "password" };
        public static AdAppKeyType symmetric = new AdAppKeyType { Value = "symmetric" };
    }
    #endregion
    #region AdAppKeyUsage
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AdAppKeyUsage>))]
    public partial class AdAppKeyUsage : Enumeration
    {
        public static AdAppKeyUsage sign = new AdAppKeyUsage { Value = "sign" };
        public static AdAppKeyUsage verify = new AdAppKeyUsage { Value = "verify" };
    }
    #endregion
    #region AdAppPermissionGrantConsentType
    /// <summary>
    ///   Used within <see cref="AzureAdTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AdAppPermissionGrantConsentType>))]
    public partial class AdAppPermissionGrantConsentType : Enumeration
    {
        public static AdAppPermissionGrantConsentType allprincipals = new AdAppPermissionGrantConsentType { Value = "allprincipals" };
        public static AdAppPermissionGrantConsentType principal = new AdAppPermissionGrantConsentType { Value = "principal" };
    }
    #endregion
}
