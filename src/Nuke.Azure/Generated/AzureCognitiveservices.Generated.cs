// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureCognitiveservices.json
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
    public static partial class AzureCognitiveservicesTasks
    {
        /// <summary>
        ///   Path to the AzureCognitiveservices executable.
        /// </summary>
        public static string AzureCognitiveservicesPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURECOGNITIVESERVICES_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureCognitiveservicesLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Cognitive Services accounts.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCognitiveservices(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureCognitiveservicesPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureCognitiveservicesLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesList(AzureCognitiveservicesListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCognitiveservicesListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesList(Configure<AzureCognitiveservicesListSettings> configurator)
        {
            return AzureCognitiveservicesList(configurator(new AzureCognitiveservicesListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCognitiveservicesListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCognitiveservicesList(CombinatorialConfigure<AzureCognitiveservicesListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCognitiveservicesList, AzureCognitiveservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountCreate(AzureCognitiveservicesAccountCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCognitiveservicesAccountCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api-properties</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.ApiProperties"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Help"/></li>
        ///     <li><c>--kind</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Kind"/></li>
        ///     <li><c>--location</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountCreate(Configure<AzureCognitiveservicesAccountCreateSettings> configurator)
        {
            return AzureCognitiveservicesAccountCreate(configurator(new AzureCognitiveservicesAccountCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api-properties</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.ApiProperties"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Help"/></li>
        ///     <li><c>--kind</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Kind"/></li>
        ///     <li><c>--location</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureCognitiveservicesAccountCreateSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCognitiveservicesAccountCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureCognitiveservicesAccountCreate(CombinatorialConfigure<AzureCognitiveservicesAccountCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCognitiveservicesAccountCreate, AzureCognitiveservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountDelete(AzureCognitiveservicesAccountDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCognitiveservicesAccountDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountDelete(Configure<AzureCognitiveservicesAccountDeleteSettings> configurator)
        {
            return AzureCognitiveservicesAccountDelete(configurator(new AzureCognitiveservicesAccountDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCognitiveservicesAccountDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureCognitiveservicesAccountDelete(CombinatorialConfigure<AzureCognitiveservicesAccountDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCognitiveservicesAccountDelete, AzureCognitiveservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountList(AzureCognitiveservicesAccountListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCognitiveservicesAccountListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountList(Configure<AzureCognitiveservicesAccountListSettings> configurator)
        {
            return AzureCognitiveservicesAccountList(configurator(new AzureCognitiveservicesAccountListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCognitiveservicesAccountListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCognitiveservicesAccountList(CombinatorialConfigure<AzureCognitiveservicesAccountListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCognitiveservicesAccountList, AzureCognitiveservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountListKinds(AzureCognitiveservicesAccountListKindsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCognitiveservicesAccountListKindsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountListKindsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountListKindsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountListKindsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountListKindsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountListKindsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountListKindsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountListKinds(Configure<AzureCognitiveservicesAccountListKindsSettings> configurator)
        {
            return AzureCognitiveservicesAccountListKinds(configurator(new AzureCognitiveservicesAccountListKindsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountListKindsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountListKindsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountListKindsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountListKindsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountListKindsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountListKindsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCognitiveservicesAccountListKindsSettings Settings, IReadOnlyCollection<Output> Output)> AzureCognitiveservicesAccountListKinds(CombinatorialConfigure<AzureCognitiveservicesAccountListKindsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCognitiveservicesAccountListKinds, AzureCognitiveservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountListSkus(AzureCognitiveservicesAccountListSkusSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCognitiveservicesAccountListSkusSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Help"/></li>
        ///     <li><c>--kind</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Kind"/></li>
        ///     <li><c>--location</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountListSkus(Configure<AzureCognitiveservicesAccountListSkusSettings> configurator)
        {
            return AzureCognitiveservicesAccountListSkus(configurator(new AzureCognitiveservicesAccountListSkusSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Help"/></li>
        ///     <li><c>--kind</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Kind"/></li>
        ///     <li><c>--location</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountListSkusSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCognitiveservicesAccountListSkusSettings Settings, IReadOnlyCollection<Output> Output)> AzureCognitiveservicesAccountListSkus(CombinatorialConfigure<AzureCognitiveservicesAccountListSkusSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCognitiveservicesAccountListSkus, AzureCognitiveservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountListUsage(AzureCognitiveservicesAccountListUsageSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCognitiveservicesAccountListUsageSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountListUsage(Configure<AzureCognitiveservicesAccountListUsageSettings> configurator)
        {
            return AzureCognitiveservicesAccountListUsage(configurator(new AzureCognitiveservicesAccountListUsageSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountListUsageSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCognitiveservicesAccountListUsageSettings Settings, IReadOnlyCollection<Output> Output)> AzureCognitiveservicesAccountListUsage(CombinatorialConfigure<AzureCognitiveservicesAccountListUsageSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCognitiveservicesAccountListUsage, AzureCognitiveservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountShow(AzureCognitiveservicesAccountShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCognitiveservicesAccountShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountShow(Configure<AzureCognitiveservicesAccountShowSettings> configurator)
        {
            return AzureCognitiveservicesAccountShow(configurator(new AzureCognitiveservicesAccountShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCognitiveservicesAccountShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureCognitiveservicesAccountShow(CombinatorialConfigure<AzureCognitiveservicesAccountShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCognitiveservicesAccountShow, AzureCognitiveservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountUpdate(AzureCognitiveservicesAccountUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCognitiveservicesAccountUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountUpdate(Configure<AzureCognitiveservicesAccountUpdateSettings> configurator)
        {
            return AzureCognitiveservicesAccountUpdate(configurator(new AzureCognitiveservicesAccountUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCognitiveservicesAccountUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureCognitiveservicesAccountUpdate(CombinatorialConfigure<AzureCognitiveservicesAccountUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCognitiveservicesAccountUpdate, AzureCognitiveservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountKeysList(AzureCognitiveservicesAccountKeysListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCognitiveservicesAccountKeysListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountKeysList(Configure<AzureCognitiveservicesAccountKeysListSettings> configurator)
        {
            return AzureCognitiveservicesAccountKeysList(configurator(new AzureCognitiveservicesAccountKeysListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountKeysListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCognitiveservicesAccountKeysListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCognitiveservicesAccountKeysList(CombinatorialConfigure<AzureCognitiveservicesAccountKeysListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCognitiveservicesAccountKeysList, AzureCognitiveservicesLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountKeysRegenerate(AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCognitiveservicesAccountKeysRegenerateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Help"/></li>
        ///     <li><c>--key-name</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.KeyName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCognitiveservicesAccountKeysRegenerate(Configure<AzureCognitiveservicesAccountKeysRegenerateSettings> configurator)
        {
            return AzureCognitiveservicesAccountKeysRegenerate(configurator(new AzureCognitiveservicesAccountKeysRegenerateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cognitive Services accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Help"/></li>
        ///     <li><c>--key-name</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.KeyName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCognitiveservicesAccountKeysRegenerateSettings Settings, IReadOnlyCollection<Output> Output)> AzureCognitiveservicesAccountKeysRegenerate(CombinatorialConfigure<AzureCognitiveservicesAccountKeysRegenerateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCognitiveservicesAccountKeysRegenerate, AzureCognitiveservicesLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureCognitiveservicesListSettings
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCognitiveservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureCognitiveservicesTasks.AzureCognitiveservicesLogger;
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
              .Add("cognitiveservices list")
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
    #region AzureCognitiveservicesAccountCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCognitiveservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureCognitiveservicesTasks.AzureCognitiveservicesLogger;
        /// <summary>
        ///   The API name of cognitive services account.
        /// </summary>
        public virtual string Kind { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Cognitive service account name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The Sku of cognitive services account.
        /// </summary>
        public virtual string Sku { get; internal set; }
        /// <summary>
        ///   Api properties in JSON format or a=b c=d format. Some cognitive services (i.e. QnA Maker) require extra api properties to create the account.
        /// </summary>
        public virtual string ApiProperties { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   Do not prompt for terms confirmation.
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
              .Add("cognitiveservices account create")
              .Add("--kind {value}", Kind)
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--api-properties {value}", ApiProperties)
              .Add("--tags {value}", Tags)
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
    #region AzureCognitiveservicesAccountDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCognitiveservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureCognitiveservicesTasks.AzureCognitiveservicesLogger;
        /// <summary>
        ///   Cognitive service account name.
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
              .Add("cognitiveservices account delete")
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
    #region AzureCognitiveservicesAccountListSettings
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCognitiveservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureCognitiveservicesTasks.AzureCognitiveservicesLogger;
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
              .Add("cognitiveservices account list")
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
    #region AzureCognitiveservicesAccountListKindsSettings
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountListKindsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCognitiveservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureCognitiveservicesTasks.AzureCognitiveservicesLogger;
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
              .Add("cognitiveservices account list-kinds")
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
    #region AzureCognitiveservicesAccountListSkusSettings
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountListSkusSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCognitiveservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureCognitiveservicesTasks.AzureCognitiveservicesLogger;
        /// <summary>
        ///   The API name of cognitive services account.
        /// </summary>
        public virtual string Kind { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Cognitive service account name.
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
              .Add("cognitiveservices account list-skus")
              .Add("--kind {value}", Kind)
              .Add("--location {value}", Location)
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
    #region AzureCognitiveservicesAccountListUsageSettings
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountListUsageSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCognitiveservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureCognitiveservicesTasks.AzureCognitiveservicesLogger;
        /// <summary>
        ///   Cognitive service account name.
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
              .Add("cognitiveservices account list-usage")
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
    #region AzureCognitiveservicesAccountShowSettings
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCognitiveservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureCognitiveservicesTasks.AzureCognitiveservicesLogger;
        /// <summary>
        ///   Cognitive service account name.
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
              .Add("cognitiveservices account show")
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
    #region AzureCognitiveservicesAccountUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCognitiveservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureCognitiveservicesTasks.AzureCognitiveservicesLogger;
        /// <summary>
        ///   Cognitive service account name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The Sku of cognitive services account.
        /// </summary>
        public virtual string Sku { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
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
              .Add("cognitiveservices account update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
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
    #region AzureCognitiveservicesAccountKeysListSettings
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountKeysListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCognitiveservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureCognitiveservicesTasks.AzureCognitiveservicesLogger;
        /// <summary>
        ///   Cognitive service account name.
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
              .Add("cognitiveservices account keys list")
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
    #region AzureCognitiveservicesAccountKeysRegenerateSettings
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountKeysRegenerateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCognitiveservices executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        public override Action<OutputType, string> CustomLogger => AzureCognitiveservicesTasks.AzureCognitiveservicesLogger;
        /// <summary>
        ///   Key name to generate.
        /// </summary>
        public virtual CognitiveservicesAccountKeysRegenerateKeyName KeyName { get; internal set; }
        /// <summary>
        ///   Cognitive service account name.
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
              .Add("cognitiveservices account keys regenerate")
              .Add("--key-name {value}", KeyName)
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
    #region AzureCognitiveservicesListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings SetResourceGroup(this AzureCognitiveservicesListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings ResetResourceGroup(this AzureCognitiveservicesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings SetSubscription(this AzureCognitiveservicesListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings ResetSubscription(this AzureCognitiveservicesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings SetDebug(this AzureCognitiveservicesListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings ResetDebug(this AzureCognitiveservicesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings SetHelp(this AzureCognitiveservicesListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings ResetHelp(this AzureCognitiveservicesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings SetOutput(this AzureCognitiveservicesListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings ResetOutput(this AzureCognitiveservicesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings SetQuery(this AzureCognitiveservicesListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings ResetQuery(this AzureCognitiveservicesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings SetVerbose(this AzureCognitiveservicesListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesListSettings ResetVerbose(this AzureCognitiveservicesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountCreateSettingsExtensions
    {
        #region Kind
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Kind"/></em></p>
        ///   <p>The API name of cognitive services account.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetKind(this AzureCognitiveservicesAccountCreateSettings toolSettings, string kind)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = kind;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Kind"/></em></p>
        ///   <p>The API name of cognitive services account.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetKind(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetLocation(this AzureCognitiveservicesAccountCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetLocation(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetName(this AzureCognitiveservicesAccountCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetName(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetResourceGroup(this AzureCognitiveservicesAccountCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetResourceGroup(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Sku"/></em></p>
        ///   <p>The Sku of cognitive services account.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetSku(this AzureCognitiveservicesAccountCreateSettings toolSettings, string sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Sku"/></em></p>
        ///   <p>The Sku of cognitive services account.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetSku(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region ApiProperties
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.ApiProperties"/></em></p>
        ///   <p>Api properties in JSON format or a=b c=d format. Some cognitive services (i.e. QnA Maker) require extra api properties to create the account.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetApiProperties(this AzureCognitiveservicesAccountCreateSettings toolSettings, string apiProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiProperties = apiProperties;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.ApiProperties"/></em></p>
        ///   <p>Api properties in JSON format or a=b c=d format. Some cognitive services (i.e. QnA Maker) require extra api properties to create the account.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetApiProperties(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiProperties = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetTags(this AzureCognitiveservicesAccountCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetTags(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Yes"/></em></p>
        ///   <p>Do not prompt for terms confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetYes(this AzureCognitiveservicesAccountCreateSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Yes"/></em></p>
        ///   <p>Do not prompt for terms confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetYes(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetSubscription(this AzureCognitiveservicesAccountCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetSubscription(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetDebug(this AzureCognitiveservicesAccountCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetDebug(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetHelp(this AzureCognitiveservicesAccountCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetHelp(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetOutput(this AzureCognitiveservicesAccountCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetOutput(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetQuery(this AzureCognitiveservicesAccountCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetQuery(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetVerbose(this AzureCognitiveservicesAccountCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetVerbose(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetName(this AzureCognitiveservicesAccountDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetName(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetResourceGroup(this AzureCognitiveservicesAccountDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetResourceGroup(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetSubscription(this AzureCognitiveservicesAccountDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetSubscription(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetDebug(this AzureCognitiveservicesAccountDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetDebug(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetHelp(this AzureCognitiveservicesAccountDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetHelp(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetOutput(this AzureCognitiveservicesAccountDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetOutput(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetQuery(this AzureCognitiveservicesAccountDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetQuery(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetVerbose(this AzureCognitiveservicesAccountDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetVerbose(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings SetResourceGroup(this AzureCognitiveservicesAccountListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings ResetResourceGroup(this AzureCognitiveservicesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings SetSubscription(this AzureCognitiveservicesAccountListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings ResetSubscription(this AzureCognitiveservicesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings SetDebug(this AzureCognitiveservicesAccountListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings ResetDebug(this AzureCognitiveservicesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings SetHelp(this AzureCognitiveservicesAccountListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings ResetHelp(this AzureCognitiveservicesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings SetOutput(this AzureCognitiveservicesAccountListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings ResetOutput(this AzureCognitiveservicesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings SetQuery(this AzureCognitiveservicesAccountListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings ResetQuery(this AzureCognitiveservicesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings SetVerbose(this AzureCognitiveservicesAccountListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSettings ResetVerbose(this AzureCognitiveservicesAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountListKindsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountListKindsSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListKindsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListKindsSettings SetSubscription(this AzureCognitiveservicesAccountListKindsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListKindsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListKindsSettings ResetSubscription(this AzureCognitiveservicesAccountListKindsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListKindsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListKindsSettings SetDebug(this AzureCognitiveservicesAccountListKindsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListKindsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListKindsSettings ResetDebug(this AzureCognitiveservicesAccountListKindsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListKindsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListKindsSettings SetHelp(this AzureCognitiveservicesAccountListKindsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListKindsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListKindsSettings ResetHelp(this AzureCognitiveservicesAccountListKindsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListKindsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListKindsSettings SetOutput(this AzureCognitiveservicesAccountListKindsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListKindsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListKindsSettings ResetOutput(this AzureCognitiveservicesAccountListKindsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListKindsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListKindsSettings SetQuery(this AzureCognitiveservicesAccountListKindsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListKindsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListKindsSettings ResetQuery(this AzureCognitiveservicesAccountListKindsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListKindsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListKindsSettings SetVerbose(this AzureCognitiveservicesAccountListKindsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListKindsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListKindsSettings ResetVerbose(this AzureCognitiveservicesAccountListKindsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountListSkusSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountListSkusSettingsExtensions
    {
        #region Kind
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Kind"/></em></p>
        ///   <p>The API name of cognitive services account.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetKind(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string kind)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = kind;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Kind"/></em></p>
        ///   <p>The API name of cognitive services account.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetKind(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetLocation(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetLocation(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetName(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetName(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetResourceGroup(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetResourceGroup(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetSubscription(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetSubscription(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetDebug(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetDebug(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetHelp(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetHelp(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetOutput(this AzureCognitiveservicesAccountListSkusSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetOutput(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetQuery(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetQuery(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetVerbose(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetVerbose(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountListUsageSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountListUsageSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListUsageSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings SetName(this AzureCognitiveservicesAccountListUsageSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListUsageSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings ResetName(this AzureCognitiveservicesAccountListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListUsageSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings SetResourceGroup(this AzureCognitiveservicesAccountListUsageSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListUsageSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings ResetResourceGroup(this AzureCognitiveservicesAccountListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListUsageSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings SetSubscription(this AzureCognitiveservicesAccountListUsageSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListUsageSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings ResetSubscription(this AzureCognitiveservicesAccountListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListUsageSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings SetDebug(this AzureCognitiveservicesAccountListUsageSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListUsageSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings ResetDebug(this AzureCognitiveservicesAccountListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListUsageSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings SetHelp(this AzureCognitiveservicesAccountListUsageSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListUsageSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings ResetHelp(this AzureCognitiveservicesAccountListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListUsageSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings SetOutput(this AzureCognitiveservicesAccountListUsageSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListUsageSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings ResetOutput(this AzureCognitiveservicesAccountListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListUsageSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings SetQuery(this AzureCognitiveservicesAccountListUsageSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListUsageSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings ResetQuery(this AzureCognitiveservicesAccountListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountListUsageSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings SetVerbose(this AzureCognitiveservicesAccountListUsageSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountListUsageSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountListUsageSettings ResetVerbose(this AzureCognitiveservicesAccountListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetName(this AzureCognitiveservicesAccountShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetName(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetResourceGroup(this AzureCognitiveservicesAccountShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetResourceGroup(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetSubscription(this AzureCognitiveservicesAccountShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetSubscription(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetDebug(this AzureCognitiveservicesAccountShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetDebug(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetHelp(this AzureCognitiveservicesAccountShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetHelp(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetOutput(this AzureCognitiveservicesAccountShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetOutput(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetQuery(this AzureCognitiveservicesAccountShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetQuery(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetVerbose(this AzureCognitiveservicesAccountShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetVerbose(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetName(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetName(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetResourceGroup(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetResourceGroup(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Sku"/></em></p>
        ///   <p>The Sku of cognitive services account.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetSku(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Sku"/></em></p>
        ///   <p>The Sku of cognitive services account.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetSku(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetTags(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetTags(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetSubscription(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetSubscription(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetDebug(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetDebug(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetHelp(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetHelp(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetOutput(this AzureCognitiveservicesAccountUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetOutput(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetQuery(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetQuery(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetVerbose(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetVerbose(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountKeysListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountKeysListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetName(this AzureCognitiveservicesAccountKeysListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetName(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetResourceGroup(this AzureCognitiveservicesAccountKeysListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetResourceGroup(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetSubscription(this AzureCognitiveservicesAccountKeysListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetSubscription(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetDebug(this AzureCognitiveservicesAccountKeysListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetDebug(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetHelp(this AzureCognitiveservicesAccountKeysListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetHelp(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetOutput(this AzureCognitiveservicesAccountKeysListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetOutput(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetQuery(this AzureCognitiveservicesAccountKeysListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetQuery(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetVerbose(this AzureCognitiveservicesAccountKeysListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetVerbose(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountKeysRegenerateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountKeysRegenerateSettingsExtensions
    {
        #region KeyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.KeyName"/></em></p>
        ///   <p>Key name to generate.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetKeyName(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, CognitiveservicesAccountKeysRegenerateKeyName keyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyName = keyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.KeyName"/></em></p>
        ///   <p>Key name to generate.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetKeyName(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetName(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Name"/></em></p>
        ///   <p>Cognitive service account name.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetName(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetResourceGroup(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetResourceGroup(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetSubscription(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetSubscription(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetDebug(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetDebug(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetHelp(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetHelp(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetOutput(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetOutput(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetQuery(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetQuery(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetVerbose(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetVerbose(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region CognitiveservicesAccountKeysRegenerateKeyName
    /// <summary>
    ///   Used within <see cref="AzureCognitiveservicesTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<CognitiveservicesAccountKeysRegenerateKeyName>))]
    public partial class CognitiveservicesAccountKeysRegenerateKeyName : Enumeration
    {
        public static CognitiveservicesAccountKeysRegenerateKeyName key1 = new CognitiveservicesAccountKeysRegenerateKeyName { Value = "key1" };
        public static CognitiveservicesAccountKeysRegenerateKeyName key2 = new CognitiveservicesAccountKeysRegenerateKeyName { Value = "key2" };
    }
    #endregion
}
