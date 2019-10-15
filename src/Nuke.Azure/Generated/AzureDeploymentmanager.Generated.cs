// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureDeploymentmanager.json
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
    public static partial class AzureDeploymentmanagerTasks
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public static string AzureDeploymentmanagerPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREDEPLOYMENTMANAGER_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureDeploymentmanagerLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Create and manage rollouts for your service.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanager(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureDeploymentmanagerPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureDeploymentmanagerLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanager(AzureDeploymentmanagerSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanager(Configure<AzureDeploymentmanagerSettings> configurator)
        {
            return AzureDeploymentmanager(configurator(new AzureDeploymentmanagerSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanager(CombinatorialConfigure<AzureDeploymentmanagerSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanager, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerArtifactSourceCreate(AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerArtifactSourceCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--artifact-root</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.ArtifactRoot"/></li>
        ///     <li><c>--artifact-source-name</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.ArtifactSourceName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sas-uri</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.SasUri"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerArtifactSourceCreate(Configure<AzureDeploymentmanagerArtifactSourceCreateSettings> configurator)
        {
            return AzureDeploymentmanagerArtifactSourceCreate(configurator(new AzureDeploymentmanagerArtifactSourceCreateSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--artifact-root</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.ArtifactRoot"/></li>
        ///     <li><c>--artifact-source-name</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.ArtifactSourceName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sas-uri</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.SasUri"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerArtifactSourceCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerArtifactSourceCreate(CombinatorialConfigure<AzureDeploymentmanagerArtifactSourceCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerArtifactSourceCreate, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerArtifactSourceDelete(AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerArtifactSourceDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--artifact-source-name</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.ArtifactSourceName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerArtifactSourceDelete(Configure<AzureDeploymentmanagerArtifactSourceDeleteSettings> configurator)
        {
            return AzureDeploymentmanagerArtifactSourceDelete(configurator(new AzureDeploymentmanagerArtifactSourceDeleteSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--artifact-source-name</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.ArtifactSourceName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerArtifactSourceDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerArtifactSourceDelete(CombinatorialConfigure<AzureDeploymentmanagerArtifactSourceDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerArtifactSourceDelete, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerArtifactSourceShow(AzureDeploymentmanagerArtifactSourceShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerArtifactSourceShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--artifact-source-name</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.ArtifactSourceName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerArtifactSourceShow(Configure<AzureDeploymentmanagerArtifactSourceShowSettings> configurator)
        {
            return AzureDeploymentmanagerArtifactSourceShow(configurator(new AzureDeploymentmanagerArtifactSourceShowSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--artifact-source-name</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.ArtifactSourceName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerArtifactSourceShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerArtifactSourceShow(CombinatorialConfigure<AzureDeploymentmanagerArtifactSourceShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerArtifactSourceShow, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerArtifactSourceUpdate(AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerArtifactSourceUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Add"/></li>
        ///     <li><c>--artifact-root</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ArtifactRoot"/></li>
        ///     <li><c>--artifact-source-name</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ArtifactSourceName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--sas-uri</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.SasUri"/></li>
        ///     <li><c>--set</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerArtifactSourceUpdate(Configure<AzureDeploymentmanagerArtifactSourceUpdateSettings> configurator)
        {
            return AzureDeploymentmanagerArtifactSourceUpdate(configurator(new AzureDeploymentmanagerArtifactSourceUpdateSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Add"/></li>
        ///     <li><c>--artifact-root</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ArtifactRoot"/></li>
        ///     <li><c>--artifact-source-name</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ArtifactSourceName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--sas-uri</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.SasUri"/></li>
        ///     <li><c>--set</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerArtifactSourceUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerArtifactSourceUpdate(CombinatorialConfigure<AzureDeploymentmanagerArtifactSourceUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerArtifactSourceUpdate, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerRolloutDelete(AzureDeploymentmanagerRolloutDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerRolloutDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerRolloutDelete(Configure<AzureDeploymentmanagerRolloutDeleteSettings> configurator)
        {
            return AzureDeploymentmanagerRolloutDelete(configurator(new AzureDeploymentmanagerRolloutDeleteSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerRolloutDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerRolloutDelete(CombinatorialConfigure<AzureDeploymentmanagerRolloutDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerRolloutDelete, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerRolloutRestart(AzureDeploymentmanagerRolloutRestartSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerRolloutRestartSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.ResourceGroup"/></li>
        ///     <li><c>--skip-succeeded</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.SkipSucceeded"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerRolloutRestart(Configure<AzureDeploymentmanagerRolloutRestartSettings> configurator)
        {
            return AzureDeploymentmanagerRolloutRestart(configurator(new AzureDeploymentmanagerRolloutRestartSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.ResourceGroup"/></li>
        ///     <li><c>--skip-succeeded</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.SkipSucceeded"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDeploymentmanagerRolloutRestartSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerRolloutRestartSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerRolloutRestart(CombinatorialConfigure<AzureDeploymentmanagerRolloutRestartSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerRolloutRestart, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerRolloutShow(AzureDeploymentmanagerRolloutShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerRolloutShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.ResourceGroup"/></li>
        ///     <li><c>--retry-attempt</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.RetryAttempt"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerRolloutShow(Configure<AzureDeploymentmanagerRolloutShowSettings> configurator)
        {
            return AzureDeploymentmanagerRolloutShow(configurator(new AzureDeploymentmanagerRolloutShowSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.ResourceGroup"/></li>
        ///     <li><c>--retry-attempt</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.RetryAttempt"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerRolloutShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerRolloutShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerRolloutShow(CombinatorialConfigure<AzureDeploymentmanagerRolloutShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerRolloutShow, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerRolloutStop(AzureDeploymentmanagerRolloutStopSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerRolloutStopSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerRolloutStop(Configure<AzureDeploymentmanagerRolloutStopSettings> configurator)
        {
            return AzureDeploymentmanagerRolloutStop(configurator(new AzureDeploymentmanagerRolloutStopSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureDeploymentmanagerRolloutStopSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerRolloutStopSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerRolloutStop(CombinatorialConfigure<AzureDeploymentmanagerRolloutStopSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerRolloutStop, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceCreate(AzureDeploymentmanagerServiceCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerServiceCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.ServiceTopologyName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Tags"/></li>
        ///     <li><c>--target-location</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.TargetLocation"/></li>
        ///     <li><c>--target-subscription-id</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.TargetSubscriptionId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceCreate(Configure<AzureDeploymentmanagerServiceCreateSettings> configurator)
        {
            return AzureDeploymentmanagerServiceCreate(configurator(new AzureDeploymentmanagerServiceCreateSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.ServiceTopologyName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Tags"/></li>
        ///     <li><c>--target-location</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.TargetLocation"/></li>
        ///     <li><c>--target-subscription-id</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.TargetSubscriptionId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerServiceCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerServiceCreate(CombinatorialConfigure<AzureDeploymentmanagerServiceCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerServiceCreate, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceDelete(AzureDeploymentmanagerServiceDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerServiceDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.ServiceTopologyName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceDelete(Configure<AzureDeploymentmanagerServiceDeleteSettings> configurator)
        {
            return AzureDeploymentmanagerServiceDelete(configurator(new AzureDeploymentmanagerServiceDeleteSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.ServiceTopologyName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerServiceDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerServiceDelete(CombinatorialConfigure<AzureDeploymentmanagerServiceDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerServiceDelete, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceShow(AzureDeploymentmanagerServiceShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerServiceShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.ResourceGroup"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.ServiceTopologyName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceShow(Configure<AzureDeploymentmanagerServiceShowSettings> configurator)
        {
            return AzureDeploymentmanagerServiceShow(configurator(new AzureDeploymentmanagerServiceShowSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.ResourceGroup"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.ServiceTopologyName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerServiceShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerServiceShow(CombinatorialConfigure<AzureDeploymentmanagerServiceShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerServiceShow, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceUpdate(AzureDeploymentmanagerServiceUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerServiceUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.ServiceTopologyName"/></li>
        ///     <li><c>--set</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Tags"/></li>
        ///     <li><c>--target-location</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.TargetLocation"/></li>
        ///     <li><c>--target-subscription-id</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.TargetSubscriptionId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceUpdate(Configure<AzureDeploymentmanagerServiceUpdateSettings> configurator)
        {
            return AzureDeploymentmanagerServiceUpdate(configurator(new AzureDeploymentmanagerServiceUpdateSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.ServiceTopologyName"/></li>
        ///     <li><c>--set</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Tags"/></li>
        ///     <li><c>--target-location</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.TargetLocation"/></li>
        ///     <li><c>--target-subscription-id</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.TargetSubscriptionId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerServiceUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerServiceUpdate(CombinatorialConfigure<AzureDeploymentmanagerServiceUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerServiceUpdate, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerStepCreate(AzureDeploymentmanagerStepCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerStepCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Debug"/></li>
        ///     <li><c>--duration</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Duration"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerStepCreate(Configure<AzureDeploymentmanagerStepCreateSettings> configurator)
        {
            return AzureDeploymentmanagerStepCreate(configurator(new AzureDeploymentmanagerStepCreateSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Debug"/></li>
        ///     <li><c>--duration</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Duration"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerStepCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerStepCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerStepCreate(CombinatorialConfigure<AzureDeploymentmanagerStepCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerStepCreate, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerStepDelete(AzureDeploymentmanagerStepDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerStepDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerStepDelete(Configure<AzureDeploymentmanagerStepDeleteSettings> configurator)
        {
            return AzureDeploymentmanagerStepDelete(configurator(new AzureDeploymentmanagerStepDeleteSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerStepDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerStepDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerStepDelete(CombinatorialConfigure<AzureDeploymentmanagerStepDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerStepDelete, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerStepShow(AzureDeploymentmanagerStepShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerStepShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerStepShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerStepShow(Configure<AzureDeploymentmanagerStepShowSettings> configurator)
        {
            return AzureDeploymentmanagerStepShow(configurator(new AzureDeploymentmanagerStepShowSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerStepShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerStepShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerStepShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerStepShow(CombinatorialConfigure<AzureDeploymentmanagerStepShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerStepShow, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerStepUpdate(AzureDeploymentmanagerStepUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerStepUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Debug"/></li>
        ///     <li><c>--duration</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Duration"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerStepUpdate(Configure<AzureDeploymentmanagerStepUpdateSettings> configurator)
        {
            return AzureDeploymentmanagerStepUpdate(configurator(new AzureDeploymentmanagerStepUpdateSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Debug"/></li>
        ///     <li><c>--duration</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Duration"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerStepUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerStepUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerStepUpdate(CombinatorialConfigure<AzureDeploymentmanagerStepUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerStepUpdate, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceUnitCreate(AzureDeploymentmanagerServiceUnitCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerServiceUnitCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Debug"/></li>
        ///     <li><c>--deployment-mode</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.DeploymentMode"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Output"/></li>
        ///     <li><c>--parameters-path</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ParametersPath"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ServiceName"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ServiceTopologyName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Tags"/></li>
        ///     <li><c>--target-resource-group</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.TargetResourceGroup"/></li>
        ///     <li><c>--template-path</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.TemplatePath"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceUnitCreate(Configure<AzureDeploymentmanagerServiceUnitCreateSettings> configurator)
        {
            return AzureDeploymentmanagerServiceUnitCreate(configurator(new AzureDeploymentmanagerServiceUnitCreateSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Debug"/></li>
        ///     <li><c>--deployment-mode</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.DeploymentMode"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Output"/></li>
        ///     <li><c>--parameters-path</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ParametersPath"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ServiceName"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ServiceTopologyName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Tags"/></li>
        ///     <li><c>--target-resource-group</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.TargetResourceGroup"/></li>
        ///     <li><c>--template-path</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.TemplatePath"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerServiceUnitCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerServiceUnitCreate(CombinatorialConfigure<AzureDeploymentmanagerServiceUnitCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerServiceUnitCreate, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceUnitDelete(AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerServiceUnitDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.ServiceName"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.ServiceTopologyName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceUnitDelete(Configure<AzureDeploymentmanagerServiceUnitDeleteSettings> configurator)
        {
            return AzureDeploymentmanagerServiceUnitDelete(configurator(new AzureDeploymentmanagerServiceUnitDeleteSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.ServiceName"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.ServiceTopologyName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerServiceUnitDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerServiceUnitDelete(CombinatorialConfigure<AzureDeploymentmanagerServiceUnitDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerServiceUnitDelete, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceUnitShow(AzureDeploymentmanagerServiceUnitShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerServiceUnitShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.ServiceName"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.ServiceTopologyName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceUnitShow(Configure<AzureDeploymentmanagerServiceUnitShowSettings> configurator)
        {
            return AzureDeploymentmanagerServiceUnitShow(configurator(new AzureDeploymentmanagerServiceUnitShowSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.ServiceName"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.ServiceTopologyName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerServiceUnitShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerServiceUnitShow(CombinatorialConfigure<AzureDeploymentmanagerServiceUnitShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerServiceUnitShow, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceUnitUpdate(AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerServiceUnitUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Debug"/></li>
        ///     <li><c>--deployment-mode</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.DeploymentMode"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Output"/></li>
        ///     <li><c>--parameters-path</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ParametersPath"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ServiceName"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ServiceTopologyName"/></li>
        ///     <li><c>--set</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Tags"/></li>
        ///     <li><c>--target-resource-group</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.TargetResourceGroup"/></li>
        ///     <li><c>--template-path</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.TemplatePath"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceUnitUpdate(Configure<AzureDeploymentmanagerServiceUnitUpdateSettings> configurator)
        {
            return AzureDeploymentmanagerServiceUnitUpdate(configurator(new AzureDeploymentmanagerServiceUnitUpdateSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Debug"/></li>
        ///     <li><c>--deployment-mode</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.DeploymentMode"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Output"/></li>
        ///     <li><c>--parameters-path</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ParametersPath"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-name</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ServiceName"/></li>
        ///     <li><c>--service-topology-name</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ServiceTopologyName"/></li>
        ///     <li><c>--set</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Tags"/></li>
        ///     <li><c>--target-resource-group</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.TargetResourceGroup"/></li>
        ///     <li><c>--template-path</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.TemplatePath"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerServiceUnitUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerServiceUnitUpdate(CombinatorialConfigure<AzureDeploymentmanagerServiceUnitUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerServiceUnitUpdate, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceTopologyCreate(AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerServiceTopologyCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--artifact-source</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.ArtifactSource"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceTopologyCreate(Configure<AzureDeploymentmanagerServiceTopologyCreateSettings> configurator)
        {
            return AzureDeploymentmanagerServiceTopologyCreate(configurator(new AzureDeploymentmanagerServiceTopologyCreateSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--artifact-source</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.ArtifactSource"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerServiceTopologyCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerServiceTopologyCreate(CombinatorialConfigure<AzureDeploymentmanagerServiceTopologyCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerServiceTopologyCreate, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceTopologyDelete(AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerServiceTopologyDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceTopologyDelete(Configure<AzureDeploymentmanagerServiceTopologyDeleteSettings> configurator)
        {
            return AzureDeploymentmanagerServiceTopologyDelete(configurator(new AzureDeploymentmanagerServiceTopologyDeleteSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerServiceTopologyDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerServiceTopologyDelete(CombinatorialConfigure<AzureDeploymentmanagerServiceTopologyDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerServiceTopologyDelete, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceTopologyShow(AzureDeploymentmanagerServiceTopologyShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerServiceTopologyShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceTopologyShow(Configure<AzureDeploymentmanagerServiceTopologyShowSettings> configurator)
        {
            return AzureDeploymentmanagerServiceTopologyShow(configurator(new AzureDeploymentmanagerServiceTopologyShowSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerServiceTopologyShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerServiceTopologyShow(CombinatorialConfigure<AzureDeploymentmanagerServiceTopologyShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerServiceTopologyShow, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceTopologyUpdate(AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureDeploymentmanagerServiceTopologyUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Add"/></li>
        ///     <li><c>--artifact-source</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.ArtifactSource"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureDeploymentmanagerServiceTopologyUpdate(Configure<AzureDeploymentmanagerServiceTopologyUpdateSettings> configurator)
        {
            return AzureDeploymentmanagerServiceTopologyUpdate(configurator(new AzureDeploymentmanagerServiceTopologyUpdateSettings()));
        }
        /// <summary>
        ///   <p>Create and manage rollouts for your service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deploymentmanager?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Add"/></li>
        ///     <li><c>--artifact-source</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.ArtifactSource"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureDeploymentmanagerServiceTopologyUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureDeploymentmanagerServiceTopologyUpdate(CombinatorialConfigure<AzureDeploymentmanagerServiceTopologyUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureDeploymentmanagerServiceTopologyUpdate, AzureDeploymentmanagerLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureDeploymentmanagerSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
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
              .Add("deploymentmanager")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureDeploymentmanagerArtifactSourceCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerArtifactSourceCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the artifact source.
        /// </summary>
        public virtual string ArtifactSourceName { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The SAS Uri to the Azure Storage container where the artifacts are stored.
        /// </summary>
        public virtual string SasUri { get; internal set; }
        /// <summary>
        ///   The root folder under which the artifacts are to be found. This is the path relative to the Azure storage container provided in --sas-uri.
        /// </summary>
        public virtual string ArtifactRoot { get; internal set; }
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
              .Add("deploymentmanager artifact-source create")
              .Add("--artifact-source-name {value}", ArtifactSourceName)
              .Add("--location {value}", Location)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sas-uri {value}", SasUri)
              .Add("--artifact-root {value}", ArtifactRoot)
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
    #region AzureDeploymentmanagerArtifactSourceDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerArtifactSourceDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the artifact source.
        /// </summary>
        public virtual string ArtifactSourceName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("deploymentmanager artifact-source delete")
              .Add("--artifact-source-name {value}", ArtifactSourceName)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureDeploymentmanagerArtifactSourceShowSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerArtifactSourceShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the artifact source.
        /// </summary>
        public virtual string ArtifactSourceName { get; internal set; }
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
              .Add("deploymentmanager artifact-source show")
              .Add("--artifact-source-name {value}", ArtifactSourceName)
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
    #region AzureDeploymentmanagerArtifactSourceUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerArtifactSourceUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the artifact source.
        /// </summary>
        public virtual string ArtifactSourceName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The root folder under which the artifacts are to be found. This is the path relative to the Azure storage container provided in --sas-uri.
        /// </summary>
        public virtual string ArtifactRoot { get; internal set; }
        /// <summary>
        ///   The SAS Uri to the Azure Storage container where the artifacts are stored.
        /// </summary>
        public virtual string SasUri { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
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
              .Add("deploymentmanager artifact-source update")
              .Add("--artifact-source-name {value}", ArtifactSourceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--artifact-root {value}", ArtifactRoot)
              .Add("--sas-uri {value}", SasUri)
              .Add("--tags {value}", Tags)
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
    #region AzureDeploymentmanagerRolloutDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerRolloutDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the rollout.
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
              .Add("deploymentmanager rollout delete")
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
    #region AzureDeploymentmanagerRolloutRestartSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerRolloutRestartSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the rollout.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Skips all the steps that have succeeded in the previous retries of this rollout.
        /// </summary>
        public virtual string SkipSucceeded { get; internal set; }
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
              .Add("deploymentmanager rollout restart")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--skip-succeeded {value}", SkipSucceeded)
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
    #region AzureDeploymentmanagerRolloutShowSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerRolloutShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the rollout.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Rollout retry attempt ordinal to get the result of. If not specified, result of the latest attempt will be returned.
        /// </summary>
        public virtual string RetryAttempt { get; internal set; }
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
              .Add("deploymentmanager rollout show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--retry-attempt {value}", RetryAttempt)
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
    #region AzureDeploymentmanagerRolloutStopSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerRolloutStopSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the rollout.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("deploymentmanager rollout stop")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureDeploymentmanagerServiceCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerServiceCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The name of the service.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the service topology.
        /// </summary>
        public virtual string ServiceTopologyName { get; internal set; }
        /// <summary>
        ///   The location where the resources in the service should be deployed to.
        /// </summary>
        public virtual string TargetLocation { get; internal set; }
        /// <summary>
        ///   The subscription to which the resources in the service should be deployed to.
        /// </summary>
        public virtual string TargetSubscriptionId { get; internal set; }
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
              .Add("deploymentmanager service create")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-topology-name {value}", ServiceTopologyName)
              .Add("--target-location {value}", TargetLocation)
              .Add("--target-subscription-id {value}", TargetSubscriptionId)
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
    #region AzureDeploymentmanagerServiceDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerServiceDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the service.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the service topology.
        /// </summary>
        public virtual string ServiceTopologyName { get; internal set; }
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
              .Add("deploymentmanager service delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-topology-name {value}", ServiceTopologyName)
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
    #region AzureDeploymentmanagerServiceShowSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerServiceShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the service.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the service topology.
        /// </summary>
        public virtual string ServiceTopologyName { get; internal set; }
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
              .Add("deploymentmanager service show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-topology-name {value}", ServiceTopologyName)
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
    #region AzureDeploymentmanagerServiceUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerServiceUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the service.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the service topology.
        /// </summary>
        public virtual string ServiceTopologyName { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   The location where the resources in the service should be deployed to.
        /// </summary>
        public virtual string TargetLocation { get; internal set; }
        /// <summary>
        ///   The subscription to which the resources in the service should be deployed to.
        /// </summary>
        public virtual string TargetSubscriptionId { get; internal set; }
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
              .Add("deploymentmanager service update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-topology-name {value}", ServiceTopologyName)
              .Add("--tags {value}", Tags)
              .Add("--target-location {value}", TargetLocation)
              .Add("--target-subscription-id {value}", TargetSubscriptionId)
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
    #region AzureDeploymentmanagerStepCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerStepCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The duration of the wait step in ISO 8601 format.
        /// </summary>
        public virtual string Duration { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The name of the step.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("deploymentmanager step create")
              .Add("--duration {value}", Duration)
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureDeploymentmanagerStepDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerStepDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the step.
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
              .Add("deploymentmanager step delete")
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
    #region AzureDeploymentmanagerStepShowSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerStepShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the step.
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
              .Add("deploymentmanager step show")
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
    #region AzureDeploymentmanagerStepUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerStepUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The duration of the wait step in ISO 8601 format.
        /// </summary>
        public virtual string Duration { get; internal set; }
        /// <summary>
        ///   The name of the step.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
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
              .Add("deploymentmanager step update")
              .Add("--duration {value}", Duration)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--tags {value}", Tags)
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
    #region AzureDeploymentmanagerServiceUnitCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerServiceUnitCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The path to the ARM parameters file. Either the full SAS Uri or the relative path in the artifact source for this topology.
        /// </summary>
        public virtual string ParametersPath { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The path to the ARM template file. Either the full SAS Uri or the relative path in the artifact source for this topology.
        /// </summary>
        public virtual string TemplatePath { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The type of depoyment mode to be used when deploying the service unit. Possible values: Incremental, Complete.
        /// </summary>
        public virtual DeploymentmanagerServiceUnitDeploymentMode DeploymentMode { get; internal set; }
        /// <summary>
        ///   The name of the service unit.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The name of the service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
        /// <summary>
        ///   The name of the service topology.
        /// </summary>
        public virtual string ServiceTopologyName { get; internal set; }
        /// <summary>
        ///   The resource group where the resources in the service unit should be deployed to.
        /// </summary>
        public virtual string TargetResourceGroup { get; internal set; }
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
              .Add("deploymentmanager service-unit create")
              .Add("--parameters-path {value}", ParametersPath)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--template-path {value}", TemplatePath)
              .Add("--location {value}", Location)
              .Add("--deployment-mode {value}", DeploymentMode)
              .Add("--name {value}", Name)
              .Add("--service-name {value}", ServiceName)
              .Add("--service-topology-name {value}", ServiceTopologyName)
              .Add("--target-resource-group {value}", TargetResourceGroup)
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
    #region AzureDeploymentmanagerServiceUnitDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerServiceUnitDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the service unit.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
        /// <summary>
        ///   The name of the service topology.
        /// </summary>
        public virtual string ServiceTopologyName { get; internal set; }
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
              .Add("deploymentmanager service-unit delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
              .Add("--service-topology-name {value}", ServiceTopologyName)
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
    #region AzureDeploymentmanagerServiceUnitShowSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerServiceUnitShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the service unit.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
        /// <summary>
        ///   The name of the service topology.
        /// </summary>
        public virtual string ServiceTopologyName { get; internal set; }
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
              .Add("deploymentmanager service-unit show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
              .Add("--service-topology-name {value}", ServiceTopologyName)
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
    #region AzureDeploymentmanagerServiceUnitUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerServiceUnitUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the service unit.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the service.
        /// </summary>
        public virtual string ServiceName { get; internal set; }
        /// <summary>
        ///   The name of the service topology.
        /// </summary>
        public virtual string ServiceTopologyName { get; internal set; }
        /// <summary>
        ///   The type of depoyment mode to be used when deploying the service unit. Possible values: Incremental, Complete.
        /// </summary>
        public virtual DeploymentmanagerServiceUnitDeploymentMode DeploymentMode { get; internal set; }
        /// <summary>
        ///   The path to the ARM parameters file. Either the full SAS Uri or the relative path in the artifact source for this topology.
        /// </summary>
        public virtual string ParametersPath { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   The resource group where the resources in the service unit should be deployed to.
        /// </summary>
        public virtual string TargetResourceGroup { get; internal set; }
        /// <summary>
        ///   The path to the ARM template file. Either the full SAS Uri or the relative path in the artifact source for this topology.
        /// </summary>
        public virtual string TemplatePath { get; internal set; }
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
              .Add("deploymentmanager service-unit update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service-name {value}", ServiceName)
              .Add("--service-topology-name {value}", ServiceTopologyName)
              .Add("--deployment-mode {value}", DeploymentMode)
              .Add("--parameters-path {value}", ParametersPath)
              .Add("--tags {value}", Tags)
              .Add("--target-resource-group {value}", TargetResourceGroup)
              .Add("--template-path {value}", TemplatePath)
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
    #region AzureDeploymentmanagerServiceTopologyCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerServiceTopologyCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The name of the service topology.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name or resource identifier of the artifact source.
        /// </summary>
        public virtual string ArtifactSource { get; internal set; }
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
              .Add("deploymentmanager service-topology create")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--artifact-source {value}", ArtifactSource)
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
    #region AzureDeploymentmanagerServiceTopologyDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerServiceTopologyDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the service topology.
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
              .Add("deploymentmanager service-topology delete")
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
    #region AzureDeploymentmanagerServiceTopologyShowSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerServiceTopologyShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the service topology.
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
              .Add("deploymentmanager service-topology show")
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
    #region AzureDeploymentmanagerServiceTopologyUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentmanagerServiceTopologyUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureDeploymentmanager executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentmanagerTasks.AzureDeploymentmanagerPath;
        public override Action<OutputType, string> CustomLogger => AzureDeploymentmanagerTasks.AzureDeploymentmanagerLogger;
        /// <summary>
        ///   The name of the service topology.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name or resource identifier of the artifact source.
        /// </summary>
        public virtual string ArtifactSource { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
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
              .Add("deploymentmanager service-topology update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--artifact-source {value}", ArtifactSource)
              .Add("--tags {value}", Tags)
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
    #region AzureDeploymentmanagerSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerSettings SetDebug(this AzureDeploymentmanagerSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerSettings ResetDebug(this AzureDeploymentmanagerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerSettings SetHelp(this AzureDeploymentmanagerSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerSettings ResetHelp(this AzureDeploymentmanagerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerSettings SetOutput(this AzureDeploymentmanagerSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerSettings ResetOutput(this AzureDeploymentmanagerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerSettings SetQuery(this AzureDeploymentmanagerSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerSettings ResetQuery(this AzureDeploymentmanagerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerSettings SetVerbose(this AzureDeploymentmanagerSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerSettings ResetVerbose(this AzureDeploymentmanagerSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerArtifactSourceCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerArtifactSourceCreateSettingsExtensions
    {
        #region ArtifactSourceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.ArtifactSourceName"/></em></p>
        ///   <p>The name of the artifact source.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings SetArtifactSourceName(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings, string artifactSourceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = artifactSourceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.ArtifactSourceName"/></em></p>
        ///   <p>The name of the artifact source.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings ResetArtifactSourceName(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings SetLocation(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings ResetLocation(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings SetResourceGroup(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings ResetResourceGroup(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SasUri
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.SasUri"/></em></p>
        ///   <p>The SAS Uri to the Azure Storage container where the artifacts are stored.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings SetSasUri(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings, string sasUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SasUri = sasUri;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.SasUri"/></em></p>
        ///   <p>The SAS Uri to the Azure Storage container where the artifacts are stored.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings ResetSasUri(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SasUri = null;
            return toolSettings;
        }
        #endregion
        #region ArtifactRoot
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.ArtifactRoot"/></em></p>
        ///   <p>The root folder under which the artifacts are to be found. This is the path relative to the Azure storage container provided in --sas-uri.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings SetArtifactRoot(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings, string artifactRoot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactRoot = artifactRoot;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.ArtifactRoot"/></em></p>
        ///   <p>The root folder under which the artifacts are to be found. This is the path relative to the Azure storage container provided in --sas-uri.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings ResetArtifactRoot(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactRoot = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings SetTags(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings ResetTags(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings SetSubscription(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings ResetSubscription(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings SetDebug(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings ResetDebug(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings SetHelp(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings ResetHelp(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings SetOutput(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings ResetOutput(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings SetQuery(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings ResetQuery(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings SetVerbose(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceCreateSettings ResetVerbose(this AzureDeploymentmanagerArtifactSourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerArtifactSourceDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerArtifactSourceDeleteSettingsExtensions
    {
        #region ArtifactSourceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.ArtifactSourceName"/></em></p>
        ///   <p>The name of the artifact source.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings SetArtifactSourceName(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings, string artifactSourceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = artifactSourceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.ArtifactSourceName"/></em></p>
        ///   <p>The name of the artifact source.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings ResetArtifactSourceName(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings SetResourceGroup(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings ResetResourceGroup(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings SetYes(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings ResetYes(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings SetSubscription(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings ResetSubscription(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings SetDebug(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings ResetDebug(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings SetHelp(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings ResetHelp(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings SetOutput(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings ResetOutput(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings SetQuery(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings ResetQuery(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings SetVerbose(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceDeleteSettings ResetVerbose(this AzureDeploymentmanagerArtifactSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerArtifactSourceShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerArtifactSourceShowSettingsExtensions
    {
        #region ArtifactSourceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.ArtifactSourceName"/></em></p>
        ///   <p>The name of the artifact source.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings SetArtifactSourceName(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings, string artifactSourceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = artifactSourceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.ArtifactSourceName"/></em></p>
        ///   <p>The name of the artifact source.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings ResetArtifactSourceName(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings SetResourceGroup(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings ResetResourceGroup(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings SetSubscription(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings ResetSubscription(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings SetDebug(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings ResetDebug(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings SetHelp(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings ResetHelp(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings SetOutput(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings ResetOutput(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings SetQuery(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings ResetQuery(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings SetVerbose(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceShowSettings ResetVerbose(this AzureDeploymentmanagerArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerArtifactSourceUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerArtifactSourceUpdateSettingsExtensions
    {
        #region ArtifactSourceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ArtifactSourceName"/></em></p>
        ///   <p>The name of the artifact source.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetArtifactSourceName(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string artifactSourceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = artifactSourceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ArtifactSourceName"/></em></p>
        ///   <p>The name of the artifact source.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetArtifactSourceName(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetResourceGroup(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetResourceGroup(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ArtifactRoot
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ArtifactRoot"/></em></p>
        ///   <p>The root folder under which the artifacts are to be found. This is the path relative to the Azure storage container provided in --sas-uri.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetArtifactRoot(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string artifactRoot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactRoot = artifactRoot;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ArtifactRoot"/></em></p>
        ///   <p>The root folder under which the artifacts are to be found. This is the path relative to the Azure storage container provided in --sas-uri.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetArtifactRoot(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactRoot = null;
            return toolSettings;
        }
        #endregion
        #region SasUri
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.SasUri"/></em></p>
        ///   <p>The SAS Uri to the Azure Storage container where the artifacts are stored.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetSasUri(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string sasUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SasUri = sasUri;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.SasUri"/></em></p>
        ///   <p>The SAS Uri to the Azure Storage container where the artifacts are stored.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetSasUri(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SasUri = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetTags(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetTags(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetAdd(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetAdd(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetForceString(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetForceString(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetRemove(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetRemove(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetSet(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetSet(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetSubscription(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetSubscription(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetDebug(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetDebug(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetHelp(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetHelp(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetOutput(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetOutput(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetQuery(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetQuery(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings SetVerbose(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerArtifactSourceUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerArtifactSourceUpdateSettings ResetVerbose(this AzureDeploymentmanagerArtifactSourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerRolloutDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerRolloutDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Name"/></em></p>
        ///   <p>The name of the rollout.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings SetName(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Name"/></em></p>
        ///   <p>The name of the rollout.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings ResetName(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings SetResourceGroup(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings ResetResourceGroup(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings SetSubscription(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings ResetSubscription(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings SetDebug(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings ResetDebug(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings SetHelp(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings ResetHelp(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings SetOutput(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings ResetOutput(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings SetQuery(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings ResetQuery(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings SetVerbose(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutDeleteSettings ResetVerbose(this AzureDeploymentmanagerRolloutDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerRolloutRestartSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerRolloutRestartSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Name"/></em></p>
        ///   <p>The name of the rollout.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings SetName(this AzureDeploymentmanagerRolloutRestartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Name"/></em></p>
        ///   <p>The name of the rollout.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings ResetName(this AzureDeploymentmanagerRolloutRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutRestartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings SetResourceGroup(this AzureDeploymentmanagerRolloutRestartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutRestartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings ResetResourceGroup(this AzureDeploymentmanagerRolloutRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SkipSucceeded
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutRestartSettings.SkipSucceeded"/></em></p>
        ///   <p>Skips all the steps that have succeeded in the previous retries of this rollout.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings SetSkipSucceeded(this AzureDeploymentmanagerRolloutRestartSettings toolSettings, string skipSucceeded)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipSucceeded = skipSucceeded;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutRestartSettings.SkipSucceeded"/></em></p>
        ///   <p>Skips all the steps that have succeeded in the previous retries of this rollout.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings ResetSkipSucceeded(this AzureDeploymentmanagerRolloutRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipSucceeded = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings SetYes(this AzureDeploymentmanagerRolloutRestartSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings ResetYes(this AzureDeploymentmanagerRolloutRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings SetSubscription(this AzureDeploymentmanagerRolloutRestartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings ResetSubscription(this AzureDeploymentmanagerRolloutRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings SetDebug(this AzureDeploymentmanagerRolloutRestartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings ResetDebug(this AzureDeploymentmanagerRolloutRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings SetHelp(this AzureDeploymentmanagerRolloutRestartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings ResetHelp(this AzureDeploymentmanagerRolloutRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings SetOutput(this AzureDeploymentmanagerRolloutRestartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings ResetOutput(this AzureDeploymentmanagerRolloutRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings SetQuery(this AzureDeploymentmanagerRolloutRestartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings ResetQuery(this AzureDeploymentmanagerRolloutRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings SetVerbose(this AzureDeploymentmanagerRolloutRestartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutRestartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutRestartSettings ResetVerbose(this AzureDeploymentmanagerRolloutRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerRolloutShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerRolloutShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutShowSettings.Name"/></em></p>
        ///   <p>The name of the rollout.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings SetName(this AzureDeploymentmanagerRolloutShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutShowSettings.Name"/></em></p>
        ///   <p>The name of the rollout.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings ResetName(this AzureDeploymentmanagerRolloutShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings SetResourceGroup(this AzureDeploymentmanagerRolloutShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings ResetResourceGroup(this AzureDeploymentmanagerRolloutShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region RetryAttempt
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutShowSettings.RetryAttempt"/></em></p>
        ///   <p>Rollout retry attempt ordinal to get the result of. If not specified, result of the latest attempt will be returned.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings SetRetryAttempt(this AzureDeploymentmanagerRolloutShowSettings toolSettings, string retryAttempt)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RetryAttempt = retryAttempt;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutShowSettings.RetryAttempt"/></em></p>
        ///   <p>Rollout retry attempt ordinal to get the result of. If not specified, result of the latest attempt will be returned.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings ResetRetryAttempt(this AzureDeploymentmanagerRolloutShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RetryAttempt = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings SetSubscription(this AzureDeploymentmanagerRolloutShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings ResetSubscription(this AzureDeploymentmanagerRolloutShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings SetDebug(this AzureDeploymentmanagerRolloutShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings ResetDebug(this AzureDeploymentmanagerRolloutShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings SetHelp(this AzureDeploymentmanagerRolloutShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings ResetHelp(this AzureDeploymentmanagerRolloutShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings SetOutput(this AzureDeploymentmanagerRolloutShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings ResetOutput(this AzureDeploymentmanagerRolloutShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings SetQuery(this AzureDeploymentmanagerRolloutShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings ResetQuery(this AzureDeploymentmanagerRolloutShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings SetVerbose(this AzureDeploymentmanagerRolloutShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutShowSettings ResetVerbose(this AzureDeploymentmanagerRolloutShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerRolloutStopSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerRolloutStopSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutStopSettings.Name"/></em></p>
        ///   <p>The name of the rollout.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings SetName(this AzureDeploymentmanagerRolloutStopSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutStopSettings.Name"/></em></p>
        ///   <p>The name of the rollout.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings ResetName(this AzureDeploymentmanagerRolloutStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings SetResourceGroup(this AzureDeploymentmanagerRolloutStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings ResetResourceGroup(this AzureDeploymentmanagerRolloutStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutStopSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings SetYes(this AzureDeploymentmanagerRolloutStopSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutStopSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings ResetYes(this AzureDeploymentmanagerRolloutStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings SetSubscription(this AzureDeploymentmanagerRolloutStopSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings ResetSubscription(this AzureDeploymentmanagerRolloutStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings SetDebug(this AzureDeploymentmanagerRolloutStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings ResetDebug(this AzureDeploymentmanagerRolloutStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings SetHelp(this AzureDeploymentmanagerRolloutStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings ResetHelp(this AzureDeploymentmanagerRolloutStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings SetOutput(this AzureDeploymentmanagerRolloutStopSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings ResetOutput(this AzureDeploymentmanagerRolloutStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings SetQuery(this AzureDeploymentmanagerRolloutStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings ResetQuery(this AzureDeploymentmanagerRolloutStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerRolloutStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings SetVerbose(this AzureDeploymentmanagerRolloutStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerRolloutStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerRolloutStopSettings ResetVerbose(this AzureDeploymentmanagerRolloutStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerServiceCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerServiceCreateSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings SetLocation(this AzureDeploymentmanagerServiceCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings ResetLocation(this AzureDeploymentmanagerServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceCreateSettings.Name"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings SetName(this AzureDeploymentmanagerServiceCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceCreateSettings.Name"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings ResetName(this AzureDeploymentmanagerServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings SetResourceGroup(this AzureDeploymentmanagerServiceCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings ResetResourceGroup(this AzureDeploymentmanagerServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceTopologyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceCreateSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings SetServiceTopologyName(this AzureDeploymentmanagerServiceCreateSettings toolSettings, string serviceTopologyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = serviceTopologyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceCreateSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings ResetServiceTopologyName(this AzureDeploymentmanagerServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = null;
            return toolSettings;
        }
        #endregion
        #region TargetLocation
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceCreateSettings.TargetLocation"/></em></p>
        ///   <p>The location where the resources in the service should be deployed to.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings SetTargetLocation(this AzureDeploymentmanagerServiceCreateSettings toolSettings, string targetLocation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetLocation = targetLocation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceCreateSettings.TargetLocation"/></em></p>
        ///   <p>The location where the resources in the service should be deployed to.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings ResetTargetLocation(this AzureDeploymentmanagerServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetLocation = null;
            return toolSettings;
        }
        #endregion
        #region TargetSubscriptionId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceCreateSettings.TargetSubscriptionId"/></em></p>
        ///   <p>The subscription to which the resources in the service should be deployed to.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings SetTargetSubscriptionId(this AzureDeploymentmanagerServiceCreateSettings toolSettings, string targetSubscriptionId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetSubscriptionId = targetSubscriptionId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceCreateSettings.TargetSubscriptionId"/></em></p>
        ///   <p>The subscription to which the resources in the service should be deployed to.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings ResetTargetSubscriptionId(this AzureDeploymentmanagerServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetSubscriptionId = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings SetTags(this AzureDeploymentmanagerServiceCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings ResetTags(this AzureDeploymentmanagerServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings SetSubscription(this AzureDeploymentmanagerServiceCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings ResetSubscription(this AzureDeploymentmanagerServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings SetDebug(this AzureDeploymentmanagerServiceCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings ResetDebug(this AzureDeploymentmanagerServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings SetHelp(this AzureDeploymentmanagerServiceCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings ResetHelp(this AzureDeploymentmanagerServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings SetOutput(this AzureDeploymentmanagerServiceCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings ResetOutput(this AzureDeploymentmanagerServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings SetQuery(this AzureDeploymentmanagerServiceCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings ResetQuery(this AzureDeploymentmanagerServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings SetVerbose(this AzureDeploymentmanagerServiceCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceCreateSettings ResetVerbose(this AzureDeploymentmanagerServiceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerServiceDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerServiceDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Name"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings SetName(this AzureDeploymentmanagerServiceDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Name"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings ResetName(this AzureDeploymentmanagerServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings SetResourceGroup(this AzureDeploymentmanagerServiceDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings ResetResourceGroup(this AzureDeploymentmanagerServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceTopologyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceDeleteSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings SetServiceTopologyName(this AzureDeploymentmanagerServiceDeleteSettings toolSettings, string serviceTopologyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = serviceTopologyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceDeleteSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings ResetServiceTopologyName(this AzureDeploymentmanagerServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings SetSubscription(this AzureDeploymentmanagerServiceDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings ResetSubscription(this AzureDeploymentmanagerServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings SetDebug(this AzureDeploymentmanagerServiceDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings ResetDebug(this AzureDeploymentmanagerServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings SetHelp(this AzureDeploymentmanagerServiceDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings ResetHelp(this AzureDeploymentmanagerServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings SetOutput(this AzureDeploymentmanagerServiceDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings ResetOutput(this AzureDeploymentmanagerServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings SetQuery(this AzureDeploymentmanagerServiceDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings ResetQuery(this AzureDeploymentmanagerServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings SetVerbose(this AzureDeploymentmanagerServiceDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceDeleteSettings ResetVerbose(this AzureDeploymentmanagerServiceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerServiceShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerServiceShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceShowSettings.Name"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings SetName(this AzureDeploymentmanagerServiceShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceShowSettings.Name"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings ResetName(this AzureDeploymentmanagerServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings SetResourceGroup(this AzureDeploymentmanagerServiceShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings ResetResourceGroup(this AzureDeploymentmanagerServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceTopologyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceShowSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings SetServiceTopologyName(this AzureDeploymentmanagerServiceShowSettings toolSettings, string serviceTopologyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = serviceTopologyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceShowSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings ResetServiceTopologyName(this AzureDeploymentmanagerServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings SetSubscription(this AzureDeploymentmanagerServiceShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings ResetSubscription(this AzureDeploymentmanagerServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings SetDebug(this AzureDeploymentmanagerServiceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings ResetDebug(this AzureDeploymentmanagerServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings SetHelp(this AzureDeploymentmanagerServiceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings ResetHelp(this AzureDeploymentmanagerServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings SetOutput(this AzureDeploymentmanagerServiceShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings ResetOutput(this AzureDeploymentmanagerServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings SetQuery(this AzureDeploymentmanagerServiceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings ResetQuery(this AzureDeploymentmanagerServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings SetVerbose(this AzureDeploymentmanagerServiceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceShowSettings ResetVerbose(this AzureDeploymentmanagerServiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerServiceUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerServiceUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Name"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetName(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Name"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetName(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetResourceGroup(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetResourceGroup(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceTopologyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetServiceTopologyName(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string serviceTopologyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = serviceTopologyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetServiceTopologyName(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetTags(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetTags(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region TargetLocation
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.TargetLocation"/></em></p>
        ///   <p>The location where the resources in the service should be deployed to.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetTargetLocation(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string targetLocation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetLocation = targetLocation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.TargetLocation"/></em></p>
        ///   <p>The location where the resources in the service should be deployed to.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetTargetLocation(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetLocation = null;
            return toolSettings;
        }
        #endregion
        #region TargetSubscriptionId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.TargetSubscriptionId"/></em></p>
        ///   <p>The subscription to which the resources in the service should be deployed to.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetTargetSubscriptionId(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string targetSubscriptionId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetSubscriptionId = targetSubscriptionId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.TargetSubscriptionId"/></em></p>
        ///   <p>The subscription to which the resources in the service should be deployed to.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetTargetSubscriptionId(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetSubscriptionId = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetAdd(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetAdd(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetForceString(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetForceString(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetRemove(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetRemove(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetSet(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetSet(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetSubscription(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetSubscription(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetDebug(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetDebug(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetHelp(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetHelp(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetOutput(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetOutput(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetQuery(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetQuery(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings SetVerbose(this AzureDeploymentmanagerServiceUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUpdateSettings ResetVerbose(this AzureDeploymentmanagerServiceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerStepCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerStepCreateSettingsExtensions
    {
        #region Duration
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepCreateSettings.Duration"/></em></p>
        ///   <p>The duration of the wait step in ISO 8601 format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings SetDuration(this AzureDeploymentmanagerStepCreateSettings toolSettings, string duration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Duration = duration;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepCreateSettings.Duration"/></em></p>
        ///   <p>The duration of the wait step in ISO 8601 format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings ResetDuration(this AzureDeploymentmanagerStepCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Duration = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings SetLocation(this AzureDeploymentmanagerStepCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings ResetLocation(this AzureDeploymentmanagerStepCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepCreateSettings.Name"/></em></p>
        ///   <p>The name of the step.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings SetName(this AzureDeploymentmanagerStepCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepCreateSettings.Name"/></em></p>
        ///   <p>The name of the step.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings ResetName(this AzureDeploymentmanagerStepCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings SetResourceGroup(this AzureDeploymentmanagerStepCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings ResetResourceGroup(this AzureDeploymentmanagerStepCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings SetTags(this AzureDeploymentmanagerStepCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings ResetTags(this AzureDeploymentmanagerStepCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings SetSubscription(this AzureDeploymentmanagerStepCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings ResetSubscription(this AzureDeploymentmanagerStepCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings SetDebug(this AzureDeploymentmanagerStepCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings ResetDebug(this AzureDeploymentmanagerStepCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings SetHelp(this AzureDeploymentmanagerStepCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings ResetHelp(this AzureDeploymentmanagerStepCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings SetOutput(this AzureDeploymentmanagerStepCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings ResetOutput(this AzureDeploymentmanagerStepCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings SetQuery(this AzureDeploymentmanagerStepCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings ResetQuery(this AzureDeploymentmanagerStepCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings SetVerbose(this AzureDeploymentmanagerStepCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepCreateSettings ResetVerbose(this AzureDeploymentmanagerStepCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerStepDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerStepDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepDeleteSettings.Name"/></em></p>
        ///   <p>The name of the step.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings SetName(this AzureDeploymentmanagerStepDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepDeleteSettings.Name"/></em></p>
        ///   <p>The name of the step.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings ResetName(this AzureDeploymentmanagerStepDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings SetResourceGroup(this AzureDeploymentmanagerStepDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings ResetResourceGroup(this AzureDeploymentmanagerStepDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings SetSubscription(this AzureDeploymentmanagerStepDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings ResetSubscription(this AzureDeploymentmanagerStepDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings SetDebug(this AzureDeploymentmanagerStepDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings ResetDebug(this AzureDeploymentmanagerStepDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings SetHelp(this AzureDeploymentmanagerStepDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings ResetHelp(this AzureDeploymentmanagerStepDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings SetOutput(this AzureDeploymentmanagerStepDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings ResetOutput(this AzureDeploymentmanagerStepDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings SetQuery(this AzureDeploymentmanagerStepDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings ResetQuery(this AzureDeploymentmanagerStepDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings SetVerbose(this AzureDeploymentmanagerStepDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepDeleteSettings ResetVerbose(this AzureDeploymentmanagerStepDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerStepShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerStepShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepShowSettings.Name"/></em></p>
        ///   <p>The name of the step.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings SetName(this AzureDeploymentmanagerStepShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepShowSettings.Name"/></em></p>
        ///   <p>The name of the step.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings ResetName(this AzureDeploymentmanagerStepShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings SetResourceGroup(this AzureDeploymentmanagerStepShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings ResetResourceGroup(this AzureDeploymentmanagerStepShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings SetSubscription(this AzureDeploymentmanagerStepShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings ResetSubscription(this AzureDeploymentmanagerStepShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings SetDebug(this AzureDeploymentmanagerStepShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings ResetDebug(this AzureDeploymentmanagerStepShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings SetHelp(this AzureDeploymentmanagerStepShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings ResetHelp(this AzureDeploymentmanagerStepShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings SetOutput(this AzureDeploymentmanagerStepShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings ResetOutput(this AzureDeploymentmanagerStepShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings SetQuery(this AzureDeploymentmanagerStepShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings ResetQuery(this AzureDeploymentmanagerStepShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings SetVerbose(this AzureDeploymentmanagerStepShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepShowSettings ResetVerbose(this AzureDeploymentmanagerStepShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerStepUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerStepUpdateSettingsExtensions
    {
        #region Duration
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.Duration"/></em></p>
        ///   <p>The duration of the wait step in ISO 8601 format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetDuration(this AzureDeploymentmanagerStepUpdateSettings toolSettings, string duration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Duration = duration;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.Duration"/></em></p>
        ///   <p>The duration of the wait step in ISO 8601 format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetDuration(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Duration = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.Name"/></em></p>
        ///   <p>The name of the step.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetName(this AzureDeploymentmanagerStepUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.Name"/></em></p>
        ///   <p>The name of the step.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetName(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetResourceGroup(this AzureDeploymentmanagerStepUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetResourceGroup(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetTags(this AzureDeploymentmanagerStepUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetTags(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetAdd(this AzureDeploymentmanagerStepUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetAdd(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetForceString(this AzureDeploymentmanagerStepUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetForceString(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetRemove(this AzureDeploymentmanagerStepUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetRemove(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetSet(this AzureDeploymentmanagerStepUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetSet(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetSubscription(this AzureDeploymentmanagerStepUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetSubscription(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetDebug(this AzureDeploymentmanagerStepUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetDebug(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetHelp(this AzureDeploymentmanagerStepUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetHelp(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetOutput(this AzureDeploymentmanagerStepUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetOutput(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetQuery(this AzureDeploymentmanagerStepUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetQuery(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerStepUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings SetVerbose(this AzureDeploymentmanagerStepUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerStepUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerStepUpdateSettings ResetVerbose(this AzureDeploymentmanagerStepUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerServiceUnitCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerServiceUnitCreateSettingsExtensions
    {
        #region ParametersPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ParametersPath"/></em></p>
        ///   <p>The path to the ARM parameters file. Either the full SAS Uri or the relative path in the artifact source for this topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetParametersPath(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string parametersPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ParametersPath = parametersPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ParametersPath"/></em></p>
        ///   <p>The path to the ARM parameters file. Either the full SAS Uri or the relative path in the artifact source for this topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetParametersPath(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ParametersPath = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetResourceGroup(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetResourceGroup(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region TemplatePath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.TemplatePath"/></em></p>
        ///   <p>The path to the ARM template file. Either the full SAS Uri or the relative path in the artifact source for this topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetTemplatePath(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string templatePath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplatePath = templatePath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.TemplatePath"/></em></p>
        ///   <p>The path to the ARM template file. Either the full SAS Uri or the relative path in the artifact source for this topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetTemplatePath(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplatePath = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetLocation(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetLocation(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region DeploymentMode
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.DeploymentMode"/></em></p>
        ///   <p>The type of depoyment mode to be used when deploying the service unit. Possible values: Incremental, Complete.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetDeploymentMode(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, DeploymentmanagerServiceUnitDeploymentMode deploymentMode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentMode = deploymentMode;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.DeploymentMode"/></em></p>
        ///   <p>The type of depoyment mode to be used when deploying the service unit. Possible values: Incremental, Complete.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetDeploymentMode(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentMode = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Name"/></em></p>
        ///   <p>The name of the service unit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetName(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Name"/></em></p>
        ///   <p>The name of the service unit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetName(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ServiceName"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetServiceName(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ServiceName"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetServiceName(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region ServiceTopologyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetServiceTopologyName(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string serviceTopologyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = serviceTopologyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetServiceTopologyName(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = null;
            return toolSettings;
        }
        #endregion
        #region TargetResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.TargetResourceGroup"/></em></p>
        ///   <p>The resource group where the resources in the service unit should be deployed to.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetTargetResourceGroup(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string targetResourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetResourceGroup = targetResourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.TargetResourceGroup"/></em></p>
        ///   <p>The resource group where the resources in the service unit should be deployed to.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetTargetResourceGroup(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetTags(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetTags(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetSubscription(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetSubscription(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetDebug(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetDebug(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetHelp(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetHelp(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetOutput(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetOutput(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetQuery(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetQuery(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings SetVerbose(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitCreateSettings ResetVerbose(this AzureDeploymentmanagerServiceUnitCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerServiceUnitDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerServiceUnitDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Name"/></em></p>
        ///   <p>The name of the service unit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings SetName(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Name"/></em></p>
        ///   <p>The name of the service unit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings ResetName(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings SetResourceGroup(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings ResetResourceGroup(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.ServiceName"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings SetServiceName(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.ServiceName"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings ResetServiceName(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region ServiceTopologyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings SetServiceTopologyName(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings, string serviceTopologyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = serviceTopologyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings ResetServiceTopologyName(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings SetSubscription(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings ResetSubscription(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings SetDebug(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings ResetDebug(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings SetHelp(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings ResetHelp(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings SetOutput(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings ResetOutput(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings SetQuery(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings ResetQuery(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings SetVerbose(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitDeleteSettings ResetVerbose(this AzureDeploymentmanagerServiceUnitDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerServiceUnitShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerServiceUnitShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Name"/></em></p>
        ///   <p>The name of the service unit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings SetName(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Name"/></em></p>
        ///   <p>The name of the service unit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings ResetName(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings SetResourceGroup(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings ResetResourceGroup(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.ServiceName"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings SetServiceName(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.ServiceName"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings ResetServiceName(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region ServiceTopologyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings SetServiceTopologyName(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings, string serviceTopologyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = serviceTopologyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings ResetServiceTopologyName(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings SetSubscription(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings ResetSubscription(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings SetDebug(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings ResetDebug(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings SetHelp(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings ResetHelp(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings SetOutput(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings ResetOutput(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings SetQuery(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings ResetQuery(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings SetVerbose(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitShowSettings ResetVerbose(this AzureDeploymentmanagerServiceUnitShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerServiceUnitUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerServiceUnitUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Name"/></em></p>
        ///   <p>The name of the service unit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetName(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Name"/></em></p>
        ///   <p>The name of the service unit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetName(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetResourceGroup(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetResourceGroup(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServiceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ServiceName"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetServiceName(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string serviceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = serviceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ServiceName"/></em></p>
        ///   <p>The name of the service.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetServiceName(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceName = null;
            return toolSettings;
        }
        #endregion
        #region ServiceTopologyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetServiceTopologyName(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string serviceTopologyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = serviceTopologyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ServiceTopologyName"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetServiceTopologyName(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceTopologyName = null;
            return toolSettings;
        }
        #endregion
        #region DeploymentMode
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.DeploymentMode"/></em></p>
        ///   <p>The type of depoyment mode to be used when deploying the service unit. Possible values: Incremental, Complete.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetDeploymentMode(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, DeploymentmanagerServiceUnitDeploymentMode deploymentMode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentMode = deploymentMode;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.DeploymentMode"/></em></p>
        ///   <p>The type of depoyment mode to be used when deploying the service unit. Possible values: Incremental, Complete.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetDeploymentMode(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentMode = null;
            return toolSettings;
        }
        #endregion
        #region ParametersPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ParametersPath"/></em></p>
        ///   <p>The path to the ARM parameters file. Either the full SAS Uri or the relative path in the artifact source for this topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetParametersPath(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string parametersPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ParametersPath = parametersPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ParametersPath"/></em></p>
        ///   <p>The path to the ARM parameters file. Either the full SAS Uri or the relative path in the artifact source for this topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetParametersPath(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ParametersPath = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetTags(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetTags(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region TargetResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.TargetResourceGroup"/></em></p>
        ///   <p>The resource group where the resources in the service unit should be deployed to.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetTargetResourceGroup(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string targetResourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetResourceGroup = targetResourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.TargetResourceGroup"/></em></p>
        ///   <p>The resource group where the resources in the service unit should be deployed to.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetTargetResourceGroup(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region TemplatePath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.TemplatePath"/></em></p>
        ///   <p>The path to the ARM template file. Either the full SAS Uri or the relative path in the artifact source for this topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetTemplatePath(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string templatePath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplatePath = templatePath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.TemplatePath"/></em></p>
        ///   <p>The path to the ARM template file. Either the full SAS Uri or the relative path in the artifact source for this topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetTemplatePath(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplatePath = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetAdd(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetAdd(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetForceString(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetForceString(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetRemove(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetRemove(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetSet(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetSet(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetSubscription(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetSubscription(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetDebug(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetDebug(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetHelp(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetHelp(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetOutput(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetOutput(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetQuery(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetQuery(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings SetVerbose(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceUnitUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceUnitUpdateSettings ResetVerbose(this AzureDeploymentmanagerServiceUnitUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerServiceTopologyCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerServiceTopologyCreateSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings SetLocation(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings ResetLocation(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Name"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings SetName(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Name"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings ResetName(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings SetResourceGroup(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings ResetResourceGroup(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ArtifactSource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.ArtifactSource"/></em></p>
        ///   <p>The name or resource identifier of the artifact source.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings SetArtifactSource(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings, string artifactSource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSource = artifactSource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.ArtifactSource"/></em></p>
        ///   <p>The name or resource identifier of the artifact source.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings ResetArtifactSource(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSource = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings SetTags(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings ResetTags(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings SetSubscription(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings ResetSubscription(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings SetDebug(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings ResetDebug(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings SetHelp(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings ResetHelp(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings SetOutput(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings ResetOutput(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings SetQuery(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings ResetQuery(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings SetVerbose(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyCreateSettings ResetVerbose(this AzureDeploymentmanagerServiceTopologyCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerServiceTopologyDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerServiceTopologyDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Name"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings SetName(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Name"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings ResetName(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings SetResourceGroup(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings ResetResourceGroup(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings SetSubscription(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings ResetSubscription(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings SetDebug(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings ResetDebug(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings SetHelp(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings ResetHelp(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings SetOutput(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings ResetOutput(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings SetQuery(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings ResetQuery(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings SetVerbose(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyDeleteSettings ResetVerbose(this AzureDeploymentmanagerServiceTopologyDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerServiceTopologyShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerServiceTopologyShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Name"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings SetName(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Name"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings ResetName(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings SetResourceGroup(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings ResetResourceGroup(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings SetSubscription(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings ResetSubscription(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings SetDebug(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings ResetDebug(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings SetHelp(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings ResetHelp(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings SetOutput(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings ResetOutput(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings SetQuery(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings ResetQuery(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings SetVerbose(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyShowSettings ResetVerbose(this AzureDeploymentmanagerServiceTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentmanagerServiceTopologyUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentmanagerServiceTopologyUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Name"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetName(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Name"/></em></p>
        ///   <p>The name of the service topology.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetName(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetResourceGroup(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetResourceGroup(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ArtifactSource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.ArtifactSource"/></em></p>
        ///   <p>The name or resource identifier of the artifact source.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetArtifactSource(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, string artifactSource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSource = artifactSource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.ArtifactSource"/></em></p>
        ///   <p>The name or resource identifier of the artifact source.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetArtifactSource(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSource = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetTags(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetTags(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetAdd(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetAdd(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetForceString(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetForceString(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetRemove(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetRemove(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetSet(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetSet(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetSubscription(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetSubscription(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetDebug(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetDebug(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetHelp(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetHelp(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetOutput(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetOutput(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetQuery(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetQuery(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings SetVerbose(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureDeploymentmanagerServiceTopologyUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureDeploymentmanagerServiceTopologyUpdateSettings ResetVerbose(this AzureDeploymentmanagerServiceTopologyUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region DeploymentmanagerServiceUnitDeploymentMode
    /// <summary>
    ///   Used within <see cref="AzureDeploymentmanagerTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<DeploymentmanagerServiceUnitDeploymentMode>))]
    public partial class DeploymentmanagerServiceUnitDeploymentMode : Enumeration
    {
        public static DeploymentmanagerServiceUnitDeploymentMode complete = new DeploymentmanagerServiceUnitDeploymentMode { Value = "complete" };
        public static DeploymentmanagerServiceUnitDeploymentMode incremental = new DeploymentmanagerServiceUnitDeploymentMode { Value = "incremental" };
    }
    #endregion
}
