// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureManagedapp.json
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
    public static partial class AzureManagedappTasks
    {
        /// <summary>
        ///   Path to the AzureManagedapp executable.
        /// </summary>
        public static string AzureManagedappPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREMANAGEDAPP_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureManagedappLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage template solutions provided and maintained by Independent Software Vendors (ISVs).
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedapp(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureManagedappPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureManagedappLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedappCreate(AzureManagedappCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedappCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappCreateSettings.Help"/></li>
        ///     <li><c>--kind</c> via <see cref="AzureManagedappCreateSettings.Kind"/></li>
        ///     <li><c>--location</c> via <see cref="AzureManagedappCreateSettings.Location"/></li>
        ///     <li><c>--managedapp-definition-id</c> via <see cref="AzureManagedappCreateSettings.ManagedappDefinitionId"/></li>
        ///     <li><c>--managed-rg-id</c> via <see cref="AzureManagedappCreateSettings.ManagedRgId"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedappCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappCreateSettings.Output"/></li>
        ///     <li><c>--parameters</c> via <see cref="AzureManagedappCreateSettings.Parameters"/></li>
        ///     <li><c>--plan-name</c> via <see cref="AzureManagedappCreateSettings.PlanName"/></li>
        ///     <li><c>--plan-product</c> via <see cref="AzureManagedappCreateSettings.PlanProduct"/></li>
        ///     <li><c>--plan-publisher</c> via <see cref="AzureManagedappCreateSettings.PlanPublisher"/></li>
        ///     <li><c>--plan-version</c> via <see cref="AzureManagedappCreateSettings.PlanVersion"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureManagedappCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedappCreate(Configure<AzureManagedappCreateSettings> configurator)
        {
            return AzureManagedappCreate(configurator(new AzureManagedappCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappCreateSettings.Help"/></li>
        ///     <li><c>--kind</c> via <see cref="AzureManagedappCreateSettings.Kind"/></li>
        ///     <li><c>--location</c> via <see cref="AzureManagedappCreateSettings.Location"/></li>
        ///     <li><c>--managedapp-definition-id</c> via <see cref="AzureManagedappCreateSettings.ManagedappDefinitionId"/></li>
        ///     <li><c>--managed-rg-id</c> via <see cref="AzureManagedappCreateSettings.ManagedRgId"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedappCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappCreateSettings.Output"/></li>
        ///     <li><c>--parameters</c> via <see cref="AzureManagedappCreateSettings.Parameters"/></li>
        ///     <li><c>--plan-name</c> via <see cref="AzureManagedappCreateSettings.PlanName"/></li>
        ///     <li><c>--plan-product</c> via <see cref="AzureManagedappCreateSettings.PlanProduct"/></li>
        ///     <li><c>--plan-publisher</c> via <see cref="AzureManagedappCreateSettings.PlanPublisher"/></li>
        ///     <li><c>--plan-version</c> via <see cref="AzureManagedappCreateSettings.PlanVersion"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureManagedappCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedappCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedappCreate(CombinatorialConfigure<AzureManagedappCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedappCreate, AzureManagedappLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedappDelete(AzureManagedappDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedappDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureManagedappDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedappDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedappDelete(Configure<AzureManagedappDeleteSettings> configurator)
        {
            return AzureManagedappDelete(configurator(new AzureManagedappDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureManagedappDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedappDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedappDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedappDelete(CombinatorialConfigure<AzureManagedappDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedappDelete, AzureManagedappLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedappList(AzureManagedappListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedappListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedappList(Configure<AzureManagedappListSettings> configurator)
        {
            return AzureManagedappList(configurator(new AzureManagedappListSettings()));
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedappListSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedappList(CombinatorialConfigure<AzureManagedappListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedappList, AzureManagedappLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedappShow(AzureManagedappShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedappShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureManagedappShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedappShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedappShow(Configure<AzureManagedappShowSettings> configurator)
        {
            return AzureManagedappShow(configurator(new AzureManagedappShowSettings()));
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureManagedappShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedappShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedappShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedappShow(CombinatorialConfigure<AzureManagedappShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedappShow, AzureManagedappLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedappDefinitionCreate(AzureManagedappDefinitionCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedappDefinitionCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--authorizations</c> via <see cref="AzureManagedappDefinitionCreateSettings.Authorizations"/></li>
        ///     <li><c>--create-ui-definition</c> via <see cref="AzureManagedappDefinitionCreateSettings.CreateUiDefinition"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappDefinitionCreateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzureManagedappDefinitionCreateSettings.Description"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureManagedappDefinitionCreateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappDefinitionCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureManagedappDefinitionCreateSettings.Location"/></li>
        ///     <li><c>--lock-level</c> via <see cref="AzureManagedappDefinitionCreateSettings.LockLevel"/></li>
        ///     <li><c>--main-template</c> via <see cref="AzureManagedappDefinitionCreateSettings.MainTemplate"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedappDefinitionCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappDefinitionCreateSettings.Output"/></li>
        ///     <li><c>--package-file-uri</c> via <see cref="AzureManagedappDefinitionCreateSettings.PackageFileUri"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappDefinitionCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappDefinitionCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappDefinitionCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureManagedappDefinitionCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappDefinitionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedappDefinitionCreate(Configure<AzureManagedappDefinitionCreateSettings> configurator)
        {
            return AzureManagedappDefinitionCreate(configurator(new AzureManagedappDefinitionCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--authorizations</c> via <see cref="AzureManagedappDefinitionCreateSettings.Authorizations"/></li>
        ///     <li><c>--create-ui-definition</c> via <see cref="AzureManagedappDefinitionCreateSettings.CreateUiDefinition"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappDefinitionCreateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzureManagedappDefinitionCreateSettings.Description"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureManagedappDefinitionCreateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappDefinitionCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureManagedappDefinitionCreateSettings.Location"/></li>
        ///     <li><c>--lock-level</c> via <see cref="AzureManagedappDefinitionCreateSettings.LockLevel"/></li>
        ///     <li><c>--main-template</c> via <see cref="AzureManagedappDefinitionCreateSettings.MainTemplate"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedappDefinitionCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappDefinitionCreateSettings.Output"/></li>
        ///     <li><c>--package-file-uri</c> via <see cref="AzureManagedappDefinitionCreateSettings.PackageFileUri"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappDefinitionCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappDefinitionCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappDefinitionCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureManagedappDefinitionCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappDefinitionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedappDefinitionCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedappDefinitionCreate(CombinatorialConfigure<AzureManagedappDefinitionCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedappDefinitionCreate, AzureManagedappLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedappDefinitionDelete(AzureManagedappDefinitionDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedappDefinitionDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappDefinitionDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedappDefinitionDelete(Configure<AzureManagedappDefinitionDeleteSettings> configurator)
        {
            return AzureManagedappDefinitionDelete(configurator(new AzureManagedappDefinitionDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappDefinitionDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappDefinitionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedappDefinitionDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedappDefinitionDelete(CombinatorialConfigure<AzureManagedappDefinitionDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedappDefinitionDelete, AzureManagedappLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedappDefinitionList(AzureManagedappDefinitionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedappDefinitionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappDefinitionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappDefinitionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappDefinitionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappDefinitionListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappDefinitionListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappDefinitionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappDefinitionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedappDefinitionList(Configure<AzureManagedappDefinitionListSettings> configurator)
        {
            return AzureManagedappDefinitionList(configurator(new AzureManagedappDefinitionListSettings()));
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappDefinitionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappDefinitionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappDefinitionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappDefinitionListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappDefinitionListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappDefinitionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappDefinitionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedappDefinitionListSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedappDefinitionList(CombinatorialConfigure<AzureManagedappDefinitionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedappDefinitionList, AzureManagedappLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureManagedappDefinitionShow(AzureManagedappDefinitionShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureManagedappDefinitionShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappDefinitionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappDefinitionShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureManagedappDefinitionShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedappDefinitionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappDefinitionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappDefinitionShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappDefinitionShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappDefinitionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappDefinitionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureManagedappDefinitionShow(Configure<AzureManagedappDefinitionShowSettings> configurator)
        {
            return AzureManagedappDefinitionShow(configurator(new AzureManagedappDefinitionShowSettings()));
        }
        /// <summary>
        ///   <p>Manage template solutions provided and maintained by Independent Software Vendors (ISVs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/managedapp?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureManagedappDefinitionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureManagedappDefinitionShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureManagedappDefinitionShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureManagedappDefinitionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureManagedappDefinitionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureManagedappDefinitionShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureManagedappDefinitionShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureManagedappDefinitionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureManagedappDefinitionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureManagedappDefinitionShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureManagedappDefinitionShow(CombinatorialConfigure<AzureManagedappDefinitionShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureManagedappDefinitionShow, AzureManagedappLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureManagedappCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedappCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedapp executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedappTasks.AzureManagedappPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedappTasks.AzureManagedappLogger;
        /// <summary>
        ///   The managed application kind. can be marketplace or servicecatalog.
        /// </summary>
        public virtual string Kind { get; internal set; }
        /// <summary>
        ///   The resource group managed by the managed application.
        /// </summary>
        public virtual string ManagedRgId { get; internal set; }
        /// <summary>
        ///   The managed application name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The resource group of the managed application.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The managed application location.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The full qualified managed application definition id.
        /// </summary>
        public virtual string ManagedappDefinitionId { get; internal set; }
        /// <summary>
        ///   JSON formatted string or a path to a file with such content.
        /// </summary>
        public virtual string Parameters { get; internal set; }
        /// <summary>
        ///   The managed application package plan name.
        /// </summary>
        public virtual string PlanName { get; internal set; }
        /// <summary>
        ///   The managed application package plan product.
        /// </summary>
        public virtual string PlanProduct { get; internal set; }
        /// <summary>
        ///   The managed application package plan publisher.
        /// </summary>
        public virtual string PlanPublisher { get; internal set; }
        /// <summary>
        ///   The managed application package plan version.
        /// </summary>
        public virtual string PlanVersion { get; internal set; }
        /// <summary>
        ///   Tags in 'a=b c' format.
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
              .Add("managedapp create")
              .Add("--kind {value}", Kind)
              .Add("--managed-rg-id {value}", ManagedRgId)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
              .Add("--managedapp-definition-id {value}", ManagedappDefinitionId)
              .Add("--parameters {value}", Parameters)
              .Add("--plan-name {value}", PlanName)
              .Add("--plan-product {value}", PlanProduct)
              .Add("--plan-publisher {value}", PlanPublisher)
              .Add("--plan-version {value}", PlanVersion)
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
    #region AzureManagedappDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedappDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedapp executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedappTasks.AzureManagedappPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedappTasks.AzureManagedappLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the managed application.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The resource group of the managed application.
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
              .Add("managedapp delete")
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
    #region AzureManagedappListSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedappListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedapp executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedappTasks.AzureManagedappPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedappTasks.AzureManagedappLogger;
        /// <summary>
        ///   The resource group of the managed application.
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
              .Add("managedapp list")
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
    #region AzureManagedappShowSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedappShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedapp executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedappTasks.AzureManagedappPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedappTasks.AzureManagedappLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The managed application name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The resource group of the managed application.
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
              .Add("managedapp show")
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
    #region AzureManagedappDefinitionCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedappDefinitionCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedapp executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedappTasks.AzureManagedappPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedappTasks.AzureManagedappLogger;
        /// <summary>
        ///   Space-separated authorization pairs in a format of &lt;principalId&gt;:&lt;roleDefinitionId&gt;.
        /// </summary>
        public virtual IReadOnlyList<string> Authorizations => AuthorizationsInternal.AsReadOnly();
        internal List<string> AuthorizationsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The managed application definition description.
        /// </summary>
        public virtual string Description { get; internal set; }
        /// <summary>
        ///   The managed application definition display name.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   The type of lock restriction.
        /// </summary>
        public virtual ManagedappDefinitionCreateLockLevel LockLevel { get; internal set; }
        /// <summary>
        ///   The managed application definition name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The resource group of the managed application definition.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The managed application definition create ui definition.
        /// </summary>
        public virtual string CreateUiDefinition { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The managed application definition main template.
        /// </summary>
        public virtual string MainTemplate { get; internal set; }
        /// <summary>
        ///   The managed application definition package file uri.
        /// </summary>
        public virtual string PackageFileUri { get; internal set; }
        /// <summary>
        ///   Tags in 'a=b c' format.
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
              .Add("managedapp definition create")
              .Add("--authorizations {value}", Authorizations, separator: ' ')
              .Add("--description {value}", Description)
              .Add("--display-name {value}", DisplayName)
              .Add("--lock-level {value}", LockLevel)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--create-ui-definition {value}", CreateUiDefinition)
              .Add("--location {value}", Location)
              .Add("--main-template {value}", MainTemplate)
              .Add("--package-file-uri {value}", PackageFileUri)
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
    #region AzureManagedappDefinitionDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedappDefinitionDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedapp executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedappTasks.AzureManagedappPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedappTasks.AzureManagedappLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the managed application definition to delete.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The resource group of the managed application definition.
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
              .Add("managedapp definition delete")
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
    #region AzureManagedappDefinitionListSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedappDefinitionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedapp executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedappTasks.AzureManagedappPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedappTasks.AzureManagedappLogger;
        /// <summary>
        ///   The resource group of the managed application definition.
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
              .Add("managedapp definition list")
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
    #region AzureManagedappDefinitionShowSettings
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureManagedappDefinitionShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureManagedapp executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureManagedappTasks.AzureManagedappPath;
        public override Action<OutputType, string> CustomLogger => AzureManagedappTasks.AzureManagedappLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The managed application definition name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The resource group of the managed application definition.
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
              .Add("managedapp definition show")
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
    #region AzureManagedappCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedappCreateSettingsExtensions
    {
        #region Kind
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.Kind"/></em></p>
        ///   <p>The managed application kind. can be marketplace or servicecatalog.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetKind(this AzureManagedappCreateSettings toolSettings, string kind)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = kind;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.Kind"/></em></p>
        ///   <p>The managed application kind. can be marketplace or servicecatalog.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetKind(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = null;
            return toolSettings;
        }
        #endregion
        #region ManagedRgId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.ManagedRgId"/></em></p>
        ///   <p>The resource group managed by the managed application.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetManagedRgId(this AzureManagedappCreateSettings toolSettings, string managedRgId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagedRgId = managedRgId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.ManagedRgId"/></em></p>
        ///   <p>The resource group managed by the managed application.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetManagedRgId(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagedRgId = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.Name"/></em></p>
        ///   <p>The managed application name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetName(this AzureManagedappCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.Name"/></em></p>
        ///   <p>The managed application name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetName(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetResourceGroup(this AzureManagedappCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetResourceGroup(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.Location"/></em></p>
        ///   <p>The managed application location.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetLocation(this AzureManagedappCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.Location"/></em></p>
        ///   <p>The managed application location.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetLocation(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ManagedappDefinitionId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.ManagedappDefinitionId"/></em></p>
        ///   <p>The full qualified managed application definition id.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetManagedappDefinitionId(this AzureManagedappCreateSettings toolSettings, string managedappDefinitionId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagedappDefinitionId = managedappDefinitionId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.ManagedappDefinitionId"/></em></p>
        ///   <p>The full qualified managed application definition id.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetManagedappDefinitionId(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagedappDefinitionId = null;
            return toolSettings;
        }
        #endregion
        #region Parameters
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.Parameters"/></em></p>
        ///   <p>JSON formatted string or a path to a file with such content.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetParameters(this AzureManagedappCreateSettings toolSettings, string parameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = parameters;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.Parameters"/></em></p>
        ///   <p>JSON formatted string or a path to a file with such content.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetParameters(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = null;
            return toolSettings;
        }
        #endregion
        #region PlanName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.PlanName"/></em></p>
        ///   <p>The managed application package plan name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetPlanName(this AzureManagedappCreateSettings toolSettings, string planName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanName = planName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.PlanName"/></em></p>
        ///   <p>The managed application package plan name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetPlanName(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanName = null;
            return toolSettings;
        }
        #endregion
        #region PlanProduct
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.PlanProduct"/></em></p>
        ///   <p>The managed application package plan product.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetPlanProduct(this AzureManagedappCreateSettings toolSettings, string planProduct)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanProduct = planProduct;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.PlanProduct"/></em></p>
        ///   <p>The managed application package plan product.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetPlanProduct(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanProduct = null;
            return toolSettings;
        }
        #endregion
        #region PlanPublisher
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.PlanPublisher"/></em></p>
        ///   <p>The managed application package plan publisher.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetPlanPublisher(this AzureManagedappCreateSettings toolSettings, string planPublisher)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPublisher = planPublisher;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.PlanPublisher"/></em></p>
        ///   <p>The managed application package plan publisher.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetPlanPublisher(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanPublisher = null;
            return toolSettings;
        }
        #endregion
        #region PlanVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.PlanVersion"/></em></p>
        ///   <p>The managed application package plan version.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetPlanVersion(this AzureManagedappCreateSettings toolSettings, string planVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanVersion = planVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.PlanVersion"/></em></p>
        ///   <p>The managed application package plan version.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetPlanVersion(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PlanVersion = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.Tags"/></em></p>
        ///   <p>Tags in 'a=b c' format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetTags(this AzureManagedappCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.Tags"/></em></p>
        ///   <p>Tags in 'a=b c' format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetTags(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetSubscription(this AzureManagedappCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetSubscription(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetDebug(this AzureManagedappCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetDebug(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetHelp(this AzureManagedappCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetHelp(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetOutput(this AzureManagedappCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetOutput(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetQuery(this AzureManagedappCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetQuery(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings SetVerbose(this AzureManagedappCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappCreateSettings ResetVerbose(this AzureManagedappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedappDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedappDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings SetIds(this AzureManagedappDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings SetIds(this AzureManagedappDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureManagedappDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings AddIds(this AzureManagedappDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureManagedappDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings AddIds(this AzureManagedappDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureManagedappDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings ClearIds(this AzureManagedappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureManagedappDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings RemoveIds(this AzureManagedappDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureManagedappDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings RemoveIds(this AzureManagedappDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDeleteSettings.Name"/></em></p>
        ///   <p>The name of the managed application.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings SetName(this AzureManagedappDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDeleteSettings.Name"/></em></p>
        ///   <p>The name of the managed application.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings ResetName(this AzureManagedappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings SetResourceGroup(this AzureManagedappDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings ResetResourceGroup(this AzureManagedappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings SetSubscription(this AzureManagedappDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings ResetSubscription(this AzureManagedappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings SetDebug(this AzureManagedappDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings ResetDebug(this AzureManagedappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings SetHelp(this AzureManagedappDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings ResetHelp(this AzureManagedappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings SetOutput(this AzureManagedappDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings ResetOutput(this AzureManagedappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings SetQuery(this AzureManagedappDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings ResetQuery(this AzureManagedappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings SetVerbose(this AzureManagedappDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDeleteSettings ResetVerbose(this AzureManagedappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedappListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedappListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappListSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings SetResourceGroup(this AzureManagedappListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappListSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings ResetResourceGroup(this AzureManagedappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings SetSubscription(this AzureManagedappListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings ResetSubscription(this AzureManagedappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings SetDebug(this AzureManagedappListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings ResetDebug(this AzureManagedappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings SetHelp(this AzureManagedappListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings ResetHelp(this AzureManagedappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings SetOutput(this AzureManagedappListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings ResetOutput(this AzureManagedappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings SetQuery(this AzureManagedappListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings ResetQuery(this AzureManagedappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings SetVerbose(this AzureManagedappListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappListSettings ResetVerbose(this AzureManagedappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedappShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedappShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings SetIds(this AzureManagedappShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings SetIds(this AzureManagedappShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureManagedappShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings AddIds(this AzureManagedappShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureManagedappShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings AddIds(this AzureManagedappShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureManagedappShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings ClearIds(this AzureManagedappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureManagedappShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings RemoveIds(this AzureManagedappShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureManagedappShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings RemoveIds(this AzureManagedappShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappShowSettings.Name"/></em></p>
        ///   <p>The managed application name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings SetName(this AzureManagedappShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappShowSettings.Name"/></em></p>
        ///   <p>The managed application name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings ResetName(this AzureManagedappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappShowSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings SetResourceGroup(this AzureManagedappShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappShowSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings ResetResourceGroup(this AzureManagedappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings SetSubscription(this AzureManagedappShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings ResetSubscription(this AzureManagedappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings SetDebug(this AzureManagedappShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings ResetDebug(this AzureManagedappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings SetHelp(this AzureManagedappShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings ResetHelp(this AzureManagedappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings SetOutput(this AzureManagedappShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings ResetOutput(this AzureManagedappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings SetQuery(this AzureManagedappShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings ResetQuery(this AzureManagedappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings SetVerbose(this AzureManagedappShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappShowSettings ResetVerbose(this AzureManagedappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedappDefinitionCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedappDefinitionCreateSettingsExtensions
    {
        #region Authorizations
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.Authorizations"/> to a new list</em></p>
        ///   <p>Space-separated authorization pairs in a format of &lt;principalId&gt;:&lt;roleDefinitionId&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetAuthorizations(this AzureManagedappDefinitionCreateSettings toolSettings, params string[] authorizations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthorizationsInternal = authorizations.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.Authorizations"/> to a new list</em></p>
        ///   <p>Space-separated authorization pairs in a format of &lt;principalId&gt;:&lt;roleDefinitionId&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetAuthorizations(this AzureManagedappDefinitionCreateSettings toolSettings, IEnumerable<string> authorizations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthorizationsInternal = authorizations.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureManagedappDefinitionCreateSettings.Authorizations"/></em></p>
        ///   <p>Space-separated authorization pairs in a format of &lt;principalId&gt;:&lt;roleDefinitionId&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings AddAuthorizations(this AzureManagedappDefinitionCreateSettings toolSettings, params string[] authorizations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthorizationsInternal.AddRange(authorizations);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureManagedappDefinitionCreateSettings.Authorizations"/></em></p>
        ///   <p>Space-separated authorization pairs in a format of &lt;principalId&gt;:&lt;roleDefinitionId&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings AddAuthorizations(this AzureManagedappDefinitionCreateSettings toolSettings, IEnumerable<string> authorizations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthorizationsInternal.AddRange(authorizations);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureManagedappDefinitionCreateSettings.Authorizations"/></em></p>
        ///   <p>Space-separated authorization pairs in a format of &lt;principalId&gt;:&lt;roleDefinitionId&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ClearAuthorizations(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthorizationsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureManagedappDefinitionCreateSettings.Authorizations"/></em></p>
        ///   <p>Space-separated authorization pairs in a format of &lt;principalId&gt;:&lt;roleDefinitionId&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings RemoveAuthorizations(this AzureManagedappDefinitionCreateSettings toolSettings, params string[] authorizations)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(authorizations);
            toolSettings.AuthorizationsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureManagedappDefinitionCreateSettings.Authorizations"/></em></p>
        ///   <p>Space-separated authorization pairs in a format of &lt;principalId&gt;:&lt;roleDefinitionId&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings RemoveAuthorizations(this AzureManagedappDefinitionCreateSettings toolSettings, IEnumerable<string> authorizations)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(authorizations);
            toolSettings.AuthorizationsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.Description"/></em></p>
        ///   <p>The managed application definition description.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetDescription(this AzureManagedappDefinitionCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.Description"/></em></p>
        ///   <p>The managed application definition description.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetDescription(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.DisplayName"/></em></p>
        ///   <p>The managed application definition display name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetDisplayName(this AzureManagedappDefinitionCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.DisplayName"/></em></p>
        ///   <p>The managed application definition display name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetDisplayName(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region LockLevel
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.LockLevel"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetLockLevel(this AzureManagedappDefinitionCreateSettings toolSettings, ManagedappDefinitionCreateLockLevel lockLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockLevel = lockLevel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.LockLevel"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetLockLevel(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockLevel = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.Name"/></em></p>
        ///   <p>The managed application definition name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetName(this AzureManagedappDefinitionCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.Name"/></em></p>
        ///   <p>The managed application definition name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetName(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetResourceGroup(this AzureManagedappDefinitionCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetResourceGroup(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CreateUiDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.CreateUiDefinition"/></em></p>
        ///   <p>The managed application definition create ui definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetCreateUiDefinition(this AzureManagedappDefinitionCreateSettings toolSettings, string createUiDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateUiDefinition = createUiDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.CreateUiDefinition"/></em></p>
        ///   <p>The managed application definition create ui definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetCreateUiDefinition(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateUiDefinition = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetLocation(this AzureManagedappDefinitionCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetLocation(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region MainTemplate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.MainTemplate"/></em></p>
        ///   <p>The managed application definition main template.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetMainTemplate(this AzureManagedappDefinitionCreateSettings toolSettings, string mainTemplate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MainTemplate = mainTemplate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.MainTemplate"/></em></p>
        ///   <p>The managed application definition main template.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetMainTemplate(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MainTemplate = null;
            return toolSettings;
        }
        #endregion
        #region PackageFileUri
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.PackageFileUri"/></em></p>
        ///   <p>The managed application definition package file uri.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetPackageFileUri(this AzureManagedappDefinitionCreateSettings toolSettings, string packageFileUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PackageFileUri = packageFileUri;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.PackageFileUri"/></em></p>
        ///   <p>The managed application definition package file uri.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetPackageFileUri(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PackageFileUri = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.Tags"/></em></p>
        ///   <p>Tags in 'a=b c' format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetTags(this AzureManagedappDefinitionCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.Tags"/></em></p>
        ///   <p>Tags in 'a=b c' format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetTags(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetSubscription(this AzureManagedappDefinitionCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetSubscription(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetDebug(this AzureManagedappDefinitionCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetDebug(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetHelp(this AzureManagedappDefinitionCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetHelp(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetOutput(this AzureManagedappDefinitionCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetOutput(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetQuery(this AzureManagedappDefinitionCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetQuery(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings SetVerbose(this AzureManagedappDefinitionCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionCreateSettings ResetVerbose(this AzureManagedappDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedappDefinitionDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedappDefinitionDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings SetIds(this AzureManagedappDefinitionDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings SetIds(this AzureManagedappDefinitionDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureManagedappDefinitionDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings AddIds(this AzureManagedappDefinitionDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureManagedappDefinitionDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings AddIds(this AzureManagedappDefinitionDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureManagedappDefinitionDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings ClearIds(this AzureManagedappDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureManagedappDefinitionDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings RemoveIds(this AzureManagedappDefinitionDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureManagedappDefinitionDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings RemoveIds(this AzureManagedappDefinitionDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionDeleteSettings.Name"/></em></p>
        ///   <p>The name of the managed application definition to delete.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings SetName(this AzureManagedappDefinitionDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionDeleteSettings.Name"/></em></p>
        ///   <p>The name of the managed application definition to delete.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings ResetName(this AzureManagedappDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings SetResourceGroup(this AzureManagedappDefinitionDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings ResetResourceGroup(this AzureManagedappDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings SetSubscription(this AzureManagedappDefinitionDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings ResetSubscription(this AzureManagedappDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings SetDebug(this AzureManagedappDefinitionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings ResetDebug(this AzureManagedappDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings SetHelp(this AzureManagedappDefinitionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings ResetHelp(this AzureManagedappDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings SetOutput(this AzureManagedappDefinitionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings ResetOutput(this AzureManagedappDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings SetQuery(this AzureManagedappDefinitionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings ResetQuery(this AzureManagedappDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings SetVerbose(this AzureManagedappDefinitionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionDeleteSettings ResetVerbose(this AzureManagedappDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedappDefinitionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedappDefinitionListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionListSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings SetResourceGroup(this AzureManagedappDefinitionListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionListSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings ResetResourceGroup(this AzureManagedappDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings SetSubscription(this AzureManagedappDefinitionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings ResetSubscription(this AzureManagedappDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings SetDebug(this AzureManagedappDefinitionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings ResetDebug(this AzureManagedappDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings SetHelp(this AzureManagedappDefinitionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings ResetHelp(this AzureManagedappDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings SetOutput(this AzureManagedappDefinitionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings ResetOutput(this AzureManagedappDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings SetQuery(this AzureManagedappDefinitionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings ResetQuery(this AzureManagedappDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings SetVerbose(this AzureManagedappDefinitionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionListSettings ResetVerbose(this AzureManagedappDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureManagedappDefinitionShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureManagedappDefinitionShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings SetIds(this AzureManagedappDefinitionShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings SetIds(this AzureManagedappDefinitionShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureManagedappDefinitionShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings AddIds(this AzureManagedappDefinitionShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureManagedappDefinitionShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings AddIds(this AzureManagedappDefinitionShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureManagedappDefinitionShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings ClearIds(this AzureManagedappDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureManagedappDefinitionShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings RemoveIds(this AzureManagedappDefinitionShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureManagedappDefinitionShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings RemoveIds(this AzureManagedappDefinitionShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionShowSettings.Name"/></em></p>
        ///   <p>The managed application definition name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings SetName(this AzureManagedappDefinitionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionShowSettings.Name"/></em></p>
        ///   <p>The managed application definition name.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings ResetName(this AzureManagedappDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionShowSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings SetResourceGroup(this AzureManagedappDefinitionShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionShowSettings.ResourceGroup"/></em></p>
        ///   <p>The resource group of the managed application definition.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings ResetResourceGroup(this AzureManagedappDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings SetSubscription(this AzureManagedappDefinitionShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings ResetSubscription(this AzureManagedappDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings SetDebug(this AzureManagedappDefinitionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings ResetDebug(this AzureManagedappDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings SetHelp(this AzureManagedappDefinitionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings ResetHelp(this AzureManagedappDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings SetOutput(this AzureManagedappDefinitionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings ResetOutput(this AzureManagedappDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings SetQuery(this AzureManagedappDefinitionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings ResetQuery(this AzureManagedappDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureManagedappDefinitionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings SetVerbose(this AzureManagedappDefinitionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureManagedappDefinitionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureManagedappDefinitionShowSettings ResetVerbose(this AzureManagedappDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region ManagedappDefinitionCreateLockLevel
    /// <summary>
    ///   Used within <see cref="AzureManagedappTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ManagedappDefinitionCreateLockLevel>))]
    public partial class ManagedappDefinitionCreateLockLevel : Enumeration
    {
        public static ManagedappDefinitionCreateLockLevel cannotdelete = new ManagedappDefinitionCreateLockLevel { Value = "cannotdelete" };
        public static ManagedappDefinitionCreateLockLevel none = new ManagedappDefinitionCreateLockLevel { Value = "none" };
        public static ManagedappDefinitionCreateLockLevel readonly_ = new ManagedappDefinitionCreateLockLevel { Value = "readonly" };
    }
    #endregion
}
