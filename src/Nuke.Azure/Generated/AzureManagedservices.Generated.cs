// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureManagedservices.json
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
    public static partial class AzureManagedservicesTasks
    {
        /// <summary>
        ///   Path to the AzureManagedservices executable.
        /// </summary>
        public static string AzureManagedservicesPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREMANAGEDSERVICES_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureManagedservicesLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage the registration assignments and definitions in Azure.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedservices(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureManagedservicesPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureManagedservicesLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedservices(AzureManagedservicesSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedservicesSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedservices(Configure<AzureManagedservicesSettings> configurator)
        {
            return AzureManagedservices(configurator(new AzureManagedservicesSettings()));
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedservicesSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedservices(CombinatorialConfigure<AzureManagedservicesSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedservices, AzureManagedservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedservicesAssignmentCreate(AzureManagedservicesAssignmentCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedservicesAssignmentCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--assignment-id</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.AssignmentId"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Debug"/></li>
        ///     <li><c>--definition</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Definition"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedservicesAssignmentCreate(Configure<AzureManagedservicesAssignmentCreateSettings> configurator)
        {
            return AzureManagedservicesAssignmentCreate(configurator(new AzureManagedservicesAssignmentCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--assignment-id</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.AssignmentId"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Debug"/></li>
        ///     <li><c>--definition</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Definition"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesAssignmentCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedservicesAssignmentCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedservicesAssignmentCreate(CombinatorialConfigure<AzureManagedservicesAssignmentCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedservicesAssignmentCreate, AzureManagedservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedservicesAssignmentDelete(AzureManagedservicesAssignmentDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedservicesAssignmentDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--assignment</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Assignment"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedservicesAssignmentDelete(Configure<AzureManagedservicesAssignmentDeleteSettings> configurator)
        {
            return AzureManagedservicesAssignmentDelete(configurator(new AzureManagedservicesAssignmentDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--assignment</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Assignment"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesAssignmentDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedservicesAssignmentDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedservicesAssignmentDelete(CombinatorialConfigure<AzureManagedservicesAssignmentDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedservicesAssignmentDelete, AzureManagedservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedservicesAssignmentList(AzureManagedservicesAssignmentListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedservicesAssignmentListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesAssignmentListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesAssignmentListSettings.Help"/></li>
        ///     <li><c>--include-definition</c> via <see cref="AzureManagedservicesAssignmentListSettings.IncludeDefinition"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesAssignmentListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesAssignmentListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedservicesAssignmentListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesAssignmentListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesAssignmentListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedservicesAssignmentList(Configure<AzureManagedservicesAssignmentListSettings> configurator)
        {
            return AzureManagedservicesAssignmentList(configurator(new AzureManagedservicesAssignmentListSettings()));
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesAssignmentListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesAssignmentListSettings.Help"/></li>
        ///     <li><c>--include-definition</c> via <see cref="AzureManagedservicesAssignmentListSettings.IncludeDefinition"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesAssignmentListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesAssignmentListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedservicesAssignmentListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesAssignmentListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesAssignmentListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedservicesAssignmentListSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedservicesAssignmentList(CombinatorialConfigure<AzureManagedservicesAssignmentListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedservicesAssignmentList, AzureManagedservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedservicesAssignmentShow(AzureManagedservicesAssignmentShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedservicesAssignmentShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--assignment</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Assignment"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Help"/></li>
        ///     <li><c>--include-definition</c> via <see cref="AzureManagedservicesAssignmentShowSettings.IncludeDefinition"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedservicesAssignmentShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedservicesAssignmentShow(Configure<AzureManagedservicesAssignmentShowSettings> configurator)
        {
            return AzureManagedservicesAssignmentShow(configurator(new AzureManagedservicesAssignmentShowSettings()));
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--assignment</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Assignment"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Help"/></li>
        ///     <li><c>--include-definition</c> via <see cref="AzureManagedservicesAssignmentShowSettings.IncludeDefinition"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedservicesAssignmentShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesAssignmentShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedservicesAssignmentShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedservicesAssignmentShow(CombinatorialConfigure<AzureManagedservicesAssignmentShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedservicesAssignmentShow, AzureManagedservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedservicesDefinitionCreate(AzureManagedservicesDefinitionCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedservicesDefinitionCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Debug"/></li>
        ///     <li><c>--definition-id</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.DefinitionId"/></li>
        ///     <li><c>--description</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Description"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Output"/></li>
        ///     <li><c>--plan-name</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.PlanName"/></li>
        ///     <li><c>--plan-product</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.PlanProduct"/></li>
        ///     <li><c>--plan-publisher</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.PlanPublisher"/></li>
        ///     <li><c>--plan-version</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.PlanVersion"/></li>
        ///     <li><c>--principal-id</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.PrincipalId"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Query"/></li>
        ///     <li><c>--role-definition-id</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.RoleDefinitionId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Subscription"/></li>
        ///     <li><c>--tenant-id</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.TenantId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedservicesDefinitionCreate(Configure<AzureManagedservicesDefinitionCreateSettings> configurator)
        {
            return AzureManagedservicesDefinitionCreate(configurator(new AzureManagedservicesDefinitionCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Debug"/></li>
        ///     <li><c>--definition-id</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.DefinitionId"/></li>
        ///     <li><c>--description</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Description"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Output"/></li>
        ///     <li><c>--plan-name</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.PlanName"/></li>
        ///     <li><c>--plan-product</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.PlanProduct"/></li>
        ///     <li><c>--plan-publisher</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.PlanPublisher"/></li>
        ///     <li><c>--plan-version</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.PlanVersion"/></li>
        ///     <li><c>--principal-id</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.PrincipalId"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Query"/></li>
        ///     <li><c>--role-definition-id</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.RoleDefinitionId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Subscription"/></li>
        ///     <li><c>--tenant-id</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.TenantId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesDefinitionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedservicesDefinitionCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedservicesDefinitionCreate(CombinatorialConfigure<AzureManagedservicesDefinitionCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedservicesDefinitionCreate, AzureManagedservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedservicesDefinitionDelete(AzureManagedservicesDefinitionDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedservicesDefinitionDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Debug"/></li>
        ///     <li><c>--definition</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Definition"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedservicesDefinitionDelete(Configure<AzureManagedservicesDefinitionDeleteSettings> configurator)
        {
            return AzureManagedservicesDefinitionDelete(configurator(new AzureManagedservicesDefinitionDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Debug"/></li>
        ///     <li><c>--definition</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Definition"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesDefinitionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedservicesDefinitionDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedservicesDefinitionDelete(CombinatorialConfigure<AzureManagedservicesDefinitionDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedservicesDefinitionDelete, AzureManagedservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedservicesDefinitionList(AzureManagedservicesDefinitionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedservicesDefinitionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesDefinitionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesDefinitionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesDefinitionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesDefinitionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesDefinitionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesDefinitionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedservicesDefinitionList(Configure<AzureManagedservicesDefinitionListSettings> configurator)
        {
            return AzureManagedservicesDefinitionList(configurator(new AzureManagedservicesDefinitionListSettings()));
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesDefinitionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesDefinitionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesDefinitionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesDefinitionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesDefinitionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesDefinitionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedservicesDefinitionListSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedservicesDefinitionList(CombinatorialConfigure<AzureManagedservicesDefinitionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedservicesDefinitionList, AzureManagedservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedservicesDefinitionShow(AzureManagedservicesDefinitionShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedservicesDefinitionShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Debug"/></li>
        ///     <li><c>--definition</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Definition"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedservicesDefinitionShow(Configure<AzureManagedservicesDefinitionShowSettings> configurator)
        {
            return AzureManagedservicesDefinitionShow(configurator(new AzureManagedservicesDefinitionShowSettings()));
        }
        /// <summary>
        ///   <p>Manage the registration assignments and definitions in Azure.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Debug"/></li>
        ///     <li><c>--definition</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Definition"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedservicesDefinitionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedservicesDefinitionShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedservicesDefinitionShow(CombinatorialConfigure<AzureManagedservicesDefinitionShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedservicesDefinitionShow, AzureManagedservicesLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureManagedservicesSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedservicesSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedservicesTasks.AzureManagedservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedservicesTasks.AzureManagedservicesLogger;
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
              .Add("managedservices")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureManagedservicesAssignmentCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedservicesAssignmentCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedservicesTasks.AzureManagedservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedservicesTasks.AzureManagedservicesLogger;
        /// <summary>
        ///   The fully qualified resource id of the registration definition.
        /// </summary>
        public virtual string Definition { get; internal set; }
        /// <summary>
        ///   Can be used to override the generated registration assignment id.
        /// </summary>
        public virtual string AssignmentId { get; internal set; }
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
              .Add("managedservices assignment create")
              .Add("--definition {value}", Definition)
              .Add("--assignment-id {value}", AssignmentId)
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
    #region AzureManagedservicesAssignmentDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedservicesAssignmentDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedservicesTasks.AzureManagedservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedservicesTasks.AzureManagedservicesLogger;
        /// <summary>
        ///   The identifier (guid) or the fully qualified resource id of the registration assignment. When resource id is used, subscription id and resource group parameters are ignored.
        /// </summary>
        public virtual string Assignment { get; internal set; }
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
              .Add("managedservices assignment delete")
              .Add("--assignment {value}", Assignment)
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
    #region AzureManagedservicesAssignmentListSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedservicesAssignmentListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedservicesTasks.AzureManagedservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedservicesTasks.AzureManagedservicesLogger;
        /// <summary>
        ///   When provided, gets the associated registration definition details.
        /// </summary>
        public virtual bool? IncludeDefinition { get; internal set; }
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
              .Add("managedservices assignment list")
              .Add("--include-definition", IncludeDefinition)
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
    #region AzureManagedservicesAssignmentShowSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedservicesAssignmentShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedservicesTasks.AzureManagedservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedservicesTasks.AzureManagedservicesLogger;
        /// <summary>
        ///   The identifier (guid) or the fully qualified resource id of the registration assignment. When resource id is used, subscription id and resource group parameters are ignored.
        /// </summary>
        public virtual string Assignment { get; internal set; }
        /// <summary>
        ///   When provided, gets the associated registration definition details.
        /// </summary>
        public virtual bool? IncludeDefinition { get; internal set; }
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
              .Add("managedservices assignment show")
              .Add("--assignment {value}", Assignment)
              .Add("--include-definition", IncludeDefinition)
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
    #region AzureManagedservicesDefinitionCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedservicesDefinitionCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedservicesTasks.AzureManagedservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedservicesTasks.AzureManagedservicesLogger;
        /// <summary>
        ///   The name of the registration definition.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The principal id.
        /// </summary>
        public virtual string PrincipalId { get; internal set; }
        /// <summary>
        ///   The role definition id.
        /// </summary>
        public virtual string RoleDefinitionId { get; internal set; }
        /// <summary>
        ///   The managed by tenant id.
        /// </summary>
        public virtual string TenantId { get; internal set; }
        /// <summary>
        ///   Can be used to override the generated registration definition id.
        /// </summary>
        public virtual string DefinitionId { get; internal set; }
        /// <summary>
        ///   The friendly description.
        /// </summary>
        public virtual string Description { get; internal set; }
        /// <summary>
        ///   The plan name.
        /// </summary>
        public virtual string PlanName { get; internal set; }
        /// <summary>
        ///   The plan product.
        /// </summary>
        public virtual string PlanProduct { get; internal set; }
        /// <summary>
        ///   The plan publisher.
        /// </summary>
        public virtual string PlanPublisher { get; internal set; }
        /// <summary>
        ///   The plan version.
        /// </summary>
        public virtual string PlanVersion { get; internal set; }
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
              .Add("managedservices definition create")
              .Add("--name {value}", Name)
              .Add("--principal-id {value}", PrincipalId)
              .Add("--role-definition-id {value}", RoleDefinitionId)
              .Add("--tenant-id {value}", TenantId)
              .Add("--definition-id {value}", DefinitionId)
              .Add("--description {value}", Description)
              .Add("--plan-name {value}", PlanName)
              .Add("--plan-product {value}", PlanProduct)
              .Add("--plan-publisher {value}", PlanPublisher)
              .Add("--plan-version {value}", PlanVersion)
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
    #region AzureManagedservicesDefinitionDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedservicesDefinitionDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedservicesTasks.AzureManagedservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedservicesTasks.AzureManagedservicesLogger;
        /// <summary>
        ///   The identifier (guid) or the fully qualified resource id of the registration definition. When resource id is used, subscription id and resource group parameters are ignored.
        /// </summary>
        public virtual string Definition { get; internal set; }
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
              .Add("managedservices definition delete")
              .Add("--definition {value}", Definition)
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
    #region AzureManagedservicesDefinitionListSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedservicesDefinitionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedservicesTasks.AzureManagedservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedservicesTasks.AzureManagedservicesLogger;
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
              .Add("managedservices definition list")
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
    #region AzureManagedservicesDefinitionShowSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedservicesDefinitionShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedservicesTasks.AzureManagedservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedservicesTasks.AzureManagedservicesLogger;
        /// <summary>
        ///   The identifier (guid) or the fully qualified resource id of the registration definition. When resource id is used, subscription id and resource group parameters are ignored.
        /// </summary>
        public virtual string Definition { get; internal set; }
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
              .Add("managedservices definition show")
              .Add("--definition {value}", Definition)
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
    #region AzureManagedservicesSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedservicesSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesSettings SetDebug(this AzureManagedservicesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesSettings ResetDebug(this AzureManagedservicesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesSettings SetHelp(this AzureManagedservicesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesSettings ResetHelp(this AzureManagedservicesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesSettings SetOutput(this AzureManagedservicesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesSettings ResetOutput(this AzureManagedservicesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesSettings SetQuery(this AzureManagedservicesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesSettings ResetQuery(this AzureManagedservicesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesSettings SetVerbose(this AzureManagedservicesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesSettings ResetVerbose(this AzureManagedservicesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedservicesAssignmentCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedservicesAssignmentCreateSettingsExtensions
    {
        #region Definition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentCreateSettings.Definition"/></em></p>
        ///   <p>The fully qualified resource id of the registration definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings SetDefinition(this AzureManagedservicesAssignmentCreateSettings toolSettings, string definition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definition = definition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentCreateSettings.Definition"/></em></p>
        ///   <p>The fully qualified resource id of the registration definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings ResetDefinition(this AzureManagedservicesAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definition = null;
            return toolSettings;
        }
        #endregion
        #region AssignmentId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentCreateSettings.AssignmentId"/></em></p>
        ///   <p>Can be used to override the generated registration assignment id.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings SetAssignmentId(this AzureManagedservicesAssignmentCreateSettings toolSettings, string assignmentId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignmentId = assignmentId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentCreateSettings.AssignmentId"/></em></p>
        ///   <p>Can be used to override the generated registration assignment id.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings ResetAssignmentId(this AzureManagedservicesAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignmentId = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings SetResourceGroup(this AzureManagedservicesAssignmentCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings ResetResourceGroup(this AzureManagedservicesAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings SetSubscription(this AzureManagedservicesAssignmentCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings ResetSubscription(this AzureManagedservicesAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings SetDebug(this AzureManagedservicesAssignmentCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings ResetDebug(this AzureManagedservicesAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings SetHelp(this AzureManagedservicesAssignmentCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings ResetHelp(this AzureManagedservicesAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings SetOutput(this AzureManagedservicesAssignmentCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings ResetOutput(this AzureManagedservicesAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings SetQuery(this AzureManagedservicesAssignmentCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings ResetQuery(this AzureManagedservicesAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings SetVerbose(this AzureManagedservicesAssignmentCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentCreateSettings ResetVerbose(this AzureManagedservicesAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedservicesAssignmentDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedservicesAssignmentDeleteSettingsExtensions
    {
        #region Assignment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentDeleteSettings.Assignment"/></em></p>
        ///   <p>The identifier (guid) or the fully qualified resource id of the registration assignment. When resource id is used, subscription id and resource group parameters are ignored.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings SetAssignment(this AzureManagedservicesAssignmentDeleteSettings toolSettings, string assignment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Assignment = assignment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentDeleteSettings.Assignment"/></em></p>
        ///   <p>The identifier (guid) or the fully qualified resource id of the registration assignment. When resource id is used, subscription id and resource group parameters are ignored.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings ResetAssignment(this AzureManagedservicesAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Assignment = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings SetResourceGroup(this AzureManagedservicesAssignmentDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings ResetResourceGroup(this AzureManagedservicesAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings SetSubscription(this AzureManagedservicesAssignmentDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings ResetSubscription(this AzureManagedservicesAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings SetDebug(this AzureManagedservicesAssignmentDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings ResetDebug(this AzureManagedservicesAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings SetHelp(this AzureManagedservicesAssignmentDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings ResetHelp(this AzureManagedservicesAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings SetOutput(this AzureManagedservicesAssignmentDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings ResetOutput(this AzureManagedservicesAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings SetQuery(this AzureManagedservicesAssignmentDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings ResetQuery(this AzureManagedservicesAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings SetVerbose(this AzureManagedservicesAssignmentDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentDeleteSettings ResetVerbose(this AzureManagedservicesAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedservicesAssignmentListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedservicesAssignmentListSettingsExtensions
    {
        #region IncludeDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentListSettings.IncludeDefinition"/></em></p>
        ///   <p>When provided, gets the associated registration definition details.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings SetIncludeDefinition(this AzureManagedservicesAssignmentListSettings toolSettings, bool? includeDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeDefinition = includeDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentListSettings.IncludeDefinition"/></em></p>
        ///   <p>When provided, gets the associated registration definition details.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings ResetIncludeDefinition(this AzureManagedservicesAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeDefinition = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureManagedservicesAssignmentListSettings.IncludeDefinition"/></em></p>
        ///   <p>When provided, gets the associated registration definition details.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings EnableIncludeDefinition(this AzureManagedservicesAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeDefinition = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureManagedservicesAssignmentListSettings.IncludeDefinition"/></em></p>
        ///   <p>When provided, gets the associated registration definition details.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings DisableIncludeDefinition(this AzureManagedservicesAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeDefinition = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureManagedservicesAssignmentListSettings.IncludeDefinition"/></em></p>
        ///   <p>When provided, gets the associated registration definition details.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings ToggleIncludeDefinition(this AzureManagedservicesAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeDefinition = !toolSettings.IncludeDefinition;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings SetResourceGroup(this AzureManagedservicesAssignmentListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings ResetResourceGroup(this AzureManagedservicesAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings SetSubscription(this AzureManagedservicesAssignmentListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings ResetSubscription(this AzureManagedservicesAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings SetDebug(this AzureManagedservicesAssignmentListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings ResetDebug(this AzureManagedservicesAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings SetHelp(this AzureManagedservicesAssignmentListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings ResetHelp(this AzureManagedservicesAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings SetOutput(this AzureManagedservicesAssignmentListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings ResetOutput(this AzureManagedservicesAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings SetQuery(this AzureManagedservicesAssignmentListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings ResetQuery(this AzureManagedservicesAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings SetVerbose(this AzureManagedservicesAssignmentListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentListSettings ResetVerbose(this AzureManagedservicesAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedservicesAssignmentShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedservicesAssignmentShowSettingsExtensions
    {
        #region Assignment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentShowSettings.Assignment"/></em></p>
        ///   <p>The identifier (guid) or the fully qualified resource id of the registration assignment. When resource id is used, subscription id and resource group parameters are ignored.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings SetAssignment(this AzureManagedservicesAssignmentShowSettings toolSettings, string assignment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Assignment = assignment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentShowSettings.Assignment"/></em></p>
        ///   <p>The identifier (guid) or the fully qualified resource id of the registration assignment. When resource id is used, subscription id and resource group parameters are ignored.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings ResetAssignment(this AzureManagedservicesAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Assignment = null;
            return toolSettings;
        }
        #endregion
        #region IncludeDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentShowSettings.IncludeDefinition"/></em></p>
        ///   <p>When provided, gets the associated registration definition details.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings SetIncludeDefinition(this AzureManagedservicesAssignmentShowSettings toolSettings, bool? includeDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeDefinition = includeDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentShowSettings.IncludeDefinition"/></em></p>
        ///   <p>When provided, gets the associated registration definition details.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings ResetIncludeDefinition(this AzureManagedservicesAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeDefinition = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureManagedservicesAssignmentShowSettings.IncludeDefinition"/></em></p>
        ///   <p>When provided, gets the associated registration definition details.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings EnableIncludeDefinition(this AzureManagedservicesAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeDefinition = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureManagedservicesAssignmentShowSettings.IncludeDefinition"/></em></p>
        ///   <p>When provided, gets the associated registration definition details.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings DisableIncludeDefinition(this AzureManagedservicesAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeDefinition = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureManagedservicesAssignmentShowSettings.IncludeDefinition"/></em></p>
        ///   <p>When provided, gets the associated registration definition details.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings ToggleIncludeDefinition(this AzureManagedservicesAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeDefinition = !toolSettings.IncludeDefinition;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings SetResourceGroup(this AzureManagedservicesAssignmentShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings ResetResourceGroup(this AzureManagedservicesAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings SetSubscription(this AzureManagedservicesAssignmentShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings ResetSubscription(this AzureManagedservicesAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings SetDebug(this AzureManagedservicesAssignmentShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings ResetDebug(this AzureManagedservicesAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings SetHelp(this AzureManagedservicesAssignmentShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings ResetHelp(this AzureManagedservicesAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings SetOutput(this AzureManagedservicesAssignmentShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings ResetOutput(this AzureManagedservicesAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings SetQuery(this AzureManagedservicesAssignmentShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings ResetQuery(this AzureManagedservicesAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesAssignmentShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings SetVerbose(this AzureManagedservicesAssignmentShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesAssignmentShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesAssignmentShowSettings ResetVerbose(this AzureManagedservicesAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedservicesDefinitionCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedservicesDefinitionCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.Name"/></em></p>
        ///   <p>The name of the registration definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetName(this AzureManagedservicesDefinitionCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.Name"/></em></p>
        ///   <p>The name of the registration definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetName(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PrincipalId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.PrincipalId"/></em></p>
        ///   <p>The principal id.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetPrincipalId(this AzureManagedservicesDefinitionCreateSettings toolSettings, string principalId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrincipalId = principalId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.PrincipalId"/></em></p>
        ///   <p>The principal id.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetPrincipalId(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrincipalId = null;
            return toolSettings;
        }
        #endregion
        #region RoleDefinitionId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.RoleDefinitionId"/></em></p>
        ///   <p>The role definition id.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetRoleDefinitionId(this AzureManagedservicesDefinitionCreateSettings toolSettings, string roleDefinitionId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RoleDefinitionId = roleDefinitionId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.RoleDefinitionId"/></em></p>
        ///   <p>The role definition id.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetRoleDefinitionId(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RoleDefinitionId = null;
            return toolSettings;
        }
        #endregion
        #region TenantId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.TenantId"/></em></p>
        ///   <p>The managed by tenant id.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetTenantId(this AzureManagedservicesDefinitionCreateSettings toolSettings, string tenantId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TenantId = tenantId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.TenantId"/></em></p>
        ///   <p>The managed by tenant id.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetTenantId(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TenantId = null;
            return toolSettings;
        }
        #endregion
        #region DefinitionId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.DefinitionId"/></em></p>
        ///   <p>Can be used to override the generated registration definition id.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetDefinitionId(this AzureManagedservicesDefinitionCreateSettings toolSettings, string definitionId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefinitionId = definitionId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.DefinitionId"/></em></p>
        ///   <p>Can be used to override the generated registration definition id.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetDefinitionId(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefinitionId = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.Description"/></em></p>
        ///   <p>The friendly description.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetDescription(this AzureManagedservicesDefinitionCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.Description"/></em></p>
        ///   <p>The friendly description.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetDescription(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region PlanName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.PlanName"/></em></p>
        ///   <p>The plan name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetPlanName(this AzureManagedservicesDefinitionCreateSettings toolSettings, string planName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanName = planName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.PlanName"/></em></p>
        ///   <p>The plan name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetPlanName(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanName = null;
            return toolSettings;
        }
        #endregion
        #region PlanProduct
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.PlanProduct"/></em></p>
        ///   <p>The plan product.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetPlanProduct(this AzureManagedservicesDefinitionCreateSettings toolSettings, string planProduct)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanProduct = planProduct;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.PlanProduct"/></em></p>
        ///   <p>The plan product.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetPlanProduct(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanProduct = null;
            return toolSettings;
        }
        #endregion
        #region PlanPublisher
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.PlanPublisher"/></em></p>
        ///   <p>The plan publisher.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetPlanPublisher(this AzureManagedservicesDefinitionCreateSettings toolSettings, string planPublisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPublisher = planPublisher;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.PlanPublisher"/></em></p>
        ///   <p>The plan publisher.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetPlanPublisher(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPublisher = null;
            return toolSettings;
        }
        #endregion
        #region PlanVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.PlanVersion"/></em></p>
        ///   <p>The plan version.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetPlanVersion(this AzureManagedservicesDefinitionCreateSettings toolSettings, string planVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanVersion = planVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.PlanVersion"/></em></p>
        ///   <p>The plan version.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetPlanVersion(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanVersion = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetSubscription(this AzureManagedservicesDefinitionCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetSubscription(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetDebug(this AzureManagedservicesDefinitionCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetDebug(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetHelp(this AzureManagedservicesDefinitionCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetHelp(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetOutput(this AzureManagedservicesDefinitionCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetOutput(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetQuery(this AzureManagedservicesDefinitionCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetQuery(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings SetVerbose(this AzureManagedservicesDefinitionCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionCreateSettings ResetVerbose(this AzureManagedservicesDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedservicesDefinitionDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedservicesDefinitionDeleteSettingsExtensions
    {
        #region Definition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionDeleteSettings.Definition"/></em></p>
        ///   <p>The identifier (guid) or the fully qualified resource id of the registration definition. When resource id is used, subscription id and resource group parameters are ignored.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings SetDefinition(this AzureManagedservicesDefinitionDeleteSettings toolSettings, string definition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definition = definition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionDeleteSettings.Definition"/></em></p>
        ///   <p>The identifier (guid) or the fully qualified resource id of the registration definition. When resource id is used, subscription id and resource group parameters are ignored.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings ResetDefinition(this AzureManagedservicesDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definition = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings SetSubscription(this AzureManagedservicesDefinitionDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings ResetSubscription(this AzureManagedservicesDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings SetDebug(this AzureManagedservicesDefinitionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings ResetDebug(this AzureManagedservicesDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings SetHelp(this AzureManagedservicesDefinitionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings ResetHelp(this AzureManagedservicesDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings SetOutput(this AzureManagedservicesDefinitionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings ResetOutput(this AzureManagedservicesDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings SetQuery(this AzureManagedservicesDefinitionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings ResetQuery(this AzureManagedservicesDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings SetVerbose(this AzureManagedservicesDefinitionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionDeleteSettings ResetVerbose(this AzureManagedservicesDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedservicesDefinitionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedservicesDefinitionListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionListSettings SetSubscription(this AzureManagedservicesDefinitionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionListSettings ResetSubscription(this AzureManagedservicesDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionListSettings SetDebug(this AzureManagedservicesDefinitionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionListSettings ResetDebug(this AzureManagedservicesDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionListSettings SetHelp(this AzureManagedservicesDefinitionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionListSettings ResetHelp(this AzureManagedservicesDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionListSettings SetOutput(this AzureManagedservicesDefinitionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionListSettings ResetOutput(this AzureManagedservicesDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionListSettings SetQuery(this AzureManagedservicesDefinitionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionListSettings ResetQuery(this AzureManagedservicesDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionListSettings SetVerbose(this AzureManagedservicesDefinitionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionListSettings ResetVerbose(this AzureManagedservicesDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedservicesDefinitionShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedservicesDefinitionShowSettingsExtensions
    {
        #region Definition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionShowSettings.Definition"/></em></p>
        ///   <p>The identifier (guid) or the fully qualified resource id of the registration definition. When resource id is used, subscription id and resource group parameters are ignored.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings SetDefinition(this AzureManagedservicesDefinitionShowSettings toolSettings, string definition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definition = definition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionShowSettings.Definition"/></em></p>
        ///   <p>The identifier (guid) or the fully qualified resource id of the registration definition. When resource id is used, subscription id and resource group parameters are ignored.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings ResetDefinition(this AzureManagedservicesDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definition = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings SetSubscription(this AzureManagedservicesDefinitionShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings ResetSubscription(this AzureManagedservicesDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings SetDebug(this AzureManagedservicesDefinitionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings ResetDebug(this AzureManagedservicesDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings SetHelp(this AzureManagedservicesDefinitionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings ResetHelp(this AzureManagedservicesDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings SetOutput(this AzureManagedservicesDefinitionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings ResetOutput(this AzureManagedservicesDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings SetQuery(this AzureManagedservicesDefinitionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings ResetQuery(this AzureManagedservicesDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedservicesDefinitionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings SetVerbose(this AzureManagedservicesDefinitionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedservicesDefinitionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedservicesDefinitionShowSettings ResetVerbose(this AzureManagedservicesDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
