// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureImage.json
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
    public static partial class AzureImageTasks
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public static string AzureImagePath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREIMAGE_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureImageLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage custom virtual machine images.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImage(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureImagePath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureImageLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageCreate(AzureImageCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--data-disk-sources</c> via <see cref="AzureImageCreateSettings.DataDiskSources"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageCreateSettings.Help"/></li>
        ///     <li><c>--hyper-v-generation</c> via <see cref="AzureImageCreateSettings.HyperVGeneration"/></li>
        ///     <li><c>--location</c> via <see cref="AzureImageCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageCreateSettings.Name"/></li>
        ///     <li><c>--os-disk-caching</c> via <see cref="AzureImageCreateSettings.OsDiskCaching"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureImageCreateSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--source</c> via <see cref="AzureImageCreateSettings.Source"/></li>
        ///     <li><c>--storage-sku</c> via <see cref="AzureImageCreateSettings.StorageSku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureImageCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageCreateSettings.Verbose"/></li>
        ///     <li><c>--zone-resilient</c> via <see cref="AzureImageCreateSettings.ZoneResilient"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageCreate(Configure<AzureImageCreateSettings> configurator)
        {
            return AzureImageCreate(configurator(new AzureImageCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--data-disk-sources</c> via <see cref="AzureImageCreateSettings.DataDiskSources"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageCreateSettings.Help"/></li>
        ///     <li><c>--hyper-v-generation</c> via <see cref="AzureImageCreateSettings.HyperVGeneration"/></li>
        ///     <li><c>--location</c> via <see cref="AzureImageCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageCreateSettings.Name"/></li>
        ///     <li><c>--os-disk-caching</c> via <see cref="AzureImageCreateSettings.OsDiskCaching"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureImageCreateSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--source</c> via <see cref="AzureImageCreateSettings.Source"/></li>
        ///     <li><c>--storage-sku</c> via <see cref="AzureImageCreateSettings.StorageSku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureImageCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageCreateSettings.Verbose"/></li>
        ///     <li><c>--zone-resilient</c> via <see cref="AzureImageCreateSettings.ZoneResilient"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageCreate(CombinatorialConfigure<AzureImageCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageCreate, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageDelete(AzureImageDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageDelete(Configure<AzureImageDeleteSettings> configurator)
        {
            return AzureImageDelete(configurator(new AzureImageDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageDelete(CombinatorialConfigure<AzureImageDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageDelete, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageList(AzureImageListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageList(Configure<AzureImageListSettings> configurator)
        {
            return AzureImageList(configurator(new AzureImageListSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageListSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageList(CombinatorialConfigure<AzureImageListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageList, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageShow(AzureImageShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageShowSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureImageShowSettings.Expand"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageShow(Configure<AzureImageShowSettings> configurator)
        {
            return AzureImageShow(configurator(new AzureImageShowSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageShowSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureImageShowSettings.Expand"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageShow(CombinatorialConfigure<AzureImageShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageShow, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageUpdate(AzureImageUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureImageUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureImageUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureImageUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureImageUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureImageUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageUpdate(Configure<AzureImageUpdateSettings> configurator)
        {
            return AzureImageUpdate(configurator(new AzureImageUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureImageUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureImageUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureImageUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureImageUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureImageUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageUpdate(CombinatorialConfigure<AzureImageUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageUpdate, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateCreate(AzureImageTemplateCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--build-timeout</c> via <see cref="AzureImageTemplateCreateSettings.BuildTimeout"/></li>
        ///     <li><c>--checksum</c> via <see cref="AzureImageTemplateCreateSettings.Checksum"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateCreateSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateCreateSettings.Defer"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateCreateSettings.Help"/></li>
        ///     <li><c>--image-source</c> via <see cref="AzureImageTemplateCreateSettings.ImageSource"/></li>
        ///     <li><c>--location</c> via <see cref="AzureImageTemplateCreateSettings.Location"/></li>
        ///     <li><c>--managed-image-destinations</c> via <see cref="AzureImageTemplateCreateSettings.ManagedImageDestinations"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureImageTemplateCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--scripts</c> via <see cref="AzureImageTemplateCreateSettings.Scripts"/></li>
        ///     <li><c>--shared-image-destinations</c> via <see cref="AzureImageTemplateCreateSettings.SharedImageDestinations"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureImageTemplateCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateCreate(Configure<AzureImageTemplateCreateSettings> configurator)
        {
            return AzureImageTemplateCreate(configurator(new AzureImageTemplateCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--build-timeout</c> via <see cref="AzureImageTemplateCreateSettings.BuildTimeout"/></li>
        ///     <li><c>--checksum</c> via <see cref="AzureImageTemplateCreateSettings.Checksum"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateCreateSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateCreateSettings.Defer"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateCreateSettings.Help"/></li>
        ///     <li><c>--image-source</c> via <see cref="AzureImageTemplateCreateSettings.ImageSource"/></li>
        ///     <li><c>--location</c> via <see cref="AzureImageTemplateCreateSettings.Location"/></li>
        ///     <li><c>--managed-image-destinations</c> via <see cref="AzureImageTemplateCreateSettings.ManagedImageDestinations"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureImageTemplateCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--scripts</c> via <see cref="AzureImageTemplateCreateSettings.Scripts"/></li>
        ///     <li><c>--shared-image-destinations</c> via <see cref="AzureImageTemplateCreateSettings.SharedImageDestinations"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureImageTemplateCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateCreate(CombinatorialConfigure<AzureImageTemplateCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateCreate, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateDelete(AzureImageTemplateDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateDelete(Configure<AzureImageTemplateDeleteSettings> configurator)
        {
            return AzureImageTemplateDelete(configurator(new AzureImageTemplateDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateDelete(CombinatorialConfigure<AzureImageTemplateDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateDelete, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateList(AzureImageTemplateListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateList(Configure<AzureImageTemplateListSettings> configurator)
        {
            return AzureImageTemplateList(configurator(new AzureImageTemplateListSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateListSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateList(CombinatorialConfigure<AzureImageTemplateListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateList, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateRun(AzureImageTemplateRunSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateRunSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateRunSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateRunSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateRunSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateRunSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureImageTemplateRunSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateRunSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateRunSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateRunSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateRunSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateRunSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateRun(Configure<AzureImageTemplateRunSettings> configurator)
        {
            return AzureImageTemplateRun(configurator(new AzureImageTemplateRunSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateRunSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateRunSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateRunSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateRunSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureImageTemplateRunSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateRunSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateRunSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateRunSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateRunSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateRunSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateRunSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateRun(CombinatorialConfigure<AzureImageTemplateRunSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateRun, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateShow(AzureImageTemplateShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateShow(Configure<AzureImageTemplateShowSettings> configurator)
        {
            return AzureImageTemplateShow(configurator(new AzureImageTemplateShowSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateShow(CombinatorialConfigure<AzureImageTemplateShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateShow, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateShowRuns(AzureImageTemplateShowRunsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateShowRunsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateShowRunsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateShowRunsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateShowRunsSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateShowRunsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateShowRunsSettings.Output"/></li>
        ///     <li><c>--output-name</c> via <see cref="AzureImageTemplateShowRunsSettings.OutputName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateShowRunsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateShowRunsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateShowRunsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateShowRunsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateShowRuns(Configure<AzureImageTemplateShowRunsSettings> configurator)
        {
            return AzureImageTemplateShowRuns(configurator(new AzureImageTemplateShowRunsSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateShowRunsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateShowRunsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateShowRunsSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateShowRunsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateShowRunsSettings.Output"/></li>
        ///     <li><c>--output-name</c> via <see cref="AzureImageTemplateShowRunsSettings.OutputName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateShowRunsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateShowRunsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateShowRunsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateShowRunsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateShowRunsSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateShowRuns(CombinatorialConfigure<AzureImageTemplateShowRunsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateShowRuns, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateUpdate(AzureImageTemplateUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureImageTemplateUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateUpdateSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateUpdateSettings.Defer"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureImageTemplateUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureImageTemplateUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureImageTemplateUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateUpdate(Configure<AzureImageTemplateUpdateSettings> configurator)
        {
            return AzureImageTemplateUpdate(configurator(new AzureImageTemplateUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureImageTemplateUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateUpdateSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateUpdateSettings.Defer"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureImageTemplateUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureImageTemplateUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureImageTemplateUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateUpdate(CombinatorialConfigure<AzureImageTemplateUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateUpdate, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateWait(AzureImageTemplateWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureImageTemplateWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureImageTemplateWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureImageTemplateWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureImageTemplateWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureImageTemplateWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureImageTemplateWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureImageTemplateWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateWait(Configure<AzureImageTemplateWaitSettings> configurator)
        {
            return AzureImageTemplateWait(configurator(new AzureImageTemplateWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureImageTemplateWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureImageTemplateWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureImageTemplateWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureImageTemplateWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureImageTemplateWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureImageTemplateWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureImageTemplateWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateWait(CombinatorialConfigure<AzureImageTemplateWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateWait, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateOutputAdd(AzureImageTemplateOutputAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateOutputAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--artifact-tags</c> via <see cref="AzureImageTemplateOutputAddSettings.ArtifactTags"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateOutputAddSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateOutputAddSettings.Defer"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureImageTemplateOutputAddSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureImageTemplateOutputAddSettings.GalleryName"/></li>
        ///     <li><c>--gallery-replication-regions</c> via <see cref="AzureImageTemplateOutputAddSettings.GalleryReplicationRegions"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateOutputAddSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateOutputAddSettings.Ids"/></li>
        ///     <li><c>--is-vhd</c> via <see cref="AzureImageTemplateOutputAddSettings.IsVhd"/></li>
        ///     <li><c>--managed-image</c> via <see cref="AzureImageTemplateOutputAddSettings.ManagedImage"/></li>
        ///     <li><c>--managed-image-location</c> via <see cref="AzureImageTemplateOutputAddSettings.ManagedImageLocation"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateOutputAddSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateOutputAddSettings.Output"/></li>
        ///     <li><c>--output-name</c> via <see cref="AzureImageTemplateOutputAddSettings.OutputName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateOutputAddSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateOutputAddSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateOutputAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateOutputAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateOutputAdd(Configure<AzureImageTemplateOutputAddSettings> configurator)
        {
            return AzureImageTemplateOutputAdd(configurator(new AzureImageTemplateOutputAddSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--artifact-tags</c> via <see cref="AzureImageTemplateOutputAddSettings.ArtifactTags"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateOutputAddSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateOutputAddSettings.Defer"/></li>
        ///     <li><c>--gallery-image-definition</c> via <see cref="AzureImageTemplateOutputAddSettings.GalleryImageDefinition"/></li>
        ///     <li><c>--gallery-name</c> via <see cref="AzureImageTemplateOutputAddSettings.GalleryName"/></li>
        ///     <li><c>--gallery-replication-regions</c> via <see cref="AzureImageTemplateOutputAddSettings.GalleryReplicationRegions"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateOutputAddSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateOutputAddSettings.Ids"/></li>
        ///     <li><c>--is-vhd</c> via <see cref="AzureImageTemplateOutputAddSettings.IsVhd"/></li>
        ///     <li><c>--managed-image</c> via <see cref="AzureImageTemplateOutputAddSettings.ManagedImage"/></li>
        ///     <li><c>--managed-image-location</c> via <see cref="AzureImageTemplateOutputAddSettings.ManagedImageLocation"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateOutputAddSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateOutputAddSettings.Output"/></li>
        ///     <li><c>--output-name</c> via <see cref="AzureImageTemplateOutputAddSettings.OutputName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateOutputAddSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateOutputAddSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateOutputAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateOutputAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateOutputAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateOutputAdd(CombinatorialConfigure<AzureImageTemplateOutputAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateOutputAdd, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateOutputClear(AzureImageTemplateOutputClearSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateOutputClearSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateOutputClearSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateOutputClearSettings.Defer"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateOutputClearSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateOutputClearSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateOutputClearSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateOutputClearSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateOutputClearSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateOutputClearSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateOutputClearSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateOutputClearSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateOutputClear(Configure<AzureImageTemplateOutputClearSettings> configurator)
        {
            return AzureImageTemplateOutputClear(configurator(new AzureImageTemplateOutputClearSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateOutputClearSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateOutputClearSettings.Defer"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateOutputClearSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateOutputClearSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateOutputClearSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateOutputClearSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateOutputClearSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateOutputClearSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateOutputClearSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateOutputClearSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateOutputClearSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateOutputClear(CombinatorialConfigure<AzureImageTemplateOutputClearSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateOutputClear, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateOutputRemove(AzureImageTemplateOutputRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateOutputRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Defer"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Output"/></li>
        ///     <li><c>--output-name</c> via <see cref="AzureImageTemplateOutputRemoveSettings.OutputName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateOutputRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateOutputRemove(Configure<AzureImageTemplateOutputRemoveSettings> configurator)
        {
            return AzureImageTemplateOutputRemove(configurator(new AzureImageTemplateOutputRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Defer"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Output"/></li>
        ///     <li><c>--output-name</c> via <see cref="AzureImageTemplateOutputRemoveSettings.OutputName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateOutputRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateOutputRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateOutputRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateOutputRemove(CombinatorialConfigure<AzureImageTemplateOutputRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateOutputRemove, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateCustomizerAdd(AzureImageTemplateCustomizerAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateCustomizerAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--customizer-name</c> via <see cref="AzureImageTemplateCustomizerAddSettings.CustomizerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Defer"/></li>
        ///     <li><c>--dest-path</c> via <see cref="AzureImageTemplateCustomizerAddSettings.DestPath"/></li>
        ///     <li><c>--exit-codes</c> via <see cref="AzureImageTemplateCustomizerAddSettings.ExitCodes"/></li>
        ///     <li><c>--file-source</c> via <see cref="AzureImageTemplateCustomizerAddSettings.FileSource"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Ids"/></li>
        ///     <li><c>--inline-script</c> via <see cref="AzureImageTemplateCustomizerAddSettings.InlineScript"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateCustomizerAddSettings.ResourceGroup"/></li>
        ///     <li><c>--restart-check-command</c> via <see cref="AzureImageTemplateCustomizerAddSettings.RestartCheckCommand"/></li>
        ///     <li><c>--restart-command</c> via <see cref="AzureImageTemplateCustomizerAddSettings.RestartCommand"/></li>
        ///     <li><c>--restart-timeout</c> via <see cref="AzureImageTemplateCustomizerAddSettings.RestartTimeout"/></li>
        ///     <li><c>--script-url</c> via <see cref="AzureImageTemplateCustomizerAddSettings.ScriptUrl"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Subscription"/></li>
        ///     <li><c>--type</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Type"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateCustomizerAdd(Configure<AzureImageTemplateCustomizerAddSettings> configurator)
        {
            return AzureImageTemplateCustomizerAdd(configurator(new AzureImageTemplateCustomizerAddSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--customizer-name</c> via <see cref="AzureImageTemplateCustomizerAddSettings.CustomizerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Defer"/></li>
        ///     <li><c>--dest-path</c> via <see cref="AzureImageTemplateCustomizerAddSettings.DestPath"/></li>
        ///     <li><c>--exit-codes</c> via <see cref="AzureImageTemplateCustomizerAddSettings.ExitCodes"/></li>
        ///     <li><c>--file-source</c> via <see cref="AzureImageTemplateCustomizerAddSettings.FileSource"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Ids"/></li>
        ///     <li><c>--inline-script</c> via <see cref="AzureImageTemplateCustomizerAddSettings.InlineScript"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateCustomizerAddSettings.ResourceGroup"/></li>
        ///     <li><c>--restart-check-command</c> via <see cref="AzureImageTemplateCustomizerAddSettings.RestartCheckCommand"/></li>
        ///     <li><c>--restart-command</c> via <see cref="AzureImageTemplateCustomizerAddSettings.RestartCommand"/></li>
        ///     <li><c>--restart-timeout</c> via <see cref="AzureImageTemplateCustomizerAddSettings.RestartTimeout"/></li>
        ///     <li><c>--script-url</c> via <see cref="AzureImageTemplateCustomizerAddSettings.ScriptUrl"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Subscription"/></li>
        ///     <li><c>--type</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Type"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateCustomizerAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateCustomizerAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateCustomizerAdd(CombinatorialConfigure<AzureImageTemplateCustomizerAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateCustomizerAdd, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateCustomizerClear(AzureImageTemplateCustomizerClearSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateCustomizerClearSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Defer"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateCustomizerClearSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateCustomizerClear(Configure<AzureImageTemplateCustomizerClearSettings> configurator)
        {
            return AzureImageTemplateCustomizerClear(configurator(new AzureImageTemplateCustomizerClearSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Defer"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateCustomizerClearSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateCustomizerClearSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateCustomizerClearSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateCustomizerClear(CombinatorialConfigure<AzureImageTemplateCustomizerClearSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateCustomizerClear, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureImageTemplateCustomizerRemove(AzureImageTemplateCustomizerRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureImageTemplateCustomizerRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--customizer-name</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.CustomizerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Defer"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureImageTemplateCustomizerRemove(Configure<AzureImageTemplateCustomizerRemoveSettings> configurator)
        {
            return AzureImageTemplateCustomizerRemove(configurator(new AzureImageTemplateCustomizerRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage custom virtual machine images.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/image?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--customizer-name</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.CustomizerName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Debug"/></li>
        ///     <li><c>--defer</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Defer"/></li>
        ///     <li><c>--help</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureImageTemplateCustomizerRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureImageTemplateCustomizerRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureImageTemplateCustomizerRemove(CombinatorialConfigure<AzureImageTemplateCustomizerRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureImageTemplateCustomizerRemove, AzureImageLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureImageCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   New image name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   OS disk source from the same region, including a virtual machine ID or name, OS disk blob URI, managed OS disk ID or name, or OS snapshot ID or name.
        /// </summary>
        public virtual string Source { get; internal set; }
        /// <summary>
        ///   Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.
        /// </summary>
        public virtual IReadOnlyList<string> DataDiskSources => DataDiskSourcesInternal.AsReadOnly();
        internal List<string> DataDiskSourcesInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The hypervisor generation of the Virtual Machine created from the image.
        /// </summary>
        public virtual ImageCreateHyperVGeneration HyperVGeneration { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Storage caching type for the image's OS disk.
        /// </summary>
        public virtual ImageCreateOsDiskCaching OsDiskCaching { get; internal set; }
        public virtual ImageCreateOsType OsType { get; internal set; }
        /// <summary>
        ///   The SKU of the storage account with which to create the VM image. Unused if source VM is specified.
        /// </summary>
        public virtual ImageCreateStorageSku StorageSku { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage.
        /// </summary>
        public virtual bool? ZoneResilient { get; internal set; }
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
              .Add("image create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--source {value}", Source)
              .Add("--data-disk-sources {value}", DataDiskSources, separator: ' ')
              .Add("--hyper-v-generation {value}", HyperVGeneration)
              .Add("--location {value}", Location)
              .Add("--os-disk-caching {value}", OsDiskCaching)
              .Add("--os-type {value}", OsType)
              .Add("--storage-sku {value}", StorageSku)
              .Add("--tags {value}", Tags)
              .Add("--zone-resilient", ZoneResilient)
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
    #region AzureImageDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the image.
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
              .Add("image delete")
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
    #region AzureImageListSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
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
              .Add("image list")
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
    #region AzureImageShowSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   The expand expression to apply on the operation.
        /// </summary>
        public virtual string Expand { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the image.
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
              .Add("image show")
              .Add("--expand {value}", Expand)
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
    #region AzureImageUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
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
        ///   The name of the image.
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
              .Add("image update")
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
    #region AzureImageTemplateCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   The name of the image template.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The Maximum duration to wait while building the image template, in minutes. Default is 60.
        /// </summary>
        public virtual string BuildTimeout { get; internal set; }
        /// <summary>
        ///   Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.
        /// </summary>
        public virtual string Defer { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   Space-separated list of shell or powershell scripts to customize the image with. Each script must be a publicly accessible URL. Infers type of script from file extension ('.sh' or'.ps1') or from source type. More more customizer options and flexibility, see: 'az image template customizer add'.
        /// </summary>
        public virtual IReadOnlyList<string> Scripts => ScriptsInternal.AsReadOnly();
        internal List<string> ScriptsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The SHA256 checksum of the Red Hat ISO image.
        /// </summary>
        public virtual string Checksum { get; internal set; }
        /// <summary>
        ///   The base image to customize. Must be a valid platform image URN, platform image alias, Red Hat ISO image URI, managed image name/ID, or shared image version ID.
        /// </summary>
        public virtual string ImageSource { get; internal set; }
        /// <summary>
        ///   Managed image output distributor information. Space-separated list of key-value pairs. E.g "image_1=westus2 image_2=westus". Each key is the name or resource ID of the managed image to be created. Each value is the location of the image.
        /// </summary>
        public virtual string ManagedImageDestinations { get; internal set; }
        /// <summary>
        ///   Shared image gallery (sig) output distributor information. Space-separated list of key-value pairs. E.g "my_gallery_1/image_def_1=eastus,westus  my_gallery_2/image_def_2=uksouth,canadaeast,francesouth." Each key is the sig image definition ID or sig gallery name and sig image definition delimited by a "/". Each value is a comma-delimited list of replica locations.
        /// </summary>
        public virtual string SharedImageDestinations { get; internal set; }
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
              .Add("image template create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--build-timeout {value}", BuildTimeout)
              .Add("--defer {value}", Defer)
              .Add("--location {value}", Location)
              .Add("--no-wait", NoWait)
              .Add("--tags {value}", Tags)
              .Add("--scripts {value}", Scripts, separator: ' ')
              .Add("--checksum {value}", Checksum)
              .Add("--image-source {value}", ImageSource)
              .Add("--managed-image-destinations {value}", ManagedImageDestinations)
              .Add("--shared-image-destinations {value}", SharedImageDestinations)
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
    #region AzureImageTemplateDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the image template.
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
              .Add("image template delete")
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
    #region AzureImageTemplateListSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
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
              .Add("image template list")
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
    #region AzureImageTemplateRunSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateRunSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
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
        ///   The name of the image template.
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
              .Add("image template run")
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
    #region AzureImageTemplateShowSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the image template.
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
              .Add("image template show")
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
    #region AzureImageTemplateShowRunsSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateShowRunsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   Name of the image builder run output.
        /// </summary>
        public virtual string OutputName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the image template.
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
              .Add("image template show-runs")
              .Add("--output-name {value}", OutputName)
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
    #region AzureImageTemplateUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.
        /// </summary>
        public virtual string Defer { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the image template.
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
              .Add("image template update")
              .Add("--defer {value}", Defer)
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
    #region AzureImageTemplateWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the image template.
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
        ///   Wait until created with 'provisioningState' at 'Succeeded'.
        /// </summary>
        public virtual string Created { get; internal set; }
        /// <summary>
        ///   Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].
        /// </summary>
        public virtual string Custom { get; internal set; }
        /// <summary>
        ///   Wait until deleted.
        /// </summary>
        public virtual string Deleted { get; internal set; }
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
        ///   Wait until updated with provisioningState at 'Succeeded'.
        /// </summary>
        public virtual string Updated { get; internal set; }
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
              .Add("image template wait")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--created {value}", Created)
              .Add("--custom {value}", Custom)
              .Add("--deleted {value}", Deleted)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--updated {value}", Updated)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureImageTemplateOutputAddSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateOutputAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   Tags that will be applied to the output artifact once it has been created by the distributor. space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string ArtifactTags { get; internal set; }
        /// <summary>
        ///   Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.
        /// </summary>
        public virtual string Defer { get; internal set; }
        /// <summary>
        ///   Name of the image builder run output. Defaults to the name of the managed image or sig image definition.
        /// </summary>
        public virtual string OutputName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the image template.
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
        ///   Name or ID of the customized managed image to be created.
        /// </summary>
        public virtual string ManagedImage { get; internal set; }
        /// <summary>
        ///   Location where the customized image will be created. Defaults to resource group's location.
        /// </summary>
        public virtual string ManagedImageLocation { get; internal set; }
        /// <summary>
        ///   Name or ID of the existing SIG image definition to create the customized image version with.
        /// </summary>
        public virtual string GalleryImageDefinition { get; internal set; }
        /// <summary>
        ///   Shared image gallery name, if image definition name and not ID was provided.
        /// </summary>
        public virtual string GalleryName { get; internal set; }
        /// <summary>
        ///   Space-separated list of regions to replicate the image version into. Defaults to resource group's location.
        /// </summary>
        public virtual IReadOnlyList<string> GalleryReplicationRegions => GalleryReplicationRegionsInternal.AsReadOnly();
        internal List<string> GalleryReplicationRegionsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The output is a VHD distributor.
        /// </summary>
        public virtual string IsVhd { get; internal set; }
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
              .Add("image template output add")
              .Add("--artifact-tags {value}", ArtifactTags)
              .Add("--defer {value}", Defer)
              .Add("--output-name {value}", OutputName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--managed-image {value}", ManagedImage)
              .Add("--managed-image-location {value}", ManagedImageLocation)
              .Add("--gallery-image-definition {value}", GalleryImageDefinition)
              .Add("--gallery-name {value}", GalleryName)
              .Add("--gallery-replication-regions {value}", GalleryReplicationRegions, separator: ' ')
              .Add("--is-vhd {value}", IsVhd)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureImageTemplateOutputClearSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateOutputClearSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.
        /// </summary>
        public virtual string Defer { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the image template.
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
              .Add("image template output clear")
              .Add("--defer {value}", Defer)
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
    #region AzureImageTemplateOutputRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateOutputRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   Name of the image builder run output.
        /// </summary>
        public virtual string OutputName { get; internal set; }
        /// <summary>
        ///   Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.
        /// </summary>
        public virtual string Defer { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the image template.
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
              .Add("image template output remove")
              .Add("--output-name {value}", OutputName)
              .Add("--defer {value}", Defer)
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
    #region AzureImageTemplateCustomizerAddSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateCustomizerAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   Name of the customizer.
        /// </summary>
        public virtual string CustomizerName { get; internal set; }
        /// <summary>
        ///   Type of customizer to be added to the image template.
        /// </summary>
        public virtual ImageTemplateCustomizerAddType Type { get; internal set; }
        /// <summary>
        ///   Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.
        /// </summary>
        public virtual string Defer { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the image template.
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
        ///   The absolute destination path where the file specified in --file-source will be downloaded to in the image.
        /// </summary>
        public virtual string DestPath { get; internal set; }
        /// <summary>
        ///   The URI of the file to be downloaded into the image. It can be a github link, SAS URI for Azure Storage, etc.
        /// </summary>
        public virtual string FileSource { get; internal set; }
        /// <summary>
        ///   Space-separated list of valid exit codes, as integers.
        /// </summary>
        public virtual IReadOnlyList<string> ExitCodes => ExitCodesInternal.AsReadOnly();
        internal List<string> ExitCodesInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Space-separated list of inline script lines to customize the image with.
        /// </summary>
        public virtual IReadOnlyList<string> InlineScript => InlineScriptInternal.AsReadOnly();
        internal List<string> InlineScriptInternal { get; set; } = new List<string>();
        /// <summary>
        ///   URL of script to customize the image with. The URL must be publicly accessible.
        /// </summary>
        public virtual string ScriptUrl { get; internal set; }
        /// <summary>
        ///   Command to verify that restart succeeded.
        /// </summary>
        public virtual string RestartCheckCommand { get; internal set; }
        /// <summary>
        ///   Command to execute the restart operation.
        /// </summary>
        public virtual string RestartCommand { get; internal set; }
        /// <summary>
        ///   Restart timeout specified as a string consisting of a magnitude and unit, e.g. '5m' (5 minutes) or '2h' (2 hours).
        /// </summary>
        public virtual string RestartTimeout { get; internal set; }
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
              .Add("image template customizer add")
              .Add("--customizer-name {value}", CustomizerName)
              .Add("--type {value}", Type)
              .Add("--defer {value}", Defer)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--dest-path {value}", DestPath)
              .Add("--file-source {value}", FileSource)
              .Add("--exit-codes {value}", ExitCodes, separator: ' ')
              .Add("--inline-script {value}", InlineScript, separator: ' ')
              .Add("--script-url {value}", ScriptUrl)
              .Add("--restart-check-command {value}", RestartCheckCommand)
              .Add("--restart-command {value}", RestartCommand)
              .Add("--restart-timeout {value}", RestartTimeout)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureImageTemplateCustomizerClearSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateCustomizerClearSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.
        /// </summary>
        public virtual string Defer { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the image template.
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
              .Add("image template customizer clear")
              .Add("--defer {value}", Defer)
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
    #region AzureImageTemplateCustomizerRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageTemplateCustomizerRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureImage executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        public override Action<OutputType, string> CustomLogger => AzureImageTasks.AzureImageLogger;
        /// <summary>
        ///   Name of the customizer.
        /// </summary>
        public virtual string CustomizerName { get; internal set; }
        /// <summary>
        ///   Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.
        /// </summary>
        public virtual string Defer { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the image template.
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
              .Add("image template customizer remove")
              .Add("--customizer-name {value}", CustomizerName)
              .Add("--defer {value}", Defer)
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
    #region AzureImageCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.Name"/></em></p>
        ///   <p>New image name.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetName(this AzureImageCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.Name"/></em></p>
        ///   <p>New image name.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetName(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetResourceGroup(this AzureImageCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetResourceGroup(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Source
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.Source"/></em></p>
        ///   <p>OS disk source from the same region, including a virtual machine ID or name, OS disk blob URI, managed OS disk ID or name, or OS snapshot ID or name.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetSource(this AzureImageCreateSettings toolSettings, string source)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = source;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.Source"/></em></p>
        ///   <p>OS disk source from the same region, including a virtual machine ID or name, OS disk blob URI, managed OS disk ID or name, or OS snapshot ID or name.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetSource(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = null;
            return toolSettings;
        }
        #endregion
        #region DataDiskSources
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.DataDiskSources"/> to a new list</em></p>
        ///   <p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetDataDiskSources(this AzureImageCreateSettings toolSettings, params string[] dataDiskSources)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSourcesInternal = dataDiskSources.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.DataDiskSources"/> to a new list</em></p>
        ///   <p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetDataDiskSources(this AzureImageCreateSettings toolSettings, IEnumerable<string> dataDiskSources)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSourcesInternal = dataDiskSources.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageCreateSettings.DataDiskSources"/></em></p>
        ///   <p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings AddDataDiskSources(this AzureImageCreateSettings toolSettings, params string[] dataDiskSources)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSourcesInternal.AddRange(dataDiskSources);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageCreateSettings.DataDiskSources"/></em></p>
        ///   <p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings AddDataDiskSources(this AzureImageCreateSettings toolSettings, IEnumerable<string> dataDiskSources)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSourcesInternal.AddRange(dataDiskSources);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageCreateSettings.DataDiskSources"/></em></p>
        ///   <p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ClearDataDiskSources(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSourcesInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageCreateSettings.DataDiskSources"/></em></p>
        ///   <p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings RemoveDataDiskSources(this AzureImageCreateSettings toolSettings, params string[] dataDiskSources)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(dataDiskSources);
            toolSettings.DataDiskSourcesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageCreateSettings.DataDiskSources"/></em></p>
        ///   <p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings RemoveDataDiskSources(this AzureImageCreateSettings toolSettings, IEnumerable<string> dataDiskSources)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(dataDiskSources);
            toolSettings.DataDiskSourcesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region HyperVGeneration
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.HyperVGeneration"/></em></p>
        ///   <p>The hypervisor generation of the Virtual Machine created from the image.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetHyperVGeneration(this AzureImageCreateSettings toolSettings, ImageCreateHyperVGeneration hyperVGeneration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HyperVGeneration = hyperVGeneration;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.HyperVGeneration"/></em></p>
        ///   <p>The hypervisor generation of the Virtual Machine created from the image.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetHyperVGeneration(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HyperVGeneration = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetLocation(this AzureImageCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetLocation(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region OsDiskCaching
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.OsDiskCaching"/></em></p>
        ///   <p>Storage caching type for the image's OS disk.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetOsDiskCaching(this AzureImageCreateSettings toolSettings, ImageCreateOsDiskCaching osDiskCaching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDiskCaching = osDiskCaching;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.OsDiskCaching"/></em></p>
        ///   <p>Storage caching type for the image's OS disk.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetOsDiskCaching(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsDiskCaching = null;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.OsType"/></em></p>
        ///   <p></p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetOsType(this AzureImageCreateSettings toolSettings, ImageCreateOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.OsType"/></em></p>
        ///   <p></p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetOsType(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region StorageSku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.StorageSku"/></em></p>
        ///   <p>The SKU of the storage account with which to create the VM image. Unused if source VM is specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetStorageSku(this AzureImageCreateSettings toolSettings, ImageCreateStorageSku storageSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSku = storageSku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.StorageSku"/></em></p>
        ///   <p>The SKU of the storage account with which to create the VM image. Unused if source VM is specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetStorageSku(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSku = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetTags(this AzureImageCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetTags(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region ZoneResilient
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.ZoneResilient"/></em></p>
        ///   <p>Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetZoneResilient(this AzureImageCreateSettings toolSettings, bool? zoneResilient)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZoneResilient = zoneResilient;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.ZoneResilient"/></em></p>
        ///   <p>Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetZoneResilient(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZoneResilient = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureImageCreateSettings.ZoneResilient"/></em></p>
        ///   <p>Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings EnableZoneResilient(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZoneResilient = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureImageCreateSettings.ZoneResilient"/></em></p>
        ///   <p>Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings DisableZoneResilient(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZoneResilient = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureImageCreateSettings.ZoneResilient"/></em></p>
        ///   <p>Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ToggleZoneResilient(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZoneResilient = !toolSettings.ZoneResilient;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetSubscription(this AzureImageCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetSubscription(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetDebug(this AzureImageCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetDebug(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetHelp(this AzureImageCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetHelp(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetOutput(this AzureImageCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetOutput(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetQuery(this AzureImageCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetQuery(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings SetVerbose(this AzureImageCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageCreateSettings ResetVerbose(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings SetIds(this AzureImageDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings SetIds(this AzureImageDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings AddIds(this AzureImageDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings AddIds(this AzureImageDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings ClearIds(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings RemoveIds(this AzureImageDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings RemoveIds(this AzureImageDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageDeleteSettings.Name"/></em></p>
        ///   <p>The name of the image.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings SetName(this AzureImageDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageDeleteSettings.Name"/></em></p>
        ///   <p>The name of the image.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings ResetName(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings SetResourceGroup(this AzureImageDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings ResetResourceGroup(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings SetSubscription(this AzureImageDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings ResetSubscription(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings SetDebug(this AzureImageDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings ResetDebug(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings SetHelp(this AzureImageDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings ResetHelp(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings SetOutput(this AzureImageDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings ResetOutput(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings SetQuery(this AzureImageDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings ResetQuery(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings SetVerbose(this AzureImageDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageDeleteSettings ResetVerbose(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings SetResourceGroup(this AzureImageListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings ResetResourceGroup(this AzureImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings SetSubscription(this AzureImageListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings ResetSubscription(this AzureImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings SetDebug(this AzureImageListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings ResetDebug(this AzureImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings SetHelp(this AzureImageListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings ResetHelp(this AzureImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings SetOutput(this AzureImageListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings ResetOutput(this AzureImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings SetQuery(this AzureImageListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings ResetQuery(this AzureImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings SetVerbose(this AzureImageListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageListSettings ResetVerbose(this AzureImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageShowSettingsExtensions
    {
        #region Expand
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageShowSettings.Expand"/></em></p>
        ///   <p>The expand expression to apply on the operation.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings SetExpand(this AzureImageShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageShowSettings.Expand"/></em></p>
        ///   <p>The expand expression to apply on the operation.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings ResetExpand(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings SetIds(this AzureImageShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings SetIds(this AzureImageShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings AddIds(this AzureImageShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings AddIds(this AzureImageShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings ClearIds(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings RemoveIds(this AzureImageShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings RemoveIds(this AzureImageShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageShowSettings.Name"/></em></p>
        ///   <p>The name of the image.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings SetName(this AzureImageShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageShowSettings.Name"/></em></p>
        ///   <p>The name of the image.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings ResetName(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings SetResourceGroup(this AzureImageShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings ResetResourceGroup(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings SetSubscription(this AzureImageShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings ResetSubscription(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings SetDebug(this AzureImageShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings ResetDebug(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings SetHelp(this AzureImageShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings ResetHelp(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings SetOutput(this AzureImageShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings ResetOutput(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings SetQuery(this AzureImageShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings ResetQuery(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings SetVerbose(this AzureImageShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageShowSettings ResetVerbose(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageUpdateSettingsExtensions
    {
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetTags(this AzureImageUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ResetTags(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetIds(this AzureImageUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetIds(this AzureImageUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings AddIds(this AzureImageUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings AddIds(this AzureImageUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ClearIds(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings RemoveIds(this AzureImageUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings RemoveIds(this AzureImageUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.Name"/></em></p>
        ///   <p>The name of the image.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetName(this AzureImageUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageUpdateSettings.Name"/></em></p>
        ///   <p>The name of the image.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ResetName(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetResourceGroup(this AzureImageUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ResetResourceGroup(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetSubscription(this AzureImageUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ResetSubscription(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetAdd(this AzureImageUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ResetAdd(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetForceString(this AzureImageUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ResetForceString(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetRemove(this AzureImageUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ResetRemove(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetSet(this AzureImageUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ResetSet(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetDebug(this AzureImageUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ResetDebug(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetHelp(this AzureImageUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ResetHelp(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetOutput(this AzureImageUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ResetOutput(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetQuery(this AzureImageUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ResetQuery(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings SetVerbose(this AzureImageUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageUpdateSettings ResetVerbose(this AzureImageUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetName(this AzureImageTemplateCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetName(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetResourceGroup(this AzureImageTemplateCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetResourceGroup(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region BuildTimeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.BuildTimeout"/></em></p>
        ///   <p>The Maximum duration to wait while building the image template, in minutes. Default is 60.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetBuildTimeout(this AzureImageTemplateCreateSettings toolSettings, string buildTimeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildTimeout = buildTimeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.BuildTimeout"/></em></p>
        ///   <p>The Maximum duration to wait while building the image template, in minutes. Default is 60.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetBuildTimeout(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildTimeout = null;
            return toolSettings;
        }
        #endregion
        #region Defer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetDefer(this AzureImageTemplateCreateSettings toolSettings, string defer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = defer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetDefer(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetLocation(this AzureImageTemplateCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetLocation(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetNoWait(this AzureImageTemplateCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetNoWait(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureImageTemplateCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings EnableNoWait(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureImageTemplateCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings DisableNoWait(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureImageTemplateCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ToggleNoWait(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetTags(this AzureImageTemplateCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetTags(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Scripts
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.Scripts"/> to a new list</em></p>
        ///   <p>Space-separated list of shell or powershell scripts to customize the image with. Each script must be a publicly accessible URL. Infers type of script from file extension ('.sh' or'.ps1') or from source type. More more customizer options and flexibility, see: 'az image template customizer add'.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetScripts(this AzureImageTemplateCreateSettings toolSettings, params string[] scripts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptsInternal = scripts.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.Scripts"/> to a new list</em></p>
        ///   <p>Space-separated list of shell or powershell scripts to customize the image with. Each script must be a publicly accessible URL. Infers type of script from file extension ('.sh' or'.ps1') or from source type. More more customizer options and flexibility, see: 'az image template customizer add'.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetScripts(this AzureImageTemplateCreateSettings toolSettings, IEnumerable<string> scripts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptsInternal = scripts.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateCreateSettings.Scripts"/></em></p>
        ///   <p>Space-separated list of shell or powershell scripts to customize the image with. Each script must be a publicly accessible URL. Infers type of script from file extension ('.sh' or'.ps1') or from source type. More more customizer options and flexibility, see: 'az image template customizer add'.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings AddScripts(this AzureImageTemplateCreateSettings toolSettings, params string[] scripts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptsInternal.AddRange(scripts);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateCreateSettings.Scripts"/></em></p>
        ///   <p>Space-separated list of shell or powershell scripts to customize the image with. Each script must be a publicly accessible URL. Infers type of script from file extension ('.sh' or'.ps1') or from source type. More more customizer options and flexibility, see: 'az image template customizer add'.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings AddScripts(this AzureImageTemplateCreateSettings toolSettings, IEnumerable<string> scripts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptsInternal.AddRange(scripts);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateCreateSettings.Scripts"/></em></p>
        ///   <p>Space-separated list of shell or powershell scripts to customize the image with. Each script must be a publicly accessible URL. Infers type of script from file extension ('.sh' or'.ps1') or from source type. More more customizer options and flexibility, see: 'az image template customizer add'.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ClearScripts(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateCreateSettings.Scripts"/></em></p>
        ///   <p>Space-separated list of shell or powershell scripts to customize the image with. Each script must be a publicly accessible URL. Infers type of script from file extension ('.sh' or'.ps1') or from source type. More more customizer options and flexibility, see: 'az image template customizer add'.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings RemoveScripts(this AzureImageTemplateCreateSettings toolSettings, params string[] scripts)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(scripts);
            toolSettings.ScriptsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateCreateSettings.Scripts"/></em></p>
        ///   <p>Space-separated list of shell or powershell scripts to customize the image with. Each script must be a publicly accessible URL. Infers type of script from file extension ('.sh' or'.ps1') or from source type. More more customizer options and flexibility, see: 'az image template customizer add'.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings RemoveScripts(this AzureImageTemplateCreateSettings toolSettings, IEnumerable<string> scripts)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(scripts);
            toolSettings.ScriptsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Checksum
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.Checksum"/></em></p>
        ///   <p>The SHA256 checksum of the Red Hat ISO image.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetChecksum(this AzureImageTemplateCreateSettings toolSettings, string checksum)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Checksum = checksum;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.Checksum"/></em></p>
        ///   <p>The SHA256 checksum of the Red Hat ISO image.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetChecksum(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Checksum = null;
            return toolSettings;
        }
        #endregion
        #region ImageSource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.ImageSource"/></em></p>
        ///   <p>The base image to customize. Must be a valid platform image URN, platform image alias, Red Hat ISO image URI, managed image name/ID, or shared image version ID.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetImageSource(this AzureImageTemplateCreateSettings toolSettings, string imageSource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageSource = imageSource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.ImageSource"/></em></p>
        ///   <p>The base image to customize. Must be a valid platform image URN, platform image alias, Red Hat ISO image URI, managed image name/ID, or shared image version ID.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetImageSource(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageSource = null;
            return toolSettings;
        }
        #endregion
        #region ManagedImageDestinations
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.ManagedImageDestinations"/></em></p>
        ///   <p>Managed image output distributor information. Space-separated list of key-value pairs. E.g "image_1=westus2 image_2=westus". Each key is the name or resource ID of the managed image to be created. Each value is the location of the image.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetManagedImageDestinations(this AzureImageTemplateCreateSettings toolSettings, string managedImageDestinations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagedImageDestinations = managedImageDestinations;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.ManagedImageDestinations"/></em></p>
        ///   <p>Managed image output distributor information. Space-separated list of key-value pairs. E.g "image_1=westus2 image_2=westus". Each key is the name or resource ID of the managed image to be created. Each value is the location of the image.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetManagedImageDestinations(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagedImageDestinations = null;
            return toolSettings;
        }
        #endregion
        #region SharedImageDestinations
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.SharedImageDestinations"/></em></p>
        ///   <p>Shared image gallery (sig) output distributor information. Space-separated list of key-value pairs. E.g "my_gallery_1/image_def_1=eastus,westus  my_gallery_2/image_def_2=uksouth,canadaeast,francesouth." Each key is the sig image definition ID or sig gallery name and sig image definition delimited by a "/". Each value is a comma-delimited list of replica locations.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetSharedImageDestinations(this AzureImageTemplateCreateSettings toolSettings, string sharedImageDestinations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SharedImageDestinations = sharedImageDestinations;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.SharedImageDestinations"/></em></p>
        ///   <p>Shared image gallery (sig) output distributor information. Space-separated list of key-value pairs. E.g "my_gallery_1/image_def_1=eastus,westus  my_gallery_2/image_def_2=uksouth,canadaeast,francesouth." Each key is the sig image definition ID or sig gallery name and sig image definition delimited by a "/". Each value is a comma-delimited list of replica locations.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetSharedImageDestinations(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SharedImageDestinations = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetSubscription(this AzureImageTemplateCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetSubscription(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetDebug(this AzureImageTemplateCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetDebug(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetHelp(this AzureImageTemplateCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetHelp(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetOutput(this AzureImageTemplateCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetOutput(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetQuery(this AzureImageTemplateCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetQuery(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings SetVerbose(this AzureImageTemplateCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCreateSettings ResetVerbose(this AzureImageTemplateCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings SetIds(this AzureImageTemplateDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings SetIds(this AzureImageTemplateDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings AddIds(this AzureImageTemplateDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings AddIds(this AzureImageTemplateDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings ClearIds(this AzureImageTemplateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings RemoveIds(this AzureImageTemplateDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings RemoveIds(this AzureImageTemplateDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateDeleteSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings SetName(this AzureImageTemplateDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateDeleteSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings ResetName(this AzureImageTemplateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings SetResourceGroup(this AzureImageTemplateDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings ResetResourceGroup(this AzureImageTemplateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings SetSubscription(this AzureImageTemplateDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings ResetSubscription(this AzureImageTemplateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings SetDebug(this AzureImageTemplateDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings ResetDebug(this AzureImageTemplateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings SetHelp(this AzureImageTemplateDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings ResetHelp(this AzureImageTemplateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings SetOutput(this AzureImageTemplateDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings ResetOutput(this AzureImageTemplateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings SetQuery(this AzureImageTemplateDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings ResetQuery(this AzureImageTemplateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings SetVerbose(this AzureImageTemplateDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateDeleteSettings ResetVerbose(this AzureImageTemplateDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings SetResourceGroup(this AzureImageTemplateListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings ResetResourceGroup(this AzureImageTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings SetSubscription(this AzureImageTemplateListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings ResetSubscription(this AzureImageTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings SetDebug(this AzureImageTemplateListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings ResetDebug(this AzureImageTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings SetHelp(this AzureImageTemplateListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings ResetHelp(this AzureImageTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings SetOutput(this AzureImageTemplateListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings ResetOutput(this AzureImageTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings SetQuery(this AzureImageTemplateListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings ResetQuery(this AzureImageTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings SetVerbose(this AzureImageTemplateListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateListSettings ResetVerbose(this AzureImageTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateRunSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateRunSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateRunSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings SetNoWait(this AzureImageTemplateRunSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateRunSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings ResetNoWait(this AzureImageTemplateRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureImageTemplateRunSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings EnableNoWait(this AzureImageTemplateRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureImageTemplateRunSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings DisableNoWait(this AzureImageTemplateRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureImageTemplateRunSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings ToggleNoWait(this AzureImageTemplateRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateRunSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings SetIds(this AzureImageTemplateRunSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateRunSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings SetIds(this AzureImageTemplateRunSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateRunSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings AddIds(this AzureImageTemplateRunSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateRunSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings AddIds(this AzureImageTemplateRunSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateRunSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings ClearIds(this AzureImageTemplateRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateRunSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings RemoveIds(this AzureImageTemplateRunSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateRunSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings RemoveIds(this AzureImageTemplateRunSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateRunSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings SetName(this AzureImageTemplateRunSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateRunSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings ResetName(this AzureImageTemplateRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateRunSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings SetResourceGroup(this AzureImageTemplateRunSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateRunSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings ResetResourceGroup(this AzureImageTemplateRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateRunSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings SetSubscription(this AzureImageTemplateRunSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateRunSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings ResetSubscription(this AzureImageTemplateRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateRunSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings SetDebug(this AzureImageTemplateRunSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateRunSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings ResetDebug(this AzureImageTemplateRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateRunSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings SetHelp(this AzureImageTemplateRunSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateRunSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings ResetHelp(this AzureImageTemplateRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateRunSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings SetOutput(this AzureImageTemplateRunSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateRunSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings ResetOutput(this AzureImageTemplateRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateRunSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings SetQuery(this AzureImageTemplateRunSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateRunSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings ResetQuery(this AzureImageTemplateRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateRunSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings SetVerbose(this AzureImageTemplateRunSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateRunSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateRunSettings ResetVerbose(this AzureImageTemplateRunSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings SetIds(this AzureImageTemplateShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings SetIds(this AzureImageTemplateShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings AddIds(this AzureImageTemplateShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings AddIds(this AzureImageTemplateShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings ClearIds(this AzureImageTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings RemoveIds(this AzureImageTemplateShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings RemoveIds(this AzureImageTemplateShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings SetName(this AzureImageTemplateShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings ResetName(this AzureImageTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings SetResourceGroup(this AzureImageTemplateShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings ResetResourceGroup(this AzureImageTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings SetSubscription(this AzureImageTemplateShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings ResetSubscription(this AzureImageTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings SetDebug(this AzureImageTemplateShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings ResetDebug(this AzureImageTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings SetHelp(this AzureImageTemplateShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings ResetHelp(this AzureImageTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings SetOutput(this AzureImageTemplateShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings ResetOutput(this AzureImageTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings SetQuery(this AzureImageTemplateShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings ResetQuery(this AzureImageTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings SetVerbose(this AzureImageTemplateShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowSettings ResetVerbose(this AzureImageTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateShowRunsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateShowRunsSettingsExtensions
    {
        #region OutputName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowRunsSettings.OutputName"/></em></p>
        ///   <p>Name of the image builder run output.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings SetOutputName(this AzureImageTemplateShowRunsSettings toolSettings, string outputName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputName = outputName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowRunsSettings.OutputName"/></em></p>
        ///   <p>Name of the image builder run output.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings ResetOutputName(this AzureImageTemplateShowRunsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowRunsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings SetIds(this AzureImageTemplateShowRunsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowRunsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings SetIds(this AzureImageTemplateShowRunsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateShowRunsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings AddIds(this AzureImageTemplateShowRunsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateShowRunsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings AddIds(this AzureImageTemplateShowRunsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateShowRunsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings ClearIds(this AzureImageTemplateShowRunsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateShowRunsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings RemoveIds(this AzureImageTemplateShowRunsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateShowRunsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings RemoveIds(this AzureImageTemplateShowRunsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowRunsSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings SetName(this AzureImageTemplateShowRunsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowRunsSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings ResetName(this AzureImageTemplateShowRunsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowRunsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings SetResourceGroup(this AzureImageTemplateShowRunsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowRunsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings ResetResourceGroup(this AzureImageTemplateShowRunsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowRunsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings SetSubscription(this AzureImageTemplateShowRunsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowRunsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings ResetSubscription(this AzureImageTemplateShowRunsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowRunsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings SetDebug(this AzureImageTemplateShowRunsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowRunsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings ResetDebug(this AzureImageTemplateShowRunsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowRunsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings SetHelp(this AzureImageTemplateShowRunsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowRunsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings ResetHelp(this AzureImageTemplateShowRunsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowRunsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings SetOutput(this AzureImageTemplateShowRunsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowRunsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings ResetOutput(this AzureImageTemplateShowRunsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowRunsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings SetQuery(this AzureImageTemplateShowRunsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowRunsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings ResetQuery(this AzureImageTemplateShowRunsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateShowRunsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings SetVerbose(this AzureImageTemplateShowRunsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateShowRunsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateShowRunsSettings ResetVerbose(this AzureImageTemplateShowRunsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateUpdateSettingsExtensions
    {
        #region Defer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetDefer(this AzureImageTemplateUpdateSettings toolSettings, string defer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = defer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateUpdateSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ResetDefer(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetIds(this AzureImageTemplateUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetIds(this AzureImageTemplateUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings AddIds(this AzureImageTemplateUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings AddIds(this AzureImageTemplateUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ClearIds(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings RemoveIds(this AzureImageTemplateUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings RemoveIds(this AzureImageTemplateUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetName(this AzureImageTemplateUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateUpdateSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ResetName(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetResourceGroup(this AzureImageTemplateUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ResetResourceGroup(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetSubscription(this AzureImageTemplateUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ResetSubscription(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetAdd(this AzureImageTemplateUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ResetAdd(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetForceString(this AzureImageTemplateUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ResetForceString(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetRemove(this AzureImageTemplateUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ResetRemove(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetSet(this AzureImageTemplateUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ResetSet(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetDebug(this AzureImageTemplateUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ResetDebug(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetHelp(this AzureImageTemplateUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ResetHelp(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetOutput(this AzureImageTemplateUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ResetOutput(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetQuery(this AzureImageTemplateUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ResetQuery(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings SetVerbose(this AzureImageTemplateUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateUpdateSettings ResetVerbose(this AzureImageTemplateUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateWaitSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetIds(this AzureImageTemplateWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetIds(this AzureImageTemplateWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings AddIds(this AzureImageTemplateWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings AddIds(this AzureImageTemplateWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ClearIds(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings RemoveIds(this AzureImageTemplateWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings RemoveIds(this AzureImageTemplateWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetName(this AzureImageTemplateWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetName(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetResourceGroup(this AzureImageTemplateWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetResourceGroup(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetSubscription(this AzureImageTemplateWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetSubscription(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetCreated(this AzureImageTemplateWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetCreated(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetCustom(this AzureImageTemplateWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetCustom(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetDeleted(this AzureImageTemplateWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetDeleted(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetExists(this AzureImageTemplateWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetExists(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetInterval(this AzureImageTemplateWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetInterval(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetTimeout(this AzureImageTemplateWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetTimeout(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetUpdated(this AzureImageTemplateWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetUpdated(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetDebug(this AzureImageTemplateWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetDebug(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetHelp(this AzureImageTemplateWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetHelp(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetOutput(this AzureImageTemplateWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetOutput(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetQuery(this AzureImageTemplateWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetQuery(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings SetVerbose(this AzureImageTemplateWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateWaitSettings ResetVerbose(this AzureImageTemplateWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateOutputAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateOutputAddSettingsExtensions
    {
        #region ArtifactTags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.ArtifactTags"/></em></p>
        ///   <p>Tags that will be applied to the output artifact once it has been created by the distributor. space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetArtifactTags(this AzureImageTemplateOutputAddSettings toolSettings, string artifactTags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactTags = artifactTags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.ArtifactTags"/></em></p>
        ///   <p>Tags that will be applied to the output artifact once it has been created by the distributor. space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetArtifactTags(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactTags = null;
            return toolSettings;
        }
        #endregion
        #region Defer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetDefer(this AzureImageTemplateOutputAddSettings toolSettings, string defer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = defer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetDefer(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = null;
            return toolSettings;
        }
        #endregion
        #region OutputName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.OutputName"/></em></p>
        ///   <p>Name of the image builder run output. Defaults to the name of the managed image or sig image definition.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetOutputName(this AzureImageTemplateOutputAddSettings toolSettings, string outputName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputName = outputName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.OutputName"/></em></p>
        ///   <p>Name of the image builder run output. Defaults to the name of the managed image or sig image definition.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetOutputName(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetIds(this AzureImageTemplateOutputAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetIds(this AzureImageTemplateOutputAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateOutputAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings AddIds(this AzureImageTemplateOutputAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateOutputAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings AddIds(this AzureImageTemplateOutputAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateOutputAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ClearIds(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateOutputAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings RemoveIds(this AzureImageTemplateOutputAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateOutputAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings RemoveIds(this AzureImageTemplateOutputAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetName(this AzureImageTemplateOutputAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetName(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetResourceGroup(this AzureImageTemplateOutputAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetResourceGroup(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetSubscription(this AzureImageTemplateOutputAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetSubscription(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region ManagedImage
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.ManagedImage"/></em></p>
        ///   <p>Name or ID of the customized managed image to be created.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetManagedImage(this AzureImageTemplateOutputAddSettings toolSettings, string managedImage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagedImage = managedImage;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.ManagedImage"/></em></p>
        ///   <p>Name or ID of the customized managed image to be created.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetManagedImage(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagedImage = null;
            return toolSettings;
        }
        #endregion
        #region ManagedImageLocation
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.ManagedImageLocation"/></em></p>
        ///   <p>Location where the customized image will be created. Defaults to resource group's location.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetManagedImageLocation(this AzureImageTemplateOutputAddSettings toolSettings, string managedImageLocation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagedImageLocation = managedImageLocation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.ManagedImageLocation"/></em></p>
        ///   <p>Location where the customized image will be created. Defaults to resource group's location.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetManagedImageLocation(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManagedImageLocation = null;
            return toolSettings;
        }
        #endregion
        #region GalleryImageDefinition
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Name or ID of the existing SIG image definition to create the customized image version with.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetGalleryImageDefinition(this AzureImageTemplateOutputAddSettings toolSettings, string galleryImageDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = galleryImageDefinition;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.GalleryImageDefinition"/></em></p>
        ///   <p>Name or ID of the existing SIG image definition to create the customized image version with.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetGalleryImageDefinition(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryImageDefinition = null;
            return toolSettings;
        }
        #endregion
        #region GalleryName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.GalleryName"/></em></p>
        ///   <p>Shared image gallery name, if image definition name and not ID was provided.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetGalleryName(this AzureImageTemplateOutputAddSettings toolSettings, string galleryName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = galleryName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.GalleryName"/></em></p>
        ///   <p>Shared image gallery name, if image definition name and not ID was provided.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetGalleryName(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryName = null;
            return toolSettings;
        }
        #endregion
        #region GalleryReplicationRegions
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.GalleryReplicationRegions"/> to a new list</em></p>
        ///   <p>Space-separated list of regions to replicate the image version into. Defaults to resource group's location.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetGalleryReplicationRegions(this AzureImageTemplateOutputAddSettings toolSettings, params string[] galleryReplicationRegions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryReplicationRegionsInternal = galleryReplicationRegions.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.GalleryReplicationRegions"/> to a new list</em></p>
        ///   <p>Space-separated list of regions to replicate the image version into. Defaults to resource group's location.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetGalleryReplicationRegions(this AzureImageTemplateOutputAddSettings toolSettings, IEnumerable<string> galleryReplicationRegions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryReplicationRegionsInternal = galleryReplicationRegions.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateOutputAddSettings.GalleryReplicationRegions"/></em></p>
        ///   <p>Space-separated list of regions to replicate the image version into. Defaults to resource group's location.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings AddGalleryReplicationRegions(this AzureImageTemplateOutputAddSettings toolSettings, params string[] galleryReplicationRegions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryReplicationRegionsInternal.AddRange(galleryReplicationRegions);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateOutputAddSettings.GalleryReplicationRegions"/></em></p>
        ///   <p>Space-separated list of regions to replicate the image version into. Defaults to resource group's location.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings AddGalleryReplicationRegions(this AzureImageTemplateOutputAddSettings toolSettings, IEnumerable<string> galleryReplicationRegions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryReplicationRegionsInternal.AddRange(galleryReplicationRegions);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateOutputAddSettings.GalleryReplicationRegions"/></em></p>
        ///   <p>Space-separated list of regions to replicate the image version into. Defaults to resource group's location.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ClearGalleryReplicationRegions(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GalleryReplicationRegionsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateOutputAddSettings.GalleryReplicationRegions"/></em></p>
        ///   <p>Space-separated list of regions to replicate the image version into. Defaults to resource group's location.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings RemoveGalleryReplicationRegions(this AzureImageTemplateOutputAddSettings toolSettings, params string[] galleryReplicationRegions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(galleryReplicationRegions);
            toolSettings.GalleryReplicationRegionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateOutputAddSettings.GalleryReplicationRegions"/></em></p>
        ///   <p>Space-separated list of regions to replicate the image version into. Defaults to resource group's location.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings RemoveGalleryReplicationRegions(this AzureImageTemplateOutputAddSettings toolSettings, IEnumerable<string> galleryReplicationRegions)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(galleryReplicationRegions);
            toolSettings.GalleryReplicationRegionsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region IsVhd
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.IsVhd"/></em></p>
        ///   <p>The output is a VHD distributor.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetIsVhd(this AzureImageTemplateOutputAddSettings toolSettings, string isVhd)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsVhd = isVhd;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.IsVhd"/></em></p>
        ///   <p>The output is a VHD distributor.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetIsVhd(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsVhd = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetDebug(this AzureImageTemplateOutputAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetDebug(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetHelp(this AzureImageTemplateOutputAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetHelp(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetOutput(this AzureImageTemplateOutputAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetOutput(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetQuery(this AzureImageTemplateOutputAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetQuery(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings SetVerbose(this AzureImageTemplateOutputAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputAddSettings ResetVerbose(this AzureImageTemplateOutputAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateOutputClearSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateOutputClearSettingsExtensions
    {
        #region Defer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputClearSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings SetDefer(this AzureImageTemplateOutputClearSettings toolSettings, string defer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = defer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputClearSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings ResetDefer(this AzureImageTemplateOutputClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputClearSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings SetIds(this AzureImageTemplateOutputClearSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputClearSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings SetIds(this AzureImageTemplateOutputClearSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateOutputClearSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings AddIds(this AzureImageTemplateOutputClearSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateOutputClearSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings AddIds(this AzureImageTemplateOutputClearSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateOutputClearSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings ClearIds(this AzureImageTemplateOutputClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateOutputClearSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings RemoveIds(this AzureImageTemplateOutputClearSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateOutputClearSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings RemoveIds(this AzureImageTemplateOutputClearSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputClearSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings SetName(this AzureImageTemplateOutputClearSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputClearSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings ResetName(this AzureImageTemplateOutputClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputClearSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings SetResourceGroup(this AzureImageTemplateOutputClearSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputClearSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings ResetResourceGroup(this AzureImageTemplateOutputClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputClearSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings SetSubscription(this AzureImageTemplateOutputClearSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputClearSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings ResetSubscription(this AzureImageTemplateOutputClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputClearSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings SetDebug(this AzureImageTemplateOutputClearSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputClearSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings ResetDebug(this AzureImageTemplateOutputClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputClearSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings SetHelp(this AzureImageTemplateOutputClearSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputClearSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings ResetHelp(this AzureImageTemplateOutputClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputClearSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings SetOutput(this AzureImageTemplateOutputClearSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputClearSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings ResetOutput(this AzureImageTemplateOutputClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputClearSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings SetQuery(this AzureImageTemplateOutputClearSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputClearSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings ResetQuery(this AzureImageTemplateOutputClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputClearSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings SetVerbose(this AzureImageTemplateOutputClearSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputClearSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputClearSettings ResetVerbose(this AzureImageTemplateOutputClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateOutputRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateOutputRemoveSettingsExtensions
    {
        #region OutputName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputRemoveSettings.OutputName"/></em></p>
        ///   <p>Name of the image builder run output.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings SetOutputName(this AzureImageTemplateOutputRemoveSettings toolSettings, string outputName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputName = outputName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputRemoveSettings.OutputName"/></em></p>
        ///   <p>Name of the image builder run output.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings ResetOutputName(this AzureImageTemplateOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputName = null;
            return toolSettings;
        }
        #endregion
        #region Defer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputRemoveSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings SetDefer(this AzureImageTemplateOutputRemoveSettings toolSettings, string defer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = defer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputRemoveSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings ResetDefer(this AzureImageTemplateOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputRemoveSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings SetIds(this AzureImageTemplateOutputRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputRemoveSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings SetIds(this AzureImageTemplateOutputRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateOutputRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings AddIds(this AzureImageTemplateOutputRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateOutputRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings AddIds(this AzureImageTemplateOutputRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateOutputRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings ClearIds(this AzureImageTemplateOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateOutputRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings RemoveIds(this AzureImageTemplateOutputRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateOutputRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings RemoveIds(this AzureImageTemplateOutputRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputRemoveSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings SetName(this AzureImageTemplateOutputRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputRemoveSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings ResetName(this AzureImageTemplateOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings SetResourceGroup(this AzureImageTemplateOutputRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings ResetResourceGroup(this AzureImageTemplateOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings SetSubscription(this AzureImageTemplateOutputRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings ResetSubscription(this AzureImageTemplateOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings SetDebug(this AzureImageTemplateOutputRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings ResetDebug(this AzureImageTemplateOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings SetHelp(this AzureImageTemplateOutputRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings ResetHelp(this AzureImageTemplateOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings SetOutput(this AzureImageTemplateOutputRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings ResetOutput(this AzureImageTemplateOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings SetQuery(this AzureImageTemplateOutputRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings ResetQuery(this AzureImageTemplateOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateOutputRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings SetVerbose(this AzureImageTemplateOutputRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateOutputRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateOutputRemoveSettings ResetVerbose(this AzureImageTemplateOutputRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateCustomizerAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateCustomizerAddSettingsExtensions
    {
        #region CustomizerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.CustomizerName"/></em></p>
        ///   <p>Name of the customizer.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetCustomizerName(this AzureImageTemplateCustomizerAddSettings toolSettings, string customizerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomizerName = customizerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.CustomizerName"/></em></p>
        ///   <p>Name of the customizer.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetCustomizerName(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomizerName = null;
            return toolSettings;
        }
        #endregion
        #region Type
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.Type"/></em></p>
        ///   <p>Type of customizer to be added to the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetType(this AzureImageTemplateCustomizerAddSettings toolSettings, ImageTemplateCustomizerAddType type)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = type;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.Type"/></em></p>
        ///   <p>Type of customizer to be added to the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetType(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = null;
            return toolSettings;
        }
        #endregion
        #region Defer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetDefer(this AzureImageTemplateCustomizerAddSettings toolSettings, string defer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = defer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetDefer(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetIds(this AzureImageTemplateCustomizerAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetIds(this AzureImageTemplateCustomizerAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateCustomizerAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings AddIds(this AzureImageTemplateCustomizerAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateCustomizerAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings AddIds(this AzureImageTemplateCustomizerAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateCustomizerAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ClearIds(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateCustomizerAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings RemoveIds(this AzureImageTemplateCustomizerAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateCustomizerAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings RemoveIds(this AzureImageTemplateCustomizerAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetName(this AzureImageTemplateCustomizerAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetName(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetResourceGroup(this AzureImageTemplateCustomizerAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetResourceGroup(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetSubscription(this AzureImageTemplateCustomizerAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetSubscription(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region DestPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.DestPath"/></em></p>
        ///   <p>The absolute destination path where the file specified in --file-source will be downloaded to in the image.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetDestPath(this AzureImageTemplateCustomizerAddSettings toolSettings, string destPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestPath = destPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.DestPath"/></em></p>
        ///   <p>The absolute destination path where the file specified in --file-source will be downloaded to in the image.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetDestPath(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestPath = null;
            return toolSettings;
        }
        #endregion
        #region FileSource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.FileSource"/></em></p>
        ///   <p>The URI of the file to be downloaded into the image. It can be a github link, SAS URI for Azure Storage, etc.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetFileSource(this AzureImageTemplateCustomizerAddSettings toolSettings, string fileSource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileSource = fileSource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.FileSource"/></em></p>
        ///   <p>The URI of the file to be downloaded into the image. It can be a github link, SAS URI for Azure Storage, etc.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetFileSource(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileSource = null;
            return toolSettings;
        }
        #endregion
        #region ExitCodes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.ExitCodes"/> to a new list</em></p>
        ///   <p>Space-separated list of valid exit codes, as integers.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetExitCodes(this AzureImageTemplateCustomizerAddSettings toolSettings, params string[] exitCodes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExitCodesInternal = exitCodes.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.ExitCodes"/> to a new list</em></p>
        ///   <p>Space-separated list of valid exit codes, as integers.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetExitCodes(this AzureImageTemplateCustomizerAddSettings toolSettings, IEnumerable<string> exitCodes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExitCodesInternal = exitCodes.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateCustomizerAddSettings.ExitCodes"/></em></p>
        ///   <p>Space-separated list of valid exit codes, as integers.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings AddExitCodes(this AzureImageTemplateCustomizerAddSettings toolSettings, params string[] exitCodes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExitCodesInternal.AddRange(exitCodes);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateCustomizerAddSettings.ExitCodes"/></em></p>
        ///   <p>Space-separated list of valid exit codes, as integers.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings AddExitCodes(this AzureImageTemplateCustomizerAddSettings toolSettings, IEnumerable<string> exitCodes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExitCodesInternal.AddRange(exitCodes);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateCustomizerAddSettings.ExitCodes"/></em></p>
        ///   <p>Space-separated list of valid exit codes, as integers.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ClearExitCodes(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExitCodesInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateCustomizerAddSettings.ExitCodes"/></em></p>
        ///   <p>Space-separated list of valid exit codes, as integers.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings RemoveExitCodes(this AzureImageTemplateCustomizerAddSettings toolSettings, params string[] exitCodes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(exitCodes);
            toolSettings.ExitCodesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateCustomizerAddSettings.ExitCodes"/></em></p>
        ///   <p>Space-separated list of valid exit codes, as integers.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings RemoveExitCodes(this AzureImageTemplateCustomizerAddSettings toolSettings, IEnumerable<string> exitCodes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(exitCodes);
            toolSettings.ExitCodesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region InlineScript
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.InlineScript"/> to a new list</em></p>
        ///   <p>Space-separated list of inline script lines to customize the image with.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetInlineScript(this AzureImageTemplateCustomizerAddSettings toolSettings, params string[] inlineScript)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InlineScriptInternal = inlineScript.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.InlineScript"/> to a new list</em></p>
        ///   <p>Space-separated list of inline script lines to customize the image with.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetInlineScript(this AzureImageTemplateCustomizerAddSettings toolSettings, IEnumerable<string> inlineScript)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InlineScriptInternal = inlineScript.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateCustomizerAddSettings.InlineScript"/></em></p>
        ///   <p>Space-separated list of inline script lines to customize the image with.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings AddInlineScript(this AzureImageTemplateCustomizerAddSettings toolSettings, params string[] inlineScript)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InlineScriptInternal.AddRange(inlineScript);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateCustomizerAddSettings.InlineScript"/></em></p>
        ///   <p>Space-separated list of inline script lines to customize the image with.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings AddInlineScript(this AzureImageTemplateCustomizerAddSettings toolSettings, IEnumerable<string> inlineScript)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InlineScriptInternal.AddRange(inlineScript);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateCustomizerAddSettings.InlineScript"/></em></p>
        ///   <p>Space-separated list of inline script lines to customize the image with.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ClearInlineScript(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InlineScriptInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateCustomizerAddSettings.InlineScript"/></em></p>
        ///   <p>Space-separated list of inline script lines to customize the image with.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings RemoveInlineScript(this AzureImageTemplateCustomizerAddSettings toolSettings, params string[] inlineScript)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(inlineScript);
            toolSettings.InlineScriptInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateCustomizerAddSettings.InlineScript"/></em></p>
        ///   <p>Space-separated list of inline script lines to customize the image with.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings RemoveInlineScript(this AzureImageTemplateCustomizerAddSettings toolSettings, IEnumerable<string> inlineScript)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(inlineScript);
            toolSettings.InlineScriptInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ScriptUrl
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.ScriptUrl"/></em></p>
        ///   <p>URL of script to customize the image with. The URL must be publicly accessible.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetScriptUrl(this AzureImageTemplateCustomizerAddSettings toolSettings, string scriptUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptUrl = scriptUrl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.ScriptUrl"/></em></p>
        ///   <p>URL of script to customize the image with. The URL must be publicly accessible.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetScriptUrl(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptUrl = null;
            return toolSettings;
        }
        #endregion
        #region RestartCheckCommand
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.RestartCheckCommand"/></em></p>
        ///   <p>Command to verify that restart succeeded.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetRestartCheckCommand(this AzureImageTemplateCustomizerAddSettings toolSettings, string restartCheckCommand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestartCheckCommand = restartCheckCommand;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.RestartCheckCommand"/></em></p>
        ///   <p>Command to verify that restart succeeded.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetRestartCheckCommand(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestartCheckCommand = null;
            return toolSettings;
        }
        #endregion
        #region RestartCommand
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.RestartCommand"/></em></p>
        ///   <p>Command to execute the restart operation.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetRestartCommand(this AzureImageTemplateCustomizerAddSettings toolSettings, string restartCommand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestartCommand = restartCommand;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.RestartCommand"/></em></p>
        ///   <p>Command to execute the restart operation.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetRestartCommand(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestartCommand = null;
            return toolSettings;
        }
        #endregion
        #region RestartTimeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.RestartTimeout"/></em></p>
        ///   <p>Restart timeout specified as a string consisting of a magnitude and unit, e.g. '5m' (5 minutes) or '2h' (2 hours).</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetRestartTimeout(this AzureImageTemplateCustomizerAddSettings toolSettings, string restartTimeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestartTimeout = restartTimeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.RestartTimeout"/></em></p>
        ///   <p>Restart timeout specified as a string consisting of a magnitude and unit, e.g. '5m' (5 minutes) or '2h' (2 hours).</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetRestartTimeout(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestartTimeout = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetDebug(this AzureImageTemplateCustomizerAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetDebug(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetHelp(this AzureImageTemplateCustomizerAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetHelp(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetOutput(this AzureImageTemplateCustomizerAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetOutput(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetQuery(this AzureImageTemplateCustomizerAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetQuery(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings SetVerbose(this AzureImageTemplateCustomizerAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerAddSettings ResetVerbose(this AzureImageTemplateCustomizerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateCustomizerClearSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateCustomizerClearSettingsExtensions
    {
        #region Defer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerClearSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings SetDefer(this AzureImageTemplateCustomizerClearSettings toolSettings, string defer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = defer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerClearSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings ResetDefer(this AzureImageTemplateCustomizerClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerClearSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings SetIds(this AzureImageTemplateCustomizerClearSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerClearSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings SetIds(this AzureImageTemplateCustomizerClearSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateCustomizerClearSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings AddIds(this AzureImageTemplateCustomizerClearSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateCustomizerClearSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings AddIds(this AzureImageTemplateCustomizerClearSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateCustomizerClearSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings ClearIds(this AzureImageTemplateCustomizerClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateCustomizerClearSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings RemoveIds(this AzureImageTemplateCustomizerClearSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateCustomizerClearSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings RemoveIds(this AzureImageTemplateCustomizerClearSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerClearSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings SetName(this AzureImageTemplateCustomizerClearSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerClearSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings ResetName(this AzureImageTemplateCustomizerClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerClearSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings SetResourceGroup(this AzureImageTemplateCustomizerClearSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerClearSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings ResetResourceGroup(this AzureImageTemplateCustomizerClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerClearSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings SetSubscription(this AzureImageTemplateCustomizerClearSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerClearSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings ResetSubscription(this AzureImageTemplateCustomizerClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerClearSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings SetDebug(this AzureImageTemplateCustomizerClearSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerClearSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings ResetDebug(this AzureImageTemplateCustomizerClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerClearSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings SetHelp(this AzureImageTemplateCustomizerClearSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerClearSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings ResetHelp(this AzureImageTemplateCustomizerClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerClearSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings SetOutput(this AzureImageTemplateCustomizerClearSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerClearSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings ResetOutput(this AzureImageTemplateCustomizerClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerClearSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings SetQuery(this AzureImageTemplateCustomizerClearSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerClearSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings ResetQuery(this AzureImageTemplateCustomizerClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerClearSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings SetVerbose(this AzureImageTemplateCustomizerClearSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerClearSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerClearSettings ResetVerbose(this AzureImageTemplateCustomizerClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageTemplateCustomizerRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageTemplateCustomizerRemoveSettingsExtensions
    {
        #region CustomizerName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerRemoveSettings.CustomizerName"/></em></p>
        ///   <p>Name of the customizer.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings SetCustomizerName(this AzureImageTemplateCustomizerRemoveSettings toolSettings, string customizerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomizerName = customizerName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerRemoveSettings.CustomizerName"/></em></p>
        ///   <p>Name of the customizer.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings ResetCustomizerName(this AzureImageTemplateCustomizerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomizerName = null;
            return toolSettings;
        }
        #endregion
        #region Defer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerRemoveSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings SetDefer(this AzureImageTemplateCustomizerRemoveSettings toolSettings, string defer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = defer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerRemoveSettings.Defer"/></em></p>
        ///   <p>Temporarily store the object in the local cache instead of sending to Azure. Use `az cache` commands to view/clear.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings ResetDefer(this AzureImageTemplateCustomizerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defer = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerRemoveSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings SetIds(this AzureImageTemplateCustomizerRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerRemoveSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings SetIds(this AzureImageTemplateCustomizerRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateCustomizerRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings AddIds(this AzureImageTemplateCustomizerRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureImageTemplateCustomizerRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings AddIds(this AzureImageTemplateCustomizerRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureImageTemplateCustomizerRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings ClearIds(this AzureImageTemplateCustomizerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateCustomizerRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings RemoveIds(this AzureImageTemplateCustomizerRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureImageTemplateCustomizerRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings RemoveIds(this AzureImageTemplateCustomizerRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerRemoveSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings SetName(this AzureImageTemplateCustomizerRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerRemoveSettings.Name"/></em></p>
        ///   <p>The name of the image template.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings ResetName(this AzureImageTemplateCustomizerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings SetResourceGroup(this AzureImageTemplateCustomizerRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings ResetResourceGroup(this AzureImageTemplateCustomizerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings SetSubscription(this AzureImageTemplateCustomizerRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings ResetSubscription(this AzureImageTemplateCustomizerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings SetDebug(this AzureImageTemplateCustomizerRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings ResetDebug(this AzureImageTemplateCustomizerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings SetHelp(this AzureImageTemplateCustomizerRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings ResetHelp(this AzureImageTemplateCustomizerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings SetOutput(this AzureImageTemplateCustomizerRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings ResetOutput(this AzureImageTemplateCustomizerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings SetQuery(this AzureImageTemplateCustomizerRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings ResetQuery(this AzureImageTemplateCustomizerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureImageTemplateCustomizerRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings SetVerbose(this AzureImageTemplateCustomizerRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureImageTemplateCustomizerRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureImageTemplateCustomizerRemoveSettings ResetVerbose(this AzureImageTemplateCustomizerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region ImageCreateHyperVGeneration
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ImageCreateHyperVGeneration>))]
    public partial class ImageCreateHyperVGeneration : Enumeration
    {
        public static ImageCreateHyperVGeneration v1 = new ImageCreateHyperVGeneration { Value = "v1" };
        public static ImageCreateHyperVGeneration v2 = new ImageCreateHyperVGeneration { Value = "v2" };
    }
    #endregion
    #region ImageCreateOsDiskCaching
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ImageCreateOsDiskCaching>))]
    public partial class ImageCreateOsDiskCaching : Enumeration
    {
        public static ImageCreateOsDiskCaching none = new ImageCreateOsDiskCaching { Value = "none" };
        public static ImageCreateOsDiskCaching readonly_ = new ImageCreateOsDiskCaching { Value = "readonly" };
        public static ImageCreateOsDiskCaching readwrite = new ImageCreateOsDiskCaching { Value = "readwrite" };
    }
    #endregion
    #region ImageCreateOsType
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ImageCreateOsType>))]
    public partial class ImageCreateOsType : Enumeration
    {
        public static ImageCreateOsType linux = new ImageCreateOsType { Value = "linux" };
        public static ImageCreateOsType windows = new ImageCreateOsType { Value = "windows" };
    }
    #endregion
    #region ImageCreateStorageSku
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ImageCreateStorageSku>))]
    public partial class ImageCreateStorageSku : Enumeration
    {
        public static ImageCreateStorageSku premium_lrs = new ImageCreateStorageSku { Value = "premium_lrs" };
        public static ImageCreateStorageSku standardssd_lrs = new ImageCreateStorageSku { Value = "standardssd_lrs" };
        public static ImageCreateStorageSku standard_lrs = new ImageCreateStorageSku { Value = "standard_lrs" };
        public static ImageCreateStorageSku ultrassd_lrs = new ImageCreateStorageSku { Value = "ultrassd_lrs" };
    }
    #endregion
    #region ImageTemplateCustomizerAddType
    /// <summary>
    ///   Used within <see cref="AzureImageTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ImageTemplateCustomizerAddType>))]
    public partial class ImageTemplateCustomizerAddType : Enumeration
    {
        public static ImageTemplateCustomizerAddType file = new ImageTemplateCustomizerAddType { Value = "file" };
        public static ImageTemplateCustomizerAddType powershell = new ImageTemplateCustomizerAddType { Value = "powershell" };
        public static ImageTemplateCustomizerAddType shell = new ImageTemplateCustomizerAddType { Value = "shell" };
        public static ImageTemplateCustomizerAddType windows_restart = new ImageTemplateCustomizerAddType { Value = "windows-restart" };
    }
    #endregion
}
