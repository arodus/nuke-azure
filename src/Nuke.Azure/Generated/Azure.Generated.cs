// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/Azure.json
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
    public static partial class AzureTasks
    {
        /// <summary>
        ///   Path to the Azure executable.
        /// </summary>
        public static string AzurePath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURE_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   General Tasks.
        /// </summary>
        public static IReadOnlyCollection<Output> Azure(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzurePath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureConfigure(AzureConfigureSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureConfigureSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureConfigureSettings.Debug"/></li>
        ///     <li><c>--defaults</c> via <see cref="AzureConfigureSettings.Defaults"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConfigureSettings.Help"/></li>
        ///     <li><c>--list-defaults</c> via <see cref="AzureConfigureSettings.ListDefaults"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConfigureSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConfigureSettings.Query"/></li>
        ///     <li><c>--scope</c> via <see cref="AzureConfigureSettings.Scope"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConfigureSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureConfigure(Configure<AzureConfigureSettings> configurator)
        {
            return AzureConfigure(configurator(new AzureConfigureSettings()));
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureConfigureSettings.Debug"/></li>
        ///     <li><c>--defaults</c> via <see cref="AzureConfigureSettings.Defaults"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConfigureSettings.Help"/></li>
        ///     <li><c>--list-defaults</c> via <see cref="AzureConfigureSettings.ListDefaults"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConfigureSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConfigureSettings.Query"/></li>
        ///     <li><c>--scope</c> via <see cref="AzureConfigureSettings.Scope"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConfigureSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureConfigureSettings Settings, IReadOnlyCollection<Output> Output)> AzureConfigure(CombinatorialConfigure<AzureConfigureSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureConfigure, AzureLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureFeedback(AzureFeedbackSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureFeedbackSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureFeedbackSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureFeedbackSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureFeedbackSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureFeedbackSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureFeedbackSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureFeedback(Configure<AzureFeedbackSettings> configurator)
        {
            return AzureFeedback(configurator(new AzureFeedbackSettings()));
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureFeedbackSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureFeedbackSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureFeedbackSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureFeedbackSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureFeedbackSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureFeedbackSettings Settings, IReadOnlyCollection<Output> Output)> AzureFeedback(CombinatorialConfigure<AzureFeedbackSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureFeedback, AzureLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureFind(AzureFindSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureFindSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureFindSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureFindSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureFindSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureFindSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureFindSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureFind(Configure<AzureFindSettings> configurator)
        {
            return AzureFind(configurator(new AzureFindSettings()));
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureFindSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureFindSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureFindSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureFindSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureFindSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureFindSettings Settings, IReadOnlyCollection<Output> Output)> AzureFind(CombinatorialConfigure<AzureFindSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureFind, AzureLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureInteractive(AzureInteractiveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureInteractiveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureInteractiveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureInteractiveSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureInteractiveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureInteractiveSettings.Query"/></li>
        ///     <li><c>--style</c> via <see cref="AzureInteractiveSettings.Style"/></li>
        ///     <li><c>--update</c> via <see cref="AzureInteractiveSettings.Update"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureInteractiveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureInteractive(Configure<AzureInteractiveSettings> configurator)
        {
            return AzureInteractive(configurator(new AzureInteractiveSettings()));
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureInteractiveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureInteractiveSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureInteractiveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureInteractiveSettings.Query"/></li>
        ///     <li><c>--style</c> via <see cref="AzureInteractiveSettings.Style"/></li>
        ///     <li><c>--update</c> via <see cref="AzureInteractiveSettings.Update"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureInteractiveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureInteractiveSettings Settings, IReadOnlyCollection<Output> Output)> AzureInteractive(CombinatorialConfigure<AzureInteractiveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureInteractive, AzureLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureLogin(AzureLoginSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureLoginSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--allow-no-subscriptions</c> via <see cref="AzureLoginSettings.AllowNoSubscriptions"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureLoginSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLoginSettings.Help"/></li>
        ///     <li><c>--identity</c> via <see cref="AzureLoginSettings.Identity"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLoginSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureLoginSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLoginSettings.Query"/></li>
        ///     <li><c>--service-principal</c> via <see cref="AzureLoginSettings.ServicePrincipal"/></li>
        ///     <li><c>--tenant</c> via <see cref="AzureLoginSettings.Tenant"/></li>
        ///     <li><c>--use-cert-sn-issuer</c> via <see cref="AzureLoginSettings.UseCertSnIssuer"/></li>
        ///     <li><c>--use-device-code</c> via <see cref="AzureLoginSettings.UseDeviceCode"/></li>
        ///     <li><c>--username</c> via <see cref="AzureLoginSettings.Username"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLoginSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureLogin(Configure<AzureLoginSettings> configurator)
        {
            return AzureLogin(configurator(new AzureLoginSettings()));
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--allow-no-subscriptions</c> via <see cref="AzureLoginSettings.AllowNoSubscriptions"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureLoginSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLoginSettings.Help"/></li>
        ///     <li><c>--identity</c> via <see cref="AzureLoginSettings.Identity"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLoginSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AzureLoginSettings.Password"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLoginSettings.Query"/></li>
        ///     <li><c>--service-principal</c> via <see cref="AzureLoginSettings.ServicePrincipal"/></li>
        ///     <li><c>--tenant</c> via <see cref="AzureLoginSettings.Tenant"/></li>
        ///     <li><c>--use-cert-sn-issuer</c> via <see cref="AzureLoginSettings.UseCertSnIssuer"/></li>
        ///     <li><c>--use-device-code</c> via <see cref="AzureLoginSettings.UseDeviceCode"/></li>
        ///     <li><c>--username</c> via <see cref="AzureLoginSettings.Username"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLoginSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureLoginSettings Settings, IReadOnlyCollection<Output> Output)> AzureLogin(CombinatorialConfigure<AzureLoginSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureLogin, AzureLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureLogout(AzureLogoutSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureLogoutSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureLogoutSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLogoutSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLogoutSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLogoutSettings.Query"/></li>
        ///     <li><c>--username</c> via <see cref="AzureLogoutSettings.Username"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLogoutSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureLogout(Configure<AzureLogoutSettings> configurator)
        {
            return AzureLogout(configurator(new AzureLogoutSettings()));
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureLogoutSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureLogoutSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureLogoutSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureLogoutSettings.Query"/></li>
        ///     <li><c>--username</c> via <see cref="AzureLogoutSettings.Username"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureLogoutSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureLogoutSettings Settings, IReadOnlyCollection<Output> Output)> AzureLogout(CombinatorialConfigure<AzureLogoutSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureLogout, AzureLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRest(AzureRestSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRestSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--body</c> via <see cref="AzureRestSettings.Body"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRestSettings.Debug"/></li>
        ///     <li><c>--headers</c> via <see cref="AzureRestSettings.Headers"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRestSettings.Help"/></li>
        ///     <li><c>--method</c> via <see cref="AzureRestSettings.Method"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRestSettings.Output"/></li>
        ///     <li><c>--output-file</c> via <see cref="AzureRestSettings.OutputFile"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRestSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureRestSettings.Resource"/></li>
        ///     <li><c>--skip-authorization-header</c> via <see cref="AzureRestSettings.SkipAuthorizationHeader"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRestSettings.Subscription"/></li>
        ///     <li><c>--uri</c> via <see cref="AzureRestSettings.Uri"/></li>
        ///     <li><c>--uri-parameters</c> via <see cref="AzureRestSettings.UriParameters"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRestSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRest(Configure<AzureRestSettings> configurator)
        {
            return AzureRest(configurator(new AzureRestSettings()));
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--body</c> via <see cref="AzureRestSettings.Body"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRestSettings.Debug"/></li>
        ///     <li><c>--headers</c> via <see cref="AzureRestSettings.Headers"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRestSettings.Help"/></li>
        ///     <li><c>--method</c> via <see cref="AzureRestSettings.Method"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRestSettings.Output"/></li>
        ///     <li><c>--output-file</c> via <see cref="AzureRestSettings.OutputFile"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRestSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureRestSettings.Resource"/></li>
        ///     <li><c>--skip-authorization-header</c> via <see cref="AzureRestSettings.SkipAuthorizationHeader"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRestSettings.Subscription"/></li>
        ///     <li><c>--uri</c> via <see cref="AzureRestSettings.Uri"/></li>
        ///     <li><c>--uri-parameters</c> via <see cref="AzureRestSettings.UriParameters"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRestSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRestSettings Settings, IReadOnlyCollection<Output> Output)> AzureRest(CombinatorialConfigure<AzureRestSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRest, AzureLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSelfTest(AzureSelfTestSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSelfTestSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSelfTestSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSelfTestSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSelfTestSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSelfTestSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSelfTestSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSelfTestSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSelfTest(Configure<AzureSelfTestSettings> configurator)
        {
            return AzureSelfTest(configurator(new AzureSelfTestSettings()));
        }
        /// <summary>
        ///   <p>General Tasks.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSelfTestSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSelfTestSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSelfTestSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSelfTestSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSelfTestSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSelfTestSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSelfTestSettings Settings, IReadOnlyCollection<Output> Output)> AzureSelfTest(CombinatorialConfigure<AzureSelfTestSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSelfTest, AzureLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureConfigureSettings
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConfigureSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Azure executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
        public override Action<OutputType, string> CustomLogger => AzureTasks.AzureLogger;
        /// <summary>
        ///   Space-separated 'name=value' pairs for common argument defaults.
        /// </summary>
        public virtual IReadOnlyDictionary<string, object> Defaults => DefaultsInternal.AsReadOnly();
        internal Dictionary<string, object> DefaultsInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary>
        ///   List all applicable defaults.
        /// </summary>
        public virtual bool? ListDefaults { get; internal set; }
        /// <summary>
        ///   Scope of defaults. Using "local" for settings only effective under current folder.
        /// </summary>
        public virtual ConfigureScope Scope { get; internal set; }
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
              .Add("configure")
              .Add("--defaults {value}", Defaults, "{key}={value}", separator: ' ')
              .Add("--list-defaults", ListDefaults)
              .Add("--scope {value}", Scope)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFeedbackSettings
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFeedbackSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Azure executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
        public override Action<OutputType, string> CustomLogger => AzureTasks.AzureLogger;
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
              .Add("feedback")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFindSettings
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFindSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Azure executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
        public override Action<OutputType, string> CustomLogger => AzureTasks.AzureLogger;
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
              .Add("find")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureInteractiveSettings
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureInteractiveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Azure executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
        public override Action<OutputType, string> CustomLogger => AzureTasks.AzureLogger;
        /// <summary>
        ///   The colors of the shell.
        /// </summary>
        public virtual InteractiveStyle Style { get; internal set; }
        /// <summary>
        ///   Update the Interactive extension to the latest available.
        /// </summary>
        public virtual string Update { get; internal set; }
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
              .Add("interactive")
              .Add("--style {value}", Style)
              .Add("--update {value}", Update)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureLoginSettings
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLoginSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Azure executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
        public override Action<OutputType, string> CustomLogger => AzureTasks.AzureLogger;
        /// <summary>
        ///   Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.
        /// </summary>
        public virtual bool? AllowNoSubscriptions { get; internal set; }
        /// <summary>
        ///   Credentials like user password, or for a service principal, provide client secret or a pem file with key and public certificate. Will prompt if not given.
        /// </summary>
        public virtual string Password { get; internal set; }
        /// <summary>
        ///   The credential representing a service principal.
        /// </summary>
        public virtual bool? ServicePrincipal { get; internal set; }
        /// <summary>
        ///   The AAD tenant, must provide when using service principals.
        /// </summary>
        public virtual string Tenant { get; internal set; }
        /// <summary>
        ///   Used with a service principal configured with Subject Name and Issuer Authentication in order to support automatic certificate rolls.
        /// </summary>
        public virtual string UseCertSnIssuer { get; internal set; }
        /// <summary>
        ///   Use CLI's old authentication flow based on device code. CLI will also use this if it can't launch a browser in your behalf, e.g. in remote SSH or Cloud Shell.
        /// </summary>
        public virtual string UseDeviceCode { get; internal set; }
        /// <summary>
        ///   User name, service principal, or managed service identity ID.
        /// </summary>
        public virtual string Username { get; internal set; }
        /// <summary>
        ///   Log in using the Virtual Machine's identity.
        /// </summary>
        public virtual bool? Identity { get; internal set; }
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
              .Add("login")
              .Add("--allow-no-subscriptions", AllowNoSubscriptions)
              .Add("--password {value}", Password, secret: true)
              .Add("--service-principal", ServicePrincipal)
              .Add("--tenant {value}", Tenant)
              .Add("--use-cert-sn-issuer {value}", UseCertSnIssuer)
              .Add("--use-device-code {value}", UseDeviceCode)
              .Add("--username {value}", Username)
              .Add("--identity", Identity)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureLogoutSettings
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLogoutSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Azure executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
        public override Action<OutputType, string> CustomLogger => AzureTasks.AzureLogger;
        /// <summary>
        ///   Account user, if missing, logout the current active account.
        /// </summary>
        public virtual string Username { get; internal set; }
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
              .Add("logout")
              .Add("--username {value}", Username)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRestSettings
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRestSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Azure executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
        public override Action<OutputType, string> CustomLogger => AzureTasks.AzureLogger;
        /// <summary>
        ///   HTTP request method.
        /// </summary>
        public virtual RestMethod Method { get; internal set; }
        /// <summary>
        ///   Request uri. For uri without host, CLI will assume "<a href="https://management.azure.com/">https://management.azure.com/</a>". Common tokens will also be replaced with real values including "{subscriptionId}".
        /// </summary>
        public virtual string Uri { get; internal set; }
        /// <summary>
        ///   Request body.
        /// </summary>
        public virtual string Body { get; internal set; }
        /// <summary>
        ///   Space-separated headers in KEY=VALUE format or JSON string. Use @{file} to load from a file.
        /// </summary>
        public virtual IReadOnlyList<string> Headers => HeadersInternal.AsReadOnly();
        internal List<string> HeadersInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Save response payload to a file.
        /// </summary>
        public virtual string OutputFile { get; internal set; }
        /// <summary>
        ///   Resource url for which CLI should acquire a token in order to access the service. The token will be placed in the "Authorization" header. By default, CLI can figure this out based on "--url" argument, unless you use ones not in the list of "az cloud show --query endpoints".
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Do not auto append "Authorization" header.
        /// </summary>
        public virtual string SkipAuthorizationHeader { get; internal set; }
        /// <summary>
        ///   Space-separated queries in KEY=VALUE format or JSON string. Use @{file} to load from a file.
        /// </summary>
        public virtual IReadOnlyList<string> UriParameters => UriParametersInternal.AsReadOnly();
        internal List<string> UriParametersInternal { get; set; } = new List<string>();
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
              .Add("rest")
              .Add("--method {value}", Method)
              .Add("--uri {value}", Uri)
              .Add("--body {value}", Body)
              .Add("--headers {value}", Headers, separator: ' ')
              .Add("--output-file {value}", OutputFile)
              .Add("--resource {value}", Resource)
              .Add("--skip-authorization-header {value}", SkipAuthorizationHeader)
              .Add("--uri-parameters {value}", UriParameters, separator: ' ')
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
    #region AzureSelfTestSettings
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSelfTestSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Azure executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
        public override Action<OutputType, string> CustomLogger => AzureTasks.AzureLogger;
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
              .Add("self-test")
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
    #region AzureConfigureSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConfigureSettingsExtensions
    {
        #region Defaults
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConfigureSettings.Defaults"/> to a new dictionary</em></p>
        ///   <p>Space-separated 'name=value' pairs for common argument defaults.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings SetDefaults(this AzureConfigureSettings toolSettings, IDictionary<string, object> defaults)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultsInternal = defaults.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureConfigureSettings.Defaults"/></em></p>
        ///   <p>Space-separated 'name=value' pairs for common argument defaults.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings ClearDefaults(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds a new key-value-pair <see cref="AzureConfigureSettings.Defaults"/></em></p>
        ///   <p>Space-separated 'name=value' pairs for common argument defaults.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings AddDefault(this AzureConfigureSettings toolSettings, string defaultKey, object defaultValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultsInternal.Add(defaultKey, defaultValue);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes a key-value-pair from <see cref="AzureConfigureSettings.Defaults"/></em></p>
        ///   <p>Space-separated 'name=value' pairs for common argument defaults.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings RemoveDefault(this AzureConfigureSettings toolSettings, string defaultKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultsInternal.Remove(defaultKey);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets a key-value-pair in <see cref="AzureConfigureSettings.Defaults"/></em></p>
        ///   <p>Space-separated 'name=value' pairs for common argument defaults.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings SetDefault(this AzureConfigureSettings toolSettings, string defaultKey, object defaultValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultsInternal[defaultKey] = defaultValue;
            return toolSettings;
        }
        #endregion
        #region ListDefaults
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConfigureSettings.ListDefaults"/></em></p>
        ///   <p>List all applicable defaults.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings SetListDefaults(this AzureConfigureSettings toolSettings, bool? listDefaults)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListDefaults = listDefaults;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConfigureSettings.ListDefaults"/></em></p>
        ///   <p>List all applicable defaults.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings ResetListDefaults(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListDefaults = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureConfigureSettings.ListDefaults"/></em></p>
        ///   <p>List all applicable defaults.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings EnableListDefaults(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListDefaults = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureConfigureSettings.ListDefaults"/></em></p>
        ///   <p>List all applicable defaults.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings DisableListDefaults(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListDefaults = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureConfigureSettings.ListDefaults"/></em></p>
        ///   <p>List all applicable defaults.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings ToggleListDefaults(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListDefaults = !toolSettings.ListDefaults;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConfigureSettings.Scope"/></em></p>
        ///   <p>Scope of defaults. Using "local" for settings only effective under current folder.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings SetScope(this AzureConfigureSettings toolSettings, ConfigureScope scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConfigureSettings.Scope"/></em></p>
        ///   <p>Scope of defaults. Using "local" for settings only effective under current folder.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings ResetScope(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConfigureSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings SetDebug(this AzureConfigureSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConfigureSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings ResetDebug(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConfigureSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings SetHelp(this AzureConfigureSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConfigureSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings ResetHelp(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConfigureSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings SetOutput(this AzureConfigureSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConfigureSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings ResetOutput(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConfigureSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings SetQuery(this AzureConfigureSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConfigureSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings ResetQuery(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConfigureSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings SetVerbose(this AzureConfigureSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConfigureSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConfigureSettings ResetVerbose(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFeedbackSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFeedbackSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeedbackSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeedbackSettings SetDebug(this AzureFeedbackSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeedbackSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeedbackSettings ResetDebug(this AzureFeedbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeedbackSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureFeedbackSettings SetHelp(this AzureFeedbackSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeedbackSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureFeedbackSettings ResetHelp(this AzureFeedbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeedbackSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureFeedbackSettings SetOutput(this AzureFeedbackSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeedbackSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureFeedbackSettings ResetOutput(this AzureFeedbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeedbackSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureFeedbackSettings SetQuery(this AzureFeedbackSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeedbackSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureFeedbackSettings ResetQuery(this AzureFeedbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeedbackSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeedbackSettings SetVerbose(this AzureFeedbackSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeedbackSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeedbackSettings ResetVerbose(this AzureFeedbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFindSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFindSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFindSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFindSettings SetDebug(this AzureFindSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFindSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFindSettings ResetDebug(this AzureFindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFindSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureFindSettings SetHelp(this AzureFindSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFindSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureFindSettings ResetHelp(this AzureFindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFindSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureFindSettings SetOutput(this AzureFindSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFindSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureFindSettings ResetOutput(this AzureFindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFindSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureFindSettings SetQuery(this AzureFindSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFindSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureFindSettings ResetQuery(this AzureFindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFindSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFindSettings SetVerbose(this AzureFindSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFindSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFindSettings ResetVerbose(this AzureFindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureInteractiveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureInteractiveSettingsExtensions
    {
        #region Style
        /// <summary>
        ///   <p><em>Sets <see cref="AzureInteractiveSettings.Style"/></em></p>
        ///   <p>The colors of the shell.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings SetStyle(this AzureInteractiveSettings toolSettings, InteractiveStyle style)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Style = style;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureInteractiveSettings.Style"/></em></p>
        ///   <p>The colors of the shell.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings ResetStyle(this AzureInteractiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Style = null;
            return toolSettings;
        }
        #endregion
        #region Update
        /// <summary>
        ///   <p><em>Sets <see cref="AzureInteractiveSettings.Update"/></em></p>
        ///   <p>Update the Interactive extension to the latest available.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings SetUpdate(this AzureInteractiveSettings toolSettings, string update)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Update = update;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureInteractiveSettings.Update"/></em></p>
        ///   <p>Update the Interactive extension to the latest available.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings ResetUpdate(this AzureInteractiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Update = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureInteractiveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings SetDebug(this AzureInteractiveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureInteractiveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings ResetDebug(this AzureInteractiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureInteractiveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings SetHelp(this AzureInteractiveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureInteractiveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings ResetHelp(this AzureInteractiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureInteractiveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings SetOutput(this AzureInteractiveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureInteractiveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings ResetOutput(this AzureInteractiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureInteractiveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings SetQuery(this AzureInteractiveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureInteractiveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings ResetQuery(this AzureInteractiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureInteractiveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings SetVerbose(this AzureInteractiveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureInteractiveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureInteractiveSettings ResetVerbose(this AzureInteractiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLoginSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLoginSettingsExtensions
    {
        #region AllowNoSubscriptions
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLoginSettings.AllowNoSubscriptions"/></em></p>
        ///   <p>Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings SetAllowNoSubscriptions(this AzureLoginSettings toolSettings, bool? allowNoSubscriptions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowNoSubscriptions = allowNoSubscriptions;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLoginSettings.AllowNoSubscriptions"/></em></p>
        ///   <p>Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ResetAllowNoSubscriptions(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowNoSubscriptions = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureLoginSettings.AllowNoSubscriptions"/></em></p>
        ///   <p>Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings EnableAllowNoSubscriptions(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowNoSubscriptions = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureLoginSettings.AllowNoSubscriptions"/></em></p>
        ///   <p>Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings DisableAllowNoSubscriptions(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowNoSubscriptions = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureLoginSettings.AllowNoSubscriptions"/></em></p>
        ///   <p>Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ToggleAllowNoSubscriptions(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowNoSubscriptions = !toolSettings.AllowNoSubscriptions;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLoginSettings.Password"/></em></p>
        ///   <p>Credentials like user password, or for a service principal, provide client secret or a pem file with key and public certificate. Will prompt if not given.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings SetPassword(this AzureLoginSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLoginSettings.Password"/></em></p>
        ///   <p>Credentials like user password, or for a service principal, provide client secret or a pem file with key and public certificate. Will prompt if not given.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ResetPassword(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ServicePrincipal
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLoginSettings.ServicePrincipal"/></em></p>
        ///   <p>The credential representing a service principal.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings SetServicePrincipal(this AzureLoginSettings toolSettings, bool? servicePrincipal)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = servicePrincipal;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLoginSettings.ServicePrincipal"/></em></p>
        ///   <p>The credential representing a service principal.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ResetServicePrincipal(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureLoginSettings.ServicePrincipal"/></em></p>
        ///   <p>The credential representing a service principal.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings EnableServicePrincipal(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureLoginSettings.ServicePrincipal"/></em></p>
        ///   <p>The credential representing a service principal.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings DisableServicePrincipal(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureLoginSettings.ServicePrincipal"/></em></p>
        ///   <p>The credential representing a service principal.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ToggleServicePrincipal(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = !toolSettings.ServicePrincipal;
            return toolSettings;
        }
        #endregion
        #region Tenant
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLoginSettings.Tenant"/></em></p>
        ///   <p>The AAD tenant, must provide when using service principals.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings SetTenant(this AzureLoginSettings toolSettings, string tenant)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tenant = tenant;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLoginSettings.Tenant"/></em></p>
        ///   <p>The AAD tenant, must provide when using service principals.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ResetTenant(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tenant = null;
            return toolSettings;
        }
        #endregion
        #region UseCertSnIssuer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLoginSettings.UseCertSnIssuer"/></em></p>
        ///   <p>Used with a service principal configured with Subject Name and Issuer Authentication in order to support automatic certificate rolls.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings SetUseCertSnIssuer(this AzureLoginSettings toolSettings, string useCertSnIssuer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseCertSnIssuer = useCertSnIssuer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLoginSettings.UseCertSnIssuer"/></em></p>
        ///   <p>Used with a service principal configured with Subject Name and Issuer Authentication in order to support automatic certificate rolls.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ResetUseCertSnIssuer(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseCertSnIssuer = null;
            return toolSettings;
        }
        #endregion
        #region UseDeviceCode
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLoginSettings.UseDeviceCode"/></em></p>
        ///   <p>Use CLI's old authentication flow based on device code. CLI will also use this if it can't launch a browser in your behalf, e.g. in remote SSH or Cloud Shell.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings SetUseDeviceCode(this AzureLoginSettings toolSettings, string useDeviceCode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseDeviceCode = useDeviceCode;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLoginSettings.UseDeviceCode"/></em></p>
        ///   <p>Use CLI's old authentication flow based on device code. CLI will also use this if it can't launch a browser in your behalf, e.g. in remote SSH or Cloud Shell.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ResetUseDeviceCode(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseDeviceCode = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLoginSettings.Username"/></em></p>
        ///   <p>User name, service principal, or managed service identity ID.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings SetUsername(this AzureLoginSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLoginSettings.Username"/></em></p>
        ///   <p>User name, service principal, or managed service identity ID.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ResetUsername(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Identity
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLoginSettings.Identity"/></em></p>
        ///   <p>Log in using the Virtual Machine's identity.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings SetIdentity(this AzureLoginSettings toolSettings, bool? identity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identity = identity;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLoginSettings.Identity"/></em></p>
        ///   <p>Log in using the Virtual Machine's identity.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ResetIdentity(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identity = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureLoginSettings.Identity"/></em></p>
        ///   <p>Log in using the Virtual Machine's identity.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings EnableIdentity(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identity = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureLoginSettings.Identity"/></em></p>
        ///   <p>Log in using the Virtual Machine's identity.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings DisableIdentity(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identity = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureLoginSettings.Identity"/></em></p>
        ///   <p>Log in using the Virtual Machine's identity.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ToggleIdentity(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identity = !toolSettings.Identity;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLoginSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings SetDebug(this AzureLoginSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLoginSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ResetDebug(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLoginSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings SetHelp(this AzureLoginSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLoginSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ResetHelp(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLoginSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings SetOutput(this AzureLoginSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLoginSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ResetOutput(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLoginSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings SetQuery(this AzureLoginSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLoginSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ResetQuery(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLoginSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings SetVerbose(this AzureLoginSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLoginSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLoginSettings ResetVerbose(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLogoutSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLogoutSettingsExtensions
    {
        #region Username
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLogoutSettings.Username"/></em></p>
        ///   <p>Account user, if missing, logout the current active account.</p>
        /// </summary>
        [Pure]
        public static AzureLogoutSettings SetUsername(this AzureLogoutSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLogoutSettings.Username"/></em></p>
        ///   <p>Account user, if missing, logout the current active account.</p>
        /// </summary>
        [Pure]
        public static AzureLogoutSettings ResetUsername(this AzureLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLogoutSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLogoutSettings SetDebug(this AzureLogoutSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLogoutSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLogoutSettings ResetDebug(this AzureLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLogoutSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLogoutSettings SetHelp(this AzureLogoutSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLogoutSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureLogoutSettings ResetHelp(this AzureLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLogoutSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLogoutSettings SetOutput(this AzureLogoutSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLogoutSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureLogoutSettings ResetOutput(this AzureLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLogoutSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLogoutSettings SetQuery(this AzureLogoutSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLogoutSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureLogoutSettings ResetQuery(this AzureLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureLogoutSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLogoutSettings SetVerbose(this AzureLogoutSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureLogoutSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureLogoutSettings ResetVerbose(this AzureLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRestSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRestSettingsExtensions
    {
        #region Method
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.Method"/></em></p>
        ///   <p>HTTP request method.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetMethod(this AzureRestSettings toolSettings, RestMethod method)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Method = method;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRestSettings.Method"/></em></p>
        ///   <p>HTTP request method.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ResetMethod(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Method = null;
            return toolSettings;
        }
        #endregion
        #region Uri
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.Uri"/></em></p>
        ///   <p>Request uri. For uri without host, CLI will assume "<a href="https://management.azure.com/">https://management.azure.com/</a>". Common tokens will also be replaced with real values including "{subscriptionId}".</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetUri(this AzureRestSettings toolSettings, string uri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = uri;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRestSettings.Uri"/></em></p>
        ///   <p>Request uri. For uri without host, CLI will assume "<a href="https://management.azure.com/">https://management.azure.com/</a>". Common tokens will also be replaced with real values including "{subscriptionId}".</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ResetUri(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Uri = null;
            return toolSettings;
        }
        #endregion
        #region Body
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.Body"/></em></p>
        ///   <p>Request body.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetBody(this AzureRestSettings toolSettings, string body)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Body = body;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRestSettings.Body"/></em></p>
        ///   <p>Request body.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ResetBody(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Body = null;
            return toolSettings;
        }
        #endregion
        #region Headers
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.Headers"/> to a new list</em></p>
        ///   <p>Space-separated headers in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetHeaders(this AzureRestSettings toolSettings, params string[] headers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HeadersInternal = headers.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.Headers"/> to a new list</em></p>
        ///   <p>Space-separated headers in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetHeaders(this AzureRestSettings toolSettings, IEnumerable<string> headers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HeadersInternal = headers.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRestSettings.Headers"/></em></p>
        ///   <p>Space-separated headers in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings AddHeaders(this AzureRestSettings toolSettings, params string[] headers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HeadersInternal.AddRange(headers);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRestSettings.Headers"/></em></p>
        ///   <p>Space-separated headers in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings AddHeaders(this AzureRestSettings toolSettings, IEnumerable<string> headers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HeadersInternal.AddRange(headers);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRestSettings.Headers"/></em></p>
        ///   <p>Space-separated headers in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ClearHeaders(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HeadersInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRestSettings.Headers"/></em></p>
        ///   <p>Space-separated headers in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings RemoveHeaders(this AzureRestSettings toolSettings, params string[] headers)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(headers);
            toolSettings.HeadersInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRestSettings.Headers"/></em></p>
        ///   <p>Space-separated headers in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings RemoveHeaders(this AzureRestSettings toolSettings, IEnumerable<string> headers)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(headers);
            toolSettings.HeadersInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region OutputFile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.OutputFile"/></em></p>
        ///   <p>Save response payload to a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetOutputFile(this AzureRestSettings toolSettings, string outputFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputFile = outputFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRestSettings.OutputFile"/></em></p>
        ///   <p>Save response payload to a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ResetOutputFile(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputFile = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.Resource"/></em></p>
        ///   <p>Resource url for which CLI should acquire a token in order to access the service. The token will be placed in the "Authorization" header. By default, CLI can figure this out based on "--url" argument, unless you use ones not in the list of "az cloud show --query endpoints".</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetResource(this AzureRestSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRestSettings.Resource"/></em></p>
        ///   <p>Resource url for which CLI should acquire a token in order to access the service. The token will be placed in the "Authorization" header. By default, CLI can figure this out based on "--url" argument, unless you use ones not in the list of "az cloud show --query endpoints".</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ResetResource(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region SkipAuthorizationHeader
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.SkipAuthorizationHeader"/></em></p>
        ///   <p>Do not auto append "Authorization" header.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetSkipAuthorizationHeader(this AzureRestSettings toolSettings, string skipAuthorizationHeader)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAuthorizationHeader = skipAuthorizationHeader;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRestSettings.SkipAuthorizationHeader"/></em></p>
        ///   <p>Do not auto append "Authorization" header.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ResetSkipAuthorizationHeader(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAuthorizationHeader = null;
            return toolSettings;
        }
        #endregion
        #region UriParameters
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.UriParameters"/> to a new list</em></p>
        ///   <p>Space-separated queries in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetUriParameters(this AzureRestSettings toolSettings, params string[] uriParameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UriParametersInternal = uriParameters.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.UriParameters"/> to a new list</em></p>
        ///   <p>Space-separated queries in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetUriParameters(this AzureRestSettings toolSettings, IEnumerable<string> uriParameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UriParametersInternal = uriParameters.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRestSettings.UriParameters"/></em></p>
        ///   <p>Space-separated queries in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings AddUriParameters(this AzureRestSettings toolSettings, params string[] uriParameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UriParametersInternal.AddRange(uriParameters);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRestSettings.UriParameters"/></em></p>
        ///   <p>Space-separated queries in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings AddUriParameters(this AzureRestSettings toolSettings, IEnumerable<string> uriParameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UriParametersInternal.AddRange(uriParameters);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRestSettings.UriParameters"/></em></p>
        ///   <p>Space-separated queries in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ClearUriParameters(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UriParametersInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRestSettings.UriParameters"/></em></p>
        ///   <p>Space-separated queries in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings RemoveUriParameters(this AzureRestSettings toolSettings, params string[] uriParameters)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(uriParameters);
            toolSettings.UriParametersInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRestSettings.UriParameters"/></em></p>
        ///   <p>Space-separated queries in KEY=VALUE format or JSON string. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings RemoveUriParameters(this AzureRestSettings toolSettings, IEnumerable<string> uriParameters)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(uriParameters);
            toolSettings.UriParametersInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetSubscription(this AzureRestSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRestSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ResetSubscription(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetDebug(this AzureRestSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRestSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ResetDebug(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetHelp(this AzureRestSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRestSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ResetHelp(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetOutput(this AzureRestSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRestSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ResetOutput(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetQuery(this AzureRestSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRestSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ResetQuery(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRestSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings SetVerbose(this AzureRestSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRestSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRestSettings ResetVerbose(this AzureRestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSelfTestSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSelfTestSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSelfTestSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSelfTestSettings SetSubscription(this AzureSelfTestSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSelfTestSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSelfTestSettings ResetSubscription(this AzureSelfTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSelfTestSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSelfTestSettings SetDebug(this AzureSelfTestSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSelfTestSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSelfTestSettings ResetDebug(this AzureSelfTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSelfTestSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSelfTestSettings SetHelp(this AzureSelfTestSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSelfTestSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSelfTestSettings ResetHelp(this AzureSelfTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSelfTestSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSelfTestSettings SetOutput(this AzureSelfTestSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSelfTestSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSelfTestSettings ResetOutput(this AzureSelfTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSelfTestSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSelfTestSettings SetQuery(this AzureSelfTestSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSelfTestSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSelfTestSettings ResetQuery(this AzureSelfTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSelfTestSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSelfTestSettings SetVerbose(this AzureSelfTestSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSelfTestSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSelfTestSettings ResetVerbose(this AzureSelfTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region ConfigureScope
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ConfigureScope>))]
    public partial class ConfigureScope : Enumeration
    {
        public static ConfigureScope global = new ConfigureScope { Value = "global" };
        public static ConfigureScope local = new ConfigureScope { Value = "local" };
    }
    #endregion
    #region InteractiveStyle
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<InteractiveStyle>))]
    public partial class InteractiveStyle : Enumeration
    {
        public static InteractiveStyle bg = new InteractiveStyle { Value = "bg" };
        public static InteractiveStyle br = new InteractiveStyle { Value = "br" };
        public static InteractiveStyle contrast = new InteractiveStyle { Value = "contrast" };
        public static InteractiveStyle default_ = new InteractiveStyle { Value = "default" };
        public static InteractiveStyle grey = new InteractiveStyle { Value = "grey" };
        public static InteractiveStyle halloween = new InteractiveStyle { Value = "halloween" };
        public static InteractiveStyle neon = new InteractiveStyle { Value = "neon" };
        public static InteractiveStyle none = new InteractiveStyle { Value = "none" };
        public static InteractiveStyle pastel = new InteractiveStyle { Value = "pastel" };
        public static InteractiveStyle primary = new InteractiveStyle { Value = "primary" };
        public static InteractiveStyle purple = new InteractiveStyle { Value = "purple" };
        public static InteractiveStyle quiet = new InteractiveStyle { Value = "quiet" };
    }
    #endregion
    #region RestMethod
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<RestMethod>))]
    public partial class RestMethod : Enumeration
    {
        public static RestMethod delete = new RestMethod { Value = "delete" };
        public static RestMethod get = new RestMethod { Value = "get" };
        public static RestMethod head = new RestMethod { Value = "head" };
        public static RestMethod options = new RestMethod { Value = "options" };
        public static RestMethod patch = new RestMethod { Value = "patch" };
        public static RestMethod post = new RestMethod { Value = "post" };
        public static RestMethod put = new RestMethod { Value = "put" };
    }
    #endregion
    #region AzureOutput
    /// <summary>
    ///   Used within <see cref="AzureTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AzureOutput>))]
    public partial class AzureOutput : Enumeration
    {
        public static AzureOutput json = new AzureOutput { Value = "json" };
        public static AzureOutput jsonc = new AzureOutput { Value = "jsonc" };
        public static AzureOutput table = new AzureOutput { Value = "table" };
        public static AzureOutput tsv = new AzureOutput { Value = "tsv" };
    }
    #endregion
}
