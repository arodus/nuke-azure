// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzurePolicy.json
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
    public static partial class AzurePolicyTasks
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public static string AzurePolicyPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREPOLICY_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzurePolicyLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage resource policies.
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicy(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzurePolicyPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzurePolicyLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicy(AzurePolicySettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicySettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicySettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicySettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicySettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicy(Configure<AzurePolicySettings> configurator)
        {
            return AzurePolicy(configurator(new AzurePolicySettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicySettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicySettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicySettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicySettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicy(CombinatorialConfigure<AzurePolicySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicy, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentCreate(AzurePolicyAssignmentCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyAssignmentCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--assign-identity</c> via <see cref="AzurePolicyAssignmentCreateSettings.AssignIdentity"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentCreateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzurePolicyAssignmentCreateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentCreateSettings.Help"/></li>
        ///     <li><c>--identity-scope</c> via <see cref="AzurePolicyAssignmentCreateSettings.IdentityScope"/></li>
        ///     <li><c>--location</c> via <see cref="AzurePolicyAssignmentCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyAssignmentCreateSettings.Name"/></li>
        ///     <li><c>--not-scopes</c> via <see cref="AzurePolicyAssignmentCreateSettings.NotScopes"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentCreateSettings.Output"/></li>
        ///     <li><c>--params</c> via <see cref="AzurePolicyAssignmentCreateSettings.Params"/></li>
        ///     <li><c>--policy</c> via <see cref="AzurePolicyAssignmentCreateSettings.Policy"/></li>
        ///     <li><c>--policy-set-definition</c> via <see cref="AzurePolicyAssignmentCreateSettings.PolicySetDefinition"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--role</c> via <see cref="AzurePolicyAssignmentCreateSettings.Role"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentCreateSettings.Scope"/></li>
        ///     <li><c>--sku</c> via <see cref="AzurePolicyAssignmentCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentCreate(Configure<AzurePolicyAssignmentCreateSettings> configurator)
        {
            return AzurePolicyAssignmentCreate(configurator(new AzurePolicyAssignmentCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--assign-identity</c> via <see cref="AzurePolicyAssignmentCreateSettings.AssignIdentity"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentCreateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzurePolicyAssignmentCreateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentCreateSettings.Help"/></li>
        ///     <li><c>--identity-scope</c> via <see cref="AzurePolicyAssignmentCreateSettings.IdentityScope"/></li>
        ///     <li><c>--location</c> via <see cref="AzurePolicyAssignmentCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyAssignmentCreateSettings.Name"/></li>
        ///     <li><c>--not-scopes</c> via <see cref="AzurePolicyAssignmentCreateSettings.NotScopes"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentCreateSettings.Output"/></li>
        ///     <li><c>--params</c> via <see cref="AzurePolicyAssignmentCreateSettings.Params"/></li>
        ///     <li><c>--policy</c> via <see cref="AzurePolicyAssignmentCreateSettings.Policy"/></li>
        ///     <li><c>--policy-set-definition</c> via <see cref="AzurePolicyAssignmentCreateSettings.PolicySetDefinition"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--role</c> via <see cref="AzurePolicyAssignmentCreateSettings.Role"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentCreateSettings.Scope"/></li>
        ///     <li><c>--sku</c> via <see cref="AzurePolicyAssignmentCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyAssignmentCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyAssignmentCreate(CombinatorialConfigure<AzurePolicyAssignmentCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyAssignmentCreate, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentDelete(AzurePolicyAssignmentDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyAssignmentDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentDelete(Configure<AzurePolicyAssignmentDeleteSettings> configurator)
        {
            return AzurePolicyAssignmentDelete(configurator(new AzurePolicyAssignmentDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyAssignmentDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyAssignmentDelete(CombinatorialConfigure<AzurePolicyAssignmentDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyAssignmentDelete, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentList(AzurePolicyAssignmentListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyAssignmentListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentListSettings.Debug"/></li>
        ///     <li><c>--disable-scope-strict-match</c> via <see cref="AzurePolicyAssignmentListSettings.DisableScopeStrictMatch"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentListSettings.ResourceGroup"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentListSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentList(Configure<AzurePolicyAssignmentListSettings> configurator)
        {
            return AzurePolicyAssignmentList(configurator(new AzurePolicyAssignmentListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentListSettings.Debug"/></li>
        ///     <li><c>--disable-scope-strict-match</c> via <see cref="AzurePolicyAssignmentListSettings.DisableScopeStrictMatch"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentListSettings.ResourceGroup"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentListSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyAssignmentListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyAssignmentList(CombinatorialConfigure<AzurePolicyAssignmentListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyAssignmentList, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentShow(AzurePolicyAssignmentShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyAssignmentShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyAssignmentShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentShowSettings.ResourceGroup"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentShowSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentShow(Configure<AzurePolicyAssignmentShowSettings> configurator)
        {
            return AzurePolicyAssignmentShow(configurator(new AzurePolicyAssignmentShowSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyAssignmentShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentShowSettings.ResourceGroup"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentShowSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyAssignmentShowSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyAssignmentShow(CombinatorialConfigure<AzurePolicyAssignmentShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyAssignmentShow, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyDefinitionCreate(AzurePolicyDefinitionCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyDefinitionCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyDefinitionCreateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzurePolicyDefinitionCreateSettings.Description"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzurePolicyDefinitionCreateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyDefinitionCreateSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyDefinitionCreateSettings.ManagementGroup"/></li>
        ///     <li><c>--metadata</c> via <see cref="AzurePolicyDefinitionCreateSettings.Metadata"/></li>
        ///     <li><c>--mode</c> via <see cref="AzurePolicyDefinitionCreateSettings.Mode"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyDefinitionCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyDefinitionCreateSettings.Output"/></li>
        ///     <li><c>--params</c> via <see cref="AzurePolicyDefinitionCreateSettings.Params"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyDefinitionCreateSettings.Query"/></li>
        ///     <li><c>--rules</c> via <see cref="AzurePolicyDefinitionCreateSettings.Rules"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyDefinitionCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyDefinitionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyDefinitionCreate(Configure<AzurePolicyDefinitionCreateSettings> configurator)
        {
            return AzurePolicyDefinitionCreate(configurator(new AzurePolicyDefinitionCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyDefinitionCreateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzurePolicyDefinitionCreateSettings.Description"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzurePolicyDefinitionCreateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyDefinitionCreateSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyDefinitionCreateSettings.ManagementGroup"/></li>
        ///     <li><c>--metadata</c> via <see cref="AzurePolicyDefinitionCreateSettings.Metadata"/></li>
        ///     <li><c>--mode</c> via <see cref="AzurePolicyDefinitionCreateSettings.Mode"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyDefinitionCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyDefinitionCreateSettings.Output"/></li>
        ///     <li><c>--params</c> via <see cref="AzurePolicyDefinitionCreateSettings.Params"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyDefinitionCreateSettings.Query"/></li>
        ///     <li><c>--rules</c> via <see cref="AzurePolicyDefinitionCreateSettings.Rules"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyDefinitionCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyDefinitionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyDefinitionCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyDefinitionCreate(CombinatorialConfigure<AzurePolicyDefinitionCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyDefinitionCreate, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyDefinitionDelete(AzurePolicyDefinitionDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyDefinitionDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyDefinitionDeleteSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyDefinitionDelete(Configure<AzurePolicyDefinitionDeleteSettings> configurator)
        {
            return AzurePolicyDefinitionDelete(configurator(new AzurePolicyDefinitionDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyDefinitionDeleteSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyDefinitionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyDefinitionDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyDefinitionDelete(CombinatorialConfigure<AzurePolicyDefinitionDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyDefinitionDelete, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyDefinitionList(AzurePolicyDefinitionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyDefinitionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyDefinitionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyDefinitionListSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyDefinitionListSettings.ManagementGroup"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyDefinitionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyDefinitionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyDefinitionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyDefinitionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyDefinitionList(Configure<AzurePolicyDefinitionListSettings> configurator)
        {
            return AzurePolicyDefinitionList(configurator(new AzurePolicyDefinitionListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyDefinitionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyDefinitionListSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyDefinitionListSettings.ManagementGroup"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyDefinitionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyDefinitionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyDefinitionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyDefinitionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyDefinitionListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyDefinitionList(CombinatorialConfigure<AzurePolicyDefinitionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyDefinitionList, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyDefinitionShow(AzurePolicyDefinitionShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyDefinitionShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyDefinitionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyDefinitionShowSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyDefinitionShowSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyDefinitionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyDefinitionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyDefinitionShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyDefinitionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyDefinitionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyDefinitionShow(Configure<AzurePolicyDefinitionShowSettings> configurator)
        {
            return AzurePolicyDefinitionShow(configurator(new AzurePolicyDefinitionShowSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyDefinitionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyDefinitionShowSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyDefinitionShowSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyDefinitionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyDefinitionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyDefinitionShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyDefinitionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyDefinitionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyDefinitionShowSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyDefinitionShow(CombinatorialConfigure<AzurePolicyDefinitionShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyDefinitionShow, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyDefinitionUpdate(AzurePolicyDefinitionUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyDefinitionUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Description"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzurePolicyDefinitionUpdateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyDefinitionUpdateSettings.ManagementGroup"/></li>
        ///     <li><c>--metadata</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Metadata"/></li>
        ///     <li><c>--mode</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Mode"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Output"/></li>
        ///     <li><c>--params</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Params"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Query"/></li>
        ///     <li><c>--rules</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Rules"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyDefinitionUpdate(Configure<AzurePolicyDefinitionUpdateSettings> configurator)
        {
            return AzurePolicyDefinitionUpdate(configurator(new AzurePolicyDefinitionUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Description"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzurePolicyDefinitionUpdateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyDefinitionUpdateSettings.ManagementGroup"/></li>
        ///     <li><c>--metadata</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Metadata"/></li>
        ///     <li><c>--mode</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Mode"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Output"/></li>
        ///     <li><c>--params</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Params"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Query"/></li>
        ///     <li><c>--rules</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Rules"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyDefinitionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyDefinitionUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyDefinitionUpdate(CombinatorialConfigure<AzurePolicyDefinitionUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyDefinitionUpdate, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyEventList(AzurePolicyEventListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyEventListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--apply</c> via <see cref="AzurePolicyEventListSettings.Apply"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyEventListSettings.Debug"/></li>
        ///     <li><c>--filter</c> via <see cref="AzurePolicyEventListSettings.Filter"/></li>
        ///     <li><c>--from</c> via <see cref="AzurePolicyEventListSettings.From"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyEventListSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyEventListSettings.ManagementGroup"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyEventListSettings.Namespace"/></li>
        ///     <li><c>--order-by</c> via <see cref="AzurePolicyEventListSettings.OrderBy"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyEventListSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyEventListSettings.Parent"/></li>
        ///     <li><c>--policy-assignment</c> via <see cref="AzurePolicyEventListSettings.PolicyAssignment"/></li>
        ///     <li><c>--policy-definition</c> via <see cref="AzurePolicyEventListSettings.PolicyDefinition"/></li>
        ///     <li><c>--policy-set-definition</c> via <see cref="AzurePolicyEventListSettings.PolicySetDefinition"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyEventListSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyEventListSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyEventListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyEventListSettings.ResourceType"/></li>
        ///     <li><c>--select</c> via <see cref="AzurePolicyEventListSettings.Select"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyEventListSettings.Subscription"/></li>
        ///     <li><c>--to</c> via <see cref="AzurePolicyEventListSettings.To"/></li>
        ///     <li><c>--top</c> via <see cref="AzurePolicyEventListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyEventListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyEventList(Configure<AzurePolicyEventListSettings> configurator)
        {
            return AzurePolicyEventList(configurator(new AzurePolicyEventListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--apply</c> via <see cref="AzurePolicyEventListSettings.Apply"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyEventListSettings.Debug"/></li>
        ///     <li><c>--filter</c> via <see cref="AzurePolicyEventListSettings.Filter"/></li>
        ///     <li><c>--from</c> via <see cref="AzurePolicyEventListSettings.From"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyEventListSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyEventListSettings.ManagementGroup"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyEventListSettings.Namespace"/></li>
        ///     <li><c>--order-by</c> via <see cref="AzurePolicyEventListSettings.OrderBy"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyEventListSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyEventListSettings.Parent"/></li>
        ///     <li><c>--policy-assignment</c> via <see cref="AzurePolicyEventListSettings.PolicyAssignment"/></li>
        ///     <li><c>--policy-definition</c> via <see cref="AzurePolicyEventListSettings.PolicyDefinition"/></li>
        ///     <li><c>--policy-set-definition</c> via <see cref="AzurePolicyEventListSettings.PolicySetDefinition"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyEventListSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyEventListSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyEventListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyEventListSettings.ResourceType"/></li>
        ///     <li><c>--select</c> via <see cref="AzurePolicyEventListSettings.Select"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyEventListSettings.Subscription"/></li>
        ///     <li><c>--to</c> via <see cref="AzurePolicyEventListSettings.To"/></li>
        ///     <li><c>--top</c> via <see cref="AzurePolicyEventListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyEventListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyEventListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyEventList(CombinatorialConfigure<AzurePolicyEventListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyEventList, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyRemediationCancel(AzurePolicyRemediationCancelSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyRemediationCancelSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyRemediationCancelSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyRemediationCancelSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyRemediationCancelSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyRemediationCancelSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyRemediationCancelSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyRemediationCancelSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyRemediationCancelSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyRemediationCancelSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyRemediationCancelSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyRemediationCancelSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyRemediationCancelSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyRemediationCancelSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyRemediationCancelSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyRemediationCancel(Configure<AzurePolicyRemediationCancelSettings> configurator)
        {
            return AzurePolicyRemediationCancel(configurator(new AzurePolicyRemediationCancelSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyRemediationCancelSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyRemediationCancelSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyRemediationCancelSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyRemediationCancelSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyRemediationCancelSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyRemediationCancelSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyRemediationCancelSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyRemediationCancelSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyRemediationCancelSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyRemediationCancelSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyRemediationCancelSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyRemediationCancelSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyRemediationCancelSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyRemediationCancelSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyRemediationCancel(CombinatorialConfigure<AzurePolicyRemediationCancelSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyRemediationCancel, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyRemediationCreate(AzurePolicyRemediationCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyRemediationCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyRemediationCreateSettings.Debug"/></li>
        ///     <li><c>--definition-reference-id</c> via <see cref="AzurePolicyRemediationCreateSettings.DefinitionReferenceId"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyRemediationCreateSettings.Help"/></li>
        ///     <li><c>--location-filters</c> via <see cref="AzurePolicyRemediationCreateSettings.LocationFilters"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyRemediationCreateSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyRemediationCreateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyRemediationCreateSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyRemediationCreateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyRemediationCreateSettings.Parent"/></li>
        ///     <li><c>--policy-assignment</c> via <see cref="AzurePolicyRemediationCreateSettings.PolicyAssignment"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyRemediationCreateSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyRemediationCreateSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyRemediationCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyRemediationCreateSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyRemediationCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyRemediationCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyRemediationCreate(Configure<AzurePolicyRemediationCreateSettings> configurator)
        {
            return AzurePolicyRemediationCreate(configurator(new AzurePolicyRemediationCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyRemediationCreateSettings.Debug"/></li>
        ///     <li><c>--definition-reference-id</c> via <see cref="AzurePolicyRemediationCreateSettings.DefinitionReferenceId"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyRemediationCreateSettings.Help"/></li>
        ///     <li><c>--location-filters</c> via <see cref="AzurePolicyRemediationCreateSettings.LocationFilters"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyRemediationCreateSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyRemediationCreateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyRemediationCreateSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyRemediationCreateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyRemediationCreateSettings.Parent"/></li>
        ///     <li><c>--policy-assignment</c> via <see cref="AzurePolicyRemediationCreateSettings.PolicyAssignment"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyRemediationCreateSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyRemediationCreateSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyRemediationCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyRemediationCreateSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyRemediationCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyRemediationCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyRemediationCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyRemediationCreate(CombinatorialConfigure<AzurePolicyRemediationCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyRemediationCreate, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyRemediationDelete(AzurePolicyRemediationDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyRemediationDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyRemediationDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyRemediationDeleteSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyRemediationDeleteSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyRemediationDeleteSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyRemediationDeleteSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyRemediationDeleteSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyRemediationDeleteSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyRemediationDeleteSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyRemediationDeleteSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyRemediationDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyRemediationDeleteSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyRemediationDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyRemediationDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyRemediationDelete(Configure<AzurePolicyRemediationDeleteSettings> configurator)
        {
            return AzurePolicyRemediationDelete(configurator(new AzurePolicyRemediationDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyRemediationDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyRemediationDeleteSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyRemediationDeleteSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyRemediationDeleteSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyRemediationDeleteSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyRemediationDeleteSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyRemediationDeleteSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyRemediationDeleteSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyRemediationDeleteSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyRemediationDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyRemediationDeleteSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyRemediationDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyRemediationDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyRemediationDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyRemediationDelete(CombinatorialConfigure<AzurePolicyRemediationDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyRemediationDelete, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyRemediationList(AzurePolicyRemediationListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyRemediationListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyRemediationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyRemediationListSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyRemediationListSettings.ManagementGroup"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyRemediationListSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyRemediationListSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyRemediationListSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyRemediationListSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyRemediationListSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyRemediationListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyRemediationListSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyRemediationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyRemediationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyRemediationList(Configure<AzurePolicyRemediationListSettings> configurator)
        {
            return AzurePolicyRemediationList(configurator(new AzurePolicyRemediationListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyRemediationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyRemediationListSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyRemediationListSettings.ManagementGroup"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyRemediationListSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyRemediationListSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyRemediationListSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyRemediationListSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyRemediationListSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyRemediationListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyRemediationListSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyRemediationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyRemediationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyRemediationListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyRemediationList(CombinatorialConfigure<AzurePolicyRemediationListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyRemediationList, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyRemediationShow(AzurePolicyRemediationShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyRemediationShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyRemediationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyRemediationShowSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyRemediationShowSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyRemediationShowSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyRemediationShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyRemediationShowSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyRemediationShowSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyRemediationShowSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyRemediationShowSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyRemediationShowSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyRemediationShowSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyRemediationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyRemediationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyRemediationShow(Configure<AzurePolicyRemediationShowSettings> configurator)
        {
            return AzurePolicyRemediationShow(configurator(new AzurePolicyRemediationShowSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyRemediationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyRemediationShowSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyRemediationShowSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyRemediationShowSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyRemediationShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyRemediationShowSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyRemediationShowSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyRemediationShowSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyRemediationShowSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyRemediationShowSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyRemediationShowSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyRemediationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyRemediationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyRemediationShowSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyRemediationShow(CombinatorialConfigure<AzurePolicyRemediationShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyRemediationShow, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicySetDefinitionCreate(AzurePolicySetDefinitionCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicySetDefinitionCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Debug"/></li>
        ///     <li><c>--definitions</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Definitions"/></li>
        ///     <li><c>--description</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Description"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzurePolicySetDefinitionCreateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicySetDefinitionCreateSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Output"/></li>
        ///     <li><c>--params</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Params"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicySetDefinitionCreate(Configure<AzurePolicySetDefinitionCreateSettings> configurator)
        {
            return AzurePolicySetDefinitionCreate(configurator(new AzurePolicySetDefinitionCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Debug"/></li>
        ///     <li><c>--definitions</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Definitions"/></li>
        ///     <li><c>--description</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Description"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzurePolicySetDefinitionCreateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicySetDefinitionCreateSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Output"/></li>
        ///     <li><c>--params</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Params"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicySetDefinitionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicySetDefinitionCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicySetDefinitionCreate(CombinatorialConfigure<AzurePolicySetDefinitionCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicySetDefinitionCreate, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicySetDefinitionDelete(AzurePolicySetDefinitionDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicySetDefinitionDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicySetDefinitionDelete(Configure<AzurePolicySetDefinitionDeleteSettings> configurator)
        {
            return AzurePolicySetDefinitionDelete(configurator(new AzurePolicySetDefinitionDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicySetDefinitionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicySetDefinitionDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicySetDefinitionDelete(CombinatorialConfigure<AzurePolicySetDefinitionDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicySetDefinitionDelete, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicySetDefinitionList(AzurePolicySetDefinitionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicySetDefinitionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicySetDefinitionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicySetDefinitionListSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicySetDefinitionListSettings.ManagementGroup"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicySetDefinitionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicySetDefinitionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicySetDefinitionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicySetDefinitionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicySetDefinitionList(Configure<AzurePolicySetDefinitionListSettings> configurator)
        {
            return AzurePolicySetDefinitionList(configurator(new AzurePolicySetDefinitionListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicySetDefinitionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicySetDefinitionListSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicySetDefinitionListSettings.ManagementGroup"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicySetDefinitionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicySetDefinitionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicySetDefinitionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicySetDefinitionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicySetDefinitionListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicySetDefinitionList(CombinatorialConfigure<AzurePolicySetDefinitionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicySetDefinitionList, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicySetDefinitionShow(AzurePolicySetDefinitionShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicySetDefinitionShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicySetDefinitionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicySetDefinitionShowSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicySetDefinitionShowSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicySetDefinitionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicySetDefinitionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicySetDefinitionShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicySetDefinitionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicySetDefinitionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicySetDefinitionShow(Configure<AzurePolicySetDefinitionShowSettings> configurator)
        {
            return AzurePolicySetDefinitionShow(configurator(new AzurePolicySetDefinitionShowSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicySetDefinitionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicySetDefinitionShowSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicySetDefinitionShowSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicySetDefinitionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicySetDefinitionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicySetDefinitionShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicySetDefinitionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicySetDefinitionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicySetDefinitionShowSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicySetDefinitionShow(CombinatorialConfigure<AzurePolicySetDefinitionShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicySetDefinitionShow, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicySetDefinitionUpdate(AzurePolicySetDefinitionUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicySetDefinitionUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Debug"/></li>
        ///     <li><c>--definitions</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Definitions"/></li>
        ///     <li><c>--description</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Description"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Output"/></li>
        ///     <li><c>--params</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Params"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicySetDefinitionUpdate(Configure<AzurePolicySetDefinitionUpdateSettings> configurator)
        {
            return AzurePolicySetDefinitionUpdate(configurator(new AzurePolicySetDefinitionUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Debug"/></li>
        ///     <li><c>--definitions</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Definitions"/></li>
        ///     <li><c>--description</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Description"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Output"/></li>
        ///     <li><c>--params</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Params"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicySetDefinitionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicySetDefinitionUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicySetDefinitionUpdate(CombinatorialConfigure<AzurePolicySetDefinitionUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicySetDefinitionUpdate, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyStateList(AzurePolicyStateListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyStateListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--all</c> via <see cref="AzurePolicyStateListSettings.All"/></li>
        ///     <li><c>--apply</c> via <see cref="AzurePolicyStateListSettings.Apply"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyStateListSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzurePolicyStateListSettings.Expand"/></li>
        ///     <li><c>--filter</c> via <see cref="AzurePolicyStateListSettings.Filter"/></li>
        ///     <li><c>--from</c> via <see cref="AzurePolicyStateListSettings.From"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyStateListSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyStateListSettings.ManagementGroup"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyStateListSettings.Namespace"/></li>
        ///     <li><c>--order-by</c> via <see cref="AzurePolicyStateListSettings.OrderBy"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyStateListSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyStateListSettings.Parent"/></li>
        ///     <li><c>--policy-assignment</c> via <see cref="AzurePolicyStateListSettings.PolicyAssignment"/></li>
        ///     <li><c>--policy-definition</c> via <see cref="AzurePolicyStateListSettings.PolicyDefinition"/></li>
        ///     <li><c>--policy-set-definition</c> via <see cref="AzurePolicyStateListSettings.PolicySetDefinition"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyStateListSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyStateListSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyStateListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyStateListSettings.ResourceType"/></li>
        ///     <li><c>--select</c> via <see cref="AzurePolicyStateListSettings.Select"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyStateListSettings.Subscription"/></li>
        ///     <li><c>--to</c> via <see cref="AzurePolicyStateListSettings.To"/></li>
        ///     <li><c>--top</c> via <see cref="AzurePolicyStateListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyStateListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyStateList(Configure<AzurePolicyStateListSettings> configurator)
        {
            return AzurePolicyStateList(configurator(new AzurePolicyStateListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--all</c> via <see cref="AzurePolicyStateListSettings.All"/></li>
        ///     <li><c>--apply</c> via <see cref="AzurePolicyStateListSettings.Apply"/></li>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyStateListSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzurePolicyStateListSettings.Expand"/></li>
        ///     <li><c>--filter</c> via <see cref="AzurePolicyStateListSettings.Filter"/></li>
        ///     <li><c>--from</c> via <see cref="AzurePolicyStateListSettings.From"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyStateListSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyStateListSettings.ManagementGroup"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyStateListSettings.Namespace"/></li>
        ///     <li><c>--order-by</c> via <see cref="AzurePolicyStateListSettings.OrderBy"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyStateListSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyStateListSettings.Parent"/></li>
        ///     <li><c>--policy-assignment</c> via <see cref="AzurePolicyStateListSettings.PolicyAssignment"/></li>
        ///     <li><c>--policy-definition</c> via <see cref="AzurePolicyStateListSettings.PolicyDefinition"/></li>
        ///     <li><c>--policy-set-definition</c> via <see cref="AzurePolicyStateListSettings.PolicySetDefinition"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyStateListSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyStateListSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyStateListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyStateListSettings.ResourceType"/></li>
        ///     <li><c>--select</c> via <see cref="AzurePolicyStateListSettings.Select"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyStateListSettings.Subscription"/></li>
        ///     <li><c>--to</c> via <see cref="AzurePolicyStateListSettings.To"/></li>
        ///     <li><c>--top</c> via <see cref="AzurePolicyStateListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyStateListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyStateListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyStateList(CombinatorialConfigure<AzurePolicyStateListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyStateList, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyStateSummarize(AzurePolicyStateSummarizeSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyStateSummarizeSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyStateSummarizeSettings.Debug"/></li>
        ///     <li><c>--filter</c> via <see cref="AzurePolicyStateSummarizeSettings.Filter"/></li>
        ///     <li><c>--from</c> via <see cref="AzurePolicyStateSummarizeSettings.From"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyStateSummarizeSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyStateSummarizeSettings.ManagementGroup"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyStateSummarizeSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyStateSummarizeSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyStateSummarizeSettings.Parent"/></li>
        ///     <li><c>--policy-assignment</c> via <see cref="AzurePolicyStateSummarizeSettings.PolicyAssignment"/></li>
        ///     <li><c>--policy-definition</c> via <see cref="AzurePolicyStateSummarizeSettings.PolicyDefinition"/></li>
        ///     <li><c>--policy-set-definition</c> via <see cref="AzurePolicyStateSummarizeSettings.PolicySetDefinition"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyStateSummarizeSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyStateSummarizeSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyStateSummarizeSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyStateSummarizeSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyStateSummarizeSettings.Subscription"/></li>
        ///     <li><c>--to</c> via <see cref="AzurePolicyStateSummarizeSettings.To"/></li>
        ///     <li><c>--top</c> via <see cref="AzurePolicyStateSummarizeSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyStateSummarizeSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyStateSummarize(Configure<AzurePolicyStateSummarizeSettings> configurator)
        {
            return AzurePolicyStateSummarize(configurator(new AzurePolicyStateSummarizeSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyStateSummarizeSettings.Debug"/></li>
        ///     <li><c>--filter</c> via <see cref="AzurePolicyStateSummarizeSettings.Filter"/></li>
        ///     <li><c>--from</c> via <see cref="AzurePolicyStateSummarizeSettings.From"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyStateSummarizeSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyStateSummarizeSettings.ManagementGroup"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyStateSummarizeSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyStateSummarizeSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyStateSummarizeSettings.Parent"/></li>
        ///     <li><c>--policy-assignment</c> via <see cref="AzurePolicyStateSummarizeSettings.PolicyAssignment"/></li>
        ///     <li><c>--policy-definition</c> via <see cref="AzurePolicyStateSummarizeSettings.PolicyDefinition"/></li>
        ///     <li><c>--policy-set-definition</c> via <see cref="AzurePolicyStateSummarizeSettings.PolicySetDefinition"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyStateSummarizeSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyStateSummarizeSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyStateSummarizeSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyStateSummarizeSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyStateSummarizeSettings.Subscription"/></li>
        ///     <li><c>--to</c> via <see cref="AzurePolicyStateSummarizeSettings.To"/></li>
        ///     <li><c>--top</c> via <see cref="AzurePolicyStateSummarizeSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyStateSummarizeSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyStateSummarizeSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyStateSummarize(CombinatorialConfigure<AzurePolicyStateSummarizeSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyStateSummarize, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentIdentityAssign(AzurePolicyAssignmentIdentityAssignSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyAssignmentIdentityAssignSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Help"/></li>
        ///     <li><c>--identity-scope</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.IdentityScope"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.ResourceGroup"/></li>
        ///     <li><c>--role</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Role"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentIdentityAssign(Configure<AzurePolicyAssignmentIdentityAssignSettings> configurator)
        {
            return AzurePolicyAssignmentIdentityAssign(configurator(new AzurePolicyAssignmentIdentityAssignSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Help"/></li>
        ///     <li><c>--identity-scope</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.IdentityScope"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.ResourceGroup"/></li>
        ///     <li><c>--role</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Role"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentIdentityAssignSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyAssignmentIdentityAssignSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyAssignmentIdentityAssign(CombinatorialConfigure<AzurePolicyAssignmentIdentityAssignSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyAssignmentIdentityAssign, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentIdentityRemove(AzurePolicyAssignmentIdentityRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyAssignmentIdentityRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentIdentityRemove(Configure<AzurePolicyAssignmentIdentityRemoveSettings> configurator)
        {
            return AzurePolicyAssignmentIdentityRemove(configurator(new AzurePolicyAssignmentIdentityRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyAssignmentIdentityRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyAssignmentIdentityRemove(CombinatorialConfigure<AzurePolicyAssignmentIdentityRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyAssignmentIdentityRemove, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentIdentityShow(AzurePolicyAssignmentIdentityShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyAssignmentIdentityShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.ResourceGroup"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyAssignmentIdentityShow(Configure<AzurePolicyAssignmentIdentityShowSettings> configurator)
        {
            return AzurePolicyAssignmentIdentityShow(configurator(new AzurePolicyAssignmentIdentityShowSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.ResourceGroup"/></li>
        ///     <li><c>--scope</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyAssignmentIdentityShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyAssignmentIdentityShowSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyAssignmentIdentityShow(CombinatorialConfigure<AzurePolicyAssignmentIdentityShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyAssignmentIdentityShow, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzurePolicyRemediationDeploymentList(AzurePolicyRemediationDeploymentListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzurePolicyRemediationDeploymentListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzurePolicyRemediationDeploymentList(Configure<AzurePolicyRemediationDeploymentListSettings> configurator)
        {
            return AzurePolicyRemediationDeploymentList(configurator(new AzurePolicyRemediationDeploymentListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource policies.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Help"/></li>
        ///     <li><c>--management-group</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.ManagementGroup"/></li>
        ///     <li><c>--name</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzurePolicyRemediationDeploymentListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzurePolicyRemediationDeploymentListSettings Settings, IReadOnlyCollection<Output> Output)> AzurePolicyRemediationDeploymentList(CombinatorialConfigure<AzurePolicyRemediationDeploymentListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzurePolicyRemediationDeploymentList, AzurePolicyLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzurePolicySettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicySettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
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
              .Add("policy")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePolicyAssignmentCreateSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyAssignmentCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Display name of the policy assignment.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Name of the new policy assignment.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Space-separated scopes where the policy assignment does not apply.
        /// </summary>
        public virtual IReadOnlyList<string> NotScopes => NotScopesInternal.AsReadOnly();
        internal List<string> NotScopesInternal { get; set; } = new List<string>();
        /// <summary>
        ///   JSON formatted string or a path to a file or uri with parameter values of the policy rule.
        /// </summary>
        public virtual string Params { get; internal set; }
        /// <summary>
        ///   Name or id of the policy definition.
        /// </summary>
        public virtual string Policy { get; internal set; }
        /// <summary>
        ///   Name or id of the policy set definition.
        /// </summary>
        public virtual string PolicySetDefinition { get; internal set; }
        /// <summary>
        ///   The resource group where the policy will be applied.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Scope to which this policy assignment applies.
        /// </summary>
        public virtual string Scope { get; internal set; }
        /// <summary>
        ///   Policy sku.
        /// </summary>
        public virtual PolicyAssignmentCreateSku Sku { get; internal set; }
        /// <summary>
        ///   Assigns a system assigned identity to the policy assignment.
        /// </summary>
        public virtual string AssignIdentity { get; internal set; }
        /// <summary>
        ///   Scope that the system assigned identity can access.
        /// </summary>
        public virtual string IdentityScope { get; internal set; }
        /// <summary>
        ///   Role name or id that will be assigned to the managed identity.
        /// </summary>
        public virtual string Role { get; internal set; }
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
              .Add("policy assignment create")
              .Add("--display-name {value}", DisplayName)
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--not-scopes {value}", NotScopes, separator: ' ')
              .Add("--params {value}", Params)
              .Add("--policy {value}", Policy)
              .Add("--policy-set-definition {value}", PolicySetDefinition)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--scope {value}", Scope)
              .Add("--sku {value}", Sku)
              .Add("--assign-identity {value}", AssignIdentity)
              .Add("--identity-scope {value}", IdentityScope)
              .Add("--role {value}", Role)
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
    #region AzurePolicyAssignmentDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyAssignmentDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Name of the policy assignment.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The resource group where the policy will be applied.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Scope to which this policy assignment applies.
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
              .Add("policy assignment delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzurePolicyAssignmentListSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyAssignmentListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Include policy assignments either inherited from parent scope or at child scope.
        /// </summary>
        public virtual string DisableScopeStrictMatch { get; internal set; }
        /// <summary>
        ///   The resource group where the policy will be applied.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Scope to which this policy assignment applies.
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
              .Add("policy assignment list")
              .Add("--disable-scope-strict-match {value}", DisableScopeStrictMatch)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzurePolicyAssignmentShowSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyAssignmentShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Name of the policy assignment.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The resource group where the policy will be applied.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Scope to which this policy assignment applies.
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
              .Add("policy assignment show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzurePolicyDefinitionCreateSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyDefinitionCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Name of the new policy definition.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Description of policy definition.
        /// </summary>
        public virtual string Description { get; internal set; }
        /// <summary>
        ///   Display name of policy definition.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   Name of the management group the new policy definition can be assigned in.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
        /// <summary>
        ///   Metadata in space-separated key=value pairs.
        /// </summary>
        public virtual IReadOnlyDictionary<string, object> Metadata => MetadataInternal.AsReadOnly();
        internal Dictionary<string, object> MetadataInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary>
        ///   Mode of the policy definition.
        /// </summary>
        public virtual PolicyDefinitionMode Mode { get; internal set; }
        /// <summary>
        ///   JSON formatted string or a path to a file or uri with parameter definitions.
        /// </summary>
        public virtual string Params { get; internal set; }
        /// <summary>
        ///   Policy rules in JSON format, or a path to a file containing JSON rules.
        /// </summary>
        public virtual string Rules { get; internal set; }
        /// <summary>
        ///   Name or id of the subscription the new policy definition can be assigned in.
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
              .Add("policy definition create")
              .Add("--name {value}", Name)
              .Add("--description {value}", Description)
              .Add("--display-name {value}", DisplayName)
              .Add("--management-group {value}", ManagementGroup)
              .Add("--metadata {value}", Metadata, "{key}={value}", separator: ' ')
              .Add("--mode {value}", Mode)
              .Add("--params {value}", Params)
              .Add("--rules {value}", Rules)
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
    #region AzurePolicyDefinitionDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyDefinitionDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   The policy definition name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the management group of the policy [set] definition.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
        /// <summary>
        ///   The subscription id of the policy [set] definition.
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
              .Add("policy definition delete")
              .Add("--name {value}", Name)
              .Add("--management-group {value}", ManagementGroup)
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
    #region AzurePolicyDefinitionListSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyDefinitionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   The name of the management group of the policy [set] definition.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
        /// <summary>
        ///   The subscription id of the policy [set] definition.
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
              .Add("policy definition list")
              .Add("--management-group {value}", ManagementGroup)
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
    #region AzurePolicyDefinitionShowSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyDefinitionShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   The policy definition name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the management group of the policy [set] definition.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
        /// <summary>
        ///   The subscription id of the policy [set] definition.
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
              .Add("policy definition show")
              .Add("--name {value}", Name)
              .Add("--management-group {value}", ManagementGroup)
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
    #region AzurePolicyDefinitionUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyDefinitionUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   The policy definition name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Description of policy definition.
        /// </summary>
        public virtual string Description { get; internal set; }
        /// <summary>
        ///   Display name of policy definition.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   The name of the management group of the policy [set] definition.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
        /// <summary>
        ///   Metadata in space-separated key=value pairs.
        /// </summary>
        public virtual IReadOnlyDictionary<string, object> Metadata => MetadataInternal.AsReadOnly();
        internal Dictionary<string, object> MetadataInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary>
        ///   Mode of the policy definition.
        /// </summary>
        public virtual PolicyDefinitionMode Mode { get; internal set; }
        /// <summary>
        ///   JSON formatted string or a path to a file or uri with parameter definitions.
        /// </summary>
        public virtual string Params { get; internal set; }
        /// <summary>
        ///   JSON formatted string or a path to a file with such content.
        /// </summary>
        public virtual string Rules { get; internal set; }
        /// <summary>
        ///   The subscription id of the policy [set] definition.
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
              .Add("policy definition update")
              .Add("--name {value}", Name)
              .Add("--description {value}", Description)
              .Add("--display-name {value}", DisplayName)
              .Add("--management-group {value}", ManagementGroup)
              .Add("--metadata {value}", Metadata, "{key}={value}", separator: ' ')
              .Add("--mode {value}", Mode)
              .Add("--params {value}", Params)
              .Add("--rules {value}", Rules)
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
    #region AzurePolicyEventListSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyEventListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Apply expression for aggregations using OData notation.
        /// </summary>
        public virtual string Apply { get; internal set; }
        /// <summary>
        ///   Filter expression using OData notation.
        /// </summary>
        public virtual string Filter { get; internal set; }
        /// <summary>
        ///   ISO 8601 formatted timestamp specifying the start time of the interval to query.
        /// </summary>
        public virtual string From { get; internal set; }
        /// <summary>
        ///   Ordering expression using OData notation.
        /// </summary>
        public virtual string OrderBy { get; internal set; }
        /// <summary>
        ///   Select expression using OData notation.
        /// </summary>
        public virtual string Select { get; internal set; }
        /// <summary>
        ///   ISO 8601 formatted timestamp specifying the end time of the interval to query.
        /// </summary>
        public virtual string To { get; internal set; }
        /// <summary>
        ///   Maximum number of records to return.
        /// </summary>
        public virtual int? Top { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: Microsoft.Provider).
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Resource type (Ex: resourceTypeC).
        /// </summary>
        public virtual string ResourceType { get; internal set; }
        /// <summary>
        ///   Name of management group.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
        /// <summary>
        ///   Name of policy assignment.
        /// </summary>
        public virtual string PolicyAssignment { get; internal set; }
        /// <summary>
        ///   Name of policy definition.
        /// </summary>
        public virtual string PolicyDefinition { get; internal set; }
        /// <summary>
        ///   Name of policy set definition.
        /// </summary>
        public virtual string PolicySetDefinition { get; internal set; }
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
              .Add("policy event list")
              .Add("--apply {value}", Apply)
              .Add("--filter {value}", Filter)
              .Add("--from {value}", From)
              .Add("--order-by {value}", OrderBy)
              .Add("--select {value}", Select)
              .Add("--to {value}", To)
              .Add("--top {value}", Top)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--management-group {value}", ManagementGroup)
              .Add("--policy-assignment {value}", PolicyAssignment)
              .Add("--policy-definition {value}", PolicyDefinition)
              .Add("--policy-set-definition {value}", PolicySetDefinition)
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
    #region AzurePolicyRemediationCancelSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyRemediationCancelSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Name of the remediation.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: Microsoft.Provider).
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Resource type (Ex: resourceTypeC).
        /// </summary>
        public virtual string ResourceType { get; internal set; }
        /// <summary>
        ///   Name of management group.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
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
              .Add("policy remediation cancel")
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--management-group {value}", ManagementGroup)
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
    #region AzurePolicyRemediationCreateSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyRemediationCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Name of the remediation.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name or resource ID of the policy assignment.
        /// </summary>
        public virtual string PolicyAssignment { get; internal set; }
        /// <summary>
        ///   Policy definition reference ID inside the policy set definition. Only required when the policy assignment is assigning a policy set definition.
        /// </summary>
        public virtual string DefinitionReferenceId { get; internal set; }
        /// <summary>
        ///   Space separated list of resource locations that should be remediated (Ex: centralus westeurope).
        /// </summary>
        public virtual IReadOnlyList<string> LocationFilters => LocationFiltersInternal.AsReadOnly();
        internal List<string> LocationFiltersInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Provider namespace (Ex: Microsoft.Provider).
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Resource type (Ex: resourceTypeC).
        /// </summary>
        public virtual string ResourceType { get; internal set; }
        /// <summary>
        ///   Name of management group.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
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
              .Add("policy remediation create")
              .Add("--name {value}", Name)
              .Add("--policy-assignment {value}", PolicyAssignment)
              .Add("--definition-reference-id {value}", DefinitionReferenceId)
              .Add("--location-filters {value}", LocationFilters, separator: ' ')
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--management-group {value}", ManagementGroup)
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
    #region AzurePolicyRemediationDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyRemediationDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Name of the remediation.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: Microsoft.Provider).
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Resource type (Ex: resourceTypeC).
        /// </summary>
        public virtual string ResourceType { get; internal set; }
        /// <summary>
        ///   Name of management group.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
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
              .Add("policy remediation delete")
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--management-group {value}", ManagementGroup)
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
    #region AzurePolicyRemediationListSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyRemediationListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Provider namespace (Ex: Microsoft.Provider).
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Resource type (Ex: resourceTypeC).
        /// </summary>
        public virtual string ResourceType { get; internal set; }
        /// <summary>
        ///   Name of management group.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
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
              .Add("policy remediation list")
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--management-group {value}", ManagementGroup)
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
    #region AzurePolicyRemediationShowSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyRemediationShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Name of the remediation.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: Microsoft.Provider).
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Resource type (Ex: resourceTypeC).
        /// </summary>
        public virtual string ResourceType { get; internal set; }
        /// <summary>
        ///   Name of management group.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
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
              .Add("policy remediation show")
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--management-group {value}", ManagementGroup)
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
    #region AzurePolicySetDefinitionCreateSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicySetDefinitionCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Policy definitions in JSON format, or a path to a file containing JSON rules.
        /// </summary>
        public virtual string Definitions { get; internal set; }
        /// <summary>
        ///   Name of the new policy set definition.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Description of policy set definition.
        /// </summary>
        public virtual string Description { get; internal set; }
        /// <summary>
        ///   Display name of policy set definition.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   Name of management group the new policy set definition can be assigned in.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
        /// <summary>
        ///   JSON formatted string or a path to a file or uri with parameter definitions.
        /// </summary>
        public virtual string Params { get; internal set; }
        /// <summary>
        ///   Name or id of the subscription the new policy set definition can be assigned in.
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
              .Add("policy set-definition create")
              .Add("--definitions {value}", Definitions)
              .Add("--name {value}", Name)
              .Add("--description {value}", Description)
              .Add("--display-name {value}", DisplayName)
              .Add("--management-group {value}", ManagementGroup)
              .Add("--params {value}", Params)
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
    #region AzurePolicySetDefinitionDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicySetDefinitionDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   The policy set definition name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the management group of the policy [set] definition.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
        /// <summary>
        ///   The subscription id of the policy [set] definition.
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
              .Add("policy set-definition delete")
              .Add("--name {value}", Name)
              .Add("--management-group {value}", ManagementGroup)
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
    #region AzurePolicySetDefinitionListSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicySetDefinitionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   The name of the management group of the policy [set] definition.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
        /// <summary>
        ///   The subscription id of the policy [set] definition.
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
              .Add("policy set-definition list")
              .Add("--management-group {value}", ManagementGroup)
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
    #region AzurePolicySetDefinitionShowSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicySetDefinitionShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   The policy set definition name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the management group of the policy [set] definition.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
        /// <summary>
        ///   The subscription id of the policy [set] definition.
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
              .Add("policy set-definition show")
              .Add("--name {value}", Name)
              .Add("--management-group {value}", ManagementGroup)
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
    #region AzurePolicySetDefinitionUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicySetDefinitionUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   The policy set definition name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   JSON formatted string or a path to a file or uri containing definitions.
        /// </summary>
        public virtual string Definitions { get; internal set; }
        /// <summary>
        ///   Description of policy set definition.
        /// </summary>
        public virtual string Description { get; internal set; }
        /// <summary>
        ///   Display name of policy set definition.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   The name of the management group of the policy [set] definition.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
        /// <summary>
        ///   JSON formatted string or a path to a file or uri with parameter definitions.
        /// </summary>
        public virtual string Params { get; internal set; }
        /// <summary>
        ///   The subscription id of the policy [set] definition.
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
              .Add("policy set-definition update")
              .Add("--name {value}", Name)
              .Add("--definitions {value}", Definitions)
              .Add("--description {value}", Description)
              .Add("--display-name {value}", DisplayName)
              .Add("--management-group {value}", ManagementGroup)
              .Add("--params {value}", Params)
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
    #region AzurePolicyStateListSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyStateListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Within the specified time interval, get all policy states instead of the latest only.
        /// </summary>
        public virtual string All { get; internal set; }
        /// <summary>
        ///   Apply expression for aggregations using OData notation.
        /// </summary>
        public virtual string Apply { get; internal set; }
        /// <summary>
        ///   Expand expression using OData notation.
        /// </summary>
        public virtual string Expand { get; internal set; }
        /// <summary>
        ///   Filter expression using OData notation.
        /// </summary>
        public virtual string Filter { get; internal set; }
        /// <summary>
        ///   ISO 8601 formatted timestamp specifying the start time of the interval to query.
        /// </summary>
        public virtual string From { get; internal set; }
        /// <summary>
        ///   Ordering expression using OData notation.
        /// </summary>
        public virtual string OrderBy { get; internal set; }
        /// <summary>
        ///   Select expression using OData notation.
        /// </summary>
        public virtual string Select { get; internal set; }
        /// <summary>
        ///   ISO 8601 formatted timestamp specifying the end time of the interval to query.
        /// </summary>
        public virtual string To { get; internal set; }
        /// <summary>
        ///   Maximum number of records to return.
        /// </summary>
        public virtual int? Top { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: Microsoft.Provider).
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Resource type (Ex: resourceTypeC).
        /// </summary>
        public virtual string ResourceType { get; internal set; }
        /// <summary>
        ///   Name of management group.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
        /// <summary>
        ///   Name of policy assignment.
        /// </summary>
        public virtual string PolicyAssignment { get; internal set; }
        /// <summary>
        ///   Name of policy definition.
        /// </summary>
        public virtual string PolicyDefinition { get; internal set; }
        /// <summary>
        ///   Name of policy set definition.
        /// </summary>
        public virtual string PolicySetDefinition { get; internal set; }
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
              .Add("policy state list")
              .Add("--all {value}", All)
              .Add("--apply {value}", Apply)
              .Add("--expand {value}", Expand)
              .Add("--filter {value}", Filter)
              .Add("--from {value}", From)
              .Add("--order-by {value}", OrderBy)
              .Add("--select {value}", Select)
              .Add("--to {value}", To)
              .Add("--top {value}", Top)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--management-group {value}", ManagementGroup)
              .Add("--policy-assignment {value}", PolicyAssignment)
              .Add("--policy-definition {value}", PolicyDefinition)
              .Add("--policy-set-definition {value}", PolicySetDefinition)
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
    #region AzurePolicyStateSummarizeSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyStateSummarizeSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Filter expression using OData notation.
        /// </summary>
        public virtual string Filter { get; internal set; }
        /// <summary>
        ///   ISO 8601 formatted timestamp specifying the start time of the interval to query.
        /// </summary>
        public virtual string From { get; internal set; }
        /// <summary>
        ///   ISO 8601 formatted timestamp specifying the end time of the interval to query.
        /// </summary>
        public virtual string To { get; internal set; }
        /// <summary>
        ///   Maximum number of records to return.
        /// </summary>
        public virtual int? Top { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: Microsoft.Provider).
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Resource type (Ex: resourceTypeC).
        /// </summary>
        public virtual string ResourceType { get; internal set; }
        /// <summary>
        ///   Name of management group.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
        /// <summary>
        ///   Name of policy assignment.
        /// </summary>
        public virtual string PolicyAssignment { get; internal set; }
        /// <summary>
        ///   Name of policy definition.
        /// </summary>
        public virtual string PolicyDefinition { get; internal set; }
        /// <summary>
        ///   Name of policy set definition.
        /// </summary>
        public virtual string PolicySetDefinition { get; internal set; }
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
              .Add("policy state summarize")
              .Add("--filter {value}", Filter)
              .Add("--from {value}", From)
              .Add("--to {value}", To)
              .Add("--top {value}", Top)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--management-group {value}", ManagementGroup)
              .Add("--policy-assignment {value}", PolicyAssignment)
              .Add("--policy-definition {value}", PolicyDefinition)
              .Add("--policy-set-definition {value}", PolicySetDefinition)
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
    #region AzurePolicyAssignmentIdentityAssignSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyAssignmentIdentityAssignSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Name of the policy assignment.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Scope that the system assigned identity can access.
        /// </summary>
        public virtual string IdentityScope { get; internal set; }
        /// <summary>
        ///   The resource group where the policy will be applied.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Role name or id that will be assigned to the managed identity.
        /// </summary>
        public virtual string Role { get; internal set; }
        /// <summary>
        ///   Scope to which this policy assignment applies.
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
              .Add("policy assignment identity assign")
              .Add("--name {value}", Name)
              .Add("--identity-scope {value}", IdentityScope)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--role {value}", Role)
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
    #region AzurePolicyAssignmentIdentityRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyAssignmentIdentityRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Name of the policy assignment.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The resource group where the policy will be applied.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Scope to which this policy assignment applies.
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
              .Add("policy assignment identity remove")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzurePolicyAssignmentIdentityShowSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyAssignmentIdentityShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Name of the policy assignment.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The resource group where the policy will be applied.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Scope to which this policy assignment applies.
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
              .Add("policy assignment identity show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzurePolicyRemediationDeploymentListSettings
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyRemediationDeploymentListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzurePolicy executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        public override Action<OutputType, string> CustomLogger => AzurePolicyTasks.AzurePolicyLogger;
        /// <summary>
        ///   Name of the remediation.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: Microsoft.Provider).
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Resource type (Ex: resourceTypeC).
        /// </summary>
        public virtual string ResourceType { get; internal set; }
        /// <summary>
        ///   Name of management group.
        /// </summary>
        public virtual string ManagementGroup { get; internal set; }
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
              .Add("policy remediation deployment list")
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--management-group {value}", ManagementGroup)
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
    #region AzurePolicySettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicySettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySettings SetDebug(this AzurePolicySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySettings ResetDebug(this AzurePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySettings SetHelp(this AzurePolicySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySettings ResetHelp(this AzurePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySettings SetOutput(this AzurePolicySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySettings ResetOutput(this AzurePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySettings SetQuery(this AzurePolicySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySettings ResetQuery(this AzurePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySettings SetVerbose(this AzurePolicySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySettings ResetVerbose(this AzurePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyAssignmentCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyAssignmentCreateSettingsExtensions
    {
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.DisplayName"/></em></p>
        ///   <p>Display name of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetDisplayName(this AzurePolicyAssignmentCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.DisplayName"/></em></p>
        ///   <p>Display name of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetDisplayName(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetLocation(this AzurePolicyAssignmentCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetLocation(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Name"/></em></p>
        ///   <p>Name of the new policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetName(this AzurePolicyAssignmentCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Name"/></em></p>
        ///   <p>Name of the new policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetName(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NotScopes
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.NotScopes"/> to a new list</em></p>
        ///   <p>Space-separated scopes where the policy assignment does not apply.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetNotScopes(this AzurePolicyAssignmentCreateSettings toolSettings, params string[] notScopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotScopesInternal = notScopes.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.NotScopes"/> to a new list</em></p>
        ///   <p>Space-separated scopes where the policy assignment does not apply.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetNotScopes(this AzurePolicyAssignmentCreateSettings toolSettings, IEnumerable<string> notScopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotScopesInternal = notScopes.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePolicyAssignmentCreateSettings.NotScopes"/></em></p>
        ///   <p>Space-separated scopes where the policy assignment does not apply.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings AddNotScopes(this AzurePolicyAssignmentCreateSettings toolSettings, params string[] notScopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotScopesInternal.AddRange(notScopes);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePolicyAssignmentCreateSettings.NotScopes"/></em></p>
        ///   <p>Space-separated scopes where the policy assignment does not apply.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings AddNotScopes(this AzurePolicyAssignmentCreateSettings toolSettings, IEnumerable<string> notScopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotScopesInternal.AddRange(notScopes);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePolicyAssignmentCreateSettings.NotScopes"/></em></p>
        ///   <p>Space-separated scopes where the policy assignment does not apply.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ClearNotScopes(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotScopesInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePolicyAssignmentCreateSettings.NotScopes"/></em></p>
        ///   <p>Space-separated scopes where the policy assignment does not apply.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings RemoveNotScopes(this AzurePolicyAssignmentCreateSettings toolSettings, params string[] notScopes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(notScopes);
            toolSettings.NotScopesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePolicyAssignmentCreateSettings.NotScopes"/></em></p>
        ///   <p>Space-separated scopes where the policy assignment does not apply.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings RemoveNotScopes(this AzurePolicyAssignmentCreateSettings toolSettings, IEnumerable<string> notScopes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(notScopes);
            toolSettings.NotScopesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Params
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Params"/></em></p>
        ///   <p>JSON formatted string or a path to a file or uri with parameter values of the policy rule.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetParams(this AzurePolicyAssignmentCreateSettings toolSettings, string @params)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = @params;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Params"/></em></p>
        ///   <p>JSON formatted string or a path to a file or uri with parameter values of the policy rule.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetParams(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = null;
            return toolSettings;
        }
        #endregion
        #region Policy
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Policy"/></em></p>
        ///   <p>Name or id of the policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetPolicy(this AzurePolicyAssignmentCreateSettings toolSettings, string policy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Policy = policy;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Policy"/></em></p>
        ///   <p>Name or id of the policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetPolicy(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Policy = null;
            return toolSettings;
        }
        #endregion
        #region PolicySetDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.PolicySetDefinition"/></em></p>
        ///   <p>Name or id of the policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetPolicySetDefinition(this AzurePolicyAssignmentCreateSettings toolSettings, string policySetDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicySetDefinition = policySetDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.PolicySetDefinition"/></em></p>
        ///   <p>Name or id of the policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetPolicySetDefinition(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicySetDefinition = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetResourceGroup(this AzurePolicyAssignmentCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetResourceGroup(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetScope(this AzurePolicyAssignmentCreateSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetScope(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Sku"/></em></p>
        ///   <p>Policy sku.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetSku(this AzurePolicyAssignmentCreateSettings toolSettings, PolicyAssignmentCreateSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Sku"/></em></p>
        ///   <p>Policy sku.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetSku(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region AssignIdentity
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.AssignIdentity"/></em></p>
        ///   <p>Assigns a system assigned identity to the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetAssignIdentity(this AzurePolicyAssignmentCreateSettings toolSettings, string assignIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignIdentity = assignIdentity;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.AssignIdentity"/></em></p>
        ///   <p>Assigns a system assigned identity to the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetAssignIdentity(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignIdentity = null;
            return toolSettings;
        }
        #endregion
        #region IdentityScope
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.IdentityScope"/></em></p>
        ///   <p>Scope that the system assigned identity can access.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetIdentityScope(this AzurePolicyAssignmentCreateSettings toolSettings, string identityScope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentityScope = identityScope;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.IdentityScope"/></em></p>
        ///   <p>Scope that the system assigned identity can access.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetIdentityScope(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentityScope = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Role"/></em></p>
        ///   <p>Role name or id that will be assigned to the managed identity.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetRole(this AzurePolicyAssignmentCreateSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Role"/></em></p>
        ///   <p>Role name or id that will be assigned to the managed identity.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetRole(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetSubscription(this AzurePolicyAssignmentCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetSubscription(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetDebug(this AzurePolicyAssignmentCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetDebug(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetHelp(this AzurePolicyAssignmentCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetHelp(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetOutput(this AzurePolicyAssignmentCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetOutput(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetQuery(this AzurePolicyAssignmentCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetQuery(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetVerbose(this AzurePolicyAssignmentCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetVerbose(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyAssignmentDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyAssignmentDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Name"/></em></p>
        ///   <p>Name of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetName(this AzurePolicyAssignmentDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Name"/></em></p>
        ///   <p>Name of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetName(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetResourceGroup(this AzurePolicyAssignmentDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetResourceGroup(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetScope(this AzurePolicyAssignmentDeleteSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetScope(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetSubscription(this AzurePolicyAssignmentDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetSubscription(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetDebug(this AzurePolicyAssignmentDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetDebug(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetHelp(this AzurePolicyAssignmentDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetHelp(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetOutput(this AzurePolicyAssignmentDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetOutput(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetQuery(this AzurePolicyAssignmentDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetQuery(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetVerbose(this AzurePolicyAssignmentDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetVerbose(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyAssignmentListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyAssignmentListSettingsExtensions
    {
        #region DisableScopeStrictMatch
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentListSettings.DisableScopeStrictMatch"/></em></p>
        ///   <p>Include policy assignments either inherited from parent scope or at child scope.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetDisableScopeStrictMatch(this AzurePolicyAssignmentListSettings toolSettings, string disableScopeStrictMatch)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableScopeStrictMatch = disableScopeStrictMatch;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentListSettings.DisableScopeStrictMatch"/></em></p>
        ///   <p>Include policy assignments either inherited from parent scope or at child scope.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetDisableScopeStrictMatch(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableScopeStrictMatch = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentListSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetResourceGroup(this AzurePolicyAssignmentListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentListSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetResourceGroup(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentListSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetScope(this AzurePolicyAssignmentListSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentListSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetScope(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetSubscription(this AzurePolicyAssignmentListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetSubscription(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetDebug(this AzurePolicyAssignmentListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetDebug(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetHelp(this AzurePolicyAssignmentListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetHelp(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetOutput(this AzurePolicyAssignmentListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetOutput(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetQuery(this AzurePolicyAssignmentListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetQuery(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetVerbose(this AzurePolicyAssignmentListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetVerbose(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyAssignmentShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyAssignmentShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Name"/></em></p>
        ///   <p>Name of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetName(this AzurePolicyAssignmentShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Name"/></em></p>
        ///   <p>Name of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetName(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetResourceGroup(this AzurePolicyAssignmentShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetResourceGroup(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetScope(this AzurePolicyAssignmentShowSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetScope(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetSubscription(this AzurePolicyAssignmentShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetSubscription(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetDebug(this AzurePolicyAssignmentShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetDebug(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetHelp(this AzurePolicyAssignmentShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetHelp(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetOutput(this AzurePolicyAssignmentShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetOutput(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetQuery(this AzurePolicyAssignmentShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetQuery(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetVerbose(this AzurePolicyAssignmentShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetVerbose(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyDefinitionCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyDefinitionCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Name"/></em></p>
        ///   <p>Name of the new policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetName(this AzurePolicyDefinitionCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Name"/></em></p>
        ///   <p>Name of the new policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetName(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Description"/></em></p>
        ///   <p>Description of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetDescription(this AzurePolicyDefinitionCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Description"/></em></p>
        ///   <p>Description of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetDescription(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.DisplayName"/></em></p>
        ///   <p>Display name of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetDisplayName(this AzurePolicyDefinitionCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.DisplayName"/></em></p>
        ///   <p>Display name of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetDisplayName(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.ManagementGroup"/></em></p>
        ///   <p>Name of the management group the new policy definition can be assigned in.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetManagementGroup(this AzurePolicyDefinitionCreateSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.ManagementGroup"/></em></p>
        ///   <p>Name of the management group the new policy definition can be assigned in.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetManagementGroup(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region Metadata
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Metadata"/> to a new dictionary</em></p>
        ///   <p>Metadata in space-separated key=value pairs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetMetadata(this AzurePolicyDefinitionCreateSettings toolSettings, IDictionary<string, object> metadata)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal = metadata.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePolicyDefinitionCreateSettings.Metadata"/></em></p>
        ///   <p>Metadata in space-separated key=value pairs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ClearMetadata(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds a new key-value-pair <see cref="AzurePolicyDefinitionCreateSettings.Metadata"/></em></p>
        ///   <p>Metadata in space-separated key=value pairs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings AddMetadatum(this AzurePolicyDefinitionCreateSettings toolSettings, string metadatumKey, object metadatumValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal.Add(metadatumKey, metadatumValue);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes a key-value-pair from <see cref="AzurePolicyDefinitionCreateSettings.Metadata"/></em></p>
        ///   <p>Metadata in space-separated key=value pairs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings RemoveMetadatum(this AzurePolicyDefinitionCreateSettings toolSettings, string metadatumKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal.Remove(metadatumKey);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets a key-value-pair in <see cref="AzurePolicyDefinitionCreateSettings.Metadata"/></em></p>
        ///   <p>Metadata in space-separated key=value pairs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetMetadatum(this AzurePolicyDefinitionCreateSettings toolSettings, string metadatumKey, object metadatumValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal[metadatumKey] = metadatumValue;
            return toolSettings;
        }
        #endregion
        #region Mode
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Mode"/></em></p>
        ///   <p>Mode of the policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetMode(this AzurePolicyDefinitionCreateSettings toolSettings, PolicyDefinitionMode mode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = mode;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Mode"/></em></p>
        ///   <p>Mode of the policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetMode(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = null;
            return toolSettings;
        }
        #endregion
        #region Params
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Params"/></em></p>
        ///   <p>JSON formatted string or a path to a file or uri with parameter definitions.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetParams(this AzurePolicyDefinitionCreateSettings toolSettings, string @params)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = @params;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Params"/></em></p>
        ///   <p>JSON formatted string or a path to a file or uri with parameter definitions.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetParams(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = null;
            return toolSettings;
        }
        #endregion
        #region Rules
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Rules"/></em></p>
        ///   <p>Policy rules in JSON format, or a path to a file containing JSON rules.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetRules(this AzurePolicyDefinitionCreateSettings toolSettings, string rules)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Rules = rules;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Rules"/></em></p>
        ///   <p>Policy rules in JSON format, or a path to a file containing JSON rules.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetRules(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Rules = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or id of the subscription the new policy definition can be assigned in.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetSubscription(this AzurePolicyDefinitionCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or id of the subscription the new policy definition can be assigned in.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetSubscription(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetDebug(this AzurePolicyDefinitionCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetDebug(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetHelp(this AzurePolicyDefinitionCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetHelp(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetOutput(this AzurePolicyDefinitionCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetOutput(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetQuery(this AzurePolicyDefinitionCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetQuery(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetVerbose(this AzurePolicyDefinitionCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetVerbose(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyDefinitionDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyDefinitionDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.Name"/></em></p>
        ///   <p>The policy definition name.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetName(this AzurePolicyDefinitionDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.Name"/></em></p>
        ///   <p>The policy definition name.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetName(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetManagementGroup(this AzurePolicyDefinitionDeleteSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetManagementGroup(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetSubscription(this AzurePolicyDefinitionDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetSubscription(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetDebug(this AzurePolicyDefinitionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetDebug(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetHelp(this AzurePolicyDefinitionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetHelp(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetOutput(this AzurePolicyDefinitionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetOutput(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetQuery(this AzurePolicyDefinitionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetQuery(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetVerbose(this AzurePolicyDefinitionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetVerbose(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyDefinitionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyDefinitionListSettingsExtensions
    {
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionListSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings SetManagementGroup(this AzurePolicyDefinitionListSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionListSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings ResetManagementGroup(this AzurePolicyDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionListSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings SetSubscription(this AzurePolicyDefinitionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionListSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings ResetSubscription(this AzurePolicyDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings SetDebug(this AzurePolicyDefinitionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings ResetDebug(this AzurePolicyDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings SetHelp(this AzurePolicyDefinitionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings ResetHelp(this AzurePolicyDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings SetOutput(this AzurePolicyDefinitionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings ResetOutput(this AzurePolicyDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings SetQuery(this AzurePolicyDefinitionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings ResetQuery(this AzurePolicyDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings SetVerbose(this AzurePolicyDefinitionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings ResetVerbose(this AzurePolicyDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyDefinitionShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyDefinitionShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.Name"/></em></p>
        ///   <p>The policy definition name.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetName(this AzurePolicyDefinitionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.Name"/></em></p>
        ///   <p>The policy definition name.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetName(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetManagementGroup(this AzurePolicyDefinitionShowSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetManagementGroup(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetSubscription(this AzurePolicyDefinitionShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetSubscription(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetDebug(this AzurePolicyDefinitionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetDebug(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetHelp(this AzurePolicyDefinitionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetHelp(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetOutput(this AzurePolicyDefinitionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetOutput(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetQuery(this AzurePolicyDefinitionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetQuery(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetVerbose(this AzurePolicyDefinitionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetVerbose(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyDefinitionUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyDefinitionUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Name"/></em></p>
        ///   <p>The policy definition name.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetName(this AzurePolicyDefinitionUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Name"/></em></p>
        ///   <p>The policy definition name.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetName(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Description"/></em></p>
        ///   <p>Description of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetDescription(this AzurePolicyDefinitionUpdateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Description"/></em></p>
        ///   <p>Description of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetDescription(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.DisplayName"/></em></p>
        ///   <p>Display name of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetDisplayName(this AzurePolicyDefinitionUpdateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.DisplayName"/></em></p>
        ///   <p>Display name of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetDisplayName(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetManagementGroup(this AzurePolicyDefinitionUpdateSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetManagementGroup(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region Metadata
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Metadata"/> to a new dictionary</em></p>
        ///   <p>Metadata in space-separated key=value pairs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetMetadata(this AzurePolicyDefinitionUpdateSettings toolSettings, IDictionary<string, object> metadata)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal = metadata.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePolicyDefinitionUpdateSettings.Metadata"/></em></p>
        ///   <p>Metadata in space-separated key=value pairs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ClearMetadata(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds a new key-value-pair <see cref="AzurePolicyDefinitionUpdateSettings.Metadata"/></em></p>
        ///   <p>Metadata in space-separated key=value pairs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings AddMetadatum(this AzurePolicyDefinitionUpdateSettings toolSettings, string metadatumKey, object metadatumValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal.Add(metadatumKey, metadatumValue);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes a key-value-pair from <see cref="AzurePolicyDefinitionUpdateSettings.Metadata"/></em></p>
        ///   <p>Metadata in space-separated key=value pairs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings RemoveMetadatum(this AzurePolicyDefinitionUpdateSettings toolSettings, string metadatumKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal.Remove(metadatumKey);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets a key-value-pair in <see cref="AzurePolicyDefinitionUpdateSettings.Metadata"/></em></p>
        ///   <p>Metadata in space-separated key=value pairs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetMetadatum(this AzurePolicyDefinitionUpdateSettings toolSettings, string metadatumKey, object metadatumValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal[metadatumKey] = metadatumValue;
            return toolSettings;
        }
        #endregion
        #region Mode
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Mode"/></em></p>
        ///   <p>Mode of the policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetMode(this AzurePolicyDefinitionUpdateSettings toolSettings, PolicyDefinitionMode mode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = mode;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Mode"/></em></p>
        ///   <p>Mode of the policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetMode(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = null;
            return toolSettings;
        }
        #endregion
        #region Params
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Params"/></em></p>
        ///   <p>JSON formatted string or a path to a file or uri with parameter definitions.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetParams(this AzurePolicyDefinitionUpdateSettings toolSettings, string @params)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = @params;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Params"/></em></p>
        ///   <p>JSON formatted string or a path to a file or uri with parameter definitions.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetParams(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = null;
            return toolSettings;
        }
        #endregion
        #region Rules
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Rules"/></em></p>
        ///   <p>JSON formatted string or a path to a file with such content.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetRules(this AzurePolicyDefinitionUpdateSettings toolSettings, string rules)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Rules = rules;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Rules"/></em></p>
        ///   <p>JSON formatted string or a path to a file with such content.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetRules(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Rules = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetSubscription(this AzurePolicyDefinitionUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetSubscription(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetDebug(this AzurePolicyDefinitionUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetDebug(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetHelp(this AzurePolicyDefinitionUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetHelp(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetOutput(this AzurePolicyDefinitionUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetOutput(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetQuery(this AzurePolicyDefinitionUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetQuery(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetVerbose(this AzurePolicyDefinitionUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetVerbose(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyEventListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyEventListSettingsExtensions
    {
        #region Apply
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.Apply"/></em></p>
        ///   <p>Apply expression for aggregations using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetApply(this AzurePolicyEventListSettings toolSettings, string apply)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Apply = apply;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.Apply"/></em></p>
        ///   <p>Apply expression for aggregations using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetApply(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Apply = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.Filter"/></em></p>
        ///   <p>Filter expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetFilter(this AzurePolicyEventListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.Filter"/></em></p>
        ///   <p>Filter expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetFilter(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region From
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.From"/></em></p>
        ///   <p>ISO 8601 formatted timestamp specifying the start time of the interval to query.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetFrom(this AzurePolicyEventListSettings toolSettings, string from)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.From = from;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.From"/></em></p>
        ///   <p>ISO 8601 formatted timestamp specifying the start time of the interval to query.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetFrom(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.From = null;
            return toolSettings;
        }
        #endregion
        #region OrderBy
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.OrderBy"/></em></p>
        ///   <p>Ordering expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetOrderBy(this AzurePolicyEventListSettings toolSettings, string orderBy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderBy = orderBy;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.OrderBy"/></em></p>
        ///   <p>Ordering expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetOrderBy(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderBy = null;
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.Select"/></em></p>
        ///   <p>Select expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetSelect(this AzurePolicyEventListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.Select"/></em></p>
        ///   <p>Select expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetSelect(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region To
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.To"/></em></p>
        ///   <p>ISO 8601 formatted timestamp specifying the end time of the interval to query.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetTo(this AzurePolicyEventListSettings toolSettings, string to)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.To = to;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.To"/></em></p>
        ///   <p>ISO 8601 formatted timestamp specifying the end time of the interval to query.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetTo(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.To = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.Top"/></em></p>
        ///   <p>Maximum number of records to return.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetTop(this AzurePolicyEventListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.Top"/></em></p>
        ///   <p>Maximum number of records to return.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetTop(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetNamespace(this AzurePolicyEventListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetNamespace(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetParent(this AzurePolicyEventListSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetParent(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetResource(this AzurePolicyEventListSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetResource(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetResourceType(this AzurePolicyEventListSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetResourceType(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetManagementGroup(this AzurePolicyEventListSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetManagementGroup(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region PolicyAssignment
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.PolicyAssignment"/></em></p>
        ///   <p>Name of policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetPolicyAssignment(this AzurePolicyEventListSettings toolSettings, string policyAssignment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyAssignment = policyAssignment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.PolicyAssignment"/></em></p>
        ///   <p>Name of policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetPolicyAssignment(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyAssignment = null;
            return toolSettings;
        }
        #endregion
        #region PolicyDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.PolicyDefinition"/></em></p>
        ///   <p>Name of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetPolicyDefinition(this AzurePolicyEventListSettings toolSettings, string policyDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyDefinition = policyDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.PolicyDefinition"/></em></p>
        ///   <p>Name of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetPolicyDefinition(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyDefinition = null;
            return toolSettings;
        }
        #endregion
        #region PolicySetDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.PolicySetDefinition"/></em></p>
        ///   <p>Name of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetPolicySetDefinition(this AzurePolicyEventListSettings toolSettings, string policySetDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicySetDefinition = policySetDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.PolicySetDefinition"/></em></p>
        ///   <p>Name of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetPolicySetDefinition(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicySetDefinition = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetResourceGroup(this AzurePolicyEventListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetResourceGroup(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetSubscription(this AzurePolicyEventListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetSubscription(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetDebug(this AzurePolicyEventListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetDebug(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetHelp(this AzurePolicyEventListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetHelp(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetOutput(this AzurePolicyEventListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetOutput(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetQuery(this AzurePolicyEventListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetQuery(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyEventListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings SetVerbose(this AzurePolicyEventListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyEventListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyEventListSettings ResetVerbose(this AzurePolicyEventListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyRemediationCancelSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyRemediationCancelSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCancelSettings.Name"/></em></p>
        ///   <p>Name of the remediation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings SetName(this AzurePolicyRemediationCancelSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCancelSettings.Name"/></em></p>
        ///   <p>Name of the remediation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings ResetName(this AzurePolicyRemediationCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCancelSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings SetNamespace(this AzurePolicyRemediationCancelSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCancelSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings ResetNamespace(this AzurePolicyRemediationCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCancelSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings SetParent(this AzurePolicyRemediationCancelSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCancelSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings ResetParent(this AzurePolicyRemediationCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCancelSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings SetResource(this AzurePolicyRemediationCancelSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCancelSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings ResetResource(this AzurePolicyRemediationCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCancelSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings SetResourceType(this AzurePolicyRemediationCancelSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCancelSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings ResetResourceType(this AzurePolicyRemediationCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCancelSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings SetManagementGroup(this AzurePolicyRemediationCancelSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCancelSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings ResetManagementGroup(this AzurePolicyRemediationCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCancelSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings SetResourceGroup(this AzurePolicyRemediationCancelSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCancelSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings ResetResourceGroup(this AzurePolicyRemediationCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCancelSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings SetSubscription(this AzurePolicyRemediationCancelSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCancelSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings ResetSubscription(this AzurePolicyRemediationCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCancelSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings SetDebug(this AzurePolicyRemediationCancelSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCancelSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings ResetDebug(this AzurePolicyRemediationCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCancelSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings SetHelp(this AzurePolicyRemediationCancelSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCancelSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings ResetHelp(this AzurePolicyRemediationCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCancelSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings SetOutput(this AzurePolicyRemediationCancelSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCancelSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings ResetOutput(this AzurePolicyRemediationCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCancelSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings SetQuery(this AzurePolicyRemediationCancelSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCancelSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings ResetQuery(this AzurePolicyRemediationCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCancelSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings SetVerbose(this AzurePolicyRemediationCancelSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCancelSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCancelSettings ResetVerbose(this AzurePolicyRemediationCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyRemediationCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyRemediationCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.Name"/></em></p>
        ///   <p>Name of the remediation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetName(this AzurePolicyRemediationCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.Name"/></em></p>
        ///   <p>Name of the remediation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetName(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PolicyAssignment
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.PolicyAssignment"/></em></p>
        ///   <p>Name or resource ID of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetPolicyAssignment(this AzurePolicyRemediationCreateSettings toolSettings, string policyAssignment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyAssignment = policyAssignment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.PolicyAssignment"/></em></p>
        ///   <p>Name or resource ID of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetPolicyAssignment(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyAssignment = null;
            return toolSettings;
        }
        #endregion
        #region DefinitionReferenceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.DefinitionReferenceId"/></em></p>
        ///   <p>Policy definition reference ID inside the policy set definition. Only required when the policy assignment is assigning a policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetDefinitionReferenceId(this AzurePolicyRemediationCreateSettings toolSettings, string definitionReferenceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefinitionReferenceId = definitionReferenceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.DefinitionReferenceId"/></em></p>
        ///   <p>Policy definition reference ID inside the policy set definition. Only required when the policy assignment is assigning a policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetDefinitionReferenceId(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefinitionReferenceId = null;
            return toolSettings;
        }
        #endregion
        #region LocationFilters
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.LocationFilters"/> to a new list</em></p>
        ///   <p>Space separated list of resource locations that should be remediated (Ex: centralus westeurope).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetLocationFilters(this AzurePolicyRemediationCreateSettings toolSettings, params string[] locationFilters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LocationFiltersInternal = locationFilters.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.LocationFilters"/> to a new list</em></p>
        ///   <p>Space separated list of resource locations that should be remediated (Ex: centralus westeurope).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetLocationFilters(this AzurePolicyRemediationCreateSettings toolSettings, IEnumerable<string> locationFilters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LocationFiltersInternal = locationFilters.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePolicyRemediationCreateSettings.LocationFilters"/></em></p>
        ///   <p>Space separated list of resource locations that should be remediated (Ex: centralus westeurope).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings AddLocationFilters(this AzurePolicyRemediationCreateSettings toolSettings, params string[] locationFilters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LocationFiltersInternal.AddRange(locationFilters);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzurePolicyRemediationCreateSettings.LocationFilters"/></em></p>
        ///   <p>Space separated list of resource locations that should be remediated (Ex: centralus westeurope).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings AddLocationFilters(this AzurePolicyRemediationCreateSettings toolSettings, IEnumerable<string> locationFilters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LocationFiltersInternal.AddRange(locationFilters);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzurePolicyRemediationCreateSettings.LocationFilters"/></em></p>
        ///   <p>Space separated list of resource locations that should be remediated (Ex: centralus westeurope).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ClearLocationFilters(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LocationFiltersInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePolicyRemediationCreateSettings.LocationFilters"/></em></p>
        ///   <p>Space separated list of resource locations that should be remediated (Ex: centralus westeurope).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings RemoveLocationFilters(this AzurePolicyRemediationCreateSettings toolSettings, params string[] locationFilters)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(locationFilters);
            toolSettings.LocationFiltersInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzurePolicyRemediationCreateSettings.LocationFilters"/></em></p>
        ///   <p>Space separated list of resource locations that should be remediated (Ex: centralus westeurope).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings RemoveLocationFilters(this AzurePolicyRemediationCreateSettings toolSettings, IEnumerable<string> locationFilters)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(locationFilters);
            toolSettings.LocationFiltersInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetNamespace(this AzurePolicyRemediationCreateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetNamespace(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetParent(this AzurePolicyRemediationCreateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetParent(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetResource(this AzurePolicyRemediationCreateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetResource(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetResourceType(this AzurePolicyRemediationCreateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetResourceType(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetManagementGroup(this AzurePolicyRemediationCreateSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetManagementGroup(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetResourceGroup(this AzurePolicyRemediationCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetResourceGroup(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetSubscription(this AzurePolicyRemediationCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetSubscription(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetDebug(this AzurePolicyRemediationCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetDebug(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetHelp(this AzurePolicyRemediationCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetHelp(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetOutput(this AzurePolicyRemediationCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetOutput(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetQuery(this AzurePolicyRemediationCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetQuery(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings SetVerbose(this AzurePolicyRemediationCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationCreateSettings ResetVerbose(this AzurePolicyRemediationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyRemediationDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyRemediationDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeleteSettings.Name"/></em></p>
        ///   <p>Name of the remediation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings SetName(this AzurePolicyRemediationDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeleteSettings.Name"/></em></p>
        ///   <p>Name of the remediation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings ResetName(this AzurePolicyRemediationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeleteSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings SetNamespace(this AzurePolicyRemediationDeleteSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeleteSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings ResetNamespace(this AzurePolicyRemediationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeleteSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings SetParent(this AzurePolicyRemediationDeleteSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeleteSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings ResetParent(this AzurePolicyRemediationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeleteSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings SetResource(this AzurePolicyRemediationDeleteSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeleteSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings ResetResource(this AzurePolicyRemediationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeleteSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings SetResourceType(this AzurePolicyRemediationDeleteSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeleteSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings ResetResourceType(this AzurePolicyRemediationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeleteSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings SetManagementGroup(this AzurePolicyRemediationDeleteSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeleteSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings ResetManagementGroup(this AzurePolicyRemediationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings SetResourceGroup(this AzurePolicyRemediationDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings ResetResourceGroup(this AzurePolicyRemediationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings SetSubscription(this AzurePolicyRemediationDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings ResetSubscription(this AzurePolicyRemediationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings SetDebug(this AzurePolicyRemediationDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings ResetDebug(this AzurePolicyRemediationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings SetHelp(this AzurePolicyRemediationDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings ResetHelp(this AzurePolicyRemediationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings SetOutput(this AzurePolicyRemediationDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings ResetOutput(this AzurePolicyRemediationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings SetQuery(this AzurePolicyRemediationDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings ResetQuery(this AzurePolicyRemediationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings SetVerbose(this AzurePolicyRemediationDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeleteSettings ResetVerbose(this AzurePolicyRemediationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyRemediationListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyRemediationListSettingsExtensions
    {
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings SetNamespace(this AzurePolicyRemediationListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings ResetNamespace(this AzurePolicyRemediationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationListSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings SetParent(this AzurePolicyRemediationListSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationListSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings ResetParent(this AzurePolicyRemediationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationListSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings SetResource(this AzurePolicyRemediationListSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationListSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings ResetResource(this AzurePolicyRemediationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationListSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings SetResourceType(this AzurePolicyRemediationListSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationListSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings ResetResourceType(this AzurePolicyRemediationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationListSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings SetManagementGroup(this AzurePolicyRemediationListSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationListSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings ResetManagementGroup(this AzurePolicyRemediationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings SetResourceGroup(this AzurePolicyRemediationListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings ResetResourceGroup(this AzurePolicyRemediationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings SetSubscription(this AzurePolicyRemediationListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings ResetSubscription(this AzurePolicyRemediationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings SetDebug(this AzurePolicyRemediationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings ResetDebug(this AzurePolicyRemediationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings SetHelp(this AzurePolicyRemediationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings ResetHelp(this AzurePolicyRemediationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings SetOutput(this AzurePolicyRemediationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings ResetOutput(this AzurePolicyRemediationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings SetQuery(this AzurePolicyRemediationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings ResetQuery(this AzurePolicyRemediationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings SetVerbose(this AzurePolicyRemediationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationListSettings ResetVerbose(this AzurePolicyRemediationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyRemediationShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyRemediationShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationShowSettings.Name"/></em></p>
        ///   <p>Name of the remediation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings SetName(this AzurePolicyRemediationShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationShowSettings.Name"/></em></p>
        ///   <p>Name of the remediation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings ResetName(this AzurePolicyRemediationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationShowSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings SetNamespace(this AzurePolicyRemediationShowSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationShowSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings ResetNamespace(this AzurePolicyRemediationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationShowSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings SetParent(this AzurePolicyRemediationShowSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationShowSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings ResetParent(this AzurePolicyRemediationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationShowSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings SetResource(this AzurePolicyRemediationShowSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationShowSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings ResetResource(this AzurePolicyRemediationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationShowSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings SetResourceType(this AzurePolicyRemediationShowSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationShowSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings ResetResourceType(this AzurePolicyRemediationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationShowSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings SetManagementGroup(this AzurePolicyRemediationShowSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationShowSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings ResetManagementGroup(this AzurePolicyRemediationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings SetResourceGroup(this AzurePolicyRemediationShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings ResetResourceGroup(this AzurePolicyRemediationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings SetSubscription(this AzurePolicyRemediationShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings ResetSubscription(this AzurePolicyRemediationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings SetDebug(this AzurePolicyRemediationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings ResetDebug(this AzurePolicyRemediationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings SetHelp(this AzurePolicyRemediationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings ResetHelp(this AzurePolicyRemediationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings SetOutput(this AzurePolicyRemediationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings ResetOutput(this AzurePolicyRemediationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings SetQuery(this AzurePolicyRemediationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings ResetQuery(this AzurePolicyRemediationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings SetVerbose(this AzurePolicyRemediationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationShowSettings ResetVerbose(this AzurePolicyRemediationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicySetDefinitionCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicySetDefinitionCreateSettingsExtensions
    {
        #region Definitions
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Definitions"/></em></p>
        ///   <p>Policy definitions in JSON format, or a path to a file containing JSON rules.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetDefinitions(this AzurePolicySetDefinitionCreateSettings toolSettings, string definitions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definitions = definitions;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Definitions"/></em></p>
        ///   <p>Policy definitions in JSON format, or a path to a file containing JSON rules.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetDefinitions(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definitions = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Name"/></em></p>
        ///   <p>Name of the new policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetName(this AzurePolicySetDefinitionCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Name"/></em></p>
        ///   <p>Name of the new policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetName(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Description"/></em></p>
        ///   <p>Description of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetDescription(this AzurePolicySetDefinitionCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Description"/></em></p>
        ///   <p>Description of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetDescription(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.DisplayName"/></em></p>
        ///   <p>Display name of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetDisplayName(this AzurePolicySetDefinitionCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.DisplayName"/></em></p>
        ///   <p>Display name of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetDisplayName(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group the new policy set definition can be assigned in.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetManagementGroup(this AzurePolicySetDefinitionCreateSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group the new policy set definition can be assigned in.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetManagementGroup(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region Params
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Params"/></em></p>
        ///   <p>JSON formatted string or a path to a file or uri with parameter definitions.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetParams(this AzurePolicySetDefinitionCreateSettings toolSettings, string @params)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = @params;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Params"/></em></p>
        ///   <p>JSON formatted string or a path to a file or uri with parameter definitions.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetParams(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or id of the subscription the new policy set definition can be assigned in.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetSubscription(this AzurePolicySetDefinitionCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or id of the subscription the new policy set definition can be assigned in.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetSubscription(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetDebug(this AzurePolicySetDefinitionCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetDebug(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetHelp(this AzurePolicySetDefinitionCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetHelp(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetOutput(this AzurePolicySetDefinitionCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetOutput(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetQuery(this AzurePolicySetDefinitionCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetQuery(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetVerbose(this AzurePolicySetDefinitionCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetVerbose(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicySetDefinitionDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicySetDefinitionDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.Name"/></em></p>
        ///   <p>The policy set definition name.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetName(this AzurePolicySetDefinitionDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.Name"/></em></p>
        ///   <p>The policy set definition name.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetName(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetManagementGroup(this AzurePolicySetDefinitionDeleteSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetManagementGroup(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetSubscription(this AzurePolicySetDefinitionDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetSubscription(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetDebug(this AzurePolicySetDefinitionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetDebug(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetHelp(this AzurePolicySetDefinitionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetHelp(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetOutput(this AzurePolicySetDefinitionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetOutput(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetQuery(this AzurePolicySetDefinitionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetQuery(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetVerbose(this AzurePolicySetDefinitionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetVerbose(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicySetDefinitionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicySetDefinitionListSettingsExtensions
    {
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionListSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings SetManagementGroup(this AzurePolicySetDefinitionListSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionListSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings ResetManagementGroup(this AzurePolicySetDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionListSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings SetSubscription(this AzurePolicySetDefinitionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionListSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings ResetSubscription(this AzurePolicySetDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings SetDebug(this AzurePolicySetDefinitionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings ResetDebug(this AzurePolicySetDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings SetHelp(this AzurePolicySetDefinitionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings ResetHelp(this AzurePolicySetDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings SetOutput(this AzurePolicySetDefinitionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings ResetOutput(this AzurePolicySetDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings SetQuery(this AzurePolicySetDefinitionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings ResetQuery(this AzurePolicySetDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings SetVerbose(this AzurePolicySetDefinitionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings ResetVerbose(this AzurePolicySetDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicySetDefinitionShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicySetDefinitionShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.Name"/></em></p>
        ///   <p>The policy set definition name.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetName(this AzurePolicySetDefinitionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.Name"/></em></p>
        ///   <p>The policy set definition name.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetName(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetManagementGroup(this AzurePolicySetDefinitionShowSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetManagementGroup(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetSubscription(this AzurePolicySetDefinitionShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetSubscription(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetDebug(this AzurePolicySetDefinitionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetDebug(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetHelp(this AzurePolicySetDefinitionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetHelp(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetOutput(this AzurePolicySetDefinitionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetOutput(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetQuery(this AzurePolicySetDefinitionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetQuery(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetVerbose(this AzurePolicySetDefinitionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetVerbose(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicySetDefinitionUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicySetDefinitionUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Name"/></em></p>
        ///   <p>The policy set definition name.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetName(this AzurePolicySetDefinitionUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Name"/></em></p>
        ///   <p>The policy set definition name.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetName(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Definitions
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Definitions"/></em></p>
        ///   <p>JSON formatted string or a path to a file or uri containing definitions.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetDefinitions(this AzurePolicySetDefinitionUpdateSettings toolSettings, string definitions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definitions = definitions;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Definitions"/></em></p>
        ///   <p>JSON formatted string or a path to a file or uri containing definitions.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetDefinitions(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definitions = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Description"/></em></p>
        ///   <p>Description of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetDescription(this AzurePolicySetDefinitionUpdateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Description"/></em></p>
        ///   <p>Description of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetDescription(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.DisplayName"/></em></p>
        ///   <p>Display name of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetDisplayName(this AzurePolicySetDefinitionUpdateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.DisplayName"/></em></p>
        ///   <p>Display name of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetDisplayName(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetManagementGroup(this AzurePolicySetDefinitionUpdateSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.ManagementGroup"/></em></p>
        ///   <p>The name of the management group of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetManagementGroup(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region Params
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Params"/></em></p>
        ///   <p>JSON formatted string or a path to a file or uri with parameter definitions.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetParams(this AzurePolicySetDefinitionUpdateSettings toolSettings, string @params)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = @params;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Params"/></em></p>
        ///   <p>JSON formatted string or a path to a file or uri with parameter definitions.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetParams(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetSubscription(this AzurePolicySetDefinitionUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Subscription"/></em></p>
        ///   <p>The subscription id of the policy [set] definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetSubscription(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetDebug(this AzurePolicySetDefinitionUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetDebug(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetHelp(this AzurePolicySetDefinitionUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetHelp(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetOutput(this AzurePolicySetDefinitionUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetOutput(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetQuery(this AzurePolicySetDefinitionUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetQuery(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetVerbose(this AzurePolicySetDefinitionUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetVerbose(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyStateListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyStateListSettingsExtensions
    {
        #region All
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.All"/></em></p>
        ///   <p>Within the specified time interval, get all policy states instead of the latest only.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetAll(this AzurePolicyStateListSettings toolSettings, string all)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = all;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.All"/></em></p>
        ///   <p>Within the specified time interval, get all policy states instead of the latest only.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetAll(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = null;
            return toolSettings;
        }
        #endregion
        #region Apply
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Apply"/></em></p>
        ///   <p>Apply expression for aggregations using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetApply(this AzurePolicyStateListSettings toolSettings, string apply)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Apply = apply;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Apply"/></em></p>
        ///   <p>Apply expression for aggregations using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetApply(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Apply = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Expand"/></em></p>
        ///   <p>Expand expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetExpand(this AzurePolicyStateListSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Expand"/></em></p>
        ///   <p>Expand expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetExpand(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Filter"/></em></p>
        ///   <p>Filter expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetFilter(this AzurePolicyStateListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Filter"/></em></p>
        ///   <p>Filter expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetFilter(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region From
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.From"/></em></p>
        ///   <p>ISO 8601 formatted timestamp specifying the start time of the interval to query.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetFrom(this AzurePolicyStateListSettings toolSettings, string from)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.From = from;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.From"/></em></p>
        ///   <p>ISO 8601 formatted timestamp specifying the start time of the interval to query.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetFrom(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.From = null;
            return toolSettings;
        }
        #endregion
        #region OrderBy
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.OrderBy"/></em></p>
        ///   <p>Ordering expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetOrderBy(this AzurePolicyStateListSettings toolSettings, string orderBy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderBy = orderBy;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.OrderBy"/></em></p>
        ///   <p>Ordering expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetOrderBy(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderBy = null;
            return toolSettings;
        }
        #endregion
        #region Select
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Select"/></em></p>
        ///   <p>Select expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetSelect(this AzurePolicyStateListSettings toolSettings, string select)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = select;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Select"/></em></p>
        ///   <p>Select expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetSelect(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Select = null;
            return toolSettings;
        }
        #endregion
        #region To
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.To"/></em></p>
        ///   <p>ISO 8601 formatted timestamp specifying the end time of the interval to query.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetTo(this AzurePolicyStateListSettings toolSettings, string to)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.To = to;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.To"/></em></p>
        ///   <p>ISO 8601 formatted timestamp specifying the end time of the interval to query.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetTo(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.To = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Top"/></em></p>
        ///   <p>Maximum number of records to return.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetTop(this AzurePolicyStateListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Top"/></em></p>
        ///   <p>Maximum number of records to return.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetTop(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetNamespace(this AzurePolicyStateListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetNamespace(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetParent(this AzurePolicyStateListSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetParent(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetResource(this AzurePolicyStateListSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetResource(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetResourceType(this AzurePolicyStateListSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetResourceType(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetManagementGroup(this AzurePolicyStateListSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetManagementGroup(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region PolicyAssignment
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.PolicyAssignment"/></em></p>
        ///   <p>Name of policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetPolicyAssignment(this AzurePolicyStateListSettings toolSettings, string policyAssignment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyAssignment = policyAssignment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.PolicyAssignment"/></em></p>
        ///   <p>Name of policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetPolicyAssignment(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyAssignment = null;
            return toolSettings;
        }
        #endregion
        #region PolicyDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.PolicyDefinition"/></em></p>
        ///   <p>Name of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetPolicyDefinition(this AzurePolicyStateListSettings toolSettings, string policyDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyDefinition = policyDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.PolicyDefinition"/></em></p>
        ///   <p>Name of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetPolicyDefinition(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyDefinition = null;
            return toolSettings;
        }
        #endregion
        #region PolicySetDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.PolicySetDefinition"/></em></p>
        ///   <p>Name of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetPolicySetDefinition(this AzurePolicyStateListSettings toolSettings, string policySetDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicySetDefinition = policySetDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.PolicySetDefinition"/></em></p>
        ///   <p>Name of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetPolicySetDefinition(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicySetDefinition = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetResourceGroup(this AzurePolicyStateListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetResourceGroup(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetSubscription(this AzurePolicyStateListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetSubscription(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetDebug(this AzurePolicyStateListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetDebug(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetHelp(this AzurePolicyStateListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetHelp(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetOutput(this AzurePolicyStateListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetOutput(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetQuery(this AzurePolicyStateListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetQuery(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings SetVerbose(this AzurePolicyStateListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateListSettings ResetVerbose(this AzurePolicyStateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyStateSummarizeSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyStateSummarizeSettingsExtensions
    {
        #region Filter
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.Filter"/></em></p>
        ///   <p>Filter expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetFilter(this AzurePolicyStateSummarizeSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.Filter"/></em></p>
        ///   <p>Filter expression using OData notation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetFilter(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region From
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.From"/></em></p>
        ///   <p>ISO 8601 formatted timestamp specifying the start time of the interval to query.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetFrom(this AzurePolicyStateSummarizeSettings toolSettings, string from)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.From = from;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.From"/></em></p>
        ///   <p>ISO 8601 formatted timestamp specifying the start time of the interval to query.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetFrom(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.From = null;
            return toolSettings;
        }
        #endregion
        #region To
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.To"/></em></p>
        ///   <p>ISO 8601 formatted timestamp specifying the end time of the interval to query.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetTo(this AzurePolicyStateSummarizeSettings toolSettings, string to)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.To = to;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.To"/></em></p>
        ///   <p>ISO 8601 formatted timestamp specifying the end time of the interval to query.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetTo(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.To = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.Top"/></em></p>
        ///   <p>Maximum number of records to return.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetTop(this AzurePolicyStateSummarizeSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.Top"/></em></p>
        ///   <p>Maximum number of records to return.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetTop(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetNamespace(this AzurePolicyStateSummarizeSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetNamespace(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetParent(this AzurePolicyStateSummarizeSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetParent(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetResource(this AzurePolicyStateSummarizeSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetResource(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetResourceType(this AzurePolicyStateSummarizeSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetResourceType(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetManagementGroup(this AzurePolicyStateSummarizeSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetManagementGroup(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region PolicyAssignment
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.PolicyAssignment"/></em></p>
        ///   <p>Name of policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetPolicyAssignment(this AzurePolicyStateSummarizeSettings toolSettings, string policyAssignment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyAssignment = policyAssignment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.PolicyAssignment"/></em></p>
        ///   <p>Name of policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetPolicyAssignment(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyAssignment = null;
            return toolSettings;
        }
        #endregion
        #region PolicyDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.PolicyDefinition"/></em></p>
        ///   <p>Name of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetPolicyDefinition(this AzurePolicyStateSummarizeSettings toolSettings, string policyDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyDefinition = policyDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.PolicyDefinition"/></em></p>
        ///   <p>Name of policy definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetPolicyDefinition(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicyDefinition = null;
            return toolSettings;
        }
        #endregion
        #region PolicySetDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.PolicySetDefinition"/></em></p>
        ///   <p>Name of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetPolicySetDefinition(this AzurePolicyStateSummarizeSettings toolSettings, string policySetDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicySetDefinition = policySetDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.PolicySetDefinition"/></em></p>
        ///   <p>Name of policy set definition.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetPolicySetDefinition(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicySetDefinition = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetResourceGroup(this AzurePolicyStateSummarizeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetResourceGroup(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetSubscription(this AzurePolicyStateSummarizeSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetSubscription(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetDebug(this AzurePolicyStateSummarizeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetDebug(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetHelp(this AzurePolicyStateSummarizeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetHelp(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetOutput(this AzurePolicyStateSummarizeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetOutput(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetQuery(this AzurePolicyStateSummarizeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetQuery(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyStateSummarizeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings SetVerbose(this AzurePolicyStateSummarizeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyStateSummarizeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyStateSummarizeSettings ResetVerbose(this AzurePolicyStateSummarizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyAssignmentIdentityAssignSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyAssignmentIdentityAssignSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Name"/></em></p>
        ///   <p>Name of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings SetName(this AzurePolicyAssignmentIdentityAssignSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Name"/></em></p>
        ///   <p>Name of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings ResetName(this AzurePolicyAssignmentIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region IdentityScope
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityAssignSettings.IdentityScope"/></em></p>
        ///   <p>Scope that the system assigned identity can access.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings SetIdentityScope(this AzurePolicyAssignmentIdentityAssignSettings toolSettings, string identityScope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentityScope = identityScope;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityAssignSettings.IdentityScope"/></em></p>
        ///   <p>Scope that the system assigned identity can access.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings ResetIdentityScope(this AzurePolicyAssignmentIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentityScope = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityAssignSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings SetResourceGroup(this AzurePolicyAssignmentIdentityAssignSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityAssignSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings ResetResourceGroup(this AzurePolicyAssignmentIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Role"/></em></p>
        ///   <p>Role name or id that will be assigned to the managed identity.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings SetRole(this AzurePolicyAssignmentIdentityAssignSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Role"/></em></p>
        ///   <p>Role name or id that will be assigned to the managed identity.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings ResetRole(this AzurePolicyAssignmentIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings SetScope(this AzurePolicyAssignmentIdentityAssignSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings ResetScope(this AzurePolicyAssignmentIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings SetSubscription(this AzurePolicyAssignmentIdentityAssignSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings ResetSubscription(this AzurePolicyAssignmentIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings SetDebug(this AzurePolicyAssignmentIdentityAssignSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings ResetDebug(this AzurePolicyAssignmentIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings SetHelp(this AzurePolicyAssignmentIdentityAssignSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings ResetHelp(this AzurePolicyAssignmentIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings SetOutput(this AzurePolicyAssignmentIdentityAssignSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings ResetOutput(this AzurePolicyAssignmentIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings SetQuery(this AzurePolicyAssignmentIdentityAssignSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings ResetQuery(this AzurePolicyAssignmentIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings SetVerbose(this AzurePolicyAssignmentIdentityAssignSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityAssignSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityAssignSettings ResetVerbose(this AzurePolicyAssignmentIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyAssignmentIdentityRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyAssignmentIdentityRemoveSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Name"/></em></p>
        ///   <p>Name of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings SetName(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Name"/></em></p>
        ///   <p>Name of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings ResetName(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings SetResourceGroup(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings ResetResourceGroup(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings SetScope(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings ResetScope(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings SetSubscription(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings ResetSubscription(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings SetDebug(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings ResetDebug(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings SetHelp(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings ResetHelp(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings SetOutput(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings ResetOutput(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings SetQuery(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings ResetQuery(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings SetVerbose(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityRemoveSettings ResetVerbose(this AzurePolicyAssignmentIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyAssignmentIdentityShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyAssignmentIdentityShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityShowSettings.Name"/></em></p>
        ///   <p>Name of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings SetName(this AzurePolicyAssignmentIdentityShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityShowSettings.Name"/></em></p>
        ///   <p>Name of the policy assignment.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings ResetName(this AzurePolicyAssignmentIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityShowSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings SetResourceGroup(this AzurePolicyAssignmentIdentityShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityShowSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group where the policy will be applied.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings ResetResourceGroup(this AzurePolicyAssignmentIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityShowSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings SetScope(this AzurePolicyAssignmentIdentityShowSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityShowSettings.Scope"/></em></p>
        ///   <p>Scope to which this policy assignment applies.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings ResetScope(this AzurePolicyAssignmentIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings SetSubscription(this AzurePolicyAssignmentIdentityShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings ResetSubscription(this AzurePolicyAssignmentIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings SetDebug(this AzurePolicyAssignmentIdentityShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings ResetDebug(this AzurePolicyAssignmentIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings SetHelp(this AzurePolicyAssignmentIdentityShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings ResetHelp(this AzurePolicyAssignmentIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings SetOutput(this AzurePolicyAssignmentIdentityShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings ResetOutput(this AzurePolicyAssignmentIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings SetQuery(this AzurePolicyAssignmentIdentityShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings ResetQuery(this AzurePolicyAssignmentIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyAssignmentIdentityShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings SetVerbose(this AzurePolicyAssignmentIdentityShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyAssignmentIdentityShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyAssignmentIdentityShowSettings ResetVerbose(this AzurePolicyAssignmentIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyRemediationDeploymentListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyRemediationDeploymentListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeploymentListSettings.Name"/></em></p>
        ///   <p>Name of the remediation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings SetName(this AzurePolicyRemediationDeploymentListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeploymentListSettings.Name"/></em></p>
        ///   <p>Name of the remediation.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings ResetName(this AzurePolicyRemediationDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeploymentListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings SetNamespace(this AzurePolicyRemediationDeploymentListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeploymentListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: Microsoft.Provider).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings ResetNamespace(this AzurePolicyRemediationDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeploymentListSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings SetParent(this AzurePolicyRemediationDeploymentListSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeploymentListSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: resourceTypeA/nameA/resourceTypeB/nameB).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings ResetParent(this AzurePolicyRemediationDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeploymentListSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings SetResource(this AzurePolicyRemediationDeploymentListSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeploymentListSettings.Resource"/></em></p>
        ///   <p>Resource ID or resource name. If a name is given, please provide the resource group and other relevant resource id arguments.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings ResetResource(this AzurePolicyRemediationDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeploymentListSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings SetResourceType(this AzurePolicyRemediationDeploymentListSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeploymentListSettings.ResourceType"/></em></p>
        ///   <p>Resource type (Ex: resourceTypeC).</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings ResetResourceType(this AzurePolicyRemediationDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region ManagementGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeploymentListSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings SetManagementGroup(this AzurePolicyRemediationDeploymentListSettings toolSettings, string managementGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = managementGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeploymentListSettings.ManagementGroup"/></em></p>
        ///   <p>Name of management group.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings ResetManagementGroup(this AzurePolicyRemediationDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagementGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeploymentListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings SetResourceGroup(this AzurePolicyRemediationDeploymentListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeploymentListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings ResetResourceGroup(this AzurePolicyRemediationDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeploymentListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings SetSubscription(this AzurePolicyRemediationDeploymentListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeploymentListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings ResetSubscription(this AzurePolicyRemediationDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeploymentListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings SetDebug(this AzurePolicyRemediationDeploymentListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeploymentListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings ResetDebug(this AzurePolicyRemediationDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeploymentListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings SetHelp(this AzurePolicyRemediationDeploymentListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeploymentListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings ResetHelp(this AzurePolicyRemediationDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeploymentListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings SetOutput(this AzurePolicyRemediationDeploymentListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeploymentListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings ResetOutput(this AzurePolicyRemediationDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeploymentListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings SetQuery(this AzurePolicyRemediationDeploymentListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeploymentListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings ResetQuery(this AzurePolicyRemediationDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzurePolicyRemediationDeploymentListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings SetVerbose(this AzurePolicyRemediationDeploymentListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzurePolicyRemediationDeploymentListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzurePolicyRemediationDeploymentListSettings ResetVerbose(this AzurePolicyRemediationDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PolicyAssignmentCreateSku
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<PolicyAssignmentCreateSku>))]
    public partial class PolicyAssignmentCreateSku : Enumeration
    {
        public static PolicyAssignmentCreateSku free = new PolicyAssignmentCreateSku { Value = "free" };
        public static PolicyAssignmentCreateSku standard = new PolicyAssignmentCreateSku { Value = "standard" };
    }
    #endregion
    #region PolicyDefinitionMode
    /// <summary>
    ///   Used within <see cref="AzurePolicyTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<PolicyDefinitionMode>))]
    public partial class PolicyDefinitionMode : Enumeration
    {
        public static PolicyDefinitionMode all = new PolicyDefinitionMode { Value = "all" };
        public static PolicyDefinitionMode indexed = new PolicyDefinitionMode { Value = "indexed" };
        public static PolicyDefinitionMode notspecified = new PolicyDefinitionMode { Value = "notspecified" };
    }
    #endregion
}
